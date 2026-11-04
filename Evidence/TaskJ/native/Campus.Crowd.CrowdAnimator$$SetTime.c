// Campus.Crowd.CrowdAnimator$$SetTime @ 0xddc22ac
void __fastcall Campus_Crowd_CrowdAnimator__SetTime(void *a0, double a1, void *a2)
{
  if ( (unk_F43BCE5 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetTime_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE5 = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a2) )
    UnityEngine_Playables_PlayableExtensions__SetTime_ScriptPlayable_object__(
      *((_QWORD *)a0 + 23),
      a1,
      *((void **)a0 + 24));
}

