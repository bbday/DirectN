﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(459,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDSZ => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr lpDDSZLcl => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}