// Campus.Crowd.CrowdAnimationComponent$$Resume @ 0xddc04ac
void __fastcall Campus_Crowd_CrowdAnimationComponent__Resume(void *a0, void *a1)
{
  __int64 v2; // x30
  void *v3; // x0
  __int64 v4; // [xsp+0h] [xbp+0h]

  v3 = *((void **)a0 + 9);
  if ( !v3 )
  {
    *(&v4 - 2) = v2;
    sub_63CF120(0, a1);
    JUMPOUT(0xDDC04C4);
  }
  Campus_Crowd_CrowdAnimator__Play(v3, nullptr);
}

