// Campus.Crowd.PenlightMeshRenderSystem$$SetupCompute @ 0xddca518
void __fastcall Campus_Crowd_PenlightMeshRenderSystem__SetupCompute(void *a0, void *a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v8; // x1
  __int64 v9; // x0
  void *v10; // x20
  void *v11; // x0
  void *v12; // x1
  void *v13; // x2

  if ( (unk_F43BD31 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
    unk_F43BD31 = 1;
  }
  *((_QWORD *)a0 + 7) = a1;
  sub_63CEE24((char *)a0 + 56, (int)a1, (int)a2, v3, v4, v5);
  v9 = Campus_Crowd_PenlightMeshRenderSystem_TypeInfo;
  v10 = *((void **)a0 + 7);
  if ( !*(_DWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 228LL) )
    sub_63CEFF4(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
  if ( v10 )
  {
    *((_DWORD *)a0 + 16) = UnityEngine_ComputeShader__FindKernel(
                             v10,
                             **(void ***)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL),
                             nullptr);
  }
  else
  {
    v11 = (void *)sub_63CF120(v9, v8);
    Campus_Crowd_CrowdSystemData__SetupCompute(v11, v12, v13);
  }
}

