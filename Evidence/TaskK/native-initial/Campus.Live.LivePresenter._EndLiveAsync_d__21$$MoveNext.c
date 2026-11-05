// Campus.Live.LivePresenter.<EndLiveAsync>d__21$$MoveNext @ 0x863e718
void __fastcall Campus_Live_LivePresenter__EndLiveAsync_d__21__MoveNext(__int64 a0, void *a1)
{
  __int64 v2; // x19
  int v3; // w8
  __int64 v4; // x22
  void *Instance; // x0
  __int64 v6; // x1
  __int64 v7; // x20
  __int64 v8; // x1
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  long double v13; // q0
  __int64 *v14; // x20
  unsigned int v15; // w21
  __int64 v16; // x8
  __int64 v17; // x9
  int *v18; // x10
  __int64 v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  __int64 v24; // x20
  __int64 v25; // x8
  unsigned int v26; // w21
  __int64 v27; // x9
  _DWORD *v28; // x10
  __int64 v29; // x0
  __int64 v30; // x8
  int v31; // w8
  __int64 *v32; // x19
  __int64 v33; // x8
  __int64 v34; // x9
  _DWORD *v35; // x10
  __int64 v36; // x0
  long double v37; // q0
  void *v38; // x0
  int v39; // w1
  _QWORD **v40; // x20
  __int64 v41; // x0
  int v42; // w21
  _QWORD *v43; // x20
  _QWORD *exception; // x0
  __int64 v45; // [xsp+0h] [xbp+0h]
  int v46; // [xsp+8h] [xbp+8h]
  long double v47; // [xsp+10h] [xbp+10h] BYREF
  long double v48; // [xsp+20h] [xbp+20h] BYREF

  v2 = a0;
  if ( (unk_F41399D & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LivePresenter__EndLiveAsync_d__21___);
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    a0 = sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    unk_F41399D = 1;
  }
  v3 = *(_DWORD *)v2;
  v4 = *(_QWORD *)(v2 + 32);
  *(_OWORD *)&v47 = 0u;
  v46 = 0;
  if ( !v3 )
  {
    v13 = *(long double *)(v2 + 40);
    *(_QWORD *)(v2 + 40) = 0;
    *(_QWORD *)(v2 + 48) = 0;
    *(_DWORD *)v2 = -1;
    v47 = v13;
    goto LABEL_23;
  }
  Instance = VL_Core_VLMonoBehaviourSingleton_object___get_Instance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
  if ( !Instance )
  {
LABEL_49:
    v38 = (void *)sub_63CF120(Instance, v6);
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
    *(_DWORD *)v2 = -2;
    sub_64DD2CC(v2 + 8, v43, 0);
    v46 = v42;
    return;
  }
  VL_Rendering_VLSRPCameraController__CaptureRequest(Instance, nullptr);
  v7 = *(_QWORD *)(v2 + 24);
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  *(_QWORD *)&v48 = Cysharp_Threading_Tasks_UniTask__DelayFrame(0, 8, v7, 0, nullptr);
  *((_QWORD *)&v48 + 1) = v8;
  sub_63CEE24(&v48, 0, v9, v10, v11, v12);
  v14 = *(__int64 **)&v48;
  v15 = DWORD2(v48);
  v47 = v48;
  if ( !unk_F3FFFCB )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F3FFFCB = 1;
  }
  a0 = Cysharp_Threading_Tasks_UniTask_TypeInfo;
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    *(__n128 *)&v13 = sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  if ( unk_F3FFFCC )
  {
    if ( !v14 )
      goto LABEL_23;
  }
  else
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCC = 1;
    if ( !v14 )
      goto LABEL_23;
  }
  v16 = *v14;
  v17 = *(unsigned __int16 *)(*v14 + 302);
  if ( *(_WORD *)(*v14 + 302) )
  {
    v18 = (int *)(*(_QWORD *)(v16 + 176) + 8LL);
    while ( *((_QWORD *)v18 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
    {
      --v17;
      v18 += 4;
      if ( !v17 )
        goto LABEL_20;
    }
    v19 = v16 + 16LL * *v18 + 312;
  }
  else
  {
LABEL_20:
    v19 = sub_6408234(v14, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
  }
  a0 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v19)(v14, v15, *(_QWORD *)(v19 + 8));
  if ( !(_DWORD)a0 )
  {
    v37 = v47;
    *(_DWORD *)v2 = 0;
    *(long double *)(v2 + 40) = v37;
    sub_63CEE24((void *)(v2 + 40), 0, v20, v21, v22, v23);
    ((void (__fastcall *)(__int64, long double *, __int64, _QWORD))loc_86499E0)(
      v2 + 8,
      &v47,
      v2,
      Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__LivePresenter__EndLiveAsync_d__21___);
    return;
  }
LABEL_23:
  if ( !unk_F3FFFCD )
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v24 = *(_QWORD *)&v47;
  if ( *(_QWORD *)&v47 )
  {
    v25 = **(_QWORD **)&v47;
    v26 = WORD4(v47);
    v27 = *(unsigned __int16 *)(**(_QWORD **)&v47 + 302LL);
    if ( *(_WORD *)(**(_QWORD **)&v47 + 302LL) )
    {
      v28 = (_DWORD *)(*(_QWORD *)(v25 + 176) + 8LL);
      while ( *((_QWORD *)v28 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v27;
        v28 += 4;
        if ( !v27 )
          goto LABEL_30;
      }
      v29 = v25 + 16LL * (*v28 + 2) + 312;
    }
    else
    {
LABEL_30:
      v29 = sub_6408234(*(_QWORD *)&v47, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    a0 = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))v29)(v24, v26, *(_QWORD *)(v29 + 8));
  }
  if ( !v4 )
  {
    a0 = sub_63CF120(a0, a1);
    goto LABEL_48;
  }
  v30 = *(_QWORD *)(v4 + 72);
  if ( !v30 )
  {
LABEL_48:
    Instance = (void *)sub_63CF120(a0, a1);
    goto LABEL_49;
  }
  (*(void (__fastcall **)(_QWORD, _QWORD, long double))(v30 + 24))(*(_QWORD *)(v30 + 64), *(_QWORD *)(v30 + 40), v13);
  v31 = byte_F3FFFCF[0];
  *(_DWORD *)v2 = -2;
  if ( !v31 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v32 = *(__int64 **)(v2 + 8);
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
          goto LABEL_42;
      }
      v36 = v33 + 16LL * (*v35 + 2) + 312;
    }
    else
    {
LABEL_42:
      v36 = sub_6408234(v32, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v36)(v32, *(_QWORD *)(v36 + 8));
  }
}

