// Campus.Crowd.CrowdSystem$$DisposePenlightMeshRenderSystem @ 0xddc972c
void __fastcall Campus_Crowd_CrowdSystem__DisposePenlightMeshRenderSystem(void *a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  void *v6; // x0
  _QWORD *v7; // x19

  v7 = (char *)a0 + 72;
  v6 = *((void **)a0 + 9);
  if ( v6 )
    Campus_Crowd_PenlightMeshRenderSystem__Dispose(v6, a1);
  *v7 = 0;
  sub_63CEE24(v7, 0, v2, v3, v4, v5);
}

