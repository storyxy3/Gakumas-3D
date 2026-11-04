// VLB.Chunk$$ResizeArray<__Il2CppFullySharedGenericType> @ 0x90ab23c
void __fastcall VLB_Chunk__ResizeArray___Il2CppFullySharedGenericType_(void *a0, void *a1, int a2, void *a3)
{
  __int64 v7; // x8
  __int64 v8; // x0
  __int64 v9; // x1
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5

  if ( !*((_QWORD *)a3 + 7) )
    sub_6407F5C();
  v7 = *((_QWORD *)a3 + 7);
  if ( *(_QWORD *)a1 )
  {
    (**(void (__fastcall ***)(void *, _QWORD))(v7 + 16))(a1, (unsigned int)a2);
  }
  else
  {
    v8 = *(_QWORD *)(v7 + 8);
    if ( (*(_WORD *)(v8 + 309) & 1) == 0 )
      sub_6407F00(v8);
    v9 = sub_63CEF64(v8, (unsigned int)a2);
    *(_QWORD *)a1 = v9;
    sub_63CEE24(a1, v9, v10, v11, v12, v13);
  }
}

