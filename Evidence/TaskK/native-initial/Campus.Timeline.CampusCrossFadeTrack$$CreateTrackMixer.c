// Campus.Timeline.CampusCrossFadeTrack$$CreateTrackMixer @ 0xdd4a4fc
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall Campus_Timeline_CampusCrossFadeTrack__CreateTrackMixer(
        void *a0,
        __int64 a1,
        void *a2,
        int a3,
        void *a4)
{
  unsigned int v5; // w19
  void *v6; // x20
  void *v9; // x23
  __int64 v10; // x8
  void *GenericBinding; // x0
  __int64 v12; // x10
  void *v13; // x24
  __int64 result; // x0
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  void *v19; // x0
  __int64 v20; // [xsp+8h] [xbp+8h] BYREF
  void *v21; // [xsp+10h] [xbp+10h]
  void *v22; // [xsp+18h] [xbp+18h] BYREF

  v5 = (unsigned int)a4;
  v6 = *(void **)&a3;
  v9 = a0;
  if ( (unk_F43B8F5 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_Live_CampusCrossFadeImage_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GameObject_TryGetComponent_PlayableDirector___);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__GetBehaviour__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__op_Implicit__);
    a0 = (void *)sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__TypeInfo);
    unk_F43B8F5 = 1;
  }
  v21 = nullptr;
  v22 = nullptr;
  v20 = 0;
  if ( !v6 )
    goto LABEL_23;
  if ( !UnityEngine_GameObject__TryGetComponent_object_(
          v6,
          &v22,
          Method_UnityEngine_GameObject_TryGetComponent_PlayableDirector___) )
    return UnityEngine_Timeline_TrackAsset__CreateTrackMixer(v9, a1, a2, (int)v6, (void *)v5);
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__TypeInfo);
  v10 = UnityEngine_Playables_ScriptPlayable_object___Create(a1, (int)a2, (void *)v5);
  a0 = v22;
  v20 = v10;
  v21 = (void *)a1;
  if ( !v22 )
    goto LABEL_23;
  GenericBinding = UnityEngine_Playables_PlayableDirector__GetGenericBinding(v22, v9, nullptr);
  if ( GenericBinding
    && (v12 = *(unsigned __int8 *)(Campus_Common_Live_CampusCrossFadeImage_TypeInfo + 304LL),
        *(unsigned __int8 *)(*(_QWORD *)GenericBinding + 304LL) >= (unsigned int)v12) )
  {
    if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)GenericBinding + 200LL) + 8 * v12 - 8) == Campus_Common_Live_CampusCrossFadeImage_TypeInfo )
      v13 = GenericBinding;
    else
      v13 = nullptr;
  }
  else
  {
    v13 = nullptr;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v13, nullptr, nullptr) )
    return UnityEngine_Timeline_TrackAsset__CreateTrackMixer(v9, a1, a2, (int)v6, (void *)v5);
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__TypeInfo);
  a0 = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
         (__int64)&v20,
         Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeMixerBehaviour__GetBehaviour__);
  if ( a0 )
  {
    *((_QWORD *)a0 + 2) = v13;
    sub_63CEE24((char *)a0 + 16, (int)v13, v15, v16, v17, v18);
    return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v20, v21);
  }
  else
  {
LABEL_23:
    v19 = (void *)sub_63CF120(a0, a1);
    UnityEngine_Timeline_PlayableTrack___ctor(v19, nullptr);
  }
  return result;
}

