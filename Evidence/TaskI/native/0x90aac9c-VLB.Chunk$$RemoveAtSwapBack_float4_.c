// VLB.Chunk$$RemoveAtSwapBack<float4> @ 0x90aac9c
void __fastcall VLB_Chunk__RemoveAtSwapBack_float4_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_OWORD *)(*(_QWORD *)a1 + 16LL * a2) = *(_OWORD *)(*(_QWORD *)a1 + 16LL * (a3 - 1));
}

