// Campus.Crowd.CrowdMeshRenderSystem$$.cctor @ 0xddc8a3c
void __fastcall Campus_Crowd_CrowdMeshRenderSystem___cctor(void *a0)
{
  int v1; // w2
  int v2; // w3
  int v3; // w4
  void *v4; // x5
  int v5; // w1
  int v6; // w0
  void *v7; // x8
  int v8; // w0
  void *v9; // x8
  int v10; // w0
  void *v11; // x8
  int v12; // w0
  void *v13; // x8
  int v14; // w0
  void *v15; // x8
  int v16; // w0
  void *v17; // x8
  int v18; // w0
  void *v19; // x8
  void *v20; // x19
  __int64 v21; // x0
  int v22; // w2
  int v23; // w3
  int v24; // w4
  void *v25; // x5

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
  v5 = StringLiteral_Skinning;
  **(_QWORD **)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) = StringLiteral_Skinning;
  sub_63CEE24(*(void **)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL), v5, v1, v2, v3, v4);
  v6 = UnityEngine_Shader__PropertyToID(StringLiteral__VertexCount, nullptr);
  v7 = (void *)StringLiteral__BoneCount;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 8LL) = v6;
  v8 = UnityEngine_Shader__PropertyToID(v7, nullptr);
  v9 = (void *)StringLiteral__InVertices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 12LL) = v8;
  v10 = UnityEngine_Shader__PropertyToID(v9, nullptr);
  v11 = (void *)StringLiteral__InSkins;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 16LL) = v10;
  v12 = UnityEngine_Shader__PropertyToID(v11, nullptr);
  v13 = (void *)StringLiteral__InMatrices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 20LL) = v12;
  v14 = UnityEngine_Shader__PropertyToID(v13, nullptr);
  v15 = (void *)StringLiteral__OutVertices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 24LL) = v14;
  v16 = UnityEngine_Shader__PropertyToID(v15, nullptr);
  v17 = (void *)StringLiteral__MeshInfo;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 28LL) = v16;
  v18 = UnityEngine_Shader__PropertyToID(v17, nullptr);
  v19 = (void *)StringLiteral__HandMatrices;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 32LL) = v18;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 36LL) = UnityEngine_Shader__PropertyToID(
                                                                                           v19,
                                                                                           nullptr);
  v20 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v20, StringLiteral_CrowdMeshRenderSystem_Create, nullptr);
  v21 = *(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL);
  *(_QWORD *)(v21 + 40) = v20;
  sub_63CEE24((void *)(v21 + 40), (int)v20, v22, v23, v24, v25);
  *(_QWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 48LL) = 0x300000002LL;
}

