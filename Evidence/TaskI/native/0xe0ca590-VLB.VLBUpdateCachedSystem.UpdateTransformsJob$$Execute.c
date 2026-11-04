// VLB.VLBUpdateCachedSystem.UpdateTransformsJob$$Execute @ 0xe0ca590
void __fastcall VLB_VLBUpdateCachedSystem_UpdateTransformsJob__Execute(__int64 a0, int a1, __int64 a2, void *a3)
{
  char v5; // w8
  __int128 v7; // q1
  __int128 v8; // q2
  float *v9; // x10
  __int128 v10; // q1
  __int128 v11; // q2
  __int128 v12; // q3
  float v13; // s5
  __int64 *v14; // x8
  float v15; // s5
  float v16; // s5
  unsigned int v17; // s8
  __int64 v18; // d9
  void *v19; // x2
  __int128 v20; // q0
  __int128 v21; // q1
  __int128 v22; // q2
  _OWORD *v23; // x8
  __int128 v24; // q4
  __int128 v25; // q5
  __int128 v26; // q0
  __int128 v27; // q6
  __int128 v28; // q0
  __int128 v29; // q1
  __int128 v30; // q4
  __int128 v31; // q5
  _OWORD *v32; // x8
  __int128 v33; // q6
  __int128 v34; // q3
  __int128 v35; // q0
  __int64 v36; // x8
  float v37; // [xsp+0h] [xbp+0h]
  float v38; // [xsp+10h] [xbp+10h]
  float v39; // [xsp+20h] [xbp+20h]
  __int128 v40; // [xsp+30h] [xbp+30h] BYREF
  __int128 v41; // [xsp+40h] [xbp+40h]
  __int128 v42; // [xsp+50h] [xbp+50h]
  __int128 v43; // [xsp+60h] [xbp+60h]
  __int128 v44; // [xsp+70h] [xbp+70h] BYREF
  __int64 v45; // [xsp+80h] [xbp+80h]
  __int128 v46; // [xsp+88h] [xbp+88h] BYREF
  __int64 v47; // [xsp+98h] [xbp+98h]
  __int128 v48; // [xsp+A0h] [xbp+A0h]
  __int128 v49; // [xsp+B0h] [xbp+B0h]
  __int128 v50; // [xsp+C0h] [xbp+C0h]
  __int128 v51; // [xsp+D0h] [xbp+D0h]
  unsigned __int64 v52; // [xsp+E0h] [xbp+E0h] BYREF
  __int64 v53; // [xsp+E8h] [xbp+E8h]
  unsigned __int64 v54; // [xsp+F0h] [xbp+F0h]
  __int64 v55; // [xsp+F8h] [xbp+F8h]
  unsigned __int64 v56; // [xsp+100h] [xbp+100h]
  __int64 v57; // [xsp+108h] [xbp+108h]
  __int64 v58; // [xsp+110h] [xbp+110h]
  __int64 v59; // [xsp+118h] [xbp+118h]
  __int128 v60; // [xsp+120h] [xbp+120h] BYREF
  __int128 v61; // [xsp+130h] [xbp+130h]
  __int128 v62; // [xsp+140h] [xbp+140h]
  __int128 v63; // [xsp+150h] [xbp+150h]
  _BYTE v64[32]; // [xsp+160h] [xbp+160h] BYREF
  __int128 v65; // [xsp+180h] [xbp+180h]
  __int128 v66; // [xsp+190h] [xbp+190h]
  __int128 v67; // [xsp+1A0h] [xbp+1A0h]
  __int128 v68; // [xsp+1B0h] [xbp+1B0h]
  __int128 v69; // [xsp+1C0h] [xbp+1C0h]
  __int128 v70; // [xsp+1D0h] [xbp+1D0h]
  __int128 v71; // [xsp+1E0h] [xbp+1E0h] BYREF
  __int128 v72; // [xsp+1F0h] [xbp+1F0h]

  v5 = unk_F43D9CD;
  STACK[0x2E0] = a2;
  STACK[0x2E8] = (unsigned __int64)a3;
  if ( (v5 & 1) == 0 )
  {
    sub_63CEE78(&Unity_Mathematics_float3_TypeInfo);
    unk_F43D9CD = 1;
  }
  UnityEngine_Jobs_TransformAccess__get_localToWorldMatrix(
    (UnityEngine_Matrix4x4_o *)&STACK[0x260],
    (__int64)&STACK[0x2E0],
    nullptr);
  v7 = *(_OWORD *)&STACK[0x270];
  v71 = *(_OWORD *)&STACK[0x260];
  v72 = v7;
  v8 = *(_OWORD *)&STACK[0x290];
  *(_OWORD *)&STACK[0x200] = *(_OWORD *)&STACK[0x280];
  *(_OWORD *)&STACK[0x210] = v8;
  Unity_Mathematics_float4x4__op_Implicit((UnityEngine_Matrix4x4_o *)&v71, nullptr);
  v9 = (float *)(*(_QWORD *)(a0 + 16) + 12LL * a1);
  v10 = *(_OWORD *)&STACK[0x230];
  v11 = *(_OWORD *)&STACK[0x240];
  v12 = *(_OWORD *)&STACK[0x250];
  v13 = *v9;
  v48 = *(_OWORD *)&STACK[0x220];
  v49 = v10;
  v50 = v11;
  v51 = v12;
  v14 = *(__int64 **)(Unity_Mathematics_float3_TypeInfo + 184LL);
  v37 = v13;
  v15 = v9[1];
  v67 = v48;
  v68 = v10;
  v69 = v11;
  v70 = v12;
  v38 = v15;
  v16 = v9[2];
  v17 = *((_DWORD *)v14 + 2);
  v18 = *v14;
  LODWORD(v65) = 0;
  v39 = v16;
  *(_OWORD *)v64 = 0u;
  *(_OWORD *)&v64[16] = 0u;
  Unity_Mathematics_float3x3___ctor_2((__int64)v64, 0, v19);
  v60 = v67;
  v61 = v68;
  HIDWORD(v53) = 0;
  HIDWORD(v55) = 0;
  v62 = v69;
  v63 = v70;
  v52 = vmul_n_f32(*(float32x2_t *)v64, v37).n64_u64[0];
  *(float *)&v53 = v37 * *(float *)&v64[8];
  HIDWORD(v57) = 0;
  v58 = v18;
  v59 = v17 | 0x3F80000000000000LL;
  v54 = vmul_n_f32(*(float32x2_t *)&v64[12], v38).n64_u64[0];
  *(float *)&v55 = v38 * *(float *)&v64[20];
  v56 = vmul_n_f32(*(float32x2_t *)&v64[24], v39).n64_u64[0];
  *(float *)&v57 = v39 * *(float *)&v65;
  sub_D7D0E8C(v64, &v60, &v52, 0);
  v20 = v51;
  v21 = *(_OWORD *)v64;
  v22 = *(_OWORD *)&v64[16];
  v23 = (_OWORD *)(*(_QWORD *)(a0 + 32) + ((__int64)a1 << 6));
  v24 = v65;
  v25 = v66;
  v23[2] = v50;
  v23[3] = v20;
  v26 = v48;
  v27 = v49;
  *(_OWORD *)&STACK[0x2A0] = v21;
  *(_OWORD *)&STACK[0x2B0] = v22;
  *(_OWORD *)&STACK[0x2C0] = v24;
  *(_OWORD *)&STACK[0x2D0] = v25;
  *v23 = v26;
  v23[1] = v27;
  v28 = *(_OWORD *)&STACK[0x2D0];
  v29 = *(_OWORD *)&STACK[0x2B0];
  v30 = *(_OWORD *)&STACK[0x2C0];
  v31 = *(_OWORD *)&STACK[0x2D0];
  v32 = (_OWORD *)(*(_QWORD *)(a0 + 48) + ((__int64)a1 << 6));
  v32[2] = *(_OWORD *)&STACK[0x2C0];
  v32[3] = v28;
  v33 = *(_OWORD *)&STACK[0x2B0];
  v34 = *(_OWORD *)&STACK[0x2A0];
  *v32 = *(_OWORD *)&STACK[0x2A0];
  v32[1] = v29;
  v41 = v33;
  v42 = v30;
  v43 = v31;
  v44 = unk_2770410;
  v45 = 0x3F0000003F800000LL;
  v40 = v34;
  VLB_Utils__TransformAABB((UnityEngine_Bounds_o *)&v46, (UnityEngine_Bounds_o *)&v44, (__int64)&v40, nullptr);
  v35 = v46;
  v36 = *(_QWORD *)(a0 + 64) + 24LL * a1;
  *(_QWORD *)(v36 + 16) = v47;
  *(_OWORD *)v36 = v35;
}

