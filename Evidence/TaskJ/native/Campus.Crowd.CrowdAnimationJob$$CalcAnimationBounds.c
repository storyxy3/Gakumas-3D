// Campus.Crowd.CrowdAnimationJob$$CalcAnimationBounds @ 0xddc1238
UnityEngine_Bounds_o *__fastcall Campus_Crowd_CrowdAnimationJob__CalcAnimationBounds(
        UnityEngine_Bounds_o *__return_ptr retstr,
        __int64 a0,
        void *a1,
        void *a2,
        void *a3)
{
  float v9; // s8
  int v10; // w8
  int v11; // w25
  __int64 v12; // x9
  __int64 v13; // x0
  __int64 v14; // x27
  int v15; // w10
  int *v16; // x11
  __int64 v17; // d0
  int v18; // s1
  UnityEngine_Bounds_o *result; // x0
  float v20; // s5
  float32x2_t v21; // d2
  __int64 v22; // x8
  float32x2_t v23; // d3
  float v24; // s4
  __int64 v25; // x8
  float32x2_t v26; // d3
  float v27; // s4
  __int64 v28; // x10
  float v29; // s5
  __int64 v30; // x11
  __int64 v31; // x9
  float32x2_t v32; // d6
  int *v33; // x15
  __int64 v34; // x16
  int v35; // t1
  float v36; // s7
  __int64 v37; // x14
  float v38; // s18
  float32x2_t v39; // d20
  float32x2_t v40; // d2
  float v41; // s4
  float32x2_t *v42; // x14
  float v43; // s16
  float v44; // s17
  float32x2_t v45; // d3
  float v46; // s7
  float32x2_t v47; // d6
  int32x2_t v48; // d21
  float v49; // s5
  int32x2_t v50; // d18
  int8x8_t v51; // d2
  float32x2_t v52; // d17
  float v53; // s3
  float32x2_t v54; // d2
  float v55; // s4
  float32x2_t v56; // d5
  float v57; // s16
  float v58; // s3
  float32x2_t v59; // d17
  float32x2_t v60; // d2
  int32x2_t v61; // d4
  int32x2_t v62; // d5
  float32x2_t v63; // d7
  float32x2_t v64; // d2
  float v65; // [xsp+0h] [xbp+0h]
  __int128 v66; // [xsp+20h] [xbp+20h] BYREF
  __int128 v67; // [xsp+30h] [xbp+30h] BYREF
  __int128 v68; // [xsp+40h] [xbp+40h]

  if ( (unk_F43BCD2 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Enumerator_Vector3__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Enumerator_Vector3__MoveNext__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Enumerator_Vector3__get_Current__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Vector3__GetEnumerator__);
    unk_F43BCD2 = 1;
  }
  v66 = *(_OWORD *)a2;
  v67 = 0u;
  v68 = 0u;
  Unity_Collections_NativeArray_Vector3___GetEnumerator(
    (__int64)&v66,
    Method_Unity_Collections_NativeArray_Vector3__GetEnumerator__);
  v9 = 0.0;
  v10 = DWORD2(v67);
  v12 = Method_Unity_Collections_NativeArray_Enumerator_Vector3__MoveNext__;
  LODWORD(v68) = v68 + 1;
  v11 = v68;
  if ( (int)v68 < SDWORD2(v67) )
  {
    do
    {
      v13 = *(_QWORD *)(v12 + 32);
      v14 = v67;
      v15 = v11;
      if ( (*(_WORD *)(v13 + 309) & 1) == 0 )
      {
        sub_6407F00(v13);
        v12 = Method_Unity_Collections_NativeArray_Enumerator_Vector3__MoveNext__;
        v15 = v68;
        v10 = DWORD2(v67);
      }
      v16 = (int *)(v14 + 12LL * v11);
      v11 = v15 + 1;
      v17 = *(_QWORD *)(v16 + 1);
      v18 = *v16;
      LODWORD(v68) = v15 + 1;
      v9 = v9 + *(float *)&v17;
      DWORD1(v68) = v18;
      *((_QWORD *)&v68 + 1) = v17;
    }
    while ( v15 + 1 < v10 );
  }
  HIDWORD(v68) = 0;
  *(_QWORD *)((char *)&v68 + 4) = 0;
  Unity_Collections_NativeArray_Enumerator_Vector3___Dispose(
    (__int64)&v67,
    Method_Unity_Collections_NativeArray_Enumerator_Vector3__Dispose__);
  v66 = *(_OWORD *)a2;
  v20 = v9 / (float)SDWORD2(v66);
  if ( !byte_F40009D[0] )
  {
    v65 = v9 / (float)SDWORD2(v66);
    result = (UnityEngine_Bounds_o *)sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    v20 = v65;
    byte_F40009D[0] = 1;
  }
  v21.n64_u32[0] = 0;
  v21.n64_f32[1] = v20;
  v22 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
  v23.n64_u64[0] = *(unsigned __int64 *)v22;
  v24 = *(float *)(v22 + 8);
  v25 = *((unsigned int *)a1 + 2);
  v26.n64_u64[0] = vmul_f32(v23, (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
  v27 = v24 * 0.5;
  if ( (int)v25 < 1 )
  {
    v29 = 0.0;
  }
  else
  {
    v28 = *(unsigned int *)(a0 + 72);
    v29 = 0.0;
    v30 = *(_QWORD *)a1;
    v31 = 0;
    do
    {
      v32.n64_u64[0] = 0;
      if ( (int)v28 < 1 )
      {
LABEL_15:
        v36 = 0.0;
      }
      else
      {
        v33 = *(int **)(a0 + 64);
        v34 = 0;
        while ( 1 )
        {
          v35 = *v33++;
          if ( *(_DWORD *)(v30 + 4 * v31) == v35 )
            break;
          v34 += 12;
          if ( 12 * v28 == v34 )
            goto LABEL_15;
        }
        v37 = *(_QWORD *)(a0 + 80) + v34;
        v32.n64_u64[0] = *(unsigned __int64 *)v37;
        v36 = *(float *)(v37 + 8);
      }
      v38 = v29 - v27;
      v39.n64_u64[0] = vsub_f32(v21, v26).n64_u64[0];
      v40.n64_u64[0] = vadd_f32(v26, v21).n64_u64[0];
      v41 = v27 + v29;
      v66 = *(_OWORD *)a2;
      v42 = (float32x2_t *)(v66 + 12 * v31++);
      v43 = v42[1].n64_f32[0];
      v44 = v43 - v36;
      v45.n64_u64[0] = vsub_f32((float32x2_t)v42->n64_u64[0], v32).n64_u64[0];
      v46 = v36 + v43;
      v47.n64_u64[0] = vadd_f32(v32, (float32x2_t)v42->n64_u64[0]).n64_u64[0];
      v48.n64_u64[0] = vcgt_f32(v40, v45).n64_u64[0];
      if ( v38 >= v44 )
        v49 = v44;
      else
        v49 = v38;
      v50.n64_u64[0] = vcgt_f32(v45, v39).n64_u64[0];
      v51.n64_u64[0] = vbsl_s8(v48, v40, v45).n64_u64[0];
      if ( v41 <= v44 )
        v41 = v44;
      v52.n64_u64[0] = vbsl_s8(v50, v39, v45).n64_u64[0];
      v53 = (float)(v41 - v49) * 0.5;
      v54.n64_u64[0] = vmul_f32(vsub_f32(v51, v52), (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
      v55 = v49 + v53;
      v56.n64_u64[0] = vadd_f32(v52, v54).n64_u64[0];
      v57 = v55 - v53;
      v58 = v53 + v55;
      v59.n64_u64[0] = vsub_f32(v56, v54).n64_u64[0];
      v60.n64_u64[0] = vadd_f32(v54, v56).n64_u64[0];
      if ( v57 >= v46 )
        v57 = v46;
      v61.n64_u64[0] = vcgt_f32(v47, v59).n64_u64[0];
      v62.n64_u64[0] = vcgt_f32(v60, v47).n64_u64[0];
      if ( v58 <= v46 )
        v58 = v46;
      v63.n64_u64[0] = vbsl_s8(v61, v59, v47).n64_u64[0];
      v27 = (float)(v58 - v57) * 0.5;
      v64.n64_u64[0] = vsub_f32(vbsl_s8(v62, v60, v47), v63).n64_u64[0];
      v29 = v57 + v27;
      v26.n64_u64[0] = vmul_f32(v64, (float32x2_t)0x3F0000003F000000LL).n64_u64[0];
      v21.n64_u64[0] = vadd_f32(v63, v26).n64_u64[0];
    }
    while ( v31 != v25 );
  }
  *(float32x2_t *)&retstr->c.x = v21;
  retstr->c.z = v29;
  *(float32x2_t *)&retstr->e.x = v26;
  retstr->e.z = v27;
  return result;
}

