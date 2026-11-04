// Campus.Crowd.CrowdAnimationComponent$$IsPause @ 0xddc04f4
bool __fastcall Campus_Crowd_CrowdAnimationComponent__IsPause(void *a0, void *a1)
{
  __int64 v2; // x30
  void *v3; // x0
  __int64 v5; // [xsp+0h] [xbp+0h]

  v3 = *((void **)a0 + 9);
  if ( !v3 )
  {
    *(&v5 - 2) = v2;
    sub_63CF120(0, a1);
    JUMPOUT(0xDDC050C);
  }
  return Campus_Crowd_CrowdAnimator__IsPaused(v3, nullptr);
}

