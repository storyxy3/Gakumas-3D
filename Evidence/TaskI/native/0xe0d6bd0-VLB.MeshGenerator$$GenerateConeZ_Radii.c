// 0xe0d6bd0 @ 0xe0d6bd0
void *__fastcall VLB_MeshGenerator__GenerateConeZ_Radii(
        float a0,
        float a1,
        float a2,
        int a3,
        int a4,
        bool a5,
        bool a6,
        void *a7)
{
  void *v13; // x19
  int v14; // w29
  float v15; // s1
  int v16; // w28
  __int64 v17; // x25
  float v18; // s0
  __int64 v19; // x26
  int v20; // w8
  unsigned int v21; // w20
  float v22; // s10
  float v23; // s9
  __int64 v24; // x0
  __int64 v25; // x1
  int v26; // w2
  int v27; // w3
  int *v28; // x24
  int v29; // w21
  __int64 v30; // kr00_8
  __int64 v31; // x8
  unsigned int v32; // w9
  float v33; // s2
  float *v34; // x10
  float v35; // s2
  float v36; // s3
  bool v37; // nf
  float v38; // s2
  float v39; // s3
  bool v40; // w21
  bool v41; // w27
  unsigned int v42; // w8
  unsigned int v43; // w11
  __int64 v44; // x12
  __int64 v45; // x10
  int v46; // s1
  int *v47; // x9
  __int64 v48; // x8
  int v49; // s1
  int v50; // w25
  unsigned int v51; // w27
  int *v52; // x8
  float v53; // s0
  float v54; // s1
  int v55; // w9
  unsigned int v56; // w8
  unsigned int v57; // w10
  unsigned int v58; // w9
  __int64 v59; // x9
  __int64 v60; // x8
  int v61; // s1
  void *v62; // x25
  int *v63; // x24
  unsigned __int64 v64; // x8
  float *v65; // x9
  int v66; // w10
  int v67; // w11
  unsigned int v68; // w8
  __int64 v69; // x9
  _DWORD *v70; // x25
  int v71; // w9
  unsigned int v72; // w10
  int i; // w8
  unsigned int v74; // w9
  int v75; // w8
  int v76; // w8
  int v77; // w9
  _DWORD *v78; // x24
  unsigned int v79; // w10
  int v80; // w8
  int v81; // w9
  unsigned int v82; // w12
  int v83; // w13
  int v84; // w14
  unsigned int v85; // w15
  unsigned int v86; // w10
  _DWORD *v87; // x16
  unsigned int v88; // w10
  unsigned int v89; // w8
  int v90; // w12
  int v91; // w9
  unsigned int v92; // w11
  unsigned int v93; // w10
  _DWORD *v94; // x14
  unsigned int v95; // w10
  unsigned int v96; // w10
  unsigned int v97; // w9
  unsigned int v98; // w8
  unsigned int v99; // w10
  _DWORD *v100; // x21
  int v101; // w8
  unsigned int v102; // w9
  unsigned int v103; // w10
  int v104; // w12
  unsigned int v105; // w11
  int v106; // w12
  int v107; // w10
  int32x4_t v108; // q0
  float32x2_t v109; // d1
  bool v112; // [xsp+8h] [xbp+8h]
  float v113; // [xsp+Ch] [xbp+Ch]
  __int64 v115; // [xsp+28h] [xbp+28h] BYREF
  __int64 v116; // [xsp+30h] [xbp+30h] BYREF
  __int64 v117; // [xsp+38h] [xbp+38h] BYREF
  int32x4_t v118; // [xsp+40h] [xbp+40h]

  if ( (unk_F43DA47 & 1) == 0 )
  {
    sub_63CEE78(&int___TypeInfo);
    sub_63CEE78(&UnityEngine_Mesh_TypeInfo);
    sub_63CEE78(&UnityEngine_Vector3___TypeInfo);
    sub_63CEE78(&UnityEngine_Vector4___TypeInfo);
    unk_F43DA47 = 1;
  }
  v13 = (void *)sub_63CF110(UnityEngine_Mesh_TypeInfo);
  UnityEngine_Mesh___ctor(v13, nullptr);
  v14 = a3 + 2;
  v15 = 1.4142;
  v16 = a3 + 1;
  v17 = (unsigned int)(a4 + 2);
  v18 = fmaxf(a1, 0.001);
  v19 = (unsigned int)(v17 * (a3 + 1));
  v112 = a1 > 0.0 && a5;
  if ( v112 )
    v20 = a3 + 2;
  else
    v20 = 0;
  if ( a3 != 4 )
    v15 = 1.0;
  v21 = v20 + v19;
  if ( a3 == 4 )
    v22 = 0.7854;
  else
    v22 = 0.0;
  v23 = v18 * v15;
  v113 = v15 * a2;
  v24 = sub_63CEF64(UnityEngine_Vector3___TypeInfo, (unsigned int)(v20 + v19));
  v28 = (int *)v24;
  if ( a3 >= 1 )
  {
    v29 = 0;
    while ( 1 )
    {
      sincosf(v22 + (float)((float)((float)v29 * 6.2832) / (float)a3), (float *)&v116 + 1, (float *)&v116);
      if ( (int)v17 >= 1 )
        break;
LABEL_23:
      if ( ++v29 == a3 )
        goto LABEL_24;
    }
    if ( v28 )
    {
      v30 = v116;
      v31 = 0;
      v32 = v29;
      while ( v32 < v28[6] )
      {
        v33 = (float)(int)v31;
        v34 = (float *)&v28[3 * v32];
        ++v31;
        v32 += v16;
        v35 = v33 / (float)(a4 + 1);
        if ( v35 <= 1.0 )
          v36 = v35;
        else
          v36 = 1.0;
        v37 = v35 < 0.0;
        v38 = v35 * a0;
        if ( v37 )
          v36 = 0.0;
        v34[10] = v38;
        v39 = v23 + (float)((float)(v113 - v23) * v36);
        v34[8] = *(float *)&v30 * v39;
        v34[9] = *((float *)&v30 + 1) * v39;
        if ( v17 == v31 )
          goto LABEL_23;
      }
      goto LABEL_119;
    }
LABEL_120:
    sub_63CF120(v24, v25);
    JUMPOUT(0xE0D746C);
  }
LABEL_24:
  v41 = a6;
  v40 = v112;
  if ( (int)v17 >= 1 )
  {
    if ( !v28 )
      goto LABEL_120;
    v42 = 0;
    do
    {
      v43 = v28[6];
      if ( v42 >= v43 || a3 + v42 >= v43 )
        goto LABEL_119;
      v44 = (__int64)&v28[3 * v42 + 8];
      --v17;
      v45 = (__int64)&v28[3 * (a3 + v42) + 8];
      v42 += v16;
      v46 = *(_DWORD *)(v44 + 8);
      *(_QWORD *)v45 = *(_QWORD *)v44;
      *(_DWORD *)(v45 + 8) = v46;
    }
    while ( v17 );
  }
  if ( v112 )
  {
    if ( !byte_F40009D[0] )
    {
      v24 = sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
      byte_F40009D[0] = 1;
    }
    if ( !v28 )
      goto LABEL_120;
    if ( (unsigned int)v19 >= v28[6] )
      goto LABEL_119;
    v47 = &v28[3 * (int)v19];
    v48 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
    v49 = *(_DWORD *)(v48 + 8);
    *((_QWORD *)v47 + 4) = *(_QWORD *)v48;
    v47[10] = v49;
    if ( a3 < 1 )
    {
      v56 = v19 + 1;
      v55 = v19;
    }
    else
    {
      v50 = 0;
      do
      {
        v51 = v19 + v50 + 1;
        if ( v51 >= v28[6] )
          goto LABEL_119;
        sincosf(v22 + (float)((float)((float)v50 * 6.2832) / (float)a3), (float *)&v115 + 1, (float *)&v115);
        v52 = &v28[3 * v51];
        ++v50;
        v53 = v23 * *(float *)&v115;
        v54 = v23 * *((float *)&v115 + 1);
        v52[10] = 0;
        *((float *)v52 + 8) = v53;
        *((float *)v52 + 9) = v54;
      }
      while ( a3 != v50 );
      v55 = v19 + v50;
      v41 = a6;
      v56 = v19 + v50 + 1;
    }
    v57 = v28[6];
    v58 = v55 - a3;
    v40 = v112;
    if ( v58 >= v57 || v56 >= v57 )
    {
LABEL_119:
      sub_63CF128(v24, v25, v26, v27);
      goto LABEL_120;
    }
    v59 = (__int64)&v28[3 * v58 + 8];
    v60 = (__int64)&v28[3 * v56 + 8];
    v61 = *(_DWORD *)(v59 + 8);
    *(_QWORD *)v60 = *(_QWORD *)v59;
    *(_DWORD *)(v60 + 8) = v61;
  }
  if ( v41 )
  {
    if ( !v28 )
      goto LABEL_120;
    v62 = (void *)sub_63CEF64(UnityEngine_Vector3___TypeInfo, (unsigned int)(2 * v28[6]));
    System_Array__CopyTo(v28, v62, 0, nullptr);
    System_Array__CopyTo(v28, v62, v28[6], nullptr);
    v28 = (int *)v62;
  }
  if ( !v13 )
    goto LABEL_120;
  UnityEngine_Mesh__set_vertices(v13, v28, nullptr);
  v24 = sub_63CEF64(UnityEngine_Vector4___TypeInfo, v21);
  v63 = (int *)v24;
  if ( (int)v19 < 1 )
  {
    v68 = 0;
  }
  else
  {
    if ( !v24 )
      goto LABEL_120;
    v64 = 0;
    v65 = (float *)(v24 + 44);
    do
    {
      if ( v64 >= *(unsigned int *)(v24 + 24) )
        goto LABEL_119;
      v66 = (int)v64 / v16;
      *(_QWORD *)(v65 - 3) = 0;
      v67 = (int)v64++ % v16;
      *(v65 - 1) = (float)v67 / (float)((float)v16 + -1.0);
      *v65 = (float)v66 / (float)((float)((float)a4 + 2.0) + -1.0);
      v65 += 4;
    }
    while ( v19 != v64 );
    v68 = v19;
  }
  if ( v14 >= 1 && v40 )
  {
    if ( !v24 )
      goto LABEL_120;
    while ( v68 < *(_DWORD *)(v24 + 24) )
    {
      v69 = v24 + 16LL * (int)v68++;
      --v14;
      *(_OWORD *)(v69 + 32) = unk_276F6C0;
      if ( !v14 )
        goto LABEL_59;
    }
    goto LABEL_119;
  }
LABEL_59:
  if ( v41 )
  {
    if ( !v24 )
      goto LABEL_120;
    v70 = (_DWORD *)sub_63CEF64(UnityEngine_Vector4___TypeInfo, (unsigned int)(2 * *(_DWORD *)(v24 + 24)));
    System_Array__CopyTo(v63, v70, 0, nullptr);
    System_Array__CopyTo(v63, v70, v63[6], nullptr);
    v71 = v63[6];
    if ( v71 >= 1 )
    {
      if ( !v70 )
        goto LABEL_120;
      v72 = v70[6];
      for ( i = 0; i < v71; ++i )
      {
        v74 = v71 + i;
        if ( v74 >= v72 )
          goto LABEL_119;
        v70[4 * v74 + 9] = 1065353216;
        v71 = v63[6];
      }
    }
  }
  else
  {
    v70 = (_DWORD *)v24;
  }
  UnityEngine_Mesh__SetUVs_11(v13, 0, v70, nullptr);
  if ( a4 + 1 > 1 )
    v75 = a4 + 1;
  else
    v75 = 1;
  v76 = a3 * v75;
  if ( v40 )
    v77 = a3;
  else
    v77 = 0;
  v24 = sub_63CEF64(int___TypeInfo, (unsigned int)(3 * (v77 + 2 * v76)));
  v78 = (_DWORD *)v24;
  if ( a3 < 1 )
  {
    if ( !v40 )
      goto LABEL_102;
    v96 = 0;
    if ( !v24 )
      goto LABEL_120;
  }
  else
  {
    v79 = 0;
    v80 = 0;
    v81 = 1;
    do
    {
      if ( (unsigned int)a4 <= 0x7FFFFFFE )
      {
        if ( !v78 )
          goto LABEL_120;
        v82 = v78[6];
        v83 = v81;
        v84 = a4 + 1;
        do
        {
          if ( v79 >= v82 )
            goto LABEL_119;
          v85 = v79;
          v86 = v79 + 1;
          v78[v85 + 8] = v83 - 1;
          if ( v86 >= v82 )
            goto LABEL_119;
          v87 = &v78[v86];
          v88 = v86 + 1;
          v87[8] = v83;
          if ( v88 >= v82 )
            goto LABEL_119;
          v78[v85 + 2 + 8] = a3 + v83;
          if ( v88 + 1 >= v82 )
            goto LABEL_119;
          v24 = (unsigned int)(a3 + v83 + 1);
          v78[v85 + 3 + 8] = v24;
          if ( v88 + 2 >= v82 )
            goto LABEL_119;
          v78[v85 + 4 + 8] = a3 + v83;
          if ( v88 + 3 >= v82 )
            goto LABEL_119;
          --v84;
          v78[v85 + 5 + 8] = v83;
          v83 += v16;
          v79 = v88 + 4;
        }
        while ( v84 );
        v79 = v85 + 6;
      }
      ++v80;
      ++v81;
    }
    while ( v80 != a3 );
    if ( !v40 )
      goto LABEL_102;
    if ( !v78 )
      goto LABEL_120;
    v89 = v78[6];
    v90 = v19 + 1;
    v91 = a3;
    do
    {
      if ( v79 >= v89 )
        goto LABEL_119;
      v92 = v79;
      v93 = v79 + 1;
      v78[v92 + 8] = v19;
      if ( v93 >= v89 )
        goto LABEL_119;
      v94 = &v78[v93];
      v95 = v93 + 1;
      v94[8] = v90 + 1;
      if ( v95 >= v89 )
        goto LABEL_119;
      --v91;
      v79 = v95 + 1;
      v78[v92 + 2 + 8] = v90++;
    }
    while ( v91 );
    v96 = v92 + 3;
  }
  v97 = v78[6];
  v98 = v96 + 1;
  if ( v96 >= v97 )
    goto LABEL_119;
  v78[v96 + 8] = v19;
  if ( v98 >= v97 )
    goto LABEL_119;
  v99 = v96 + 2;
  v78[v98 + 8] = v19 + 1;
  if ( v99 >= v97 )
    goto LABEL_119;
  v78[v99 + 8] = v19 + a3;
LABEL_102:
  if ( v41 )
  {
    if ( !v78 )
      goto LABEL_120;
    v100 = (_DWORD *)sub_63CEF64(int___TypeInfo, (unsigned int)(2 * v78[6]));
    System_Array__CopyTo(v78, v100, 0, nullptr);
    v101 = v78[6];
    if ( v101 >= 1 )
    {
      v102 = 0;
      while ( v102 < v101 )
      {
        if ( !v100 )
          goto LABEL_120;
        v103 = v100[6];
        if ( v101 + v102 >= v103 )
          break;
        v100[v101 + v102 + 8] = v78[v102 + 8] + v21;
        if ( v102 + 2 >= v101 )
          break;
        v104 = v101 + v102 + 1;
        if ( v104 >= v103 )
          break;
        v105 = v102 + 1;
        v100[v104 + 8] = v78[v102 + 2 + 8] + v21;
        if ( v102 + 1 >= v101 )
          break;
        v106 = v101 + v102 + 2;
        if ( v106 >= v103 )
          break;
        v107 = v78[v102 + 1 + 8];
        v102 += 3;
        v100[v106 + 8] = v107 + v21;
        if ( (int)(v105 + 2) >= v101 )
          goto LABEL_116;
      }
      goto LABEL_119;
    }
  }
  else
  {
    v100 = v78;
  }
LABEL_116:
  UnityEngine_Mesh__set_triangles(v13, v100, nullptr);
  v108.n128_f32[0] = v113;
  v109.n64_f32[0] = a0;
  v117 = 0;
  if ( v23 > v113 )
    v108.n128_f32[0] = v23;
  v109.n64_f32[1] = v108.n128_f32[0] + v108.n128_f32[0];
  v108.n128_u64[0] = vmul_f32(v109, (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
  v118 = vzip1q_s32(v108, vrev64q_s32(v108));
  UnityEngine_Mesh__set_bounds(v13, (UnityEngine_Bounds_o *)&v117, nullptr);
  return v13;
}

