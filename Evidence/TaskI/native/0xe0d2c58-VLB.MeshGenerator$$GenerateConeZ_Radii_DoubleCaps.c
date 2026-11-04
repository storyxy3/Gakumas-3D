// 0xe0d2c58 @ 0xe0d2c58
void *__fastcall VLB_MeshGenerator__GenerateConeZ_Radii_DoubleCaps(
        float a0,
        float a1,
        float a2,
        int a3,
        bool a4,
        void *a5)
{
  __int64 v9; // x21
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x0
  void *v13; // x20
  __int64 v14; // x0
  int v15; // w27
  float v16; // s9
  void *v17; // x22
  __int64 v18; // x24
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x22
  __int64 v24; // x23
  int v25; // w2
  int v26; // w3
  int v27; // w4
  void *v28; // x5
  float v29; // s0
  int v30; // w8
  _DWORD *v31; // x22
  int i; // w25
  __int64 v33; // kr00_8
  char v34; // w8
  float v35; // s8
  char v36; // w27
  float v37; // s10
  int v38; // w2
  int v39; // w3
  float *v40; // x9
  float v41; // s0
  unsigned int v42; // w24
  _DWORD *v43; // x9
  __int64 v44; // x8
  int v45; // s1
  _DWORD *v46; // x8
  __int64 v47; // x22
  int v48; // w2
  int v49; // w3
  int v50; // w4
  void *v51; // x5
  __int64 v52; // x8
  __int64 v53; // x0
  void **v54; // x21
  int v55; // w2
  int v56; // w3
  int v57; // w4
  void *v58; // x5
  __int64 v59; // x8
  int v60; // w16
  int v61; // w9
  int v62; // w10
  int v63; // w11
  int v64; // w12
  _DWORD *v65; // x13
  int v66; // w15
  int v67; // w14
  int v68; // w16
  unsigned int v69; // w17
  unsigned int v70; // w15
  __int64 v71; // x23
  int32x4_t v72; // q0
  float32x2_t v73; // d1
  float v76; // [xsp+Ch] [xbp+Ch]
  __int64 v78; // [xsp+20h] [xbp+20h] BYREF
  __int64 v79; // [xsp+28h] [xbp+28h] BYREF
  int32x4_t v80; // [xsp+30h] [xbp+30h]

  if ( (unk_F43DA48 & 1) == 0 )
  {
    sub_63CEE78(&System_Action_int__bool__TypeInfo);
    sub_63CEE78(&System_Func_int__int__TypeInfo);
    sub_63CEE78(&int___TypeInfo);
    sub_63CEE78(&UnityEngine_Mesh_TypeInfo);
    sub_63CEE78(&Method_VLB_MeshGenerator___c__DisplayClass6_0__GenerateConeZ_Radii_DoubleCaps_b__0__);
    sub_63CEE78(&Method_VLB_MeshGenerator___c__DisplayClass6_0__GenerateConeZ_Radii_DoubleCaps_b__1__);
    sub_63CEE78(&VLB_MeshGenerator___c__DisplayClass6_0_TypeInfo);
    sub_63CEE78(&Method_VLB_MeshGenerator___c__DisplayClass6_1__GenerateConeZ_Radii_DoubleCaps_b__2__);
    sub_63CEE78(&VLB_MeshGenerator___c__DisplayClass6_1_TypeInfo);
    sub_63CEE78(&UnityEngine_Vector3___TypeInfo);
    unk_F43DA48 = 1;
  }
  v9 = sub_63CF110(VLB_MeshGenerator___c__DisplayClass6_0_TypeInfo);
  System_Object___ctor((void *)v9, nullptr);
  if ( !v9 )
    goto LABEL_57;
  v12 = UnityEngine_Mesh_TypeInfo;
  *(_DWORD *)(v9 + 16) = a3;
  v13 = (void *)sub_63CF110(v12);
  UnityEngine_Mesh___ctor(v13, nullptr);
  v14 = System_Func_int__int__TypeInfo;
  v15 = 2 * *(_DWORD *)(v9 + 16);
  v16 = fmaxf(a1, 0.001);
  *(_DWORD *)(v9 + 20) = v15;
  v17 = (void *)sub_63CF110(v14);
  System_Func_int__int____ctor(
    v17,
    (void *)v9,
    Method_VLB_MeshGenerator___c__DisplayClass6_0__GenerateConeZ_Radii_DoubleCaps_b__0__,
    nullptr);
  *(_QWORD *)(v9 + 24) = v17;
  v18 = v9 + 24;
  sub_63CEE24((void *)(v9 + 24), (int)v17, v19, v20, v21, v22);
  v23 = (void *)sub_63CF110(System_Func_int__int__TypeInfo);
  System_Func_int__int____ctor(
    v23,
    (void *)v9,
    Method_VLB_MeshGenerator___c__DisplayClass6_0__GenerateConeZ_Radii_DoubleCaps_b__1__,
    nullptr);
  *(_QWORD *)(v9 + 32) = v23;
  v24 = v9 + 32;
  sub_63CEE24((void *)(v9 + 32), (int)v23, v25, v26, v27, v28);
  v29 = 0.0;
  if ( *(_DWORD *)(v9 + 16) == 4 )
    v29 = 0.7854;
  v76 = v29;
  v10 = sub_63CEF64(UnityEngine_Vector3___TypeInfo, (unsigned int)(v15 + 2));
  v30 = *(_DWORD *)(v9 + 16);
  v31 = (_DWORD *)v10;
  if ( v30 >= 1 )
  {
    for ( i = 0; i < v30; ++i )
    {
      sincosf(v76 + (float)((float)((float)i * 6.2832) / (float)v30), (float *)&v78 + 1, (float *)&v78);
      v33 = v78;
      v11 = 0;
      v34 = 1;
      do
      {
        if ( !*(_QWORD *)v18 )
          goto LABEL_57;
        v35 = (float)(int)v11;
        v36 = v34;
        v37 = (float)(int)v11 <= 1.0 ? (float)(int)v11 : 1.0;
        v10 = (*(__int64 (__fastcall **)(_QWORD))(*(_QWORD *)v18 + 24LL))(*(_QWORD *)(*(_QWORD *)v18 + 64LL));
        if ( !v31 )
          goto LABEL_57;
        if ( (unsigned int)(v10 + i) >= v31[6] )
          goto LABEL_58;
        v40 = (float *)&v31[3 * (int)v10 + 3 * i];
        v34 = 0;
        v11 = 1;
        v41 = v16 + (float)((float)(a2 - v16) * v37);
        v40[10] = v35 * a0;
        v40[8] = *(float *)&v33 * v41;
        v40[9] = *((float *)&v33 + 1) * v41;
      }
      while ( (v36 & 1) != 0 );
      v30 = *(_DWORD *)(v9 + 16);
    }
  }
  if ( !*(_QWORD *)v24 )
    goto LABEL_57;
  v10 = (*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))(*(_QWORD *)v24 + 24LL))(
          *(_QWORD *)(*(_QWORD *)v24 + 64LL),
          0,
          *(_QWORD *)(*(_QWORD *)v24 + 40LL));
  v42 = v10;
  if ( !byte_F40009D[0] )
  {
    v10 = sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    byte_F40009D[0] = 1;
  }
  if ( !v31 )
    goto LABEL_57;
  if ( v42 >= v31[6] )
    goto LABEL_58;
  v43 = &v31[3 * v42];
  v44 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
  v45 = *(_DWORD *)(v44 + 8);
  *((_QWORD *)v43 + 4) = *(_QWORD *)v44;
  v43[10] = v45;
  if ( !*(_QWORD *)v24 )
    goto LABEL_57;
  v10 = (*(__int64 (__fastcall **)(_QWORD, __int64, _QWORD))(*(_QWORD *)v24 + 24LL))(
          *(_QWORD *)(*(_QWORD *)v24 + 64LL),
          1,
          *(_QWORD *)(*(_QWORD *)v24 + 40LL));
  if ( (unsigned int)v10 >= v31[6] )
  {
LABEL_58:
    sub_63CF128(v10, v11, v38, v39);
    JUMPOUT(0xE0D3234);
  }
  v46 = &v31[3 * (int)v10];
  *((_QWORD *)v46 + 4) = 0;
  *((float *)v46 + 10) = a0;
  if ( !v13 )
    goto LABEL_57;
  UnityEngine_Mesh__set_vertices(v13, v31, nullptr);
  v47 = sub_63CF110(VLB_MeshGenerator___c__DisplayClass6_1_TypeInfo);
  System_Object___ctor((void *)v47, nullptr);
  if ( !v47 )
    goto LABEL_57;
  *(_QWORD *)(v47 + 32) = v9;
  sub_63CEE24((void *)(v47 + 32), v9, v48, v49, v50, v51);
  v52 = *(_QWORD *)(v47 + 32);
  if ( !v52 )
    goto LABEL_57;
  v53 = sub_63CEF64(int___TypeInfo, (unsigned int)(12 * *(_DWORD *)(v52 + 16)));
  *(_QWORD *)(v47 + 16) = v53;
  v54 = (void **)(v47 + 16);
  sub_63CEE24((void *)(v47 + 16), v53, v55, v56, v57, v58);
  v59 = *(_QWORD *)(v47 + 32);
  *(_DWORD *)(v47 + 24) = 0;
  if ( !v59 )
    goto LABEL_57;
  v60 = *(_DWORD *)(v59 + 16);
  if ( a4 )
    v61 = 1;
  else
    v61 = 2;
  if ( a4 )
    v62 = 2;
  else
    v62 = 1;
  if ( a4 )
    v63 = 4;
  else
    v63 = 5;
  if ( a4 )
    v64 = 5;
  else
    v64 = 4;
  if ( v60 >= 1 )
  {
    v65 = *v54;
    v66 = 0;
    v10 = 0;
    do
    {
      v67 = v66 + 1;
      v68 = v66 + 1 == v60 ? 0 : v66 + 1;
      if ( !v65 )
        goto LABEL_57;
      v69 = v65[6];
      if ( (unsigned int)v10 >= v69 )
        goto LABEL_58;
      v65[(int)v10 + 8] = v66;
      v10 = (unsigned int)(*(_DWORD *)(v47 + 24) + v61);
      if ( (unsigned int)v10 >= v69 )
        goto LABEL_58;
      v65[(int)v10 + 8] = v68;
      v10 = (unsigned int)(*(_DWORD *)(v47 + 24) + v62);
      if ( (unsigned int)v10 >= v69 )
        goto LABEL_58;
      v11 = (unsigned int)(v66 + *(_DWORD *)(v59 + 16));
      v65[(int)v10 + 8] = v11;
      v10 = (unsigned int)(*(_DWORD *)(v47 + 24) + 3);
      if ( (unsigned int)v10 >= v69 )
        goto LABEL_58;
      v11 = (unsigned int)(*(_DWORD *)(v59 + 16) + v68);
      v65[(int)v10 + 8] = v11;
      v10 = (unsigned int)(*(_DWORD *)(v47 + 24) + v63);
      if ( (unsigned int)v10 >= v69 )
        goto LABEL_58;
      v11 = *(unsigned int *)(v59 + 16);
      v10 = (__int64)&v65[(int)v10];
      *(_DWORD *)(v10 + 32) = v66 + v11;
      v70 = *(_DWORD *)(v47 + 24) + v64;
      if ( v70 >= v69 )
        goto LABEL_58;
      v65[v70 + 8] = v68;
      v60 = *(_DWORD *)(v59 + 16);
      v10 = (unsigned int)(*(_DWORD *)(v47 + 24) + 6);
      v66 = v67;
      *(_DWORD *)(v47 + 24) = v10;
    }
    while ( v67 < v60 );
  }
  v71 = sub_63CF110(System_Action_int__bool__TypeInfo);
  System_Action_int__bool____ctor(
    (void *)v71,
    (void *)v47,
    Method_VLB_MeshGenerator___c__DisplayClass6_1__GenerateConeZ_Radii_DoubleCaps_b__2__,
    nullptr);
  if ( !v71 )
  {
LABEL_57:
    v10 = sub_63CF120(v10, v11);
    goto LABEL_58;
  }
  (*(void (__fastcall **)(_QWORD, _QWORD, bool, _QWORD))(v71 + 24))(*(_QWORD *)(v71 + 64), 0, a4, *(_QWORD *)(v71 + 40));
  (*(void (__fastcall **)(_QWORD, __int64, bool, _QWORD))(v71 + 24))(
    *(_QWORD *)(v71 + 64),
    1,
    !a4,
    *(_QWORD *)(v71 + 40));
  UnityEngine_Mesh__set_triangles(v13, *v54, nullptr);
  v72.n128_f32[0] = a2;
  v73.n64_f32[0] = a0;
  v79 = 0;
  if ( v16 > a2 )
    v72.n128_f32[0] = v16;
  v73.n64_f32[1] = v72.n128_f32[0] + v72.n128_f32[0];
  v72.n128_u64[0] = vmul_f32(v73, (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
  v80 = vzip1q_s32(v72, vrev64q_s32(v72));
  UnityEngine_Mesh__set_bounds(v13, (UnityEngine_Bounds_o *)&v79, nullptr);
  return v13;
}

