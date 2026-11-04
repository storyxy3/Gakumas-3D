// 0xddc2574 @ 0xddc2574
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimator__ConnectAnimation_4(
        void *a0,
        int a1,
        void *a2,
        double a3,
        float a4,
        int a5,
        void *a6)
{
  void *v13; // x1
  void *Behaviour; // x0
  __int64 v15; // x1
  void *v16; // x0
  int v17; // w1
  void *v18; // x2
  float v19; // s0

  if ( (unk_F43BCDD & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCDD = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, *(void **)&a1) )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) && Campus_Crowd_CrowdAnimator__IsValid(a0, v13) )
    {
      if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
      Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                    (__int64)a0 + 184,
                    Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
      if ( Behaviour )
      {
        Campus_Crowd_CrowdAnimationBehaviour__ConnectAnimation(Behaviour, a1, a2, a3, a4, a5, nullptr);
      }
      else
      {
        v16 = (void *)sub_63CF120(0, v15);
        Campus_Crowd_CrowdAnimationTimeline__SetAnimationWeight(v16, v17, v19, v18);
      }
    }
  }
}

