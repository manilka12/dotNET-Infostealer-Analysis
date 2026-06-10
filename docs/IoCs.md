# IoCs

If you're hunting for this, here's what to look for.

### C2 Infrastructure
- `158.94.208.104` -> This is the initial staging server. It serves the Donut shellcode and the .NET payload. It actively blocks scanners by 302 redirecting them to `cloudflare.com`.
- `91.92.243.161` (Port 3038) -> This is the final exfiltration server where the stolen data is sent. 

### URLs
- `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png` -> Serves the Donut Shellcode Loader (53 KB)
- `http://158.94.208.104/x7GkP2mQ9zL4/my_s.bin` -> Serves the Final .NET Infostealer (312 KB)
- `http://158.94.208.104/x7GkP2mQ9zL4/my_downloader.bin` -> Was likely a secondary payload, but the server just 404s it now. 

### Dropped Files / Artifacts
- `hack2.txt` / `hack2.ps1` -> The initial downloader script.
- `my_newest_ll.png` / `payload.bin` -> The 53 KB Donut shellcode. 
- `stage4.exe` -> The 48 KB C++ injector embedded inside the Donut payload.
- `my_s_real.bin` -> The 312 KB .NET payload.

### TTPs / Behaviors to alert on
- PowerShell calling `Add-Type` to dynamically load C# code that imports `VirtualAlloc` and `CreateThread`. It's a dead giveaway for memory injection.
- The injector reads `HKCU\Control Panel\International\Geo\Name` to build its HTTP User-Agent. Look for outbound HTTP requests where the User-Agent is just a raw country code (e.g., `US`, `FR`).
- Outbound requests with the exact User-Agent `powershell` (all lowercase, no version info) hitting suspicious IPs.
- **Persistence:** Manipulates the Windows Registry (`Registry.LocalMachine.OpenSubKey`) to ensure it runs across reboots.
- **Evasion:** Loops through running processes (`Process.GetProcesses()`) to detect and terminate analysis tools.
- **App-Bound Bypass:** Interacts with the Chrome COM `IElevator` service to request decrypted App-Bound keys without needing direct code injection.

### Encryption Details
- The .NET payload encrypts all its strings. The AES key is hardcoded: `B025011E705D8869AE4F29F083465799465EE53648465ECA3E706AC49D7DA7DB`.
