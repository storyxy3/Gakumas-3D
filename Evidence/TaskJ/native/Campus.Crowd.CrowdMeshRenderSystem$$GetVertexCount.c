// Campus.Crowd.CrowdMeshRenderSystem$$GetVertexCount @ 0xddc84f4
int __fastcall Campus_Crowd_CrowdMeshRenderSystem__GetVertexCount(void *a0, void *a1)
{
  void *v3; // x20
  __int64 v4; // x1
  void *v5; // x0
  int result; // w0
  void *v7; // x0
  void *v8; // x1
  void *v9; // x2
  void *v10; // x3

  if ( (unk_F43BD0F & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD0F = 1;
  }
  v3 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
    return 0;
  v5 = *((void **)a0 + 5);
  if ( v5 )
    return UnityEngine_Mesh__get_vertexCount(v5, nullptr);
  v7 = (void *)sub_63CF120(0, v4);
  Campus_Crowd_CrowdMeshRenderSystem__SetHandMatrices(v7, v8, v9, v10);
  return result;
}

