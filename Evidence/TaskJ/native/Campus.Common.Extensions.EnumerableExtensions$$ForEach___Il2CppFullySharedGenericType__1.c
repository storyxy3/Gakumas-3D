// 0x91f9274 @ 0x91f9274
// bad sp value at call has been detected, the output may be wrong!
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach___Il2CppFullySharedGenericType__1(
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
  __int64 v17; // x8
  __int64 v18; // x9
  int *v19; // x10
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 v22; // x1
  __int64 *v23; // x22
  __int64 v24; // x1
  __int64 v25; // x0
  __int64 v26; // x8
  __int64 v27; // x9
  int *v28; // x10
  __int64 v29; // x0
  __int64 v30; // x1
  __int64 v31; // x8
  _QWORD *v32; // x4
  __int64 *v33; // x1
  __int64 v34; // x0
  __int64 (__fastcall *v35)(__int64, __int64 *, void *, _QWORD *); // x8
  __int64 **i; // x8
  __int64 *v37; // x20
  __int64 v38; // x8
  __int64 v39; // x9
  int *v40; // x10
  __int64 v41; // x0
  void *v42; // x0
  void *v43; // x19
  int v44; // w1
  _QWORD savedregs[8]; // [xsp+30h] [xbp+0h] BYREF
  __int64 v46; // [xsp+70h] [xbp+40h] BYREF

  v3 = a2;
  v5 = (__int64 *)a0;
  savedregs[7] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
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
  v7 = (__int64 *)((char *)&v46 - ((*(unsigned int *)(v6[4] + 252LL) + 15LL) & 0x1FFFFFFF0LL));
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
    while ( 1 )
    {
      v17 = *(_QWORD *)v16;
      v18 = *(unsigned __int16 *)(*(_QWORD *)v16 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v16 + 302LL) )
      {
        v19 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
        while ( *((_QWORD *)v19 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v18;
          v19 += 4;
          if ( !v18 )
            goto LABEL_19;
        }
        v20 = v17 + 16LL * *v19 + 312;
      }
      else
      {
LABEL_19:
        v20 = sub_6408234(v16, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v21 = (*(__int64 (__fastcall **)(__int64, _QWORD))v20)(v16, *(_QWORD *)(v20 + 8));
      if ( (v21 & 1) == 0 )
        goto LABEL_37;
      v23 = (__int64 *)savedregs[5];
      if ( !savedregs[5] )
        break;
      v24 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v24 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v24 = v25;
      }
      v26 = *v23;
      v27 = *(unsigned __int16 *)(*v23 + 302);
      if ( *(_WORD *)(*v23 + 302) )
      {
        v28 = (int *)(*(_QWORD *)(v26 + 176) + 8LL);
        while ( *((_QWORD *)v28 - 1) != v24 )
        {
          --v27;
          v28 += 4;
          if ( !v27 )
            goto LABEL_29;
        }
        v29 = v26 + 16LL * *v28 + 312;
      }
      else
      {
LABEL_29:
        v29 = sub_6408234(v23, v24, 0);
      }
      v30 = *(_QWORD *)(v29 + 8);
      savedregs[6] = v7;
      v14 = (*(__int64 (__fastcall **)(_QWORD, __int64, __int64 *, _QWORD *, _QWORD *))(v30 + 16))(
              *(_QWORD *)(v30 + 8),
              v30,
              v23,
              &savedregs[6],
              v7);
      if ( a1 )
      {
        v31 = v3[7];
        v32 = v7;
        if ( (*(_DWORD *)(*(_QWORD *)(v31 + 32) + 40LL) & 0x80000000) == 0 )
          v32 = (_QWORD *)*v7;
        v33 = *(__int64 **)(v31 + 48);
        v34 = *v33;
        v35 = (__int64 (__fastcall *)(__int64, __int64 *, void *, _QWORD *))v33[2];
        savedregs[6] = v32;
        v14 = v35(v34, v33, a1, &savedregs[6]);
      }
      v16 = savedregs[5];
      if ( !savedregs[5] )
        goto LABEL_36;
    }
    a0 = (void *)sub_63CF120(v21, v22);
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
    v37 = *i;
    if ( *i )
    {
      v38 = *v37;
      v39 = *(unsigned __int16 *)(*v37 + 302);
      if ( *(_WORD *)(*v37 + 302) )
      {
        v40 = (int *)(*(_QWORD *)(v38 + 176) + 8LL);
        while ( *((_QWORD *)v40 - 1) != System_IDisposable_TypeInfo )
        {
          --v39;
          v40 += 4;
          if ( !v39 )
            goto LABEL_43;
        }
        v41 = v38 + 16LL * *v40 + 312;
      }
      else
      {
LABEL_43:
        v41 = sub_6408234(v37, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v41)(v37, *(_QWORD *)(v41 + 8));
    }
    if ( !v3 )
      break;
LABEL_50:
    sub_63CF118(v3);
    v43 = v42;
    if ( v44 != 1 )
    {
      sub_5D96914(&savedregs[3]);
      sub_64BD8DC(v43);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v42);
    savedregs[3] = v3;
    __cxa_end_catch();
  }
}

