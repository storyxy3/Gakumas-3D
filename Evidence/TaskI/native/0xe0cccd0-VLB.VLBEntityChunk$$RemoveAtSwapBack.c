// VLB.VLBEntityChunk$$RemoveAtSwapBack @ 0xe0cccd0
void __fastcall VLB_VLBEntityChunk__RemoveAtSwapBack(void *a0, int a1, void *a2)
{
  if ( (unk_F43D9E4 & 1) == 0 )
  {
    sub_63CEE78(&Method_VLB_Chunk_RemoveAtSwapBack_Entity___);
    sub_63CEE78(&Method_VLB_Chunk_RemoveAtSwapBack_VolumetricLightBeamSD___);
    unk_F43D9E4 = 1;
  }
  VLB_Chunk__RemoveAtSwapBack_Entity_(
    a0,
    (char *)a0 + 40,
    a1,
    *((_DWORD *)a0 + 4),
    Method_VLB_Chunk_RemoveAtSwapBack_Entity___);
  VLB_Chunk__RemoveAtSwapBack_object_(
    a0,
    (char *)a0 + 56,
    a1,
    *((_DWORD *)a0 + 4),
    Method_VLB_Chunk_RemoveAtSwapBack_VolumetricLightBeamSD___);
  UnityEngine_Jobs_TransformAccessArray__RemoveAtSwapBack((__int64)a0 + 64, a1, nullptr);
  --*((_DWORD *)a0 + 4);
}

