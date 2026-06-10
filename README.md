# Infostealer Malware Analysis Report

## Overview
This repository contains a comprehensive technical analysis of a multi-stage Infostealer malware campaign. The analysis was conducted in a controlled sandbox environment. 

**Disclaimer:** This repository contains analysis, findings, and Indicators of Compromise (IoCs) intended for educational and defensive purposes. Live, weaponized malware binaries have been intentionally omitted to prevent misuse and comply with GitHub's Terms of Service regarding the distribution of malicious code.

## Infection Chain
1. **Initial Vector:** A PowerShell script (`hack2.txt`) uses `Invoke-WebRequest` to download an image file (`my_newest_ll.png`).
2. **First Stage Payload:** The `.png` file is actually a **Donut Shellcode Loader** (53 KB). It is executed dynamically in memory via `VirtualAlloc` and `CreateThread`.
3. **Injector Module:** The shellcode executes `stage4.exe` (a native C++ executable). This module retrieves the infected machine's ISO Country Code (e.g., `US`, `LK`) via the `GetGeoInfo` API.
4. **C2 Evasion & Secondary Payloads:** The injector downloads secondary payloads using WinHTTP. 
   - **Evasion Mechanism:** The C2 server strictly validates the HTTP `User-Agent`. Requests from automated scanners or generic browsers receive an HTTP `302 Found` redirect to the legitimate `https://cloudflare.com` homepage (acting as a decoy 1.3 MB file).
   - Sending the correct User-Agent (`powershell`) successfully retrieves the final payload (`my_s.bin`).
5. **Final Stage (Infostealer):** `my_s_real.bin` is a heavily obfuscated 312 KB `.NET` assembly. At runtime, it utilizes an embedded AES routine to decrypt strings and targets sensitive applications (Chrome App-Bound Encryption bypass, Steam configuration, etc.).

## Contents
* `docs/audit.md`: The complete, step-by-step reverse engineering audit and findings.
* `docs/IoCs.md`: Indicators of Compromise (IPs, URLs, Hashes) for threat hunting.
* `source_code/infostealer_decompiled.cs`: The fully decompiled 15,000+ line C# source code of the final stage payload.
* `source_code/hack2_defanged.ps1`: A safe, defanged version of the initial PowerShell delivery script.
* `scripts/donut_decrypt.py`: Python script used to decrypt the Chaskey-encrypted Donut shellcode.
* `scripts/string_decryptor.py`: Python script used to bypass the AES-256 string encryption used in the final stage payload.

## Defense & Mitigation
Security teams can use the provided IoCs to build detection rules (such as YARA or Snort) to block the C2 IP addresses and monitor for PowerShell processes making outbound HTTP requests with the observed User-Agents.
