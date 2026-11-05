// Campus.Live.Live3DPresenter.<LoadTimelineSceneAsync>d__44$$MoveNext @ 0x84f8254
void __fastcall Campus_Live_Live3DPresenter__LoadTimelineSceneAsync_d__44__MoveNext(__int64 a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v6; // x19
  int v7; // w8
  __int64 v8; // x20
  __int128 v9; // q0
  __int128 v10; // q0
  __int64 v11; // x8
  __int128 v12; // q0
  void *Instance; // x0
  __int64 v14; // x1
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  __int64 v19; // x9
  __int64 v20; // x0
  __int64 *v21; // x21
  unsigned int v22; // w22
  __int64 v23; // x0
  __int64 v24; // x1
  __int64 v25; // x0
  __int64 v26; // x8
  __int64 v27; // x9
  int *v28; // x10
  __int64 v29; // x0
  __int64 v30; // x1
  __int128 v31; // q0
  __int64 v32; // x8
  __int64 v33; // x1
  void *v34; // x0
  void *RootObjects; // x1
  void *v36; // x3
  int v37; // w2
  int v38; // w3
  int v39; // w4
  void *v40; // x5
  __int64 v41; // x20
  __int64 v42; // x1
  __int64 v43; // x21
  __int64 v44; // x20
  __int64 v45; // x8
  unsigned int v46; // w21
  __int64 v47; // x9
  int *v48; // x10
  __int64 v49; // x0
  int v50; // w2
  int v51; // w3
  int v52; // w4
  void *v53; // x5
  __int64 v54; // x20
  __int64 v55; // x8
  unsigned int v56; // w21
  __int64 v57; // x9
  _DWORD *v58; // x10
  __int64 v59; // x0
  __int64 v60; // x20
  __int64 v61; // x1
  int v62; // w2
  int v63; // w3
  int v64; // w4
  void *v65; // x5
  __int64 v66; // x20
  __int64 v67; // x8
  unsigned int v68; // w21
  __int64 v69; // x9
  int *v70; // x10
  __int64 v71; // x0
  int v72; // w2
  int v73; // w3
  int v74; // w4
  void *v75; // x5
  __int64 v76; // x20
  __int64 v77; // x8
  unsigned int v78; // w21
  __int64 v79; // x9
  _DWORD *v80; // x10
  __int64 v81; // x0
  int v82; // w8
  __int64 *v83; // x19
  __int64 v84; // x8
  __int64 v85; // x9
  _DWORD *v86; // x10
  __int64 v87; // x0
  __int128 v88; // q0
  __int128 v89; // q0
  void *v90; // x0
  int v91; // w1
  _QWORD **v92; // x20
  __int64 v93; // x0
  int v94; // w21
  _QWORD *v95; // x20
  _QWORD *exception; // x0
  __int128 v97; // [xsp+0h] [xbp+0h] BYREF
  __int64 v98; // [xsp+10h] [xbp+10h]
  __int64 v99; // [xsp+20h] [xbp+20h]
  int v100; // [xsp+28h] [xbp+28h]
  __int128 v101; // [xsp+30h] [xbp+30h] BYREF
  __int128 v102; // [xsp+40h] [xbp+40h]
  __int64 v103; // [xsp+50h] [xbp+50h]
  __int128 v104; // [xsp+60h] [xbp+60h] BYREF
  __int64 v105; // [xsp+70h] [xbp+70h]

  v6 = a0;
  if ( (unk_F413054 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_AssetBundleSceneLoader___Live3DPresenter__LoadTimelineSceneAsync_d__44___);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__Live3DPresenter__LoadTimelineSceneAsync_d__44___);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AssetBundleSceneLoader__GetResult__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AssetBundleSceneLoader__get_IsCompleted__);
    sub_63CEE78(&Method_Qua_Utility_Singleton_LiveResourceManager__get_Instance__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_AssetBundleSceneLoader__GetAwaiter__);
    a0 = sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F413054 = 1;
  }
  v104 = 0u;
  v105 = 0;
  v102 = 0u;
  v7 = *(_DWORD *)v6;
  v8 = *(_QWORD *)(v6 + 40);
  v103 = 0;
  v101 = 0u;
  v100 = 0;
  if ( !v7 )
  {
    v11 = *(_QWORD *)(v6 + 64);
    v12 = *(_OWORD *)(v6 + 48);
    *(_QWORD *)(v6 + 56) = 0;
    *(_QWORD *)(v6 + 64) = 0;
    *(_QWORD *)(v6 + 48) = 0;
    v105 = v11;
    v104 = v12;
    *(_DWORD *)v6 = -1;
    goto LABEL_13;
  }
  if ( v7 == 1 )
  {
    v10 = *(_OWORD *)(v6 + 72);
    *(_QWORD *)(v6 + 72) = 0;
    *(_QWORD *)(v6 + 80) = 0;
    *(_DWORD *)v6 = -1;
    v101 = v10;
LABEL_45:
    if ( !unk_F3FFFCD )
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
      unk_F3FFFCD = 1;
    }
    v54 = v101;
    if ( (_QWORD)v101 )
    {
      v55 = *(_QWORD *)v101;
      v56 = WORD4(v101);
      v57 = *(unsigned __int16 *)(*(_QWORD *)v101 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v101 + 302LL) )
      {
        v58 = (_DWORD *)(*(_QWORD *)(v55 + 176) + 8LL);
        while ( *((_QWORD *)v58 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
        {
          --v57;
          v58 += 4;
          if ( !v57 )
            goto LABEL_52;
        }
        v59 = v55 + 16LL * (*v58 + 2) + 312;
      }
      else
      {
LABEL_52:
        v59 = sub_6408234(v101, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
      }
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v59)(v54, v56, *(_QWORD *)(v59 + 8));
    }
    v60 = *(_QWORD *)(v6 + 32);
    if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
      sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
    *(_QWORD *)&v97 = Cysharp_Threading_Tasks_UniTask__Yield_2(8, v60, 0, nullptr);
    *((_QWORD *)&v97 + 1) = v61;
    sub_63CEE24(&v97, 0, v62, v63, v64, v65);
    v101 = v97;
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
    v66 = v101;
    if ( (_QWORD)v101 )
    {
      v67 = *(_QWORD *)v101;
      v68 = WORD4(v101);
      v69 = *(unsigned __int16 *)(*(_QWORD *)v101 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v101 + 302LL) )
      {
        v70 = (int *)(*(_QWORD *)(v67 + 176) + 8LL);
        while ( *((_QWORD *)v70 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
        {
          --v69;
          v70 += 4;
          if ( !v69 )
            goto LABEL_68;
        }
        v71 = v67 + 16LL * *v70 + 312;
      }
      else
      {
LABEL_68:
        v71 = sub_6408234(v101, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
      }
      if ( !(*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v71)(v66, v68, *(_QWORD *)(v71 + 8)) )
      {
        v88 = v101;
        *(_DWORD *)v6 = 2;
        *(_OWORD *)(v6 + 72) = v88;
        sub_63CEE24((void *)(v6 + 72), 0, v72, v73, v74, v75);
        ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8505DF0)(
          v6 + 8,
          &v101,
          v6,
          Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__Live3DPresenter__LoadTimelineSceneAsync_d__44___);
        return;
      }
    }
    goto LABEL_71;
  }
  if ( v7 != 2 )
  {
    Instance = Qua_Utility_Singleton_object___get_Instance(Method_Qua_Utility_Singleton_LiveResourceManager__get_Instance__);
    if ( !Instance )
      goto LABEL_96;
    Campus_Live_LiveResourceManager__LoadSceneAsync(
      Instance,
      *(void **)(v6 + 24),
      *(void **)(v6 + 24),
      *(_QWORD *)(v6 + 32),
      nullptr);
    v19 = v98;
    v98 = 0;
    v102 = v97;
    v103 = v19;
    v20 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_AssetBundleSceneLoader__GetAwaiter__ + 32LL);
    v97 = 0u;
    if ( (*(_BYTE *)(v20 + 309) & 1) == 0 )
      sub_6407F00(v20);
    v97 = v102;
    v98 = v103;
    sub_63CEE24(&v97, 0, v15, v16, v17, v18);
    v104 = v97;
    v105 = v98;
    a0 = sub_65115C4(&v104, Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AssetBundleSceneLoader__get_IsCompleted__);
    if ( (a0 & 1) == 0 )
    {
      v31 = v104;
      v32 = v105;
      *(_DWORD *)v6 = 0;
      *(_OWORD *)(v6 + 48) = v31;
      *(_QWORD *)(v6 + 64) = v32;
      sub_63CEE24((void *)(v6 + 48), 0, v2, v3, v4, v5);
      ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8505CE4)(
        v6 + 8,
        &v104,
        v6,
        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_AssetBundleSceneLoader___Live3DPresenter__LoadTimelineSceneAsync_d__44___);
      return;
    }
