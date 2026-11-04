// VLB.Chunk$$RemoveAtSwapBack<float4x4> @ 0x90aacb0
void __fastcall VLB_Chunk__RemoveAtSwapBack_float4x4_(void *a0, void *a1, int a2, int a3, void *a4)
{
  __int128 *v5; // x8
  _OWORD *v6; // x9
  __int128 v7; // q0
  __int128 v8; // q2
  __int128 v9; // q3

  v5 = (__int128 *)(*(_QWORD *)a1 + ((__int64)(a3 - 1) << 6));
  v6 = (_OWORD *)(*(_QWORD *)a1 + ((__int64)a2 << 6));
  v7 = v5[3];
  v8 = *v5;
  v9 = v5[1];
  v6[2] = v5[2];
  v6[3] = v7;
  *v6 = v8;
  v6[1] = v9;
}

