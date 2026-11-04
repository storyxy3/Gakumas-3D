// VLB.VLBCachedChunk$$Dispose @ 0xe0ca024
void __fastcall VLB_VLBCachedChunk__Dispose(void *a0, void *a1)
{
  if ( (unk_F43D9C9 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_quaternion__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Bounds__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float2__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Color__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float3__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_bool__Dispose__);
    unk_F43D9C9 = 1;
  }
  if ( *((_DWORD *)a0 + 5) )
  {
    Unity_Collections_NativeArray_float4x4___Dispose(
      (__int64)a0 + 72,
      Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    Unity_Collections_NativeArray_float4x4___Dispose(
      (__int64)a0 + 88,
      Method_Unity_Collections_NativeArray_float4x4__Dispose__);
    Unity_Collections_NativeArray_Bounds___Dispose(
      (__int64)a0 + 104,
      Method_Unity_Collections_NativeArray_Bounds__Dispose__);
    Unity_Collections_NativeArray_bool___Dispose(
      (__int64)a0 + 120,
      Method_Unity_Collections_NativeArray_bool__Dispose__);
    Unity_Collections_NativeArray_Color___Dispose(
      (__int64)a0 + 136,
      Method_Unity_Collections_NativeArray_Color__Dispose__);
    Unity_Collections_NativeArray_float2___Dispose(
      (__int64)a0 + 152,
      Method_Unity_Collections_NativeArray_float2__Dispose__);
    Unity_Collections_NativeArray_float2___Dispose(
      (__int64)a0 + 168,
      Method_Unity_Collections_NativeArray_float2__Dispose__);
    Unity_Collections_NativeArray_float4___Dispose(
      (__int64)a0 + 184,
      Method_Unity_Collections_NativeArray_float4__Dispose__);
    Unity_Collections_NativeArray_float4___Dispose(
      (__int64)a0 + 200,
      Method_Unity_Collections_NativeArray_float4__Dispose__);
    Unity_Collections_NativeArray_float2___Dispose(
      (__int64)a0 + 216,
      Method_Unity_Collections_NativeArray_float2__Dispose__);
    Unity_Collections_NativeArray_int___Dispose(
      (__int64)a0 + 232,
      (void *)Method_Unity_Collections_NativeArray_int__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 248,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 264,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_float2___Dispose(
      (__int64)a0 + 280,
      Method_Unity_Collections_NativeArray_float2__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 296,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 312,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 328,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_float___Dispose(
      (__int64)a0 + 344,
      Method_Unity_Collections_NativeArray_float__Dispose__);
    Unity_Collections_NativeArray_quaternion___Dispose(
      (__int64)a0 + 360,
      Method_Unity_Collections_NativeArray_quaternion__Dispose__);
    Unity_Collections_NativeArray_float3___Dispose(
      (__int64)a0 + 376,
      Method_Unity_Collections_NativeArray_float3__Dispose__);
    *((_QWORD *)a0 + 2) = 0;
  }
}

