import struct

def ROTL(x, shift, bits=32):
    return ((x << shift) & ((1 << bits) - 1)) | (x >> (bits - shift))

def chaskey_core(v0, v1, v2, v3):
    for _ in range(16):
        v0 = (v0 + v1) & 0xFFFFFFFF
        v1 = ROTL(v1, 5) ^ v0
        v0 = ROTL(v0, 16)
        
        v2 = (v2 + v3) & 0xFFFFFFFF
        v3 = ROTL(v3, 8) ^ v2
        
        v0 = (v0 + v3) & 0xFFFFFFFF
        v3 = ROTL(v3, 13) ^ v0
        
        v2 = (v2 + v1) & 0xFFFFFFFF
        v1 = ROTL(v1, 7) ^ v2
        v2 = ROTL(v2, 16)
    return v0, v1, v2, v3

def increment_counter(ctr_bytes):
    ctr_int = int.from_bytes(ctr_bytes, 'big')
    ctr_int += 1
    return ctr_int.to_bytes(16, 'big')

def donut_chaskey_decrypt(data, key, nonce_ctr):
    k0, k1, k2, k3 = struct.unpack('<4I', key)
    
    out = bytearray()
    ctr = nonce_ctr
    
    for i in range(0, len(data), 16):
        c0, c1, c2, c3 = struct.unpack('<4I', ctr)
        
        # 1. State = counter_block ^ key
        v0, v1, v2, v3 = c0 ^ k0, c1 ^ k1, c2 ^ k2, c3 ^ k3
        
        # 2. Chaskey core (16 rounds)
        v0, v1, v2, v3 = chaskey_core(v0, v1, v2, v3)
        
        # 3. State = State ^ key
        v0 ^= k0
        v1 ^= k1
        v2 ^= k2
        v3 ^= k3
        
        keystream = struct.pack('<4I', v0, v1, v2, v3)
        
        chunk = data[i:i+16]
        for j in range(len(chunk)):
            out.append(chunk[j] ^ keystream[j])
            
        ctr = increment_counter(ctr)
        
    return bytes(out)

if __name__ == '__main__':
    with open(r'C:\Users\temp\malware_lab\payload.bin', 'rb') as f:
        payload = f.read()

    key = payload[0x09 : 0x09+16]
    nonce_ctr = payload[0x19 : 0x19+16]
    ct = payload[0x241 : ]
    
    decrypted = donut_chaskey_decrypt(ct, key, nonce_ctr)
    
    with open(r'C:\Users\temp\malware_lab\decrypted_module.bin', 'wb') as out_f:
        out_f.write(decrypted)
        
    print(f"[*] Saved decrypted module to decrypted_module.bin ({len(decrypted)} bytes).")
    
    # Try to find MZ header inside the decrypted module
    idx = decrypted.find(b'MZ')
    if idx != -1:
        print(f"[*] Found MZ header at offset {idx}")
        pe_data = decrypted[idx:]
        with open(r'C:\Users\temp\malware_lab\stage4.exe', 'wb') as f:
            f.write(pe_data)
        print(f"[*] Saved PE to stage4.exe")
    else:
        print("[-] MZ header not found inside decrypted data")
