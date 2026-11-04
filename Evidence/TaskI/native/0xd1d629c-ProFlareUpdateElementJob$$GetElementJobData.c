// 0xd1d629c @ 0xd1d629c
__int64 __fastcall ProFlareUpdateElementJob__GetElementJobData(
        __int64 a0,
        void *a1,
        __int64 a2,
        float a3,
        UnityEngine_Color_o a4,
        void *a5)
{
  __int64 v6; // x8
  float v7; // s5
  float v8; // s6
  float v9; // s7
  float v10; // s14
  float v11; // s15
  float v12; // s8
  float a; // s9
  float r; // s10
  __int64 v18; // x19
  float v19; // s0
  float x; // s12
  float y; // s13
  unsigned int v22; // w0
  unsigned int v23; // w23
  int v24; // w24
  unsigned int v25; // w22
  int v26; // w8
  float *v27; // x8
  unsigned int v28; // w25
  __int64 v29; // x8
  int v30; // w20
  __int64 result; // x0
  int v32; // s0
  int v33; // s1
  float g; // [xsp+8h] [xbp+8h]
  float b; // [xsp+Ch] [xbp+Ch]
  __int128 v36; // [xsp+10h] [xbp+10h]
  UnityEngine_Vector2_o v37; // 0:kr00_8.8
  UnityEngine_Vector2_o v38; // 0:s0.4,4:s1.4

  v10 = v9;
  v11 = v8;
  v12 = v7;
  a = a4.a;
  r = a4.r;
  v18 = v6;
  g = a4.g;
  b = a4.b;
  if ( (unk_F42C953 & 1) == 0 )
  {
    sub_63CEE78(&Unity_Mathematics_float2_TypeInfo);
    unk_F42C953 = 1;
  }
  v19 = *((float *)a1 + 12);
  x = *((float *)a1 + 13) * v19;
  if ( x < 0.0 || (y = *((float *)a1 + 14) * v19, y < 0.0) )
  {
    v37 = Unity_Mathematics_float2__op_Implicit_3(0, a1);
    x = v37.x;
    y = v37.y;
  }
  sub_6551F64(0, a1, a, v12, v11, v10);
  v23 = HIWORD(v22);
  v24 = HIBYTE(v22);
  v25 = v22;
  if ( *(_BYTE *)(a0 + 8) )
  {
    v26 = *(_DWORD *)(a0 + 12);
    if ( v26 > v24 || BYTE1(v22) + (unsigned __int8)v22 + BYTE2(v22) < v26 )
    {
      if ( !byte_F400253[0] )
      {
        sub_63CEE78(&UnityEngine_Vector2_TypeInfo);
        byte_F400253[0] = 1;
      }
      v27 = *(float **)(UnityEngine_Vector2_TypeInfo + 184LL);
      x = *v27;
      y = v27[1];
    }
  }
  if ( *(_BYTE *)(a0 + 16) )
  {
    LOBYTE(v23) = 20;
    v24 = 50;
    LOBYTE(v28) = 20;
    LOBYTE(v25) = 20;
  }
  else
  {
    v28 = v25 >> 8;
  }
  v29 = *((int *)a1 + 30);
  v38.y = y;
  v30 = *((_DWORD *)a1 + 1);
  v36 = *(_OWORD *)(*(_QWORD *)(a0 + 56) + 16 * v29);
  v38.x = x;
  result = Unity_Mathematics_float2__op_Implicit_4(v38, nullptr);
  *(_DWORD *)(v18 + 8) = v32;
  *(_DWORD *)(v18 + 12) = v33;
  *(float *)(v18 + 16) = a3;
  *(float *)(v18 + 20) = r;
  *(float *)(v18 + 24) = g;
  *(float *)(v18 + 28) = b;
  *(_OWORD *)(v18 + 32) = v36;
  *(_DWORD *)v18 = v30;
  *(_DWORD *)(v18 + 4) = (v24 << 24) | ((unsigned __int8)v23 << 16) | ((unsigned __int8)v28 << 8) | (unsigned __int8)v25;
  return result;
}

