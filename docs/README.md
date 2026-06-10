# Multi-Stage .NET Infostealer Analysis

Dumped some notes and scripts here from a recent malware investigation. I stumbled across a pretty nasty multi-stage infostealer that uses some interesting tricks to bypass analysis. 

**Note:** I didn't include the live binaries for obvious reasons, but the decrypted source, IoCs, and my decryption scripts are all in here. 

### The Infection Chain
1. Starts off with a basic PowerShell downloader (`hack2.ps1`). It pulls down what looks like a PNG (`my_newest_ll.png`), but it's actually just Donut shellcode (around 53 KB). The PS script compiles a C# class on the fly using `Add-Type` to inject and run the shellcode in memory.
2. The shellcode drops a native C++ injector (`stage4.exe`). This thing grabs your machine's geographic country code (like `US` or `LK`) using the Windows `GetGeoInfo` API.
3. **The anti-analysis trick:** The injector reaches out to the C2 using WinHTTP. If you hit the C2 with a normal browser User-Agent or curl, the server drops a `302 Found` and redirects you straight to `cloudflare.com` (serving you a benign 1.3 MB HTML file). It's a massive troll. 
4. If you hit it with the exact right User-Agent (it expects `powershell` for the payload), it drops the real goods: `my_s.bin`.

### The Payload
5. **Final Stage (Infostealer):** `my_s_real.bin` is a heavily obfuscated 312 KB `.NET` assembly. At runtime, it utilizes an embedded AES routine to decrypt strings and targets sensitive applications. 
   - **Persistence:** It actively manipulates the Windows Registry (`Registry.LocalMachine.OpenSubKey`) to maintain persistence.
   - **Evasion:** It calls `Process.GetProcesses()` to actively terminate analysis tools and debuggers.
   - **Chrome Bypass:** Bypasses Chrome's App-Bound Encryption by interacting directly with the `IElevator` COM service to decrypt the `Local State` key.

### What's in this repo?
* `docs/audit.md`: My raw analysis notes.
* `docs/IoCs.md`: IPs, URLs, and hashes. Block these.
* `source_code/infostealer_decompiled.cs`: The full 15k-line C# source of the final payload.
* `source_code/hack2_defanged.ps1`: The original PS dropper (commented out the execution lines so it's safe).
* `scripts/`: The python scripts I used to decrypt the Donut shellcode and the final AES strings.
