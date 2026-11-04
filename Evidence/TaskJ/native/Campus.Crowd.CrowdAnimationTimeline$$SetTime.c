// Campus.Crowd.CrowdAnimationTimeline$$SetTime @ 0xddc229c
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetTime(void *a0, double a1, void *a2)
{
  void *v3; // x0

  v3 = *((void **)a0 + 8);
  if ( v3 )
    Campus_Crowd_CrowdAnimator__SetTime(v3, a1, a2);
}

