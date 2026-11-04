// Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$UpdateCone @ 0xddb7b04
void __fastcall Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__UpdateCone(
        __int64 a0,
        void *a1,
        bool a2,
        void *a3)
{
  __int64 v4; // x27
  __int64 v7; // x23
  __int64 v8; // x21
  int v9; // w8
  float v10; // s8
  double v11; // d8
  double v12; // d9
  float v13; // s0
  float v14; // s0
  double v15; // d10
  float v16; // s8
  float v17; // s0
  float v18; // s0
  float v19; // s1
  float v20; // s2
  float v21; // s3
  float v22; // s0
  float v23; // s12
  float v24; // s13
  float v25; // s1
  float v26; // s3
  float v27; // s14
  float v28; // s2
  void *v29; // x2
  __int64 v30; // x1
  __int64 v31; // x2
  void *v32; // x3
  float v33; // [xsp+2Ch] [xbp+2Ch]
  float v34; // [xsp+30h] [xbp+30h]
  float v35; // [xsp+34h] [xbp+34h]
  float v36; // [xsp+38h] [xbp+38h]
  float v37; // [xsp+3Ch] [xbp+3Ch]
  UnityEngine_Color_o v38; // 0:s2.4,4:s3.4,8:s4.4,12:s5.4

  LODWORD(v4) = *(_DWORD *)(a0 + 48);
  if ( (int)v4 >= 1 )
  {
    v7 = 0;
    v8 = 0;
    v33 = 1.0;
    v34 = 0.0;
    do
    {
      v9 = byte_F4004BE[1];
      if ( (int)v4 >= 2 )
      {
        v10 = *(float *)(a0 + 52);
        if ( !byte_F4004BE[1] )
        {
          sub_63CEE78(&System_Math_TypeInfo);
          byte_F4004BE[1] = 1;
        }
        if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
          sub_63CEFF4(System_Math_TypeInfo);
        v11 = (float)((float)(v10 * 0.5) * 0.017453);
        v12 = sin(v11);
        if ( !byte_F4004F4[0] )
        {
          sub_63CEE78(&System_Math_TypeInfo);
          byte_F4004F4[0] = 1;
        }
        if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
          sub_63CEFF4(System_Math_TypeInfo);
        v13 = v12;
        v34 = v13;
        v14 = cos(v11);
        LODWORD(v4) = *(_DWORD *)(a0 + 48);
        v9 = byte_F4004BE[1];
        v33 = v14;
      }
      if ( !v9 )
      {
        sub_63CEE78(&System_Math_TypeInfo);
        byte_F4004BE[1] = 1;
      }
      if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
        sub_63CEFF4(System_Math_TypeInfo);
      v15 = sin((float)((float)((float)((float)(int)v8 / (float)(int)v4) * 3.1416)
                      + (float)((float)((float)(int)v8 / (float)(int)v4) * 3.1416)));
      if ( !byte_F4004F4[0] )
      {
        sub_63CEE78(&System_Math_TypeInfo);
        byte_F4004F4[0] = 1;
      }
      if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
        sub_63CEFF4(System_Math_TypeInfo);
      v17 = cos((float)((float)((float)((float)(int)v8 / (float)(int)v4) * 3.1416)
                      + (float)((float)((float)(int)v8 / (float)(int)v4) * 3.1416)));
      v16 = v15;
      sub_DDC0C3C(0, v34 * v17, v34 * v16, v33, 0.0, 1.0, 0.0);
      v22 = sub_DDC0A2C(a0, 0, v18, v19, v20, v21);
      v23 = *(float *)(a0 + 44);
      v24 = *(float *)(a0 + 56);
      v36 = v25;
      v37 = v22;
      v27 = v26;
      v35 = v28;
      Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__GetLaserColor(a0, v8, v29);
      fmodf(*(float *)(a0 + 80) * *(float *)(a0 + 76), 1.0);
      v38.g = v27;
      v38.b = v23;
      v38.a = v24;
      v38.r = v35;
      Campus_Live_Equipment_Environment_LiveLaser__UpdateLaserVertex(
        (char *)a1 + 44 * SHIDWORD(v7),
        v30,
        v37,
        v36,
        v38,
        v31,
        v32);
      v4 = *(int *)(a0 + 48);
      ++v8;
      v7 += 0xF00000000LL;
    }
    while ( v8 < v4 );
  }
}

