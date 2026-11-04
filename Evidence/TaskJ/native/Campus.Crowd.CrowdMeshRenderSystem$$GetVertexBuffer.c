// Campus.Crowd.CrowdMeshRenderSystem$$GetVertexBuffer @ 0xddc8210
// local variable allocation has failed, the output may be wrong!
void *__fastcall Campus_Crowd_CrowdMeshRenderSystem__GetVertexBuffer(void *a0, int a1, void *a2)
{
  int v3; // w3
  __int64 v4; // x8
  void *result; // x0
  void *v6; // x0
  void *v7; // x1
  void *v8; // x2

  v4 = *((_QWORD *)a0 + 7);
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
  Campus_Crowd_CrowdMeshRenderSystem__SetupCompute(v6, v7, v8);
  return result;
}

