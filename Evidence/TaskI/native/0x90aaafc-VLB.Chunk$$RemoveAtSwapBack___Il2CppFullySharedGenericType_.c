// VLB.Chunk$$RemoveAtSwapBack<__Il2CppFullySharedGenericType> @ 0x90aaafc
void __fastcall VLB_Chunk__RemoveAtSwapBack___Il2CppFullySharedGenericType_(
        void *a0,
        void *a1,
        int a2,
        int a3,
        void *a4)
{
  __int64 v9; // x8
  size_t v10; // x22
  _DWORD *v11; // x24
  unsigned int v12; // w27
  _DWORD *v13; // x26
  __int64 v14; // x28
  char *v15; // x23
  __int64 savedregs_88; // [xsp+68h] [xbp+58h]
  __int64 v17; // [xsp+70h] [xbp+60h] BYREF

  savedregs_88 = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  v9 = *((_QWORD *)a4 + 7);
  if ( !v9 )
  {
    a0 = (void *)sub_6407F5C();
    v9 = *((_QWORD *)a4 + 7);
  }
  v10 = *(unsigned int *)(*(_QWORD *)(v9 + 8) + 252LL);
  v11 = *(_DWORD **)a1;
  if ( !v11 )
LABEL_11:
    sub_63CF120(a0, a1);
  v12 = v11[6];
  if ( a3 - 1 >= v12 )
    goto LABEL_10;
  v13 = v11 + 8;
  v14 = *(unsigned int *)(*(_QWORD *)v11 + 260LL);
  v15 = (char *)v11 + v14 * (a3 - 1) + 32;
  a0 = memcpy((char *)&v17 - ((v10 + 15) & 0x1FFFFFFF0LL), v15, v10);
  if ( v12 <= a2 )
    goto LABEL_10;
  memmove((char *)v13 + v14 * a2, v15, v10);
  a0 = *(void **)(*((_QWORD *)a4 + 7) + 8LL);
  if ( (*(_WORD *)((_BYTE *)a0 + 309) & 1) == 0 )
    sub_6407F00(a0);
  if ( v11[6] <= (unsigned int)a2 )
  {
LABEL_10:
    sub_63CF128(a0, a1, a2, a3);
    goto LABEL_11;
  }
  sub_63CEE28(
    a0,
    (char *)v13 + *(unsigned int *)(*(_QWORD *)v11 + 260LL) * (__int64)a2,
    (char *)&v17 - ((v10 + 15) & 0x1FFFFFFF0LL));
}

