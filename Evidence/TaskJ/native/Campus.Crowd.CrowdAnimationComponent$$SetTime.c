// Campus.Crowd.CrowdAnimationComponent$$SetTime @ 0xddc056c
void __fastcall Campus_Crowd_CrowdAnimationComponent__SetTime(void *a0, double a1, void *a2)
{
  __int64 v3; // x30
  void *v4; // x0
  __int64 v5; // [xsp+0h] [xbp+0h]

  v4 = *((void **)a0 + 9);
  if ( !v4 )
  {
    *(&v5 - 2) = v3;
    sub_63CF120(0, a2);
    JUMPOUT(0xDDC0584);
  }
  Campus_Crowd_CrowdAnimator__SetTime(v4, a1, nullptr);
}

