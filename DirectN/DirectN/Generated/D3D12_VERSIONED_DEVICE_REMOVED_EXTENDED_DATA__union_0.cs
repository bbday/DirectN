﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(13277,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA>(__bits, 0, 384); set => InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA>(value, __bits, 0, 384); }
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA1>(__bits, 0, 512); set => InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA1>(value, __bits, 0, 512); }
    }
}
