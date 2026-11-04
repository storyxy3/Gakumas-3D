// Campus.Crowd.CrowdVolume$$<BuildHierarchy>g__Create|16_0 @ 0xddcdd20
void *__fastcall Campus_Crowd_CrowdVolume___BuildHierarchy_g__Create_16_0(void *a0, void *a1, void *a2, void *a3)
{
  void *IsNullOrEmpty; // x0
  __int64 v8; // x1
  void *transform; // x22
  void *v10; // x22
  void *v12; // x0
  void *v13; // x1
  UnityEngine_Vector3_o Position; // 0:kr00_12.12
  UnityEngine_Quaternion_o rotation; // 0:kr10_16.16

  if ( (unk_F43BD4A & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_GameObject_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD4A = 1;
  }
  IsNullOrEmpty = (void *)System_String__IsNullOrEmpty(a1, nullptr);
  transform = nullptr;
  if ( ((unsigned __int8)IsNullOrEmpty & 1) != 0 )
    return transform;
  if ( a0 )
  {
    transform = UnityEngine_Transform__Find(a0, a1, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(transform, nullptr, nullptr) )
      return transform;
    v10 = (void *)sub_63CF110(UnityEngine_GameObject_TypeInfo);
    UnityEngine_GameObject___ctor(v10, a1, nullptr);
    IsNullOrEmpty = UnityEngine_Component__get_gameObject(a0, nullptr);
    if ( IsNullOrEmpty )
    {
      IsNullOrEmpty = (void *)UnityEngine_GameObject__get_layer(IsNullOrEmpty, nullptr);
      if ( v10 )
      {
        UnityEngine_GameObject__set_layer(v10, (int)IsNullOrEmpty, nullptr);
        transform = UnityEngine_GameObject__get_transform(v10, nullptr);
        Position = UnityEngine_Matrix4x4__GetPosition((UnityEngine_Matrix4x4_o *)a2, nullptr);
        rotation = UnityEngine_Matrix4x4__get_rotation((UnityEngine_Matrix4x4_o *)a2, nullptr);
        if ( transform )
        {
          UnityEngine_Transform__SetPositionAndRotation(transform, Position, rotation, nullptr);
          UnityEngine_Transform__SetParent_1(transform, a0, 0, nullptr);
          return transform;
        }
      }
    }
  }
  v12 = (void *)sub_63CF120(IsNullOrEmpty, v8);
  return (void *)Campus_AudiencePenlight_AudiencePenlightComponent__get_HidePenlight(v12, v13);
}

