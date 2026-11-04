// VLB.Chunk$$RemoveAtSwapBack<int> @ 0x90aa998
void __fastcall VLB_Chunk__RemoveAtSwapBack_int_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_DWORD *)(*(_QWORD *)a1 + 4LL * a2) = *(_DWORD *)(*(_QWORD *)a1 + 4LL * (a3 - 1));
}

