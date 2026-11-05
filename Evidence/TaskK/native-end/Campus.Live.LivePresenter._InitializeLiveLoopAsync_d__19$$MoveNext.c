// Campus.Live.LivePresenter.<InitializeLiveLoopAsync>d__19$$MoveNext @ 0x863ef60
void __fastcall Campus_Live_LivePresenter__InitializeLiveLoopAsync_d__19__MoveNext(__int64 a0, void *a1)
{
  void *v2; // x2
  __int64 v3; // x19
  int v4; // w8
  __int64 v5; // x22
  __int128 v6; // q0
  __int128 v7; // q0
  void *v8; // x0
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v13; // x20
  __int64 v14; // x1
  __int64 v15; // x21
  __int64 v16; // x20
  __int64 v17; // x8
  unsigned int v18; // w21
  __int64 v19; // x9
  int *v20; // x10
  __int64 v21; // x0
  int v22; // w2
  int v23; // w3
  int v24; // w4
  void *v25; // x5
  __int64 v26; // x20
  __int64 v27; // x8
  unsigned int v28; // w21
  __int64 v29; // x9
  _DWORD *v30; // x10
  __int64 v31; // x0
  __int64 v32; // x20
  __int64 v33; // x1
  int v34; // w2
  int v35; // w3
  int v36; // w4
  void *v37; // x5
  __int64 v38; // x20
  __int64 v39; // x8
  unsigned int v40; // w21
  __int64 v41; // x9
  int *v42; // x10
  __int64 v43; // x0
  int v44; // w2
  int v45; // w3
  int v46; // w4
  void *v47; // x5
  __int64 v48; // x20
  __int64 v49; // x8
  unsigned int v50; // w21
  __int64 v51; // x9
  _DWORD *v52; // x10
  __int64 v53; // x0
  __int64 v54; // x8
  __int64 v55; // x9
  __int64 v56; // x9
  int v57; // w8
  __int64 *v58; // x19
  __int64 v59; // x8
  __int64 v60; // x9
  _DWORD *v61; // x10
  __int64 v62; // x0
  __int128 v63; // q0
  __int128 v64; // q0
  void *v65; // x0
  int v66; // w1
  _QWORD **v67; // x20
  __int64 v68; // x0
  int v69; // w21
  _QWORD *v70; // x20
  _QWORD *exception; // x0
  __int64 v72; // [xsp+0h] [xbp+0h]
  int v73; // [xsp+8h] [xbp+8h]
  __int128 v74; // [xsp+10h] [xbp+10h] BYREF
  __int128 v75; // [xsp+20h] [xbp+20h] BYREF

  v3 = a0;
  if ( (unk_F41399F & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LivePresenter__InitializeLiveLoopAsync_d__19___);
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F41399F = 1;
  }
  v4 = *(_DWORD *)v3;
  v5 = *(_QWORD *)(v3 + 24);
  v74 = 0u;
  v73 = 0;
  if ( v4 )
  {
    if ( v4 == 1 )
    {
      v6 = *(_OWORD *)(v3 + 40);
      *(_QWORD *)(v3 + 40) = 0;
      *(_QWORD *)(v3 + 48) = 0;
      *(_DWORD *)v3 = -1;
      v74 = v6;
      goto LABEL_51;
    }
    if ( !v5 )
    {
LABEL_83:
      v8 = (void *)sub_63CF120(a0, a1);
      goto LABEL_84;
    }
    v8 = *(void **)(v5 + 48);
    if ( !v8 )
    {
LABEL_84:
      v65 = (void *)sub_63CF120(v8, a1);
      if ( v66 != 1 )
        sub_64BD8DC(v65);
      v67 = (_QWORD **)__cxa_begin_catch(v65);
      v68 = sub_63CEE8C(&System_Exception_TypeInfo);
      if ( (sub_63CF528(v68, **v67) & 1) == 0 )
      {
        exception = __cxa_allocate_exception(8u);
        *exception = *v67;
        __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
      }
      v69 = v73;
      v70 = *v67;
      *(&v72 + v73) = (__int64)v70;
      v73 = v69 + 1;
      __cxa_end_catch();
      *(_DWORD *)v3 = -2;
      sub_64DD2CC(v3 + 8, v70, 0);
      v73 = v69;
      return;
    }
    v13 = Campus_Live_LivePlayerPresenter__Build3DAsync(v8, *(_QWORD *)(v3 + 32), v2);
    v15 = v14;
    if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
      sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
    *(_QWORD *)&v75 = v13;
    *((_QWORD *)&v75 + 1) = v15;
    sub_63CEE24(&v75, 0, v9, v10, v11, v12);
    v74 = v75;
    if ( !unk_F3FFFCB )
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
      unk_F3FFFCB = 1;
    }
    if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
      sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
    if ( !unk_F3FFFCC )
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
      unk_F3FFFCC = 1;
    }
    v16 = v74;
    if ( (_QWORD)v74 )
    {
      v17 = *(_QWORD *)v74;
      v18 = WORD4(v74);
      v19 = *(unsigned __int16 *)(*(_QWORD *)v74 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v74 + 302LL) )
      {
        v20 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
        while ( *((_QWORD *)v20 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
        {
          --v19;
          v20 += 4;
          if ( !v19 )
            goto LABEL_22;
        }
        v21 = v17 + 16LL * *v20 + 312;
      }
      else
      {
LABEL_22:
        v21 = sub_6408234(v74, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
      }
      if ( !(*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v21)(v16, v18, *(_QWORD *)(v21 + 8)) )
      {
        v64 = v74;
        *(_DWORD *)v3 = 0;
        *(_OWORD *)(v3 + 40) = v64;
        sub_63CEE24((void *)(v3 + 40), 0, v22, v23, v24, v25);
        ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8649BF8)(
          v3 + 8,
          &v74,
          v3,
          Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LivePresenter__InitializeLiveLoopAsync_d__19___);
        return;
      }
    }
  }
  else
  {
    v7 = *(_OWORD *)(v3 + 40);
    *(_QWORD *)(v3 + 40) = 0;
    *(_QWORD *)(v3 + 48) = 0;
    *(_DWORD *)v3 = -1;
    v74 = v7;
  }
  if ( !unk_F3FFFCD )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v26 = v74;
  if ( (_QWORD)v74 )
  {
    v27 = *(_QWORD *)v74;
    v28 = WORD4(v74);
    v29 = *(unsigned __int16 *)(*(_QWORD *)v74 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v74 + 302LL) )
    {
      v30 = (_DWORD *)(*(_QWORD *)(v27 + 176) + 8LL);
      while ( *((_QWORD *)v30 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v29;
        v30 += 4;
        if ( !v29 )
          goto LABEL_32;
      }
      v31 = v27 + 16LL * (*v30 + 2) + 312;
    }
    else
    {
LABEL_32:
      v31 = sub_6408234(v74, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v31)(v26, v28, *(_QWORD *)(v31 + 8));
  }
  v32 = *(_QWORD *)(v3 + 32);
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  *(_QWORD *)&v75 = Cysharp_Threading_Tasks_UniTask__DelayFrame(1, 8, v32, 0, nullptr);
  *((_QWORD *)&v75 + 1) = v33;
  sub_63CEE24(&v75, 0, v34, v35, v36, v37);
  v74 = v75;
  if ( !unk_F3FFFCB )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F3FFFCB = 1;
  }
  a0 = Cysharp_Threading_Tasks_UniTask_TypeInfo;
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  if ( !unk_F3FFFCC )
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCC = 1;
  }
  v38 = v74;
  if ( (_QWORD)v74 )
  {
    v39 = *(_QWORD *)v74;
    v40 = WORD4(v74);
    v41 = *(unsigned __int16 *)(*(_QWORD *)v74 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v74 + 302LL) )
    {
      v42 = (int *)(*(_QWORD *)(v39 + 176) + 8LL);
      while ( *((_QWORD *)v42 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v41;
        v42 += 4;
        if ( !v41 )
          goto LABEL_48;
      }
      v43 = v39 + 16LL * *v42 + 312;
    }
    else
    {
LABEL_48:
      v43 = sub_6408234(v74, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
    }
    a0 = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))v43)(v38, v40, *(_QWORD *)(v43 + 8));
    if ( !(_DWORD)a0 )
    {
      v63 = v74;
      *(_DWORD *)v3 = 1;
      *(_OWORD *)(v3 + 40) = v63;
      sub_63CEE24((void *)(v3 + 40), 0, v44, v45, v46, v47);
      ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8649BF8)(
        v3 + 8,
        &v74,
        v3,
        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LivePresenter__InitializeLiveLoopAsync_d__19___);
      return;
    }
  }
