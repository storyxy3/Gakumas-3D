// Campus.Crowd.CrowdVolume$$UpdateParameters @ 0xddcdb54
void __fastcall Campus_Crowd_CrowdVolume__UpdateParameters(void *a0, void *a1)
{
  char *v3; // x20
  void *v4; // x21
  void *profile; // x0
  __int64 v6; // x1
  void *v7; // x0
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  void *v12; // x0
  void *v13; // x1

  if ( (unk_F43BD49 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeParameter_CrowdVolume__Override__);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeProfile_Add_Crowd___);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeProfile_TryGet_Crowd___);
    unk_F43BD49 = 1;
  }
  v3 = (char *)a0 + 120;
  v4 = *((void **)a0 + 15);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  profile = (void *)UnityEngine_Object__op_Equality(v4, nullptr, nullptr);
  if ( ((unsigned __int8)profile & 1) != 0 )
  {
    profile = UnityEngine_Rendering_Volume__get_profile(a0, nullptr);
    if ( !profile )
      goto LABEL_13;
    profile = (void *)UnityEngine_Rendering_VolumeProfile__TryGet_object_(
                        profile,
                        (char *)a0 + 120,
                        Method_UnityEngine_Rendering_VolumeProfile_TryGet_Crowd___);
    if ( ((unsigned __int8)profile & 1) == 0 )
    {
      profile = UnityEngine_Rendering_Volume__get_profile(a0, nullptr);
      if ( !profile )
        goto LABEL_13;
      v7 = UnityEngine_Rendering_VolumeProfile__Add_object_(
             profile,
             0,
             Method_UnityEngine_Rendering_VolumeProfile_Add_Crowd___);
      *(_QWORD *)v3 = v7;
      sub_63CEE24((char *)a0 + 120, (int)v7, v8, v9, v10, v11);
    }
  }
  if ( *(_QWORD *)v3 )
  {
    profile = *(void **)(*(_QWORD *)v3 + 56LL);
    if ( profile )
    {
      UnityEngine_Rendering_VolumeParameter_object___Override(
        profile,
        a0,
        Method_UnityEngine_Rendering_VolumeParameter_CrowdVolume__Override__);
      return;
    }
  }
LABEL_13:
  v12 = (void *)sub_63CF120(profile, v6);
  Campus_Crowd_CrowdVolume__OnDestroy(v12, v13);
}

