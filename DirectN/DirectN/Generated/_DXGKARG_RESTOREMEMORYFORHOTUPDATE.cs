﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8963,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RESTOREMEMORYFORHOTUPDATE
    {
        public _DXGK_RESTOREMEMORYFORHOTUPDATEFLAGS Flags;
        public IntPtr pDataMdl;
        public uint MetaDataSize;
        public IntPtr pMetaData;
    }
}
