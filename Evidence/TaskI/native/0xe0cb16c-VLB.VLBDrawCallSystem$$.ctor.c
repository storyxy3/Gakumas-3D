// VLB.VLBDrawCallSystem$$.ctor @ 0xe0cb16c
void __fastcall VLB_VLBDrawCallSystem___ctor(void *a0, void *a1, void *a2, void *a3)
{
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  void *v15; // x0
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5

  if ( (unk_F43D9DA & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Profiling_CustomSampler_TypeInfo);
    sub_63CEE78(&StringLiteral_VLBCreateDrawCallSystem_Execute);
    unk_F43D9DA = 1;
  }
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 2) = a1;
  sub_63CEE24((char *)a0 + 16, (int)a1, v7, v8, v9, v10);
  *((_QWORD *)a0 + 3) = a2;
  sub_63CEE24((char *)a0 + 24, (int)a2, v11, v12, v13, v14);
  if ( !*(_DWORD *)(UnityEngine_Profiling_CustomSampler_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Profiling_CustomSampler_TypeInfo);
  v15 = UnityEngine_Profiling_CustomSampler__Create(StringLiteral_VLBCreateDrawCallSystem_Execute, 0, nullptr);
  *((_QWORD *)a0 + 4) = v15;
  sub_63CEE24((char *)a0 + 32, (int)v15, v16, v17, v18, v19);
}

