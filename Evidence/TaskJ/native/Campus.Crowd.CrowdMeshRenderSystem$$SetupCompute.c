// Campus.Crowd.CrowdMeshRenderSystem$$SetupCompute @ 0xddc8240
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__SetupCompute(void *a0, void *a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v8; // x1
  __int64 v9; // x0
  void *v10; // x20

  if ( (unk_F43BD0A & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    unk_F43BD0A = 1;
  }
  *((_QWORD *)a0 + 17) = a1;
  sub_63CEE24((char *)a0 + 136, (int)a1, (int)a2, v3, v4, v5);
  v9 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
  v10 = *((void **)a0 + 17);
  if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
    sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
  if ( !v10 )
  {
    sub_63CF120(v9, v8);
    JUMPOUT(0xDDC82D8);
  }
  *((_DWORD *)a0 + 36) = UnityEngine_ComputeShader__FindKernel(
                           v10,
                           **(void ***)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL),
                           nullptr);
}

