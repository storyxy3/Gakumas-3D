// Campus.Crowd.CrowdSystemData$$SetupCompute @ 0xddca5b0
void __fastcall Campus_Crowd_CrowdSystemData__SetupCompute(void *a0, void *a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v8; // x1
  __int64 v9; // x0
  void *v10; // x20
  void *v11; // x0
  void *v12; // x1

  if ( (unk_F43BD21 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    unk_F43BD21 = 1;
  }
  *((_QWORD *)a0 + 18) = a1;
  sub_63CEE24((char *)a0 + 144, (int)a1, (int)a2, v3, v4, v5);
  v9 = Campus_Crowd_CrowdSystemData_TypeInfo;
  v10 = *((void **)a0 + 18);
  if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
    sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
  if ( v10 )
  {
    *((_DWORD *)a0 + 50) = UnityEngine_ComputeShader__FindKernel(
                             v10,
                             *(void **)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 8LL),
                             nullptr);
  }
  else
  {
    v11 = (void *)sub_63CF120(v9, v8);
    Campus_Crowd_CrowdVolume__get_CrowdPenlight(v11, v12);
  }
}

