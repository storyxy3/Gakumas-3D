// VLB.Chunk$$RemoveAtSwapBack<Entity> @ 0x90aa984
void __fastcall VLB_Chunk__RemoveAtSwapBack_Entity_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_QWORD *)(*(_QWORD *)a1 + 8LL * a2) = *(_QWORD *)(*(_QWORD *)a1 + 8LL * (a3 - 1));
}

