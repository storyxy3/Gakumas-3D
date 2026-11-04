// 0xd1d58c8 @ 0xd1d58c8
void __fastcall ProFlareBatchForSRPData__UpdateElementData(void *a0, int a1, void *a2)
{
  void **v5; // x21
  int v6; // w22
  void *v7; // x23
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  __int64 v12; // x1
  void *v13; // x0
  void *v14; // x1
  __int128 v15; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F42C94E & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_ComputeBuffer_SetData_ProFlareElementData___);
    sub_63CEE78(&UnityEngine_ComputeBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareElementData___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateElementData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareElementData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareElementData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateElementData__get_IsCreated__);
    unk_F42C94E = 1;
  }
  if ( !*((_QWORD *)a0 + 14) )
  {
    v15 = 0u;
    Unity_Collections_NativeArray_ProFlareElementData____ctor(
      (__int64)&v15,
      a1,
      4,
      1,
      Method_Unity_Collections_NativeArray_ProFlareElementData___ctor__);
    *((_OWORD *)a0 + 7) = v15;
  }
  if ( !*((_QWORD *)a0 + 16) )
  {
    v15 = 0u;
    Unity_Collections_NativeArray_ProFlareUpdateElementData____ctor(
      (__int64)&v15,
      a1,
      4,
      1,
      Method_Unity_Collections_NativeArray_ProFlareUpdateElementData___ctor__);
    *((_OWORD *)a0 + 8) = v15;
  }
  v5 = (void **)((char *)a0 + 104);
  if ( !*((_QWORD *)a0 + 13) )
  {
    if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
      sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
    v6 = System_Runtime_InteropServices_Marshal__SizeOf_ProFlareElementData_(Method_System_Runtime_InteropServices_Marshal_SizeOf_ProFlareElementData___);
    v7 = (void *)sub_63CF110(UnityEngine_ComputeBuffer_TypeInfo);
    UnityEngine_ComputeBuffer___ctor_2(v7, a1, v6, 16, 0, nullptr);
    *v5 = v7;
    sub_63CEE24((char *)a0 + 104, (int)v7, v8, v9, v10, v11);
    if ( *v5 )
    {
      UnityEngine_ComputeBuffer__SetData_ProFlareElementData_(*v5, *((_QWORD *)a0 + 14), *((void **)a0 + 15));
    }
    else
    {
      v13 = (void *)sub_63CF120(0, v12);
      ProFlareBatchForSRPData__get_CanDispose(v13, v14);
    }
  }
}

