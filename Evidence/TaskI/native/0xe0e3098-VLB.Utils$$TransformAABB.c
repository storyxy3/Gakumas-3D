// 0xe0e3098 @ 0xe0e3098
UnityEngine_Bounds_o *__fastcall VLB_Utils__TransformAABB(
        UnityEngine_Bounds_o *__return_ptr retstr,
        UnityEngine_Bounds_o *a0,
        __int64 a1,
        void *a2)
{
  float y; // s2
  float x; // s5
  float v6; // s6
  float z; // s7
  float v8; // s16
  int32x2_t v9; // d20
  int8x8_t v10; // d30
  float v11; // s1
  float v12; // s3
  float v13; // s4
  float v14; // s5
  float v15; // s6
  float v16; // s7
  int32x2_t v17; // d0
  float v18; // s8
  float v19; // s2
  unsigned int v22; // w8
  float v23; // s25
  float v24; // s26
  float v26; // s27
  float v27; // s28
  float32x2_t v28; // d25
  float v29; // s26
  float32x2_t v30; // d25
  int32x2_t v31; // d28
  int32x2_t v32; // d29
  _BOOL4 v33; // w10
  uint32x2_t v34; // d27
  _BOOL4 v35; // w11
  int8x8_t v36; // d28
  int8x8_t v37; // d27
  void *v38; // x1
  UnityEngine_Bounds_o *result; // x0
  float v40; // s0
  float v41; // s1
  float v42; // s2
  __int64 v43; // x8
  __int128 v44; // q0
  UnityEngine_Vector3_o v45; // 0:kr00_12.12
  UnityEngine_Vector3_o v46; // 0:kr14_12.12

  y = a0->c.y;
  x = a0->e.x;
  v6 = a0->e.y;
  z = a0->c.z;
  v8 = a0->e.z;
  v9.n64_u64[0] = vdup_n_s32(0x7F800000u).n64_u64[0];
  v10.n64_u64[0] = 0x80000000800000LL;
  v11 = a0->c.x - x;
  v12 = y - v6;
  v13 = z - v8;
  v14 = a0->c.x + x;
  v15 = y + v6;
  v16 = z + v8;
  v17.n64_u64[0] = vdup_n_s32(0x7F7FFFFFu).n64_u64[0];
  v18 = -3.4028e38;
  v19 = 3.4028e38;
  v22 = 0;
  do
  {
    if ( (v22 & 1) != 0 )
      v23 = v14;
    else
      v23 = v11;
    if ( (v22 & 2) != 0 )
      v24 = v15;
    else
      v24 = v12;
    if ( v22++ >= 4 )
      v26 = v16;
    else
      v26 = v13;
    v27 = *(float *)(a1 + 8) * v23;
    v28.n64_u64[0] = vadd_f32(
                       vadd_f32(vmul_n_f32(*(float32x2_t *)a1, v23), vmul_n_f32(*(float32x2_t *)(a1 + 16), v24)),
                       vmul_n_f32(*(float32x2_t *)(a1 + 32), v26)).n64_u64[0];
    v29 = *(float *)(a1 + 56)
        + (float)((float)(v27 + (float)(*(float *)(a1 + 24) * v24)) + (float)(*(float *)(a1 + 40) * v26));
    v30.n64_u64[0] = vadd_f32(*(float32x2_t *)(a1 + 48), v28).n64_u64[0];
    v31.n64_u64[0] = vcgt_f32(v30, v17).n64_u64[0];
    v32.n64_u64[0] = vcgt_f32(v10, v30).n64_u64[0];
    v33 = v19 < v29;
    v34.n64_u64[0] = vcgt_u32(vabs_f32(v30), v9).n64_u64[0];
    if ( (LODWORD(v29) & 0x7FFFFFFFu) <= 0x7F800000 )
    {
      v35 = v18 > v29;
    }
    else
    {
      v33 = 1;
      v35 = 1;
    }
    v36.n64_u64[0] = vorr_s8(v31, v34).n64_u64[0];
    v37.n64_u64[0] = vorr_s8(v32, v34).n64_u64[0];
    if ( !v33 )
      v19 = v29;
    if ( !v35 )
      v18 = v29;
    v17.n64_u64[0] = vbsl_s8(v36, v17, v30).n64_u64[0];
    v10.n64_u64[0] = vbsl_s8(v37, v10, v30).n64_u64[0];
  }
  while ( v22 != 8 );
  v45 = Unity_Mathematics_float3__op_Implicit_2(0, (void *)a1);
  v46 = Unity_Mathematics_float3__op_Implicit_2(0, v38);
  v40 = (float)(v46.x - v45.x) * 0.5;
  v41 = (float)(v46.y - v45.y) * 0.5;
  v42 = (float)(v46.z - v45.z) * 0.5;
  a0->e.y = v41;
  a0->e.z = v42;
  v43 = *(_QWORD *)&a0->e.y;
  a0->c.x = v45.x + v40;
  a0->c.y = v45.y + v41;
  a0->c.z = v45.z + v42;
  a0->e.x = v40;
  v44 = *(_OWORD *)&a0->c.x;
  *(_QWORD *)&retstr->e.y = v43;
  *(_OWORD *)&retstr->c.x = v44;
  return result;
}

