import struct

def chacha20_block(key, nonce, counter):
    # key: 16 bytes or 32 bytes
    # nonce: 8 bytes
    # counter: 8 bytes (or combined as 16 byte nonce/counter)
    
    if len(key) == 16:
        constants = [0x61707865, 0x3120646e, 0x79622d36, 0x6b206574]
        k = struct.unpack('<4I', key) * 2
    elif len(key) == 32:
        constants = [0x61707865, 0x3320646e, 0x79622d32, 0x6b206574]
        k = struct.unpack('<8I', key)
    else:
        raise ValueError("Key must be 16 or 32 bytes")

    # Assuming nonce is 8 bytes, counter is 8 bytes
    n = struct.unpack('<2I', nonce[:8])
    c = struct.unpack('<2I', counter)
    
    state = constants + list(k) + list(c) + list(n)
    
    def ROTL(a, b):
        return ((a << b) | (a >> (32 - b))) & 0xFFFFFFFF
        
    def QR(state, a, b, c, d):
        state[a] = (state[a] + state[b]) & 0xFFFFFFFF
        state[d] = ROTL(state[d] ^ state[a], 16)
        state[c] = (state[c] + state[d]) & 0xFFFFFFFF
        state[b] = ROTL(state[b] ^ state[c], 12)
        state[a] = (state[a] + state[b]) & 0xFFFFFFFF
        state[d] = ROTL(state[d] ^ state[a], 8)
        state[c] = (state[c] + state[d]) & 0xFFFFFFFF
        state[b] = ROTL(state[b] ^ state[c], 7)

    working_state = list(state)
    for _ in range(10):
        QR(working_state, 0, 4, 8, 12)
        QR(working_state, 1, 5, 9, 13)
        QR(working_state, 2, 6, 10, 14)
        QR(working_state, 3, 7, 11, 15)
        QR(working_state, 0, 5, 10, 15)
        QR(working_state, 1, 6, 11, 12)
        QR(working_state, 2, 7, 8, 13)
        QR(working_state, 3, 4, 9, 14)
        
    for i in range(16):
        state[i] = (state[i] + working_state[i]) & 0xFFFFFFFF
        
    return struct.pack('<16I', *state)

def chacha20_decrypt(data, key, nonce, counter=0):
    out = bytearray()
    for i in range(0, len(data), 64):
        c_bytes = struct.pack('<Q', counter)
        block = chacha20_block(key, nonce, c_bytes)
        
        chunk = data[i:i+64]
        for j in range(len(chunk)):
            out.append(chunk[j] ^ block[j])
        counter += 1
    return bytes(out)

# Read the file
with open(r'C:\Users\temp\malware_lab\payload.bin', 'rb') as f:
    payload = f.read()

# Extract key, nonce, and ciphertext
key = payload[0x09 : 0x09+16]
nonce = payload[0x19 : 0x19+8]
counter = payload[0x19+8 : 0x19+16] # The second 8 bytes of 'nonce' in DONUT_CRYPT? 
# Wait, DONUT_CRYPT has mki[16]. 
# Usually, counter is the first 8 bytes or last 8 bytes.
# Let's try both, or just assume standard Chacha20 where counter is 8 bytes and nonce is 8 bytes.
# Actually, the 16 bytes of mki are:
# 30 70 d2 76 0d cf c0 75 0e c7 fa 21 e3 c7 12 71
# It might be 8 byte nonce + 8 byte counter, or vice-versa.

# Let's try the Cryptography library which is faster and standard.
import cryptography.hazmat.primitives.ciphers.algorithms as algo
from cryptography.hazmat.primitives.ciphers import Cipher, modes
from cryptography.hazmat.backends import default_backend

def try_decrypt(k, n, ct):
    try:
        # standard chacha20 requires 32-byte key and 16-byte nonce
        cipher = Cipher(algo.ChaCha20(k, n), mode=None, backend=default_backend())
        decryptor = cipher.decryptor()
        return decryptor.update(ct)
    except Exception as e:
        return b""

# Try with 32-byte key (by duplicating 16-byte key)
key32 = key * 2
nonce16 = payload[0x19 : 0x19+16]
ct = payload[0x241 : 0x241+100]

res = try_decrypt(key32, nonce16, ct)
print(f"Standard ChaCha20 (Key*2): {res.hex()[:60]}")

# Also try the custom 16-byte script
try:
    res2 = chacha20_decrypt(ct, key, nonce16[8:], struct.unpack('<Q', nonce16[:8])[0])
    print(f"Custom ChaCha20 (16-byte): {res2.hex()[:60]}")
except Exception as e:
    print(e)
