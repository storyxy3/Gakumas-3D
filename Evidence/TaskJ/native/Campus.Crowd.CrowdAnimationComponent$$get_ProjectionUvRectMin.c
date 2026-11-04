// Campus.Crowd.CrowdAnimationComponent$$get_ProjectionUvRectMin @ 0xddc005c
UnityEngine_Vector2_o __fastcall Campus_Crowd_CrowdAnimationComponent__get_ProjectionUvRectMin(void *a0, void *a1)
{
  float *v2; // x8
  UnityEngine_Vector2_o result; // 0:s0.4,4:s1.4

  if ( !byte_F400253[0] )
  {
    sub_63CEE78(&UnityEngine_Vector2_TypeInfo);
    byte_F400253[0] = 1;
  }
  v2 = *(float **)(UnityEngine_Vector2_TypeInfo + 184LL);
  result.x = *v2;
  result.y = v2[1];
  return result;
}

