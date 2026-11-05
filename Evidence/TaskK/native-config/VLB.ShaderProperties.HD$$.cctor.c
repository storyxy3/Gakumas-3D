// VLB.ShaderProperties.HD$$.cctor @ 0xe0e1be4
void __fastcall VLB_ShaderProperties_HD___cctor(void *a0)
{
  int v1; // w0
  void *v2; // x8
  int v3; // w0
  void *v4; // x8
  int v5; // w0
  void *v6; // x8
  int v7; // w0
  void *v8; // x8
  int v9; // w0
  void *v10; // x8
  int v11; // w0
  void *v12; // x8
  int v13; // w0
  void *v14; // x8
  int v15; // w0
  void *v16; // x8

  if ( (unk_F43DAB6 & 1) == 0 )
  {
    sub_63CEE78(&VLB_ShaderProperties_HD_TypeInfo);
    sub_63CEE78(&StringLiteral__TransformScale);
    sub_63CEE78(&StringLiteral__CookiePosAndScale);
    sub_63CEE78(&StringLiteral__Intensity);
    sub_63CEE78(&StringLiteral__Jittering);
    sub_63CEE78(&StringLiteral__VLB_JitteringNoiseTex);
    sub_63CEE78(&StringLiteral__CookieTexture);
    sub_63CEE78(&StringLiteral__CameraForwardOS);
    sub_63CEE78(&StringLiteral__VLB_CameraBlendingDistance);
    sub_63CEE78(&StringLiteral__ShadowProps);
    sub_63CEE78(&StringLiteral__CameraForwardWS);
    sub_63CEE78(&StringLiteral__CookieProperties);
    sub_63CEE78(&StringLiteral__SideSoftness);
    sub_63CEE78(&StringLiteral__ShadowDepthTexture);
    unk_F43DAB6 = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID(StringLiteral__Intensity, nullptr);
  v2 = (void *)StringLiteral__SideSoftness;
  **(_DWORD **)(VLB_ShaderProperties_HD_TypeInfo + 184LL) = v1;
  v3 = UnityEngine_Shader__PropertyToID(v2, nullptr);
  v4 = (void *)StringLiteral__CameraForwardOS;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 4LL) = v3;
  v5 = UnityEngine_Shader__PropertyToID(v4, nullptr);
  v6 = (void *)StringLiteral__CameraForwardWS;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 8LL) = v5;
  v7 = UnityEngine_Shader__PropertyToID(v6, nullptr);
  v8 = (void *)StringLiteral__TransformScale;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 12LL) = v7;
  v9 = UnityEngine_Shader__PropertyToID(v8, nullptr);
  v10 = (void *)StringLiteral__ShadowDepthTexture;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 16LL) = v9;
  v11 = UnityEngine_Shader__PropertyToID(v10, nullptr);
  v12 = (void *)StringLiteral__ShadowProps;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 20LL) = v11;
  v13 = UnityEngine_Shader__PropertyToID(v12, nullptr);
  v14 = (void *)StringLiteral__Jittering;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 24LL) = v13;
  v15 = UnityEngine_Shader__PropertyToID(v14, nullptr);
  v16 = (void *)StringLiteral__CookieTexture;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 28LL) = v15;
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 32LL) = UnityEngine_Shader__PropertyToID(
                                                                                v16,
                                                                                nullptr);
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 36LL) = UnityEngine_Shader__PropertyToID(
                                                                                StringLiteral__CookieProperties,
                                                                                nullptr);
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 40LL) = UnityEngine_Shader__PropertyToID(
                                                                                StringLiteral__CookiePosAndScale,
                                                                                nullptr);
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 44LL) = UnityEngine_Shader__PropertyToID(
                                                                                StringLiteral__VLB_CameraBlendingDistance,
                                                                                nullptr);
  *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 48LL) = UnityEngine_Shader__PropertyToID(
                                                                                StringLiteral__VLB_JitteringNoiseTex,
                                                                                nullptr);
}

