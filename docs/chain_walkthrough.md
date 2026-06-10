# Chain Walkthrough: From Stager to Final Payload

**Scope:** local evidence in `C:\Users\temp\malware_lab`  
**Safety:** this walkthrough uses captured files only. Do not contact the live
C2 and do not execute the malware natively.

## 1. Initial PowerShell Stager

`hack_start.txt` is the first stage the attacker tried to run. The important
behavior is:

1. Define URL:
   `http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png`
2. Download bytes with `Invoke-WebRequest`.
3. Compile an in-memory C# helper via `Add-Type`.
4. Import `VirtualAlloc`, `CreateThread`, and `WaitForSingleObject`.
5. Copy the downloaded bytes into executable memory with `Marshal.Copy`.
6. Start the downloaded buffer with `CreateThread`.

The `.png` name is camouflage. The payload that matters is not a PNG image.

## 2. Which Saved Download Is Real?

The current folder contains multiple saved bodies from different attempts.

| File | Size | Role |
| --- | ---: | --- |
| `my_newest_ll.png` | 286 | HTML 302 redirect to Cloudflare decoy |
| `my_newest_ll.bin` | 286 | Same HTML 302 decoy |
| `my_newest_ll_1370756.bin` | 1,370,756 | Large Cloudflare HTML decoy |
| `payload.bin` | 53,323 | Actual shellcode-like Donut payload |
| `my_newest_ll_53323.bin` | 53,323 | Same bytes as `payload.bin` |
| `my_s.bin` | 286 | HTML 302 decoy, not final payload |
| `my_s_real.bin` | 312,832 | Actual recovered final wrapper/payload |
| `my_downloader.bin` | 286 | HTML 302 decoy |
| `my_downloader_real.bin` | 276 | HTML 404 failed payload |

This means the current folder proves that the server served decoys for many
requests. It also contains recovered real payload bodies, but they are the local
captured files `payload.bin`, `my_newest_ll_53323.bin`, and `my_s_real.bin`.

## 3. Donut Payload Decryption: How `stage4.exe` Is Extracted

There is no password brute forcing here. The Donut loader stores the decrypt
parameters inside the shellcode header.

For `payload.bin`:

* key offset: `0x09`
* key bytes: `e734e0f679d39295d39169b18cdae3c0`
* nonce/counter offset: `0x19`
* nonce/counter bytes: `3070d2760dcfc0750ec7fa21e3c71271`
* ciphertext offset: `0x241`
* ciphertext length: 52,746 bytes

The repo script `scripts/donut_decrypt.py` implements the Donut Chaskey-style
counter-mode decryptor:

1. Read the 16 byte key at `0x09`.
2. Read the 16 byte nonce/counter at `0x19`.
3. Treat bytes from `0x241` to EOF as ciphertext.
4. For each 16 byte block, run the Chaskey-style 16-round core over the counter
   block mixed with the key.
5. XOR the generated keystream with ciphertext.
6. Search the decrypted output for `MZ`.
7. Carve from the `MZ` offset to recover the PE.

Verified output:

* decrypted blob size: 52,746 bytes
* `MZ` offset in decrypted blob: `4172`
* extracted PE size: 48,574 bytes
* extracted PE SHA256:
  `4FE8D173468E95EF543AD7E96D7FB341E0C0458C901C2187BD770B5955D91E26`
* extracted PE matches local `stage4.exe`: yes

## 4. `stage4.exe`: User-Agent, Geo Branch, and Two Payload Paths

Static disassembly of `stage4.exe` shows the WinHTTP session setup:

* `WinHttpOpen` first argument: wide string `powershell`
* `WinHttpConnect` host: `158.94.208.104`
* `WinHttpConnect` port: `80`
* `WinHttpOpenRequest` method: `GET`

The wide strings present in `stage4.exe` include:

* `powershell`
* `158.94.208.104`
* `GET`
* `Control Panel\International\Geo`
* `Name`
* `RU`, `BY`, `US`, `CA`
* `x7GkP2mQ9zL4/my_s.bin`
* `x7GkP2mQ9zL4/my_downloader.bin`

The geo branch lifted from disassembly around RVA `0x1ac8-0x1c31` is:

1. Read `HKCU\Control Panel\International\Geo\Name`.
2. If the value is `RU` or `BY`, exit early.
3. Attempt primary payload path `x7GkP2mQ9zL4/my_s.bin`.
4. Attempt the second payload path `x7GkP2mQ9zL4/my_downloader.bin` only for
   the `US`/`CA` branch.

The folder did not recover a working second payload. The saved
`my_downloader_real.bin` is an Apache `404 Not Found` HTML body.

## 5. Final Wrapper and Embedded .NET Payload

`my_s_real.bin` is the recovered final wrapper:

* size: 312,832 bytes
* SHA256:
  `0A60144D4C1554223E78AD52B31BA5E15284CC7DF18A77D3DD90CBCC7D428C11`

It contains an embedded .NET PE at file offset `0x1ba40`. The repo script now
verifies that slicing from `0x1ba40` to EOF matches `inner_payload.bin`:

* embedded inner size: 199,616 bytes
* embedded inner SHA256:
  `E6257DE7191D7E9D9E7334FDD434631EE0C2F37BF3BDB82239F032A17F836C34`
* `.NET` COM descriptor RVA: `0x2000`

This inner payload is the decompiled source represented by
`source_code/infostealer_decompiled.cs`.

## 6. Final-Stage Constant Decoding

The final .NET stage uses custom constant encoding, not AES for strings. The
decoder in `scripts/decode_constants.py` reproduces the decompiled
`flag6144`/`text872` helpers:

1. Unshuffle encoded hex nibbles.
2. Validate a custom header/checksum.
3. Rebuild a 256 byte substitution table from the decompiled string literal.
4. Apply rolling arithmetic, XOR, and rotate operations.

Verified decoded results:

* 787 encoded constant calls
* 228 string decode calls
* final C2: `91.92.243.161:3038`
* browser artifacts: `Login Data`, `Local State`, `Cookies`, `Web Data`,
  `Preferences`, `cookies.sqlite`, `formhistory.sqlite`, `places.sqlite`,
  `key4.db`, `app_bound_encrypted_key`
* apps: `Steam`, `config.vdf`, `loginusers.vdf`, `Telegram Desktop UWP`,
  `telegram`, `discord`
* execution/deletion: `powershell.exe`, `cmd.exe`,
  `ping 1.1.1.1 & del "`

## 7. Reproduce Locally

Run:

```powershell
python scripts\reproduce_chain.py --lab-root C:\Users\temp\malware_lab
python scripts\decode_constants.py --grep "91.92"
python -m unittest discover -s tests
```
