// 0xbd12970 @ 0xbd12970
UnityEngine_Vector3_o __fastcall VL_VLDefaultActorController_object__object__object___GetAnimatedPosition(
        void *a0,
        void *a1)
{
  void *v2; // x19
  void *v3; // x20
  float *v4; // x8
  void *v8; // x0
  void *v9; // x1
  UnityEngine_Vector3_o bodyPosition; // 0:kr00_12.12
  UnityEngine_Quaternion_o AnimatedRotation; // 0:kr10_16.16
  UnityEngine_Vector3_o result; // 0:s0.4,4:s1.4,8:s2.4

  v2 = a0;
  if ( (unk_F41D650 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    a0 = (void *)sub_63CEE78(&StringLiteral_SetupAnimation___________);
    unk_F41D650 = 1;
  }
  if ( !v2 )
  {
LABEL_14:
    v8 = (void *)sub_63CF120(a0, a1);
    AnimatedRotation = VL_VLDefaultActorController_object__object__object___GetAnimatedRotation(v8, v9);
    result.x = AnimatedRotation.x;
    result.y = AnimatedRotation.y;
    result.z = AnimatedRotation.z;
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
      bodyPosition = UnityEngine_Animator__get_bodyPosition(a0, nullptr);
      result.x = bodyPosition.x;
      result.y = bodyPosition.y;
      result.z = bodyPosition.z;
      return result;
    }
    goto LABEL_14;
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(StringLiteral_SetupAnimation___________, nullptr);
  if ( !byte_F40009D[0] )
  {
    sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    byte_F40009D[0] = 1;
  }
  v4 = *(float **)(UnityEngine_Vector3_TypeInfo + 184LL);
  result.x = *v4;
  result.y = v4[1];
  result.z = v4[2];
  return result;
}

