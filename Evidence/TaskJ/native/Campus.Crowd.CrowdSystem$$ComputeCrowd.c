// Campus.Crowd.CrowdSystem$$ComputeCrowd @ 0xddc61bc
void __fastcall Campus_Crowd_CrowdSystem__ComputeCrowd(void *a0, void *a1, void *a2)
{
  void *v5; // x1
  void *v6; // x2
  void *v7; // x0
  void *v8; // x0

  Unity_Jobs_JobHandle__Complete((__int64)a0 + 88, nullptr);
  v7 = *((void **)a0 + 10);
  if ( v7 )
  {
    Campus_Crowd_CrowdSystemData__UpdatePersonIndexBuffer(v7, v5, v6);
    v8 = *((void **)a0 + 10);
    if ( v8 )
      Campus_Crowd_CrowdSystemData__ComputeUpdatePerson(v8, a1, v6);
  }
  Campus_Crowd_CrowdSystem__ComputePenlight(a0, a1, v6);
}

