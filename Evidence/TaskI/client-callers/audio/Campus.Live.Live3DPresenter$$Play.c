// 0x84f4844 @ 0x84f4844
void __fastcall Campus_Live_Live3DPresenter__Play(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x1
  void *v5; // x0
  __int64 v6; // x8
  void *v7; // x1
  __int64 updated; // x0
  void *v9; // x1
  void *v10; // x3
  void *v11; // x2
  __int64 refreshed; // x0
  void *v13; // x1
  __int64 Ct; // x20
  __int64 v15; // x20
  void *v16; // x1
  void *v17; // x21
  void *v18; // x22
  __int64 v19; // x0
  void *v20; // x1
  void *v21; // x0
  void *v22; // x1

  if ( (unk_F413032 & 1) == 0 )
  {
    sub_63CEE78(&System_Action_TypeInfo);
    sub_63CEE78(&Method_Campus_Live_Live3DPresenter_ResetActorModel__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
    unk_F413032 = 1;
  }
  v3 = *((void **)a0 + 20);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
  {
    v5 = *((void **)a0 + 20);
    if ( !v5 )
    {
LABEL_15:
      v21 = (void *)sub_63CF120(v5, v4);
      Campus_Live_Live3DPresenter__SetupFocusPanoramaCamerasWithHeightCorrection(v21, v22);
      return;
    }
    (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)v5 + 1320LL))(
      v5,
      **(_QWORD **)(unk_F43F500 + 184LL),
      *(_QWORD *)(*(_QWORD *)v5 + 1328LL));
  }
  Campus_Live_Live3DPresenter__SetupFocusPanoramaCamerasWithHeightCorrection(a0, v4);
  v6 = *((_QWORD *)a0 + 8);
  if ( !v6 )
    goto LABEL_15;
  v5 = *(void **)(v6 + 32);
  if ( !v5 )
    goto LABEL_15;
  UnityEngine_Playables_PlayableDirector__Play_3(v5, nullptr);
  updated = Campus_Live_Live3DPresenter__InvalidateFocusPanoramaCameraStateBeforeLateUpdateAsync(a0, v7);
  Qua_Extensions_UniTaskExtension__Run(updated, v9);
  Campus_Live_Live3DPresenter__SwitchNextCamera_1(a0, *((_DWORD *)a0 + 36) + 1, 1, v10);
  if ( *((_BYTE *)a0 + 148) )
  {
    refreshed = Campus_Live_Live3DPresenter__RefreshPanoramaCameraOverrideAfterFrameAsync(a0, 1, v11);
    Cysharp_Threading_Tasks_UniTaskExtensions__Forget(refreshed, v13);
  }
  Ct = Campus_Common_Extensions_ComponentExtensions__GetCt(a0, nullptr);
  if ( !*(_DWORD *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 228LL) )
    sub_63CEFF4(Cysharp_Threading_Tasks_UniTask_TypeInfo);
  v15 = Cysharp_Threading_Tasks_UniTask__DelayFrame(0, 8, Ct, 0, nullptr);
  v17 = v16;
  v18 = (void *)sub_63CF110(System_Action_TypeInfo);
  System_Action___ctor(v18, a0, Method_Campus_Live_Live3DPresenter_ResetActorModel__, nullptr);
  v19 = Cysharp_Threading_Tasks_UniTaskExtensions__ContinueWith(v15, v17, v18);
  Qua_Extensions_UniTaskExtension__Run(v19, v20);
}

