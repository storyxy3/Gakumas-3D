// 0xe0e3254 @ 0xe0e3254
__int64 __fastcall VLB_Utils__GetPlane(UnityEngine_Vector4_o a0, void *a1)
{
  float y; // s10
  float x; // s11
  float z; // s9
  float v5; // s12
  float v6; // s11
  __int64 result; // x0
  float v8; // s10
  float v9; // s9

  y = a0.y;
  x = a0.x;
  z = a0.z;
  v5 = sqrtf((float)(a0.z * a0.z) + (float)((float)(a0.x * a0.x) + (float)(a0.y * a0.y)));
  if ( !byte_F40034E[226] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F40034E[226] = 1;
  }
  v6 = x / v5;
  result = System_Math_TypeInfo;
  v8 = y / v5;
  v9 = z / v5;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  if ( sqrtf((float)(v9 * v9) + (float)((float)(v6 * v6) + (float)(v8 * v8))) <= 0.00001 && !byte_F40009D[0] )
  {
    result = sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    byte_F40009D[0] = 1;
  }
  return result;
}

