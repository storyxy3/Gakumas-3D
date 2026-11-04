// Campus.Crowd.CrowdSystemData$$SetVisiblePersonCount @ 0xddca804
void __fastcall Campus_Crowd_CrowdSystemData__SetVisiblePersonCount(void *a0, void *a1, void *a2, int a3, void *a4)
{
  __int64 v8; // x0

  if ( (unk_F43BD25 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD25 = 1;
  }
  if ( a1 )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) )
    {
      v8 = Campus_Crowd_CrowdSystemData_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
        v8 = Campus_Crowd_CrowdSystemData_TypeInfo;
      }
      UnityEngine_Rendering_CommandBuffer__SetComputeIntParam(
        a1,
        a2,
        *(_DWORD *)(*(_QWORD *)(v8 + 184) + 36LL),
        a3,
        nullptr);
    }
  }
}

