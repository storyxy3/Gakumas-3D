// Campus.Live.Equipment.Environment.LiveLaser.LaserVertexJob$$GetLaserColor @ 0xddb767c
UnityEngine_Color_o __fastcall Campus_Live_Equipment_Environment_LiveLaser_LaserVertexJob__GetLaserColor(
        __int64 a0,
        int a1,
        void *a2)
{
  int v3; // w8
  float v5; // s0
  int v6; // w8
  int v7; // w9
  float v8; // s1
  float v9; // s8
  float v10; // s9
  float v11; // s0
  UnityEngine_Color_o result; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v3 = *(_DWORD *)(a0 + 40);
  if ( !v3 )
  {
LABEL_19:
    v9 = *(float *)(a0 + 60);
    result.g = *(float *)(a0 + 64);
    result.b = *(float *)(a0 + 68);
    result.a = *(float *)(a0 + 72);
    goto LABEL_20;
  }
  v5 = *(float *)(a0 + 80);
  if ( v3 > 2 )
  {
    if ( v3 == 3 )
    {
      v6 = a1 - *(_DWORD *)(a0 + 48) / 2;
      if ( v6 < 0 )
        v6 = *(_DWORD *)(a0 + 48) / 2 - a1;
    }
    else
    {
      if ( v3 != 4 )
        goto LABEL_16;
      v7 = a1 - *(_DWORD *)(a0 + 48) / 2;
      if ( v7 < 0 )
        v7 = *(_DWORD *)(a0 + 48) / 2 - a1;
      v6 = *(_DWORD *)(a0 + 48) / 2 - v7;
    }
    goto LABEL_14;
  }
  if ( v3 != 1 )
  {
    if ( v3 != 2 )
      goto LABEL_16;
    v6 = *(_DWORD *)(a0 + 48) + ~a1;
LABEL_14:
    v8 = (float)v6;
    goto LABEL_15;
  }
  v8 = (float)a1;
LABEL_15:
  v5 = v5 - (float)(*(float *)(a0 + 92) * v8);
LABEL_16:
  v9 = 0.0;
  v10 = *(float *)(a0 + 88);
  if ( v5 < 0.0 )
    v5 = 0.0;
  v11 = fmodf(v5, *(float *)(a0 + 84) + v10);
  result.g = 0.0;
  result.b = 0.0;
  result.a = 1.0;
  if ( v11 >= v10 )
    goto LABEL_19;
LABEL_20:
  result.r = v9;
  return result;
}

