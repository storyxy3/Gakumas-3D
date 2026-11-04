// 0xe0ddc68 @ 0xe0ddc68
void *__fastcall VLB_GlobalMeshSD__Get(void *a0)
{
  void *Instance; // x0
  __int64 v2; // x1
  bool SD_requiresDoubleSidedMesh; // w19
  void *v4; // x20
  int v5; // w19
  _BOOL8 v6; // x0
  __int64 v7; // x8
  int v8; // w20
  void *ConeZ_Radii; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void *v14; // x20
  void *result; // x0
  void *v16; // x0

  if ( (unk_F43DA84 & 1) == 0 )
  {
    sub_63CEE78(&VLB_GlobalMeshSD_TypeInfo);
    sub_63CEE78(&VLB_Consts_Internal_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43DA84 = 1;
  }
  Instance = VLB_Config__get_Instance(nullptr);
  if ( Instance )
  {
    SD_requiresDoubleSidedMesh = VLB_Config__get_SD_requiresDoubleSidedMesh(Instance, nullptr);
    v4 = **(void ***)(VLB_GlobalMeshSD_TypeInfo + 184LL);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    v5 = SD_requiresDoubleSidedMesh;
    v6 = UnityEngine_Object__op_Equality(v4, nullptr, nullptr);
    if ( !v6 )
    {
      v7 = *(_QWORD *)(VLB_GlobalMeshSD_TypeInfo + 184LL);
      if ( *(unsigned __int8 *)(v7 + 8) == v5 )
        return *(void **)v7;
    }
    VLB_GlobalMeshSD__Destroy((void *)v6);
    Instance = VLB_Config__get_Instance(nullptr);
    if ( Instance )
    {
      v8 = *((_DWORD *)Instance + 16);
      Instance = VLB_Config__get_Instance(nullptr);
      if ( Instance )
      {
        ConeZ_Radii = VLB_MeshGenerator__GenerateConeZ_Radii(
                        1.0,
                        1.0,
                        1.0,
                        v8,
                        *((_DWORD *)Instance + 17),
                        0,
                        v5,
                        nullptr);
        **(_QWORD **)(VLB_GlobalMeshSD_TypeInfo + 184LL) = ConeZ_Radii;
        sub_63CEE24(*(void **)(VLB_GlobalMeshSD_TypeInfo + 184LL), (int)ConeZ_Radii, v10, v11, v12, v13);
        v14 = **(void ***)(VLB_GlobalMeshSD_TypeInfo + 184LL);
        if ( !*(_DWORD *)(VLB_Consts_Internal_TypeInfo + 228LL) )
          sub_63CEFF4(VLB_Consts_Internal_TypeInfo);
        Instance = (void *)VLB_Consts_Internal__get_ProceduralObjectsHideFlags(nullptr);
        if ( v14 )
        {
          UnityEngine_Object__set_hideFlags(v14, (int)Instance, nullptr);
          v7 = *(_QWORD *)(VLB_GlobalMeshSD_TypeInfo + 184LL);
          *(_BYTE *)(v7 + 8) = v5;
          return *(void **)v7;
        }
      }
    }
  }
  v16 = (void *)sub_63CF120(Instance, v2);
  VLB_GlobalMeshSD__Destroy(v16);
  return result;
}

