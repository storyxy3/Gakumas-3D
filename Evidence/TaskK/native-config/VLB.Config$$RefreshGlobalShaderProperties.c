// VLB.Config$$RefreshGlobalShaderProperties @ 0xe0c7d40
void __fastcall VLB_Config__RefreshGlobalShaderProperties(void *a0, void *a1)
{
  __int64 v3; // x0
  int v4; // w20
  bool usesReversedZBuffer; // w0
  float v6; // s0
  __int64 v7; // x0
  __int64 v8; // x0

  if ( (unk_F43D9AA & 1) == 0 )
  {
    sub_63CEE78(&VLB_ShaderProperties_HD_TypeInfo);
    sub_63CEE78(&VLB_ShaderProperties_TypeInfo);
    unk_F43D9AA = 1;
  }
  v3 = VLB_ShaderProperties_TypeInfo;
  if ( !*(_DWORD *)(VLB_ShaderProperties_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VLB_ShaderProperties_TypeInfo);
    v3 = VLB_ShaderProperties_TypeInfo;
  }
  v4 = *(_DWORD *)(*(_QWORD *)(v3 + 184) + 56LL);
  usesReversedZBuffer = UnityEngine_SystemInfo__get_usesReversedZBuffer(nullptr);
  v6 = 0.0;
  if ( usesReversedZBuffer )
    v6 = 1.0;
  UnityEngine_Shader__SetGlobalFloat_1(v4, v6, nullptr);
  v7 = VLB_ShaderProperties_TypeInfo;
  if ( !*(_DWORD *)(VLB_ShaderProperties_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VLB_ShaderProperties_TypeInfo);
    v7 = VLB_ShaderProperties_TypeInfo;
  }
  UnityEngine_Shader__SetGlobalFloat_1(*(_DWORD *)(*(_QWORD *)(v7 + 184) + 68LL), *((float *)a0 + 14), nullptr);
  UnityEngine_Shader__SetGlobalTexture_1(
    *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_TypeInfo + 184LL) + 72LL),
    *((void **)a0 + 15),
    nullptr);
  UnityEngine_Shader__SetGlobalTexture_1(
    *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_TypeInfo + 184LL) + 76LL),
    *((void **)a0 + 15),
    nullptr);
  UnityEngine_Shader__SetGlobalTexture_1(
    *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_TypeInfo + 184LL) + 76LL),
    *((void **)a0 + 17),
    nullptr);
  v8 = VLB_ShaderProperties_HD_TypeInfo;
  if ( !*(_DWORD *)(VLB_ShaderProperties_HD_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VLB_ShaderProperties_HD_TypeInfo);
    v8 = VLB_ShaderProperties_HD_TypeInfo;
  }
  UnityEngine_Shader__SetGlobalFloat_1(*(_DWORD *)(*(_QWORD *)(v8 + 184) + 44LL), *((float *)a0 + 18), nullptr);
  UnityEngine_Shader__SetGlobalTexture_1(
    *(_DWORD *)(*(_QWORD *)(VLB_ShaderProperties_HD_TypeInfo + 184LL) + 48LL),
    *((void **)a0 + 16),
    nullptr);
}

