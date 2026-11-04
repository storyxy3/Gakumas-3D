// 0xddc3390 @ 0xddc3390
void __fastcall Campus_Crowd_CrowdAnimator__ConnectAnimation_3(
        void *a0,
        void *a1,
        double a2,
        float a3,
        int a4,
        void *a5)
{
  bool IsValid; // w0
  void *v12; // x1
  void *Behaviour; // x0
  __int64 v14; // x1
  void *v15; // x21
  __int64 v16; // x0
  __int64 v17; // x1
  int v18; // w2
  int v19; // w3
  void *v20; // x0
  void *v21; // x1

  if ( (unk_F43BCDC & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    unk_F43BCDC = 1;
  }
  IsValid = Campus_Crowd_CrowdAnimator__IsValid(a0, a1);
  if ( a1 && IsValid && Campus_Crowd_CrowdAnimator__IsValid(a0, v12) )
  {
    if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    Behaviour = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
                  (__int64)a0 + 184,
                  Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__GetBehaviour__);
    if ( Behaviour )
    {
      v15 = Behaviour;
      Campus_Crowd_CrowdAnimationBehaviour__SetAnimationCount(Behaviour, 1, nullptr);
      Campus_Crowd_CrowdAnimationBehaviour__SetOverrideAnimationCount(v15, 1, nullptr);
      if ( *((_DWORD *)a1 + 6) )
      {
        Campus_Crowd_CrowdAnimationBehaviour__ConnectAnimation(v15, 0, *((void **)a1 + 4), a2, a3, a4, nullptr);
        if ( (*((_DWORD *)a1 + 6) & 0xFFFFFFFE) != 0 )
        {
          Campus_Crowd_CrowdAnimationBehaviour__ConnectOverrideAnimation(
            v15,
            0,
            *((void **)a1 + 5),
            a2,
            a3,
            a4,
            nullptr);
          Campus_Crowd_CrowdAnimationBehaviour__SetOverrideAnimationWeight(v15, 0, 1.0, nullptr);
          return;
        }
      }
      sub_63CF128(v16, v17, v18, v19);
    }
    v20 = (void *)sub_63CF120(Behaviour, v14);
    Campus_Crowd_CrowdAnimator__IsPlaying(v20, v21);
  }
}

