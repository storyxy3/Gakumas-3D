// 0xd1d3b98 @ 0xd1d3b98
// local variable allocation has failed, the output may be wrong!
void __fastcall ProFlareBatchForSRPData__ScheduleFlares(void *a0, bool a1, void *a2)
{
  char *v3; // x22
  __int64 v4; // x8
  _DWORD *v5; // x20
  _OWORD *v6; // x26
  __int64 v7; // x0
  void *v8; // x1
  _DWORD *UnsafePtr_ProFlareUpdateInOutputData; // x21
  float time; // s0
  int v11; // w8
  int v12; // w22
  void *Item; // x23
  __int64 v14; // x8
  void *v15; // x24
  void *v16; // x25
  float v17; // s0
  void *v18; // x22
  bool usesReversedZBuffer; // w21
  int v20; // s0
  int v21; // s12
  int v22; // s1
  int v23; // s13
  int v24; // s2
  int v25; // s14
  int v26; // s0
  int v27; // s1
  int v28; // s2
  int v29; // s10
  int v30; // s15
  int v31; // s9
  __int128 v32; // q1
  __int128 v33; // q2
  __int128 v34; // q1
  __int128 v35; // q2
  __int64 v36; // x8
  __int128 v37; // q0
  int v38; // w9
  __int64 v39; // x1
  __int128 v40; // q0
  __int128 v41; // q1
  __int128 v42; // q1
  __int128 v43; // q2
  unsigned __int64 v44; // x1
  void *UnsafePtr_ProFlareUpdateElementData; // x0
  void *v46; // x1
  __int64 v47; // x8
  char *UnsafePtr_ProFlareInputData; // x21
  int v49; // w8
  float v50; // s12
  unsigned __int8 *v51; // x22
  int v52; // w26
  int i; // w23
  int v54; // w9
  void *v55; // x0
  int v56; // w2
  int v57; // w3
  int v58; // w4
  void *v59; // x5
  unsigned __int64 v60; // x10
  unsigned __int64 v61; // x8
  void *v62; // x24
  void *v63; // x24
  void *v64; // x24
  unsigned __int64 v65; // x8
  int v66; // s0
  int v67; // s1
  int v68; // s2
  void *v69; // x24
  unsigned __int64 v70; // x8
  unsigned __int64 v71; // x8
  float v72; // s2
  float v73; // s8
  bool v74; // cc
  float v75; // s1
  int v76; // w9
  float v77; // s0
  float v78; // s3
  float v79; // s0
  float v80; // s3
  float v81; // s0
  float v82; // s9
  float v83; // s0
  float v84; // s3
  float v85; // s4
  float v86; // s3
  float v87; // s4
  float v88; // s6
  float v89; // s5
  _BOOL4 v90; // w9
  float v91; // s0
  float v92; // s0
  float v93; // s7
  float v94; // s0
  _BOOL4 v95; // w9
  float v96; // s5
  float v97; // s2
  float v98; // s2
  float v99; // s1
  float v100; // s0
  unsigned __int64 v101; // x8
  float v102; // s10
  float v103; // s11
  float v104; // s1
  float v105; // s0
  float v106; // s14
  float v107; // s3
  float v108; // s1
  float v109; // s1
  float v110; // s0
  float v111; // s0
  float v112; // s0
  float v113; // s1
  int v114; // w9
  float v115; // s0
  float v116; // s1
  int v117; // w24
  void *v118; // x0
  int v119; // w2
  int v120; // w3
  int v121; // w4
  void *v122; // x5
  void *v123; // x4
  unsigned __int64 v124; // x8
  __int128 v125; // q0
  int v126; // w9
  unsigned __int64 v127; // x9
  float *v128; // x11
  bool v129; // zf
  int v130; // w10
  float *v131; // x9
  float v132; // s0
  float v133; // s1
  unsigned __int64 v134; // x9
  float *v135; // x11
  int v136; // w10
  float *v137; // x9
  float v138; // s3
  int v139; // w9
  float v140; // s1
  unsigned __int64 v141; // x9
  int v142; // w8
  int v143; // w25
  void *v144; // x4
  unsigned __int64 v145; // x9
  float v149; // s12
  float *v150; // x9
  float v151; // s13
  float v152; // s15
  float v153; // s6
  unsigned __int64 v154; // x8
  int v155; // w9
  __int64 v156; // x8
  float v157; // s8
  float v158; // s9
  float v159; // s10
  float v160; // s11
  float v161; // s14
  float v162; // s15
  __int64 v163; // x8
  __int128 v164; // q0
  char v165; // w9
  __int128 v166; // q0
  __int128 v167; // q1
  char v168; // w9
  __int128 v169; // q1
  int v170; // w9
  char v171; // w8
  __int128 v172; // q0
  unsigned __int64 v173; // x9
  __int64 v174; // x1
  float aspect; // [xsp+2Ch] [xbp+2Ch]
  char *v176; // [xsp+30h] [xbp+30h]
  float v177; // [xsp+3Ch] [xbp+3Ch]
  float v178; // [xsp+3Ch] [xbp+3Ch]
  float v179; // [xsp+40h] [xbp+40h]
  float v180; // [xsp+40h] [xbp+40h]
  float v181; // [xsp+44h] [xbp+44h]
  float v182; // [xsp+44h] [xbp+44h]
  float v183; // [xsp+48h] [xbp+48h]
  float v184; // [xsp+48h] [xbp+48h]
  float v185; // [xsp+4Ch] [xbp+4Ch]
  float v186; // [xsp+4Ch] [xbp+4Ch]
  __int128 v187; // [xsp+50h] [xbp+50h] BYREF
  __int128 v188; // [xsp+60h] [xbp+60h]
  __int128 v189; // [xsp+70h] [xbp+70h]
  __int128 v190; // [xsp+80h] [xbp+80h]
  __int128 v191; // [xsp+90h] [xbp+90h]
  __int128 v192; // [xsp+A0h] [xbp+A0h]
  __int128 v193; // [xsp+B0h] [xbp+B0h]
  __int128 v194; // [xsp+C0h] [xbp+C0h]
  __int128 v195; // [xsp+D0h] [xbp+D0h] BYREF
  __int128 v196; // [xsp+E0h] [xbp+E0h]
  __int128 v197; // [xsp+F0h] [xbp+F0h]
  __int128 v198; // [xsp+100h] [xbp+100h]
  __int128 v199; // [xsp+110h] [xbp+110h] BYREF
  __int128 v200; // [xsp+120h] [xbp+120h]
  __int128 v201; // [xsp+130h] [xbp+130h]
  __int128 v202; // [xsp+140h] [xbp+140h]
  __int128 v203; // [xsp+150h] [xbp+150h] BYREF
  __int128 v204; // [xsp+160h] [xbp+160h]
  __int128 v205; // [xsp+170h] [xbp+170h]
  __int128 v206; // [xsp+180h] [xbp+180h]
  __int128 v207; // [xsp+190h] [xbp+190h] BYREF
  __int128 v208; // [xsp+1A0h] [xbp+1A0h]
  __int128 v209; // [xsp+1B0h] [xbp+1B0h]
  __int128 v210; // [xsp+1C0h] [xbp+1C0h]
  __int128 v211; // [xsp+1D0h] [xbp+1D0h] BYREF
  __int128 v212; // [xsp+1E0h] [xbp+1E0h]
  __int128 v213; // [xsp+1F0h] [xbp+1F0h]
  UnityEngine_Vector3_o position; // 0:kr14_12.12
  UnityEngine_Vector3_o forward; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Vector3_o v216; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Vector3_o v217; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Color_o v218; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Color_o v219; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Quaternion_o rotation; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v3 = (char *)a0;
  STACK[0x3B8] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  if ( (unk_F42C949 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_Unity_Jobs_IJobParallelForExtensions_Schedule_ProFlareUpdateElementJob___);
    sub_63CEE78(&Method_UnityEngine_Jobs_IJobParallelForTransformExtensions_ScheduleReadOnly_ProFlareUpdateJob___);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlare__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareElement__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_SubElement__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlare__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareElement__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_SubElement__get_Item__);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_ProFlareInputData___);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_ProFlareUpdateElementData___);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_ProFlareUpdateInOutputData___);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ProFlareUpdateInOutputData__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&ProFlareBatchForSRPData_TypeInfo);
    a0 = (void *)sub_63CEE78(&StringLiteral_Flare______);
    unk_F42C949 = 1;
  }
  STACK[0x3A8] = 0;
  *((_DWORD *)v3 + 55) = 4;
  v4 = *((_QWORD *)v3 + 4);
  STACK[0x3A0] = 0;
  LODWORD(STACK[0x3B0]) = 0;
  *(_OWORD *)&STACK[0x2F0] = 0u;
  *(_OWORD *)&STACK[0x300] = 0u;
  STACK[0x2E8] = 0;
  STACK[0x2E0] = 0;
  LODWORD(STACK[0x2DC]) = 0;
  STACK[0x2C8] = 0;
  STACK[0x2C0] = 0;
  STACK[0x2D0] = 0;
  STACK[0x2B0] = 0;
  *(_OWORD *)&STACK[0x290] = 0u;
  *(_OWORD *)&STACK[0x2A0] = 0u;
  STACK[0x390] = 0;
  STACK[0x388] = 0;
  STACK[0x397] = 0;
  *((_DWORD *)v3 + 52) = 0;
  if ( !v4 )
    goto LABEL_217;
  v5 = *(_DWORD **)(v4 + 48);
  if ( !v5 )
    goto LABEL_217;
  if ( v5[6] <= *((_DWORD *)v3 + 30) )
  {
    v6 = v3 + 144;
    if ( *((_QWORD *)v3 + 18) )
    {
      a0 = *((void **)v3 + 5);
      if ( !a0 )
        goto LABEL_221;
      aspect = UnityEngine_Camera__get_aspect(a0, nullptr);
      v7 = *((_QWORD *)v3 + 18);
      v8 = *((void **)v3 + 19);
      v176 = v3;
      *(_OWORD *)&STACK[0x300] = *((_OWORD *)v3 + 7);
      UnsafePtr_ProFlareUpdateInOutputData = Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_ProFlareUpdateInOutputData_(
                                               v7,
                                               v8);
      time = UnityEngine_Time__get_time(nullptr);
      v11 = v5[6];
      *(float *)&STACK[0x2F8] = time;
      LODWORD(STACK[0x2FC]) = 0;
      if ( v11 >= 1 )
      {
        v12 = 0;
        do
        {
          Item = System_Collections_Generic_List_object___get_Item(
                   v5,
                   v12,
                   Method_System_Collections_Generic_List_ProFlare__get_Item__);
          if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Object_TypeInfo);
          a0 = (void *)UnityEngine_Object__op_Equality(Item, nullptr, nullptr);
          if ( ((unsigned __int8)a0 & 1) != 0 )
            goto LABEL_31;
          if ( !Item )
            goto LABEL_217;
          if ( !*((_BYTE *)Item + 41) )
            goto LABEL_31;
          v14 = *((_QWORD *)v176 + 4);
          if ( !v14 )
            goto LABEL_217;
          v15 = *((void **)Item + 4);
          v16 = *(void **)(v14 + 40);
          if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Object_TypeInfo);
          a0 = (void *)UnityEngine_Object__op_Inequality(v15, v16, nullptr);
          if ( ((unsigned __int8)a0 & 1) != 0 || *((float *)Item + 24) < 0.001 )
            goto LABEL_31;
          v17 = *((float *)Item + 25);
          if ( v17 <= *((float *)Item + 26) )
            v17 = *((float *)Item + 26);
          if ( v17 <= *((float *)Item + 27) )
            v17 = *((float *)Item + 27);
          if ( v17 < 0.001 || *((float *)Item + 22) < 0.01 )
            goto LABEL_31;
          a0 = *((void **)Item + 7);
          if ( !a0 )
            goto LABEL_217;
          if ( UnityEngine_Transform__get_localScale(a0, nullptr).x < 0.01 )
          {
LABEL_31:
            if ( !UnsafePtr_ProFlareUpdateInOutputData )
              goto LABEL_217;
            *(_BYTE *)UnsafePtr_ProFlareUpdateInOutputData = 0;
          }
          else
          {
            if ( !UnsafePtr_ProFlareUpdateInOutputData )
              goto LABEL_217;
            *(_BYTE *)UnsafePtr_ProFlareUpdateInOutputData = 1;
            UnsafePtr_ProFlareUpdateInOutputData[1] = *((_DWORD *)Item + 43);
          }
          ++v12;
          UnsafePtr_ProFlareUpdateInOutputData += 8;
        }
        while ( v12 < v5[6] );
      }
      a0 = *((void **)v176 + 5);
      if ( !a0 )
        goto LABEL_221;
      a0 = UnityEngine_Component__get_transform(a0, nullptr);
      if ( !a0 )
        goto LABEL_221;
      v18 = a0;
      position = UnityEngine_Transform__get_position(a0, nullptr);
      STACK[0x3A8] = 0;
      STACK[0x3A0] = 0;
      LODWORD(STACK[0x3B0]) = 0;
      usesReversedZBuffer = UnityEngine_SystemInfo__get_usesReversedZBuffer(nullptr);
      Unity_Mathematics_float3__op_Implicit_3(position, nullptr);
      v21 = v20;
      v23 = v22;
      v25 = v24;
      forward = UnityEngine_Transform__get_forward(v18, nullptr);
      Unity_Mathematics_float3__op_Implicit_3(forward, nullptr);
      a0 = *((void **)v176 + 5);
      if ( !a0 )
        goto LABEL_221;
      v29 = v26;
      v30 = v27;
      v31 = v28;
      UnityEngine_Camera__get_projectionMatrix((UnityEngine_Matrix4x4_o *)&STACK[0x250], a0, nullptr);
      v32 = *(_OWORD *)&STACK[0x260];
      v211 = *(_OWORD *)&STACK[0x250];
      v212 = v32;
      v33 = *(_OWORD *)&STACK[0x280];
      v213 = *(_OWORD *)&STACK[0x270];
      *(_OWORD *)&STACK[0x200] = v33;
      UnityEngine_GL__GetGPUProjectionMatrix(
        (UnityEngine_Matrix4x4_o *)&STACK[0x210],
        (UnityEngine_Matrix4x4_o *)&v211,
        0,
        nullptr);
      a0 = *((void **)v176 + 5);
      if ( !a0 )
        goto LABEL_221;
      UnityEngine_Camera__get_worldToCameraMatrix((UnityEngine_Matrix4x4_o *)&v207, a0, nullptr);
      v34 = *(_OWORD *)&STACK[0x220];
      v199 = *(_OWORD *)&STACK[0x210];
      v200 = v34;
      v35 = *(_OWORD *)&STACK[0x240];
      v201 = *(_OWORD *)&STACK[0x230];
      v202 = v35;
      v195 = v207;
      v196 = v208;
      v197 = v209;
      v198 = v210;
      UnityEngine_Matrix4x4__op_Multiply(
        (UnityEngine_Matrix4x4_o *)&v203,
        (UnityEngine_Matrix4x4_o *)&v199,
        (UnityEngine_Matrix4x4_o *)&v195,
        nullptr);
      v187 = v203;
      v188 = v204;
      v189 = v205;
      v190 = v206;
      a0 = (void *)Unity_Mathematics_float4x4__op_Implicit((UnityEngine_Matrix4x4_o *)&v187, nullptr);
      v36 = *((_QWORD *)v176 + 4);
      *(_OWORD *)&STACK[0x3A4] = *v6;
      if ( !v36 )
      {
LABEL_221:
        while ( 1 )
LABEL_217:
          a0 = (void *)sub_63CF120(a0, a1);
      }
      v37 = *(_OWORD *)&STACK[0x3A0];
      v38 = STACK[0x3B0];
      v39 = *(_QWORD *)(v36 + 96);
      STACK[0x2E8] = 0;
      *(_OWORD *)&STACK[0x36C] = v37;
      v40 = v193;
      v41 = v194;
      STACK[0x2E0] = 0;
      LODWORD(STACK[0x37C]) = v38;
      LOBYTE(STACK[0x310]) = usesReversedZBuffer;
      LOWORD(STACK[0x311]) = 0;
      LOBYTE(STACK[0x313]) = 0;
      LODWORD(STACK[0x314]) = v21;
      LODWORD(STACK[0x318]) = v23;
      LODWORD(STACK[0x31C]) = v25;
      LODWORD(STACK[0x320]) = v29;
      LODWORD(STACK[0x324]) = v30;
      *(_OWORD *)&STACK[0x35C] = v41;
      v42 = v191;
      v43 = v192;
      LODWORD(STACK[0x328]) = v31;
      *(_OWORD *)&STACK[0x34C] = v40;
      *(_OWORD *)&STACK[0x33C] = v43;
      *(_OWORD *)&STACK[0x32C] = v42;
      STACK[0x2E0] = UnityEngine_Jobs_IJobParallelForTransformExtensions__ScheduleReadOnly_ProFlareUpdateJob_(
                       (__int64)&STACK[0x310],
                       v39,
                       32,
                       0,
                       nullptr);
      STACK[0x2E8] = v44;
      Unity_Jobs_JobHandle__Complete((__int64)&STACK[0x2E0], nullptr);
      UnsafePtr_ProFlareUpdateElementData = Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_ProFlareUpdateElementData_(
                                              *((_QWORD *)v176 + 16),
                                              *((void **)v176 + 17));
      v47 = *((_QWORD *)v176 + 23);
      v46 = *((void **)v176 + 24);
      STACK[0x2F0] = (unsigned __int64)UnsafePtr_ProFlareUpdateElementData;
      UnsafePtr_ProFlareInputData = (char *)Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_ProFlareInputData_(
                                              v47,
                                              v46);
      a0 = Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_ProFlareUpdateInOutputData_(
             *((_QWORD *)v176 + 18),
             *((void **)v176 + 19));
      v49 = v5[6];
      LODWORD(STACK[0x2DC]) = 0;
      if ( v49 <= 0 )
      {
        *((_DWORD *)v176 + 53) = 0;
        *((_DWORD *)v176 + 54) = 0;
        *((_DWORD *)v176 + 52) = v49;
      }
      else
      {
        v50 = 1.0;
        v51 = (unsigned __int8 *)a0;
        v52 = 0;
        for ( i = 0; i < v49; LODWORD(STACK[0x2DC]) = i )
        {
          if ( !v51 )
            goto LABEL_217;
          v54 = *v51;
          *(_DWORD *)UnsafePtr_ProFlareInputData = v54;
          if ( v54 )
          {
            v55 = System_Collections_Generic_List_object___get_Item(
                    v5,
                    i,
                    Method_System_Collections_Generic_List_ProFlare__get_Item__);
            STACK[0x2C0] = (unsigned __int64)v55;
            sub_63CEE24(&STACK[0x2C0], (int)v55, v56, v57, v58, v59);
            v60 = *((_QWORD *)v51 + 1);
            v61 = STACK[0x2C0];
            LODWORD(STACK[0x2D4]) = *((_DWORD *)v51 + 4);
            STACK[0x2CC] = v60;
            if ( !v61 )
              goto LABEL_217;
            if ( *(_BYTE *)(v61 + 229) )
            {
              v62 = *(void **)(v61 + 232);
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              a0 = (void *)UnityEngine_Object__op_Inequality(v62, nullptr, nullptr);
              if ( ((unsigned __int8)a0 & 1) != 0 )
              {
                if ( !STACK[0x2C0] )
                  goto LABEL_217;
                v63 = *(void **)(STACK[0x2C0] + 240);
                if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                  sub_63CEFF4(UnityEngine_Object_TypeInfo);
                a0 = (void *)UnityEngine_Object__op_Inequality(v63, nullptr, nullptr);
                if ( ((unsigned __int8)a0 & 1) != 0 )
                {
                  if ( !STACK[0x2C0] )
                    goto LABEL_217;
                  a0 = *(void **)(STACK[0x2C0] + 232);
                  if ( !a0 )
                    goto LABEL_217;
                  UnityEngine_Transform__set_position(a0, position, nullptr);
                  if ( !STACK[0x2C0] )
                    goto LABEL_217;
                  a0 = *(void **)(STACK[0x2C0] + 240);
                  if ( !a0 )
                    goto LABEL_217;
                  v64 = *((void **)v176 + 5);
                  v216 = UnityEngine_Transform__get_position(a0, nullptr);
                  if ( !v64 )
                    goto LABEL_217;
                  v217 = UnityEngine_Camera__WorldToViewportPoint_1(v64, v216, nullptr);
                  a0 = (void *)Unity_Mathematics_float3__op_Implicit_3(v217, nullptr);
                  v65 = STACK[0x2C0];
                  LODWORD(STACK[0x2CC]) = v66;
                  LODWORD(STACK[0x2D0]) = v67;
                  LODWORD(STACK[0x2D4]) = v68;
                  if ( !v65 )
                    goto LABEL_217;
                  a0 = *(void **)(v65 + 56);
                  if ( !a0 )
                    goto LABEL_217;
                  v69 = *(void **)(v65 + 232);
                  rotation = UnityEngine_Transform__get_rotation(a0, nullptr);
                  if ( !v69 )
                    goto LABEL_217;
                  UnityEngine_Transform__set_rotation(v69, rotation, nullptr);
                }
              }
            }
            v70 = STACK[0x2D0];
            *(_OWORD *)&STACK[0x310] = *(_OWORD *)&STACK[0x2C0];
            STACK[0x320] = v70;
            *(_QWORD *)(UnsafePtr_ProFlareInputData + 4) = STACK[0x31C];
            *((_DWORD *)UnsafePtr_ProFlareInputData + 3) = STACK[0x324];
            v71 = STACK[0x2C0];
            if ( !STACK[0x2C0] )
              goto LABEL_217;
            v72 = *(float *)&STACK[0x2CC];
            v73 = 1.0;
            v74 = *(float *)&STACK[0x2CC] <= 0.0;
            *((_QWORD *)UnsafePtr_ProFlareInputData + 2) = *(_QWORD *)(v71 + 164);
            v75 = *(float *)&STACK[0x2D0];
            v76 = !v74;
            if ( v72 >= 1.0 )
              v76 = 0;
            if ( v76 != 1 || v75 <= 0.0 || v75 >= v50 )
            {
              v77 = 0.0;
              v78 = 0.0;
              if ( (v76 & 1) == 0 )
              {
                if ( v72 <= 0.5 )
                  v78 = fabsf(v72);
                else
                  v78 = v72 + -1.0;
              }
              if ( v75 <= 0.0 || v75 >= v50 )
              {
                if ( v75 <= 0.5 )
                  v77 = fabsf(v75);
                else
                  v77 = v75 + -1.0;
              }
              if ( v78 > v77 )
                v77 = v78;
              v79 = v50 - (float)((float)(v50 / *(float *)(v71 + 172)) * v77);
              if ( v79 <= v50 )
                v80 = v79;
              else
                v80 = v50;
              if ( v79 >= 0.0 )
                v73 = v80;
              else
                v73 = 0.0;
            }
            v81 = *(float *)(v71 + 220);
            v82 = 0.0;
            if ( v72 > (float)(0.5 - v81)
              && v81 > 0.0
              && v72 < (float)(v81 + 0.5)
              && v75 > (float)(0.5 - v81)
              && v75 < (float)(v81 + 0.5) )
            {
              v83 = v50 / v81;
              v84 = fabsf(v72 + -0.5);
              v85 = fabsf(v75 + -0.5);
              if ( v84 <= v85 )
                v84 = v85;
              v82 = v50 - (float)(v84 * v83);
            }
            v86 = *(float *)(v71 + 188);
            v87 = *(float *)(v71 + 192);
            v88 = v87 + 0.0;
            v89 = (float)(v87 + 0.0) + v86;
            if ( v72 > v89 )
            {
              v90 = 0;
              v91 = (float)(v50 - v87) - v86;
              if ( v72 < v91 && v75 > v89 )
                v90 = v75 < v91;
            }
            else
            {
              v90 = 0;
            }
            v92 = 0.0;
            if ( (float)(v72 + v86) > v88 )
            {
              v93 = v50 - v87;
              if ( (float)(v72 - v86) < (float)(v50 - v87)
                && (float)(v75 + v86) > v88
                && (float)(v75 - v86) < v93
                && !v90 )
              {
                v94 = v50 / v86;
                v95 = v75 <= v89;
                if ( v75 >= (float)(v93 - v86) )
                  v95 = 1;
                if ( v72 <= v89 || (v96 = 0.0, v72 >= (float)(v93 - v86)) )
                {
                  if ( v72 <= 0.5 )
                    v97 = vabds_f32(v72 - v87, v86);
                  else
                    v97 = (float)((float)(v72 + -1.0) + v87) + v86;
                  v96 = (float)(v94 * v97) * 0.5;
                }
                v98 = 0.0;
                if ( v95 )
                {
                  if ( v75 <= 0.5 )
                    v99 = vabds_f32(v75 - v87, v86);
                  else
                    v99 = (float)((float)(v75 + -1.0) + v87) + v86;
                  v98 = (float)(v94 * v99) * 0.5;
                }
                if ( v96 <= v98 )
                  v92 = v98;
                else
                  v92 = v96;
              }
            }
            a0 = *(void **)(v71 + 200);
            if ( !a0 )
              goto LABEL_217;
            v100 = UnityEngine_AnimationCurve__Evaluate(a0, v92, nullptr);
            v101 = STACK[0x2C0];
            if ( !STACK[0x2C0] )
              goto LABEL_217;
            v102 = v100;
            v103 = 1.0;
            if ( *(_BYTE *)(v101 + 124) )
            {
              v104 = *((float *)v51 + 5);
              v105 = *(float *)(v101 + 128);
              v106 = 0.0;
              if ( v104 <= v105 )
                v107 = *((float *)v51 + 5);
              else
                v107 = *(float *)(v101 + 128);
              if ( v104 >= (float)-v105 )
                v108 = v107;
              else
                v108 = -v105;
              v109 = fabsf(v108);
              if ( v109 <= v105 )
              {
                v110 = (float)(v50 / (float)(v105 * -0.5)) * v109;
                v106 = v110 + v50;
                if ( *(_BYTE *)(v101 + 134) )
                {
                  a0 = *(void **)(v101 + 136);
                  if ( !a0 )
                    goto LABEL_217;
                  v111 = UnityEngine_AnimationCurve__Evaluate(a0, v110 + v50, nullptr);
                  v101 = STACK[0x2C0];
                  if ( !STACK[0x2C0] )
                    goto LABEL_217;
                  v106 = v111;
                }
              }
            }
            else
            {
              v106 = 1.0;
            }
            if ( *(_BYTE *)(v101 + 116) )
            {
              v103 = v50 - (float)(*((float *)v51 + 6) / *(float *)(v101 + 120));
              if ( v103 < 0.001 )
              {
                *(_DWORD *)UnsafePtr_ProFlareInputData = 0;
                v101 = STACK[0x2C0];
              }
            }
            v112 = *(float *)&STACK[0x2CC];
            v113 = *(float *)&STACK[0x2D0];
            v114 = *(_DWORD *)UnsafePtr_ProFlareInputData;
            LODWORD(STACK[0x2D4]) = 0;
            LODWORD(STACK[0x2C8]) = 1065353216;
            v115 = v112 + -0.5;
            v116 = v113 + -0.5;
            if ( !v114 )
              v73 = 0.0;
            *(float *)&STACK[0x2D0] = v116 + v116;
            *(float *)&STACK[0x2CC] = (float)(aspect * v115) + (float)(aspect * v115);
            if ( !v101 )
              goto LABEL_217;
            if ( *(_BYTE *)(v101 + 92) )
              LODWORD(STACK[0x2C8]) = *((_DWORD *)v51 + 7);
            v117 = 0;
            while ( 1 )
            {
              a0 = *(void **)(v101 + 48);
              if ( !a0 )
                goto LABEL_217;
              if ( v117 >= *((_DWORD *)a0 + 6) )
                break;
              v118 = System_Collections_Generic_List_object___get_Item(
                       a0,
                       v117,
                       Method_System_Collections_Generic_List_ProFlareElement__get_Item__);
              STACK[0x290] = (unsigned __int64)v118;
              sub_63CEE24(&STACK[0x290], (int)v118, v119, v120, v121, v122);
              v124 = STACK[0x2C0];
              if ( !STACK[0x2C0] )
                goto LABEL_217;
              v125 = *(_OWORD *)(v124 + 100);
              v126 = *(unsigned __int8 *)(v124 + 176);
              LODWORD(STACK[0x2B0]) = 1065353216;
              LODWORD(STACK[0x2A8]) = 0;
              *(_OWORD *)&STACK[0x298] = v125;
              if ( v126 )
              {
                v127 = STACK[0x290];
                if ( !STACK[0x290] )
                  goto LABEL_217;
                v128 = (float *)(v127 + 260);
                v129 = *(_BYTE *)(v127 + 256) == 0;
                v130 = *(unsigned __int8 *)(v127 + 272);
                v131 = (float *)(v127 + 276);
                if ( v129 )
                  v128 = (float *)(v124 + 180);
                if ( !v130 )
                  v131 = (float *)(v124 + 184);
                v132 = (float)(v102 * *v128) + v50;
                v133 = (float)(v102 * *v131) + 0.0;
                *(float *)&STACK[0x2B0] = v132;
                *(float *)&STACK[0x2A8] = v133;
              }
              else
              {
                v133 = 0.0;
                v132 = 1.0;
              }
              if ( *(_BYTE *)(v124 + 208) )
              {
                v134 = STACK[0x290];
                if ( !STACK[0x290] )
                  goto LABEL_217;
                v135 = (float *)(v134 + 268);
                v129 = *(_BYTE *)(v134 + 264) == 0;
                v136 = *(unsigned __int8 *)(v134 + 280);
                v137 = (float *)(v134 + 284);
                if ( v129 )
                  v135 = (float *)(v124 + 212);
                if ( !v136 )
                  v137 = (float *)(v124 + 216);
                v138 = v82 * *v137;
                v132 = v132 + (float)(v82 * *v135);
                *(float *)&STACK[0x2B0] = v132;
                *(float *)&STACK[0x2A8] = v133 + v138;
              }
              if ( v132 < 0.0 )
              {
                v132 = 0.0;
                LODWORD(STACK[0x2B0]) = 0;
              }
              if ( *(_BYTE *)(v124 + 132) )
              {
                v132 = v106 * v132;
                *(float *)&STACK[0x2B0] = v132;
              }
              if ( *(_BYTE *)(v124 + 117) )
              {
                v132 = v103 * v132;
                *(float *)&STACK[0x2B0] = v132;
              }
              v139 = *(unsigned __int8 *)(v124 + 118);
              if ( *(_BYTE *)(v124 + 133) )
                v140 = v106;
              else
                v140 = v50;
              *(float *)&STACK[0x2AC] = v140;
              if ( v139 )
              {
                v140 = v103 * v140;
                *(float *)&STACK[0x2AC] = v140;
              }
              v141 = STACK[0x290];
              *(float *)&STACK[0x2AC] = v73 * v140;
              if ( !v141 )
                goto LABEL_217;
              if ( *(_BYTE *)(v141 + 17) )
              {
                if ( v132 > 0.001
                  && !*(_BYTE *)(v124 + 257)
                  && SLODWORD(STACK[0x2FC]) < SLODWORD(STACK[0x308])
                  && *(_DWORD *)(v141 + 20) < *((_DWORD *)v176 + 24) )
                {
                  v142 = *(_DWORD *)(v141 + 304);
                  if ( v142 )
                  {
                    if ( v142 == 1 )
                    {
                      v143 = 0;
                      while ( 1 )
                      {
                        a0 = *(void **)(v141 + 288);
                        if ( !a0 )
                          goto LABEL_217;
                        if ( v143 >= *((_DWORD *)a0 + 6) )
                          break;
                        a0 = System_Collections_Generic_List_object___get_Item(
                               a0,
                               v143,
                               Method_System_Collections_Generic_List_SubElement__get_Item__);
                        if ( !a0 )
                          goto LABEL_217;
                        v145 = STACK[0x290];
                        if ( !STACK[0x290] )
                          goto LABEL_217;
                        v218 = *((UnityEngine_Color_o *)a0 + 1);
                        v149 = *(float *)(v145 + 140);
                        if ( *(_BYTE *)(v145 + 84) )
                          v150 = (float *)((char *)a0 + 48);
                        else
                          v150 = (float *)(v145 + 80);
                        v151 = *((float *)a0 + 16);
                        v152 = *((float *)a0 + 17);
                        v153 = *v150;
                        if ( !*(_DWORD *)(ProFlareBatchForSRPData_TypeInfo + 228LL) )
                        {
                          v183 = *((float *)a0 + 5);
                          v185 = *((float *)a0 + 4);
                          v179 = *((float *)a0 + 7);
                          v181 = *((float *)a0 + 6);
                          v177 = *v150;
                          sub_63CEFF4(ProFlareBatchForSRPData_TypeInfo);
                          v153 = v177;
                          v218.a = v179;
                          v218.r = v185;
                          v218.b = v181;
                          v218.g = v183;
                        }
                        ProFlareBatchForSRPData___ScheduleFlares_g__UpdateElementJobData_48_0(
                          v218,
                          v152,
                          v149 + v151,
                          v153,
                          &STACK[0x2F0],
                          &STACK[0x2DC],
                          &STACK[0x2C0],
                          &STACK[0x290],
                          v144);
                        v50 = 1.0;
                        if ( SLODWORD(STACK[0x2FC]) >= SLODWORD(STACK[0x308]) )
                          break;
                        v141 = STACK[0x290];
                        ++v143;
                        if ( !STACK[0x290] )
                          goto LABEL_217;
                      }
                    }
                  }
                  else
                  {
                    v178 = v73;
                    v180 = v106;
                    v182 = v103;
                    v184 = v102;
                    v186 = v82;
                    v157 = *(float *)(v141 + 192);
                    v158 = *(float *)(v141 + 196);
                    v159 = *(float *)(v141 + 200);
                    v160 = *(float *)(v141 + 204);
                    v161 = *(float *)(v141 + 140);
                    v162 = *(float *)(v141 + 80);
                    if ( !*(_DWORD *)(ProFlareBatchForSRPData_TypeInfo + 228LL) )
                      sub_63CEFF4(ProFlareBatchForSRPData_TypeInfo);
                    v219.r = v157;
                    v219.g = v158;
                    v219.b = v159;
                    v219.a = v160;
                    ProFlareBatchForSRPData___ScheduleFlares_g__UpdateElementJobData_48_0(
                      v219,
                      1.0,
                      v161,
                      v162,
                      &STACK[0x2F0],
                      &STACK[0x2DC],
                      &STACK[0x2C0],
                      &STACK[0x290],
                      v123);
                    v102 = v184;
                    v82 = v186;
                    v73 = v178;
                    v106 = v180;
                    v103 = v182;
                  }
                }
              }
              else
              {
                LODWORD(STACK[0x2B0]) = 0;
              }
              v154 = STACK[0x290];
              if ( !STACK[0x290] )
                goto LABEL_217;
              v155 = *(_DWORD *)(v154 + 304);
              if ( v155 == 1 )
              {
                v156 = *(_QWORD *)(v154 + 288);
                if ( !v156 )
                  goto LABEL_217;
                v52 += *(_DWORD *)(v156 + 24);
              }
              else if ( !v155 )
              {
                ++v52;
              }
              v101 = STACK[0x2C0];
              ++v117;
              if ( !STACK[0x2C0] )
                goto LABEL_217;
            }
            v49 = v5[6];
          }
          ++i;
          UnsafePtr_ProFlareInputData += 24;
          v51 += 32;
        }
        *(_QWORD *)&a1 = LODWORD(STACK[0x2FC]);
        *((_DWORD *)v176 + 52) = v49;
        *((_DWORD *)v176 + 53) = v52;
        *((_DWORD *)v176 + 54) = a1;
        if ( a1 >= 1 )
        {
          v163 = *((_QWORD *)v176 + 4);
          STACK[0x390] = 0;
          STACK[0x388] = 0;
          STACK[0x397] = 0;
          if ( !v163 )
            goto LABEL_217;
          STACK[0x2E8] = 0;
          STACK[0x2E0] = 0;
          v164 = *((_OWORD *)v176 + 8);
          v165 = *(_BYTE *)(v163 + 129);
          LOWORD(STACK[0x311]) = 0;
          LOBYTE(STACK[0x313]) = 0;
          *(_OWORD *)&STACK[0x38F] = v164;
          v167 = *(_OWORD *)&STACK[0x2F0];
          v166 = *(_OWORD *)&STACK[0x300];
          LOBYTE(STACK[0x310]) = v165;
          v168 = *(_BYTE *)(v163 + 104);
          LOWORD(STACK[0x319]) = 0;
          *(_OWORD *)&STACK[0x250] = v167;
          *(_OWORD *)&STACK[0x260] = v166;
          v169 = *(_OWORD *)(v176 + 88);
          *(_OWORD *)&STACK[0x338] = v166;
          LODWORD(v166) = *(_DWORD *)(v163 + 132);
          *(_OWORD *)&STACK[0x348] = v169;
          LODWORD(STACK[0x314]) = v166;
          LOBYTE(STACK[0x318]) = v168;
          v170 = *(_DWORD *)(v163 + 108);
          v171 = *(_BYTE *)(v163 + 112);
          v172 = *(_OWORD *)&STACK[0x388];
          LOBYTE(STACK[0x31B]) = 0;
          LODWORD(STACK[0x31C]) = v170;
          v173 = STACK[0x397];
          LOBYTE(STACK[0x320]) = v171;
          STACK[0x330] = v173;
          *(_OWORD *)&STACK[0x321] = v172;
          *((_QWORD *)v176 + 20) = Unity_Jobs_IJobParallelForExtensions__Schedule_ProFlareUpdateElementJob_(
                                     (__int64)&STACK[0x310],
                                     a1,
                                     32,
                                     0,
                                     nullptr);
          *((_QWORD *)v176 + 21) = v174;
        }
      }
    }
  }
  else
  {
    if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Debug_TypeInfo);
    UnityEngine_Debug__LogError(StringLiteral_Flare______, nullptr);
  }
}

