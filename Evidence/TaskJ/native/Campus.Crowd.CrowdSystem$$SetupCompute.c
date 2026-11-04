// Campus.Crowd.CrowdSystem$$SetupCompute @ 0xddc9688
void __fastcall Campus_Crowd_CrowdSystem__SetupCompute(void *a0, void *a1, void *a2, void *a3, void *a4)
{
  void *v6; // x0
  void *v9; // x0
  void *v10; // x0

  v6 = *((void **)a0 + 7);
  if ( v6 )
    Campus_Crowd_CrowdMeshRenderSystem__SetupCompute(v6, a1, a2);
  v9 = *((void **)a0 + 9);
  if ( v9 )
    Campus_Crowd_PenlightMeshRenderSystem__SetupCompute(v9, a3, a2);
  v10 = *((void **)a0 + 10);
  if ( v10 )
    Campus_Crowd_CrowdSystemData__SetupCompute(v10, a2, a2);
}

