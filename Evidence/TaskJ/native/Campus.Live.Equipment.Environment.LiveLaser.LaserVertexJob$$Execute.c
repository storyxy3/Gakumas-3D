// Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$Execute @ 0xddb7764
void __fastcall Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__Execute(__int64 a0, void *a1)
{
  float32x4_t v2; // q0
  __int64 v4; // x8
  int32x2_t v5; // d1
  int8x16_t v6; // q5
  float32x2_t v7; // d3
  int v8; // w9
  int v9; // s20
  int32x2_t v10; // d6
  float v11; // s17
  float v12; // s18
  float32x2_t v13; // d4
  __int64 v14; // d1
  float32x2_t v15; // d19
  int v16; // s2
  int v17; // s4
  float v18; // s5
  float32x4_t v19; // q0
  float32x4_t v20; // q0
  __int64 v21; // x0
  void *v22; // x1
  void *UnsafePtr_LiveLaser_VertexLayout; // x0
  void *v24; // x2
  void *v25; // x3
  unsigned int v26; // w8

  if ( (unk_F43BC7A & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_LiveLaser_VertexLayout___);
    sub_63CEE78(&Unity_Mathematics_quaternion_TypeInfo);
    unk_F43BC7A = 1;
  }
  v4 = *(_QWORD *)a0 + 132LL * *(int *)(a0 + 32);
  v2.n128_u64[0] = *(_QWORD *)(v4 + 116);
  v5.n64_u64[0] = vmul_f32((float32x2_t)v2.n128_u64[0], (float32x2_t)v2.n128_u64[0]).n64_u64[0];
  v6 = vmulq_n_f32(*(float32x4_t *)(v4 + 4), *(float *)v4);
  v7.n64_u64[0] = *(unsigned __int64 *)(v4 + 124);
  v8 = *(_DWORD *)(v4 + 24);
  v9 = *(_DWORD *)(v4 + 36);
  v10.n64_u64[0] = vmul_f32(v7, v7).n64_u64[0];
  v11 = (float)*(int *)(v4 + 28);
  v12 = (float)*(int *)(v4 + 32);
  v13.n64_u64[0] = vadd_f32(v5, vdup_lane_s32(v5, 1)).n64_u64[0];
  v14 = *(_QWORD *)(v4 + 40);
  v15.n64_u64[0] = vadd_f32(v10, v13).n64_u64[0];
  v17 = *(_DWORD *)(v4 + 48);
  v16 = *(_DWORD *)(v4 + 52);
  *(_DWORD *)(a0 + 80) = *(_DWORD *)(v4 + 20);
  *(int8x16_t *)(a0 + 60) = vandq_s8(v6, vcgtq_f32(v6, vdupq_n_s32(0x3B83126Fu)));
  v18 = vadd_f32(vdup_lane_s32(v10, 1), v15).n64_f32[0];
  *(_DWORD *)(a0 + 36) = (unsigned __int8)v8;
  *(_DWORD *)(a0 + 40) = BYTE1(v8);
  *(_DWORD *)(a0 + 48) = BYTE2(v8);
  *(float *)(a0 + 44) = v11 * 0.001;
  *(float *)(a0 + 52) = (float)v9;
  *(float *)(a0 + 56) = v12 * 0.001;
  if ( v18 <= 1.1755e-38 )
  {
    v20 = *(float32x4_t *)*(_QWORD *)(Unity_Mathematics_quaternion_TypeInfo + 184LL);
  }
  else
  {
    v19.n128_u64[0] = vnegq_f32(v2).n128_u64[0];
    v19.n128_f32[2] = -v7.n64_f32[0];
    v19.n128_u32[3] = v7.n64_u32[1];
    v20 = vmulq_n_f32(v19, 1.0 / v18);
  }
  *(float32x4_t *)(a0 + 120) = v20;
  if ( BYTE1(v8) )
  {
    *(_QWORD *)(a0 + 84) = v14;
    *(_DWORD *)(a0 + 92) = v17;
  }
  v21 = *(_QWORD *)(a0 + 16);
  v22 = *(void **)(a0 + 24);
  *(_DWORD *)(a0 + 76) = v16;
  UnsafePtr_LiveLaser_VertexLayout = Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_LiveLaser_VertexLayout_(
                                       v21,
                                       v22);
  v26 = *(_DWORD *)(a0 + 36);
  if ( v26 )
  {
    if ( v26 < 3 )
      Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__UpdateCone(
        a0,
        UnsafePtr_LiveLaser_VertexLayout,
        0,
        v25);
  }
  else
  {
    Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__UpdatePlane(a0, UnsafePtr_LiveLaser_VertexLayout, v24);
  }
}

