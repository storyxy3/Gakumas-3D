// ProFlareBatchForSRPData$$<ScheduleFlares>g__UpdateElementJobData|48_0 @ 0xd1d5098
void __fastcall ProFlareBatchForSRPData___ScheduleFlares_g__UpdateElementJobData_48_0(
        UnityEngine_Color_o a0,
        float a1,
        float a2,
        float a3,
        void *a4,
        void *a5,
        void *a6,
        void *a7,
        void *a8)
{
  __int64 v9; // x8
  int v13; // w9
  __int64 v14; // x8
  __int64 v15; // x9
  __int64 v16; // x8
  __int64 v17; // x9
  char v18; // w10
  int v19; // w10
  __int64 v20; // x8
  __int64 v21; // x21
  __int64 v22; // x8
  __int64 v23; // x9
  int v24; // w10
  __int64 v25; // x8
  __int64 v26; // x9
  __int64 v27; // x8
  float v28; // s0
  float v29; // s1
  char v30; // w10
  int v31; // w11
  float v32; // s0
  int v33; // s1
  int v34; // w9
  int v35; // w10
  void *v36; // x0
  void *v37; // x1
  UnityEngine_Vector3_o v38; // 0:kr00_12.12

  if ( !*(_QWORD *)a7 )
    goto LABEL_17;
  v9 = *(_QWORD *)a4;
  if ( !*(_QWORD *)a4 )
    goto LABEL_17;
  v13 = *(_DWORD *)a5;
  *(_BYTE *)v9 = *(_DWORD *)(*(_QWORD *)a7 + 304LL) == 1;
  *(_DWORD *)(v9 + 4) = v13;
  *(_OWORD *)(v9 + 8) = *(_OWORD *)((char *)a7 + 8);
  if ( !*(_QWORD *)a4 )
    goto LABEL_17;
  *(UnityEngine_Color_o *)(*(_QWORD *)a4 + 24LL) = a0;
  v14 = *(_QWORD *)a4;
  if ( !*(_QWORD *)a4 )
    goto LABEL_17;
  v15 = *(_QWORD *)a7;
  *(_QWORD *)(v14 + 40) = *((_QWORD *)a7 + 3);
  if ( !v15 )
    goto LABEL_17;
  if ( !*(_QWORD *)a6 )
    goto LABEL_17;
  *(float *)(v14 + 48) = *((float *)a6 + 2)
                       * (float)(*((float *)a7 + 8)
                               * (float)(*(float *)(*(_QWORD *)a6 + 88LL)
                                       * (float)((float)(*(float *)(v15 + 52) * a1) * 0.01)));
  *(_QWORD *)(v14 + 52) = *(_QWORD *)(v15 + 296);
  v16 = *(_QWORD *)a7;
  if ( !*(_QWORD *)a7 )
    goto LABEL_17;
  v17 = *(_QWORD *)a4;
  if ( !*(_QWORD *)a4 )
    goto LABEL_17;
  v18 = *(_BYTE *)(v16 + 84);
  *(float *)(v17 + 64) = a3;
  *(_BYTE *)(v17 + 60) = v18;
  v19 = *(_DWORD *)(v16 + 136);
  v20 = *(_QWORD *)(v16 + 128);
  *(_DWORD *)(v17 + 76) = v19;
  *(_QWORD *)(v17 + 68) = v20;
  v21 = *(_QWORD *)a4;
  v38 = Unity_Mathematics_float3__op_Implicit_2(0, a5);
  if ( !v21 )
    goto LABEL_17;
  *(UnityEngine_Vector3_o *)(v21 + 80) = v38;
  v22 = *(_QWORD *)a7;
  if ( !*(_QWORD *)a7 )
    goto LABEL_17;
  v23 = *(_QWORD *)a4;
  if ( *(_QWORD *)a4
    && (v24 = *(_DWORD *)(v22 + 124),
        v25 = *(_QWORD *)(v22 + 116),
        *(_DWORD *)(v23 + 100) = v24,
        *(_QWORD *)(v23 + 92) = v25,
        (v26 = *(_QWORD *)a7) != 0)
    && (v27 = *(_QWORD *)a4) != 0 )
  {
    v28 = *((float *)a4 + 2);
    v29 = *(float *)(v26 + 168);
    v30 = *(_BYTE *)(v26 + 161);
    v31 = *(_DWORD *)(v26 + 20);
    *(float *)(v27 + 116) = a2;
    v32 = v28 * v29;
    v33 = *(_DWORD *)(v26 + 164);
    v34 = *((_DWORD *)a4 + 3);
    *(_BYTE *)(v27 + 104) = v30;
    v35 = *((_DWORD *)a4 + 6);
    ++v34;
    *(_DWORD *)(v27 + 120) = v31;
    *((_DWORD *)a4 + 3) = v34;
    *(_DWORD *)(v27 + 108) = v33;
    *(float *)(v27 + 112) = v32;
    if ( v34 < v35 )
      *(_QWORD *)a4 = v27 + 124;
  }
  else
  {
LABEL_17:
    v36 = (void *)sub_63CF120(a4, a5);
    ProFlareBatchForSRPData__CompleteJob(v36, v37);
  }
}

