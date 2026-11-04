// Campus.Crowd.CrowdTimelineAsset$$.ctor @ 0xddcc49c
void __fastcall Campus_Crowd_CrowdTimelineAsset___ctor(void *a0, void *a1)
{
  void *v3; // x20
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43BD3B & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdTimelineBehaviour_TypeInfo);
    unk_F43BD3B = 1;
  }
  v3 = (void *)sub_63CF110(Campus_Crowd_CrowdTimelineBehaviour_TypeInfo);
  UnityEngine_Playables_PlayableBehaviour___ctor(v3, nullptr);
  *((_QWORD *)a0 + 3) = v3;
  sub_63CEE24((char *)a0 + 24, (int)v3, v4, v5, v6, v7);
  UnityEngine_Playables_PlayableAsset___ctor(a0, nullptr);
}

