// VLB.Chunk$$RemoveAtSwapBack<SubDrawCall> @ 0x90aaa04
void __fastcall VLB_Chunk__RemoveAtSwapBack_SubDrawCall_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_QWORD *)(*(_QWORD *)a1 + 8LL * a2) = *(_QWORD *)(*(_QWORD *)a1 + 8LL * (a3 - 1));
}

