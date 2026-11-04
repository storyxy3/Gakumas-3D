// 0xd1cd27c @ 0xd1cd27c
void __fastcall ProFlareRenderingSystem___cctor(void *a0)
{
  int v1; // w0
  __int64 v2; // x1
  __int64 v3; // x8
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F42C91F & 1) == 0 )
  {
    sub_63CEE78(&ProFlareRenderingSystem_TypeInfo);
    sub_63CEE78(&StringLiteral_Update);
    sub_63CEE78(&StringLiteral__ProcessBuffer);
    unk_F42C91F = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID((void *)StringLiteral__ProcessBuffer, nullptr);
  v2 = StringLiteral_Update;
  v3 = *(_QWORD *)(ProFlareRenderingSystem_TypeInfo + 184LL);
  *(_DWORD *)v3 = v1;
  *(_QWORD *)(v3 + 8) = v2;
  sub_63CEE24((void *)(v3 + 8), v2, v4, v5, v6, v7);
}

