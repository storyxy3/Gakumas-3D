// VLB.VLBDrawSystem$$.ctor @ 0xe0cbd0c
void __fastcall VLB_VLBDrawSystem___ctor(void *a0, void *a1, void *a2)
{
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  __int64 v9; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  __int64 v14; // x0
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  __int64 v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  __int64 v24; // x0
  int v25; // w2
  int v26; // w3
  int v27; // w4
  void *v28; // x5
  __int64 v29; // x0
  int v30; // w2
  int v31; // w3
  int v32; // w4
  void *v33; // x5
  void *v34; // x0
  int v35; // w2
  int v36; // w3
  int v37; // w4
  void *v38; // x5

  if ( (unk_F43D9DD & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Profiling_CustomSampler_TypeInfo);
    sub_63CEE78(&UnityEngine_Matrix4x4___TypeInfo);
    sub_63CEE78(&UnityEngine_Vector4___TypeInfo);
    sub_63CEE78(&StringLiteral_VLBDrawCallSystem);
    unk_F43D9DD = 1;
  }
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 3) = a1;
  sub_63CEE24((char *)a0 + 24, (int)a1, v5, v6, v7, v8);
  v9 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 200);
  *((_QWORD *)a0 + 4) = v9;
  sub_63CEE24((char *)a0 + 32, v9, v10, v11, v12, v13);
  v14 = sub_63CEF64(UnityEngine_Vector4___TypeInfo, 200);
  *((_QWORD *)a0 + 5) = v14;
  sub_63CEE24((char *)a0 + 40, v14, v15, v16, v17, v18);
  v19 = sub_63CEF64(UnityEngine_Vector4___TypeInfo, 200);
  *((_QWORD *)a0 + 6) = v19;
  sub_63CEE24((char *)a0 + 48, v19, v20, v21, v22, v23);
  v24 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 200);
  *((_QWORD *)a0 + 7) = v24;
  sub_63CEE24((char *)a0 + 56, v24, v25, v26, v27, v28);
  v29 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 200);
  *((_QWORD *)a0 + 8) = v29;
  sub_63CEE24((char *)a0 + 64, v29, v30, v31, v32, v33);
  if ( !*(_DWORD *)(UnityEngine_Profiling_CustomSampler_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Profiling_CustomSampler_TypeInfo);
  v34 = UnityEngine_Profiling_CustomSampler__Create(StringLiteral_VLBDrawCallSystem, 0, nullptr);
  *((_QWORD *)a0 + 9) = v34;
  sub_63CEE24((char *)a0 + 72, (int)v34, v35, v36, v37, v38);
}

