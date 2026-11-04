// Campus.Crowd.CrowdAnimationBehaviour$$SetAnimationTime @ 0xddbfb98
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__SetAnimationTime(void *a0, int a1, double a2, void *a3)
{
  __int64 v4; // x8
  void *v5; // x0

  if ( (a1 & 0x80000000) == 0 )
  {
    v4 = *((_QWORD *)a0 + 20);
    if ( v4 )
    {
      if ( *(_DWORD *)(v4 + 24) > a1 )
      {
        v5 = *(void **)(v4 + 8LL * (unsigned int)a1 + 32);
        if ( v5 )
          Campus_Crowd_ClipData__SetTime(v5, a2, nullptr);
      }
    }
  }
}

