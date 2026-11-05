// Campus.Timeline.CampusVolumeTimelineMixerBehaviour$$ProcessFrame @ 0xdd7e7b4
void __fastcall Campus_Timeline_CampusVolumeTimelineMixerBehaviour__ProcessFrame(
        void *a0,
        __int64 a1,
        __int64 a2,
        void *a3,
        void *a4)
{
  int InputCount_Playable; // w0
  int v8; // w21
  unsigned int i; // w22
  float InputWeight_Playable; // s8
  __int64 Input_Playable; // x23
  void *v12; // x1
  void *v13; // x24
  __int64 v14; // x1
  void *Behaviour; // x23
  void *v16; // x1
  bool v17; // w8
  void *v18; // x0
  float *v19; // x9
  double *v20; // x20
  double *v21; // x19
  float v22; // s8
  void *v23; // x1
  void *v24; // x1
  void *v25; // x1
  void *v26; // x0
  void *v27; // x1
  __int64 v28; // [xsp+0h] [xbp+0h] BYREF
  __int64 v29; // [xsp+8h] [xbp+8h]
  double *v30; // [xsp+10h] [xbp+10h] BYREF
  __int64 v31; // [xsp+18h] [xbp+18h] BYREF
  void *v32; // [xsp+20h] [xbp+20h] BYREF
  __int64 v33; // [xsp+28h] [xbp+28h] BYREF

  if ( (unk_F43BAD8 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputCount_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputWeight_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInput_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__GetBehaviour__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__op_Explicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo);
    sub_63CEE78(&Method_System_ValueTuple_CampusVolumeTimelineBehaviour__float__Equals__);
    sub_63CEE78(&Method_System_ValueTuple_CampusVolumeTimelineBehaviour__float___ctor__);
    unk_F43BAD8 = 1;
  }
  v32 = nullptr;
  v33 = 0;
  v30 = nullptr;
  v31 = 0;
  v28 = 0;
  v29 = 0;
  InputCount_Playable = UnityEngine_Playables_PlayableExtensions__GetInputCount_Playable_(a1, (void *)a2);
  v32 = nullptr;
  v33 = 0;
  v30 = nullptr;
  v31 = 0;
  if ( InputCount_Playable >= 1 )
  {
    v8 = InputCount_Playable;
    for ( i = 0; v8 != i; ++i )
    {
      InputWeight_Playable = UnityEngine_Playables_PlayableExtensions__GetInputWeight_Playable_(a1, a2, (void *)i);
      Input_Playable = UnityEngine_Playables_PlayableExtensions__GetInput_Playable_(a1, a2, (void *)i);
      v13 = v12;
      if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo);
      v28 = UnityEngine_Playables_ScriptPlayable_object___op_Explicit(Input_Playable, v13);
      v29 = v14;
      if ( InputWeight_Playable > 0.0 )
      {
        if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo);
        Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                      (__int64)&v28,
                      Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__GetBehaviour__);
        if ( !System_ValueTuple_object__float___Equals_1((__int64)&v32, 0, nullptr) )
        {
          System_ValueTuple_object__float____ctor(
            (__int64)&v30,
            Behaviour,
            InputWeight_Playable,
            Method_System_ValueTuple_CampusVolumeTimelineBehaviour__float___ctor__);
          break;
        }
        System_ValueTuple_object__float____ctor(
          (__int64)&v32,
          Behaviour,
          InputWeight_Playable,
          Method_System_ValueTuple_CampusVolumeTimelineBehaviour__float___ctor__);
      }
    }
  }
  if ( !System_ValueTuple_object__float___Equals_1((__int64)&v32, 0, nullptr) )
  {
    v17 = System_ValueTuple_object__float___Equals_1((__int64)&v30, 0, nullptr);
    v18 = v32;
    if ( v17 )
    {
      if ( v32 )
      {
        Campus_Timeline_CampusVolumeTimelineBehaviour__SetVolumeWeight(v32, *(float *)&v33, v16);
        v18 = v32;
        if ( v32 )
        {
          Campus_Timeline_CampusVolumeTimelineBehaviour__ResetVolumePriority(v32, v16);
          return;
        }
      }
      goto LABEL_30;
    }
    if ( !v32 || !v30 )
    {
LABEL_30:
      v26 = (void *)sub_63CF120(v18, v16);
      Campus_Timeline_CampusVolumeTimelineMixerBehaviour___ctor(v26, v27);
      return;
    }
    v19 = (float *)&v31;
    if ( *((double *)v32 + 6) < v30[6] )
    {
      v20 = (double *)v32;
    }
    else
    {
      v19 = (float *)&v33;
      v20 = v30;
    }
    if ( *((double *)v32 + 6) >= v30[6] )
      v21 = (double *)v32;
    else
      v21 = v30;
    v22 = *v19;
    Campus_Timeline_CampusVolumeTimelineBehaviour__SetVolumeWeight(v20, 1.0, v16);
    Campus_Timeline_CampusVolumeTimelineBehaviour__ResetVolumePriority(v20, v23);
    Campus_Timeline_CampusVolumeTimelineBehaviour__SetVolumeWeight(v21, v22, v24);
    Campus_Timeline_CampusVolumeTimelineBehaviour__OffsetVolumePriority(v21, 1.0, v25);
  }
}

