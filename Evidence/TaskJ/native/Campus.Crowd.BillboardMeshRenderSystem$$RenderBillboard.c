// Campus.Crowd.BillboardMeshRenderSystem$$RenderBillboard @ 0xddc7650
void __fastcall Campus_Crowd_BillboardMeshRenderSystem__RenderBillboard(
        void *a0,
        void *a1,
        void *a2,
        void *a3,
        int a4,
        int a5,
        int a6,
        void *a7)
{
  __int64 v15; // x0
  int *v16; // x8
  __int64 v17; // x0
  int v18; // w25

  if ( (unk_F43BD04 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__CopyTo__);
    unk_F43BD04 = 1;
  }
  if ( a1 && a3 && a5 >= 1 && *((int *)a0 + 26) >= 1 && *((int *)a0 + 27) >= 1 )
  {
    if ( a6 == 1 )
    {
      v17 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
        v17 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
      }
      v16 = (int *)(*(_QWORD *)(v17 + 184) + 76LL);
    }
    else
    {
      if ( a6 )
      {
        v18 = -1;
        goto LABEL_19;
      }
      v15 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
        v15 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
      }
      v16 = (int *)(*(_QWORD *)(v15 + 184) + 80LL);
    }
    v18 = *v16;
LABEL_19:
    Unity_Collections_NativeArray_Matrix4x4___CopyTo(
      (__int64)a0 + 72,
      *((void **)a0 + 4),
      Method_Unity_Collections_NativeArray_Matrix4x4__CopyTo__);
    if ( !*(_DWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 228LL) )
      sub_63CEFF4(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    UnityEngine_MaterialPropertyBlock__SetInt(
      a3,
      *(_DWORD *)(*(_QWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL) + 8LL),
      a4,
      nullptr);
    UnityEngine_MaterialPropertyBlock__SetMatrixArray_2(
      a3,
      *(_DWORD *)(*(_QWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL) + 4LL),
      *((void **)a0 + 4),
      nullptr);
    UnityEngine_Rendering_CommandBuffer__DrawMeshInstancedProcedural(
      a1,
      *((void **)a0 + 2),
      0,
      a2,
      v18,
      a5,
      a3,
      nullptr);
  }
}

