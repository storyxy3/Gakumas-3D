// Campus.Live.Equipment.Environment.LiveLaser$$OnApply @ 0xddb72dc
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__OnApply(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0
  void *v6; // x21
  int8x16_t v7; // q0
  int v8; // w8
  int v9; // w8
  void *v10; // x1
  void *transform; // x0
  void *v12; // x21
  void *v13; // x21
  void *v14; // x0
  __int64 v15; // x1
  __int64 v16; // x2
  void *v17; // x3
  float v18; // s0
  float v19; // s1
  UnityEngine_Color_o v20; // 0:s2.4,4:s3.4,8:s4.4,12:s5.4

  if ( (unk_F43BC79 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BC79 = 1;
  }
  v5 = UnityEngine_Object_TypeInfo;
  v6 = *((void **)a0 + 7);
  *((_DWORD *)a0 + 20) = *((_DWORD *)a1 + 5);
  v7 = vmulq_n_f32(*(float32x4_t *)((char *)a1 + 4), *(float *)a1);
  *(int8x16_t *)((char *)a0 + 84) = vandq_s8(v7, vcgtq_f32(v7, vdupq_n_s32(0x3B83126Fu)));
  v8 = *((_DWORD *)a1 + 6);
  *((_DWORD *)a0 + 18) = (unsigned __int8)v8;
  *((_DWORD *)a0 + 19) = BYTE1(v8);
  *((_DWORD *)a0 + 25) = BYTE2(v8);
  v9 = *(_DWORD *)(v5 + 228);
  *(float32x2_t *)((char *)a0 + 108) = vmul_f32(vcvt_f32_s32(*(int32x2_t *)((char *)a1 + 28)), vdup_n_s32(0x3A83126Fu));
  v7.n128_f32[0] = (float)*((int *)a1 + 9);
  *((_DWORD *)a0 + 29) = *((_DWORD *)a1 + 13);
  *((_DWORD *)a0 + 26) = v7.n128_u32[0];
  if ( !v9 )
    sub_63CEFF4(v5);
  if ( UnityEngine_Object__op_Inequality(v6, nullptr, nullptr) )
  {
    transform = *((void **)a0 + 7);
    if ( !transform )
      goto LABEL_20;
    UnityEngine_Transform__set_localRotation(transform, *(UnityEngine_Quaternion_o *)((char *)a1 + 84), nullptr);
  }
  v12 = *((void **)a0 + 8);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v12, nullptr, nullptr) )
  {
    transform = *((void **)a0 + 8);
    if ( !transform )
      goto LABEL_20;
    UnityEngine_Transform__set_localRotation(transform, *(UnityEngine_Quaternion_o *)((char *)a1 + 100), nullptr);
  }
  v13 = *((void **)a0 + 6);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Inequality(v13, nullptr, nullptr) )
    goto LABEL_19;
  transform = *((void **)a0 + 6);
  if ( transform )
  {
    transform = UnityEngine_Component__get_transform(transform, nullptr);
    if ( transform )
    {
      UnityEngine_Transform__set_localRotation(transform, *(UnityEngine_Quaternion_o *)((char *)a1 + 116), nullptr);
LABEL_19:
      Campus_Live_Equipment_Environment_LiveLaser__UpdateMesh(a0, v10);
      return;
    }
  }
LABEL_20:
  v14 = (void *)sub_63CF120(transform, v10);
  Campus_Live_Equipment_Environment_LiveLaser__UpdateLaserVertex(v14, v15, v18, v19, v20, v16, v17);
}

