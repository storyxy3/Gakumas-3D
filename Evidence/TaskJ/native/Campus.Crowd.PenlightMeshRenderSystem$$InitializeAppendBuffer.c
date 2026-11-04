// Campus.Crowd.PenlightMeshRenderSystem$$InitializeAppendBuffer @ 0xddcbf1c
void __fastcall Campus_Crowd_PenlightMeshRenderSystem__InitializeAppendBuffer(
        void *a0,
        int a1,
        void *a2,
        void *a3,
        void *a4)
{
  int v8; // w21
  int v9; // w22
  void *v10; // x23
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  void *v15; // x23
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  __int64 v20; // x1
  void *v21; // x0
  void *v22; // x0
  int v23; // w1
  void *v24; // x2
  __int64 v25; // [xsp+0h] [xbp+0h] BYREF
  void *v26; // [xsp+8h] [xbp+8h]

  if ( (unk_F43BD36 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_GraphicsBuffer_SetData_uint___);
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint___ctor__);
    unk_F43BD36 = 1;
  }
  v8 = 8 * a1;
  v25 = 0;
  v26 = nullptr;
  if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
    sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
  v9 = System_Runtime_InteropServices_Marshal__SizeOf_uint_(Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
  v10 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v10, 72, v8, v9, nullptr);
  *(_QWORD *)a2 = v10;
  sub_63CEE24(a2, (int)v10, v11, v12, v13, v14);
  v15 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v15, 68, v8, v9, nullptr);
  *(_QWORD *)a3 = v15;
  sub_63CEE24(a3, (int)v15, v16, v17, v18, v19);
  Unity_Collections_NativeArray_uint____ctor(
    (__int64)&v25,
    v8,
    2,
    1,
    Method_Unity_Collections_NativeArray_uint___ctor__);
  v21 = *(void **)a2;
  if ( *(_QWORD *)a2
    && (UnityEngine_GraphicsBuffer__SetData_uint_(v21, v25, v26), (v21 = *(void **)a3) != nullptr)
    && (UnityEngine_GraphicsBuffer__SetData_uint_(v21, v25, v26),
        Unity_Collections_NativeArray_uint___Dispose(
          (__int64)&v25,
          Method_Unity_Collections_NativeArray_uint__Dispose__),
        (v21 = *(void **)a2) != nullptr)
    && (UnityEngine_GraphicsBuffer__SetCounterValue(v21, 0, nullptr), (v21 = *(void **)a3) != nullptr) )
  {
    UnityEngine_GraphicsBuffer__SetCounterValue(v21, 0, nullptr);
  }
  else
  {
    v22 = (void *)sub_63CF120(v21, v20);
    Campus_Crowd_PenlightMeshRenderSystem__GetPenlightInfoBytesBuffer(v22, v23, v24);
  }
}

