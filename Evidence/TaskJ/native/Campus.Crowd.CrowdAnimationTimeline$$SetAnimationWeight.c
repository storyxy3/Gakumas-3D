// Campus.Crowd.CrowdAnimationTimeline$$SetAnimationWeight @ 0xddc268c
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetAnimationWeight(void *a0, int a1, float a2, void *a3)
{
  void *v4; // x0

  v4 = *((void **)a0 + 8);
  if ( v4 )
    Campus_Crowd_CrowdAnimator__SetAnimationWeight(v4, a1, a2, a3);
}

