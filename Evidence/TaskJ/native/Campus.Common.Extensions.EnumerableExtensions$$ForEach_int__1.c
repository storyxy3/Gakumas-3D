// 0x91f7934 @ 0x91f7934
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach_int__1(void *a0, void *a1, void *a2)
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
  __int64 v14; // x21
  __int64 v15; // x8
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x1
  __int64 v21; // x21
  __int64 v22; // x1
  __int64 v23; // x0
  __int64 v24; // x8
  __int64 v25; // x9
  int *v26; // x10
  __int64 v27; // x0
  __int64 *i; // x8
  __int64 *v29; // x20
  __int64 v30; // x8
  __int64 v31; // x9
  int *v32; // x10
  __int64 v33; // x0
  void *v34; // x0
  void *v35; // x19
  int v36; // w1
  _QWORD *v37; // [xsp+0h] [xbp+0h] BYREF
  __int64 *v38; // [xsp+8h] [xbp+8h]
  __int64 v39; // [xsp+18h] [xbp+18h] BYREF

  v3 = a2;
  v5 = (__int64 *)a0;
  if ( !*((_QWORD *)a2 + 7) )
  {
    sub_63CEE78(&System_IDisposable_TypeInfo);
    a0 = (void *)sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    if ( !v3[7] )
      a0 = (void *)sub_6407F5C();
  }
  v39 = 0;
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
  v39 = v12;
  v37 = nullptr;
  v38 = &v39;
  if ( v12 )
  {
    v14 = v12;
    while ( 1 )
    {
      v15 = *(_QWORD *)v14;
      v16 = *(unsigned __int16 *)(*(_QWORD *)v14 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v14 + 302LL) )
      {
        v17 = (int *)(*(_QWORD *)(v15 + 176) + 8LL);
        while ( *((_QWORD *)v17 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v16;
          v17 += 4;
          if ( !v16 )
            goto LABEL_19;
        }
        v18 = v15 + 16LL * *v17 + 312;
      }
      else
      {
LABEL_19:
        v18 = sub_6408234(v14, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v19 = (*(__int64 (__fastcall **)(__int64, _QWORD))v18)(v14, *(_QWORD *)(v18 + 8));
      if ( (v19 & 1) == 0 )
        goto LABEL_35;
      v21 = v39;
      if ( !v39 )
        break;
      v22 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v22 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v22 = v23;
      }
      v24 = *(_QWORD *)v21;
      v25 = *(unsigned __int16 *)(*(_QWORD *)v21 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v21 + 302LL) )
      {
        v26 = (int *)(*(_QWORD *)(v24 + 176) + 8LL);
        while ( *((_QWORD *)v26 - 1) != v22 )
        {
          --v25;
          v26 += 4;
          if ( !v25 )
            goto LABEL_29;
        }
        v27 = v24 + 16LL * *v26 + 312;
      }
      else
      {
LABEL_29:
        v27 = sub_6408234(v21, v22, 0);
      }
      v12 = (*(__int64 (__fastcall **)(__int64, _QWORD))v27)(v21, *(_QWORD *)(v27 + 8));
      v13 = (unsigned int)v12;
      if ( a1 )
        v12 = (*((__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))a1 + 3))(
                *((_QWORD *)a1 + 8),
                (unsigned int)v12,
                *((_QWORD *)a1 + 5));
      v14 = v39;
      if ( !v39 )
        goto LABEL_34;
    }
    a0 = (void *)sub_63CF120(v19, v20);
LABEL_47:
    sub_63CF120(a0, a1);
    goto LABEL_48;
  }
LABEL_34:
  sub_63CF120(v12, v13);
LABEL_35:
  v3 = nullptr;
  for ( i = &v39; ; i = v38 )
  {
    v29 = (__int64 *)*i;
    if ( *i )
    {
      v30 = *v29;
      v31 = *(unsigned __int16 *)(*v29 + 302);
      if ( *(_WORD *)(*v29 + 302) )
      {
        v32 = (int *)(*(_QWORD *)(v30 + 176) + 8LL);
        while ( *((_QWORD *)v32 - 1) != System_IDisposable_TypeInfo )
        {
          --v31;
          v32 += 4;
          if ( !v31 )
            goto LABEL_41;
        }
        v33 = v30 + 16LL * *v32 + 312;
      }
      else
      {
LABEL_41:
        v33 = sub_6408234(v29, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v33)(v29, *(_QWORD *)(v33 + 8));
    }
    if ( !v3 )
      break;
LABEL_48:
    sub_63CF118(v3);
    v35 = v34;
    if ( v36 != 1 )
    {
      sub_5D96914(&v37);
      sub_64BD8DC(v35);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v34);
    v37 = v3;
    __cxa_end_catch();
  }
}

