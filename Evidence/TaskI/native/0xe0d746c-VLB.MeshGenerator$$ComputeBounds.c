// 0xe0d746c @ 0xe0d746c
// local variable allocation has failed, the output may be wrong!
UnityEngine_Bounds_o *__fastcall VLB_MeshGenerator__ComputeBounds(
        UnityEngine_Bounds_o *__return_ptr retstr,
        float a0,
        float a1,
        float a2,
        void *a3)
{
  float v5; // v0.s[1]
  int32x4_t v6; // q0

  *(_QWORD *)&retstr->c.z = 0;
  *(_QWORD *)&retstr->e.y = 0;
  *(_QWORD *)&retstr->c.x = 0;
  if ( a1 <= a2 )
    a1 = a2;
  v5 = a1 + a1;
  v6.n128_u64[0] = vmul_f32(*(float32x2_t *)&a0, (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
  *(int32x4_t *)&retstr->c.z = vzip1q_s32(v6, vrev64q_s32(v6));
  return (UnityEngine_Bounds_o *)a3;
}

