# Analysis Notes

Just throwing my raw notes in here so I don't lose them.

**The Dropper (hack2.txt / PS)**
Grabbed the initial script from an infected box. It's a pretty standard PowerShell dropper that reaches out to `158.94.208.104` to pull down `my_newest_ll.png`. 
Obviously it's not a PNG. It uses `Add-Type` to compile some C# on the fly and calls `VirtualAlloc` and `CreateThread` to run the file straight in memory. Turns out the "PNG" is actually about 53 KB of Donut shellcode. 

**The C++ Injector (stage4.exe)**
Extracted the shellcode payload which ended up being a native C++ binary (`stage4.exe`). 
Reversing this was annoying without symbols, but I dumped the strings and checked the imports. It's heavily reliant on WinHTTP. 
The craziest part: it calls `GetGeoInfo` to pull the local machine's ISO country code (like `US`, `RU`, whatever) and uses that as the `User-Agent` to fetch the next payloads.

When I tried hitting the C2 with curl/python, the server just threw a `302 Found` and redirected me to `cloudflare.com` (giving me a 1.3 MB HTML file). The attackers literally set up their Apache server to redirect sandboxes and analysts to Cloudflare to troll them. 

After spoofing the requests and testing the exact User-Agents found in the binary strings, I figured out that passing `User-Agent: powershell` successfully bypasses the trap and downloads the real payload (`my_s.bin`). There was also a tertiary payload (`my_downloader.bin`) but the server just 404s on it now.

**The Final Payload (my_s_real.bin)**
`my_s.bin` is a 312 KB .NET binary. Heavily obfuscated. I dumped it into a decompiler (IL to C#) and pulled out about 15k lines of source.
All the important strings (registry paths, C2 IPs, target files) are encrypted. Found a static class handling the decryption at runtime with AES.
Key: `B025011E705D8869AE4F29F083465799465EE53648465ECA3E706AC49D7DA7DB`

I wrote a python script to emulate the decryption and ripped out all 127 strings. 
It's an infostealer. Hits Chrome App-Bound Encryption, Steam, etc. The final exfiltration C2 is `91.92.243.161:3038`.

**Persistence & Evasion Tactics (Confirmed in Source)**
- **Registry Persistence:** At line 968 of the decompiled code, it explicitly calls `Registry.LocalMachine.OpenSubKey` to manipulate the registry, embedding itself for persistence. This is not just a run-once grabber.
- **Process Evasion:** At line 13274, it calls `Process.GetProcesses()`. It actively hunts for and terminates analysis tools and debuggers.
- **Chrome Bypass:** To bypass Chrome's new App-Bound Encryption, it utilizes COM spoofing. Since it can't decrypt `Local State` directly, it interacts with Chrome's `IElevator` COM service to trick Windows into handing over the decrypted keys.
