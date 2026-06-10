import speakeasy
import sys
import json

def analyze_stage4(file_path):
    print(f"[*] Emulating {file_path} to capture network and injection APIs...")
    se = speakeasy.Speakeasy()
    
    try:
        module = se.load_module(file_path)
    except Exception as e:
        print(f"[-] Failed to load module: {e}")
        return

    try:
        se.run_module(module)
    except Exception as e:
        print(f"[-] Emulation stopped (normal for malware expecting C2): {e}")

    report = se.get_report()
    
    print("\n" + "="*50)
    print("CRITICAL API CALLS CAPTURED:")
    print("="*50)
    
    interesting_apis = ['WinHttpOpen', 'WinHttpConnect', 'WinHttpOpenRequest', 'WinHttpSendRequest', 'WinHttpAddRequestHeaders', 'CreateProcess', 'CreateRemoteThread', 'WriteProcessMemory', 'VirtualAllocEx', 'SetThreadContext', 'ResumeThread']
    
    for event in report.get('api', []):
        api_name = event.get('api_name', '')
        if any(interesting in api_name for interesting in interesting_apis):
            print(f"\n[+] {api_name}")
            args = event.get('args', [])
            for i, arg in enumerate(args):
                if isinstance(arg, bytes):
                    try:
                        # Try decoding as wide string first (common in Windows APIs)
                        val = arg.decode('utf-16le').rstrip('\x00')
                        if not val:
                            val = arg.decode('utf-8').rstrip('\x00')
                        print(f"    arg[{i}]: {val}")
                    except:
                        print(f"    arg[{i}]: {arg.hex()}")
                elif isinstance(arg, int):
                    print(f"    arg[{i}]: {hex(arg)}")
                else:
                    print(f"    arg[{i}]: {arg}")

if __name__ == "__main__":
    analyze_stage4(r'C:\Users\temp\malware_lab\stage4.exe')
