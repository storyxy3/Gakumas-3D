// Campus.Crowd.CrowdMeshRenderSystem$$get_SubMeshes @ 0xddc7d90
void *__fastcall Campus_Crowd_CrowdMeshRenderSystem__get_SubMeshes(void *a0, void *a1)
{
  __int64 v2; // x8

  v2 = *((_QWORD *)a0 + 2);
  if ( v2 )
    return *(void **)(v2 + 24);
  else
    return nullptr;
}

