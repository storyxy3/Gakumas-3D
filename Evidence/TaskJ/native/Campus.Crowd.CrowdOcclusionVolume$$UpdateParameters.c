// Campus.Crowd.CrowdOcclusionVolume$$UpdateParameters @ 0xddc3914
void __fastcall Campus_Crowd_CrowdOcclusionVolume__UpdateParameters(void *a0, void *a1)
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
  __int64 v12; // x8
  void *v13; // x20
  void *v14; // x0
  void *v15; // x1
  UnityEngine_Vector3_o position; // 0:s0.4,4:s1.4,8:s2.4

  if ( (unk_F43BCF2 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeParameter_Vector3__Override__);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeParameter_float__Override__);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeProfile_Add_Crowd___);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeProfile_TryGet_Crowd___);
    unk_F43BCF2 = 1;
  }
  v3 = (char *)a0 + 88;
  v4 = *((void **)a0 + 11);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  profile = (void *)UnityEngine_Object__op_Equality(v4, nullptr, nullptr);
  if ( ((unsigned __int8)profile & 1) != 0 )
  {
    profile = UnityEngine_Rendering_Volume__get_profile(a0, nullptr);
    if ( !profile )
      goto LABEL_16;
    profile = (void *)UnityEngine_Rendering_VolumeProfile__TryGet_object_(
                        profile,
                        (char *)a0 + 88,
                        Method_UnityEngine_Rendering_VolumeProfile_TryGet_Crowd___);
    if ( ((unsigned __int8)profile & 1) == 0 )
    {
      profile = UnityEngine_Rendering_Volume__get_profile(a0, nullptr);
      if ( !profile )
        goto LABEL_16;
      v7 = UnityEngine_Rendering_VolumeProfile__Add_object_(
             profile,
             0,
             Method_UnityEngine_Rendering_VolumeProfile_Add_Crowd___);
      *(_QWORD *)v3 = v7;
      sub_63CEE24((char *)a0 + 88, (int)v7, v8, v9, v10, v11);
    }
  }
  if ( *(_QWORD *)v3 )
  {
    profile = *(void **)(*(_QWORD *)v3 + 72LL);
    if ( profile )
    {
      UnityEngine_Rendering_VolumeParameter_float___Override(
        profile,
        *((float *)a0 + 20),
        Method_UnityEngine_Rendering_VolumeParameter_float__Override__);
      v12 = *((_QWORD *)a0 + 11);
      if ( v12 )
      {
        v13 = *(void **)(v12 + 64);
        profile = UnityEngine_Component__get_transform(a0, nullptr);
        if ( profile )
        {
          position = UnityEngine_Transform__get_position(profile, nullptr);
          if ( v13 )
          {
            UnityEngine_Rendering_VolumeParameter_Vector3___Override(
              v13,
              position,
              Method_UnityEngine_Rendering_VolumeParameter_Vector3__Override__);
            return;
          }
        }
      }
    }
  }
LABEL_16:
  v14 = (void *)sub_63CF120(profile, v6);
  Campus_Crowd_CrowdOcclusionVolume__OnDestroy(v14, v15);
}

