// VLB.Chunk$$RemoveAtSwapBack<bool> @ 0x90aa930
void __fastcall VLB_Chunk__RemoveAtSwapBack_bool_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_BYTE *)(*(_QWORD *)a1 + a2) = *(_BYTE *)(*(_QWORD *)a1 + a3 - 1);
}

