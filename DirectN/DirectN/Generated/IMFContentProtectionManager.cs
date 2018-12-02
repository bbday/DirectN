﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(7094,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("acf92459-6a61-42bd-b57c-b43e51203cb0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentProtectionManager
    {
        [PreserveSig]
        HRESULT BeginEnableContent(/* [in] */ ref IMFActivate pEnablerActivate, /* [in] */ IMFTopology pTopo, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndEnableContent(/* [in] */ ref IMFAsyncResult pResult);
    }
}