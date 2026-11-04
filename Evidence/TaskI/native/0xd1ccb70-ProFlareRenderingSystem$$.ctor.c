// 0xd1ccb70 @ 0xd1ccb70
void __fastcall ProFlareRenderingSystem___ctor(void *a0, void *a1, void *a2, void *a3)
{
  _BOOL4 supportsComputeShaders; // w22
  void **v8; // x20
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  __int64 v17; // x1
  void *v18; // x0
  void *v19; // x23
  void *v20; // x23
  void *v21; // x21
  void *v22; // x20
  void *v23; // x0
  void *v24; // x1
  void *v25; // x2
  void *v26; // x3

  if ( (unk_F42C91D & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&ProFlareRenderingSystem_TypeInfo);
    unk_F42C91D = 1;
  }
  System_Object___ctor(a0, nullptr);
  supportsComputeShaders = UnityEngine_SystemInfo__get_supportsComputeShaders(nullptr);
  *((_QWORD *)a0 + 2) = a1;
  v8 = (void **)((char *)a0 + 16);
  sub_63CEE24((char *)a0 + 16, (int)a1, v9, v10, v11, v12);
  *((_QWORD *)a0 + 3) = a2;
  sub_63CEE24((char *)a0 + 24, (int)a2, v13, v14, v15, v16);
  v18 = *((void **)a0 + 3);
  if ( !v18 )
    goto LABEL_21;
  UnityEngine_Material__set_enableInstancing(v18, 1, nullptr);
  v19 = *v8;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v19, nullptr, nullptr) )
  {
    v20 = *v8;
    v18 = (void *)ProFlareRenderingSystem_TypeInfo;
    if ( !*(_DWORD *)(ProFlareRenderingSystem_TypeInfo + 228LL) )
      sub_63CEFF4(ProFlareRenderingSystem_TypeInfo);
    if ( !v20 )
      goto LABEL_21;
    if ( (supportsComputeShaders
        & UnityEngine_ComputeShader__HasKernel(
            v20,
            *(void **)(*(_QWORD *)(ProFlareRenderingSystem_TypeInfo + 184LL) + 8LL),
            nullptr)
        & 1) == 0 )
      return;
  }
  else if ( !supportsComputeShaders )
  {
    return;
  }
  v21 = *((void **)a0 + 3);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v21, nullptr, nullptr) )
  {
    v22 = *v8;
    v18 = (void *)ProFlareRenderingSystem_TypeInfo;
    if ( !*(_DWORD *)(ProFlareRenderingSystem_TypeInfo + 228LL) )
      sub_63CEFF4(ProFlareRenderingSystem_TypeInfo);
    if ( v22 )
    {
      *((_DWORD *)a0 + 10) = UnityEngine_ComputeShader__FindKernel(
                               v22,
                               *(void **)(*(_QWORD *)(ProFlareRenderingSystem_TypeInfo + 184LL) + 8LL),
                               nullptr);
      return;
    }
LABEL_21:
    v23 = (void *)sub_63CF120(v18, v17);
    ProFlareRenderingSystem__TryGetFlareData(v23, v24, v25, v26);
  }
}

