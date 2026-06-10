#!/usr/bin/env python3
"""Offline decoder for final-stage constants in infostealer_decompiled.cs.

This script is defensive analysis tooling. It does not load or execute the
malware assembly. It ports the decompiled flag6144/text872 constant decoder so
claims about C2 strings, target files, and WMI names can be reproduced from
source text.
"""

from __future__ import annotations

import argparse
import json
import re
from functools import lru_cache
from pathlib import Path


REPO_ROOT = Path(__file__).resolve().parents[1]
DEFAULT_SOURCE = REPO_ROOT / "source_code" / "infostealer_decompiled.cs"
STRING_METHOD = "0e291526dfde44109a60e580c474e7dd"
CALL_RE = re.compile(r'flag6144\.([A-Za-z0-9]+) \("([0-9a-f]+)"\)')
SUB_TABLE_RE = re.compile(
    r'array8361 \[num\] = \(byte\)\(\("(.*?)" \[num\] - 1\) \^',
    re.DOTALL,
)
HEX_VALUES = {char: index for index, char in enumerate("0123456789abcdef")}


def _decode_csharp_string_literal(value: str) -> str:
    result: list[str] = []
    index = 0
    while index < len(value):
        char = value[index]
        if char != "\\":
            result.append(char)
            index += 1
            continue

        index += 1
        if index >= len(value):
            result.append("\\")
            break

        escape = value[index]
        index += 1
        escapes = {
            "\\": "\\",
            '"': '"',
            "0": "\0",
            "a": "\a",
            "b": "\b",
            "f": "\f",
            "n": "\n",
            "r": "\r",
            "t": "\t",
            "v": "\v",
        }
        if escape == "u":
            result.append(chr(int(value[index : index + 4], 16)))
            index += 4
        else:
            result.append(escapes.get(escape, escape))

    return "".join(result)


@lru_cache(maxsize=4)
def _substitution_table(source_path: str) -> tuple[int, ...]:
    source_text = Path(source_path).read_text(encoding="utf-8")
    match = SUB_TABLE_RE.search(source_text)
    if not match:
        raise ValueError("Could not find final-stage substitution table in source")

    literal = _decode_csharp_string_literal(match.group(1))
    if len(literal) != 256:
        raise ValueError(f"Expected 256 substitution chars, found {len(literal)}")

    return tuple(
        (((ord(literal[index]) - 1) ^ ((index * 73 + 19) & 0xFF)) & 0xFF)
        for index in range(256)
    )


def _nibble_index(index: int, count: int, mode: int) -> int:
    if mode == 0:
        return index
    if mode == 1:
        return count - 1 - index
    if mode == 2:
        return index >> 1
    if mode == 3:
        if index & 1:
            return index >> 1
        return (count >> 1) + (index >> 1)
    return index


def _unshuffle_hex(encoded: str) -> bytes:
    if not encoded:
        return b""

    first = HEX_VALUES.get(encoded[0], -1)
    if first < 0:
        return b""

    mode = first >> 2
    nibble_count = len(encoded) - 1
    if nibble_count & 1:
        return b""

    output = bytearray(nibble_count // 2)
    accumulator = 0
    bits = 0
    output_index = 0
    for index in range(nibble_count):
        source_index = _nibble_index(index, nibble_count, mode) + 1
        value = HEX_VALUES.get(encoded[source_index], -1)
        if value < 0:
            return b""

        accumulator = (accumulator << 4) | value
        bits += 4
        if bits >= 8:
            bits -= 8
            if output_index < len(output):
                output[output_index] = (accumulator >> bits) & 0xFF
                output_index += 1

    return bytes(output)


def decode_bytes(encoded: str, source_path: Path | str = DEFAULT_SOURCE) -> bytes:
    packed = _unshuffle_hex(encoded)
    if len(packed) < 5:
        return b""

    header = packed[0] ^ 0xEB
    if (header & 0x0F) != 2:
        return b""

    mode = (header >> 4) & 3
    seed = (packed[1] ^ 0x5B) | ((packed[2] ^ 0x45) << 8)
    expected_checksum = (packed[3] ^ (seed & 0xFF) ^ 7) | (
        (packed[4] ^ ((seed >> 8) & 0xFF) ^ 0x0F) << 8
    )

    table = _substitution_table(str(Path(source_path)))
    state = (seed ^ 0x4C) & 0xFF
    checksum = 58592
    output = bytearray(len(packed) - 5)

    for index, value in enumerate(packed[5:]):
        rolling = (((seed * 89) ^ ((index + 1) * 113)) + state + 227) & 0xFFFF
        decoded = table[value]

        if mode & 2:
            decoded ^= rolling & 0xFF
        else:
            decoded = (decoded - (rolling & 0xFF)) & 0xFF

        rotate = ((rolling & 7) + 3) & 7
        decoded = ((decoded >> rotate) | (decoded << (8 - rotate))) & 0xFF

        if mode & 1:
            decoded ^= (rolling >> 8) & 0xFF
        else:
            decoded = (decoded - ((rolling >> 8) & 0xFF)) & 0xFF

        output[index] = decoded
        checksum = ((checksum + decoded + (index + 1) * 137) ^ 0xE3) & 0xFFFF
        state = (decoded ^ (rolling >> 8)) & 0xFF

    if checksum != expected_checksum:
        return b""

    return bytes(output)


def decode_string(encoded: str, source_path: Path | str = DEFAULT_SOURCE) -> str:
    return decode_bytes(encoded, source_path).decode("utf-8", errors="replace")


def extract_constants(source_path: Path | str = DEFAULT_SOURCE) -> dict[str, object]:
    source_path = Path(source_path)
    source_text = source_path.read_text(encoding="utf-8")
    calls = CALL_RE.findall(source_text)
    decoded_strings = [
        decode_string(encoded, source_path)
        for method, encoded in calls
        if method == STRING_METHOD
    ]

    return {
        "source": str(source_path),
        "total_calls": len(calls),
        "string_calls": sum(1 for method, _ in calls if method == STRING_METHOD),
        "decoded_strings": sorted({value for value in decoded_strings if value}),
    }


def main() -> int:
    parser = argparse.ArgumentParser(
        description="Decode final-stage obfuscated constants without executing malware."
    )
    parser.add_argument(
        "--source",
        type=Path,
        default=DEFAULT_SOURCE,
        help="Path to infostealer_decompiled.cs",
    )
    parser.add_argument("--json", action="store_true", help="Print JSON inventory")
    parser.add_argument("--grep", help="Only print decoded strings containing this text")
    args = parser.parse_args()

    inventory = extract_constants(args.source)
    if args.json:
        print(json.dumps(inventory, indent=2, sort_keys=True))
        return 0

    strings = inventory["decoded_strings"]
    if args.grep:
        needle = args.grep.lower()
        strings = [value for value in strings if needle in value.lower()]

    print(f"source: {inventory['source']}")
    print(f"encoded constant calls: {inventory['total_calls']}")
    print(f"string constant calls: {inventory['string_calls']}")
    print(f"unique decoded strings: {len(inventory['decoded_strings'])}")
    for value in strings:
        print(value)
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
