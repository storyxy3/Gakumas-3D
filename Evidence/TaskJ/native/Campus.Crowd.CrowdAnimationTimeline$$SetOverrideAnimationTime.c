// Campus.Crowd.CrowdAnimationTimeline$$SetOverrideAnimationTime @ 0xddc2aec
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetOverrideAnimationTime(void *a0, int a1, double a2, void *a3)
{
  void *v4; // x0

  v4 = *((void **)a0 + 8);
  if ( v4 )
    Campus_Crowd_CrowdAnimator__SetOverrideAnimationTime(v4, a1, a2, a3);
}

