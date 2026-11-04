// Campus.Crowd.CrowdSortJob$$IsCulledOcclusionSphere @ 0xddc9140
bool __fastcall Campus_Crowd_CrowdSortJob__IsCulledOcclusionSphere(__int64 a0, __int64 a1, void *a2)
{
  float v3; // s0
  float v4; // s1
  float v5; // s2
  float v6; // s3

  v6 = *(float *)(a0 + 204);
  return v6 > 0.0
      && (float)((float)((float)(*(float *)(a0 + 200) - v5) * (float)(*(float *)(a0 + 200) - v5))
               + (float)((float)((float)(*(float *)(a0 + 196) - v4) * (float)(*(float *)(a0 + 196) - v4))
                       + (float)((float)(*(float *)(a0 + 192) - v3) * (float)(*(float *)(a0 + 192) - v3)))) <= (float)(v6 * v6);
}

