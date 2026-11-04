// Campus.Crowd.CrowdAnimationTimeline$$SetAnimationTime @ 0xddc274c
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetAnimationTime(void *a0, int a1, double a2, void *a3)
{
  void *v4; // x0

  v4 = *((void **)a0 + 8);
  if ( v4 )
    Campus_Crowd_CrowdAnimator__SetAnimationTime(v4, a1, a2, a3);
}

