﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(723,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDPIXELFORMAT__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint dwRBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwYBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwStencilBitDepth => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwLuminanceBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwBumpDuBitMask => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwOperations => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}