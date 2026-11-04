// Campus.Crowd.CrowdAnimationTimeline$$SetAnimationData @ 0xddc2544
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetAnimationData(void *a0, int a1, void *a2, void *a3)
{
  void *v4; // x4
  __int64 v5; // x30
  void *v6; // x0
  double v7; // d0
  float v8; // s1
  int v9; // w3
  void *v10; // x2
  __int64 v11; // [xsp+0h] [xbp+0h]

  v6 = *((void **)a0 + 8);
  if ( v6 )
  {
    if ( a2 )
    {
      v7 = *((double *)a2 + 3);
      v8 = *((float *)a2 + 8);
      v9 = *((_DWORD *)a2 + 9);
      v10 = *((void **)a2 + 2);
    }
    else
    {
      *(&v11 - 2) = v5;
      v6 = (void *)sub_63CF120(v6, *(_QWORD *)&a1);
    }
    Campus_Crowd_CrowdAnimator__ConnectAnimation_4(v6, a1, v10, v7, v8, v9, v4);
  }
}

