// Campus.Crowd.CrowdMeshRenderSystem$$SetMaxInstanceCounts @ 0xddc82d8
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__SetMaxInstanceCounts(void *a0, int a1, void *a2)
{
  __int64 v3; // x8
  __int64 v4; // x8
  int v5; // w8

  v3 = *((_QWORD *)a0 + 2);
  if ( v3 )
  {
    v4 = *(_QWORD *)(v3 + 24);
    if ( v4 )
    {
      v5 = *(_DWORD *)(v4 + 24);
      if ( v5 >= 1 )
        *((_DWORD *)a0 + 37) = (a1 & (unsigned int)~(a1 >> 31)) / v5;
    }
  }
}

