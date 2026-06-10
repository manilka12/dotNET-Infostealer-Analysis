import speakeasy
import sys

def emulate_and_trace(file_path):
    print(f"[*] Emulating Shellcode: {file_path}")
    se = speakeasy.Speakeasy()
    
    with open(file_path, 'rb') as f:
        code = f.read()

    try:
        module = se.load_shellcode(file_path, arch='amd64')
    except Exception as e:
        print(f"[-] Failed to load shellcode: {e}")
        return

    base = module
    
    # Add a code hook to trace execution
    def hook_code(emu, address, size, ctx):
        if address == base + 0x81c5:
            print(f"[!] Hit 0x81c5 (Decryption function)")
        if address == base + 0x9c55:
            r8 = emu.reg_read('r8')
            rdx = emu.reg_read('rdx')
            print(f"[!] Hit 0x9c55 (API Resolver) - Module Hash: {hex(r8)}, Func Hash: {hex(rdx)}")
        if address == base + 0x82b4:
            print(f"[!] Hit 0x82b4 (Chacha20 call!)")
            
            # Let's dump the memory at R8 (buffer) and length R9D
            r8 = emu.reg_read('r8')
            r9d = emu.reg_read('r9d')
            if r9d is None: r9d = emu.reg_read('r9') & 0xFFFFFFFF
            print(f"    Buffer: {hex(r8)}, Size: {r9d}")

    se.add_code_hook(hook_code)

    print(f"[*] Starting emulation...")
    try:
        se.run_shellcode(module)
    except Exception as e:
        print(f"[-] Emulation error: {e}")

    report = se.get_report()
    
    print("="*50)
    print("API Calls Captured:")
    print("="*50)
    
    for event in report.get('api', []):
        api_name = event.get('api_name')
        print(f"API: {api_name}")

if __name__ == "__main__":
    emulate_and_trace(r'C:\Users\temp\malware_lab\payload.bin')
