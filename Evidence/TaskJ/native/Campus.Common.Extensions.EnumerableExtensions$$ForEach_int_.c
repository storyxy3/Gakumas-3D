// 0x91f7bfc @ 0x91f7bfc
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach_int_(void *a0, void *a1, void *a2)
{
  _QWORD *v3; // x19
  __int64 *v5; // x21
  __int64 v6; // x1
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  int *v10; // x10
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x1
  __int64 v14; // x22
  unsigned int v15; // w21
  __int64 v16; // x8
  __int64 v17; // x9
  int *v18; // x10
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x1
  __int64 v22; // x22
  __int64 v23; // x1
  __int64 v24; // x0
  __int64 v25; // x8
  __int64 v26; // x9
  int *v27; // x10
  __int64 v28; // x0
  __int64 *i; // x8
  __int64 *v30; // x20
  __int64 v31; // x8
  __int64 v32; // x9
  int *v33; // x10
  __int64 v34; // x0
  void *v35; // x0
  void *v36; // x19
  int v37; // w1
  _QWORD *v38; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v39; // [xsp+10h] [xbp+10h]
  __int64 v40; // [xsp+18h] [xbp+18h] BYREF

  v3 = a2;
  v5 = (__int64 *)a0;
  if ( !*((_QWORD *)a2 + 7) )
  {
    sub_63CEE78(&System_IDisposable_TypeInfo);
    a0 = (void *)sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    if ( !v3[7] )
      a0 = (void *)sub_6407F5C();
  }
  v40 = 0;
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
  v12 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v11)(v5, *(_QWORD *)(v11 + 8));
  v40 = v12;
  v38 = nullptr;
  v39 = &v40;
  if ( v12 )
  {
    v14 = v12;
    v15 = 0;
    while ( 1 )
    {
      v16 = *(_QWORD *)v14;
      v17 = *(unsigned __int16 *)(*(_QWORD *)v14 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v14 + 302LL) )
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
      v20 = (*(__int64 (__fastcall **)(__int64, _QWORD))v19)(v14, *(_QWORD *)(v19 + 8));
      if ( (v20 & 1) == 0 )
        goto LABEL_35;
      v22 = v40;
      if ( !v40 )
        break;
      v23 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v23 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v23 = v24;
      }
      v25 = *(_QWORD *)v22;
      v26 = *(unsigned __int16 *)(*(_QWORD *)v22 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v22 + 302LL) )
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
      v12 = (*(__int64 (__fastcall **)(__int64, _QWORD))v28)(v22, *(_QWORD *)(v28 + 8));
      v13 = (unsigned int)v12;
      if ( a1 )
        v12 = (*((__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD, _QWORD))a1 + 3))(
                *((_QWORD *)a1 + 8),
                (unsigned int)v12,
                v15,
                *((_QWORD *)a1 + 5));
      v14 = v40;
      ++v15;
      if ( !v40 )
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
  for ( i = &v40; ; i = v39 )
  {
    v30 = (__int64 *)*i;
    if ( *i )
    {
      v31 = *v30;
      v32 = *(unsigned __int16 *)(*v30 + 302);
      if ( *(_WORD *)(*v30 + 302) )
      {
        v33 = (int *)(*(_QWORD *)(v31 + 176) + 8LL);
        while ( *((_QWORD *)v33 - 1) != System_IDisposable_TypeInfo )
        {
          --v32;
          v33 += 4;
          if ( !v32 )
            goto LABEL_41;
        }
        v34 = v31 + 16LL * *v33 + 312;
      }
      else
      {
LABEL_41:
        v34 = sub_6408234(v30, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v34)(v30, *(_QWORD *)(v34 + 8));
    }
    if ( !v3 )
      break;
LABEL_48:
    sub_63CF118(v3);
    v36 = v35;
    if ( v37 != 1 )
    {
      sub_5D96914(&v38);
      sub_64BD8DC(v36);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v35);
    v38 = v3;
    __cxa_end_catch();
  }
}

