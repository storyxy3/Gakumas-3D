// Campus.Timeline.CampusVolumeTimelineTrack$$CreateTrackMixer @ 0xdd7ea80
__int64 __fastcall Campus_Timeline_CampusVolumeTimelineTrack__CreateTrackMixer(
        void *a0,
        __int64 a1,
        void *a2,
        int a3,
        void *a4)
{
  unsigned int v5; // w19
  int v6; // w20
  __int64 v8; // x0
  void *v9; // x1

  v5 = (unsigned int)a4;
  v6 = (int)a2;
  if ( (unk_F43BAD9 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineMixerBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineMixerBehaviour__op_Implicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineMixerBehaviour__TypeInfo);
    unk_F43BAD9 = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineMixerBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineMixerBehaviour__TypeInfo);
  v8 = UnityEngine_Playables_ScriptPlayable_object___Create(a1, v6, (void *)v5);
  return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v8, v9);
}

