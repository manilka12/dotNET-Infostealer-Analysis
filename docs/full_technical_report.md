# Malware Analysis Report: Deep Static Analysis

**Analyst:** manilka12  
**Analysis Type:** Full Static Reverse Engineering (No Execution)  
**Sample Chain:** `payload.bin` -> `stage4.exe` -> `my_s_real.bin` 

---

## Executive Summary
The analyzed malware sample is a sophisticated, multi-stage loader and infostealer designed to bypass antivirus detection using encrypted shellcode, Geo-fencing evasion techniques, and process injection. The attack chain consists of three main stages:
1. **Initial Loader (`payload.bin`):** A custom Donut-generated shellcode wrapper that uses the Chaskey block cipher to hide the next stage.
2. **Injector Module (`stage4.exe`):** A native Windows executable responsible for environment checks, process injection (into `svchost.exe`), and primary C2 communication to download the payload.
3. **Final Stage Payload (`my_s_real.bin`):** An obfuscated .NET infostealer loaded directly into memory. Its strings and constants are obfuscated using a custom substitution cipher.

---

## Stage 1: Donut Shellcode Loader (`payload.bin`)
- **File Type:** Raw Shellcode / Encrypted Blob (53 KB)
- **Encryption Algorithm:** Chaskey Block Cipher
- **Mechanism:** The shellcode uses an egg-hunter/decoder stub to dynamically locate and decrypt the main executable in memory. The payload contains an embedded Windows executable (`stage4.exe`) which remains hidden from static AV scanners until decrypted at runtime.

---

## Stage 2: The Process Injector (`stage4.exe`)
- **File Type:** 64-bit PE Executable (Extracted from memory statically)
- **Primary Function:** Evasion and Initial Access staging.

**Key Capabilities Discovered:**
1. **Geo-Fencing & Evasion:** 
   The malware reads the Windows registry key `Control Panel\International\Geo\Name`. It explicitly checks for the country codes **`RU`** (Russia), **`BY`** (Belarus), **`US`**, and **`CA`**. If the victim's machine is located in the CIS region (RU/BY), the malware likely terminates itself.
2. **Process Injection:** 
   The binary actively searches the system for `svchost.exe` and `powershell.exe` to inject its malicious threads into legitimate Windows processes.
3. **Primary Download Server:** 
   Using `WINHTTP.dll`, the injected process establishes an HTTP connection to the staging server:
   - **Staging IP Address:** `158.94.208.104`
   - **Target Endpoints:** `/x7GkP2mQ9zL4/my_s.bin` and `/x7GkP2mQ9zL4/my_downloader.bin`

---

## Stage 3: The Final Payload (`my_s_real.bin`)
- **File Type:** Native Executable wrapper loading an Embedded .NET Assembly
- **Embedded .NET Offset:** `0x1ba40`
- **Primary Function:** Comprehensive Information Stealing & Remote Code Execution

**Full Decoded Configuration & Capabilities:**
By successfully reverse-engineering the custom constant obfuscation routine built into the .NET assembly, the true configuration and capabilities of the final payload were extracted. The malware replaces all strings and constants with method calls that decode shuffled hex ciphertext using a custom 256-byte substitution table and bitwise math. A total of 787 encoded constants (including 228 strings) were identified.

### 1. Actual Command & Control (C2) Server
The final payload stops communicating with `158.94.208.104` and instead shifts to its true operational C2 server:
- **Final C2 Endpoint:** `91.92.243.161:3038` (Raw TCP, AES-CBC with a 16-byte bootstrap key for transport)

### 2. Information Stealing Targets
The payload actively hunts for and extracts credentials and session data from:
* **Chromium Browsers (Chrome, Edge, Brave, etc.):** 
  - `Login Data`, `Local State`, `Cookies`, `History`, `Web Data`, `Preferences`, `extension storage`
  - It actively targets `__AE_SHM_MARKER_` indicating an attempt to target App-Bound Encrypted keys.
* **Gecko Browsers (Firefox):**
  - `formhistory.sqlite`, `cookies.sqlite`, `places.sqlite`, `logins.json`, `key4.db`
* **Gaming Clients:**
  - Steam (`config.vdf`, `loginusers.vdf`)
* **Messaging Applications:**
  - `Telegram Desktop UWP`, Discord.

### 3. System Fingerprinting
The malware builds a comprehensive profile of the victim machine using WMI and registry keys:
* `Win32_Processor`, `Win32_VideoController`, `Win32_OperatingSystem`
* CPU fingerprinting via `HKLM\HARDWARE\DESCRIPTION\System\CentralProcessor\0\ProcessorNameString`

### 4. Process Injection & Execution
The final payload contains code to launch additional processes or inject further stages:
* **Injection APIs:** `VirtualAllocEx`, `WriteProcessMemory`, `CreateRemoteThread`, `MapViewOfFile`, `UnmapViewOfFile`
* **Execution:** Spawns `powershell.exe` with `-ExecutionPolicy Bypass`
* **Anti-Forensics / Self-Deletion:** Executes the command `cmd /C ping 1.1.1.1 & del "` to delete itself from disk.

---

### Security Recommendations
* **Indicators of Compromise (IOCs):**
  * **Staging Server:** `158.94.208.104`
  * **True C2 Server:** `91.92.243.161:3038`
* Rotate all passwords and session tokens immediately, particularly those saved in Chrome, Firefox, and Steam.
* Isolate the machine from the network immediately to sever the connection to `91.92.243.161:3038`.
