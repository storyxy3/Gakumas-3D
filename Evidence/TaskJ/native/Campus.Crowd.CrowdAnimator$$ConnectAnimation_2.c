// 0xddc3258 @ 0xddc3258
void __fastcall Campus_Crowd_CrowdAnimator__ConnectAnimation_2(
        void *a0,
        void *a1,
        double a2,
        float a3,
        int a4,
        void *a5)
{
  void *v11; // x1
  void *Behaviour; // x0
  __int64 v13; // x1
  void *v14; // x21
  void *v15; // x0
  void *v16; // x1
  void *v17; // x2

  if ( (unk_F43BCDB & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCDB = 1;
  }
  if ( Campus_Crowd_CrowdAnimator__IsValid(a0, a1) )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(a1, nullptr, nullptr) && Campus_Crowd_CrowdAnimator__IsValid(a0, v11) )
    {
      if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
      Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                    (__int64)a0 + 184,
                    Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
      if ( Behaviour )
      {
        v14 = Behaviour;
        Campus_Crowd_CrowdAnimationBehaviour__SetAnimationCount(Behaviour, 1, nullptr);
        Campus_Crowd_CrowdAnimationBehaviour__ConnectAnimation(v14, 0, a1, a2, a3, a4, nullptr);
      }
      else
      {
        v15 = (void *)sub_63CF120(0, v13);
        Campus_Crowd_CrowdAnimator__ConnectAnimation_1(v15, v16, v17);
      }
    }
  }
}

