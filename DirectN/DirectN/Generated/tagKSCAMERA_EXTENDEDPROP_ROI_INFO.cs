﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(6278,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_ROI_INFO
    {
        public tagRECT Region;
        public ulong Flags;
        public int Weight;
        public int RegionOfInterestType;
    }
}