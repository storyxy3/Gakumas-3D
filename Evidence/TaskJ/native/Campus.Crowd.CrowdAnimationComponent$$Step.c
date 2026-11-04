// Campus.Crowd.CrowdAnimationComponent$$Step @ 0xddc050c
void __fastcall Campus_Crowd_CrowdAnimationComponent__Step(void *a0, void *a1)
{
  void *v2; // x19
  double Time; // d8
  float fixedDeltaTime; // s0

  v2 = *((void **)a0 + 9);
  if ( !v2 )
  {
    sub_63CF120(a0, a1);
    JUMPOUT(0xDDC0554);
  }
  Time = Campus_Crowd_CrowdAnimator__GetTime(*((void **)a0 + 9), nullptr);
  fixedDeltaTime = UnityEngine_Time__get_fixedDeltaTime(nullptr);
  Campus_Crowd_CrowdAnimator__SetTime(v2, Time + fixedDeltaTime, nullptr);
}

