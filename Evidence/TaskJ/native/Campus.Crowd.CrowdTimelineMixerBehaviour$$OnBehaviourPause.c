// Campus.Crowd.CrowdTimelineMixerBehaviour$$OnBehaviourPause @ 0xddcc510
void __fastcall Campus_Crowd_CrowdTimelineMixerBehaviour__OnBehaviourPause(void *a0, __int64 a1, __int64 a2, void *a3)
{
  __int64 v4; // x30
  __int64 v5; // x8
  void *v6; // x0
  void *v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  void *v10; // x3
  __int64 v11; // [xsp+0h] [xbp+0h]

  v5 = *((_QWORD *)a0 + 2);
  if ( v5 )
  {
    v6 = *(void **)(v5 + 64);
    if ( v6 )
      Campus_Crowd_CrowdAnimator__Pause(v6, (void *)a1);
  }
  else
  {
    *(&v11 - 2) = v4;
    v7 = (void *)sub_63CF120(a0, a1);
    Campus_Crowd_CrowdTimelineMixerBehaviour__OnBehaviourPlay(v7, v8, v9, v10);
  }
}

