﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(11677,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_META_COMMAND_PARAMETER_DESC
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12_META_COMMAND_PARAMETER_TYPE Type;
        public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;
        public D3D12_RESOURCE_STATES RequiredResourceState;
        public uint StructureOffset;
    }
}