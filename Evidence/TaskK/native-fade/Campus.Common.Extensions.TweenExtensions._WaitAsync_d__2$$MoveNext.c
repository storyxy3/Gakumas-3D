// Campus.Common.Extensions.TweenExtensions.<WaitAsync>d__2$$MoveNext @ 0xdd7ad94
void __fastcall Campus_Common_Extensions_TweenExtensions__WaitAsync_d__2__MoveNext(__int64 a0, void *a1)
{
  void *v2; // x3
  int v4; // w8
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  __int64 v9; // x20
  __int64 v10; // x1
  __int64 v11; // x21
  __int64 *v12; // x20
  unsigned int v13; // w21
  __int128 v14; // q0
  __int64 v15; // x8
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  __int64 v23; // x20
  __int64 v24; // x8
  unsigned int v25; // w21
  __int64 v26; // x9
  _DWORD *v27; // x10
  __int64 v28; // x0
  int v29; // w8
  __int64 *v30; // x19
  __int64 v31; // x8
  __int64 v32; // x9
  _DWORD *v33; // x10
  __int64 v34; // x0
  __int128 v35; // q0
  __int128 v36; // [xsp+10h] [xbp+10h] BYREF
  __int128 v37; // [xsp+20h] [xbp+20h] BYREF

  if ( (unk_F43BABB & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__TweenExtensions__WaitAsync_d__2___);
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F43BABB = 1;
  }
  v4 = *(_DWORD *)a0;
  v36 = 0u;
  if ( v4 )
  {
    v9 = Campus_Common_Extensions_TweenExtensions__WaitAsync_1(*(void **)(a0 + 24), 0, *(_QWORD *)(a0 + 32), v2);
    v11 = v10;
    if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
      sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
    *(_QWORD *)&v37 = v9;
    *((_QWORD *)&v37 + 1) = v11;
    sub_63CEE24(&v37, 0, v5, v6, v7, v8);
    v12 = (__int64 *)v37;
    v13 = DWORD2(v37);
    v36 = v37;
    if ( !unk_F3FFFCB )
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
      unk_F3FFFCB = 1;
    }
    if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
      sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
    if ( unk_F3FFFCC )
    {
      if ( !v12 )
        goto LABEL_22;
    }
    else
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
      unk_F3FFFCC = 1;
      if ( !v12 )
        goto LABEL_22;
    }
    v15 = *v12;
    v16 = *(unsigned __int16 *)(*v12 + 302);
    if ( *(_WORD *)(*v12 + 302) )
    {
      v17 = (int *)(*(_QWORD *)(v15 + 176) + 8LL);
      while ( *((_QWORD *)v17 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
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
      v18 = sub_6408234(v12, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
    }
    if ( !(*(unsigned int (__fastcall **)(__int64 *, _QWORD, _QWORD))v18)(v12, v13, *(_QWORD *)(v18 + 8)) )
    {
      v35 = v36;
      *(_DWORD *)a0 = 0;
      *(_OWORD *)(a0 + 40) = v35;
      sub_63CEE24((void *)(a0 + 40), 0, v19, v20, v21, v22);
      sub_90077DC(
        a0 + 8,
        &v36,
        a0,
        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__TweenExtensions__WaitAsync_d__2___);
      return;
    }
  }
  else
  {
    v14 = *(_OWORD *)(a0 + 40);
    *(_QWORD *)(a0 + 40) = 0;
    *(_QWORD *)(a0 + 48) = 0;
    *(_DWORD *)a0 = -1;
    v36 = v14;
  }
LABEL_22:
  if ( !unk_F3FFFCD )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v23 = v36;
  if ( (_QWORD)v36 )
  {
    v24 = *(_QWORD *)v36;
    v25 = WORD4(v36);
    v26 = *(unsigned __int16 *)(*(_QWORD *)v36 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v36 + 302LL) )
    {
      v27 = (_DWORD *)(*(_QWORD *)(v24 + 176) + 8LL);
      while ( *((_QWORD *)v27 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v26;
        v27 += 4;
        if ( !v26 )
          goto LABEL_29;
      }
      v28 = v24 + 16LL * (*v27 + 2) + 312;
    }
    else
    {
LABEL_29:
      v28 = sub_6408234(v36, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v28)(v23, v25, *(_QWORD *)(v28 + 8));
  }
  v29 = byte_F3FFFCF[0];
  *(_DWORD *)a0 = -2;
  if ( !v29 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v30 = *(__int64 **)(a0 + 8);
  if ( v30 )
  {
    v31 = *v30;
    v32 = *(unsigned __int16 *)(*v30 + 302);
    if ( *(_WORD *)(*v30 + 302) )
    {
      v33 = (_DWORD *)(*(_QWORD *)(v31 + 176) + 8LL);
      while ( *((_QWORD *)v33 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
      {
        --v32;
        v33 += 4;
        if ( !v32 )
          goto LABEL_39;
      }
      v34 = v31 + 16LL * (*v33 + 2) + 312;
    }
    else
    {
LABEL_39:
      v34 = sub_6408234(v30, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v34)(v30, *(_QWORD *)(v34 + 8));
  }
}

