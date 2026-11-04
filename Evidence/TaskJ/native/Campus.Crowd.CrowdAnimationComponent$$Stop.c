// Campus.Crowd.CrowdAnimationComponent$$Stop @ 0xddc0478
void __fastcall Campus_Crowd_CrowdAnimationComponent__Stop(void *a0, void *a1)
{
  void *v3; // x0

  v3 = *((void **)a0 + 9);
  if ( !v3 || (Campus_Crowd_CrowdAnimator__Pause(v3, nullptr), (v3 = *((void **)a0 + 9)) == nullptr) )
  {
    sub_63CF120(v3, a1);
    JUMPOUT(0xDDC04AC);
  }
  Campus_Crowd_CrowdAnimator__SetTime(v3, 0.0, nullptr);
}

