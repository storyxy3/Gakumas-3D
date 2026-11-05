// VLB.Config$$ResetInternalData @ 0xe0c7fb0
void __fastcall VLB_Config__ResetInternalData(void *a0, void *a1)
{
  _QWORD *v3; // x0
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  _QWORD *v8; // x8
  __int64 v9; // x9
  _QWORD *v10; // x10
  char *v11; // x0
  int v12; // w1
  __int64 v13; // x20
  void *TypeFromHandle; // x0
  _QWORD *v15; // x0
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  _QWORD *v20; // x8
  __int64 v21; // x9
  _QWORD *v22; // x10
  char *v23; // x0
  int v24; // w1
  void *v25; // x0
  _QWORD *v26; // x0
  int v27; // w2
  int v28; // w3
  int v29; // w4
  void *v30; // x5
  __int64 v31; // x9
  _QWORD *v32; // x8
  _QWORD *v33; // x10
  char *v34; // x0
  int v35; // w1
  void *v36; // x0
  _QWORD *v37; // x0
  int v38; // w2
  int v39; // w3
  int v40; // w4
  void *v41; // x5
  __int64 v42; // x8
  _QWORD *v43; // x9
  char *v44; // x19
  int v45; // w1

  if ( (unk_F43D9AB & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_ParticleSystem_var);
    sub_63CEE78(&UnityEngine_ParticleSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Texture2D_var);
    sub_63CEE78(&UnityEngine_Texture2D_TypeInfo);
    sub_63CEE78(&UnityEngine_Texture3D_TypeInfo);
    sub_63CEE78(&StringLiteral_VLBDitheringNoise);
    sub_63CEE78(&StringLiteral_DustParticles);
    sub_63CEE78(&StringLiteral_Noise3D_64x64x64);
    sub_63CEE78(&StringLiteral_VLBBlueNoise);
    unk_F43D9AB = 1;
  }
  v3 = UnityEngine_Resources__Load(StringLiteral_Noise3D_64x64x64, nullptr);
  if ( v3 )
  {
    v8 = v3;
    v9 = UnityEngine_Texture3D_TypeInfo;
    if ( *v3 == UnityEngine_Texture3D_TypeInfo )
      v10 = v3;
    else
      v10 = nullptr;
    *((_QWORD *)a0 + 13) = v10;
    v11 = (char *)a0 + 104;
    if ( *v8 == v9 )
      v12 = (int)v8;
    else
      v12 = 0;
  }
  else
  {
    v12 = 0;
    *((_QWORD *)a0 + 13) = 0;
    v11 = (char *)a0 + 104;
  }
  sub_63CEE24(v11, v12, v4, v5, v6, v7);
  v13 = UnityEngine_ParticleSystem_var;
  if ( !*(_DWORD *)(unk_F43F550 + 228LL) )
    sub_63CEFF4(unk_F43F550);
  TypeFromHandle = System_Type__GetTypeFromHandle(v13, nullptr);
  v15 = UnityEngine_Resources__Load_1(StringLiteral_DustParticles, TypeFromHandle, nullptr);
  if ( v15 )
  {
    v20 = v15;
    v21 = UnityEngine_ParticleSystem_TypeInfo;
    if ( *v15 == UnityEngine_ParticleSystem_TypeInfo )
      v22 = v15;
    else
      v22 = nullptr;
    *((_QWORD *)a0 + 14) = v22;
    v23 = (char *)a0 + 112;
    if ( *v20 == v21 )
      v24 = (int)v20;
    else
      v24 = 0;
  }
  else
  {
    v24 = 0;
    *((_QWORD *)a0 + 14) = 0;
    v23 = (char *)a0 + 112;
  }
  sub_63CEE24(v23, v24, v16, v17, v18, v19);
  v25 = System_Type__GetTypeFromHandle(UnityEngine_Texture2D_var, nullptr);
  v26 = UnityEngine_Resources__Load_1(StringLiteral_VLBDitheringNoise, v25, nullptr);
  if ( v26 )
  {
    v31 = UnityEngine_Texture2D_TypeInfo;
    v32 = v26;
    if ( *v26 == UnityEngine_Texture2D_TypeInfo )
      v33 = v26;
    else
      v33 = nullptr;
    *((_QWORD *)a0 + 15) = v33;
    v34 = (char *)a0 + 120;
    if ( *v32 == v31 )
      v35 = (int)v32;
    else
      v35 = 0;
  }
  else
  {
    v35 = 0;
    *((_QWORD *)a0 + 15) = 0;
    v34 = (char *)a0 + 120;
  }
  sub_63CEE24(v34, v35, v27, v28, v29, v30);
  v36 = System_Type__GetTypeFromHandle(UnityEngine_Texture2D_var, nullptr);
  v37 = UnityEngine_Resources__Load_1(StringLiteral_VLBBlueNoise, v36, nullptr);
  if ( v37 )
  {
    v42 = UnityEngine_Texture2D_TypeInfo;
    if ( *v37 == UnityEngine_Texture2D_TypeInfo )
      v43 = v37;
    else
      v43 = nullptr;
    *((_QWORD *)a0 + 16) = v43;
    v44 = (char *)a0 + 128;
    if ( *v37 == v42 )
      v45 = (int)v37;
    else
      v45 = 0;
  }
  else
  {
    v45 = 0;
    *((_QWORD *)a0 + 16) = 0;
    v44 = (char *)a0 + 128;
  }
  sub_63CEE24(v44, v45, v38, v39, v40, v41);
}

