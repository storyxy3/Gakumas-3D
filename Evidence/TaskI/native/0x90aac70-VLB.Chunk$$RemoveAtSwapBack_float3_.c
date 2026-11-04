// VLB.Chunk$$RemoveAtSwapBack<float3> @ 0x90aac70
void __fastcall VLB_Chunk__RemoveAtSwapBack_float3_(void *a0, void *a1, int a2, int a3, void *a4)
{
  __int64 v5; // x9
  __int64 v6; // x8
  int v7; // w10
  __int64 v8; // x9

  v5 = *(_QWORD *)a1 + 12LL * (a3 - 1);
  v6 = *(_QWORD *)a1 + 12LL * a2;
  v7 = *(_DWORD *)(v5 + 8);
  v8 = *(_QWORD *)v5;
  *(_DWORD *)(v6 + 8) = v7;
  *(_QWORD *)v6 = v8;
}