LABEL_13:
    v21 = (__int64 *)v104;
    if ( (_QWORD)v104 )
    {
      v22 = (unsigned __int16)v105;
      v23 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AssetBundleSceneLoader__GetResult__ + 32LL);
      if ( (*(_WORD *)(v23 + 309) & 1) == 0 )
        sub_6407F00(v23);
      v24 = *(_QWORD *)(*(_QWORD *)(v23 + 192) + 40LL);
      if ( (*(_WORD *)(v24 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(*(_QWORD *)(v23 + 192) + 40LL));
        v24 = v25;
      }
      v26 = *v21;
      v27 = *(unsigned __int16 *)(*v21 + 302);
      if ( *(_WORD *)(*v21 + 302) )
      {
        v28 = (int *)(*(_QWORD *)(v26 + 176) + 8LL);
        while ( *((_QWORD *)v28 - 1) != v24 )
        {
          --v27;
          v28 += 4;
          if ( !v27 )
            goto LABEL_22;
        }
        v29 = v26 + 16LL * *v28 + 312;
      }
      else
      {
LABEL_22:
        v29 = sub_6408234(v21, v24, 0);
      }
      a0 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v29)(v21, v22, *(_QWORD *)(v29 + 8));
      v30 = a0;
    }
    else
    {
      v30 = *((_QWORD *)&v104 + 1);
    }
    if ( v8 )
    {
      *(_QWORD *)(v8 + 104) = v30;
      sub_63CEE24((void *)(v8 + 104), v30, v2, v3, v4, v5);
      v34 = *(void **)(v8 + 104);
      if ( v34 )
      {
        RootObjects = Campus_Common_AssetBundleSceneLoader__get_RootObjects(v34, nullptr);
        v41 = Campus_Live_Live3DPresenter__SetTimelineObjectsAsync((void *)v8, RootObjects, *(_QWORD *)(v6 + 32), v36);
        v43 = v42;
        if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
          sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
        *(_QWORD *)&v97 = v41;
        *((_QWORD *)&v97 + 1) = v43;
        sub_63CEE24(&v97, 0, v37, v38, v39, v40);
        v101 = v97;
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
        v44 = v101;
        if ( (_QWORD)v101 )
        {
          v45 = *(_QWORD *)v101;
          v46 = WORD4(v101);
          v47 = *(unsigned __int16 *)(*(_QWORD *)v101 + 302LL);
          if ( *(_WORD *)(*(_QWORD *)v101 + 302LL) )
          {
            v48 = (int *)(*(_QWORD *)(v45 + 176) + 8LL);
            while ( *((_QWORD *)v48 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
            {
              --v47;
              v48 += 4;
              if ( !v47 )
                goto LABEL_42;
            }
            v49 = v45 + 16LL * *v48 + 312;
          }
          else
          {
LABEL_42:
            v49 = sub_6408234(v101, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 0);
          }
          if ( !(*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v49)(v44, v46, *(_QWORD *)(v49 + 8)) )
          {
            v89 = v101;
            *(_DWORD *)v6 = 1;
            *(_OWORD *)(v6 + 72) = v89;
            sub_63CEE24((void *)(v6 + 72), 0, v50, v51, v52, v53);
            ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8505DF0)(
              v6 + 8,
              &v101,
              v6,
              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__Live3DPresenter__LoadTimelineSceneAsync_d__44___);
            return;
          }
        }
        goto LABEL_45;
      }
    }
    else
    {
      v34 = (void *)sub_63CF120(a0, v30);
    }
    Instance = (void *)sub_63CF120(v34, v33);
LABEL_96:
    v90 = (void *)sub_63CF120(Instance, v14);
    if ( v91 != 1 )
      sub_64BD8DC(v90);
    v92 = (_QWORD **)__cxa_begin_catch(v90);
    v93 = sub_63CEE8C(&System_Exception_TypeInfo);
    if ( (sub_63CF528(v93, **v92) & 1) == 0 )
    {
      exception = __cxa_allocate_exception(8u);
      *exception = *v92;
      __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
    }
    v94 = v100;
    v95 = *v92;
    *(&v99 + v100) = (__int64)v95;
    v100 = v94 + 1;
    __cxa_end_catch();
    *(_DWORD *)v6 = -2;
    sub_64DD2CC(v6 + 8, v95, 0);
    v100 = v94;
    return;
  }
  v9 = *(_OWORD *)(v6 + 72);
  *(_QWORD *)(v6 + 72) = 0;
  *(_QWORD *)(v6 + 80) = 0;
  *(_DWORD *)v6 = -1;
  v101 = v9;
