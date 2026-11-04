// 0x91f7080 @ 0x91f7080
void __fastcall Campus_Common_Extensions_EnumerableExtensions__ForEach_ValueTuple_uint__Color__(
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
  _QWORD *v14; // x21
  __int64 v15; // x8
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x1
  _QWORD *v21; // x21
  __int64 v22; // x1
  __int64 v23; // x0
  __int64 v24; // x8
  __int64 v25; // x9
  int *v26; // x10
  __int64 v27; // x0
  __int64 v28; // x0
  __int64 (__fastcall *v29)(__int64, __int128 *, __int64); // x9
  __int64 v30; // x2
  __int64 **i; // x8
  __int64 *v32; // x20
  __int64 v33; // x8
  __int64 v34; // x9
  int *v35; // x10
  __int64 v36; // x0
  void *v37; // x0
  void *v38; // x19
  int v39; // w1
  _QWORD *v40; // [xsp+0h] [xbp+0h] BYREF
  __int64 **v41; // [xsp+8h] [xbp+8h]
  __int128 v42; // [xsp+10h] [xbp+10h]
  int v43; // [xsp+20h] [xbp+20h]
  __int128 v44; // [xsp+30h] [xbp+30h] BYREF
  int v45; // [xsp+40h] [xbp+40h]
  _QWORD *v46; // [xsp+58h] [xbp+58h] BYREF

  v3 = a2;
  v5 = (__int64 *)a0;
  if ( !*((_QWORD *)a2 + 7) )
  {
    sub_63CEE78(&System_IDisposable_TypeInfo);
    a0 = (void *)sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    if ( !v3[7] )
      a0 = (void *)sub_6407F5C();
  }
  v46 = nullptr;
  v42 = 0u;
  v43 = 0;
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
  v46 = v12;
  v40 = nullptr;
  v41 = &v46;
  if ( v12 )
  {
    v14 = v12;
    while ( 1 )
    {
      v15 = *v14;
      v16 = *(unsigned __int16 *)(*v14 + 302LL);
      if ( *(_WORD *)(*v14 + 302LL) )
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
      v19 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))v18)(v14, *(_QWORD *)(v18 + 8));
      if ( (v19 & 1) == 0 )
        goto LABEL_35;
      v21 = v46;
      if ( !v46 )
        break;
      v22 = *(_QWORD *)(v3[7] + 16LL);
      if ( (*(_WORD *)(v22 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(v3[7] + 16LL));
        v22 = v23;
      }
      v24 = *v21;
      v25 = *(unsigned __int16 *)(*v21 + 302LL);
      if ( *(_WORD *)(*v21 + 302LL) )
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
      v12 = (*(_QWORD *(__fastcall **)(__int128 *__return_ptr, _QWORD *, _QWORD))v27)(&v44, v21, *(_QWORD *)(v27 + 8));
      v42 = v44;
      v43 = v45;
      if ( a1 )
      {
        v28 = *((_QWORD *)a1 + 8);
        v29 = *((__int64 (__fastcall **)(__int64, __int128 *, __int64))a1 + 3);
        v30 = *((_QWORD *)a1 + 5);
        v44 = v42;
        v45 = v43;
        v12 = (_QWORD *)v29(v28, &v44, v30);
      }
      v14 = v46;
      if ( !v46 )
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
  for ( i = &v46; ; i = v41 )
  {
    v32 = *i;
    if ( *i )
    {
      v33 = *v32;
      v34 = *(unsigned __int16 *)(*v32 + 302);
      if ( *(_WORD *)(*v32 + 302) )
      {
        v35 = (int *)(*(_QWORD *)(v33 + 176) + 8LL);
        while ( *((_QWORD *)v35 - 1) != System_IDisposable_TypeInfo )
        {
          --v34;
          v35 += 4;
          if ( !v34 )
            goto LABEL_41;
        }
        v36 = v33 + 16LL * *v35 + 312;
      }
      else
      {
LABEL_41:
        v36 = sub_6408234(v32, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v36)(v32, *(_QWORD *)(v36 + 8));
    }
    if ( !v3 )
      break;
LABEL_48:
    sub_63CF118(v3);
    v38 = v37;
    if ( v39 != 1 )
    {
      sub_5D96914(&v40);
      sub_64BD8DC(v38);
    }
    v3 = *(_QWORD **)__cxa_begin_catch(v37);
    v40 = v3;
    __cxa_end_catch();
  }
}

