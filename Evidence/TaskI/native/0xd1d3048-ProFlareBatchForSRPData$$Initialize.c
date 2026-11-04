// 0xd1d3048 @ 0xd1d3048
void __fastcall ProFlareBatchForSRPData__Initialize(void *a0, int a1, void *a2)
{
  __int64 v5; // x8
  void **v6; // x21
  int v7; // w22
  void *v8; // x23
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v13; // x1
  void *v14; // x0
  void **v15; // x21
  int v16; // w22
  void *v17; // x23
  int v18; // w2
  int v19; // w3
  int v20; // w4
  void *v21; // x5
  void **v22; // x21
  int v23; // w22
  __int64 v24; // x9
  __int64 v25; // x8
  int v26; // w11
  int8x8_t v27; // d1
  int v28; // w13
  __int64 v29; // x12
  int v30; // w13
  unsigned __int64 v31; // d1
  void *v32; // x20
  int v33; // w2
  int v34; // w3
  int v35; // w4
  void *v36; // x5
  _OWORD *v37; // x19
  __int64 v38; // t1
  void *v39; // x0
  void *v40; // x1
  __int128 v41; // [xsp+0h] [xbp+0h] BYREF
  __int64 v42; // [xsp+10h] [xbp+10h] BYREF
  void *v43; // [xsp+18h] [xbp+18h]
  __int64 v44; // [xsp+20h] [xbp+20h] BYREF
  void *v45; // [xsp+28h] [xbp+28h]

  if ( (unk_F42C94F & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_ComputeBuffer_SetData_ProFlareInputData___);
    sub_63CEE78(&Method_UnityEngine_ComputeBuffer_SetData_ProFlareProcessData___);
    sub_63CEE78(&UnityEngine_ComputeBuffer_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GraphicsBuffer_SetData_int___);
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareInputData___);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareProcessData___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareProcessData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareInputData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareProcessData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int___ctor___1);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareInputData__get_IsCreated__);
    unk_F42C94F = 1;
  }
  v44 = 0;
  v45 = nullptr;
  v5 = *((_QWORD *)a0 + 23);
  v42 = 0;
  v43 = nullptr;
  *((_DWORD *)a0 + 55) = 4;
  if ( !v5 )
  {
    v41 = 0u;
    Unity_Collections_NativeArray_ProFlareInputData____ctor(
      (__int64)&v41,
      a1,
      4,
      1,
      Method_Unity_Collections_NativeArray_ProFlareInputData___ctor__);
    *(_OWORD *)((char *)a0 + 184) = v41;
  }
  v6 = (void **)((char *)a0 + 176);
  if ( !*((_QWORD *)a0 + 22) )
  {
    if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
      sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
    v7 = System_Runtime_InteropServices_Marshal__SizeOf_ProFlareInputData_(Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareInputData___);
    v8 = (void *)sub_63CF110(UnityEngine_ComputeBuffer_TypeInfo);
    UnityEngine_ComputeBuffer___ctor_2(v8, a1, v7, 16, 0, nullptr);
    *v6 = v8;
    sub_63CEE24((char *)a0 + 176, (int)v8, v9, v10, v11, v12);
    v14 = *v6;
    if ( !*v6 )
      goto LABEL_24;
    UnityEngine_ComputeBuffer__SetData_ProFlareInputData_(v14, *((_QWORD *)a0 + 23), *((void **)a0 + 24));
  }
  v15 = (void **)((char *)a0 + 200);
  if ( !*((_QWORD *)a0 + 25) )
  {
    if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
      sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
    v16 = System_Runtime_InteropServices_Marshal__SizeOf_ProFlareProcessData_(Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareProcessData___);
    v17 = (void *)sub_63CF110(UnityEngine_ComputeBuffer_TypeInfo);
    UnityEngine_ComputeBuffer___ctor_2(v17, a1, v16, 16, 0, nullptr);
    *v15 = v17;
    sub_63CEE24((char *)a0 + 200, (int)v17, v18, v19, v20, v21);
    Unity_Collections_NativeArray_ProFlareProcessData____ctor(
      (__int64)&v44,
      a1,
      2,
      1,
      Method_Unity_Collections_NativeArray_ProFlareProcessData___ctor__);
    v14 = *v15;
    if ( !*v15 )
      goto LABEL_24;
    UnityEngine_ComputeBuffer__SetData_ProFlareProcessData_(v14, v44, v45);
    Unity_Collections_NativeArray_ProFlareProcessData___Dispose(
      (__int64)&v44,
      Method_Unity_Collections_NativeArray_ProFlareProcessData__Dispose__);
  }
  ProFlareBatchForSRPData__UpdateElementData(a0, a1, a2);
  v22 = (void **)((char *)a0 + 80);
  if ( *((_QWORD *)a0 + 10) )
    goto LABEL_21;
  v23 = 6 * a1;
  Unity_Collections_NativeArray_int____ctor(
    (__int64)&v42,
    6 * a1,
    2,
    1,
    (void *)Method_Unity_Collections_NativeArray_int___ctor___1);
  if ( a1 >= 1 )
  {
    v24 = v42;
    v25 = 0;
    v26 = 0;
    do
    {
      v27.n64_u64[0] = vdup_n_s32(v25).n64_u64[0];
      v28 = v25 + 2;
      *(_DWORD *)(v24 + 4LL * (v26 + 2)) = v25 + 2;
      *(_DWORD *)(v24 + 4LL * v26) = v25;
      v25 += 4;
      v29 = 4LL * (v26 + 4);
      *(_DWORD *)(v24 + 4LL * (v26 + 3)) = v28;
      v30 = v26 + 1;
      v31 = vorr_s8(v27, (int8x8_t)0x300000001LL).n64_u64[0];
      v26 += 6;
      *(_DWORD *)(v24 + 4LL * v30) = v31;
      *(_QWORD *)(v24 + v29) = v31;
    }
    while ( 4LL * (unsigned int)a1 != v25 );
  }
  v32 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v32, 34, v23, 4, nullptr);
  *v22 = v32;
  sub_63CEE24((char *)a0 + 80, (int)v32, v33, v34, v35, v36);
  v14 = *v22;
  if ( !*v22 )
  {
LABEL_24:
    v39 = (void *)sub_63CF120(v14, v13);
    ProFlareBatchForSRP__Dispose(v39, v40);
    return;
  }
  UnityEngine_GraphicsBuffer__SetData_int_(v14, v42, v43);
  Unity_Collections_NativeArray_int___Dispose(
    (__int64)&v42,
    (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
LABEL_21:
  v38 = *((_QWORD *)a0 + 18);
  v37 = (char *)a0 + 144;
  if ( !v38 )
  {
    v41 = 0u;
    Unity_Collections_NativeArray_ProFlareUpdateInOutputData____ctor(
      (__int64)&v41,
      1024,
      4,
      1,
      Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData___ctor__);
    *v37 = v41;
  }
}

