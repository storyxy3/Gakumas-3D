// Campus.Crowd.CrowdAnimator$$GetTime @ 0xddc3548
double __fastcall Campus_Crowd_CrowdAnimator__GetTime(void *a0, void *a1)
{
  if ( (unk_F43BCE6 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetTime_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE6 = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a1) )
    return UnityEngine_Playables_PlayableExtensions__GetTime_ScriptPlayable_object__(
             *((_QWORD *)a0 + 23),
             *((void **)a0 + 24));
  else
    return NAN;
}

