﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(584,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_CREATEHWQUEUEFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint DisableGpuTimeout => InteropRuntime.GetUInt32(__bits, 0, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 1, 31);
    }
}