// Campus.Crowd.CrowdAnimationTimeline$$InitializeCrowdAnimator @ 0xddc177c
void __fastcall Campus_Crowd_CrowdAnimationTimeline__InitializeCrowdAnimator(void *a0, void *a1)
{
  __int64 v3; // x8
  void *transform; // x23
  void *v5; // x21
  void *v6; // x22
  void *v7; // x24
  void *v8; // x4
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  void *v13; // [xsp+8h] [xbp+8h] BYREF
  void *v14; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F43BCD3 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_Animator___);
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_CrowdVolume___);
    sub_63CEE78(&Campus_Crowd_CrowdAnimator_TypeInfo);
    unk_F43BCD3 = 1;
  }
  v14 = nullptr;
  v3 = *((_QWORD *)a0 + 8);
  v13 = nullptr;
  if ( !v3
    && UnityEngine_Component__TryGetComponent_object_(
         a0,
         &v14,
         Method_UnityEngine_Component_TryGetComponent_Animator___)
    && UnityEngine_Component__TryGetComponent_object_(
         a0,
         &v13,
         Method_UnityEngine_Component_TryGetComponent_CrowdVolume___) )
  {
    transform = UnityEngine_Component__get_transform(a0, nullptr);
    v5 = v14;
    v6 = v13;
    v7 = (void *)sub_63CF110(Campus_Crowd_CrowdAnimator_TypeInfo);
    Campus_Crowd_CrowdAnimator___ctor(v7, transform, v5, v6, v8);
    *((_QWORD *)a0 + 8) = v7;
    sub_63CEE24((char *)a0 + 64, (int)v7, v9, v10, v11, v12);
  }
}

