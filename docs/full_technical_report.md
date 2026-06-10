# Malware Analysis Report: Deep Static Analysis

**Analysis type:** offline static reverse engineering
**Verified:** 2026-06-10
**Sample chain:** `hack_start.txt` -> `payload.bin` -> `stage4.exe` ->
`my_s_real.bin`

## Executive Summary

The investigated folder contains a multi-stage infostealer chain. The initial
PowerShell stager downloads bytes from a disguised `.png` URL and executes the
response in memory. The verified 53,323 byte payload is Donut-style shellcode
that decrypts an embedded PE (`stage4.exe`). `stage4.exe` exposes WinHTTP,
registry, token, process enumeration, and process-injection API imports. The
final payload is an obfuscated PE/.NET stage whose constants can be decoded
offline from the decompiled C# source.

The repository now includes reproducibility scripts:

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
python scripts\decode_constants.py --grep "91.92"
```

## Stage 0: PowerShell Stager

`hack_start.txt` contains a PowerShell loader that:

* requests `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png`
* compiles C# through `Add-Type`
* imports `VirtualAlloc`, `CreateThread`, and `WaitForSingleObject`
* copies downloaded bytes into executable memory with `Marshal.Copy`
* starts the buffer as a thread

This is a direct in-memory shellcode execution pattern.

## Stage 1: Donut Shellcode

Verified local sample:

* file: `payload.bin`
* size: 53,323 bytes
* SHA256:
  `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC`

The current local `my_newest_ll.png` is a 286 byte HTML decoy. The actual
shellcode bytes are `payload.bin` and `my_newest_ll_53323.bin`.

The Donut decryptor uses:

* key offset: `0x09`
* nonce/counter offset: `0x19`
* ciphertext offset: `0x241`
* Chaskey-style core in counter mode

Decryption output:

* decrypted blob size: 52,746 bytes
* embedded `MZ` offset: `4172`
* extracted PE size: 48,574 bytes
* extracted PE SHA256:
  `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26`

## Stage 2: Native Injector / Downloader (`stage4.exe`)

Verified PE metadata:

* file: `stage4.exe`
* architecture: x64 (`Machine: 0x8664`)
* sections: `.text`, `.data`, `.rdata`, `.pdata`, `.xdata`, `.bss`, `.idata`,
  `.tls`, `.reloc`

Verified imports:

* `ADVAPI32.dll!OpenProcessToken`
* `ADVAPI32.dll!RegOpenKeyExW`
* `ADVAPI32.dll!RegQueryValueExW`
* `KERNEL32.dll!CreateRemoteThread`
* `KERNEL32.dll!CreateToolhelp32Snapshot`
* `KERNEL32.dll!OpenProcess`
* `KERNEL32.dll!VirtualAllocEx`
* `KERNEL32.dll!WriteProcessMemory`
* `WINHTTP.dll!WinHttpConnect`
* `WINHTTP.dll!WinHttpOpen`
* `WINHTTP.dll!WinHttpOpenRequest`
* `WINHTTP.dll!WinHttpReadData`
* `WINHTTP.dll!WinHttpSendRequest`

Verified strings:

* `svchost.exe`
* `powershell`
* `158.94.208.104`
* `GET`
* `Control Panel\International\Geo`
* `Name`
* `RU`, `BY`, `US`, `CA`
* `x7GkP2mQ9zL4/my_s.bin`
* `x7GkP2mQ9zL4/my_downloader.bin`

Assessment: imports and strings support process injection capability, WinHTTP
download behavior, and geo-registry access. Static disassembly around RVA
`0x1ac8-0x1c31` shows `RU`/`BY` trigger early exit. The primary path
`my_s.bin` is attempted after the geo check, and the second path
`my_downloader.bin` is attempted only for the `US`/`CA` branch.

## Stage 3: Final Payload (`my_s_real.bin`)

Verified local sample:

* size: 312,832 bytes
* SHA256:
  `0A60144D4C1554223E78AD52B31BA5E15284CC7DF18A77D3DD90CBCC7D428C11`
* architecture: x64 PE wrapper

The decompiled C# source contains a custom constant decoder. The repository
script `scripts/decode_constants.py` verifies:

* 787 encoded constant calls
* 228 string decode calls
* 120 unique non-empty decoded strings in the current source

`my_s_real.bin` embeds the inner .NET payload at offset `0x1ba40`. Slicing from
that offset to EOF matches `inner_payload.bin`:

* embedded inner size: 199,616 bytes
* embedded inner SHA256:
  `E6257DE7191D7E9D9E7334FDD434631EE0C2F37BF3BDB82239F032A17F836C34`
* `.NET` COM descriptor RVA: `0x2000`

The string/primitive constant protection is not AES. It is a custom scheme:
shuffled hex decoding, header/checksum validation, a 256 byte substitution
table, rolling arithmetic, XOR, and rotates. AES appears separately in the
source through `AesManaged`, `CreateEncryptor`, and `CreateDecryptor`; the exact
C2 framing should be documented only after protocol reconstruction.

## Decoded Final-Stage Configuration and Capabilities

Verified decoded strings include:

### Network

* `91.92.243.161:3038`

### System Fingerprinting

* `root\CIMV2`
* `Win32_OperatingSystem`
* `Win32_Processor`
* `Win32_VideoController`
* `Win32_ComputerSystem`
* `OSArchitecture`, `Caption`, `Version`, `Name`, `UserName`

### Browser and Credential Artifacts

* Chromium-style: `Login Data`, `Local State`, `Cookies`, `Web Data`,
  `Preferences`, `Local Storage`, `IndexedDB`, `Sync Extension Settings`,
  `chrome-extension_`, `app_bound_encrypted_key`
* Firefox-style: `cookies.sqlite`, `formhistory.sqlite`, `places.sqlite`,
  `key4.db`

### Application Artifacts

* Steam: `Steam`, `config.vdf`, `loginusers.vdf`, `local.vdf`
* Telegram: `Telegram Desktop UWP`, `telegram`, `tdata`
* Discord: `discord`, `leveldb`

### Execution and Cleanup

* `powershell.exe`
* `WindowsPowerShell`
* `-ExecutionPolicy Bypass -File "`
* `cmd.exe`
* `ping 1.1.1.1 & del "`
* `CreateProcess`
* `VirtualAllocEx`
* `WriteProcessMemory`

## Defensive Recommendations

* Isolate suspected hosts from the network.
* Block or monitor outbound traffic to `158.94.208.104` and
  `91.92.243.161:3038`.
* Hunt for PowerShell using `Add-Type` plus `VirtualAlloc` and `CreateThread`.
* Hunt for HTTP user agents or processes contacting the staging URL paths.
* Rotate browser-saved credentials, cookies/session tokens, Steam credentials,
  Telegram sessions, and Discord tokens for any affected host.
* Use `docs/evidence_matrix.md` before converting any claim into a detection
  rule; it identifies which claims are verified and which remain partial.

## Residual Uncertainty

The current scripts verify the main chain and decoded final-stage strings. They
do not yet fully reconstruct:

1. exact C2 packet framing and AES key lifecycle
2. every runtime branch in the final-stage obfuscated code

Those should be handled as follow-up reverse-engineering tasks, not assumed.
