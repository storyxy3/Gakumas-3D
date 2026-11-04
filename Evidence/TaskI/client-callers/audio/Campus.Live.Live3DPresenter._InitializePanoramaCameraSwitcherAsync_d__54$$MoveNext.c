// 0x84f6310 @ 0x84f6310
void __fastcall Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54__MoveNext(
        __int64 a0,
        void *a1)
{
  __int64 v2; // x19
  int v3; // w8
  __int64 v4; // x20
  void *Instance; // x0
  __int64 v6; // x1
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5
  __int64 v11; // x21
  __int64 v12; // x1
  __int64 v13; // x22
  __int128 v14; // kr00_16
  __int128 v15; // q0
  __int64 v16; // x8
  __int64 v17; // x9
  int *v18; // x10
  __int64 v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  __int64 v24; // x21
  __int64 v25; // x8
  unsigned int v26; // w22
  __int64 v27; // x9
  _DWORD *v28; // x10
  __int64 v29; // x0
  __int64 v30; // x8
  void *v31; // x21
  void *v32; // x22
  void *v33; // x0
  __int64 v34; // x0
  __int64 v35; // x1
  __int64 v36; // x8
  void *v37; // x21
  __int64 v38; // x0
  __int64 v39; // x8
  void *v40; // x22
  void *v41; // x23
  __int64 v42; // x0
  int v43; // w2
  int v44; // w3
  int v45; // w4
  void *v46; // x5
  void *v47; // x0
  __int64 v48; // x0
  __int64 v49; // x1
  __int64 v50; // x8
  void *v51; // x21
  void *v52; // x22
  void *v53; // x0
  __int64 v54; // x0
  __int64 v55; // x1
  __int64 v56; // x8
  __int64 v57; // x0
  void *v58; // x21
  __int64 v59; // x8
  void *v60; // x22
  void *v61; // x23
  __int64 v62; // x0
  int v63; // w2
  int v64; // w3
  int v65; // w4
  void *v66; // x5
  void *v67; // x0
  int v68; // w8
  __int64 *v69; // x19
  __int64 v70; // x8
  __int64 v71; // x9
  _DWORD *v72; // x10
  __int64 v73; // x0
  __int128 v74; // q0
  void *v75; // x0
  int v76; // w1
  _QWORD **v77; // x20
  __int64 v78; // x0
  int v79; // w21
  _QWORD *v80; // x20
  _QWORD *exception; // x0
  __int64 v82; // [xsp+0h] [xbp+0h]
  int v83; // [xsp+8h] [xbp+8h]
  __int128 v84; // [xsp+10h] [xbp+10h] BYREF
  __int128 v85; // [xsp+20h] [xbp+20h] BYREF

  v2 = a0;
  if ( (unk_F41304E & 1) == 0 )
  {
    sub_63CEE78(&System_Action_ValueTuple_int__bool___TypeInfo);
    sub_63CEE78(&System_Action_ForcedCameraChangedInfo__TypeInfo);
    sub_63CEE78(&System_Action_CurrentActorSignalData__TypeInfo);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54___);
    sub_63CEE78(&Method_UniRx_DisposableExtensions_AddTo_IDisposable____1);
    sub_63CEE78(&Method_Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_b__54_0__);
    sub_63CEE78(&Method_Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_b__54_2__);
    sub_63CEE78(&Method_UniRx_ObservableExtensions_Subscribe_CurrentActorSignalData___);
    sub_63CEE78(&Method_UniRx_ObservableExtensions_Subscribe_ForcedCameraChangedInfo___);
    sub_63CEE78(&Method_UniRx_ObservableExtensions_Subscribe_ValueTuple_int__bool____);
    sub_63CEE78(&Method_Qua_Utility_Singleton_LivePanoramaCameraManager__get_Instance__);
    sub_63CEE78(&Method_Campus_Live_Live3DPresenter___c__InitializePanoramaCameraSwitcherAsync_b__54_1__);
    sub_63CEE78(&Method_Campus_Live_Live3DPresenter___c__InitializePanoramaCameraSwitcherAsync_b__54_3__);
    sub_63CEE78(&Campus_Live_Live3DPresenter___c_TypeInfo);
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F41304E = 1;
  }
  v3 = *(_DWORD *)v2;
  v4 = *(_QWORD *)(v2 + 24);
  v84 = 0u;
  v83 = 0;
  if ( !v3 )
  {
    v15 = *(_OWORD *)(v2 + 40);
    *(_QWORD *)(v2 + 40) = 0;
    *(_QWORD *)(v2 + 48) = 0;
    *(_DWORD *)v2 = -1;
    v84 = v15;
    goto LABEL_25;
  }
  if ( !v4 )
  {
LABEL_70:
    Instance = (void *)sub_63CF120(a0, a1);
    goto LABEL_71;
  }
  if ( !*(_BYTE *)(v4 + 148) )
    goto LABEL_53;
  Instance = Qua_Utility_Singleton_object___get_Instance(Method_Qua_Utility_Singleton_LivePanoramaCameraManager__get_Instance__);
  if ( !Instance )
  {
LABEL_71:
    v75 = (void *)sub_63CF120(Instance, v6);
    if ( v76 != 1 )
      sub_64BD8DC(v75);
    v77 = (_QWORD **)__cxa_begin_catch(v75);
    v78 = sub_63CEE8C(&System_Exception_TypeInfo);
    if ( (sub_63CF528(v78, **v77) & 1) == 0 )
    {
      exception = __cxa_allocate_exception(8u);
      *exception = *v77;
      __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
    }
    v79 = v83;
    v80 = *v77;
    *(&v82 + v83) = (__int64)v80;
    v83 = v79 + 1;
    __cxa_end_catch();
    *(_DWORD *)v2 = -2;
    sub_64DD2CC(v2 + 8, v80, 0);
    v83 = v79;
    return;
  }
  v11 = Campus_Live_LivePanoramaCameraManager__InitializeAsync(
          Instance,
          *(void **)(v4 + 64),
          *(_QWORD *)(v2 + 32),
          nullptr);
  v13 = v12;
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  *(_QWORD *)&v85 = v11;
  *((_QWORD *)&v85 + 1) = v13;
  sub_63CEE24(&v85, 0, v7, v8, v9, v10);
  v14 = v85;
  v84 = v85;
  if ( !unk_F3FFFCB )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F3FFFCB = 1;
  }
  a0 = Cysharp_Threading_Tasks_UniTask_TypeInfo;
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  if ( unk_F3FFFCC )
  {
    if ( !(_QWORD)v14 )
      goto LABEL_25;
  }
  else
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCC = 1;
    if ( !(_QWORD)v14 )
      goto LABEL_25;
  }
  v16 = *(_QWORD *)v14;
  v17 = *(unsigned __int16 *)(*(_QWORD *)v14 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v14 + 302LL) )
  {
    v18 = (int *)(*(_QWORD *)(v16 + 176) + 8LL);
    while ( *((_QWORD *)v18 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
    {
      --v17;
      v18 += 4;
      if ( !v17 )
        goto LABEL_22;
    }
    v19 = v16 + 16LL * *v18 + 312;
  }
  else
  {
LABEL_22:
    v19 = sub_6408234(v14, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
  }
  a0 = (*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v19)(v14, DWORD2(v14), *(_QWORD *)(v19 + 8));
  if ( !(_DWORD)a0 )
  {
    v74 = v84;
    *(_DWORD *)v2 = 0;
    *(_OWORD *)(v2 + 40) = v74;
    sub_63CEE24((void *)(v2 + 40), 0, v20, v21, v22, v23);
    sub_8505590(
      v2 + 8,
      &v84,
      v2,
      Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54___);
    return;
  }
LABEL_25:
  if ( !unk_F3FFFCD )
  {
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v24 = v84;
  if ( (_QWORD)v84 )
  {
    v25 = *(_QWORD *)v84;
    v26 = WORD4(v84);
    v27 = *(unsigned __int16 *)(*(_QWORD *)v84 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v84 + 302LL) )
    {
      v28 = (_DWORD *)(*(_QWORD *)(v25 + 176) + 8LL);
      while ( *((_QWORD *)v28 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v27;
        v28 += 4;
        if ( !v27 )
          goto LABEL_32;
      }
      v29 = v25 + 16LL * (*v28 + 2) + 312;
    }
    else
    {
LABEL_32:
      v29 = sub_6408234(v84, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    a0 = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))v29)(v24, v26, *(_QWORD *)(v29 + 8));
  }
  if ( !v4 )
  {
    a0 = sub_63CF120(a0, a1);
    goto LABEL_66;
  }
  v30 = *(_QWORD *)(v4 + 64);
  if ( !v30 )
  {
LABEL_66:
    v34 = sub_63CF120(a0, a1);
    goto LABEL_67;
  }
  v31 = *(void **)(v30 + 120);
  v32 = (void *)sub_63CF110(System_Action_CurrentActorSignalData__TypeInfo);
  System_Action_CurrentActorSignalData____ctor(
    v32,
    (void *)v4,
    Method_Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_b__54_0__,
    nullptr);
  v33 = UniRx_ObservableExtensions__Subscribe_CurrentActorSignalData_(
          v31,
          v32,
          Method_UniRx_ObservableExtensions_Subscribe_CurrentActorSignalData___);
  v34 = (__int64)UniRx_DisposableExtensions__AddTo_object__2(
                   v33,
                   (void *)v4,
                   Method_UniRx_DisposableExtensions_AddTo_IDisposable____1);
  v36 = *(_QWORD *)(v4 + 64);
  if ( !v36 )
  {
LABEL_67:
    v48 = sub_63CF120(v34, v35);
LABEL_68:
    v54 = sub_63CF120(v48, v49);
    goto LABEL_69;
  }
  v37 = *(void **)(v36 + 160);
  v38 = Campus_Live_Live3DPresenter___c_TypeInfo;
  if ( !*(_DWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Live_Live3DPresenter___c_TypeInfo);
    v38 = Campus_Live_Live3DPresenter___c_TypeInfo;
  }
  v39 = *(_QWORD *)(v38 + 184);
  v40 = *(void **)(v39 + 96);
  if ( !v40 )
  {
    if ( !*(_DWORD *)(v38 + 228) )
    {
      sub_63CEFF4(v38);
      v39 = *(_QWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 184LL);
    }
    v41 = *(void **)v39;
    v40 = (void *)sub_63CF110(System_Action_ValueTuple_int__bool___TypeInfo);
    System_Action_ValueTuple_int__bool_____ctor(
      v40,
      v41,
      Method_Campus_Live_Live3DPresenter___c__InitializePanoramaCameraSwitcherAsync_b__54_1__,
      nullptr);
    v42 = *(_QWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 184LL);
    *(_QWORD *)(v42 + 96) = v40;
    sub_63CEE24((void *)(v42 + 96), (int)v40, v43, v44, v45, v46);
  }
  v47 = UniRx_ObservableExtensions__Subscribe_ValueTuple_int__bool__(
          v37,
          v40,
          Method_UniRx_ObservableExtensions_Subscribe_ValueTuple_int__bool____);
  v48 = (__int64)UniRx_DisposableExtensions__AddTo_object__2(
                   v47,
                   (void *)v4,
                   Method_UniRx_DisposableExtensions_AddTo_IDisposable____1);
  v50 = *(_QWORD *)(v4 + 64);
  if ( !v50 )
    goto LABEL_68;
  v51 = *(void **)(v50 + 72);
  v52 = (void *)sub_63CF110(System_Action_ForcedCameraChangedInfo__TypeInfo);
  System_Action_ForcedCameraChangedInfo____ctor(
    v52,
    (void *)v4,
    Method_Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_b__54_2__,
    nullptr);
  v53 = UniRx_ObservableExtensions__Subscribe_ForcedCameraChangedInfo_(
          v51,
          v52,
          Method_UniRx_ObservableExtensions_Subscribe_ForcedCameraChangedInfo___);
  v54 = (__int64)UniRx_DisposableExtensions__AddTo_object__2(
                   v53,
                   (void *)v4,
                   Method_UniRx_DisposableExtensions_AddTo_IDisposable____1);
  v56 = *(_QWORD *)(v4 + 64);
  if ( !v56 )
  {
LABEL_69:
    a0 = sub_63CF120(v54, v55);
    goto LABEL_70;
  }
  v57 = Campus_Live_Live3DPresenter___c_TypeInfo;
  v58 = *(void **)(v56 + 168);
  if ( !*(_DWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Live_Live3DPresenter___c_TypeInfo);
    v57 = Campus_Live_Live3DPresenter___c_TypeInfo;
  }
  v59 = *(_QWORD *)(v57 + 184);
  v60 = *(void **)(v59 + 104);
  if ( !v60 )
  {
    if ( !*(_DWORD *)(v57 + 228) )
    {
      sub_63CEFF4(v57);
      v59 = *(_QWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 184LL);
    }
    v61 = *(void **)v59;
    v60 = (void *)sub_63CF110(System_Action_ValueTuple_int__bool___TypeInfo);
    System_Action_ValueTuple_int__bool_____ctor(
      v60,
      v61,
      Method_Campus_Live_Live3DPresenter___c__InitializePanoramaCameraSwitcherAsync_b__54_3__,
      nullptr);
    v62 = *(_QWORD *)(Campus_Live_Live3DPresenter___c_TypeInfo + 184LL);
    *(_QWORD *)(v62 + 104) = v60;
    sub_63CEE24((void *)(v62 + 104), (int)v60, v63, v64, v65, v66);
  }
  v67 = UniRx_ObservableExtensions__Subscribe_ValueTuple_int__bool__(
          v58,
          v60,
          Method_UniRx_ObservableExtensions_Subscribe_ValueTuple_int__bool____);
  UniRx_DisposableExtensions__AddTo_object__2(v67, (void *)v4, Method_UniRx_DisposableExtensions_AddTo_IDisposable____1);
LABEL_53:
  v68 = byte_F3FFFCF[0];
  *(_DWORD *)v2 = -2;
  if ( !v68 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v69 = *(__int64 **)(v2 + 8);
  if ( v69 )
  {
    v70 = *v69;
    v71 = *(unsigned __int16 *)(*v69 + 302);
    if ( *(_WORD *)(*v69 + 302) )
    {
      v72 = (_DWORD *)(*(_QWORD *)(v70 + 176) + 8LL);
      while ( *((_QWORD *)v72 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
      {
        --v71;
        v72 += 4;
        if ( !v71 )
          goto LABEL_60;
      }
      v73 = v70 + 16LL * (*v72 + 2) + 312;
    }
    else
    {
LABEL_60:
      v73 = sub_6408234(v69, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v73)(v69, *(_QWORD *)(v73 + 8));
  }
}

