﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12shader.h(61,9)
using System;
using System.Runtime.InteropServices;
using D3D_CBUFFER_TYPE = DirectN._D3D_CBUFFER_TYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_BUFFER_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public D3D_CBUFFER_TYPE Type;
        public uint Variables;
        public uint Size;
        public uint uFlags;
    }
}