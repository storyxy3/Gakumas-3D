// Campus.Crowd.CrowdAnimationTimeline$$SetAnimationCount @ 0xddc2478
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetAnimationCount(void *a0, int a1, void *a2)
{
  __int64 v5; // x1
  void *v6; // x2
  void *v7; // x0
  int v8; // w1

  Campus_Crowd_CrowdAnimationTimeline__InitializeCrowdAnimator(a0, *(void **)&a1);
  v7 = *((void **)a0 + 8);
  if ( v7 )
    v8 = a1;
  else
    v7 = (void *)sub_63CF120(0, v5);
  Campus_Crowd_CrowdAnimator__SetAnimationCount(v7, v8, v6);
}

