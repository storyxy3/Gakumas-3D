// 0xe0cca14 @ 0xe0cca14
void *__fastcall VLB_GlobalMeshHD__Get(void *a0)
{
  void *v1; // x19
  _BOOL8 v2; // x0
  void *v3; // x1
  void *Instance; // x0
  __int64 v5; // x1
  void *v6; // x2
  void *ConeZ_Radii_DoubleCaps; // x0
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  void *v12; // x0
  void *v13; // x19
  void *result; // x0
  void *v15; // x0

  if ( (unk_F43DA13 & 1) == 0 )
  {
    sub_63CEE78(&VLB_GlobalMeshHD_TypeInfo);
    sub_63CEE78(&VLB_Consts_Internal_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43DA13 = 1;
  }
  v1 = **(void ***)(VLB_GlobalMeshHD_TypeInfo + 184LL);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v2 = UnityEngine_Object__op_Equality(v1, nullptr, nullptr);
  if ( !v2 )
    return **(void ***)(VLB_GlobalMeshHD_TypeInfo + 184LL);
  VLB_GlobalMeshHD__Destroy((void *)v2);
  Instance = VLB_Config__GetInstance(0, v3);
  if ( Instance )
  {
    ConeZ_Radii_DoubleCaps = VLB_MeshGenerator__GenerateConeZ_Radii_DoubleCaps(
                               1.0,
                               1.0,
                               1.0,
                               *((_DWORD *)Instance + 16),
                               1,
                               v6);
    **(_QWORD **)(VLB_GlobalMeshHD_TypeInfo + 184LL) = ConeZ_Radii_DoubleCaps;
    sub_63CEE24(*(void **)(VLB_GlobalMeshHD_TypeInfo + 184LL), (int)ConeZ_Radii_DoubleCaps, v8, v9, v10, v11);
    v12 = (void *)VLB_Consts_Internal_TypeInfo;
    v13 = **(void ***)(VLB_GlobalMeshHD_TypeInfo + 184LL);
    if ( !*(_DWORD *)(VLB_Consts_Internal_TypeInfo + 228LL) )
      sub_63CEFF4(VLB_Consts_Internal_TypeInfo);
    Instance = (void *)VLB_Consts_Internal__get_ProceduralObjectsHideFlags(v12);
    if ( v13 )
    {
      UnityEngine_Object__set_hideFlags(v13, (int)Instance, nullptr);
      return **(void ***)(VLB_GlobalMeshHD_TypeInfo + 184LL);
    }
  }
  v15 = (void *)sub_63CF120(Instance, v5);
  VLB_VLBDrawSystem___cctor(v15);
  return result;
}

