// Campus.Timeline.CampusCrossFadeMixerBehaviour$$PrepareFrame @ 0xdd4a088
void __fastcall Campus_Timeline_CampusCrossFadeMixerBehaviour__PrepareFrame(void *a0, __int64 a1, __int64 a2, void *a3)
{
  int InputCount_Playable; // w0
  float v8; // s8
  int v9; // w22
  int HashCode; // w23
  unsigned int i; // w24
  float InputWeight_Playable; // s9
  __int64 Input_Playable; // x23
  void *v14; // x1
  void *v15; // x25
  void *v16; // x1
  __int64 v17; // x1
  __int64 v18; // x0
  void *v19; // x1
  __int64 v20; // x22
  void *v21; // x24
  double Time_Playable; // d0
  void *v23; // x0
  void *v24; // [xsp+8h] [xbp+8h]
  __int64 Handle; // [xsp+10h] [xbp+10h] BYREF
  __int64 v26; // [xsp+18h] [xbp+18h]
  __int64 v27; // [xsp+20h] [xbp+20h] BYREF
  void *v28; // [xsp+28h] [xbp+28h]

  if ( (unk_F43B8F3 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputCount_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputWeight_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInput_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetTime_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_ScriptPlayable_CampusCrossFadeBehaviour____);
    sub_63CEE78(&UnityEngine_Playables_PlayableHandle_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__GetHandle__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__op_Explicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
    unk_F43B8F3 = 1;
  }
  v28 = nullptr;
  v26 = 0;
  v27 = 0;
  Handle = 0;
  InputCount_Playable = UnityEngine_Playables_PlayableExtensions__GetInputCount_Playable_(a1, (void *)a2);
  v27 = 0;
  v28 = nullptr;
  if ( InputCount_Playable < 1 )
  {
    v19 = nullptr;
    v18 = 0;
    v8 = 0.0;
    HashCode = 0;
  }
  else
  {
    v8 = 0.0;
    v24 = a0;
    v9 = InputCount_Playable;
    HashCode = 0;
    for ( i = 0; i != v9; ++i )
    {
      InputWeight_Playable = UnityEngine_Playables_PlayableExtensions__GetInputWeight_Playable_(a1, a2, (void *)i);
      if ( InputWeight_Playable > 0.0 )
      {
        Input_Playable = UnityEngine_Playables_PlayableExtensions__GetInput_Playable_(a1, a2, (void *)i);
        v15 = v14;
        if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
        v27 = UnityEngine_Playables_ScriptPlayable_object___op_Explicit(Input_Playable, v15);
        v28 = v16;
        Handle = UnityEngine_Playables_ScriptPlayable_object___GetHandle(
                   (__int64)&v27,
                   Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__GetHandle__);
        v26 = v17;
        if ( !*(_DWORD *)(UnityEngine_Playables_PlayableHandle_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Playables_PlayableHandle_TypeInfo);
        HashCode = UnityEngine_Playables_PlayableHandle__GetHashCode((__int64)&Handle, nullptr);
      }
      v8 = v8 + InputWeight_Playable;
    }
    v18 = v27;
    v19 = v28;
    a0 = v24;
  }
  if ( UnityEngine_Playables_PlayableExtensions__IsValid_ScriptPlayable_object__(v18, v19)
    && *((_DWORD *)a0 + 6) != HashCode )
  {
    v20 = v27;
    v21 = v28;
    Time_Playable = UnityEngine_Playables_PlayableExtensions__GetTime_Playable_(a1, (void *)a2);
    Campus_Timeline_CampusCrossFadeMixerBehaviour__OnClipPlay(a0, v20, Time_Playable, v21);
  }
  v23 = *((void **)a0 + 2);
  *((_DWORD *)a0 + 6) = HashCode;
  Qua_Extensions_GraphicExtensions__SetAlpha(v23, v8, nullptr);
}

