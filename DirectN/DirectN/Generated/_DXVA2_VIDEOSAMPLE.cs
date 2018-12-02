﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2swdev.h(47,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VIDEOSAMPLE
    {
        public int Start;
        public int End;
        public int SampleFormat;
        public uint SampleFlags;
        public IntPtr SrcResource;
        public RECT SrcRect;
        public RECT DstRect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public int[][] Pal;
        public int PlanarAlpha;
    }
}