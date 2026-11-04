// VLB.VLBDrawCallChunk$$Dispose @ 0xe0cb07c
void __fastcall VLB_VLBDrawCallChunk__Dispose(void *a0, void *a1)
{
  if ( (unk_F43D9D9 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_SubDrawCall__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4__Dispose__);
    unk_F43D9D9 = 1;
  }
  Unity_Collections_NativeArray_int___Dispose(
    (__int64)a0 + 136,
    (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
  if ( *((_DWORD *)a0 + 5) )
  {
    Unity_Collections_NativeArray_float4x4___Dispose(
      (__int64)a0 + 40,
      Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    Unity_Collections_NativeArray_float4___Dispose(
      (__int64)a0 + 56,
      Method_Unity_Collections_NativeArray_float4__Dispose__);
    Unity_Collections_NativeArray_float4___Dispose(
      (__int64)a0 + 72,
      Method_Unity_Collections_NativeArray_float4__Dispose__);
    Unity_Collections_NativeArray_float4x4___Dispose(
      (__int64)a0 + 88,
      Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    Unity_Collections_NativeArray_float4x4___Dispose(
      (__int64)a0 + 104,
      Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    Unity_Collections_NativeArray_SubDrawCall___Dispose(
      (__int64)a0 + 120,
      Method_Unity_Collections_NativeArray_SubDrawCall__Dispose__);
    Unity_Collections_NativeArray_int___Dispose(
      (__int64)a0 + 152,
      (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
    *((_QWORD *)a0 + 2) = 0;
  }
}

