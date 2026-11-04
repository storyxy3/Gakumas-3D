// Campus.Crowd.CrowdAnimator$$Pause @ 0xddc2330
void __fastcall Campus_Crowd_CrowdAnimator__Pause(void *a0, void *a1)
{
  if ( (unk_F43BCE7 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_Pause_ScriptPlayable_CrowdAnimationBehaviour____);
    unk_F43BCE7 = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a1) )
    UnityEngine_Playables_PlayableExtensions__Pause_ScriptPlayable_object__(*((_QWORD *)a0 + 23), *((void **)a0 + 24));
}

