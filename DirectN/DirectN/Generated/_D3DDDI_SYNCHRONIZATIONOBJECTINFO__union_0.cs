﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dukmdt.h(1591,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0 SynchronizationMutex { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_0>(value, __bits, 0, 32); }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1 Semaphore { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1>(__bits, 0, 64); set => InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_1>(value, __bits, 0, 64); }
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2 Reserved { get => InteropRuntime.Get<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2>(__bits, 0, 512); set => InteropRuntime.Set<_D3DDDI_SYNCHRONIZATIONOBJECTINFO__union_0__struct_2>(value, __bits, 0, 512); }
    }
}
