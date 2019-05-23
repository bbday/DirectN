﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(497,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_LIGHT
    {
        public _D3DLIGHTTYPE Type;
        public _D3DCOLORVALUE Diffuse;
        public _D3DCOLORVALUE Specular;
        public _D3DCOLORVALUE Ambient;
        public _D3DVECTOR Position;
        public _D3DVECTOR Direction;
        public float Range;
        public float Falloff;
        public float Attenuation0;
        public float Attenuation1;
        public float Attenuation2;
        public float Theta;
        public float Phi;
    }
}