# Investigation Audit Log

**Case:** Multi-stage .NET infostealer
**Analyst:** manilka12
**Updated verification:** 2026-06-10
**Method:** offline static analysis, byte decryption, PE parsing, and source
constant decoding. No native malware execution and no C2 contact.

## Reproduction Baseline

Run from the repository root:

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
python scripts\decode_constants.py --grep "91.92"
python -m unittest discover -s tests
```

The current verified pipeline reports:

* `payload.bin` SHA256:
  `9BB96FA6AEE45120D14660506320932691310ADEF4353E684775F590A17C22FC`
* Donut-decrypted blob size: 52,746 bytes
* Embedded `MZ` offset: `4172`
* Extracted `stage4.exe` SHA256:
  `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26`
* Extracted `stage4.exe` matches the local `stage4.exe`: `True`
* Final-stage encoded constants: 787 total calls, 228 string calls

## Phase 0: Initial Triage and PowerShell Stager

The saved file `hack_start.txt` is a PowerShell stager, not an inert text note.
It contains:

* URL: `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png`
* `Invoke-WebRequest`
* dynamic C# compilation through `Add-Type`
* Win32 interop declarations for `VirtualAlloc`, `CreateThread`, and
  `WaitForSingleObject`
* `Marshal.Copy` of downloaded bytes into executable memory

Conclusion: verified PowerShell in-memory shellcode loader.

Important correction: the current local `my_newest_ll.png` is a 286 byte HTML
decoy response. The actual 53,323 byte shellcode bytes are represented by
`payload.bin` and `my_newest_ll_53323.bin`.

## Phase 1: Donut Shellcode and `stage4.exe`

The shellcode is decrypted by the Chaskey-style Donut routine in
`scripts/donut_decrypt.py` and `scripts/reproduce_chain.py`.

Verified outputs:

* key offset: `0x09`
* nonce/counter offset: `0x19`
* ciphertext offset: `0x241`
* decrypted blob size: 52,746 bytes
* embedded `MZ` offset: `4172`
* extracted PE size: 48,574 bytes
* extracted PE hash matches local `stage4.exe`

`stage4.exe` PE imports verify the capability surface:

* process/toolhelp: `CreateToolhelp32Snapshot`, `OpenProcess`
* remote memory/thread: `VirtualAllocEx`, `WriteProcessMemory`,
  `CreateRemoteThread`
* WinHTTP: `WinHttpOpen`, `WinHttpConnect`, `WinHttpOpenRequest`,
  `WinHttpSendRequest`, `WinHttpReadData`
* registry: `RegOpenKeyExW`, `RegQueryValueExW`
* privilege/token: `OpenProcessToken`

`stage4.exe` wide strings include:

* `svchost.exe`
* `powershell`
* `158.94.208.104`
* `GET`
* `Control Panel\International\Geo`
* `Name`
* `RU`, `BY`, `US`, `CA`
* `x7GkP2mQ9zL4/my_s.bin`
* `x7GkP2mQ9zL4/my_downloader.bin`

Evidence supports staging, WinHTTP download behavior, geo-registry access, and
process injection capability. Static disassembly around RVA `0x1ac8-0x1c31`
shows `RU`/`BY` trigger early exit, while the second downloader path is reached
only for the `US`/`CA` branch.

## Phase 2: Final Payload Constant Decoding

The final-stage C# source uses `flag6144`/`text872` helpers for constants. The
offline decoder in `scripts/decode_constants.py` ports the decompiled algorithm:

1. shuffled hexadecimal nibble ordering
2. header validation and checksum
3. 256 byte substitution table rebuilt from the decompiled string literal
4. rolling byte arithmetic, XOR, and rotate operations

This is not AES string encryption. AES appears in the source for runtime
transport/data handling, while string and primitive constants use the custom
decoder above.

Verified decoded strings include:

* C2: `91.92.243.161:3038`
* WMI: `root\CIMV2`, `Win32_OperatingSystem`, `Win32_Processor`,
  `Win32_VideoController`, `Win32_ComputerSystem`
* browsers: `Login Data`, `Local State`, `Cookies`, `Web Data`, `Preferences`,
  `cookies.sqlite`, `formhistory.sqlite`, `places.sqlite`, `key4.db`,
  `app_bound_encrypted_key`, `chrome-extension_`
* apps: `Steam`, `config.vdf`, `loginusers.vdf`, `Telegram Desktop UWP`,
  `telegram`, `discord`
* execution/deletion: `powershell.exe`, `WindowsPowerShell`, `cmd.exe`,
  `-ExecutionPolicy Bypass -File "`, `ping 1.1.1.1 & del "`

## Phase 3: Current Confidence

Verified:

* PowerShell stager behavior
* Donut decryptor offsets and extracted PE
* `stage4.exe` import surface, staging strings, User-Agent, and geo branch
* final C2 string and stealing targets via decoded constants
* process execution and self-deletion strings in final-stage source
* final wrapper embedded .NET payload at offset `0x1ba40`

Partially verified / needs deeper lifting:

* exact AES-CBC protocol framing and key lifecycle
* exact runtime ordering of all final-stage capabilities

## Conclusion

The folder contains enough local evidence to verify the multi-stage chain from
`hack_start.txt` through Donut shellcode, `stage4.exe`, and the final obfuscated
.NET payload. The repo now includes scripts and tests that reproduce the major
claims without executing the malware.
