// VLB.Chunk$$ResizeArray<__Il2CppFullySharedGenericStructType> @ 0x90ab15c
void __fastcall VLB_Chunk__ResizeArray___Il2CppFullySharedGenericStructType_(void *a0, void *a1, int a2, void *a3)
{
  void (__fastcall ***v4)(__int128 *, _QWORD, __int64, _QWORD); // x8
  __int64 v8; // x21
  __int64 v9; // x22
  __int128 v10; // kr00_16
  unsigned int v11; // w0
  __int128 v12; // [xsp+0h] [xbp+0h] BYREF

  v4 = *((void (__fastcall ****)(__int128 *, _QWORD, __int64, _QWORD))a3 + 7);
  if ( !v4 )
  {
    sub_6407F5C();
    v4 = *((void (__fastcall ****)(__int128 *, _QWORD, __int64, _QWORD))a3 + 7);
  }
  v12 = 0u;
  (**v4)(&v12, (unsigned int)a2, 4, 0);
  if ( ((**(__int64 (__fastcall ***)(void *))(*((_QWORD *)a3 + 7) + 24LL))(a1) & 1) != 0 )
  {
    v8 = *(_QWORD *)a1;
    v9 = *((_QWORD *)a1 + 1);
    v10 = v12;
    v11 = (**(__int64 (__fastcall ***)(void *))(*((_QWORD *)a3 + 7) + 40LL))(a1);
    (**(void (__fastcall ***)(__int64, __int64, _QWORD, _QWORD, _QWORD))(*((_QWORD *)a3 + 7) + 48LL))(
      v8,
      v9,
      v10,
      *((_QWORD *)&v10 + 1),
      v11);
    (**(void (__fastcall ***)(void *))(*((_QWORD *)a3 + 7) + 56LL))(a1);
  }
  *(_OWORD *)a1 = v12;
}

