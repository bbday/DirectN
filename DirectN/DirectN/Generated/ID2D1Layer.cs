﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1.h(2331,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents the backing store required to render a layer.
    /// </summary>
    [Guid("2cd9069b-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Layer : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Layer
        [PreserveSig]
        D2D_SIZE_F GetSize();
    }
}
