﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(416,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BUFFER_PLACEMENT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_HRESOURCE_PLACEMENT UMD { get => InteropRuntime.Get<D3D12DDIARG_HRESOURCE_PLACEMENT>(__bits, 0, 128); set => InteropRuntime.Set<D3D12DDIARG_HRESOURCE_PLACEMENT>(value, __bits, 0, 128); }
    }
}
