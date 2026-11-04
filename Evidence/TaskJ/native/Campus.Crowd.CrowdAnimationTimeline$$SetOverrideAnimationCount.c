// Campus.Crowd.CrowdAnimationTimeline$$SetOverrideAnimationCount @ 0xddc2980
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetOverrideAnimationCount(void *a0, int a1, void *a2)
{
  void *v3; // x0

  v3 = *((void **)a0 + 8);
  if ( v3 )
    Campus_Crowd_CrowdAnimator__SetOverrideAnimationCount(v3, a1, a2);
}

