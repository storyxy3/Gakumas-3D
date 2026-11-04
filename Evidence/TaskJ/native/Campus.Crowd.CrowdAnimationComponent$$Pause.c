// Campus.Crowd.CrowdAnimationComponent$$Pause @ 0xddc04c4
void __fastcall Campus_Crowd_CrowdAnimationComponent__Pause(void *a0, void *a1)
{
  __int64 v2; // x30
  void *v3; // x0
  __int64 v4; // [xsp+0h] [xbp+0h]

  v3 = *((void **)a0 + 9);
  if ( !v3 )
  {
    *(&v4 - 2) = v2;
    sub_63CF120(0, a1);
    JUMPOUT(0xDDC04DC);
  }
  Campus_Crowd_CrowdAnimator__Pause(v3, nullptr);
}

