// Campus.Crowd.PenlightMeshRenderSystem$$.cctor @ 0xddcc120
void __fastcall Campus_Crowd_PenlightMeshRenderSystem___cctor(void *a0)
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
  int v15; // w1
  _QWORD *v16; // x8
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5

  if ( (unk_F43BD37 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
    sub_63CEE78(&StringLiteral_UpdatePenlight);
    sub_63CEE78(&StringLiteral__USE_COLOR_TABLE);
    sub_63CEE78(&StringLiteral__PenlightColors);
    sub_63CEE78(&StringLiteral__TargetPenlightType);
    sub_63CEE78(&StringLiteral__PenlightProjectionParams);
    sub_63CEE78(&StringLiteral__PenlightProjectionUV);
    sub_63CEE78(&StringLiteral__PenlightInfoBytesBuffer);
    unk_F43BD37 = 1;
  }
  v5 = StringLiteral_UpdatePenlight;
  **(_QWORD **)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) = StringLiteral_UpdatePenlight;
  sub_63CEE24(*(void **)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL), v5, v1, v2, v3, v4);
  v6 = UnityEngine_Shader__PropertyToID(StringLiteral__TargetPenlightType, nullptr);
  v7 = (void *)StringLiteral__PenlightInfoBytesBuffer;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 8LL) = v6;
  v8 = UnityEngine_Shader__PropertyToID(v7, nullptr);
  v9 = (void *)StringLiteral__PenlightColors;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 12LL) = v8;
  v10 = UnityEngine_Shader__PropertyToID(v9, nullptr);
  v11 = (void *)StringLiteral__PenlightProjectionParams;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 16LL) = v10;
  v12 = UnityEngine_Shader__PropertyToID(v11, nullptr);
  v13 = (void *)StringLiteral__PenlightProjectionUV;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 20LL) = v12;
  v14 = UnityEngine_Shader__PropertyToID(v13, nullptr);
  v15 = StringLiteral__USE_COLOR_TABLE;
  v16 = *(_QWORD **)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL);
  v16[4] = StringLiteral__USE_COLOR_TABLE;
  v16 += 4;
  *((_DWORD *)v16 - 2) = v14;
  sub_63CEE24(v16, v15, v17, v18, v19, v20);
  *(_QWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 40LL) = 0x200000001LL;
}

