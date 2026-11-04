// VLB.VLBCulledChunk$$Dispose @ 0xe0ca8fc
void __fastcall VLB_VLBCulledChunk__Dispose(void *a0, void *a1)
{
  if ( (unk_F43D9D0 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Plane__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_int__Dispose__);
    unk_F43D9D0 = 1;
  }
  if ( *((_DWORD *)a0 + 5) )
  {
    Unity_Collections_NativeArray_Plane___Dispose(
      (__int64)a0 + 64,
      Method_Unity_Collections_NativeArray_Plane__Dispose__);
    Unity_Collections_NativeList_int___Dispose((__int64)a0 + 80, Method_Unity_Collections_NativeList_int__Dispose__);
    *((_QWORD *)a0 + 2) = 0;
  }
}

