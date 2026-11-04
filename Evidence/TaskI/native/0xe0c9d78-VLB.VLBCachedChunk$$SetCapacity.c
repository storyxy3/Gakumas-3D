// VLB.VLBCachedChunk$$SetCapacity @ 0xe0c9d78
void __fastcall VLB_VLBCachedChunk__SetCapacity(void *a0, int a1, void *a2)
{
  if ( (unk_F43D9C8 & 1) == 0 )
  {
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_bool___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_Bounds___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_Color___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_int___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float2___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float3___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float4___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float4x4___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_quaternion___);
    unk_F43D9C8 = 1;
  }
  VLB_Chunk__ResizeArray_float4x4_(a0, (char *)a0 + 72, a1, Method_VLB_Chunk_ResizeArray_float4x4___);
  VLB_Chunk__ResizeArray_float4x4_(a0, (char *)a0 + 88, a1, Method_VLB_Chunk_ResizeArray_float4x4___);
  VLB_Chunk__ResizeArray_Bounds_(a0, (char *)a0 + 104, a1, Method_VLB_Chunk_ResizeArray_Bounds___);
  VLB_Chunk__ResizeArray_bool_(a0, (char *)a0 + 120, a1, Method_VLB_Chunk_ResizeArray_bool___);
  VLB_Chunk__ResizeArray_Color_(a0, (char *)a0 + 136, a1, Method_VLB_Chunk_ResizeArray_Color___);
  VLB_Chunk__ResizeArray_float2_(a0, (char *)a0 + 152, a1, Method_VLB_Chunk_ResizeArray_float2___);
  VLB_Chunk__ResizeArray_float2_(a0, (char *)a0 + 168, a1, Method_VLB_Chunk_ResizeArray_float2___);
  VLB_Chunk__ResizeArray_float4_(a0, (char *)a0 + 184, a1, Method_VLB_Chunk_ResizeArray_float4___);
  VLB_Chunk__ResizeArray_float4_(a0, (char *)a0 + 200, a1, Method_VLB_Chunk_ResizeArray_float4___);
  VLB_Chunk__ResizeArray_float2_(a0, (char *)a0 + 216, a1, Method_VLB_Chunk_ResizeArray_float2___);
  VLB_Chunk__ResizeArray_int_(a0, (char *)a0 + 232, a1, Method_VLB_Chunk_ResizeArray_int___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 248, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 264, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_float2_(a0, (char *)a0 + 280, a1, Method_VLB_Chunk_ResizeArray_float2___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 296, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 312, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 328, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_float_(a0, (char *)a0 + 344, a1, Method_VLB_Chunk_ResizeArray_float___);
  VLB_Chunk__ResizeArray_quaternion_(a0, (char *)a0 + 360, a1, Method_VLB_Chunk_ResizeArray_quaternion___);
  VLB_Chunk__ResizeArray_float3_(a0, (char *)a0 + 376, a1, Method_VLB_Chunk_ResizeArray_float3___);
  *((_DWORD *)a0 + 5) = a1;
}

