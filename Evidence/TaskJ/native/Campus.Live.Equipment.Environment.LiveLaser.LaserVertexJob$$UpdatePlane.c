// Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$UpdatePlane @ 0xddb78f8
void __fastcall Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__UpdatePlane(__int64 a0, void *a1, void *a2)
{
  int v3; // w8
  float v6; // s1
  __int64 v7; // x23
  __int64 v8; // x21
  float v9; // s1
  float v10; // s3
  float v11; // s0
  float v12; // s11
  float v13; // s12
  float v14; // s1
  float v15; // s3
  float v16; // s13
  float v17; // s2
  void *v18; // x2
  __int64 v19; // x1
  __int64 v20; // x2
  void *v21; // x3
  float v22; // [xsp+2Ch] [xbp+2Ch]
  float v23; // [xsp+30h] [xbp+30h]
  float v24; // [xsp+34h] [xbp+34h]
  float v25; // [xsp+38h] [xbp+38h]
  float v26; // [xsp+3Ch] [xbp+3Ch]
  double v27; // [xsp+40h] [xbp+40h] BYREF
  double v28; // [xsp+48h] [xbp+48h] BYREF
  UnityEngine_Color_o v29; // 0:s2.4,4:s3.4,8:s4.4,12:s5.4

  v3 = *(_DWORD *)(a0 + 48);
  if ( v3 >= 2 )
  {
    v6 = *(float *)(a0 + 52);
    v22 = v6 / (float)(v3 - 1);
    v23 = v6 * -0.5;
  }
  else
  {
    v22 = 0.0;
    v23 = 0.0;
    if ( v3 != 1 )
      return;
  }
  v7 = 0;
  v8 = 0;
  do
  {
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
    sincos((float)((float)((float)(v23 + (float)(v22 * (float)(int)v8)) * 0.017453) * 0.5), &v28, &v27);
    v9 = v28;
    v10 = v27;
    v11 = sub_DDC0A2C(a0, 0, v9 * 0.0, v9, v9 * 0.0, v10);
    v12 = *(float *)(a0 + 44);
    v13 = *(float *)(a0 + 56);
    v25 = v14;
    v26 = v11;
    v16 = v15;
    v24 = v17;
    Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__GetLaserColor(a0, v8, v18);
    fmodf(*(float *)(a0 + 80) * *(float *)(a0 + 76), 1.0);
    v29.g = v16;
    v29.b = v12;
    v29.a = v13;
    v29.r = v24;
    Campus_Live_Equipment_Environment_LiveLaser__UpdateLaserVertex(
      (char *)a1 + 44 * SHIDWORD(v7),
      v19,
      v26,
      v25,
      v29,
      v20,
      v21);
    ++v8;
    v7 += 0xF00000000LL;
  }
  while ( v8 < *(int *)(a0 + 48) );
}

