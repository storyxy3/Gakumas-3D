// Campus.Crowd.BillboardMatricesJobHandler.BillboardMatricesJob$$Execute @ 0xddc65c8
void __fastcall Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__Execute(__int64 a0, int a1, void *a2)
{
  int v3; // w8
  int v6; // w22
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  float v10; // s4
  float v11; // s5
  float32x2_t v12; // d7
  float v13; // s0
  float v14; // s2
  float v15; // s4
  float32x2_t v16; // d1
  float32x2_t v17; // d5
  float v18; // s2
  float32x2_t v19; // d3
  __int128 *v20; // x8
  float v21; // s4
  float32x2_t v22; // d5
  float v23; // s2
  float32x2_t v24; // d3
  float v25; // s16
  float v26; // s2
  float32x2_t v27; // d17
  float32x2_t v28; // d3
  float v29; // s8
  __int128 v30; // q0
  float32x2_t v31; // d9
  __int128 v32; // q0
  float v33; // s10
  __int128 v34; // q4
  __int128 v35; // q5
  float32x2_t v36; // d11
  __int128 v37; // q0
  __int128 v38; // q6
  UnityEngine_Bounds_o *v39; // x0
  __int128 v40; // q1
  void *v41; // x5
  UnityEngine_Matrix4x4_o *v42; // x0
  __int128 v43; // q1
  _OWORD *v44; // x8
  __int128 v45; // q2
  __int128 v46; // q1
  void *v47; // x2
  __int128 v48; // q1
  _OWORD *v49; // x8
  __int128 v50; // q2
  __int128 v51; // [xsp+0h] [xbp+0h] BYREF
  __int64 v52; // [xsp+10h] [xbp+10h]
  __int128 v53; // [xsp+20h] [xbp+20h] BYREF
  __int128 v54; // [xsp+30h] [xbp+30h]
  __int128 v55; // [xsp+40h] [xbp+40h]
  __int128 v56; // [xsp+50h] [xbp+50h]
  __int128 v57; // [xsp+60h] [xbp+60h] BYREF
  __int64 v58; // [xsp+70h] [xbp+70h]
  __int128 v59; // [xsp+80h] [xbp+80h] BYREF
  __int128 v60; // [xsp+90h] [xbp+90h]
  __int128 v61; // [xsp+A0h] [xbp+A0h]
  __int128 v62; // [xsp+B0h] [xbp+B0h]
  __int128 v63; // [xsp+C0h] [xbp+C0h] BYREF
  __int128 v64; // [xsp+D0h] [xbp+D0h]
  __int128 v65; // [xsp+E0h] [xbp+E0h]
  __int128 v66; // [xsp+F0h] [xbp+F0h]
  __int128 v67; // [xsp+100h] [xbp+100h] BYREF
  __int128 v68; // [xsp+110h] [xbp+110h]
  __int128 v69; // [xsp+120h] [xbp+120h]
  __int128 v70; // [xsp+130h] [xbp+130h]
  unsigned __int64 v71; // [xsp+140h] [xbp+140h] BYREF
  __int128 v72; // [xsp+148h] [xbp+148h]
  __int128 v73; // [xsp+158h] [xbp+158h] BYREF
  __int64 v74; // [xsp+168h] [xbp+168h]
  __int128 v75; // [xsp+170h] [xbp+170h]
  __int128 v76; // [xsp+180h] [xbp+180h]
  __int128 v77; // [xsp+190h] [xbp+190h]
  __int128 v78; // [xsp+1A0h] [xbp+1A0h]
  __int128 v79; // [xsp+1B0h] [xbp+1B0h]
  __int64 v80; // [xsp+1C0h] [xbp+1C0h]
  __int128 v81; // [xsp+1D0h] [xbp+1D0h]
  __int128 v82; // [xsp+1E0h] [xbp+1E0h]
  __int128 v83; // [xsp+1F0h] [xbp+1F0h]

  if ( (unk_F43BD00 & 1) == 0 )
  {
    sub_63CEE78(&VL_AABB_AABBUtility_TypeInfo);
    unk_F43BD00 = 1;
  }
  v79 = 0u;
  v80 = 0;
  v81 = 0u;
  v82 = 0u;
  v83 = 0u;
  *(_OWORD *)&STACK[0x200] = 0u;
  if ( a1 <= 31 )
  {
    v6 = a1 - (v3 & 0xFFFFFFFC);
    if ( !byte_F40009D[436] )
    {
      sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
      byte_F40009D[436] = 1;
    }
    v7 = VL_AABB_AABBUtility_TypeInfo;
    v8 = *(_QWORD *)(a0 + 16) + 24LL * (a1 / 32);
    v9 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
    v10 = *(float *)(v8 + 8);
    v11 = *(float *)(v8 + 20);
    v12.n64_u64[0] = *(unsigned __int64 *)(v8 + 12);
    v13 = *(float *)(v9 + 20) * 0.1;
    v14 = v10 - v11;
    v15 = v10 + v11;
    v16.n64_u64[0] = vmul_f32(*(float32x2_t *)(v9 + 12), vdup_n_s32(0x3DCCCCCDu)).n64_u64[0];
    v17.n64_u64[0] = vadd_f32(*(float32x2_t *)v8, v12).n64_u64[0];
    v18 = v14 - v13;
    v19.n64_u64[0] = vsub_f32(vsub_f32(*(float32x2_t *)v8, v12), v16).n64_u64[0];
    v20 = (__int128 *)(*(_QWORD *)a0 + ((__int64)v6 << 6));
    v21 = (float)(v15 - v18) * 0.5;
    v22.n64_u64[0] = vmul_f32(vsub_f32(v17, v19), (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
    v23 = v18 + v21;
    v24.n64_u64[0] = vadd_f32(v19, v22).n64_u64[0];
    v25 = v21 + v23;
    v26 = v23 - v21;
    v27.n64_u64[0] = vadd_f32(v22, v24).n64_u64[0];
    v28.n64_u64[0] = vsub_f32(v24, v22).n64_u64[0];
    v29 = (float)((float)(v13 + v25) - v26) * 0.5;
    v30 = v20[1];
    v31.n64_u64[0] = vmul_f32(vsub_f32(vadd_f32(v16, v27), v28), (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
    v81 = *v20;
    v82 = v30;
    v32 = v20[3];
    v33 = v26 + v29;
    v35 = *v20;
    v34 = v20[1];
    v36.n64_u64[0] = vadd_f32(v28, v31).n64_u64[0];
    v83 = v20[2];
    *(_OWORD *)&STACK[0x200] = v32;
    v38 = v20[2];
    v37 = v20[3];
    LODWORD(v20) = *(_DWORD *)(v7 + 228);
    v75 = v35;
    v76 = v34;
    v77 = v38;
    v78 = v37;
    if ( !(_DWORD)v20 )
      sub_63CEFF4(v7);
    v71 = v36.n64_u64[0];
    v67 = v75;
    v68 = v76;
    *(float32x2_t *)((char *)&v72 + 4) = v31;
    *(float *)&v72 = v33;
    *((float *)&v72 + 3) = v29;
    v69 = v77;
    v70 = v78;
    v39 = VL_AABB_AABBUtility__TransformAABB(
            (UnityEngine_Bounds_o *)&v73,
            (UnityEngine_Bounds_o *)&v71,
            (UnityEngine_Matrix4x4_o *)&v67,
            nullptr);
    v59 = v81;
    v60 = v82;
    v40 = *(_OWORD *)&STACK[0x200];
    v80 = v74;
    v58 = v74;
    v79 = v73;
    v61 = v83;
    v62 = v40;
    v57 = v73;
    v42 = Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__CalculateObjToWorldMatrix(
            (UnityEngine_Matrix4x4_o *)&v63,
            (__int64)v39,
            a1 / 4,
            v6,
            (UnityEngine_Matrix4x4_o *)&v59,
            (UnityEngine_Bounds_o *)&v57,
            v41);
    v43 = v64;
    v44 = (_OWORD *)(*(_QWORD *)(a0 + 32) + ((__int64)a1 << 6));
    *v44 = v63;
    v44[1] = v43;
    v45 = v66;
    v46 = v79;
    v44[2] = v65;
    v44[3] = v45;
    v51 = v46;
    v52 = v80;
    Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__CalculateBillboardMatrix(
      (UnityEngine_Matrix4x4_o *)&v53,
      (__int64)v42,
      (UnityEngine_Bounds_o *)&v51,
      v47);
    v48 = v54;
    v49 = (_OWORD *)(*(_QWORD *)(a0 + 48) + ((__int64)a1 << 6));
    *v49 = v53;
    v49[1] = v48;
    v50 = v56;
    v49[2] = v55;
    v49[3] = v50;
  }
}

