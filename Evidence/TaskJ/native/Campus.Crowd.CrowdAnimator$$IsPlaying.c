// Campus.Crowd.CrowdAnimator$$IsPlaying @ 0xddc34e0
bool __fastcall Campus_Crowd_CrowdAnimator__IsPlaying(void *a0, void *a1)
{
  if ( (unk_F43BCE4 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetPlayState_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE4 = 1;
  }
  return Campus_Crowd_CrowdAnimator__IsValid(a0, a1)
      && UnityEngine_Playables_PlayableExtensions__GetPlayState_ScriptPlayable_object__(
           *((_QWORD *)a0 + 23),
           *((void **)a0 + 24)) == 1;
}

