import os, re
d = r'C:\Users\temp\malware_lab'
for fn in os.listdir(d):
    path = os.path.join(d, fn)
    if os.path.isfile(path) and fn != "search_iocs.py":
        try:
            with open(path, 'rb') as f:
                data = f.read()
            if b'158.94.208.104' in data:
                print(f'Found IP 158.94.208.104 in {fn}')
            
            urls = re.findall(b'https?://[^\x00\r\n ]+', data)
            if urls:
                # filter out common schema URLs
                interesting_urls = [u for u in urls if b'w3.org' not in u and b'schemas.microsoft' not in u]
                if interesting_urls:
                    print(f'Found URLs in {fn}: {[u.decode(errors="ignore") for u in interesting_urls[:5]]}')
            
            urls_w = re.findall(b'h\x00t\x00t\x00p\x00s?\x00:\x00/\x00/\x00(?:[^\x00]\x00)+', data)
            if urls_w:
                print(f'Found Wide URLs in {fn}: {[u.decode("utf-16le", errors="ignore") for u in urls_w[:5]]}')
        except Exception as e:
            print(f'Error reading {fn}: {e}')
