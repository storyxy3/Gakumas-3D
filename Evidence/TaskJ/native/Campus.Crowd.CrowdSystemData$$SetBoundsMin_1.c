// 0xddcad84 @ 0xddcad84
void __fastcall Campus_Crowd_CrowdSystemData__SetBoundsMin_1(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0
  UnityEngine_Vector4_o v6; // 0:kr00_16.16

  if ( (unk_F43BD29 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    unk_F43BD29 = 1;
  }
  if ( a1 )
  {
    v5 = Campus_Crowd_CrowdSystemData_TypeInfo;
    if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
      v5 = Campus_Crowd_CrowdSystemData_TypeInfo;
    }
    *(float32x2_t *)&v6.x = vsub_f32(*(float32x2_t *)((char *)a0 + 152), *(float32x2_t *)((char *)a0 + 164));
    v6.z = *((float *)a0 + 40) - *((float *)a0 + 43);
    v6.w = 0.0;
    UnityEngine_MaterialPropertyBlock__SetVector_1(a1, *(_DWORD *)(*(_QWORD *)(v5 + 184) + 28LL), v6, nullptr);
  }
}

