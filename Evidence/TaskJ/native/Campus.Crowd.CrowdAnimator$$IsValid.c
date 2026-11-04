// Campus.Crowd.CrowdAnimator$$IsValid @ 0xddc31e0
bool __fastcall Campus_Crowd_CrowdAnimator__IsValid(void *a0, void *a1)
{
  if ( (unk_F43BCE9 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE9 = 1;
  }
  return UnityEngine_Playables_PlayableGraph__IsValid((__int64)a0 + 56, nullptr)
      && UnityEngine_Playables_PlayableExtensions__IsValid_ScriptPlayable_object__(
           *((_QWORD *)a0 + 23),
           *((void **)a0 + 24));
}

