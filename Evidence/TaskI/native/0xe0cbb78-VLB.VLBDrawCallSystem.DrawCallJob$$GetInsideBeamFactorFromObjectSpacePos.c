// VLB.VLBDrawCallSystem.DrawCallJob$$GetInsideBeamFactorFromObjectSpacePos @ 0xe0cbb78
float __fastcall VLB_VLBDrawCallSystem_DrawCallJob__GetInsideBeamFactorFromObjectSpacePos(
        __int64 a0,
        __int64 a1,
        float a2,
        float a3,
        void *a4)
{
  float v5; // s2
  float v6; // s3
  float v7; // s4
  float v9; // s1
  float v10; // s8
  float v11; // s9
  float v12; // s10
  float v14; // s11
  float v15; // s9
  float v16; // s9
  float v17; // s8
  float v18; // s9
  float v19; // s8
  float v20; // s0
  float v21; // s0

  v9 = -1.0;
  if ( v5 >= 0.0 )
  {
    v10 = v7;
    v11 = v6;
    v12 = v5;
    if ( !byte_F4004BE[0] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004BE[0] = 1;
    }
    if ( *(_DWORD *)(System_Math_TypeInfo + 228LL) )
    {
      v14 = sqrtf((float)(a2 * a2) + (float)(a3 * a3));
    }
    else
    {
      sub_63CEFF4(System_Math_TypeInfo);
      v14 = sqrtf((float)(a2 * a2) + (float)(a3 * a3));
      if ( !byte_F4004BE[0] )
      {
        sub_63CEE78(&System_Math_TypeInfo);
        byte_F4004BE[0] = 1;
      }
    }
    v15 = v12 + v11;
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    v16 = 1.0 / sqrtf((float)(v15 * v15) + (float)(v14 * v14));
    v17 = v10 * 0.017453;
    if ( !byte_F4004BE[1] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004BE[1] = 1;
    }
    v18 = v14 * v16;
    v19 = v17 * 0.5;
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    v20 = sin(v19);
    v21 = (float)(fabsf(v20) - fabsf(v18)) / 0.1;
    if ( (LODWORD(v21) & 0x7FFFFFFFu) > 0x7F800000 || v21 > 1.0 )
      v21 = 1.0;
    v9 = -1.0;
    if ( (LODWORD(v21) & 0x7FFFFFFFu) <= 0x7F800000 && v21 >= -1.0 )
      return v21;
  }
  return v9;
}

