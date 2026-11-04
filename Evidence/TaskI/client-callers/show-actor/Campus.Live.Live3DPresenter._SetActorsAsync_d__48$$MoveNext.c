// 0x84f8f10 @ 0x84f8f10
void __fastcall Campus_Live_Live3DPresenter__SetActorsAsync_d__48__MoveNext(__int64 a0, void *a1)
{
  int v3; // w8
  __int64 v4; // x26
  void *v5; // x20
  void *AssetName; // x0
  void *v7; // x1
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  __int64 v12; // x0
  __int64 v13; // x1
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  int v18; // w8
  __int64 v19; // x8
  __int128 v20; // q0
  __int64 v21; // x9
  int v22; // w10
  __int64 v23; // x8
  __int64 v24; // x1
  int v25; // w21
  void **v26; // x20
  __int64 v27; // x0
  __int64 v28; // x1
  void *v29; // x0
  __int64 v30; // x0
  __int64 v31; // x1
  int v32; // w2
  int v33; // w3
  int v34; // w4
  void *v35; // x5
  __int64 *v36; // x20
  __int64 v37; // x8
  __int64 v38; // x9
  int *v39; // x10
  __int64 v40; // x0
  __int64 v41; // x0
  __int64 v42; // x1
  __int64 v43; // x20
  __int64 v44; // x8
  __int64 v45; // x9
  _DWORD *v46; // x10
  __int64 v47; // x0
  void *v48; // x21
  void *Instance; // x20
  void *CharacterLookEffectorMaster; // x0
  __int64 v51; // x1
  int v52; // w2
  int v53; // w3
  int v54; // w4
  void *v55; // x5
  __int64 v56; // x9
  __int64 v57; // x0
  int v58; // w2
  int v59; // w3
  int v60; // w4
  void *v61; // x5
  __int64 *v62; // x20
  unsigned int v63; // w21
  __int64 v64; // x0
  __int64 v65; // x1
  __int64 v66; // x0
  __int64 v67; // x8
  __int64 v68; // x9
  int *v69; // x10
  __int64 v70; // x0
  void *v71; // x20
  void *v72; // x21
  __int64 v73; // x0
  __int64 v74; // x1
  void *v75; // x0
  __int64 v76; // x1
  void *v77; // x21
  void *v78; // x0
  __int64 v79; // x1
  int v80; // w8
  __int64 *v81; // x19
  __int64 v82; // x8
  __int64 v83; // x9
  _DWORD *v84; // x10
  __int64 v85; // x0
  __int128 v86; // q0
  __int64 v87; // x8
  void *v88; // x0
  int v89; // w1
  _QWORD **v90; // x20
  __int64 v91; // x0
  int v92; // w21
  _QWORD *v93; // x20
  _QWORD *exception; // x0
  __int128 v95; // [xsp+0h] [xbp+0h] BYREF
  __int64 v96; // [xsp+10h] [xbp+10h]
  __int64 v97; // [xsp+20h] [xbp+20h]
  int v98; // [xsp+28h] [xbp+28h]
  __int128 v99; // [xsp+30h] [xbp+30h]
  __int64 v100; // [xsp+40h] [xbp+40h]
  __int128 v101; // [xsp+50h] [xbp+50h] BYREF
  __int64 v102; // [xsp+60h] [xbp+60h]

  if ( (unk_F413056 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_CampusCustomLookAtEffector___Live3DPresenter__SetActorsAsync_d__48___);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_CampusCustomLookAtEffector__GetResult__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_CampusCustomLookAtEffector__get_IsCompleted__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__ICampusActorController___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__ICampusActorController__set_Item__);
    sub_63CEE78(&System_Collections_Generic_Dictionary_int__ICampusActorController__TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GameObject_AddComponent_PanoramaActorLookAtController___);
    sub_63CEE78(&UnityEngine_GameObject_TypeInfo);
    sub_63CEE78(&Campus_Common_ICampusActorDescriptor_TypeInfo);
    sub_63CEE78(&VL_IVLActorController_ICampusActorDescriptor__TypeInfo);
    sub_63CEE78(&Method_Qua_Utility_Singleton_LiveResourceManager__get_Instance__);
    sub_63CEE78(&Method_Qua_Utility_Singleton_LivePanoramaCameraManager__get_Instance__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_CampusCustomLookAtEffector__GetAwaiter__);
    sub_63CEE78(&StringLiteral_PanoramaActorLookAtController);
    unk_F413056 = 1;
  }
  v101 = 0u;
  v102 = 0;
  v3 = *(_DWORD *)a0;
  v4 = *(_QWORD *)(a0 + 24);
  v99 = 0u;
  v100 = 0;
  v98 = 0;
  if ( !v3 )
  {
    v19 = *(_QWORD *)(a0 + 80);
    v20 = *(_OWORD *)(a0 + 64);
    *(_QWORD *)(a0 + 72) = 0;
    *(_QWORD *)(a0 + 80) = 0;
    *(_QWORD *)(a0 + 64) = 0;
    v102 = v19;
    v101 = v20;
    *(_DWORD *)a0 = -1;
    goto LABEL_33;
  }
  v5 = (void *)sub_63CF110(System_Collections_Generic_Dictionary_int__ICampusActorController__TypeInfo);
  System_Collections_Generic_Dictionary_int__object____ctor_1(
    v5,
    5,
    Method_System_Collections_Generic_Dictionary_int__ICampusActorController___ctor__);
  if ( v4 )
  {
    *(_QWORD *)(v4 + 80) = v5;
    sub_63CEE24((void *)(v4 + 80), (int)v5, v8, v9, v10, v11);
    v18 = 0;
    for ( *(_DWORD *)(a0 + 48) = 0; ; *(_DWORD *)(a0 + 48) = v18 )
    {
      v21 = *(_QWORD *)(a0 + 32);
      if ( !v21 )
      {
        v73 = sub_63CF120(v12, v13);
LABEL_65:
        v78 = (void *)sub_63CF120(v73, v74);
LABEL_66:
        v75 = (void *)sub_63CF120(v78, v79);
LABEL_67:
        v29 = (void *)sub_63CF120(v75, v76);
LABEL_68:
        v27 = sub_63CF120(v29, v28);
LABEL_69:
        v12 = sub_63CF120(v27, v28);
LABEL_70:
        sub_63CF128(v12, v13, v14, v15);
LABEL_71:
        v30 = sub_63CF120(v41, v42);
LABEL_72:
        CharacterLookEffectorMaster = (void *)sub_63CF120(v30, v31);
LABEL_73:
        AssetName = (void *)sub_63CF120(CharacterLookEffectorMaster, v51);
        goto LABEL_74;
      }
      v22 = *(_DWORD *)(v21 + 24);
      if ( v18 >= v22 )
        break;
      if ( v18 >= (unsigned int)v22 )
        goto LABEL_70;
      v23 = v21 + 16LL * v18;
      v24 = *(_QWORD *)(v23 + 40);
      v25 = *(_DWORD *)(v23 + 32);
      *(_QWORD *)(a0 + 56) = v24;
      v26 = (void **)(a0 + 56);
      sub_63CEE24((void *)(a0 + 56), v24, v14, v15, v16, v17);
      if ( !v4 )
        goto LABEL_69;
      v29 = *(void **)(v4 + 80);
      if ( !v29 )
        goto LABEL_68;
      System_Collections_Generic_Dictionary_int__object___set_Item(
        v29,
        v25,
        *v26,
        Method_System_Collections_Generic_Dictionary_int__ICampusActorController__set_Item__);
      if ( *(_BYTE *)(v4 + 148) )
      {
        v36 = (__int64 *)*v26;
        if ( !v36 )
          goto LABEL_72;
        v37 = *v36;
        v38 = *(unsigned __int16 *)(*v36 + 302);
        if ( *(_WORD *)(*v36 + 302) )
        {
          v39 = (int *)(*(_QWORD *)(v37 + 176) + 8LL);
          while ( *((_QWORD *)v39 - 1) != VL_IVLActorController_ICampusActorDescriptor__TypeInfo )
          {
            --v38;
            v39 += 4;
            if ( !v38 )
              goto LABEL_19;
          }
          v40 = v37 + 16LL * *v39 + 312;
        }
        else
        {
LABEL_19:
          v40 = sub_6408234(v36, VL_IVLActorController_ICampusActorDescriptor__TypeInfo, 0);
        }
        v41 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v40)(v36, *(_QWORD *)(v40 + 8));
        v43 = v41;
        if ( !v41 )
          goto LABEL_71;
        v44 = *(_QWORD *)v41;
        v45 = *(unsigned __int16 *)(*(_QWORD *)v41 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v41 + 302LL) )
        {
          v46 = (_DWORD *)(*(_QWORD *)(v44 + 176) + 8LL);
          while ( *((_QWORD *)v46 - 1) != Campus_Common_ICampusActorDescriptor_TypeInfo )
          {
            --v45;
            v46 += 4;
            if ( !v45 )
              goto LABEL_26;
          }
          v47 = v44 + 16LL * (*v46 + 6) + 312;
        }
        else
        {
LABEL_26:
          v47 = sub_6408234(v41, Campus_Common_ICampusActorDescriptor_TypeInfo, 6);
        }
        v48 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))v47)(v43, *(_QWORD *)(v47 + 8));
        Instance = Qua_Utility_Singleton_object___get_Instance(Method_Qua_Utility_Singleton_LiveResourceManager__get_Instance__);
        CharacterLookEffectorMaster = Campus_Common_Master_MasterManager__get_CharacterLookEffectorMaster(nullptr);
        if ( !CharacterLookEffectorMaster )
          goto LABEL_73;
        AssetName = Campus_Common_Master_CharacterLookEffectorMaster__GetAssetName(
                      CharacterLookEffectorMaster,
                      v48,
                      2,
                      nullptr);
        v7 = AssetName;
        if ( !Instance )
          goto LABEL_74;
        Campus_Live_LiveResourceManager__LoadLookAtEffectorAsync(Instance, AssetName, *(_QWORD *)(a0 + 40), nullptr);
        v56 = v96;
        v96 = 0;
        v99 = v95;
        v100 = v56;
        v95 = 0u;
        v57 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_CampusCustomLookAtEffector__GetAwaiter__ + 32LL);
        if ( (*(_BYTE *)(v57 + 309) & 1) == 0 )
          sub_6407F00(v57);
        v95 = v99;
        v96 = v100;
        sub_63CEE24(&v95, 0, v52, v53, v54, v55);
        v101 = v95;
        v102 = v96;
        if ( (sub_65115C4(
                &v101,
                Method_Cysharp_Threading_Tasks_UniTask_Awaiter_CampusCustomLookAtEffector__get_IsCompleted__)
            & 1) == 0 )
        {
          v86 = v101;
          v87 = v102;
          *(_DWORD *)a0 = 0;
          *(_OWORD *)(a0 + 64) = v86;
          *(_QWORD *)(a0 + 80) = v87;
          sub_63CEE24((void *)(a0 + 64), 0, v58, v59, v60, v61);
          ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_8506008)(
            a0 + 8,
            &v101,
            a0,
            Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_CampusCustomLookAtEffector___Live3DPresenter__SetActorsAsync_d__48___);
          return;
        }
