// Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$LookCamera @ 0xddb7d94
__int64 __fastcall Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__LookCamera(
        __int64 a0,
        __int64 a1,
        void *a2)
{
  float v3; // s12
  float v4; // s14
  float v5; // s15
  float v6; // s13
  float v7; // s0
  __int64 result; // x0
  __int64 v9; // [xsp+0h] [xbp+0h] BYREF
  __int64 v10; // [xsp+8h] [xbp+8h] BYREF

  v3 = *(float *)(a0 + 116);
  v4 = *(float *)(a0 + 104);
  v5 = *(float *)(a0 + 108);
  v6 = *(float *)(a0 + 96);
  if ( !byte_F4004BE[3] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004BE[3] = 1;
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  if ( !byte_F4004BE[1] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004BE[1] = 1;
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  if ( !byte_F4004F4[0] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004F4[0] = 1;
  }
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v7 = atan2((float)(v5 - v6), (float)(v3 - v4));
  sincos((float)(v7 * 0.5), (double *)&v10, (double *)&v9);
  return result;
}

