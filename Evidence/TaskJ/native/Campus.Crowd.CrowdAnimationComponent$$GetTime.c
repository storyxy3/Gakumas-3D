// Campus.Crowd.CrowdAnimationComponent$$GetTime @ 0xddc0554
double __fastcall Campus_Crowd_CrowdAnimationComponent__GetTime(void *a0, void *a1)
{
  __int64 v2; // x30
  void *v3; // x0
  double result; // d0
  void *v5; // x0
  void *v6; // x1
  double v7; // d0
  __int64 v8; // [xsp+0h] [xbp+0h]

  v3 = *((void **)a0 + 9);
  if ( v3 )
    return Campus_Crowd_CrowdAnimator__GetTime(v3, nullptr);
  *(&v8 - 2) = v2;
  v5 = (void *)sub_63CF120(0, a1);
  Campus_Crowd_CrowdAnimationComponent__SetTime(v5, v7, v6);
  return result;
}

