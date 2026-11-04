// Campus.Crowd.CrowdVolume$$get_Position @ 0xddcd4a0
UnityEngine_Vector3_o __fastcall Campus_Crowd_CrowdVolume__get_Position(void *a0, void *a1)
{
  void *v3; // x20
  __int64 v4; // x1
  void *transform; // x0
  int v6; // w0
  void *v7; // x1
  void *v8; // x2
  void *v9; // x3
  void *v10; // x4
  UnityEngine_Vector3_o position; // 0:kr00_12.12
  UnityEngine_Vector3_o result; // 0:s0.4,4:s1.4,8:s2.4

  if ( (unk_F43BD44 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD44 = 1;
  }
  v3 = *((void **)a0 + 13);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
  {
    transform = *((void **)a0 + 13);
    if ( !transform )
      goto LABEL_11;
  }
  else
  {
    transform = a0;
  }
  transform = UnityEngine_Component__get_transform(transform, nullptr);
  if ( transform )
  {
    position = UnityEngine_Transform__get_position(transform, nullptr);
    result.x = position.x;
    result.y = position.y;
    result.z = position.z;
    return result;
  }
LABEL_11:
  v6 = sub_63CF120(transform, v4);
  Campus_Crowd_CrowdUtility__GetCellFromOctreeAddress(v6, v7, v8, v9, v10);
  return result;
}

