#!/usr/bin/env python3
"""Reproduce the malware-chain evidence without executing malware.

The script operates only on local files. It does not launch PE files, execute
shellcode, or contact C2 infrastructure.
"""

from __future__ import annotations

import argparse
import hashlib
import json
import re
import sys
from pathlib import Path
from typing import Any


SCRIPT_DIR = Path(__file__).resolve().parent
REPO_ROOT = SCRIPT_DIR.parent
DEFAULT_LAB_ROOT = REPO_ROOT.parent
if str(SCRIPT_DIR) not in sys.path:
    sys.path.insert(0, str(SCRIPT_DIR))

import decode_constants  # noqa: E402
import donut_decrypt  # noqa: E402


URL_RE = re.compile(r"https?://[^\s'\"<>]+", re.IGNORECASE)
INTERESTING_IMPORTS = {
    "CreateRemoteThread",
    "CreateToolhelp32Snapshot",
    "OpenProcess",
    "RegOpenKeyExW",
    "RegQueryValueExW",
    "VirtualAllocEx",
    "WriteProcessMemory",
    "WinHttpConnect",
    "WinHttpOpen",
    "WinHttpOpenRequest",
    "WinHttpReadData",
    "WinHttpSendRequest",
}
DECODED_KEYWORDS = {
    "c2": ["91.92", ":3038"],
    "wmi": ["Win32_"],
    "browser": ["Login Data", "Local State", "Cookies", "History"],
    "apps": ["Steam", "Telegram", "discord"],
    "execution": ["powershell", "cmd.exe"],
}
DOWNLOAD_CANDIDATES = [
    "my_newest_ll.png",
    "my_newest_ll.bin",
    "my_newest_ll_53323.bin",
    "my_newest_ll_1370756.bin",
    "payload.bin",
    "my_s.bin",
    "my_s_real.bin",
    "my_downloader.bin",
    "my_downloader_real.bin",
    "downloaded_test.bin",
    "downloaded_US.bin",
    "downloaded_CA.bin",
    "downloaded_RU.bin",
    "downloaded_BY.bin",
    "downloaded_Mozilla.bin",
]


