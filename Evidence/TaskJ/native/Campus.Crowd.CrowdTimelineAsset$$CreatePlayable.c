// Campus.Crowd.CrowdTimelineAsset$$CreatePlayable @ 0xddcc3f4
__int64 __fastcall Campus_Crowd_CrowdTimelineAsset__CreatePlayable(void *a0, __int64 a1, void *a2, void *a3)
{
  __int64 v7; // x21
  __int64 v8; // x0
  void *v9; // x1

  if ( (unk_F43BD3A & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__op_Implicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo);
    unk_F43BD3A = 1;
  }
  v7 = *((_QWORD *)a0 + 3);
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdTimelineBehaviour__TypeInfo);
  v8 = UnityEngine_Playables_ScriptPlayable_object___Create_1(a1, a2, v7, nullptr);
  return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v8, v9);
}

