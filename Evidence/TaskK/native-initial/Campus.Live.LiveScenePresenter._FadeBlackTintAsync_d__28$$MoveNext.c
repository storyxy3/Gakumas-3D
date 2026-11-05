// Campus.Live.LiveScenePresenter.<FadeBlackTintAsync>d__28$$MoveNext @ 0x670fc00
void __fastcall Campus_Live_LiveScenePresenter__FadeBlackTintAsync_d__28__MoveNext(__int64 a0, void *a1)
{
  void *v2; // x3
  __int64 v3; // x19
  int v4; // w8
  __int64 v5; // x8
  void *v6; // x0
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5
  __int64 v11; // x20
  __int64 v12; // x1
  __int64 v13; // x21
  __int64 *v14; // x20
  unsigned int v15; // w21
  __int128 v16; // q0
  __int64 v17; // x8
  __int64 v18; // x9
  int *v19; // x10
  __int64 v20; // x0
  int v21; // w2
  int v22; // w3
  int v23; // w4
  void *v24; // x5
  __int64 v25; // x20
  __int64 v26; // x8
  unsigned int v27; // w21
  __int64 v28; // x9
  _DWORD *v29; // x10
  __int64 v30; // x0
  int v31; // w8
  __int64 *v32; // x19
  __int64 v33; // x8
  __int64 v34; // x9
  _DWORD *v35; // x10
  __int64 v36; // x0
  __int128 v37; // q0
  void *v38; // x0
  int v39; // w1
  _QWORD **v40; // x20
  __int64 v41; // x0
  int v42; // w21
  _QWORD *v43; // x20
  _QWORD *exception; // x0
  __int64 v45; // [xsp+0h] [xbp+0h]
  int v46; // [xsp+8h] [xbp+8h]
  __int128 v47; // [xsp+10h] [xbp+10h] BYREF
  __int128 v48; // [xsp+20h] [xbp+20h] BYREF
  UnityEngine_Color_o v49; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v3 = a0;
  if ( (unk_F4011D0 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LiveScenePresenter__FadeBlackTintAsync_d__28___);
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F4011D0 = 1;
  }
  v4 = *(_DWORD *)v3;
  v47 = 0u;
  v46 = 0;
  if ( !v4 )
  {
    v16 = *(_OWORD *)(v3 + 48);
    *(_QWORD *)(v3 + 48) = 0;
    *(_QWORD *)(v3 + 56) = 0;
    *(_DWORD *)v3 = -1;
    v47 = v16;
    goto LABEL_24;
  }
  v5 = *(_QWORD *)(v3 + 24);
  if ( !v5 )
  {
    v6 = (void *)sub_63CF120(a0, a1);
    goto LABEL_47;
  }
  v6 = *(void **)(v5 + 32);
  if ( !v6 )
  {
LABEL_47:
    v38 = (void *)sub_63CF120(v6, a1);
    if ( v39 != 1 )
      sub_64BD8DC(v38);
    v40 = (_QWORD **)__cxa_begin_catch(v38);
    v41 = sub_63CEE8C(&System_Exception_TypeInfo);
    if ( (sub_63CF528(v41, **v40) & 1) == 0 )
    {
      exception = __cxa_allocate_exception(8u);
      *exception = *v40;
      __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
    }
    v42 = v46;
    v43 = *v40;
    *(&v45 + v46) = (__int64)v43;
    v46 = v42 + 1;
    __cxa_end_catch();
    *(_DWORD *)v3 = -2;
    sub_64DD2CC(v3 + 8, v43, 0);
    v46 = v42;
    return;
  }
  v49.r = 0.0;
  v49.g = 0.0;
  v49.b = 0.0;
  v49.a = 1.0;
  v11 = Campus_Live_LiveSceneView__FadeBlackTintAsync_1(v6, *(_BYTE *)(v3 + 32), v49, 0.3, *(_QWORD *)(v3 + 40), v2);
  v13 = v12;
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  *(_QWORD *)&v48 = v11;
  *((_QWORD *)&v48 + 1) = v13;
  sub_63CEE24(&v48, 0, v7, v8, v9, v10);
  v14 = (__int64 *)v48;
  v15 = DWORD2(v48);
  v47 = v48;
  if ( !unk_F3FFFCB )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F3FFFCB = 1;
  }
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  if ( unk_F3FFFCC )
  {
    if ( !v14 )
      goto LABEL_24;
LABEL_17:
    v17 = *v14;
    v18 = *(unsigned __int16 *)(*v14 + 302);
    if ( *(_WORD *)(*v14 + 302) )
    {
      v19 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v18;
        v19 += 4;
        if ( !v18 )
          goto LABEL_21;
      }
      v20 = v17 + 16LL * *v19 + 312;
    }
    else
    {
LABEL_21:
      v20 = sub_6408234(v14, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
    }
    if ( !(*(unsigned int (__fastcall **)(__int64 *, _QWORD, _QWORD))v20)(v14, v15, *(_QWORD *)(v20 + 8)) )
    {
      v37 = v47;
      *(_DWORD *)v3 = 0;
      *(_OWORD *)(v3 + 48) = v37;
      sub_63CEE24((void *)(v3 + 48), 0, v21, v22, v23, v24);
      sub_67223FC(
        v3 + 8,
        &v47,
        v3,
        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LiveScenePresenter__FadeBlackTintAsync_d__28___);
      return;
    }
    goto LABEL_24;
  }
  sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
  unk_F3FFFCC = 1;
  if ( v14 )
    goto LABEL_17;
LABEL_24:
  if ( !unk_F3FFFCD )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v25 = v47;
  if ( (_QWORD)v47 )
  {
    v26 = *(_QWORD *)v47;
    v27 = WORD4(v47);
    v28 = *(unsigned __int16 *)(*(_QWORD *)v47 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v47 + 302LL) )
    {
      v29 = (_DWORD *)(*(_QWORD *)(v26 + 176) + 8LL);
      while ( *((_QWORD *)v29 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v28;
        v29 += 4;
        if ( !v28 )
          goto LABEL_31;
      }
      v30 = v26 + 16LL * (*v29 + 2) + 312;
    }
    else
    {
LABEL_31:
      v30 = sub_6408234(v47, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v30)(v25, v27, *(_QWORD *)(v30 + 8));
  }
  v31 = byte_F3FFFCF[0];
  *(_DWORD *)v3 = -2;
  if ( !v31 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v32 = *(__int64 **)(v3 + 8);
  if ( v32 )
  {
    v33 = *v32;
    v34 = *(unsigned __int16 *)(*v32 + 302);
    if ( *(_WORD *)(*v32 + 302) )
    {
      v35 = (_DWORD *)(*(_QWORD *)(v33 + 176) + 8LL);
      while ( *((_QWORD *)v35 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
      {
        --v34;
        v35 += 4;
        if ( !v34 )
          goto LABEL_41;
      }
      v36 = v33 + 16LL * (*v35 + 2) + 312;
    }
    else
    {
LABEL_41:
      v36 = sub_6408234(v32, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v36)(v32, *(_QWORD *)(v36 + 8));
  }
}

