// Campus.Crowd.CrowdSystem$$BakeBillboardCrowd @ 0xddc638c
void __fastcall Campus_Crowd_CrowdSystem__BakeBillboardCrowd(void *a0, __int64 a1, void *a2, void *a3)
{
  void *v4; // x5
  __int64 v5; // x8
  void *v6; // x0
  __int64 v7; // x9
  void *v8; // x4

  v5 = *((_QWORD *)a0 + 7);
  if ( v5 )
  {
    v6 = *((void **)a0 + 8);
    if ( v6 )
    {
      v7 = *(_QWORD *)(v5 + 16);
      if ( v7 )
        v8 = *(void **)(v7 + 24);
      else
        v8 = nullptr;
      Campus_Crowd_BillboardMeshRenderSystem__BakeBillboard(v6, a1, a2, *(void **)(v5 + 40), v8, v4);
    }
  }
}

