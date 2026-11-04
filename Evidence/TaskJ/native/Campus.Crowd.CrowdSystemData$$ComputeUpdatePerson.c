// Campus.Crowd.CrowdSystemData$$ComputeUpdatePerson @ 0xddca08c
void __fastcall Campus_Crowd_CrowdSystemData__ComputeUpdatePerson(void *a0, void *a1, void *a2)
{
  void *v5; // x21
  void *v6; // x1
  int TotalSubMeshInstanceCount; // w23
  __int64 v8; // x1
  int v9; // w22
  void *v10; // x24
  int v11; // w21
  __int64 v12; // x0
  void *v13; // x3
  void *v14; // x0
  void *v15; // x4
  void *v16; // x4
  void *v17; // x0
  void *v18; // x1
  void *v19; // x2
  __int128 v20; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43BD23 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_Value__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD23 = 1;
  }
  v5 = *((void **)a0 + 18);
  v20 = 0u;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v5, nullptr, nullptr) && (*((_DWORD *)a0 + 50) & 0x80000000) == 0 )
  {
    v20 = *((_OWORD *)a0 + 8);
    if ( Unity_Collections_NativeReference_int___get_IsCreated(
           (__int64)&v20,
           Method_Unity_Collections_NativeReference_int__get_IsCreated__) )
    {
      TotalSubMeshInstanceCount = Campus_Crowd_CrowdSystemData__get_TotalSubMeshInstanceCount(a0, v6);
      v20 = *((_OWORD *)a0 + 8);
      v9 = Unity_Collections_NativeReference_int___get_Value(
             (__int64)&v20,
             Method_Unity_Collections_NativeReference_int__get_Value__)
         + TotalSubMeshInstanceCount;
      if ( v9 >= 1 )
      {
        v10 = *((void **)a0 + 18);
        if ( (_BYTE)v9 )
          v11 = ((unsigned int)v9 >> 8) + 1;
        else
          v11 = (unsigned int)v9 >> 8;
        v12 = Campus_Crowd_CrowdSystemData_TypeInfo;
        if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
          sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
        if ( a1 )
        {
          UnityEngine_Rendering_CommandBuffer__SetComputeIntParam(
            a1,
            v10,
            *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 32LL),
            TotalSubMeshInstanceCount,
            nullptr);
          Campus_Crowd_CrowdSystemData__SetBoundsMin(a0, a1, *((void **)a0 + 18), v13);
          Campus_Crowd_CrowdSystemData__SetVisiblePersonCount(v14, a1, *((void **)a0 + 18), v9, v15);
          Campus_Crowd_CrowdSystemData__SetPersonBuffers(a0, a1, *((void **)a0 + 18), *((_DWORD *)a0 + 50), v16);
          UnityEngine_Rendering_CommandBuffer__DispatchCompute(
            a1,
            *((void **)a0 + 18),
            *((_DWORD *)a0 + 50),
            v11,
            1,
            1,
            nullptr);
        }
        else
        {
          v17 = (void *)sub_63CF120(v12, v8);
          Campus_Crowd_CrowdSystem__ComputePenlight(v17, v18, v19);
        }
      }
    }
  }
}

