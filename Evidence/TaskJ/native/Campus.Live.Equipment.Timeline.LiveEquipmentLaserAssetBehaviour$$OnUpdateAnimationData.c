// 0xddb1b80 @ 0xddb1b80
void __fastcall Campus_Live_Equipment_Timeline_LiveEquipmentLaserAssetBehaviour__OnUpdateAnimationData(
        void *a0,
        void *a1,
        void *a2,
        float a3,
        float a4,
        float a5,
        void *a6,
        void *a7)
{
  __int64 v13; // x0
  __int64 v14; // x1
  int v15; // w24
  float v16; // s11
  int v17; // w25
  int v18; // w26
  int v19; // w27
  float v20; // s12
  double v21; // d11
  double v22; // d0
  double v23; // d0
  double v24; // d1
  double v25; // d1
  float v26; // s11
  int v27; // w22
  float v28; // s12
  double v29; // d11
  void *v30; // x1
  double v31; // d0
  double v32; // d0
  double v33; // d1
  double v34; // d1
  __int64 v35; // x21
  int v36; // w23
  float TimeScale; // s11
  void *v38; // x1
  float v39; // s11
  float v40; // s10
  long double v41; // q0
  float v42; // s10
  float v43; // s10
  double v44; // d9
  int v45; // w25
  int v46; // w22
  double v47; // d0
  double v48; // d0
  double v49; // d1
  double v50; // d1
  int v51; // w8
  __int64 v52; // d0
  int v53; // s1
  int v54; // s2
  void *v55; // x0
  void *v56; // x1
  void *v57; // x2
  void *v58; // x3
  float v59; // s0
  float v60; // s1
  float v61; // s2
  int v62; // [xsp+8h] [xbp+8h]
  int v63; // [xsp+Ch] [xbp+Ch]
  double v64; // [xsp+18h] [xbp+18h] BYREF

  Campus_Live_Equipment_Timeline_LiveEquipmentAssetBehaviour__SampleAllCurve(a0, a1, a3, a4, a5, a6, a6);
  if ( !*((_BYTE *)a0 + 16) )
    return;
  if ( !a1 )
    goto LABEL_64;
  v15 = *((_DWORD *)a1 + 26);
  v16 = (float)*((int *)a0 + 47);
  v17 = *((_DWORD *)a0 + 46);
  v18 = *((_DWORD *)a0 + 43);
  v19 = *((_DWORD *)a0 + 44);
  v62 = *((_DWORD *)a1 + 25);
  v63 = *((_DWORD *)a1 + 27);
  if ( !byte_F40034E[227] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F40034E[227] = 1;
  }
  v20 = v16 * a5;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v21 = v20;
  v22 = modf(v20, &v64);
  if ( v20 >= 0.0 )
  {
    if ( v22 != 0.5 )
    {
      v23 = floor(v21 + 0.5);
      goto LABEL_17;
    }
    v24 = 1.0;
    v23 = v64;
  }
  else
  {
    if ( v22 != -0.5 )
    {
      v23 = ceil(v21 + -0.5);
      goto LABEL_17;
    }
    v23 = v64;
    v24 = -1.0;
  }
  v25 = v23 + v24;
  if ( ((__int64)v23 & 1) != 0 )
    v23 = v25;
LABEL_17:
  v26 = (float)*((int *)a0 + 45) * 1000.0;
  if ( v23 == INFINITY )
    v27 = 0x80000000;
  else
    v27 = (int)v23;
  if ( !byte_F40034E[227] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F40034E[227] = 1;
  }
  v28 = v26 * a5;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v29 = v28;
  v31 = modf(v28, &v64);
  if ( v28 >= 0.0 )
  {
    if ( v31 != 0.5 )
    {
      v32 = floor(v29 + 0.5);
      goto LABEL_34;
    }
    v33 = 1.0;
    v32 = v64;
  }
  else
  {
    if ( v31 != -0.5 )
    {
      v32 = ceil(v29 + -0.5);
      goto LABEL_34;
    }
    v32 = v64;
    v33 = -1.0;
  }
  v34 = v32 + v33;
  if ( ((__int64)v32 & 1) != 0 )
    v32 = v34;
LABEL_34:
  v35 = *((_QWORD *)a0 + 26);
  if ( v32 == INFINITY )
    v36 = 0x80000000;
  else
    v36 = (int)v32;
  TimeScale = Campus_Live_Equipment_Timeline_LiveEquipmentAssetBehaviour__get_TimeScale(a0, v30);
  v39 = (float)(TimeScale * a3) + Campus_Live_Equipment_Timeline_LiveEquipmentAssetBehaviour__get_TimeOffset(a0, v38);
  if ( *((_BYTE *)a0 + 17) )
  {
    if ( v35 )
    {
      v40 = (*(float (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v35 + 376LL))(
              v35,
              *(_QWORD *)(*(_QWORD *)v35 + 384LL));
      *(float *)&v41 = fmodf(v39, 1.0) * v40;
      goto LABEL_42;
    }
LABEL_64:
    v55 = (void *)sub_63CF120(v13, v14);
    Campus_Live_Equipment_Timeline_LiveEquipmentAssetBehaviour__SampleAllCurve(v55, v56, v59, v60, v61, v57, v58);
    return;
  }
  if ( !v35 )
    goto LABEL_64;
  *(float *)&v41 = (float)(v39 / a4)
                 * (*(float (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v35 + 376LL))(
                     v35,
                     *(_QWORD *)(*(_QWORD *)v35 + 384LL));
LABEL_42:
  v42 = (*(float (__fastcall **)(__int64, _QWORD, long double))(*(_QWORD *)v35 + 392LL))(
          v35,
          *(_QWORD *)(*(_QWORD *)v35 + 400LL),
          v41);
  if ( !byte_F40034E[227] )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F40034E[227] = 1;
  }
  v43 = v42 * a5;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v44 = v43;
  v45 = v18 | (v19 << 8) | (v17 << 16);
  v46 = v27 + v62;
  v47 = modf(v43, &v64);
  if ( v43 >= 0.0 )
  {
    if ( v47 == 0.5 )
    {
      v49 = 1.0;
      v48 = v64;
LABEL_51:
      v50 = v48 + v49;
      if ( ((__int64)v48 & 1) != 0 )
        v48 = v50;
      goto LABEL_56;
    }
    v48 = floor(v44 + 0.5);
  }
  else
  {
    if ( v47 == -0.5 )
    {
      v48 = v64;
      v49 = -1.0;
      goto LABEL_51;
    }
    v48 = ceil(v44 + -0.5);
  }
LABEL_56:
  *((_DWORD *)a1 + 24) = v45;
  *((_DWORD *)a1 + 25) = v46;
  *((float *)a1 + 8) = a3;
  if ( v48 == INFINITY )
    v51 = 0x80000000;
  else
    v51 = (int)v48;
  *((_DWORD *)a1 + 26) = v36 + v15;
  *((_DWORD *)a1 + 27) = v51 + v63;
  if ( *((_DWORD *)a0 + 44) )
  {
    v52 = *(_QWORD *)((char *)a0 + 196);
    v53 = *((_DWORD *)a0 + 51);
  }
  else
  {
    v52 = 0;
    v53 = 0;
  }
  v54 = *((_DWORD *)a0 + 48);
  *((_QWORD *)a1 + 14) = v52;
  *((_DWORD *)a1 + 30) = v53;
  *((_DWORD *)a1 + 31) = v54;
}

