// Campus.Crowd.CrowdSystemData$$Dispose @ 0xddcb3b4
void __fastcall Campus_Crowd_CrowdSystemData__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x0
  void *v5; // x0
  void *v6; // x0
  void *v7; // x0

  if ( (unk_F43BD2B & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_PersonInfo__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_OctreeInfo__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_OctreeInfo__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_PersonInfo__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_IsCreated__);
    unk_F43BD2B = 1;
  }
  v3 = *((void **)a0 + 3);
  if ( v3 )
    UnityEngine_GraphicsBuffer__Dispose(v3, nullptr);
  v4 = *((void **)a0 + 4);
  if ( v4 )
    UnityEngine_GraphicsBuffer__Dispose(v4, nullptr);
  v5 = *((void **)a0 + 6);
  if ( v5 )
    UnityEngine_GraphicsBuffer__Dispose(v5, nullptr);
  v6 = *((void **)a0 + 5);
  if ( v6 )
    UnityEngine_GraphicsBuffer__Dispose(v6, nullptr);
  v7 = *((void **)a0 + 7);
  if ( v7 )
    UnityEngine_GraphicsBuffer__Dispose(v7, nullptr);
  if ( *((_QWORD *)a0 + 8) )
    Unity_Collections_NativeArray_PersonInfo___Dispose(
      (__int64)a0 + 64,
      Method_Unity_Collections_NativeArray_PersonInfo__Dispose__);
  if ( *((_QWORD *)a0 + 10) )
    Unity_Collections_NativeArray_OctreeInfo___Dispose(
      (__int64)a0 + 80,
      Method_Unity_Collections_NativeArray_OctreeInfo__Dispose__);
  if ( *((_QWORD *)a0 + 12) )
    Unity_Collections_NativeArray_uint___Dispose((__int64)a0 + 96, Method_Unity_Collections_NativeArray_uint__Dispose__);
  if ( *((_QWORD *)a0 + 14) )
    Unity_Collections_NativeArray_int___Dispose(
      (__int64)a0 + 112,
      (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
  if ( Unity_Collections_NativeReference_int___get_IsCreated(
         (__int64)a0 + 128,
         Method_Unity_Collections_NativeReference_int__get_IsCreated__) )
  {
    Unity_Collections_NativeReference_int___Dispose(
      (__int64)a0 + 128,
      Method_Unity_Collections_NativeReference_int__Dispose__);
  }
}

