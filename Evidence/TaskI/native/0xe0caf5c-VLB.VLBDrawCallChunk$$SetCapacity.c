// VLB.VLBDrawCallChunk$$SetCapacity @ 0xe0caf5c
void __fastcall VLB_VLBDrawCallChunk__SetCapacity(void *a0, int a1, void *a2)
{
  if ( (unk_F43D9D8 & 1) == 0 )
  {
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_int___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_SubDrawCall___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float4___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_float4x4___);
    unk_F43D9D8 = 1;
  }
  VLB_Chunk__ResizeArray_float4x4_(a0, (char *)a0 + 40, a1, Method_VLB_Chunk_ResizeArray_float4x4___);
  VLB_Chunk__ResizeArray_float4_(a0, (char *)a0 + 56, a1, Method_VLB_Chunk_ResizeArray_float4___);
  VLB_Chunk__ResizeArray_float4_(a0, (char *)a0 + 72, a1, Method_VLB_Chunk_ResizeArray_float4___);
  VLB_Chunk__ResizeArray_float4x4_(a0, (char *)a0 + 88, a1, Method_VLB_Chunk_ResizeArray_float4x4___);
  VLB_Chunk__ResizeArray_float4x4_(a0, (char *)a0 + 104, a1, Method_VLB_Chunk_ResizeArray_float4x4___);
  VLB_Chunk__ResizeArray_SubDrawCall_(a0, (char *)a0 + 120, a1, Method_VLB_Chunk_ResizeArray_SubDrawCall___);
  VLB_Chunk__ResizeArray_int_(a0, (char *)a0 + 152, a1, Method_VLB_Chunk_ResizeArray_int___);
  *((_DWORD *)a0 + 5) = a1;
}

