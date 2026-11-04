// 0xd1d5e20 @ 0xd1d5e20
float __fastcall ProFlareUpdateJob__Angle(__int64 a0, __int64 a1, __int64 a2, void *a3)
{
  unsigned int v4; // s0
  float v5; // s1
  unsigned int v6; // s2
  unsigned __int64 v7; // d3
  float v8; // s4
  unsigned __int32 v9; // s5
  float32x2_t v10; // d0
  float32x2_t v11; // d3
  float32x2_t v12; // d1
  int32x2_t v17; // d1
  unsigned __int64 v18; // d0
  float v19; // s0
  double v21; // d2
  double v23; // d0
  double v24; // d0
  unsigned int v27; // [xsp+0h] [xbp+0h]
  unsigned int v28; // [xsp+10h] [xbp+10h]
  unsigned __int32 v29; // [xsp+20h] [xbp+20h]
  int8x8_t v30; // [xsp+30h] [xbp+30h]
  float v31; // [xsp+40h] [xbp+40h]
  float v32; // [xsp+50h] [xbp+50h]

  v29 = v9;
  v30.n64_u64[0] = v7;
  v27 = v4;
  v28 = v6;
  v31 = v5;
  v32 = v8;
  if ( !byte_F4004BE[0] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004BE[0] = 1;
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
  {
    sub_63CEFF4(System_Math_TypeInfo);
    if ( !byte_F4004BE[0] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004BE[0] = 1;
    }
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  if ( !unk_F42C954 )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    unk_F42C954 = 1;
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v10.n64_u64[0] = __PAIR64__(v27, v30.n64_u32[0]);
  v11.n64_u64[0] = vmul_f32(v10, v10).n64_u64[0];
  v10.n64_u32[0] = v29;
  v12.n64_u64[0] = vadd_f32(
                     v11,
                     vmul_f32(
                       (float32x2_t)__PAIR64__(LODWORD(v31), LODWORD(v32)),
                       (float32x2_t)__PAIR64__(LODWORD(v31), LODWORD(v32)))).n64_u64[0];
  __asm { FMOV            V3.2S, #1.0 }
  v17.n64_u64[0] = vdiv_f32(
                     _D3,
                     vsqrt_f32(vadd_f32(vmul_f32((float32x2_t)__PAIR64__(v28, v29), (float32x2_t)__PAIR64__(v28, v29)), v12))).n64_u64[0];
  v18 = vmul_f32(vmul_f32(v10, v17), vmul_f32(vext_s8((int8x8_t)__PAIR64__(v28, v29), v30, 4u), vrev64_s32(v17))).n64_u64[0];
  v19 = *(float *)&v18
      + (float)(*((float *)&v18 + 1) + (float)(vmuls_lane_f32(v31, v17, 1) * (float)(v32 * v17.n64_f32[0])));
  if ( (LODWORD(v19) & 0x7FFFFFFFu) > 0x7F800000 || v19 > 1.0 )
    v19 = 1.0;
  v21 = v19;
  _NF = (LODWORD(v19) & 0x7FFFFFFFu) > 0x7F800000 || v19 < -1.0;
  v23 = -1.0;
  if ( !_NF )
    v23 = v21;
  v24 = acos(v23) * 57.2957795;
  if ( v24 < 1.0e-15 )
    return 0.0;
  return v24;
}

