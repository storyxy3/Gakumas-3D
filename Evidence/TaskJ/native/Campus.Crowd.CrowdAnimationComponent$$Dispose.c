// Campus.Crowd.CrowdAnimationComponent$$Dispose @ 0xddc0418
void __fastcall Campus_Crowd_CrowdAnimationComponent__Dispose(void *a0, void *a1)
{
  void *v2; // x0
  _QWORD *v3; // x19
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  v3 = (char *)a0 + 72;
  v2 = *((void **)a0 + 9);
  if ( v2 )
  {
    Campus_Crowd_CrowdAnimator__Dispose(v2, nullptr);
    *v3 = 0;
    sub_63CEE24(v3, 0, v4, v5, v6, v7);
  }
}

