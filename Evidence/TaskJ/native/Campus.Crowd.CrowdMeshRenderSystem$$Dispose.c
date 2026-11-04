// Campus.Crowd.CrowdMeshRenderSystem$$Dispose @ 0xddc8940
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__Dispose(void *a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  unsigned __int64 v4; // x21
  __int64 v5; // x22
  __int64 v6; // x23
  __int64 v7; // x24
  __int64 v8; // x25
  __int64 v9; // x26
  __int64 v10; // x27
  __int64 v11; // x28
  __int64 v12; // x29
  void *v14; // x0
  __int64 v15; // x20
  __int64 v16; // x8
  void *v17; // x20
  void *v18; // x19
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  __int64 v23; // x30
  int v24; // w1
  int v25; // w0
  void *v26; // x8
  int v27; // w0
  void *v28; // x8
  int v29; // w0
  void *v30; // x8
  int v31; // w0
  void *v32; // x8
  int v33; // w0
  void *v34; // x8
  int v35; // w0
  void *v36; // x8
  int v37; // w0
  void *v38; // x8
  void *v39; // x19
  __int64 v40; // x0
  int v41; // w2
  int v42; // w3
  int v43; // w4
  void *v44; // x5
  __int64 v45; // [xsp+0h] [xbp+0h]
  __int64 v46; // [xsp+10h] [xbp+10h]
  __int64 v47; // [xsp+18h] [xbp+18h]
  __int64 v48; // [xsp+20h] [xbp+20h]
  __int64 v49; // [xsp+28h] [xbp+28h]
  __int64 v50; // [xsp+30h] [xbp+30h]
  __int64 v51; // [xsp+38h] [xbp+38h]
  __int64 v52; // [xsp+40h] [xbp+40h]
  unsigned __int64 v53; // [xsp+48h] [xbp+48h]
  __int64 v54; // [xsp+50h] [xbp+50h]
  void *v55; // [xsp+58h] [xbp+58h]

  if ( (unk_F43BD0E & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD0E = 1;
  }
  v14 = *((void **)a0 + 6);
  if ( v14 )
    UnityEngine_GraphicsBuffer__Dispose(v14, nullptr);
  v15 = *((_QWORD *)a0 + 7);
  if ( v15 )
  {
    v16 = *(_QWORD *)(v15 + 24);
    if ( (int)v16 < 1 )
    {
LABEL_12:
      v17 = *((void **)a0 + 5);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( UnityEngine_Object__op_Inequality(v17, nullptr, nullptr) )
      {
        v18 = *((void **)a0 + 5);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        UnityEngine_Object__DestroyImmediate_1(v18, nullptr);
      }
      return;
    }
    v4 = 0;
    v5 = v15 + 32;
    while ( v4 < (unsigned int)v16 )
    {
      v14 = *(void **)(v5 + 8 * v4);
      if ( v14 )
        UnityEngine_GraphicsBuffer__Dispose(v14, nullptr);
      LODWORD(v16) = *(_DWORD *)(v15 + 24);
      if ( (__int64)++v4 >= (int)v16 )
        goto LABEL_12;
    }
    sub_63CF128(v14, a1, v2, v3);
  }
  sub_63CF120(v14, a1);
  *(&v45 - 12) = v12;
  *(&v45 - 11) = v23;
  v46 = v11;
  v47 = v10;
  v48 = v9;
  v49 = v8;
  v50 = v7;
  v51 = v6;
  v52 = v5;
  v53 = v4;
  v54 = v15;
  v55 = a0;
  if ( (unk_F43BD10 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&StringLiteral__HandMatrices);
    sub_63CEE78(&StringLiteral__InSkins);
    sub_63CEE78(&StringLiteral__VertexCount);
    sub_63CEE78(&StringLiteral__InMatrices);
    sub_63CEE78(&StringLiteral__OutVertices);
    sub_63CEE78(&StringLiteral_Skinning);
    sub_63CEE78(&StringLiteral_CrowdMeshRenderSystem_Create);
    sub_63CEE78(&StringLiteral__BoneCount);
    sub_63CEE78(&StringLiteral__MeshInfo);
    sub_63CEE78(&StringLiteral__InVertices);
    unk_F43BD10 = 1;
  }
  v24 = StringLiteral_Skinning;
  **(_QWORD **)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) = StringLiteral_Skinning;
  sub_63CEE24(*(void **)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL), v24, v19, v20, v21, v22);
  v25 = UnityEngine_Shader__PropertyToID(StringLiteral__VertexCount, nullptr);
  v26 = (void *)StringLiteral__BoneCount;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 8LL) = v25;
  v27 = UnityEngine_Shader__PropertyToID(v26, nullptr);
  v28 = (void *)StringLiteral__InVertices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 12LL) = v27;
  v29 = UnityEngine_Shader__PropertyToID(v28, nullptr);
  v30 = (void *)StringLiteral__InSkins;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 16LL) = v29;
  v31 = UnityEngine_Shader__PropertyToID(v30, nullptr);
  v32 = (void *)StringLiteral__InMatrices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 20LL) = v31;
  v33 = UnityEngine_Shader__PropertyToID(v32, nullptr);
  v34 = (void *)StringLiteral__OutVertices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 24LL) = v33;
  v35 = UnityEngine_Shader__PropertyToID(v34, nullptr);
  v36 = (void *)StringLiteral__MeshInfo;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 28LL) = v35;
  v37 = UnityEngine_Shader__PropertyToID(v36, nullptr);
  v38 = (void *)StringLiteral__HandMatrices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 32LL) = v37;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 36LL) = UnityEngine_Shader__PropertyToID(
                                                                                           v38,
                                                                                           nullptr);
  v39 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v39, StringLiteral_CrowdMeshRenderSystem_Create, nullptr);
  v40 = *(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL);
  *(_QWORD *)(v40 + 40) = v39;
  sub_63CEE24((void *)(v40 + 40), (int)v39, v41, v42, v43, v44);
  *(_QWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 48LL) = 0x300000002LL;
}