LABEL_51:
  if ( !unk_F3FFFCD )
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v48 = v74;
  if ( (_QWORD)v74 )
  {
    v49 = *(_QWORD *)v74;
    v50 = WORD4(v74);
    v51 = *(unsigned __int16 *)(*(_QWORD *)v74 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v74 + 302LL) )
    {
      v52 = (_DWORD *)(*(_QWORD *)(v49 + 176) + 8LL);
      while ( *((_QWORD *)v52 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v51;
        v52 += 4;
        if ( !v51 )
          goto LABEL_58;
      }
      v53 = v49 + 16LL * (*v52 + 2) + 312;
    }
    else
    {
LABEL_58:
      v53 = sub_6408234(v74, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    a0 = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))v53)(v48, v50, *(_QWORD *)(v53 + 8));
  }
  if ( !v5 )
  {
    a0 = sub_63CF120(a0, a1);
    goto LABEL_80;
  }
  v54 = *(_QWORD *)(v5 + 32);
  if ( !v54 )
  {
LABEL_80:
    a0 = sub_63CF120(a0, a1);
    goto LABEL_81;
  }
  v55 = *(_QWORD *)(v5 + 48);
  if ( !v55 )
  {
LABEL_81:
    a0 = sub_63CF120(a0, a1);
LABEL_82:
    a0 = sub_63CF120(a0, a1);
    goto LABEL_83;
  }
  v56 = *(_QWORD *)(v55 + 32);
  if ( !v56 )
    goto LABEL_82;
  a0 = *(_QWORD *)(v54 + 32);
  if ( !a0 )
    goto LABEL_82;
  Campus_Live_Data_LiveExecutionData__SetMaxTime((void *)a0, *(float *)(v56 + 32), nullptr);
  v57 = byte_F3FFFCF[0];
  *(_DWORD *)v3 = -2;
  if ( !v57 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v58 = *(__int64 **)(v3 + 8);
  if ( v58 )
  {
    v59 = *v58;
    v60 = *(unsigned __int16 *)(*v58 + 302);
    if ( *(_WORD *)(*v58 + 302) )
    {
      v61 = (_DWORD *)(*(_QWORD *)(v59 + 176) + 8LL);
      while ( *((_QWORD *)v61 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
      {
        --v60;
        v61 += 4;
        if ( !v60 )
          goto LABEL_73;
      }
      v62 = v59 + 16LL * (*v61 + 2) + 312;
    }
    else
    {
LABEL_73:
      v62 = sub_6408234(v58, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v62)(v58, *(_QWORD *)(v62 + 8));
  }
}

