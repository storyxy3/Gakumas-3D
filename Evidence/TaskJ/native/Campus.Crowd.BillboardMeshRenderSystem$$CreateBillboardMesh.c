// Campus.Crowd.BillboardMeshRenderSystem$$CreateBillboardMesh @ 0xddc6f18
void *__fastcall Campus_Crowd_BillboardMeshRenderSystem__CreateBillboardMesh(void *a0, void *a1)
{
  __int64 v2; // x0
  __int64 v3; // x1
  int v4; // w2
  int v5; // w3
  unsigned int v6; // w8
  void *v7; // x19
  void *v8; // x20
  unsigned int v9; // w8
  void *v10; // x21
  void *v16; // x22
  void *result; // x0
  void *v18; // x0
  int v19; // w1
  int v20; // w2
  void *v21; // x3

  if ( (unk_F43BD06 & 1) == 0 )
  {
    sub_63CEE78(&int___TypeInfo);
    sub_63CEE78(&UnityEngine_Mesh_TypeInfo);
    sub_63CEE78(&Field__PrivateImplementationDetails__A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92);
    sub_63CEE78(&UnityEngine_Vector2___TypeInfo);
    sub_63CEE78(&UnityEngine_Vector3___TypeInfo);
    sub_63CEE78(&StringLiteral_Crowd_Billboard_Mesh);
    unk_F43BD06 = 1;
  }
  v2 = sub_63CEF64(UnityEngine_Vector3___TypeInfo, 4);
  if ( !v2 )
    goto LABEL_16;
  v6 = *(_DWORD *)(v2 + 24);
  v7 = (void *)v2;
  if ( !v6 )
    goto LABEL_15;
  *(_DWORD *)(v2 + 40) = 0;
  *(_QWORD *)(v2 + 32) = 0xBF0000003F000000LL;
  if ( v6 == 1 )
    goto LABEL_15;
  *(_DWORD *)(v2 + 52) = 0;
  *(_QWORD *)(v2 + 44) = 0x3F0000003F000000LL;
  if ( v6 <= 2 )
    goto LABEL_15;
  *(_DWORD *)(v2 + 64) = 0;
  *(_QWORD *)(v2 + 56) = 0x3F000000BF000000LL;
  if ( v6 == 3 )
    goto LABEL_15;
  *(_QWORD *)(v2 + 68) = 0xBF000000BF000000LL;
  *(_DWORD *)(v2 + 76) = 0;
  v8 = (void *)sub_63CEF64(int___TypeInfo, 6);
  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray_1(
    v8,
    Field__PrivateImplementationDetails__A493ECF28E33055ADFE6BC8CA3E34E8C596165C57BE7A385BF0A924C74806A92,
    nullptr);
  v2 = sub_63CEF64(UnityEngine_Vector2___TypeInfo, 4);
  if ( !v2 )
    goto LABEL_16;
  v9 = *(_DWORD *)(v2 + 24);
  v10 = (void *)v2;
  if ( !v9 )
    goto LABEL_15;
  *(_QWORD *)(v2 + 32) = 0;
  if ( v9 == 1 )
    goto LABEL_15;
  *(_QWORD *)(v2 + 40) = 0x3F80000000000000LL;
  if ( v9 <= 2 )
    goto LABEL_15;
  __asm { FMOV            V0.2S, #1.0 }
  *(_QWORD *)(v2 + 48) = _D0;
  if ( v9 == 3 )
  {
LABEL_15:
    sub_63CF128(v2, v3, v4, v5);
    goto LABEL_16;
  }
  *(_QWORD *)(v2 + 56) = 1065353216;
  v16 = (void *)sub_63CF110(UnityEngine_Mesh_TypeInfo);
  UnityEngine_Mesh___ctor(v16, nullptr);
  if ( v16 )
  {
    UnityEngine_Object__set_name(v16, StringLiteral_Crowd_Billboard_Mesh, nullptr);
    UnityEngine_Object__set_hideFlags(v16, 52, nullptr);
    UnityEngine_Mesh__SetVertices_3(v16, v7, nullptr);
    UnityEngine_Mesh__SetIndices(v16, v8, 0, 0, nullptr);
    UnityEngine_Mesh__SetUVs_9(v16, 0, v10, nullptr);
    UnityEngine_Mesh__RecalculateNormals(v16, nullptr);
    UnityEngine_Mesh__RecalculateTangents(v16, nullptr);
    UnityEngine_Mesh__UploadMeshData(v16, 1, nullptr);
    return v16;
  }
LABEL_16:
  v18 = (void *)sub_63CF120(v2, v3);
  Campus_Crowd_BillboardMeshRenderSystem__SetBillboardResolution(v18, v19, v20, v21);
  return result;
}

