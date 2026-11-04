// Campus.Crowd.CrowdAnimator$$SetAnimationTime @ 0xddc275c
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimator__SetAnimationTime(void *a0, int a1, double a2, void *a3)
{
  void *Behaviour; // x0
  __int64 v8; // x1
  void *v9; // x0
  int v10; // w1
  void *v11; // x2
  void *v12; // x3

  if ( (unk_F43BCE1 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCE1 = 1;
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
      Campus_Crowd_CrowdAnimationBehaviour__SetAnimationTime(Behaviour, a1, a2, nullptr);
    }
    else
    {
      v9 = (void *)sub_63CF120(0, v8);
      Campus_Crowd_CrowdAnimationTimeline__SetOverrideAnimationData(v9, v10, v11, v12);
    }
  }
}

