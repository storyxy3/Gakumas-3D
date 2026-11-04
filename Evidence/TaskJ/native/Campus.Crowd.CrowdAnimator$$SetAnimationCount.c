// Campus.Crowd.CrowdAnimator$$SetAnimationCount @ 0xddc24a8
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimator__SetAnimationCount(void *a0, int a1, void *a2)
{
  void *Behaviour; // x0
  __int64 v6; // x1
  void *v7; // x0
  int v8; // w1
  void *v9; // x2
  void *v10; // x3

  if ( (unk_F43BCDF & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCDF = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, *(void **)&a1) )
  {
    if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                  (__int64)a0 + 184,
                  Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    if ( Behaviour )
    {
      Campus_Crowd_CrowdAnimationBehaviour__SetAnimationCount(Behaviour, a1, nullptr);
    }
    else
    {
      v7 = (void *)sub_63CF120(0, v6);
      Campus_Crowd_CrowdAnimationTimeline__SetAnimationData(v7, v8, v9, v10);
    }
  }
}

