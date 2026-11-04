// Campus.Crowd.CrowdSystem$$DisposeCrowdSystemData @ 0xddc99cc
void __fastcall Campus_Crowd_CrowdSystem__DisposeCrowdSystemData(void *a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  void *v6; // x0
  _QWORD *v7; // x19

  v7 = (char *)a0 + 80;
  v6 = *((void **)a0 + 10);
  if ( v6 )
    Campus_Crowd_CrowdSystemData__Dispose(v6, a1);
  *v7 = 0;
  sub_63CEE24(v7, 0, v2, v3, v4, v5);
}

