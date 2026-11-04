// 0x91f7374 @ 0x91f7374
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach_ValueTuple_long__long__bool__(
        void *a0,
        void *a1,
        void *a2)
{
  _QWORD *v3; // x19
  __int64 *v5; // x21
  __int64 v6; // x1
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  int *v10; // x10
  __int64 v11; // x0
  _QWORD *v12; // x0
  __int64 v13; // x1
  _QWORD *v14; // x22
  unsigned int v15; // w21
  __int64 v16; // x8
  __int64 v17; // x9
  int *v18; // x10
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x1
  _QWORD *v22; // x22
  __int64 v23; // x1
  __int64 v24; // x0
  __int64 v25; // x8
  __int64 v26; // x9
  int *v27; // x10
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 (__fastcall *v30)(__int64, __int128 *, _QWORD, __int64); // x9
  __int64 v31; // x3
  __int64 **i; // x8
  __int64 *v33; // x20
  __int64 v34; // x8
  __int64 v35; // x9
  int *v36; // x10
  __int64 v37; // x0
  void *v38; // x0
  void *v39; // x19
  int v40; // w1
  _QWORD *v41; // [xsp+0h] [xbp+0h] BYREF
  __int64 **v42; // [xsp+8h] [xbp+8h]
  __int128 v43; // [xsp+10h] [xbp+10h]
  __int64 v44; // [xsp+20h] [xbp+20h]
  _QWORD *v45; // [xsp+28h] [xbp+28h] BYREF
  __int128 v46; // [xsp+30h] [xbp+30h] BYREF
  __int64 v47; // [xsp+40h] [xbp+40h]

  v3 = a2;
  v5 = (__int64 *)a0;
  if ( !*((_QWORD *)a2 + 7) )
  {
    sub_63CEE78(&System_IDisposable_TypeInfo);
    a0 = (void *)sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    if ( !v3[7] )
      a0 = (void *)sub_6407F5C();
  }
  v44 = 0;
  v45 = nullptr;
  v43 = 0u;
  if ( !v5 )
    goto LABEL_47;
  v6 = *(_QWORD *)v3[7];
  if ( (*(_WORD *)(v6 + 309) & 1) == 0 )
  {
    sub_6407F00(*(_QWORD *)v3[7]);
    v6 = v7;
  }
  v8 = *v5;
  v9 = *(unsigned __int16 *)(*v5 + 302);
  if ( *(_WORD *)(*v5 + 302) )
  {
    v10 = (int *)(*(_QWORD *)(v8 + 176) + 8LL);
    while ( *((_QWORD *)v10 - 1) != v6 )
    {
      --v9;
      v10 += 4;
      if ( !v9 )
        goto LABEL_11;
    }
    v11 = v8 + 16LL * *v10 + 312;
  }
  else
  {
LABEL_11:
    v11 = sub_6408234(v5, v6, 0);
  }
  v12 = (_QWORD *)(*(__int64 (__fastcall **)(__int64 *, _QWORD))v11)(v5, *(_QWORD *)(v11 + 8));
  v45 = v12;
  v41 = nullptr;
  v42 = &v45;
  if ( v12 )
  {
    v14 = v12;
    v15 = 0;
    while ( 1 )
    {
      v16 = *v14;
      v17 = *(unsigned __int16 *)(*v14 + 302LL);
      if ( *(_WORD *)(*v14 + 302LL) )
      {
        v18 = (int *)(*(_QWORD *)(v16 + 176) + 8LL);
        while ( *((_QWORD *)v18 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v17;
          v18 += 4;
          if ( !v17 )
            goto LABEL_19;
        }
        v19 = v16 + 16LL * *v18 + 312;
      }
      else
      {
LABEL_19:
        v19 = sub_6408234(v14, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v20 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))v19)(v14, *(_QWORD *)(v19 + 8));
      if ( (v20 & 1) == 0 )
        goto LABEL_35;
      v22 = v45;
      if ( !v45 )
        break;
      v23 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v23 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v23 = v24;
      }
      v25 = *v22;
      v26 = *(unsigned __int16 *)(*v22 + 302LL);
      if ( *(_WORD *)(*v22 + 302LL) )
      {
        v27 = (int *)(*(_QWORD *)(v25 + 176) + 8LL);
        while ( *((_QWORD *)v27 - 1) != v23 )
        {
          --v26;
          v27 += 4;
          if ( !v26 )
            goto LABEL_29;
        }
        v28 = v25 + 16LL * *v27 + 312;
      }
      else
      {
LABEL_29:
        v28 = sub_6408234(v22, v23, 0);
      }
      v12 = (*(_QWORD *(__fastcall **)(__int128 *__return_ptr, _QWORD *, _QWORD))v28)(&v46, v22, *(_QWORD *)(v28 + 8));
      v43 = v46;
      v44 = v47;
      if ( a1 )
      {
        v29 = *((_QWORD *)a1 + 8);
        v30 = *((__int64 (__fastcall **)(__int64, __int128 *, _QWORD, __int64))a1 + 3);
        v31 = *((_QWORD *)a1 + 5);
        v46 = v43;
        v47 = v44;
        v12 = (_QWORD *)v30(v29, &v46, v15, v31);
      }
      v14 = v45;
      ++v15;
      if ( !v45 )
        goto LABEL_34;
    }
    a0 = (void *)sub_63CF120(v20, v21);
LABEL_47:
    sub_63CF120(a0, a1);
    goto LABEL_48;
  }
LABEL_34:
  sub_63CF120(v12, v13);
LABEL_35:
  v3 = nullptr;
  for ( i = &v45; ; i = v42 )
  {
    v33 = *i;
    if ( *i )
    {
      v34 = *v33;
      v35 = *(unsigned __int16 *)(*v33 + 302);
      if ( *(_WORD *)(*v33 + 302) )
      {
        v36 = (int *)(*(_QWORD *)(v34 + 176) + 8LL);
        while ( *((_QWORD *)v36 - 1) != System_IDisposable_TypeInfo )
        {
          --v35;
          v36 += 4;
          if ( !v35 )
            goto LABEL_41;
        }
        v37 = v34 + 16LL * *v36 + 312;
      }
      else
      {
LABEL_41:
        v37 = sub_6408234(v33, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v37)(v33, *(_QWORD *)(v37 + 8));
    }
    if ( !v3 )
      break;
LABEL_48:
    sub_63CF118(v3);
    v39 = v38;
    if ( v40 != 1 )
    {
      sub_5D96914(&v41);
      sub_64BD8DC(v39);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v38);
    v41 = v3;
    __cxa_end_catch();
  }
}

