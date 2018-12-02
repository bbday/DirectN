﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(833,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56648f4d-cc8b-4444-a5ad-b5a3d76e91b3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectConstantBuffer : ID3D10EffectVariable
    {
        // ID3D10EffectVariable
        [PreserveSig]
        new bool IsValid();
        
        [PreserveSig]
        new ID3D10EffectType GetType();
        
        [PreserveSig]
        new HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_EFFECT_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        new ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        new ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberByIndex(uint Index);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        new ID3D10EffectVariable GetElement(uint Index);
        
        [PreserveSig]
        new ID3D10EffectConstantBuffer GetParentConstantBuffer();
        
        [PreserveSig]
        new ID3D10EffectScalarVariable AsScalar();
        
        [PreserveSig]
        new ID3D10EffectVectorVariable AsVector();
        
        [PreserveSig]
        new ID3D10EffectMatrixVariable AsMatrix();
        
        [PreserveSig]
        new ID3D10EffectStringVariable AsString();
        
        [PreserveSig]
        new ID3D10EffectShaderResourceVariable AsShaderResource();
        
        [PreserveSig]
        new ID3D10EffectRenderTargetViewVariable AsRenderTargetView();
        
        [PreserveSig]
        new ID3D10EffectDepthStencilViewVariable AsDepthStencilView();
        
        [PreserveSig]
        new ID3D10EffectConstantBuffer AsConstantBuffer();
        
        [PreserveSig]
        new ID3D10EffectShaderVariable AsShader();
        
        [PreserveSig]
        new ID3D10EffectBlendVariable AsBlend();
        
        [PreserveSig]
        new ID3D10EffectDepthStencilVariable AsDepthStencil();
        
        [PreserveSig]
        new ID3D10EffectRasterizerVariable AsRasterizer();
        
        [PreserveSig]
        new ID3D10EffectSamplerVariable AsSampler();
        
        [PreserveSig]
        new HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        new HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData, uint Offset, uint ByteCount);
        
        // ID3D10EffectConstantBuffer
        [PreserveSig]
        ID3D10EffectType GetType();
        
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_EFFECT_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        ID3D10EffectVariable GetElement(uint Index);
        
        [PreserveSig]
        ID3D10EffectConstantBuffer GetParentConstantBuffer();
        
        [PreserveSig]
        ID3D10EffectScalarVariable AsScalar();
        
        [PreserveSig]
        ID3D10EffectVectorVariable AsVector();
        
        [PreserveSig]
        ID3D10EffectMatrixVariable AsMatrix();
        
        [PreserveSig]
        ID3D10EffectStringVariable AsString();
        
        [PreserveSig]
        ID3D10EffectShaderResourceVariable AsShaderResource();
        
        [PreserveSig]
        ID3D10EffectRenderTargetViewVariable AsRenderTargetView();
        
        [PreserveSig]
        ID3D10EffectDepthStencilViewVariable AsDepthStencilView();
        
        [PreserveSig]
        ID3D10EffectConstantBuffer AsConstantBuffer();
        
        [PreserveSig]
        ID3D10EffectShaderVariable AsShader();
        
        [PreserveSig]
        ID3D10EffectBlendVariable AsBlend();
        
        [PreserveSig]
        ID3D10EffectDepthStencilVariable AsDepthStencil();
        
        [PreserveSig]
        ID3D10EffectRasterizerVariable AsRasterizer();
        
        [PreserveSig]
        ID3D10EffectSamplerVariable AsSampler();
        
        [PreserveSig]
        HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        HRESULT SetConstantBuffer(/* optional(ID3D10Buffer) */ IntPtr pConstantBuffer);
        
        [PreserveSig]
        HRESULT GetConstantBuffer(/* THIS_ _Out_ */ out IntPtr ppConstantBuffer);
        
        [PreserveSig]
        HRESULT SetTextureBuffer(/* optional(ID3D10ShaderResourceView) */ IntPtr pTextureBuffer);
        
        [PreserveSig]
        HRESULT GetTextureBuffer(/* THIS_ _Out_ */ out IntPtr ppTextureBuffer);
    }
}