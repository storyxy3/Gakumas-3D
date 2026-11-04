// Campus.Crowd.CrowdSystemData$$.cctor @ 0xddcbb60
void __fastcall Campus_Crowd_CrowdSystemData___cctor(void *a0)
{
  int v1; // w2
  int v2; // w3
  int v3; // w4
  void *v4; // x5
  __int64 v5; // x1
  __int64 v6; // x0
  int v7; // w0
  void *v8; // x8
  int v9; // w0
  void *v10; // x8
  int v11; // w0
  void *v12; // x8
  int v13; // w0
  void *v14; // x8
  int v15; // w0
  void *v16; // x8
  int v17; // w0
  void *v18; // x8

  if ( (unk_F43BD2F & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&StringLiteral__VisiblePersonCount);
    sub_63CEE78(&StringLiteral__BoundingMin);
    sub_63CEE78(&StringLiteral__PersonInfoBuffer);
    sub_63CEE78(&StringLiteral__NonBillboardPersonCount);
    sub_63CEE78(&StringLiteral_UpdatePerson);
    sub_63CEE78(&StringLiteral__PenlightInfoBuffer);
    sub_63CEE78(&StringLiteral__PersonIndexBuffer);
    sub_63CEE78(&StringLiteral__PersonInfoBytesBuffer);
    unk_F43BD2F = 1;
  }
  v5 = StringLiteral_UpdatePerson;
  v6 = *(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL);
  *(_DWORD *)v6 = 16;
  *(_QWORD *)(v6 + 8) = v5;
  sub_63CEE24((void *)(v6 + 8), v5, v1, v2, v3, v4);
  v7 = UnityEngine_Shader__PropertyToID(StringLiteral__PersonInfoBuffer, nullptr);
  v8 = (void *)StringLiteral__PersonInfoBytesBuffer;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 16LL) = v7;
  v9 = UnityEngine_Shader__PropertyToID(v8, nullptr);
  v10 = (void *)StringLiteral__PersonIndexBuffer;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 20LL) = v9;
  v11 = UnityEngine_Shader__PropertyToID(v10, nullptr);
  v12 = (void *)StringLiteral__BoundingMin;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 24LL) = v11;
  v13 = UnityEngine_Shader__PropertyToID(v12, nullptr);
  v14 = (void *)StringLiteral__NonBillboardPersonCount;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 28LL) = v13;
  v15 = UnityEngine_Shader__PropertyToID(v14, nullptr);
  v16 = (void *)StringLiteral__VisiblePersonCount;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 32LL) = v15;
  v17 = UnityEngine_Shader__PropertyToID(v16, nullptr);
  v18 = (void *)StringLiteral__PenlightInfoBuffer;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 36LL) = v17;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 184LL) + 40LL) = UnityEngine_Shader__PropertyToID(
                                                                                     v18,
                                                                                     nullptr);
}

