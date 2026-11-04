// Campus.Crowd.CrowdTimelineMixerBehaviour$$PrepareFrame @ 0xddcc550
void __fastcall Campus_Crowd_CrowdTimelineMixerBehaviour__PrepareFrame(void *a0, __int64 a1, __int64 a2, void *a3)
{
  void *v6; // x23
  int InputCount_Playable; // w0
  __int64 v8; // x21
  void *evaluationType; // x0
  void *v10; // x1
  double Time_Playable; // d0
  unsigned int i; // w24
  __int64 Input_Playable; // x25
  void *v14; // x1
  int v15; // w26
  int v16; // w0
  int v17; // w27
  unsigned int j; // w28
  __int64 v19; // x29
  void *v20; // x1
  void *v21; // x20
  void *v22; // x1
  _BYTE *Behaviour; // x29
  void *v24; // x2
  float InputWeight_Playable; // s0
  float v26; // s8
  __int64 v27; // x8
  void *v28; // x0
  __int64 v29; // x20
  void *v30; // x2
  double Time_ScriptPlayable_object; // d0
  void *v32; // x0
  __int64 v33; // x20
  void *v34; // x2
  double v35; // d0
  __int64 v36; // x8
  __int64 v37; // x8
  void *v38; // x0
  __int64 v39; // x8
  void *v40; // x0
  __int64 v41; // x8
  void *v42; // x0
  void *v43; // x0
  void *v44; // x0
  void *v45; // x1
  int v46; // [xsp+14h] [xbp+14h]
  __int64 v48; // [xsp+20h] [xbp+20h] BYREF
  void *v49; // [xsp+28h] [xbp+28h]
  void *v50; // [xsp+38h] [xbp+38h]

  v50 = (void *)a2;
  if ( (unk_F43BD3C & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputCount_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputWeight_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInput_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetTime_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetTime_ScriptPlayable_CrowdTimelineBehaviour____);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__GetBehaviour__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__op_Explicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo);
    unk_F43BD3C = 1;
  }
  v6 = v50;
  v48 = 0;
  v49 = nullptr;
  InputCount_Playable = UnityEngine_Playables_PlayableExtensions__GetInputCount_Playable_(a1, v50);
  v8 = *((_QWORD *)a0 + 2);
  v46 = InputCount_Playable;
  Time_Playable = UnityEngine_Playables_PlayableExtensions__GetTime_Playable_(a1, v6);
  if ( !v8 )
    goto LABEL_46;
  evaluationType = *(void **)(v8 + 64);
  if ( evaluationType )
    Campus_Crowd_CrowdAnimator__SetTime(evaluationType, Time_Playable, v10);
  if ( v46 < 1 )
  {
    v41 = *((_QWORD *)a0 + 2);
    if ( !v41 )
      goto LABEL_46;
    v42 = *(void **)(v41 + 64);
    if ( v42 )
      Campus_Crowd_CrowdAnimator__Pause(v42, v10);
    return;
  }
  for ( i = 0; i != v46; ++i )
  {
    Input_Playable = UnityEngine_Playables_PlayableExtensions__GetInput_Playable_(a1, (int)v50, (void *)i);
    v15 = (int)v14;
    v16 = UnityEngine_Playables_PlayableExtensions__GetInputCount_Playable_(Input_Playable, v14);
    if ( v16 >= 1 )
    {
      v17 = v16;
      for ( j = 0; v17 != j; ++j )
      {
        v19 = UnityEngine_Playables_PlayableExtensions__GetInput_Playable_(Input_Playable, v15, (void *)j);
        v21 = v20;
        if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo);
        v48 = UnityEngine_Playables_ScriptPlayable_object___op_Explicit(v19, v21);
        v49 = v22;
        Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                      (__int64)&v48,
                      Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__GetBehaviour__);
        InputWeight_Playable = UnityEngine_Playables_PlayableExtensions__GetInputWeight_Playable_(
                                 Input_Playable,
                                 v15,
                                 (void *)j);
        v26 = InputWeight_Playable;
        v27 = *((_QWORD *)a0 + 2);
        if ( i == 1 )
        {
          if ( !v27 )
            goto LABEL_46;
          v28 = *(void **)(v27 + 64);
          if ( v28 )
            Campus_Crowd_CrowdAnimator__SetOverrideAnimationWeight(v28, j, InputWeight_Playable, v24);
          if ( v26 <= 0.0 )
            continue;
          v29 = *((_QWORD *)a0 + 2);
          Time_ScriptPlayable_object = UnityEngine_Playables_PlayableExtensions__GetTime_ScriptPlayable_object__(
                                         v48,
                                         v49);
          if ( !v29 )
            goto LABEL_46;
          evaluationType = *(void **)(v29 + 64);
          if ( evaluationType )
            Campus_Crowd_CrowdAnimator__SetOverrideAnimationTime(evaluationType, j, Time_ScriptPlayable_object, v30);
        }
        else
        {
          if ( !v27 )
            goto LABEL_46;
          v32 = *(void **)(v27 + 64);
          if ( v32 )
            Campus_Crowd_CrowdAnimator__SetAnimationWeight(v32, j, InputWeight_Playable, v24);
          if ( v26 <= 0.0 )
            continue;
          v33 = *((_QWORD *)a0 + 2);
          v35 = UnityEngine_Playables_PlayableExtensions__GetTime_ScriptPlayable_object__(v48, v49);
          if ( !v33 )
            goto LABEL_46;
          evaluationType = *(void **)(v33 + 64);
          if ( evaluationType )
            Campus_Crowd_CrowdAnimator__SetAnimationTime(evaluationType, j, v35, v34);
        }
        if ( !Behaviour )
          goto LABEL_46;
        v36 = *((_QWORD *)a0 + 2);
        if ( !v36 )
          goto LABEL_46;
        *(_BYTE *)(v36 + 32) = Behaviour[40];
      }
    }
  }
  evaluationType = (void *)UnityEngine_Playables_FrameData__get_evaluationType((__int64)a3, nullptr);
  v37 = *((_QWORD *)a0 + 2);
  if ( (_DWORD)evaluationType )
  {
    if ( !v37 )
      goto LABEL_46;
    v38 = *(void **)(v37 + 64);
    if ( v38 )
    {
      evaluationType = (void *)Campus_Crowd_CrowdAnimator__IsPaused(v38, v10);
      if ( ((unsigned __int8)evaluationType & 1) != 0 )
      {
        v39 = *((_QWORD *)a0 + 2);
        if ( v39 )
        {
          v40 = *(void **)(v39 + 64);
          if ( v40 )
            Campus_Crowd_CrowdAnimator__Play(v40, v10);
          return;
        }
LABEL_46:
        v44 = (void *)sub_63CF120(evaluationType, v10);
        Campus_Crowd_CrowdTimelineMixerBehaviour___ctor(v44, v45);
      }
    }
  }
  else
  {
    if ( !v37 )
      goto LABEL_46;
    v43 = *(void **)(v37 + 64);
    if ( v43 )
      Campus_Crowd_CrowdAnimator__Pause(v43, v10);
  }
}

