// Campus.Crowd.CrowdSystemData$$SetPersonInfoBytes @ 0xddcad08
void __fastcall Campus_Crowd_CrowdSystemData__SetPersonInfoBytes(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0

  if ( (unk_F43BD28 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    unk_F43BD28 = 1;
  }
  if ( a1 )
  {
    v5 = Campus_Crowd_CrowdSystemData_TypeInfo;
    if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
      v5 = Campus_Crowd_CrowdSystemData_TypeInfo;
    }
    UnityEngine_MaterialPropertyBlock__SetBuffer_1(
      a1,
      *(_DWORD *)(*(_QWORD *)(v5 + 184) + 20LL),
      *((void **)a0 + 5),
      nullptr);
  }
}

