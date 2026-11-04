// Campus.Live.Equipment.Environment.LiveLaser$$OnEnable @ 0xddb663c
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__OnEnable(void *a0, void *a1)
{
  void *v3; // x21
  void **v4; // x20
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  void *v9; // x21
  void *name; // x0
  void *gameObject; // x0
  __int64 v12; // x1
  __int64 v13; // x21
  int v14; // w2
  int v15; // w3
  __int64 v16; // x8
  __int64 v17; // x9
  float v18; // s4
  unsigned int v19; // w11
  __int64 v20; // x12
  __int64 v21; // x16
  __int64 v22; // x15
  float v23; // s7
  int v24; // w14
  int v25; // w8
  int v26; // w10
  __int64 v27; // x9
  int i; // w11
  char v29; // w14
  int v30; // w13
  char v31; // w0
  int v32; // w14
  __int16 v33; // w16
  int v34; // w17
  void *v35; // x21
  void *sharedMaterial; // x21
  void *v37; // x0
  int v38; // w2
  int v39; // w3
  int v40; // w4
  void *v41; // x5
  void *v42; // x0
  void *v43; // x1
  __int128 v44; // [xsp+10h] [xbp+10h] BYREF
  __int128 v45; // [xsp+20h] [xbp+20h] BYREF
  __int128 v46; // [xsp+30h] [xbp+30h] BYREF
  __int128 v47; // [xsp+40h] [xbp+40h] BYREF
  __int128 v48; // [xsp+50h] [xbp+50h] BYREF

  if ( (unk_F43BC73 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_MeshFilter___);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GameObject_AddComponent_MeshFilter___);
    sub_63CEE78(&Method_UnityEngine_Mesh_SetIndexBufferData_ushort___);
    sub_63CEE78(&Method_UnityEngine_Mesh_SetVertexBufferData_LiveLaser_VertexLayout___);
    sub_63CEE78(&UnityEngine_Mesh_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ushort___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_LiveLaser_VertexLayout___ctor__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_VertexAttributeDescriptor___TypeInfo);
    sub_63CEE78(&StringLiteral_LaserMesh_);
    sub_63CEE78(&StringLiteral_Laser__Renderer__________);
    sub_63CEE78(&StringLiteral_Material_________);
    unk_F43BC73 = 1;
  }
  v3 = (void *)sub_63CF110(UnityEngine_Mesh_TypeInfo);
  UnityEngine_Mesh___ctor(v3, nullptr);
  *((_QWORD *)a0 + 15) = v3;
  v4 = (void **)((char *)a0 + 120);
  sub_63CEE24((char *)a0 + 120, (int)v3, v5, v6, v7, v8);
  v9 = *((void **)a0 + 15);
  name = UnityEngine_Object__get_name(a0, nullptr);
  gameObject = System_String__Concat_2(StringLiteral_LaserMesh_, name, nullptr);
  if ( !v9 )
    goto LABEL_49;
  UnityEngine_Object__set_name(v9, gameObject, nullptr);
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Object__set_hideFlags(gameObject, 52, nullptr);
  v13 = sub_63CEF64(UnityEngine_Rendering_VertexAttributeDescriptor___TypeInfo, 4);
  v48 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v48, 0, 0, 3, 0, nullptr);
  if ( !v13 )
    goto LABEL_49;
  if ( !*(_DWORD *)(v13 + 24) )
    goto LABEL_50;
  *(_OWORD *)(v13 + 32) = v48;
  v47 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v47, 3, 0, 4, 0, nullptr);
  if ( (*(_DWORD *)(v13 + 24) & 0xFFFFFFFE) == 0 )
    goto LABEL_50;
  *(_OWORD *)(v13 + 48) = v47;
  v46 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v46, 4, 0, 2, 0, nullptr);
  if ( *(_DWORD *)(v13 + 24) <= 2u )
    goto LABEL_50;
  *(_OWORD *)(v13 + 64) = v46;
  v45 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v45, 5, 0, 2, 0, nullptr);
  if ( (*(_DWORD *)(v13 + 24) & 0xFFFFFFFC) == 0 )
    goto LABEL_50;
  *(_OWORD *)(v13 + 80) = v45;
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Mesh__SetVertexBufferParams(gameObject, 240, (void *)v13, nullptr);
  v44 = 0u;
  Unity_Collections_NativeArray_LiveLaser_VertexLayout____ctor(
    (__int64)&v44,
    240,
    4,
    0,
    Method_Unity_Collections_NativeArray_LiveLaser_VertexLayout___ctor__);
  v16 = 0;
  v17 = 0;
  *(_OWORD *)((char *)a0 + 136) = v44;
  do
  {
    v18 = vcvts_n_f32_s32(v17, 4u);
    v19 = 0;
    v20 = 0;
    do
    {
      v21 = v16 + v20;
      v20 += 44;
      v22 = *((_QWORD *)a0 + 17) + v21;
      *(_DWORD *)(v22 + 4) = 0;
      *(_QWORD *)(v22 + 20) = 0;
      v23 = vcvts_n_f32_s32(v19 / 3, 2u);
      *(_QWORD *)(v22 + 12) = 0;
      v24 = v19 % 3;
      ++v19;
      *(float *)(v22 + 8) = v23;
      *(float *)v22 = vcvts_n_f32_s32(v24, 1u) + -0.5;
      *(float *)(v22 + 36) = v18 + vcvts_n_f32_s32(v24, 5u);
      *(float *)(v22 + 40) = v23;
      *(float *)(v22 + 28) = (float)((float)((float)v24 * 0.124) + 0.001) + 0.75;
      *(float *)(v22 + 32) = v23;
    }
    while ( v20 != 660 );
    ++v17;
    v16 += 660;
  }
  while ( v17 != 16 );
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Mesh__SetVertexBufferData_LiveLaser_VertexLayout_(
    gameObject,
    *((_QWORD *)a0 + 17),
    *((_QWORD *)a0 + 18),
    0,
    0,
    240,
    0,
    nullptr);
  v48 = 0u;
  Unity_Collections_NativeArray_ushort____ctor(
    (__int64)&v48,
    768,
    4,
    0,
    (void *)Method_Unity_Collections_NativeArray_ushort___ctor__);
  v25 = 0;
  v26 = 0;
  *(_OWORD *)((char *)a0 + 152) = v48;
  v27 = *((_QWORD *)a0 + 19);
  do
  {
    for ( i = 0; i != 4; ++i )
    {
      v29 = 1;
      v30 = 3 * i + 15 * v26;
      do
      {
        v31 = v29;
        *(_WORD *)(v27 + 2LL * (v25 + 4)) = v30 + 3;
        v32 = v25 + 5;
        *(_WORD *)(v27 + 2LL * v25) = v30;
        *(_WORD *)(v27 + 2LL * (v25 + 1)) = v30 + 3;
        v33 = v30++ + 4;
        *(_WORD *)(v27 + 2LL * (v25 + 2)) = v30;
        v34 = v25 + 3;
        v25 += 6;
        *(_WORD *)(v27 + 2LL * v32) = v33;
        v29 = 0;
        *(_WORD *)(v27 + 2LL * v34) = v30;
      }
      while ( (v31 & 1) != 0 );
    }
    ++v26;
  }
  while ( v26 != 16 );
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Mesh__SetIndexBufferParams(gameObject, 768, 0, nullptr);
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Mesh__SetIndexBufferData_ushort_(
    gameObject,
    *((_QWORD *)a0 + 19),
    *((_QWORD *)a0 + 20),
    0,
    0,
    768,
    nullptr);
  gameObject = *((void **)a0 + 15);
  if ( !gameObject )
    goto LABEL_49;
  UnityEngine_Mesh__set_subMeshCount(gameObject, 1, nullptr);
  gameObject = *v4;
  if ( !*v4 )
    goto LABEL_49;
  UnityEngine_Mesh__MarkDynamic(gameObject, nullptr);
  v35 = *((void **)a0 + 6);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v35, nullptr, nullptr) )
  {
    gameObject = *((void **)a0 + 6);
    if ( gameObject )
    {
      UnityEngine_Renderer__set_shadowCastingMode(gameObject, 0, nullptr);
      gameObject = *((void **)a0 + 6);
      if ( gameObject )
      {
        UnityEngine_Renderer__set_lightProbeUsage(gameObject, 0, nullptr);
        gameObject = *((void **)a0 + 6);
        if ( gameObject )
        {
          sharedMaterial = UnityEngine_Renderer__get_sharedMaterial(gameObject, nullptr);
          if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Object_TypeInfo);
          if ( UnityEngine_Object__op_Equality(sharedMaterial, nullptr, nullptr) )
          {
            if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
              sub_63CEFF4(UnityEngine_Debug_TypeInfo);
            UnityEngine_Debug__LogError(StringLiteral_Material_________, nullptr);
          }
          gameObject = *((void **)a0 + 6);
          if ( gameObject )
          {
            if ( UnityEngine_Component__TryGetComponent_object_(
                   gameObject,
                   (char *)a0 + 128,
                   Method_UnityEngine_Component_TryGetComponent_MeshFilter___) )
            {
              goto LABEL_43;
            }
            gameObject = *((void **)a0 + 6);
            if ( gameObject )
            {
              gameObject = UnityEngine_Component__get_gameObject(gameObject, nullptr);
              if ( gameObject )
              {
                v37 = UnityEngine_GameObject__AddComponent_object_(
                        gameObject,
                        Method_UnityEngine_GameObject_AddComponent_MeshFilter___);
                *((_QWORD *)a0 + 16) = v37;
                sub_63CEE24((char *)a0 + 128, (int)v37, v38, v39, v40, v41);
LABEL_43:
                gameObject = *((void **)a0 + 16);
                if ( gameObject )
                {
                  UnityEngine_MeshFilter__set_sharedMesh(gameObject, *v4, nullptr);
                  return;
                }
              }
            }
          }
        }
      }
    }
LABEL_49:
    gameObject = (void *)sub_63CF120(gameObject, v12);
LABEL_50:
    sub_63CF128(gameObject, v12, v14, v15);
    Campus_Live_Equipment_Environment_LiveLaser__OnDisable(v42, v43);
    return;
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(StringLiteral_Laser__Renderer__________, nullptr);
}

