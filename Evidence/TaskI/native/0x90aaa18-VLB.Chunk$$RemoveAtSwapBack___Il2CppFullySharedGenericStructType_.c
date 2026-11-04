// VLB.Chunk$$RemoveAtSwapBack<__Il2CppFullySharedGenericStructType> @ 0x90aaa18
// bad sp value at call has been detected, the output may be wrong!
void __fastcall VLB_Chunk__RemoveAtSwapBack___Il2CppFullySharedGenericStructType_(
        void *a0,
        void *a1,
        int a2,
        int a3,
        void *a4)
{
  __int64 v9; // x8
  char *v10; // x23
  __int64 *v11; // x1
  __int64 v12; // x0
  void (__fastcall *v13)(__int64, __int64 *, void *, _QWORD *, char *); // x8
  __int64 v14; // x8
  __int64 *v15; // x1
  __int64 v16; // x0
  void (__fastcall *v17)(__int64, __int64 *, void *, _QWORD *, char *); // x8
  _QWORD savedregs[8]; // [xsp+20h] [xbp+0h] BYREF
  __int64 v19; // [xsp+60h] [xbp+40h] BYREF

  savedregs[7] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  v9 = *((_QWORD *)a4 + 7);
  if ( !v9 )
  {
    sub_6407F5C();
    v9 = *((_QWORD *)a4 + 7);
  }
  v10 = (char *)&v19 - ((*(unsigned int *)(*(_QWORD *)(v9 + 24) + 252LL) + 15LL) & 0x1FFFFFFF0LL);
  v11 = *(__int64 **)(v9 + 8);
  HIDWORD(savedregs[6]) = a3 - 1;
  v12 = *v11;
  v13 = (void (__fastcall *)(__int64, __int64 *, void *, _QWORD *, char *))v11[2];
  savedregs[4] = (char *)&savedregs[6] + 4;
  savedregs[5] = v10;
  v13(v12, v11, a1, &savedregs[4], v10);
  v14 = *((_QWORD *)a4 + 7);
  HIDWORD(savedregs[6]) = a2;
  v15 = *(__int64 **)(v14 + 32);
  v16 = *v15;
  v17 = (void (__fastcall *)(__int64, __int64 *, void *, _QWORD *, char *))v15[2];
  savedregs[4] = (char *)&savedregs[6] + 4;
  savedregs[5] = v10;
  v17(v16, v15, a1, &savedregs[4], v10);
}

