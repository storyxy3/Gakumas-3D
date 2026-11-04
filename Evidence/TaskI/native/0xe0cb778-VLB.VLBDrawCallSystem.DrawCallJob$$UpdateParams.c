// VLB.VLBDrawCallSystem.DrawCallJob$$UpdateParams @ 0xe0cb778
void __fastcall VLB_VLBDrawCallSystem_DrawCallJob__UpdateParams(__int64 a0, int a1, int a2, void *a3)
{
  __int64 v5; // x21
  __int64 v7; // x8
  float v8; // s8
  float v9; // s9
  int v10; // s11
  float v11; // s10
  float v12; // s8
  float v13; // s0
  __int64 v14; // x8
  __int128 *v15; // x8
  __int128 v16; // q1
  __int128 v17; // q2
  __int128 v18; // q3
  __int64 v19; // x0
  void *v20; // x1
  void *v21; // x2
  float v22; // s15
  float v23; // s8
  float v24; // s11
  float32x2_t v25; // d14
  float32x2_t v26; // d13
  float32x2_t v27; // d12
  float32x2_t v28; // d9
  float v29; // s10
  float v30; // s0
  unsigned __int64 v31; // d0
  float v32; // s4
  float v33; // s1
  float v34; // s2
  float32x2_t v35; // d5
  float v36; // s4
  float v37; // s11
  float32x2_t v38; // d8
  float v39; // s12
  float32x2_t v40; // d8
  float v41; // s9
  float v42; // s10
  float32x2_t *v43; // x8
  float v44; // s2
  int *v45; // x9
  float *v46; // x8
  int *v47; // x10
  int v48; // s3
  int v49; // s4
  float v50; // s0
  float v51; // s1
  int *v52; // x8
  int *v53; // x9
  int v54; // s9
  int v55; // s10
  float v56; // s15
  float v57; // s8
  int v58; // s13
  int v59; // s14
  int v60; // s11
  int v61; // s12
  float v62; // s0
  __int64 v63; // x8
  int v64; // w10
  float v65; // s9
  float v66; // s10
  float v67; // s1
  int v68; // s2
  int *v69; // x9
  int v70; // s6
  float v71; // s0
  float v72; // s5
  double v73; // d3
  __int64 v74; // x10
  int v75; // s7
  int v76; // s16
  double v77; // d4
  float v78; // s3
  float v79; // s4
  bool v80; // nf
  int v81; // [xsp+Ch] [xbp+Ch]
  int v82; // [xsp+10h] [xbp+10h]
  int v83; // [xsp+14h] [xbp+14h]
  int v84; // [xsp+18h] [xbp+18h]
  int v85; // [xsp+1Ch] [xbp+1Ch]
  int v86; // [xsp+20h] [xbp+20h]
  double v87; // [xsp+28h] [xbp+28h] BYREF
  __int128 v88; // [xsp+30h] [xbp+30h] BYREF
  __int128 v89; // [xsp+40h] [xbp+40h]
  __int128 v90; // [xsp+50h] [xbp+50h]
  __int128 v91; // [xsp+60h] [xbp+60h]
  float32x2_t v92; // [xsp+70h] [xbp+70h]
  float v93; // [xsp+78h] [xbp+78h]
  float32x2_t v94; // [xsp+80h] [xbp+80h]
  float v95; // [xsp+88h] [xbp+88h]
  float32x2_t v96; // [xsp+90h] [xbp+90h]
  float v97; // [xsp+98h] [xbp+98h]
  float32x2_t v98; // [xsp+A0h] [xbp+A0h]
  float v99; // [xsp+A8h] [xbp+A8h]
  __int128 v100; // [xsp+B0h] [xbp+B0h]
  __int128 v101; // [xsp+C0h] [xbp+C0h]
  __int128 v102; // [xsp+D0h] [xbp+D0h]
  __int128 v103; // [xsp+E0h] [xbp+E0h]
  double v104; // [xsp+138h] [xbp+138h] BYREF

  v5 = a2;
  v7 = *(_QWORD *)(a0 + 32) + 16LL * a2;
  v8 = *(float *)(v7 + 4);
  v9 = *(float *)(v7 + 8);
  v10 = *(_DWORD *)(v7 + 12);
  v11 = UnityEngine_Mathf__GammaToLinearSpace(*(float *)v7, nullptr);
  v12 = UnityEngine_Mathf__GammaToLinearSpace(v8, nullptr);
  v13 = UnityEngine_Mathf__GammaToLinearSpace(v9, nullptr);
  v14 = *(_QWORD *)(a0 + 336) + 16LL * a1;
  *(float *)v14 = v11;
  *(float *)(v14 + 4) = v12;
  *(float *)(v14 + 8) = v13;
  *(_DWORD *)(v14 + 12) = v10;
  v15 = (__int128 *)(*(_QWORD *)a0 + (v5 << 6));
  v16 = v15[1];
  v17 = v15[2];
  v18 = v15[3];
  v88 = *v15;
  v89 = v16;
  v90 = v17;
  v91 = v18;
  v100 = v88;
  v101 = v16;
  v102 = v17;
  v103 = v18;
  v19 = Unity_Mathematics_math__inverse((__int64)&v88, nullptr);
  v22 = v93;
  v23 = v95;
  v24 = v97;
  v25.n64_u64[0] = v92.n64_u64[0];
  v26.n64_u64[0] = v94.n64_u64[0];
  v27.n64_u64[0] = v96.n64_u64[0];
  v28.n64_u64[0] = v98.n64_u64[0];
  v29 = v99;
  if ( *(_BYTE *)(a0 + 296) )
  {
    v30 = -1.0;
  }
  else
  {
    v31 = vadd_f32(
            v98,
            vadd_f32(
              vadd_f32(vmul_n_f32(v92, *(float *)(a0 + 272)), vmul_n_f32(v94, *(float *)(a0 + 276))),
              vmul_n_f32(v96, *(float *)(a0 + 280)))).n64_u64[0];
    v30 = VLB_VLBDrawCallSystem_DrawCallJob__GetInsideBeamFactorFromObjectSpacePos(
            v19,
            (__int64)v20,
            *(float *)&v31,
            *((float *)&v31 + 1),
            v21);
  }
  v32 = *(float *)(a0 + 284);
  v33 = *(float *)(a0 + 288);
  v34 = v22 * v32;
  v35.n64_u64[0] = vmul_n_f32(v25, v32).n64_u64[0];
  v36 = *(float *)(a0 + 292);
  v37 = (float)(v34 + (float)(v23 * v33)) + (float)(v24 * v36);
  v38.n64_u64[0] = vadd_f32(vadd_f32(v35, vmul_n_f32(v26, v33)), vmul_n_f32(v27, v36)).n64_u64[0];
  if ( !byte_F4004BE[0] )
  {
    v39 = v30;
    sub_63CEE78(&System_Math_TypeInfo);
    v30 = v39;
    byte_F4004BE[0] = 1;
  }
  v40.n64_u64[0] = vadd_f32(v28, v38).n64_u64[0];
  v41 = v29 + v37;
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
  {
    v42 = v30;
    sub_63CEFF4(System_Math_TypeInfo);
    v30 = v42;
  }
  v43 = (float32x2_t *)(*(_QWORD *)(a0 + 352) + 16LL * a1);
  v44 = 1.0 / sqrtf((float)(v41 * v41) + vaddv_f32(vmul_f32(v40, v40)));
  v43->n64_u64[0] = vmul_n_f32(v40, v44).n64_u64[0];
  v43[1].n64_f32[0] = v41 * v44;
  v43[1].n64_f32[1] = v30;
  v45 = (int *)(*(_QWORD *)(a0 + 64) + 8 * v5);
  v46 = (float *)(*(_QWORD *)(a0 + 48) + 8 * v5);
  v47 = (int *)(*(_QWORD *)(a0 + 96) + 16 * v5);
  v49 = *v45;
  v48 = v45[1];
  v50 = *v46;
  v51 = v46[1];
  v52 = (int *)(*(_QWORD *)(a0 + 80) + 16 * v5);
  v53 = (int *)(*(_QWORD *)(a0 + 112) + 8 * v5);
  v55 = *v47;
  v54 = v47[1];
  v85 = v49;
  v86 = v48;
  v56 = fmaxf(v50, 0.0001);
  v57 = fmaxf(v51, 0.0001);
  v59 = v47[2];
  v58 = v47[3];
  v81 = *v52;
  v82 = v52[1];
  v61 = *v53;
  v60 = v53[1];
  v83 = v52[2];
  v84 = v52[3];
  v62 = Unity_Mathematics_noise__snoise(0, v20);
  v63 = *(_QWORD *)(a0 + 368) + ((__int64)a1 << 6);
  v64 = byte_F4004F4[0];
  *(float *)v63 = v56;
  *(_DWORD *)(v63 + 4) = v81;
  *(float *)(v63 + 16) = v57;
  *(_DWORD *)(v63 + 20) = v82;
  *(_DWORD *)(v63 + 8) = v55;
  *(_DWORD *)(v63 + 12) = v61;
  *(_DWORD *)(v63 + 32) = v85;
  *(_DWORD *)(v63 + 36) = v83;
  *(_DWORD *)(v63 + 24) = v54;
  *(_DWORD *)(v63 + 28) = v60;
  *(_DWORD *)(v63 + 40) = v59;
  *(_DWORD *)(v63 + 44) = 0;
  *(_DWORD *)(v63 + 48) = v86;
  *(_DWORD *)(v63 + 52) = v84;
  *(_DWORD *)(v63 + 56) = v58;
  *(float *)(v63 + 60) = v62;
  v65 = *(float *)(*(_QWORD *)(a0 + 144) + 4 * v5);
  v66 = *(float *)(*(_QWORD *)(a0 + 160) + 4 * v5);
  if ( !v64 )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    byte_F4004F4[0] = 1;
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
  sincos((float)((float)(v66 * 0.017453) * 0.5), &v104, &v87);
  v67 = 0.001;
  v68 = *(_DWORD *)(*(_QWORD *)(a0 + 192) + 4 * v5);
  v69 = (int *)(*(_QWORD *)(a0 + 176) + 8 * v5);
  v70 = *(_DWORD *)(*(_QWORD *)(a0 + 224) + 4 * v5);
  v71 = fmaxf(fabsf(v65), 0.0001);
  v72 = *(float *)(*(_QWORD *)(a0 + 208) + 4 * v5);
  v73 = v104;
  v74 = *(_QWORD *)(a0 + 384) + ((__int64)a1 << 6);
  v75 = *v69;
  v76 = v69[1];
  v77 = v87;
  *(_QWORD *)(v74 + 8) = 0;
  v78 = v73;
  *(_QWORD *)(v74 + 24) = 0;
  v79 = v77;
  *(_QWORD *)(v74 + 40) = 0;
  *(_DWORD *)(v74 + 16) = 0;
  if ( v65 < 0.0 )
    v71 = -v71;
  *(_DWORD *)(v74 + 20) = v76;
  v80 = (LODWORD(v72) & 0x7FFFFFFFu) > 0x7F800000 || v72 < 0.001;
  *(float *)(v74 + 32) = v79;
  *(_DWORD *)(v74 + 36) = v68;
  *(float *)(v74 + 48) = v78;
  if ( !v80 )
    v67 = v72;
  *(float *)v74 = v71;
  *(_DWORD *)(v74 + 4) = v75;
  *(_DWORD *)(v74 + 60) = 0;
  *(float *)(v74 + 52) = v67;
  *(_DWORD *)(v74 + 56) = v70;
}

