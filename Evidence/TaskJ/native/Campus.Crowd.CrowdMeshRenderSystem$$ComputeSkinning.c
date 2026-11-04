// Campus.Crowd.CrowdMeshRenderSystem$$ComputeSkinning @ 0xddc8304
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__ComputeSkinning(void *a0, void *a1, void *a2, void *a3)
{
  int VertexCount; // w0
  unsigned int v8; // w22
  void *v9; // x23
  __int64 v10; // x1
  void *v11; // x23
  __int64 v12; // x0
  unsigned int v13; // w25
  void *v14; // x2
  void *VertexBuffer; // x22
  void *v16; // x2
  void *v17; // x23
  void *v18; // x0
  void *v19; // x1

  if ( (unk_F43BD0B & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD0B = 1;
  }
  VertexCount = Campus_Crowd_CrowdMeshRenderSystem__GetVertexCount(a0, a1);
  if ( VertexCount >= 1 )
  {
    v8 = VertexCount;
    v9 = *((void **)a0 + 17);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(v9, nullptr, nullptr) && (*((_DWORD *)a0 + 36) & 0x80000000) == 0 )
    {
      v11 = *((void **)a0 + 17);
      v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
        sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
      if ( a1 )
      {
        UnityEngine_Rendering_CommandBuffer__SetComputeIntParam(
          a1,
          v11,
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 8LL),
          v8,
          nullptr);
        UnityEngine_Rendering_CommandBuffer__SetComputeIntParam(
          a1,
          *((void **)a0 + 17),
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 12LL),
          *((_DWORD *)a0 + 6),
          nullptr);
        v13 = v8 >> 6;
        VertexBuffer = Campus_Crowd_CrowdMeshRenderSystem__GetVertexBuffer(a0, 0, v14);
        v17 = Campus_Crowd_CrowdMeshRenderSystem__GetVertexBuffer(a0, 3, v16);
        UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
          a1,
          *((void **)a0 + 17),
          *((_DWORD *)a0 + 36),
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 16LL),
          *((void **)a0 + 6),
          nullptr);
        UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
          a1,
          *((void **)a0 + 17),
          *((_DWORD *)a0 + 36),
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 20LL),
          v17,
          nullptr);
        UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
          a1,
          *((void **)a0 + 17),
          *((_DWORD *)a0 + 36),
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 24LL),
          a2,
          nullptr);
        UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
          a1,
          *((void **)a0 + 17),
          *((_DWORD *)a0 + 36),
          *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 28LL),
          VertexBuffer,
          nullptr);
        UnityEngine_Rendering_CommandBuffer__DispatchCompute(
          a1,
          *((void **)a0 + 17),
          *((_DWORD *)a0 + 36),
          v13 + 1,
          1,
          1,
          nullptr);
      }
      else
      {
        v18 = (void *)sub_63CF120(v12, v10);
        Campus_Crowd_CrowdMeshRenderSystem__GetVertexCount(v18, v19);
      }
    }
  }
}

