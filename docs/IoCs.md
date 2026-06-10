# Indicators of Compromise and Hunting Leads

## Infrastructure

| Indicator | Type | Confidence | Notes |
| --- | --- | --- | --- |
| `158.94.208.104` | IP | Verified | Staging server in the PowerShell stager and `stage4.exe` strings. |
| `91.92.243.161:3038` | IP:port | Verified decoded constant | Final-stage C2 string decoded from `infostealer_decompiled.cs` with `scripts/decode_constants.py`. |
| `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png` | URL | Verified | Initial stager URL. Response content appears user-agent or server-state dependent. |
| `http://158.94.208.104/x7GkP2mQ9zL4/my_s.bin` | URL path | Verified in `stage4.exe` strings | Secondary payload path. |
| `http://158.94.208.104/x7GkP2mQ9zL4/my_downloader.bin` | URL path | Verified in `stage4.exe` strings | Additional staged path. |

## File Hashes

| File | SHA256 | Notes |
| --- | --- | --- |
| `hack_start.txt` | `DE089C557486415A2C0A25CF557D07C47C6B68F97731C83A059BC839C58EA11B` | Saved PowerShell in-memory loader. |
| `payload.bin` | `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC` | 53,323 byte shellcode-like Donut payload. |
| `my_newest_ll_53323.bin` | `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC` | Same bytes as `payload.bin`. |
| `stage4.exe` | `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26` | PE extracted from decrypted Donut payload. |
| `my_s_real.bin` | `0A60144D4C1554223E78AD52B31BA5E15284CC7DF18A77D3DD90CBCC7D428C11` | Final-stage PE evidence. |
| `my_newest_ll.png` | `2675A1EB0A3881757ADB4D7838A1923D929BCBBA3F8DDC440D305DA7CF9CA020` | Current local 286 byte HTML decoy, not the shellcode bytes. |
| `my_newest_ll_1370756.bin` | `D0A6EFE1BCCF92E2C5B6B478A485FEDEF30EB20A2F3151BD1D511FC53BA7F617` | Larger HTML/decoy response. |

## Host and Process Indicators

High-confidence behavior:

* PowerShell script using `Invoke-WebRequest`, `Add-Type`, `VirtualAlloc`,
  `Marshal.Copy`, and `CreateThread` in the same execution chain.
* Outbound HTTP to `158.94.208.104` from PowerShell or an injected process.
* PE imports in `stage4.exe`: `VirtualAllocEx`, `WriteProcessMemory`,
  `CreateRemoteThread`, `CreateToolhelp32Snapshot`, `OpenProcess`,
  `WinHttpOpen`, `WinHttpConnect`, `WinHttpOpenRequest`, `WinHttpSendRequest`,
  `WinHttpReadData`, `RegOpenKeyExW`, and `RegQueryValueExW`.
* Strings in `stage4.exe`: `svchost.exe`, `powershell`,
  `Control Panel\International\Geo`, `x7GkP2mQ9zL4/my_s.bin`, and
  `x7GkP2mQ9zL4/my_downloader.bin`.

Decoded final-stage strings useful for hunting:

* Network: `91.92.243.161:3038`
* WMI/fingerprinting: `root\CIMV2`, `Win32_OperatingSystem`,
  `Win32_Processor`, `Win32_VideoController`, `Win32_ComputerSystem`
* Browser data: `Login Data`, `Local State`, `Cookies`, `Web Data`,
  `Preferences`, `cookies.sqlite`, `formhistory.sqlite`, `places.sqlite`,
  `key4.db`, `app_bound_encrypted_key`, `chrome-extension_`
* Apps: `Steam`, `config.vdf`, `loginusers.vdf`, `Telegram Desktop UWP`,
  `telegram`, `discord`
* Execution/deletion: `powershell.exe`, `WindowsPowerShell`, `cmd.exe`,
  `-ExecutionPolicy Bypass -File "`, `ping 1.1.1.1 & del "`

## Verification

Reproduce the current IoCs with:

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
python scripts\decode_constants.py --grep "91.92"
```
