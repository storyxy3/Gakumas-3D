// Campus.Crowd.CrowdSystemData$$SetPersonBuffers @ 0xddca8cc
void __fastcall Campus_Crowd_CrowdSystemData__SetPersonBuffers(void *a0, void *a1, void *a2, int a3, void *a4)
{
  bool v9; // w0
  __int64 v10; // x0

  if ( (unk_F43BD26 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD26 = 1;
  }
  if ( a1 )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    v9 = UnityEngine_Object__op_Equality(a2, nullptr, nullptr);
    if ( (a3 & 0x80000000) == 0 && !v9 )
    {
      v10 = Campus_Crowd_CrowdSystemData_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
        v10 = Campus_Crowd_CrowdSystemData_TypeInfo;
      }
      UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
        a1,
        a2,
        a3,
        *(_DWORD *)(*(_QWORD *)(v10 + 184) + 16LL),
        *((void **)a0 + 3),
        nullptr);
      UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
        a1,
        a2,
        a3,
        *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 20LL),
        *((void **)a0 + 5),
        nullptr);
      UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
        a1,
        a2,
        a3,
        *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 24LL),
        *((void **)a0 + 6),
        nullptr);
    }
  }
}

