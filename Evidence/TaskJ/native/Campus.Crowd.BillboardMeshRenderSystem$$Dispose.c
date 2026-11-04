// Campus.Crowd.BillboardMeshRenderSystem$$Dispose @ 0xddc77f0
void __fastcall Campus_Crowd_BillboardMeshRenderSystem__Dispose(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x0
  void *v5; // x0
  char *v6; // x19
  __int64 v7; // t1

  if ( (unk_F43BD05 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    unk_F43BD05 = 1;
  }
  v3 = *((void **)a0 + 2);
  if ( !*(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
  UnityEngine_Rendering_CoreUtils__Destroy(v3, nullptr);
  v4 = *((void **)a0 + 11);
  if ( v4 )
    UnityEngine_Rendering_RTHandle__Release(v4, nullptr);
  v5 = *((void **)a0 + 12);
  if ( v5 )
    UnityEngine_Rendering_RTHandle__Release(v5, nullptr);
  if ( *((_QWORD *)a0 + 5) )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)a0 + 40,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
  if ( *((_QWORD *)a0 + 7) )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)a0 + 56,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
  v7 = *((_QWORD *)a0 + 9);
  v6 = (char *)a0 + 72;
  if ( v7 )
    Unity_Collections_NativeArray_Matrix4x4___Dispose(
      (__int64)v6,
      Method_Unity_Collections_NativeArray_Matrix4x4__Dispose__);
}

