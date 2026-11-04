// 0xd1d356c @ 0xd1d356c
void __fastcall ProFlareBatchForSRPData__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  void *v8; // x0
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  void *v13; // x0
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  void *v18; // x0
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x20
  bool v24; // w0
  __int64 v25; // x1
  void *v26; // x20
  void *v27; // x0
  void *name; // x1
  void *v29; // x19
  void *v30; // x0
  void *v31; // x1

  if ( (unk_F42C951 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareInputData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateElementData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareElementData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4__Dispose___1);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareElementData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareInputData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateElementData__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&StringLiteral_Dispose_FlareData__);
    sub_63CEE78(&StringLiteral___40);
    sub_63CEE78(&StringLiteral_);
    unk_F42C951 = 1;
  }
  v3 = *((void **)a0 + 10);
  if ( v3 )
  {
    UnityEngine_GraphicsBuffer__Dispose(v3, nullptr);
    *((_QWORD *)a0 + 10) = 0;
    sub_63CEE24((char *)a0 + 80, 0, v4, v5, v6, v7);
  }
  if ( *((_QWORD *)a0 + 11) )
    Unity_Collections_NativeArray_float4___Dispose_1((__int64)a0 + 88, *((_QWORD *)a0 + 20), *((void **)a0 + 21));
  v8 = *((void **)a0 + 13);
  if ( v8 )
  {
    UnityEngine_ComputeBuffer__Release(v8, nullptr);
    *((_QWORD *)a0 + 13) = 0;
    sub_63CEE24((char *)a0 + 104, 0, v9, v10, v11, v12);
  }
  if ( *((_QWORD *)a0 + 14) )
    Unity_Collections_NativeArray_ProFlareElementData___Dispose_1(
      (__int64)a0 + 112,
      *((_QWORD *)a0 + 20),
      *((void **)a0 + 21));
  if ( *((_QWORD *)a0 + 16) )
    Unity_Collections_NativeArray_ProFlareUpdateElementData___Dispose_1(
      (__int64)a0 + 128,
      *((_QWORD *)a0 + 20),
      *((void **)a0 + 21));
  v13 = *((void **)a0 + 22);
  if ( v13 )
  {
    UnityEngine_ComputeBuffer__Release(v13, nullptr);
    *((_QWORD *)a0 + 22) = 0;
    sub_63CEE24((char *)a0 + 176, 0, v14, v15, v16, v17);
  }
  if ( *((_QWORD *)a0 + 23) )
    Unity_Collections_NativeArray_ProFlareInputData___Dispose_1(
      (__int64)a0 + 184,
      *((_QWORD *)a0 + 20),
      *((void **)a0 + 21));
  v18 = *((void **)a0 + 25);
  if ( v18 )
  {
    UnityEngine_ComputeBuffer__Release(v18, nullptr);
    *((_QWORD *)a0 + 25) = 0;
    sub_63CEE24((char *)a0 + 200, 0, v19, v20, v21, v22);
  }
  if ( *((_QWORD *)a0 + 18) )
    Unity_Collections_NativeArray_ProFlareUpdateInOutputData___Dispose_1(
      (__int64)a0 + 144,
      *((_QWORD *)a0 + 20),
      *((void **)a0 + 21));
  v23 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v24 = UnityEngine_Object__op_Inequality(v23, nullptr, nullptr);
  v26 = (void *)StringLiteral_Dispose_FlareData__;
  if ( v24 )
  {
    v27 = *((void **)a0 + 5);
    if ( !v27 )
    {
      v30 = (void *)sub_63CF120(0, v25);
      ProFlareBatchForSRP__OnDisable(v30, v31);
      return;
    }
    name = UnityEngine_Object__get_name(v27, nullptr);
  }
  else
  {
    name = (void *)StringLiteral_;
  }
  v29 = System_String__Concat_3(v26, name, StringLiteral___40, nullptr);
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__Log(v29, nullptr);
}

