// VLB.Chunk$$RemoveAtSwapBack<Bounds> @ 0x90aa944
void __fastcall VLB_Chunk__RemoveAtSwapBack_Bounds_(void *a0, void *a1, int a2, int a3, void *a4)
{
  __int64 v5; // x9
  __int64 v6; // x8
  __int128 v7; // q0

  v5 = *(_QWORD *)a1 + 24LL * (a3 - 1);
  v6 = *(_QWORD *)a1 + 24LL * a2;
  v7 = *(_OWORD *)v5;
  *(_QWORD *)(v6 + 16) = *(_QWORD *)(v5 + 16);
  *(_OWORD *)v6 = v7;
}

