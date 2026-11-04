// Campus.Crowd.CrowdMotionDefine$$get_Item @ 0xddc364c
// local variable allocation has failed, the output may be wrong!
void *__fastcall Campus_Crowd_CrowdMotionDefine__get_Item(void *a0, int a1, void *a2)
{
  int v3; // w3
  __int64 v4; // x8
  void *v6; // x0
  void *v7; // x1

  v4 = *((_QWORD *)a0 + 9);
  if ( v4 )
  {
    if ( *(_DWORD *)(v4 + 24) > (unsigned int)a1 )
      return *(void **)(v4 + 8LL * a1 + 32);
  }
  else
  {
    a0 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
  }
  sub_63CF128(a0, *(_QWORD *)&a1, (_DWORD)a2, v3);
  return (void *)Campus_Crowd_CrowdMotionDefine__get_count(v6, v7);
}

