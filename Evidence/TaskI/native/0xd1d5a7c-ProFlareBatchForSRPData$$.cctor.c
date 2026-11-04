// 0xd1d5a7c @ 0xd1d5a7c
void __fastcall ProFlareBatchForSRPData___cctor(void *a0)
{
  int v1; // w0
  void *v2; // x8
  int v3; // w0
  void *v4; // x8
  int v5; // w0
  void *v6; // x8
  int v7; // w0
  void *v8; // x8

  if ( (unk_F42C952 & 1) == 0 )
  {
    sub_63CEE78(&ProFlareBatchForSRPData_TypeInfo);
    sub_63CEE78(&StringLiteral__ElementBuffer);
    sub_63CEE78(&StringLiteral__MainTex);
    sub_63CEE78(&StringLiteral__OcclusionParams);
    sub_63CEE78(&StringLiteral__ProcessBuffer);
    sub_63CEE78(&StringLiteral__InputBuffer);
    unk_F42C952 = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID(StringLiteral__InputBuffer, nullptr);
  v2 = (void *)StringLiteral__ProcessBuffer;
  **(_DWORD **)(ProFlareBatchForSRPData_TypeInfo + 184LL) = v1;
  v3 = UnityEngine_Shader__PropertyToID(v2, nullptr);
  v4 = (void *)StringLiteral__OcclusionParams;
  *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 4LL) = v3;
  v5 = UnityEngine_Shader__PropertyToID(v4, nullptr);
  v6 = (void *)StringLiteral__ElementBuffer;
  *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 8LL) = v5;
  v7 = UnityEngine_Shader__PropertyToID(v6, nullptr);
  v8 = StringLiteral__MainTex;
  *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 12LL) = v7;
  *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 16LL) = UnityEngine_Shader__PropertyToID(
                                                                                v8,
                                                                                nullptr);
}

