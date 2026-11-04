// VLB.VLBDrawCallSystem.DrawCallJob$$Execute @ 0xe0cb554
void __fastcall VLB_VLBDrawCallSystem_DrawCallJob__Execute(__int64 a0, void *a1)
{
  __int64 v3; // x24
  int v4; // w23
  __int64 v5; // x20
  unsigned int v6; // w25
  float v7; // s15
  float v8; // s14
  float v9; // s8
  int v10; // w22
  __int64 v11; // x8
  float v12; // s9
  float v13; // s10
  float v14; // s0
  float v15; // s11
  float v16; // s1
  float v17; // s12
  float v18; // s2
  float v19; // s13
  float v20; // s8
  void *v21; // x3
  float v22; // s0
  float v23; // s1
  float v24; // s2
  __int128 *v27; // x8
  _OWORD *v28; // x9
  __int128 v29; // q0
  __int128 v30; // q2
  __int128 v31; // q3
  unsigned __int64 v32; // x8
  float v33; // [xsp+Ch] [xbp+Ch]
  UnityEngine_Vector3_o v34; // 0:s0.4,4:s1.4,8:s2.4

  if ( *(int *)(a0 + 312) < 1 )
  {
    v4 = 0;
  }
  else
  {
    v3 = 0;
    v4 = 0;
    v5 = 0;
    v6 = 0;
    do
    {
      v7 = *(float *)(a0 + 272);
      v8 = *(float *)(a0 + 276);
      v9 = *(float *)(a0 + 280);
      v10 = *(_DWORD *)(*(_QWORD *)(a0 + 304) + 4 * v3);
      v11 = *(_QWORD *)(a0 + 256) + 24LL * v10;
      v12 = *(float *)(v11 + 16);
      v13 = *(float *)(v11 + 20);
      v33 = *(float *)(v11 + 12);
      Unity_Mathematics_float3__op_Implicit_3(*(UnityEngine_Vector3_o *)v11, nullptr);
      v15 = v14;
      v17 = v16;
      v19 = v18;
      if ( !byte_F4004BE[0] )
      {
        sub_63CEE78(&System_Math_TypeInfo);
        byte_F4004BE[0] = 1;
      }
      if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
        sub_63CEFF4(System_Math_TypeInfo);
      v34.y = v12;
      v34.z = v13;
      v20 = sqrtf(
              (float)((float)(v9 - v19) * (float)(v9 - v19))
            + (float)((float)((float)(v7 - v15) * (float)(v7 - v15)) + (float)((float)(v8 - v17) * (float)(v8 - v17))));
      v34.x = v33;
      Unity_Mathematics_float3__op_Implicit_3(v34, nullptr);
      if ( (LODWORD(v23) & 0x7FFFFFFFu) <= 0x7F800000 && v22 <= v23 )
        v22 = v23;
      if ( v22 <= v24 && (LODWORD(v24) & 0x7FFFFFFFu) <= 0x7F800000 )
        v22 = v24;
      if ( v20 <= (float)(v22 + 1000.0) )
      {
        v27 = (__int128 *)(*(_QWORD *)(a0 + 16) + ((__int64)v10 << 6));
        v28 = (_OWORD *)(*(_QWORD *)(a0 + 320) + ((__int64)(int)v5 << 6));
        v29 = v27[3];
        v30 = *v27;
        v31 = v27[1];
        v28[2] = v27[2];
        v28[3] = v29;
        *v28 = v30;
        v28[1] = v31;
        VLB_VLBDrawCallSystem_DrawCallJob__UpdateParams(a0, v5, v10, v21);
        *(_DWORD *)(*(_QWORD *)(a0 + 432) + 4LL * (int)v5) = v10;
        v5 = (unsigned int)(v5 + 1);
        if ( (int)(v5 - v6) >= 200 )
        {
          v32 = v6 | (unsigned __int64)(v5 << 32);
          v6 = v5;
          *(_QWORD *)(*(_QWORD *)(a0 + 400) + 8LL * v4++) = v32;
        }
      }
      ++v3;
    }
    while ( v3 < *(int *)(a0 + 312) );
    if ( (_DWORD)v5 != v6 )
      *(_QWORD *)(*(_QWORD *)(a0 + 400) + 8LL * v4++) = v6 | (unsigned __int64)(v5 << 32);
  }
  **(_DWORD **)(a0 + 416) = v4;
}

