// Campus.Crowd.CrowdModelData$$get_BoundingSphere @ 0xddc38d8
UnityEngine_Vector4_o __fastcall Campus_Crowd_CrowdModelData__get_BoundingSphere(void *a0, void *a1)
{
  UnityEngine_Vector4_o result; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  result.x = *((float *)a0 + 26);
  result.y = *((float *)a0 + 27);
  result.z = *((float *)a0 + 28);
  result.w = *((float *)a0 + 29);
  return result;
}

