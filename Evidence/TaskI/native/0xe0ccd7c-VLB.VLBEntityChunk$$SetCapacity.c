// VLB.VLBEntityChunk$$SetCapacity @ 0xe0ccd7c
void __fastcall VLB_VLBEntityChunk__SetCapacity(void *a0, int a1, void *a2)
{
  if ( (unk_F43D9E5 & 1) == 0 )
  {
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_Entity___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeArray_VolumetricLightBeamSD___);
    sub_63CEE78(&Method_VLB_Chunk_ResizeNativeArray_VolumetricLightBeamSD___);
    unk_F43D9E5 = 1;
  }
  VLB_Chunk__ResizeArray_Entity_(a0, (char *)a0 + 40, a1, Method_VLB_Chunk_ResizeArray_Entity___);
  VLB_Chunk__ResizeNativeArray_object_(
    a0,
    (char *)a0 + 64,
    *((void **)a0 + 7),
    a1,
    Method_VLB_Chunk_ResizeNativeArray_VolumetricLightBeamSD___);
  VLB_Chunk__ResizeArray_object_(a0, (char *)a0 + 56, a1, Method_VLB_Chunk_ResizeArray_VolumetricLightBeamSD___);
  *((_DWORD *)a0 + 5) = a1;
}

