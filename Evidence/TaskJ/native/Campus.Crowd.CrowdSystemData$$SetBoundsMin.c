// 0xddca720 @ 0xddca720
void __fastcall Campus_Crowd_CrowdSystemData__SetBoundsMin(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v7; // x0
  UnityEngine_Vector4_o v8; // 0:kr00_16.16

  if ( (unk_F43BD24 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD24 = 1;
  }
  if ( a1 )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) )
    {
      v7 = Campus_Crowd_CrowdSystemData_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
        v7 = Campus_Crowd_CrowdSystemData_TypeInfo;
      }
      *(float32x2_t *)&v8.x = vsub_f32(*(float32x2_t *)((char *)a0 + 152), *(float32x2_t *)((char *)a0 + 164));
      v8.z = *((float *)a0 + 40) - *((float *)a0 + 43);
      v8.w = 0.0;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(
        a1,
        a2,
        *(_DWORD *)(*(_QWORD *)(v7 + 184) + 28LL),
        v8,
        nullptr);
    }
  }
}

