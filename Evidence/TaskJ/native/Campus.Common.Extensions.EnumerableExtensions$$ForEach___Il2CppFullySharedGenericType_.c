// 0x91f9604 @ 0x91f9604
// bad sp value at call has been detected, the output may be wrong!
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach___Il2CppFullySharedGenericType_(
        void *a0,
        void *a1,
        void *a2)
{
  _QWORD *v3; // x19
  __int64 *v5; // x22
  _QWORD *v6; // x8
  _QWORD *v7; // x21
  __int64 v8; // x1
  __int64 v9; // x0
  __int64 v10; // x8
  __int64 v11; // x9
  int *v12; // x10
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x1
  __int64 v16; // x22
  int v17; // w24
  __int64 v18; // x8
  __int64 v19; // x9
  int *v20; // x10
  __int64 v21; // x0
  __int64 v22; // x0
  __int64 v23; // x1
  __int64 *v24; // x22
  __int64 v25; // x1
  __int64 v26; // x0
  __int64 v27; // x8
  __int64 v28; // x9
  int *v29; // x10
  __int64 v30; // x0
  __int64 v31; // x1
  __int64 v32; // x9
  _QWORD *v33; // x8
  __int64 *v34; // x1
  __int64 v35; // x0
  __int64 (__fastcall *v36)(__int64, __int64 *, void *, _QWORD *, char *); // x9
  __int64 **i; // x8
  __int64 *v38; // x20
  __int64 v39; // x8
  __int64 v40; // x9
  int *v41; // x10
  __int64 v42; // x0
  void *v43; // x0
  void *v44; // x19
  int v45; // w1
  _QWORD savedregs[10]; // [xsp+40h] [xbp+0h] BYREF
  __int64 v47; // [xsp+90h] [xbp+50h] BYREF

  v3 = a2;
  v5 = (__int64 *)a0;
  savedregs[9] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  v6 = *((_QWORD **)a2 + 7);
  if ( !v6 )
  {
    sub_63CEE78(&System_IDisposable_TypeInfo);
    a0 = (void *)sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    v6 = (_QWORD *)v3[7];
    if ( !v6 )
    {
      a0 = (void *)sub_6407F5C();
      v6 = (_QWORD *)v3[7];
    }
  }
  v7 = (__int64 *)((char *)&v47 - ((*(unsigned int *)(v6[4] + 252LL) + 15LL) & 0x1FFFFFFF0LL));
  savedregs[5] = 0;
  if ( !v5 )
    goto LABEL_49;
  v8 = *v6;
  if ( (*(_WORD *)(*v6 + 309LL) & 1) == 0 )
  {
    sub_6407F00(v8);
    v8 = v9;
  }
  v10 = *v5;
  v11 = *(unsigned __int16 *)(*v5 + 302);
  if ( *(_WORD *)(*v5 + 302) )
  {
    v12 = (int *)(*(_QWORD *)(v10 + 176) + 8LL);
    while ( *((_QWORD *)v12 - 1) != v8 )
    {
      --v11;
      v12 += 4;
      if ( !v11 )
        goto LABEL_11;
    }
    v13 = v10 + 16LL * *v12 + 312;
  }
  else
  {
LABEL_11:
    v13 = sub_6408234(v5, v8, 0);
  }
  v14 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v13)(v5, *(_QWORD *)(v13 + 8));
  savedregs[5] = v14;
  savedregs[3] = 0;
  savedregs[4] = &savedregs[5];
  if ( v14 )
  {
    v16 = v14;
    v17 = 0;
    while ( 1 )
    {
      v18 = *(_QWORD *)v16;
      v19 = *(unsigned __int16 *)(*(_QWORD *)v16 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v16 + 302LL) )
      {
        v20 = (int *)(*(_QWORD *)(v18 + 176) + 8LL);
        while ( *((_QWORD *)v20 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v19;
          v20 += 4;
          if ( !v19 )
            goto LABEL_19;
        }
        v21 = v18 + 16LL * *v20 + 312;
      }
      else
      {
LABEL_19:
        v21 = sub_6408234(v16, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v22 = (*(__int64 (__fastcall **)(__int64, _QWORD))v21)(v16, *(_QWORD *)(v21 + 8));
      if ( (v22 & 1) == 0 )
        goto LABEL_37;
      v24 = (__int64 *)savedregs[5];
      if ( !savedregs[5] )
        break;
      v25 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v25 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v25 = v26;
      }
      v27 = *v24;
      v28 = *(unsigned __int16 *)(*v24 + 302);
      if ( *(_WORD *)(*v24 + 302) )
      {
        v29 = (int *)(*(_QWORD *)(v27 + 176) + 8LL);
        while ( *((_QWORD *)v29 - 1) != v25 )
        {
          --v28;
          v29 += 4;
          if ( !v28 )
            goto LABEL_29;
        }
        v30 = v27 + 16LL * *v29 + 312;
      }
      else
      {
LABEL_29:
        v30 = sub_6408234(v24, v25, 0);
      }
      v31 = *(_QWORD *)(v30 + 8);
      savedregs[6] = v7;
      v14 = (*(__int64 (__fastcall **)(_QWORD, __int64, __int64 *, _QWORD *, _QWORD *))(v31 + 16))(
              *(_QWORD *)(v31 + 8),
              v31,
              v24,
              &savedregs[6],
              v7);
      if ( a1 )
      {
        v32 = v3[7];
        v33 = v7;
        if ( (*(_DWORD *)(*(_QWORD *)(v32 + 32) + 40LL) & 0x80000000) == 0 )
          v33 = (_QWORD *)*v7;
        v34 = *(__int64 **)(v32 + 48);
        HIDWORD(savedregs[8]) = v17;
        v35 = *v34;
        v36 = (__int64 (__fastcall *)(__int64, __int64 *, void *, _QWORD *, char *))v34[2];
        savedregs[6] = v33;
        savedregs[7] = (char *)&savedregs[8] + 4;
        v14 = v36(v35, v34, a1, &savedregs[6], (char *)&savedregs[8] + 4);
      }
      v16 = savedregs[5];
      ++v17;
      if ( !savedregs[5] )
        goto LABEL_36;
    }
    a0 = (void *)sub_63CF120(v22, v23);
LABEL_49:
    sub_63CF120(a0, a1);
    goto LABEL_50;
  }
LABEL_36:
  sub_63CF120(v14, v15);
LABEL_37:
  v3 = nullptr;
  for ( i = (__int64 **)&savedregs[5]; ; i = (__int64 **)savedregs[4] )
  {
    v38 = *i;
    if ( *i )
    {
      v39 = *v38;
      v40 = *(unsigned __int16 *)(*v38 + 302);
      if ( *(_WORD *)(*v38 + 302) )
      {
        v41 = (int *)(*(_QWORD *)(v39 + 176) + 8LL);
        while ( *((_QWORD *)v41 - 1) != System_IDisposable_TypeInfo )
        {
          --v40;
          v41 += 4;
          if ( !v40 )
            goto LABEL_43;
        }
        v42 = v39 + 16LL * *v41 + 312;
      }
      else
      {
LABEL_43:
        v42 = sub_6408234(v38, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v42)(v38, *(_QWORD *)(v42 + 8));
    }
    if ( !v3 )
      break;
LABEL_50:
    sub_63CF118(v3);
    v44 = v43;
    if ( v45 != 1 )
    {
      sub_5D96914(&savedregs[3]);
      sub_64BD8DC(v44);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v43);
    savedregs[3] = v3;
    __cxa_end_catch();
  }
}

