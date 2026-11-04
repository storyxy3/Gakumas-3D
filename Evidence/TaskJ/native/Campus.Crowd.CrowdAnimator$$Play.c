// Campus.Crowd.CrowdAnimator$$Play @ 0xddc2418
void __fastcall Campus_Crowd_CrowdAnimator__Play(void *a0, void *a1)
{
  if ( (unk_F43BCE3 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_Play_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE3 = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a1) )
    UnityEngine_Playables_PlayableExtensions__Play_ScriptPlayable_object__(*((_QWORD *)a0 + 23), *((void **)a0 + 24));
}

