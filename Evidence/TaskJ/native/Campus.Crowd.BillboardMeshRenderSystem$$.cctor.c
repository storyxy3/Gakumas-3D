// Campus.Crowd.BillboardMeshRenderSystem$$.cctor @ 0xddc78d4
void __fastcall Campus_Crowd_BillboardMeshRenderSystem___cctor(void *a0)
{
  int v1; // w0
  void *v2; // x8
  int v3; // w0
  void *v4; // x8
  __int64 v5; // x8
  __int128 v6; // q2
  __int128 v7; // q1
  __int128 v8; // q3
  __int64 v9; // x9
  __int128 v10; // [xsp+0h] [xbp+0h] BYREF
  __int128 v11; // [xsp+10h] [xbp+10h]
  __int128 v12; // [xsp+20h] [xbp+20h]
  __int128 v13; // [xsp+30h] [xbp+30h]
  __int128 v14; // [xsp+40h] [xbp+40h] BYREF
  __int128 v15; // [xsp+50h] [xbp+50h]
  __int128 v16; // [xsp+60h] [xbp+60h]
  __int128 v17; // [xsp+70h] [xbp+70h]
  __int128 v18; // [xsp+80h] [xbp+80h] BYREF
  __int128 v19; // [xsp+90h] [xbp+90h]
  __int128 v20; // [xsp+A0h] [xbp+A0h]
  __int128 v21; // [xsp+B0h] [xbp+B0h]

  if ( (unk_F43BD07 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    sub_63CEE78(&StringLiteral__BillboardOffset);
    sub_63CEE78(&StringLiteral__BillboardTexture);
    sub_63CEE78(&StringLiteral__BillboardMatrices);
    unk_F43BD07 = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID(StringLiteral__BillboardTexture, nullptr);
  v2 = (void *)StringLiteral__BillboardMatrices;
  **(_DWORD **)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL) = v1;
  v3 = UnityEngine_Shader__PropertyToID(v2, nullptr);
  v4 = (void *)StringLiteral__BillboardOffset;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL) + 4LL) = v3;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL) + 8LL) = UnityEngine_Shader__PropertyToID(
                                                                                              v4,
                                                                                              nullptr);
  UnityEngine_Matrix4x4__Ortho((UnityEngine_Matrix4x4_o *)&v18, -0.5, 0.5, -0.5, 0.5, -10.0, 10.0, nullptr);
  v10 = v18;
  v11 = v19;
  v12 = v20;
  v13 = v21;
  UnityEngine_GL__GetGPUProjectionMatrix((UnityEngine_Matrix4x4_o *)&v14, (UnityEngine_Matrix4x4_o *)&v10, 0, nullptr);
  v5 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
  v6 = v15;
  v8 = v16;
  v7 = v17;
  v9 = *(_QWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL);
  *(_OWORD *)(v9 + 12) = v14;
  *(_OWORD *)(v9 + 60) = v7;
  *(_OWORD *)(v9 + 44) = v8;
  *(_OWORD *)(v9 + 28) = v6;
  *(_QWORD *)(*(_QWORD *)(v5 + 184) + 76LL) = 0x100000000LL;
}

