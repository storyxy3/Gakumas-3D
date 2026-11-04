// Campus.Crowd.CrowdAnimationTimeline$$IsPaused @ 0xddc2390
bool __fastcall Campus_Crowd_CrowdAnimationTimeline__IsPaused(void *a0, void *a1)
{
  void *v2; // x0

  v2 = *((void **)a0 + 8);
  if ( v2 )
    LOBYTE(v2) = Campus_Crowd_CrowdAnimator__IsPaused(v2, a1);
  return (char)v2;
}

