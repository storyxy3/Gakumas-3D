// 0xd1d6100 @ 0xd1d6100
UnityEngine_Color_o __fastcall ProFlareUpdateElementJob__GetElementColor(__int64 a0, void *a1, void *a2)
{
  float32x2_t v3; // d0
  UnityEngine_Color_o result; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v3.n64_u64[0] = vmul_f32(*(float32x2_t *)((char *)a1 + 24), *(float32x2_t *)((char *)a1 + 8)).n64_u64[0];
  result.b = *((float *)a1 + 8) * *((float *)a1 + 4);
  LODWORD(result.g) = v3.n64_u32[1];
  result.a = (float)((float)(*((float *)a1 + 9) * *((float *)a1 + 5)) + *((float *)a1 + 10)) * *((float *)a1 + 11);
  result.r = v3.n64_f32[0];
  return result;
}

