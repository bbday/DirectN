﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(3622,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_ROOT_SIGNATURE_0013__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 308)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pRootSignature_1_1 { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
