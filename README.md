# Infostealer Malware Analysis Report

## Overview
This repository contains a defensive, reproducible analysis of a multi-stage
infostealer chain. Live malware binaries are intentionally omitted from the
GitHub repository; the scripts expect the analyst to provide local samples in a
separate lab folder.

The local lab used for the current verification was `C:\Users\temp\malware_lab`.
The analysis was performed offline: no native malware execution and no C2
network contact.

## Reproduce the Evidence
Run the full offline evidence pipeline from the repository root:

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
```

Run the final-stage constant decoder directly:

```powershell
python scripts\decode_constants.py --grep "91.92"
python scripts\decode_constants.py --grep "Login Data"
```

Run tests for the analysis tooling:

```powershell
python -m unittest discover -s tests
```

## Verified Infection Chain
1. **Initial vector:** `hack_start.txt` is a PowerShell in-memory loader. It
   downloads from `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png`, compiles
   C# with `Add-Type`, allocates executable memory with `VirtualAlloc`, copies
   response bytes with `Marshal.Copy`, and starts them with `CreateThread`.
2. **Stage 1 shellcode:** `payload.bin` / `my_newest_ll_53323.bin` is a 53,323
   byte shellcode-like blob. The current local `my_newest_ll.png` is a 286 byte
   HTML decoy response, not the shellcode bytes.
3. **Donut decryptor:** `scripts/reproduce_chain.py` uses the Chaskey-style
   Donut decryptor from `scripts/donut_decrypt.py`. It decrypts 52,746 bytes,
   finds an `MZ` header at offset `4172`, and extracts `stage4.exe`.
4. **Stage 2 injector:** the extracted `stage4.exe` hash matches the local
   `stage4.exe`. PE imports verify WinHTTP, registry access, token privilege
   adjustment, process enumeration, remote allocation/write, and remote thread
   creation APIs.
5. **Final stage:** `my_s_real.bin` is a 312,832 byte PE. The decompiled C#
   contains 787 encoded constants, including 228 string decode calls. The offline
   decoder verifies the final C2 string `91.92.243.161:3038`, WMI class names,
   browser artifacts, Steam/Telegram/Discord artifacts, and self-deletion strings.

## Contents
* `docs/evidence_matrix.md`: claim-by-claim evidence, commands, and confidence.
* `docs/chain_walkthrough.md`: exact stage-by-stage walkthrough from stager to
  final payload.
* `docs/audit.md`: reverse-engineering audit notes with verified updates.
* `docs/IoCs.md`: hashes, URLs, IPs, decoded strings, and hunting leads.
* `docs/full_technical_report.md`: static technical report.
* `source_code/infostealer_decompiled.cs`: decompiled final-stage C#.
* `source_code/hack2_defanged.ps1`: defanged stager reference.
* `scripts/reproduce_chain.py`: A-to-Z offline reproduction pipeline.
* `scripts/decode_constants.py`: final-stage constant decoder.
* `scripts/donut_decrypt.py`: Donut Chaskey-style payload decryptor.

## Defensive Use Only
Use these artifacts for incident response, malware reverse engineering,
detection engineering, and recovery. The scripts are designed to parse and
decrypt local evidence without executing the malware or contacting attacker
infrastructure.
