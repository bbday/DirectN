﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3264,5)
using System;
using System.Runtime.InteropServices;
using MFARGB = DirectN._MFARGB;
using RECT = DirectN.tagRECT;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [Guid("a3f675d5-6119-4f7f-a100-1d8b280f0efb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoProcessorControl
    {
        [PreserveSig]
        HRESULT SetBorderColor(/* optional(MFARGB) */ IntPtr pBorderColor);
        
        [PreserveSig]
        HRESULT SetSourceRectangle(/* optional(RECT) */ IntPtr pSrcRect);
        
        [PreserveSig]
        HRESULT SetDestinationRectangle(/* optional(RECT) */ IntPtr pDstRect);
        
        [PreserveSig]
        HRESULT SetMirror(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_MIRROR eMirror);
        
        [PreserveSig]
        HRESULT SetRotation(/* [annotation][in] _In_ */ _MF_VIDEO_PROCESSOR_ROTATION eRotation);
        
        [PreserveSig]
        HRESULT SetConstrictionSize(/* optional(SIZE) */ IntPtr pConstrictionSize);
    }
}