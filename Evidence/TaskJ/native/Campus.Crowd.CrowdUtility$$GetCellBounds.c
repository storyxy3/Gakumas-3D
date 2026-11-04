// Campus.Crowd.CrowdUtility$$GetCellBounds @ 0xddc7c30
UnityEngine_Bounds_o *__fastcall Campus_Crowd_CrowdUtility__GetCellBounds(
        UnityEngine_Bounds_o *__return_ptr retstr,
        UnityEngine_Bounds_o *a0,
        int a1,
        UnityEngine_Vector4_o a2,
        void *a3)
{
  void *v5; // x4
  float w; // s8
  float z; // s9
  int v11; // w8
  float v12; // s1
  float32x2_t v13; // d4
  float v14; // s6
  float32x2_t v15; // d7
  float32x2_t v16; // d4
  float v17; // s1
  UnityEngine_Bounds_o *result; // x0
  __int64 v19; // x8
  float y; // [xsp+0h] [xbp+0h]
  float x; // [xsp+10h] [xbp+10h]
  _BYTE v22[24]; // [xsp+28h] [xbp+28h] BYREF
  __int64 v23; // [xsp+40h] [xbp+40h] BYREF
  __int64 v24; // [xsp+48h] [xbp+48h] BYREF

  w = a2.w;
  z = a2.z;
  y = a2.y;
  x = a2.x;
  if ( (unk_F43BD42 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdUtility_TypeInfo);
    unk_F43BD42 = 1;
  }
  v24 = 0;
  HIDWORD(v23) = 0;
  v11 = *(_DWORD *)(Campus_Crowd_CrowdUtility_TypeInfo + 228LL);
  *(_QWORD *)v22 = 0;
  *(_QWORD *)&v22[8] = 0;
  *(_QWORD *)&v22[16] = 0;
  if ( !v11 )
    sub_63CEFF4(Campus_Crowd_CrowdUtility_TypeInfo);
  Campus_Crowd_CrowdUtility__GetCellFromOctreeAddress(a1, (char *)&v24 + 4, &v24, (char *)&v23 + 4, v5);
  v12 = a0->e.z;
  v13.n64_u64[0] = *(unsigned __int64 *)&a0->e.x;
  v14 = (float)(v12 + v12) * 0.0625;
  v15.n64_u64[0] = vmul_f32(vadd_f32(v13, v13), vdup_n_s32(0x3D800000u)).n64_u64[0];
  v16.n64_u64[0] = vsub_f32(*(float32x2_t *)&a0->c.x, v13).n64_u64[0];
  v17 = a0->c.z - v12;
  *(float *)&v22[20] = v14 * 0.5;
  *(float32x2_t *)&v22[12] = vmul_f32(v15, (float32x2_t)0x3F0000003F000000LL);
  *(float *)&v22[8] = z + (float)((float)(v14 * (float)((float)SHIDWORD(v23) + 0.5)) + v17);
  *(float32x2_t *)v22 = vadd_f32(
                          (float32x2_t)__PAIR64__(LODWORD(y), LODWORD(x)),
                          vadd_f32(
                            vmul_f32(
                              v15,
                              vadd_f32(
                                vcvt_f32_s32((int32x2_t)__PAIR64__(v24, HIDWORD(v24))),
                                (float32x2_t)0x3F0000003F000000LL)),
                            v16));
  UnityEngine_Bounds__Expand((UnityEngine_Bounds_o *)v22, w * 4.0, nullptr);
  v19 = *(_QWORD *)&v22[16];
  *(_OWORD *)&retstr->c.x = *(_OWORD *)v22;
  *(_QWORD *)&retstr->e.y = v19;
  return result;
}

