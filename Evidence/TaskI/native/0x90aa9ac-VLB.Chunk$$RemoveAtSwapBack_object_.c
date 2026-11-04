// VLB.Chunk$$RemoveAtSwapBack<object> @ 0x90aa9ac
void __fastcall VLB_Chunk__RemoveAtSwapBack_object_(void *a0, void *a1, int a2, int a3, void *a4)
{
  void *v5; // x5
  __int64 v6; // x8
  unsigned int v7; // w10
  __int64 v8; // x8
  __int64 v9; // x1
  _QWORD *v10; // x0
  void *v11; // x0
  void *v12; // x1
  int v13; // w2
  int v14; // w3
  void *v15; // x4

  v6 = *(_QWORD *)a1;
  if ( *(_QWORD *)a1 )
  {
    v7 = *(_DWORD *)(v6 + 24);
    if ( a3 - 1 < v7 && v7 > a2 )
    {
      v8 = v6 + 32;
      v9 = *(_QWORD *)(v8 + 8LL * (a3 - 1));
      v10 = (_QWORD *)(v8 + 8LL * a2);
      *v10 = v9;
      sub_63CEE24(v10, v9, a2, a3, (int)a4, v5);
      return;
    }
    sub_63CF128(a0, a1, a2, a3);
  }
  v11 = (void *)sub_63CF120(a0, a1);
  VLB_Chunk__RemoveAtSwapBack_float_(v11, v12, v13, v14, v15);
}

