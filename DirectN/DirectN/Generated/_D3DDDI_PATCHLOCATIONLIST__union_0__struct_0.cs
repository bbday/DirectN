﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(414,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_PATCHLOCATIONLIST__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint SlotId => InteropRuntime.GetUInt32(__bits, 0, 24);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 24, 8);
    }
}