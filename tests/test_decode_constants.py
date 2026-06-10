import importlib.util
import unittest
from pathlib import Path


REPO_ROOT = Path(__file__).resolve().parents[1]
MODULE_PATH = REPO_ROOT / "scripts" / "decode_constants.py"
SOURCE_PATH = REPO_ROOT / "source_code" / "infostealer_decompiled.cs"


def load_module():
    spec = importlib.util.spec_from_file_location("decode_constants", MODULE_PATH)
    module = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(module)
    return module


class DecodeConstantsTests(unittest.TestCase):
    def test_known_final_stage_constants_decode(self):
        decoder = load_module()

        self.assertEqual(decoder.decode_string("6bc9cc766609d"), "\\")
        self.assertEqual(
            decoder.decode_string("f942bc0f006df608c0d310a2ed6c6e99262924d5da86675"),
            "91.92.243.161:3038",
        )
        self.assertEqual(
            decoder.decode_string("63221f1b1d1aad2bc10a8f36807839e"),
            "Login Data",
        )

    def test_source_constant_inventory_matches_audit_count(self):
        decoder = load_module()

        inventory = decoder.extract_constants(SOURCE_PATH)

        self.assertEqual(inventory["total_calls"], 787)
        self.assertEqual(inventory["string_calls"], 228)
        self.assertIn("91.92.243.161:3038", inventory["decoded_strings"])
        self.assertIn("Win32_Processor", inventory["decoded_strings"])
        self.assertIn("Telegram Desktop UWP", inventory["decoded_strings"])


if __name__ == "__main__":
    unittest.main()
