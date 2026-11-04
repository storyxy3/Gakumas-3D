// Campus.Crowd.CrowdAnimationComponent$$get_ProjectionUvRectMax @ 0xddc009c
UnityEngine_Vector2_o __fastcall Campus_Crowd_CrowdAnimationComponent__get_ProjectionUvRectMax(void *a0, void *a1)
{
  __int64 v2; // x8
  UnityEngine_Vector2_o result; // 0:s0.4,4:s1.4

  if ( !byte_F40034E[0] )
  {
    sub_63CEE78(&UnityEngine_Vector2_TypeInfo);
    byte_F40034E[0] = 1;
  }
  v2 = *(_QWORD *)(UnityEngine_Vector2_TypeInfo + 184LL);
  result.x = *(float *)(v2 + 8);
  result.y = *(float *)(v2 + 12);
  return result;
}