LABEL_33:
        v62 = (__int64 *)v101;
        if ( (_QWORD)v101 )
        {
          v63 = (unsigned __int16)v102;
          v64 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_CampusCustomLookAtEffector__GetResult__ + 32LL);
          if ( (*(_WORD *)(v64 + 309) & 1) == 0 )
            sub_6407F00(v64);
          v65 = *(_QWORD *)(*(_QWORD *)(v64 + 192) + 40LL);
          if ( (*(_WORD *)(v65 + 309) & 1) == 0 )
          {
            sub_6407F00(*(_QWORD *)(*(_QWORD *)(v64 + 192) + 40LL));
            v65 = v66;
          }
          v67 = *v62;
          v68 = *(unsigned __int16 *)(*v62 + 302);
          if ( *(_WORD *)(*v62 + 302) )
          {
            v69 = (int *)(*(_QWORD *)(v67 + 176) + 8LL);
            while ( *((_QWORD *)v69 - 1) != v65 )
            {
              --v68;
              v69 += 4;
              if ( !v68 )
                goto LABEL_42;
            }
            v70 = v67 + 16LL * *v69 + 312;
          }
          else
          {
LABEL_42:
            v70 = sub_6408234(v62, v65, 0);
          }
          v71 = (void *)(*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v70)(v62, v63, *(_QWORD *)(v70 + 8));
        }
        else
        {
          v71 = *((void **)&v101 + 1);
        }
        v72 = (void *)sub_63CF110(UnityEngine_GameObject_TypeInfo);
        UnityEngine_GameObject___ctor(v72, StringLiteral_PanoramaActorLookAtController, nullptr);
        if ( !v72 )
          goto LABEL_65;
        v75 = UnityEngine_GameObject__AddComponent_object_(
                v72,
                Method_UnityEngine_GameObject_AddComponent_PanoramaActorLookAtController___);
        v77 = v75;
        if ( !v75 )
          goto LABEL_67;
        Campus_Common_Panorama_PanoramaActorLookAtController__Initialize(v75, *(void **)(a0 + 56), v71, nullptr);
        v78 = Qua_Utility_Singleton_object___get_Instance(Method_Qua_Utility_Singleton_LivePanoramaCameraManager__get_Instance__);
        if ( !v78 )
          goto LABEL_66;
        Campus_Live_LivePanoramaCameraManager__AddPanoramaActor(v78, v77, nullptr);
        if ( !*(_DWORD *)(a0 + 48) )
          Campus_Live_LivePanoramaCameraManager__SetFocusTarget(*(void **)(a0 + 56), nullptr);
      }
      *(_QWORD *)(a0 + 56) = 0;
      sub_63CEE24((void *)(a0 + 56), 0, v32, v33, v34, v35);
      v18 = *(_DWORD *)(a0 + 48) + 1;
    }
    v80 = byte_F3FFFCF[0];
    *(_DWORD *)a0 = -2;
    if ( !v80 )
    {
      sub_63CEE78(&Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo);
      byte_F3FFFCF[0] = 1;
    }
    v81 = *(__int64 **)(a0 + 8);
    if ( v81 )
    {
      v82 = *v81;
      v83 = *(unsigned __int16 *)(*v81 + 302);
      if ( *(_WORD *)(*v81 + 302) )
      {
        v84 = (_DWORD *)(*(_QWORD *)(v82 + 176) + 8LL);
        while ( *((_QWORD *)v84 - 1) != Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo )
        {
          --v83;
          v84 += 4;
          if ( !v83 )
            goto LABEL_59;
        }
        v85 = v82 + 16LL * (*v84 + 2) + 312;
      }
      else
      {
LABEL_59:
        v85 = sub_6408234(v81, Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo, 2);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v85)(v81, *(_QWORD *)(v85 + 8));
    }
  }
  else
  {
LABEL_74:
    v88 = (void *)sub_63CF120(AssetName, v7);
    if ( v89 != 1 )
      sub_64BD8DC(v88);
    v90 = (_QWORD **)__cxa_begin_catch(v88);
    v91 = sub_63CEE8C(&System_Exception_TypeInfo);
    if ( (sub_63CF528(v91, **v90) & 1) == 0 )
    {
      exception = __cxa_allocate_exception(8u);
      *exception = *v90;
      __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
    }
    v92 = v98;
    v93 = *v90;
    *(&v97 + v98) = (__int64)v93;
    v98 = v92 + 1;
    __cxa_end_catch();
    *(_DWORD *)a0 = -2;
    sub_64DD2CC(a0 + 8, v93, 0);
    v98 = v92;
  }
}

