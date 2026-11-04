// Campus.Crowd.CrowdSystem$$SetDrawCounts @ 0xddc485c
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdSystem__SetDrawCounts(void *a0, int a1, void *a2)
{
  __int64 v3; // x30
  __int64 v4; // x8
  __int64 v5; // x9
  __int64 v6; // x9
  int v7; // w9
  void *v8; // x0
  int v9; // w1
  void *v10; // x2
  __int64 v11; // [xsp+0h] [xbp+0h]

  v4 = *((_QWORD *)a0 + 7);
  if ( v4 )
  {
    v5 = *(_QWORD *)(v4 + 16);
    if ( v5 )
    {
      v6 = *(_QWORD *)(v5 + 24);
      if ( v6 )
      {
        v7 = *(_DWORD *)(v6 + 24);
        if ( v7 >= 1 )
          *(_DWORD *)(v4 + 148) = (a1 & (unsigned int)~(a1 >> 31)) / v7;
      }
    }
  }
  else
  {
    *(&v11 - 2) = v3;
    v8 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
    Campus_Crowd_CrowdSystem__SetBillboardResolution(v8, v9, v10);
  }
}

