// Campus.Crowd.CrowdAnimator$$SetOverrideAnimationTime @ 0xddc2afc
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimator__SetOverrideAnimationTime(void *a0, int a1, double a2, void *a3)
{
  void *Behaviour; // x0
  __int64 v8; // x1
  void *v9; // x0
  void *v10; // x1

  if ( (unk_F43BCEC & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCEC = 1;
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
      Campus_Crowd_CrowdAnimationBehaviour__SetOverrideAnimationTime(Behaviour, a1, a2, nullptr);
    }
    else
    {
      v9 = (void *)sub_63CF120(0, v8);
      Campus_Crowd_CrowdAnimationTimeline___ctor(v9, v10);
    }
  }
}

