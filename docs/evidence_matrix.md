# Evidence Matrix

**Verification date:** 2026-06-10  
**Local lab root:** `C:\Users\temp\malware_lab`  
**Mode:** offline static analysis and byte decryption only. No native malware
execution and no network calls to attacker infrastructure.

## Primary Reproduction Commands

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
python scripts\decode_constants.py --grep "91.92"
python -m unittest discover -s tests
```

## Claim Status

| Claim | Status | Evidence |
| --- | --- | --- |
| `hack_start.txt` is a PowerShell in-memory loader | Verified | `reproduce_chain.py` detects the staging URL, `Invoke-WebRequest`, `Add-Type`, `VirtualAlloc`, `Marshal.Copy`, and `CreateThread`. SHA256: `DE089C557486415A2C0A25CF557D07C47C6B68F97731C83A059BC839C58EA11B`. |
| The staging URL is `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png` | Verified | Present in `hack_start.txt`; extracted by `reproduce_chain.py`. |
| Current local `my_newest_ll.png` is the shellcode payload | False for current folder | Current local `my_newest_ll.png` is 286 bytes and begins with HTML. SHA256: `2675A1EB0A3881757ADB4D7838A1923D929BCBBA3F8DDC440D305DA7CF9CA020`. |
| `payload.bin` / `my_newest_ll_53323.bin` is the shellcode payload | Verified | Both are 53,323 bytes and share SHA256 `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC`. |
| Donut payload decrypts to an embedded PE | Verified | Decryptor output size: 52,746 bytes. `MZ` found at offset `4172`. |
| Extracted PE matches `stage4.exe` | Verified | Extracted PE SHA256 equals local `stage4.exe` SHA256: `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26`. |
| `stage4.exe` uses process injection APIs | Verified imports | PE imports include `OpenProcess`, `VirtualAllocEx`, `WriteProcessMemory`, and `CreateRemoteThread`. Imports prove capability surface, not runtime branch execution. |
| `stage4.exe` uses WinHTTP for staging traffic | Verified imports and strings | Imports include `WinHttpOpen`, `WinHttpConnect`, `WinHttpOpenRequest`, `WinHttpSendRequest`, and `WinHttpReadData`. Strings include `158.94.208.104`, `x7GkP2mQ9zL4/my_s.bin`, and `x7GkP2mQ9zL4/my_downloader.bin`. |
| `stage4.exe` reads geo registry data | Verified imports and strings | Imports include `RegOpenKeyExW` and `RegQueryValueExW`; strings include `Control Panel\International\Geo`. Exact branch decisions were not fully lifted in this pass. |
| `stage4.exe` exits early for RU/BY | Verified by static lift | Wide strings include `RU` and `BY`. Disassembly around RVA `0x1ac8-0x1c31` checks the geo `Name` value and exits before payload download when it matches either code. |
| `stage4.exe` attempts the second downloader only for US/CA | Verified by static lift | Disassembly around RVA `0x1b8a-0x1c20` compares the geo `Name` value with `US` and `CA`; the `my_downloader.bin` path is reached only when that branch enables the second payload flag. |
| Final payload contains encoded constants | Verified | `decode_constants.py` finds 787 `flag6144` constant calls and 228 string decode calls. |
| Final C2 is `91.92.243.161:3038` | Verified decoded constant | `decode_constants.py --grep "91.92"` decodes this exact string from `infostealer_decompiled.cs`. |
| Final payload uses WMI fingerprinting | Verified decoded constants | Decoded strings include `root\CIMV2`, `Win32_OperatingSystem`, `Win32_Processor`, `Win32_VideoController`, and `Win32_ComputerSystem`. |
| Final payload targets browser data | Verified decoded constants | Decoded strings include `Login Data`, `Local State`, `Cookies`, `Web Data`, `Preferences`, `cookies.sqlite`, `formhistory.sqlite`, `places.sqlite`, `key4.db`, `app_bound_encrypted_key`, and `chrome-extension_`. |
| Final payload targets Steam, Telegram, and Discord | Verified decoded constants | Decoded strings include `Steam`, `config.vdf`, `loginusers.vdf`, `Telegram Desktop UWP`, `telegram`, and `discord`. |
| Final payload contains self-deletion behavior | Verified decoded constants/source | Decoded strings include `cmd.exe`, `/C`, and `ping 1.1.1.1 & del "`. |
| Final payload has injection/execution capability | Verified decoded constants/source | Decoded strings include `VirtualAllocEx`, `WriteProcessMemory`, `CreateProcess`, `powershell.exe`, and `-ExecutionPolicy Bypass -File "`. This verifies capability strings and related source structure, not that every path runs in all environments. |
| `my_s_real.bin` embeds the decompiled .NET payload | Verified | `my_s_real.bin` has an embedded `MZ` at offset `0x1ba40`; slicing from that offset to EOF matches `inner_payload.bin` SHA256 `E6257DE7191D7E9D9E7334FDD434631EE0C2F37BF3BDB82239F032A17F836C34`. |
| C2 transport encryption is AES-CBC | Partially verified | Source uses `AesManaged`, generates IVs, and calls `CreateEncryptor`/`CreateDecryptor`. The exact protocol framing and key lifecycle need deeper packet/protocol reconstruction before stronger wording. |

## Hashes

| File | Size | SHA256 | Notes |
| --- | ---: | --- | --- |
| `hack_start.txt` | 1,611 | `DE089C557486415A2C0A25CF557D07C47C6B68F97731C83A059BC839C58EA11B` | Saved PowerShell stager. |
| `payload.bin` | 53,323 | `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC` | Shellcode-like Donut payload bytes. |
| `my_newest_ll_53323.bin` | 53,323 | `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC` | Same bytes as `payload.bin`. |
| `stage4.exe` | 48,574 | `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26` | Extracted PE from decrypted Donut payload. |
| `my_s_real.bin` | 312,832 | `0A60144D4C1554223E78AD52B31BA5E15284CC7DF18A77D3DD90CBCC7D428C11` | Final-stage PE wrapper / .NET payload evidence. |
| `my_newest_ll.png` | 286 | `2675A1EB0A3881757ADB4D7838A1923D929BCBBA3F8DDC440D305DA7CF9CA020` | Current local HTML decoy response. |
| `my_newest_ll_1370756.bin` | 1,370,756 | `D0A6EFE1BCCF92E2C5B6B478A485FEDEF30EB20A2F3151BD1D511FC53BA7F617` | Larger HTML/decoy response. |

## Remaining Work

The current repo now reproduces the major static claims. The remaining items
that would benefit from deeper work are:

1. Reconstruct final C2 packet framing around `AesManaged` to document the exact
   transport sequence defensively.
2. Add YARA/Sigma/Splunk detections from the verified strings and imports.
