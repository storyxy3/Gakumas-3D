// Campus.Live.Equipment.Environment.LiveLaser$$UpdateLaserVertex @ 0xddb7470
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__UpdateLaserVertex(
        void *a0,
        __int64 a1,
        float a2,
        float a3,
        UnityEngine_Color_o a4,
        __int64 a5,
        void *a6)
{
  float v8; // s15
  float a; // s8
  float g; // s9
  float r; // s10
  float v13; // s13
  __int64 v15; // x0
  unsigned int v16; // w8
  float v17; // s0
  float v18; // s22
  int v19; // w10
  float v20; // s23
  float v21; // s24
  float v22; // s26
  float v23; // s23
  float v24; // s24
  float v25; // s26
  float v26; // s28
  float v27; // s27
  void *v28; // x0
  void *v29; // x1
  __int64 v30; // [xsp+60h] [xbp+60h]
  __int64 v31; // [xsp+68h] [xbp+68h]
  __int64 v32; // [xsp+70h] [xbp+70h]

  v8 = a4.a * a4.a;
  a = a4.a;
  g = a4.g;
  r = a4.r;
  v13 = a4.b * 20.0;
  if ( !byte_F4004BE[0] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004BE[0] = 1;
  }
  v15 = System_Math_TypeInfo;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v16 = 0;
  v17 = a / sqrtf((float)(v13 * v13) + v8);
  while ( a0 )
  {
    *((_DWORD *)a0 + 4) = HIDWORD(v30);
    *((_DWORD *)a0 + 5) = v31;
    v18 = vcvts_n_f32_s32(v16 / 3, 2u);
    v19 = v16 % 3;
    ++v16;
    *((float *)a0 + 10) = v18;
    v20 = v13 + (float)((float)(v13 - v13) * v18);
    v21 = (float)((float)(v20 + v20) * 0.5) * (float)v19;
    v22 = vabds_f32(v21, v20);
    v23 = v21 - v20;
    *((_DWORD *)a0 + 6) = HIDWORD(v31);
    *((float *)a0 + 7) = *(float *)&v32 + (float)((float)((float)v19 * 0.124) + 0.001);
    v24 = (float)(v18 * a) + (float)((float)((float)(v17 * (float)(v18 * a)) - (float)(v18 * a)) * (float)(v22 / v13));
    v25 = (float)((float)(a2 * 0.0) - (float)(a3 * v23)) + (float)((float)(a2 * 0.0) - (float)(a3 * v23));
    v26 = (float)((float)(a3 * v24) - (float)(r * 0.0)) + (float)((float)(a3 * v24) - (float)(r * 0.0));
    v27 = (float)((float)(r * v23) - (float)(a2 * v24)) + (float)((float)(r * v23) - (float)(a2 * v24));
    *((float *)a0 + 8) = v18;
    *((float *)a0 + 9) = *((float *)&v32 + 1) + vcvts_n_f32_s32(v19, 5u);
    *(float *)a0 = (float)(v23 + (float)(g * v26)) + (float)((float)(a3 * v25) - (float)(r * v27));
    *((float *)a0 + 1) = (float)((float)(g * v27) + 0.0) + (float)((float)(r * v26) - (float)(a2 * v25));
    *((float *)a0 + 2) = (float)(v24 + (float)(g * v25)) + (float)((float)(a2 * v27) - (float)(a3 * v26));
    *((_DWORD *)a0 + 3) = v30;
    a0 = (char *)a0 + 44;
    if ( v16 == 15 )
      return;
  }
  v28 = (void *)sub_63CF120(v15, a1);
  Campus_Live_Equipment_Environment_LiveLaser___ctor(v28, v29);
}

