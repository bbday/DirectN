﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(6126,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_VALUE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public double dbl { get => InteropRuntime.GetDouble(__bits, 0, 64); set => InteropRuntime.SetDouble(value, __bits, 0, 64); }
        public ulong ull { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
        public uint ul { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public ulong ratio { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
        public int l { get => InteropRuntime.GetInt32(__bits, 0, 32); set => InteropRuntime.SetInt32(value, __bits, 0, 32); }
        public long ll { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
    }
}
