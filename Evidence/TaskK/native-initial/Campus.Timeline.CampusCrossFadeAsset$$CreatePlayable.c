// Campus.Timeline.CampusCrossFadeAsset$$CreatePlayable @ 0xdd49e50
__int64 __fastcall Campus_Timeline_CampusCrossFadeAsset__CreatePlayable(void *a0, __int64 a1, void *a2, void *a3)
{
  __int64 v7; // x21
  __int64 v8; // x0
  void *v9; // x1

  if ( (unk_F43B8F1 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__op_Implicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
    unk_F43B8F1 = 1;
  }
  v7 = *((_QWORD *)a0 + 3);
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
  v8 = UnityEngine_Playables_ScriptPlayable_object___Create_1(a1, a2, v7, nullptr);
  return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v8, v9);
}

