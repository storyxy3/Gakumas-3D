// Campus.Crowd.CrowdSystem$$Dispose @ 0xddc517c
void __fastcall Campus_Crowd_CrowdSystem__Dispose(void *a0, void *a1)
{
  void *v3; // x1
  void *v4; // x1
  void *v5; // x1
  void *v6; // x1

  if ( (unk_F43BD1D & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__Dispose___1);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__get_IsCreated__);
    unk_F43BD1D = 1;
  }
  if ( *((_QWORD *)a0 + 13) )
    Unity_Collections_NativeList_CellSortData___Dispose_1((__int64)a0 + 104, *((_QWORD *)a0 + 11), *((void **)a0 + 12));
  if ( !Unity_Jobs_JobHandle__get_IsCompleted((__int64)a0 + 88, nullptr) )
    Unity_Jobs_JobHandle__Complete((__int64)a0 + 88, nullptr);
  Campus_Crowd_CrowdSystem__DisposeCrowdMeshRenderSystem(a0, v3);
  Campus_Crowd_CrowdSystem__DisposeBillboardMeshRenderSystem(a0, v4);
  Campus_Crowd_CrowdSystem__DisposePenlightMeshRenderSystem(a0, v5);
  Campus_Crowd_CrowdSystem__DisposeCrowdSystemData(a0, v6);
}

