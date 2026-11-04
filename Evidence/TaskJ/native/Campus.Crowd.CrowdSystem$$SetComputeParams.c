// Campus.Crowd.CrowdSystem$$SetComputeParams @ 0xddc9e30
void __fastcall Campus_Crowd_CrowdSystem__SetComputeParams(
        void *a0,
        void *a1,
        void *a2,
        UnityEngine_Vector3_o a3,
        float a4,
        UnityEngine_Vector3_o a5,
        UnityEngine_Vector3_o a6,
        UnityEngine_Vector4_o a7,
        void *a8)
{
  float x; // s13
  float y; // s14
  float v11; // s8
  float z; // s11
  float v14; // s12
  __int64 v17; // x0
  float v18; // [xsp+Ch] [xbp+Ch]
  __int64 v19; // [xsp+80h] [xbp+80h]
  float v20; // [xsp+88h] [xbp+88h]
  __int64 v21; // [xsp+90h] [xbp+90h]
  __int64 v22; // [xsp+98h] [xbp+98h]
  UnityEngine_Vector4_o v23; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v24; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v25; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v26; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  x = a3.x;
  y = a5.y;
  v11 = a5.x;
  z = a3.z;
  v14 = a3.y;
  v18 = a5.z;
  if ( (unk_F43BD18 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD18 = 1;
  }
  if ( a1 )
  {
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) )
    {
      v17 = Campus_Crowd_CrowdSystem_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_CrowdSystem_TypeInfo);
        v17 = Campus_Crowd_CrowdSystem_TypeInfo;
      }
      v23.x = x;
      v23.y = v14;
      v23.z = z;
      v23.w = a4;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(a1, a2, **(_DWORD **)(v17 + 184), v23, nullptr);
      v24.w = 0.0;
      v24.x = v11;
      v24.y = y;
      v24.z = v18;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(
        a1,
        a2,
        *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 4LL),
        v24,
        nullptr);
      v25.w = 0.0;
      *(_QWORD *)&v25.x = v19;
      v25.z = v20;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(
        a1,
        a2,
        *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 8LL),
        v25,
        nullptr);
      *(_QWORD *)&v26.x = v21;
      *(_QWORD *)&v26.z = v22;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(
        a1,
        a2,
        *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 12LL),
        v26,
        nullptr);
    }
  }
}

