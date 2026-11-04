// Campus.Crowd.CrowdSortJob$$IsCulledBoundingSphere @ 0xddc9120
bool __fastcall Campus_Crowd_CrowdSortJob__IsCulledBoundingSphere(__int64 a0, __int64 a1, void *a2)
{
  return VL_Rendering_CameraPlanes__TestBoundingSphere(a0 + 80, 0, a2);
}

