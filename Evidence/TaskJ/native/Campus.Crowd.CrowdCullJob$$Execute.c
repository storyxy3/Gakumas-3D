// Campus.Crowd.CrowdCullJob$$Execute @ 0xddc7a24
void __fastcall Campus_Crowd_CrowdCullJob__Execute(__int64 a0, int a1, void *a2)
{
  __int64 v5; // x8
  float v6; // s8
  float v7; // s9
  float v8; // s10
  float v9; // s11
  __int128 v10; // q0
  __int64 v11; // x9
  int v12; // w23
  __int64 v13; // x22
  int v14; // w21
  __int64 v15; // kr00_8
  float v16; // s10
  float v17; // s11
  float v18; // s13
  float v19; // s12
  float v20; // s8
  float v21; // s8
  __int64 v22; // x8
  __int64 v23; // x8
  __int64 v24; // [xsp+0h] [xbp+0h] BYREF
  __int128 v25; // [xsp+8h] [xbp+8h]
  __int64 v26; // [xsp+18h] [xbp+18h] BYREF
  __int128 v27; // [xsp+20h] [xbp+20h]
  __int128 v28; // [xsp+30h] [xbp+30h] BYREF
  __int64 v29; // [xsp+40h] [xbp+40h]
  __int64 v30; // [xsp+50h] [xbp+50h]
  int v31; // [xsp+58h] [xbp+58h]
  UnityEngine_Vector4_o v32; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BD08 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdUtility_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeList_ParallelWriter_CellSortData__AddNoResize__);
    unk_F43BD08 = 1;
  }
  v5 = *(_QWORD *)a0 + 12LL * a1;
  v6 = *(float *)(a0 + 144);
  v7 = *(float *)(a0 + 148);
  v8 = *(float *)(a0 + 152);
  v9 = *(float *)(a0 + 156);
  v10 = *(_OWORD *)(a0 + 120);
  v11 = *(_QWORD *)(a0 + 136);
  v31 = 0;
  v12 = *(_DWORD *)v5;
  v13 = *(unsigned __int16 *)(v5 + 4);
  v14 = *(_DWORD *)(v5 + 8);
  LODWORD(v5) = *(_DWORD *)(Campus_Crowd_CrowdUtility_TypeInfo + 228LL);
  v28 = v10;
  v29 = v11;
  v30 = 0;
  if ( !(_DWORD)v5 )
    sub_63CEFF4(Campus_Crowd_CrowdUtility_TypeInfo);
  v32.x = v6;
  v32.y = v7;
  v32.z = v8;
  v32.w = v9;
  Campus_Crowd_CrowdUtility__GetCellBounds((UnityEngine_Bounds_o *)&v26, (UnityEngine_Bounds_o *)&v28, v14, v32, a2);
  v15 = v26;
  v16 = *(float *)&v27;
  v31 = HIDWORD(v27);
  v30 = *(_QWORD *)((char *)&v27 + 4);
  v24 = v26;
  v25 = v27;
  if ( VL_Rendering_CameraPlanes__TestAABB(a0 + 24, (UnityEngine_Bounds_o *)&v24, nullptr) )
  {
    v17 = *(float *)(a0 + 160);
    v18 = *(float *)(a0 + 164);
    v19 = *(float *)(a0 + 168);
    if ( !unk_F4056FE )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      unk_F4056FE = 1;
    }
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    v20 = sqrtf(
            (float)((float)(v19 - v16) * (float)(v19 - v16))
          + (float)((float)((float)(v17 - *(float *)&v15) * (float)(v17 - *(float *)&v15))
                  + (float)((float)(v18 - *((float *)&v15 + 1)) * (float)(v18 - *((float *)&v15 + 1)))));
    if ( !unk_F4032D5 )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      unk_F4032D5 = 1;
    }
    v21 = v20 * 100.0;
    v22 = *(unsigned int *)(System_Math_TypeInfo + 228LL);
    if ( !(_DWORD)v22 )
      sub_63CEFF4(System_Math_TypeInfo);
    LODWORD(v22) = vcvtms_s32_f32(v21);
    v23 = v22 << 48;
    if ( floorf(v21) == INFINITY )
      v23 = 0;
    Unity_Collections_NativeList_ParallelWriter_CellSortData___AddNoResize(
      a0 + 16,
      v23 | (v13 << 32) | (unsigned int)(v12 << 16) | (unsigned __int64)(unsigned __int16)a1,
      Method_Unity_Collections_NativeList_ParallelWriter_CellSortData__AddNoResize__);
  }
}