def sha256_bytes(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest().upper()


def sha256_file(path: Path) -> str:
    digest = hashlib.sha256()
    with path.open("rb") as handle:
        for chunk in iter(lambda: handle.read(1024 * 1024), b""):
            digest.update(chunk)
    return digest.hexdigest().upper()


def file_record(path: Path) -> dict[str, Any]:
    if not path.exists():
        return {"path": str(path), "exists": False}
    data = path.read_bytes()
    return {
        "path": str(path),
        "exists": True,
        "size": len(data),
        "sha256": sha256_bytes(data),
        "magic": classify_magic(data),
        "role": classify_payload_role(data),
    }


def classify_magic(data: bytes) -> str:
    if data.startswith(b"MZ"):
        return "PE/DOS MZ"
    if data.startswith(b"<!DOCTYPE") or data.lstrip().startswith(b"<html"):
        return "HTML/decoy response"
    if data.startswith(b"\x89PNG\r\n\x1a\n"):
        return "PNG image"
    if data[:1] in {b"\xE8", b"\xFC"}:
        return "raw shellcode-like blob"
    return "unknown/binary"


def classify_payload_role(data: bytes) -> str:
    prefix = data[:512].lower()
    if data.startswith(b"MZ"):
        return "PE payload"
    if data[:1] in {b"\xE8", b"\xFC"}:
        return "shellcode-like"
    if prefix.lstrip().startswith(b"<!doctype") or prefix.lstrip().startswith(b"<html"):
        if b"404 not found" in prefix:
            return "HTML 404/failed payload"
        if b"302 found" in prefix or b"cloudflare" in prefix:
            return "HTML redirect/decoy"
        return "HTML response"
    return "unknown"


def find_mz_offsets(data: bytes) -> list[int]:
    offsets: list[int] = []
    offset = data.find(b"MZ")
    while offset != -1:
        offsets.append(offset)
        offset = data.find(b"MZ", offset + 1)
    return offsets


def extract_utf16le_strings(data: bytes, min_chars: int = 2) -> list[str]:
    strings: list[str] = []
    index = 0
    while index + 1 < len(data):
        start = index
        chars: list[str] = []
        while index + 1 < len(data):
            code_unit = data[index] | (data[index + 1] << 8)
            if code_unit == 0:
                break
            if not (32 <= code_unit <= 126):
                chars = []
                break
            chars.append(chr(code_unit))
            index += 2

        if len(chars) >= min_chars:
            strings.append("".join(chars))
        index = max(index + 2, start + 2)
    return sorted(set(strings))


def embedded_payload_bytes(data: bytes, offset: int) -> bytes:
    return data[offset:]


def analyze_stager(path: Path) -> dict[str, Any]:
    text = path.read_text(encoding="utf-8", errors="replace")
    lower = text.lower()
    uses_add_type = "add-type" in lower
    uses_virtualalloc = "virtualalloc" in lower
    uses_createthread = "createthread" in lower
    uses_marshal_copy = "marshal" in lower and "copy" in lower
    memory_loader = (
        uses_add_type and uses_virtualalloc and uses_createthread and uses_marshal_copy
    )
    return {
        **file_record(path),
        "urls": URL_RE.findall(text),
        "uses_invoke_webrequest": "invoke-webrequest" in lower,
        "uses_add_type": uses_add_type,
        "uses_virtualalloc": uses_virtualalloc,
        "uses_createthread": uses_createthread,
        "uses_marshal_copy": uses_marshal_copy,
        "classification": (
            "PowerShell in-memory shellcode loader"
            if memory_loader
            else "PowerShell script"
        ),
    }


def decrypt_donut_payload(payload_path: Path, expected_stage4_path: Path | None) -> dict[str, Any]:
    payload = payload_path.read_bytes()
    key = payload[0x09 : 0x09 + 16]
    nonce_counter = payload[0x19 : 0x19 + 16]
    ciphertext = payload[0x241 :]
    decrypted = donut_decrypt.donut_chaskey_decrypt(ciphertext, key, nonce_counter)
    mz_offset = decrypted.find(b"MZ")
    extracted_pe = decrypted[mz_offset:] if mz_offset >= 0 else b""

    result: dict[str, Any] = {
        "payload": file_record(payload_path),
        "algorithm": "Donut Chaskey-style counter-mode decryptor",
        "key_offset": "0x09",
        "nonce_counter_offset": "0x19",
        "ciphertext_offset": "0x241",
        "decrypted_size": len(decrypted),
        "decrypted_sha256": sha256_bytes(decrypted),
        "mz_offset": mz_offset,
        "extracted_stage4_size": len(extracted_pe),
        "extracted_stage4_sha256": sha256_bytes(extracted_pe) if extracted_pe else None,
    }

    if expected_stage4_path and expected_stage4_path.exists() and extracted_pe:
        expected_hash = sha256_file(expected_stage4_path)
        result["expected_stage4"] = file_record(expected_stage4_path)
        result["extracted_stage4_matches_expected"] = (
            expected_hash == result["extracted_stage4_sha256"]
        )

    return result


def pe_summary(path: Path) -> dict[str, Any]:
    record = file_record(path)
    if not path.exists():
        return record

    try:
        import pefile
    except ImportError:
        record["pe_error"] = "pefile is not installed"
        return record

    try:
        pe = pefile.PE(str(path), fast_load=False)
    except Exception as exc:  # pragma: no cover - depends on malformed samples
        record["pe_error"] = str(exc)
        return record

    imports: list[str] = []
    if hasattr(pe, "DIRECTORY_ENTRY_IMPORT"):
        for entry in pe.DIRECTORY_ENTRY_IMPORT:
            dll = entry.dll.decode(errors="ignore")
            for imported in entry.imports:
                if imported.name:
                    name = imported.name.decode(errors="ignore")
                    imports.append(f"{dll}!{name}")

    record.update(
        {
            "machine": hex(pe.FILE_HEADER.Machine),
            "sections": [
                section.Name.decode(errors="ignore").rstrip("\x00")
                for section in pe.sections
            ],
            "interesting_imports": [
                item
                for item in imports
                if any(marker in item for marker in INTERESTING_IMPORTS)
            ],
        }
    )
    return record


def saved_download_summary(lab_root: Path) -> list[dict[str, Any]]:
    rows: list[dict[str, Any]] = []
    for name in DOWNLOAD_CANDIDATES:
        path = lab_root / name
        if path.exists():
            rows.append(file_record(path))
    return rows


def stage4_logic_summary(path: Path) -> dict[str, Any]:
    if not path.exists():
        return {"error": f"missing {path}"}
    wide_strings = extract_utf16le_strings(path.read_bytes(), min_chars=2)
    interesting = {
        "powershell",
        "158.94.208.104",
        "GET",
        "Control Panel\\International\\Geo",
        "Name",
        "RU",
        "BY",
        "US",
        "CA",
        "x7GkP2mQ9zL4/my_s.bin",
        "x7GkP2mQ9zL4/my_downloader.bin",
        "svchost.exe",
    }
    return {
        "wide_strings_of_interest": [
            value for value in wide_strings if value in interesting
        ],
        "network_sequence": [
            "WinHttpOpen user-agent: powershell",
            "WinHttpConnect host: 158.94.208.104 port: 80",
            "WinHttpOpenRequest method: GET",
            "Primary path: x7GkP2mQ9zL4/my_s.bin",
            "Conditional second path: x7GkP2mQ9zL4/my_downloader.bin",
        ],
        "geo_policy_from_static_lift": {
            "registry_key": "HKCU\\Control Panel\\International\\Geo",
            "registry_value": "Name",
            "early_exit_country_codes": ["RU", "BY"],
            "second_payload_country_codes": ["US", "CA"],
            "notes": (
                "Derived from disassembly around stage4.exe RVA 0x1ac8-0x1c31; "
                "the wide-string comparison helper returns zero on equality."
            ),
        },
    }


def final_wrapper_summary(path: Path, expected_inner: Path | None = None) -> dict[str, Any]:
    if not path.exists():
        return {"error": f"missing {path}"}

    data = path.read_bytes()
    mz_offsets = find_mz_offsets(data)
    result: dict[str, Any] = {
        "file": file_record(path),
        "mz_offsets": [hex(offset) for offset in mz_offsets],
        "known_inner_payload_offset": "0x1ba40" if 0x1BA40 in mz_offsets else None,
    }

    if 0x1BA40 not in mz_offsets:
        return result

    inner = embedded_payload_bytes(data, 0x1BA40)
    result["embedded_inner_size"] = len(inner)
    result["embedded_inner_sha256"] = sha256_bytes(inner)
    try:
        import pefile

        pe = pefile.PE(data=inner, fast_load=False)
        pe_raw_size = max(
            section.PointerToRawData + section.SizeOfRawData
            for section in pe.sections
        )
        result["embedded_inner_pe_raw_size"] = pe_raw_size
        result["embedded_inner_sections"] = [
            section.Name.decode(errors="ignore").rstrip("\x00")
            for section in pe.sections
        ]
        dotnet_dir = pe.OPTIONAL_HEADER.DATA_DIRECTORY[14]
        result["embedded_inner_dotnet_com_descriptor"] = {
            "rva": hex(dotnet_dir.VirtualAddress),
            "size": hex(dotnet_dir.Size),
        }
    except Exception as exc:
        result["embedded_inner_error"] = str(exc)

    if expected_inner and expected_inner.exists():
        result["expected_inner"] = file_record(expected_inner)
        result["embedded_inner_matches_expected"] = (
            sha256_file(expected_inner) == result.get("embedded_inner_sha256")
        )
    return result


def decoded_constant_summary(source_path: Path) -> dict[str, Any]:
    inventory = decode_constants.extract_constants(source_path)
    strings = inventory["decoded_strings"]
    keyword_hits = {
        name: [
            value
            for value in strings
            if any(marker.lower() in value.lower() for marker in markers)
        ]
        for name, markers in DECODED_KEYWORDS.items()
    }
    return {**inventory, "keyword_hits": keyword_hits}


def build_report(lab_root: Path = DEFAULT_LAB_ROOT, repo_root: Path = REPO_ROOT) -> dict[str, Any]:
    source_path = repo_root / "source_code" / "infostealer_decompiled.cs"
    payload_path = lab_root / "payload.bin"
    stage4_path = lab_root / "stage4.exe"

    return {
        "safety": {
            "native_execution": False,
            "network_access": False,
            "notes": "Offline static/decryption workflow only.",
        },
        "stager": analyze_stager(lab_root / "hack_start.txt"),
        "files": {
            "payload_bin": file_record(payload_path),
            "stage4_exe": file_record(stage4_path),
            "my_s_real_bin": file_record(lab_root / "my_s_real.bin"),
            "my_newest_ll_png": file_record(lab_root / "my_newest_ll.png"),
            "my_newest_ll_53323_bin": file_record(lab_root / "my_newest_ll_53323.bin"),
            "my_newest_ll_1370756_bin": file_record(
                lab_root / "my_newest_ll_1370756.bin"
            ),
        },
        "saved_downloads": saved_download_summary(lab_root),
        "donut_payload": decrypt_donut_payload(payload_path, stage4_path)
        if payload_path.exists()
        else {"error": f"missing {payload_path}"},
        "stage4_pe": pe_summary(stage4_path),
        "stage4_logic": stage4_logic_summary(stage4_path),
        "final_payload_pe": pe_summary(lab_root / "my_s_real.bin"),
        "final_wrapper": final_wrapper_summary(
            lab_root / "my_s_real.bin", lab_root / "inner_payload.bin"
        ),
        "final_stage_constants": decoded_constant_summary(source_path)
        if source_path.exists()
        else {"error": f"missing {source_path}"},
    }


def print_text_report(report: dict[str, Any]) -> None:
    stager = report["stager"]
    donut = report["donut_payload"]
    constants = report["final_stage_constants"]

    print("Offline malware-chain reproduction")
    print(f"stager: {stager['classification']}")
    print(f"stager urls: {', '.join(stager['urls'])}")
    print(f"payload sha256: {report['files']['payload_bin'].get('sha256')}")
    print(f"donut decrypted size: {donut.get('decrypted_size')}")
    print(f"stage4 MZ offset in decrypted blob: {donut.get('mz_offset')}")
    print(f"stage4 extracted sha256: {donut.get('extracted_stage4_sha256')}")
    print(f"stage4 match: {donut.get('extracted_stage4_matches_expected')}")
    print("stage4 interesting imports:")
    for imported in report["stage4_pe"].get("interesting_imports", []):
        print(f"  {imported}")
    print("stage4 network sequence:")
    for item in report["stage4_logic"].get("network_sequence", []):
        print(f"  {item}")
    geo = report["stage4_logic"].get("geo_policy_from_static_lift", {})
    if geo:
        print(
            "stage4 geo policy: early exit "
            f"{geo.get('early_exit_country_codes')} ; second payload "
            f"{geo.get('second_payload_country_codes')}"
        )
    wrapper = report.get("final_wrapper", {})
    if wrapper.get("known_inner_payload_offset"):
        print(
            "final wrapper inner payload: "
            f"offset {wrapper.get('known_inner_payload_offset')} "
            f"sha256 {wrapper.get('embedded_inner_sha256')} "
            f"matches expected {wrapper.get('embedded_inner_matches_expected')}"
        )
    print("saved download bodies:")
    for row in report.get("saved_downloads", []):
        print(f"  {Path(row['path']).name}: {row.get('size')} bytes, {row.get('role')}")
    print(f"encoded constant calls: {constants.get('total_calls')}")
    print(f"string constant calls: {constants.get('string_calls')}")
    for group, hits in constants.get("keyword_hits", {}).items():
        if hits:
            print(f"{group}: {', '.join(hits)}")


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Reproduce chain evidence without executing malware."
    )
    parser.add_argument("--lab-root", type=Path, default=DEFAULT_LAB_ROOT)
    parser.add_argument("--repo-root", type=Path, default=REPO_ROOT)
    parser.add_argument("--json", action="store_true")
    parser.add_argument("--output", type=Path, help="Optional path to write JSON report")
    args = parser.parse_args()

    report = build_report(args.lab_root, args.repo_root)
    if args.output:
        args.output.write_text(json.dumps(report, indent=2, sort_keys=True), encoding="utf-8")
    if args.json:
        print(json.dumps(report, indent=2, sort_keys=True))
    else:
        print_text_report(report)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
