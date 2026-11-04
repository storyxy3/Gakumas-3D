// VLB.VLBUpdateCachedSystem$$.ctor @ 0xe0ca244
void __fastcall VLB_VLBUpdateCachedSystem___ctor(void *a0, void *a1, void *a2)
{
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  void *v9; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5

  if ( (unk_F43D9CA & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Profiling_CustomSampler_TypeInfo);
    sub_63CEE78(&StringLiteral_UpdateCachedSystem_Execute);
    unk_F43D9CA = 1;
  }
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 2) = a1;
  sub_63CEE24((char *)a0 + 16, (int)a1, v5, v6, v7, v8);
  if ( !*(_DWORD *)(UnityEngine_Profiling_CustomSampler_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Profiling_CustomSampler_TypeInfo);
  v9 = UnityEngine_Profiling_CustomSampler__Create(StringLiteral_UpdateCachedSystem_Execute, 0, nullptr);
  *((_QWORD *)a0 + 3) = v9;
  sub_63CEE24((char *)a0 + 24, (int)v9, v10, v11, v12, v13);
}