LABEL_71:
  if ( !unk_F3FFFCD )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
    unk_F3FFFCD = 1;
  }
  v76 = v101;
  if ( (_QWORD)v101 )
  {
    v77 = *(_QWORD *)v101;
    v78 = WORD4(v101);
    v79 = *(unsigned __int16 *)(*(_QWORD *)v101 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v101 + 302LL) )
    {
      v80 = (_DWORD *)(*(_QWORD *)(v77 + 176) + 8LL);
      while ( *((_QWORD *)v80 - 1) != Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo )
      {
        --v79;
        v80 += 4;
        if ( !v79 )
          goto LABEL_78;
      }
      v81 = v77 + 16LL * (*v80 + 2) + 312;
    }
    else
    {
LABEL_78:
      v81 = sub_6408234(v101, Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v81)(v76, v78, *(_QWORD *)(v81 + 8));
  }
  v82 = byte_F3FFFCF[0];
  *(_DWORD *)v6 = -2;
  if ( !v82 )
  {
    sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
    byte_F3FFFCF[0] = 1;
  }
  v83 = *(__int64 **)(v6 + 8);
  if ( v83 )
  {
    v84 = *v83;
    v85 = *(unsigned __int16 *)(*v83 + 302);
    if ( *(_WORD *)(*v83 + 302) )
    {
      v86 = (_DWORD *)(*(_QWORD *)(v84 + 176) + 8LL);
      while ( *((_QWORD *)v86 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
      {
        --v85;
        v86 += 4;
        if ( !v85 )
          goto LABEL_88;
      }
      v87 = v84 + 16LL * (*v86 + 2) + 312;
    }
    else
    {
LABEL_88:
      v87 = sub_6408234(v83, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v87)(v83, *(_QWORD *)(v87 + 8));
  }
}

