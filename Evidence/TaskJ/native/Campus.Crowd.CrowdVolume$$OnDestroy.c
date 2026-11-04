// Campus.Crowd.CrowdVolume$$OnDestroy @ 0xddcdc64
void __fastcall Campus_Crowd_CrowdVolume__OnDestroy(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x20
  void *profile; // x19

  if ( (unk_F43BD48 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD48 = 1;
  }
  v3 = *((void **)a0 + 15);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
  {
    v4 = *((void **)a0 + 15);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    UnityEngine_Object__DestroyImmediate_1(v4, nullptr);
  }
  profile = UnityEngine_Rendering_Volume__get_profile(a0, nullptr);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  UnityEngine_Object__DestroyImmediate_1(profile, nullptr);
}

