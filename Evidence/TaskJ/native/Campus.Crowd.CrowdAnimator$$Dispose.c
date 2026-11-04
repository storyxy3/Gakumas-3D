// Campus.Crowd.CrowdAnimator$$Dispose @ 0xddc203c
void __fastcall Campus_Crowd_CrowdAnimator__Dispose(void *a0, void *a1)
{
  char *v3; // x19
  __int64 v4; // t1

  if ( (unk_F43BCDA & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_TransformStreamHandle__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Bounds__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Vector3__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_TransformStreamHandle__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Vector3__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Bounds__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_Matrix4x4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_Matrix4x4__get_IsCreated__);
    unk_F43BCDA = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a1) )
    UnityEngine_Playables_PlayableGraph__Destroy((__int64)a0 + 56, nullptr);
  if ( Unity_Collections_NativeReference_Matrix4x4___get_IsCreated(
         (__int64)a0 + 16,
         Method_Unity_Collections_NativeReference_Matrix4x4__get_IsCreated__) )
  {
    Unity_Collections_NativeReference_Matrix4x4___Dispose(
      (__int64)a0 + 16,
      Method_Unity_Collections_NativeReference_Matrix4x4__Dispose__);
  }
  if ( *((_QWORD *)a0 + 26) )
    Unity_Collections_NativeArray_TransformStreamHandle___Dispose(
      (__int64)a0 + 208,
      Method_Unity_Collections_NativeArray_TransformStreamHandle__Dispose__);
  if ( *((_QWORD *)a0 + 4) )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)a0 + 32,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
  if ( *((_QWORD *)a0 + 9) )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)a0 + 72,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
  if ( *((_QWORD *)a0 + 11) )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)a0 + 88,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
  if ( *((_QWORD *)a0 + 14) )
    Unity_Collections_NativeArray_Bounds___Dispose(
      (__int64)a0 + 112,
      Method_Unity_Collections_NativeArray_Bounds__Dispose__);
  if ( *((_QWORD *)a0 + 16) )
    Unity_Collections_NativeArray_int___Dispose(
      (__int64)a0 + 128,
      (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
  if ( *((_QWORD *)a0 + 18) )
    Unity_Collections_NativeArray_int___Dispose(
      (__int64)a0 + 144,
      (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
  v4 = *((_QWORD *)a0 + 20);
  v3 = (char *)a0 + 160;
  if ( v4 )
    Unity_Collections_NativeArray_Vector3___Dispose(
      (__int64)v3,
      Method_Unity_Collections_NativeArray_Vector3__Dispose__);
}

