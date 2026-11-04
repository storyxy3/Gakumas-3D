// 0xbd12a74 @ 0xbd12a74
UnityEngine_Quaternion_o __fastcall VL_VLDefaultActorController_object__object__object___GetAnimatedRotation(
        void *a0,
        void *a1)
{
  void *v2; // x19
  void *v3; // x20
  float *v4; // x8
  void *v9; // x0
  int v10; // w1
  void *v11; // x2
  void *v12; // x3
  UnityEngine_Quaternion_o bodyRotation; // 0:kr00_16.16
  UnityEngine_Quaternion_o result; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v2 = a0;
  if ( (unk_F41D651 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    a0 = (void *)sub_63CEE78(&StringLiteral_SetupAnimation___________);
    unk_F41D651 = 1;
  }
  if ( !v2 )
  {
LABEL_14:
    v9 = (void *)sub_63CF120(a0, a1);
    VL_VLDefaultActorController_object__object__object___TryGetHumanBodyBoneTransform(v9, v10, v11, v12);
    return result;
  }
  v3 = *((void **)v2 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v3, nullptr, nullptr) )
  {
    a0 = *((void **)v2 + 5);
    if ( a0 )
    {
      bodyRotation = UnityEngine_Animator__get_bodyRotation(a0, nullptr);
      result.x = bodyRotation.x;
      result.y = bodyRotation.y;
      result.z = bodyRotation.z;
      result.w = bodyRotation.w;
      return result;
    }
    goto LABEL_14;
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(StringLiteral_SetupAnimation___________, nullptr);
  if ( !byte_F40034E[366] )
  {
    sub_63CEE78(&UnityEngine_Quaternion_TypeInfo);
    byte_F40034E[366] = 1;
  }
  v4 = *(float **)(UnityEngine_Quaternion_TypeInfo + 184LL);
  result.x = *v4;
  result.y = v4[1];
  result.z = v4[2];
  result.w = v4[3];
  return result;
}

