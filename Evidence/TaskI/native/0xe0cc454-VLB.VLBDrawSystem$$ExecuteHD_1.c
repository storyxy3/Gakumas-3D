// 0xe0cc454 @ 0xe0cc454
void __fastcall VLB_VLBDrawSystem__ExecuteHD_1(
        void *a0,
        void *a1,
        void *a2,
        void *a3,
        void *a4,
        int a5,
        void *a6,
        void *a7,
        void *a8)
{
  char v11; // w8
  void *v15; // x19
  _BOOL8 enableInstancing; // x0
  __int64 visibleLights; // x0
  void *v18; // x1
  int v19; // w2
  int v20; // w3
  double timeAsDouble; // d8
  __int64 v22; // x9
  double v23; // d0
  float v24; // s8
  int *v25; // x9
  int v26; // w8
  int v27; // w9
  __int64 v28; // x19
  __int64 v29; // x22
  __int64 v30; // x26
  int v31; // w27
  __int64 v32; // x8
  __int64 v33; // x23
  int v34; // w28
  __int64 v35; // x0
  void *v36; // x29
  float *v37; // x8
  float v38; // s10
  float v39; // s11
  float v40; // s9
  float v41; // s12
  int v42; // w24
  void *v43; // x29
  int v44; // w24
  void *v45; // x1
  void *v46; // x24
  int v47; // w29
  float v48; // s9
  __int128 *v49; // x8
  __int128 v50; // q0
  __int128 v51; // q2
  __int128 v52; // q3
  __int128 v53; // q1
  int v54; // w1
  __int128 v55; // q2
  __int128 *v56; // x8
  __int128 v57; // q0
  __int128 v58; // q2
  __int128 v59; // q3
  void *v60; // x6
  void *v61; // x0
  void *v62; // x1
  __int64 v63; // [xsp+10h] [xbp+10h]
  __int64 v64; // [xsp+18h] [xbp+18h]
  void *v65; // [xsp+40h] [xbp+40h]
  void *v66; // [xsp+48h] [xbp+48h]
  void *v67; // [xsp+50h] [xbp+50h]
  void *v68; // [xsp+58h] [xbp+58h]
  __int64 v69; // [xsp+60h] [xbp+60h]
  __int128 v71; // [xsp+70h] [xbp+70h] BYREF
  __int128 v72; // [xsp+80h] [xbp+80h]
  __int128 v73; // [xsp+90h] [xbp+90h]
  __int128 v74; // [xsp+A0h] [xbp+A0h]
  __int128 v75; // [xsp+B0h] [xbp+B0h] BYREF
  __int128 v76; // [xsp+C0h] [xbp+C0h]
  __int128 v77; // [xsp+D0h] [xbp+D0h]
  __int128 v78; // [xsp+E0h] [xbp+E0h]
  __int128 v79; // [xsp+F0h] [xbp+F0h] BYREF
  __int128 v80; // [xsp+100h] [xbp+100h]
  __int128 v81; // [xsp+110h] [xbp+110h]
  __int128 v82; // [xsp+120h] [xbp+120h]
  __int128 v83; // [xsp+130h] [xbp+130h]
  __int128 v84; // [xsp+140h] [xbp+140h]
  __int128 v85; // [xsp+150h] [xbp+150h]
  __int128 v86; // [xsp+160h] [xbp+160h]
  __int128 v87; // [xsp+170h] [xbp+170h] BYREF
  __int128 v88; // [xsp+180h] [xbp+180h]
  __int128 v89; // [xsp+190h] [xbp+190h]
  __int128 v90; // [xsp+1A0h] [xbp+1A0h]
  __int128 v91; // [xsp+1B0h] [xbp+1B0h] BYREF
  __int128 v92; // [xsp+1C0h] [xbp+1C0h]
  __int128 v93; // [xsp+1D0h] [xbp+1D0h]
  __int128 v94; // [xsp+1E0h] [xbp+1E0h]
  __int128 v95; // [xsp+1F0h] [xbp+1F0h] BYREF
  UnityEngine_Vector4_o v96; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v97; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v98; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v99; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v11 = unk_F43D9E2;
  STACK[0x288] = (unsigned __int64)a2;
  if ( (v11 & 1) == 0 )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    a0 = (void *)sub_63CEE78(&VLB_VLBDrawSystem_TypeInfo);
    unk_F43D9E2 = 1;
  }
  STACK[0x278] = 0;
  STACK[0x270] = 0;
  if ( a3 )
  {
    *(_OWORD *)&STACK[0x270] = *(_OWORD *)((char *)a3 + 24);
    Unity_Jobs_JobHandle__Complete((__int64)&STACK[0x270], nullptr);
    if ( a4 )
    {
      *(_OWORD *)&STACK[0x270] = *(_OWORD *)((char *)a4 + 24);
      Unity_Jobs_JobHandle__Complete((__int64)&STACK[0x270], nullptr);
      if ( STACK[0x288] )
      {
        if ( !a5 )
          return;
        v15 = *(void **)(STACK[0x288] + 80);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        a0 = (void *)UnityEngine_Object__op_Equality(v15, nullptr, nullptr);
        if ( ((unsigned __int8)a0 & 1) != 0 )
          return;
        if ( v15 )
        {
          enableInstancing = UnityEngine_Material__get_enableInstancing(v15, nullptr);
          if ( !a7 || !enableInstancing )
            return;
          v67 = VLB_GlobalMeshHD__Get((void *)enableInstancing);
          visibleLights = UnityEngine_Rendering_CullingResults__get_visibleLights((__int64)a6, nullptr);
          v68 = v18;
          v69 = visibleLights;
          timeAsDouble = UnityEngine_Time__get_timeAsDouble(nullptr);
          a0 = (void *)System_Math_TypeInfo;
          if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
            sub_63CEFF4(System_Math_TypeInfo);
          v63 = **((unsigned int **)a4 + 17);
          if ( **((int **)a4 + 17) < 1 )
            return;
          v22 = 0;
          v65 = v15;
          v66 = a1;
          v23 = floor(timeAsDouble * 60.0) * 1.61803399;
          v24 = v23 - floor(v23);
          while ( 1 )
          {
            v64 = v22;
            v25 = (int *)(*((_QWORD *)a4 + 15) + 8 * v22);
            v26 = *v25;
            v27 = v25[1];
            if ( v27 > v26 )
              break;
LABEL_34:
            v22 = v64 + 1;
            if ( v64 + 1 == v63 )
              return;
          }
          v28 = 4LL * v26;
          v29 = 16LL * v26;
          v30 = (__int64)v26 << 6;
          v31 = v27 - v26;
          while ( 1 )
          {
            v32 = *(_QWORD *)(STACK[0x288] + 56);
            if ( !v32 )
              break;
            v33 = *(int *)(*((_QWORD *)a4 + 19) + v28);
            if ( (unsigned int)v33 >= *(_DWORD *)(v32 + 24) )
              goto LABEL_37;
            a0 = (void *)VLB_VLBDrawSystem__GetShadowLightIndex(a0, *(void **)(v32 + 8 * v33 + 32), v69, v68, a7);
            if ( ((unsigned int)a0 & 0x80000000) == 0 )
            {
              v34 = (int)a0;
              v35 = VLB_VLBDrawSystem_TypeInfo;
              v36 = *((void **)a3 + 5);
              v37 = (float *)(*((_QWORD *)a4 + 11) + 4 * v29);
              v38 = v37[4];
              v39 = v37[5];
              v40 = v37[1];
              v41 = v37[9];
              if ( !*(_DWORD *)(VLB_VLBDrawSystem_TypeInfo + 228LL) )
              {
                sub_63CEFF4(VLB_VLBDrawSystem_TypeInfo);
                v35 = VLB_VLBDrawSystem_TypeInfo;
              }
              v42 = **(_DWORD **)(v35 + 184);
              v98 = Unity_Mathematics_float4__op_Implicit_3(0, a1);
              if ( !v36 )
                break;
              UnityEngine_MaterialPropertyBlock__SetVector_1(v36, v42, v98, nullptr);
              v43 = *((void **)a3 + 5);
              v44 = *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 4LL);
              v99 = Unity_Mathematics_float4__op_Implicit_3(0, v45);
              if ( !v43 )
                break;
              UnityEngine_MaterialPropertyBlock__SetVector_1(v43, v44, v99, nullptr);
              a0 = *((void **)a3 + 5);
              if ( !a0 )
                break;
              v96.x = v40;
              v96.y = v39;
              v96.z = v41;
              v96.w = v38;
              UnityEngine_MaterialPropertyBlock__SetVector_1(
                a0,
                *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 8LL),
                v96,
                nullptr);
              v46 = *((void **)a3 + 5);
              a0 = (void *)System_Math_TypeInfo;
              v47 = *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 16LL);
              v48 = *(float *)(*((_QWORD *)a3 + 43) + 4 * v33);
              if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
                sub_63CEFF4(System_Math_TypeInfo);
              if ( !v46 )
                break;
              v97.z = 0.0;
              v97.w = 0.0;
              v97.x = v48;
              v97.y = v24;
              UnityEngine_MaterialPropertyBlock__SetVector_1(v46, v47, v97, nullptr);
              v49 = (__int128 *)(*((_QWORD *)a3 + 9) + (v33 << 6));
              v50 = v49[1];
              v51 = v49[2];
              v52 = v49[3];
              v91 = *v49;
              v92 = v50;
              v93 = v51;
              v94 = v52;
              *(_OWORD *)&STACK[0x230] = v91;
              *(_OWORD *)&STACK[0x240] = v50;
              *(_OWORD *)&STACK[0x250] = v51;
              *(_OWORD *)&STACK[0x260] = v52;
              Unity_Mathematics_float4x4__op_Implicit_1((UnityEngine_Matrix4x4_o *)&v95, (__int64)&v91, nullptr);
              a0 = *((void **)a3 + 5);
              if ( !a0 )
                break;
              v53 = *(_OWORD *)&STACK[0x200];
              v54 = *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 20LL);
              v87 = v95;
              v88 = v53;
              v55 = *(_OWORD *)&STACK[0x220];
              v89 = *(_OWORD *)&STACK[0x210];
              v90 = v55;
              UnityEngine_MaterialPropertyBlock__SetMatrix_1(a0, v54, (UnityEngine_Matrix4x4_o *)&v87, nullptr);
              if ( !v66 )
                break;
              UnityEngine_Rendering_CommandBuffer__SetGlobalInt(
                v66,
                *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 24LL),
                v34,
                nullptr);
              v56 = (__int128 *)(*((_QWORD *)a4 + 5) + v30);
              v57 = v56[1];
              v58 = v56[2];
              v59 = v56[3];
              v75 = *v56;
              v76 = v57;
              v77 = v58;
              v78 = v59;
              v83 = v75;
              v84 = v57;
              v85 = v58;
              v86 = v59;
              Unity_Mathematics_float4x4__op_Implicit_1((UnityEngine_Matrix4x4_o *)&v79, (__int64)&v75, nullptr);
              v60 = *((void **)a3 + 5);
              v71 = v79;
              v72 = v80;
              v73 = v81;
              v74 = v82;
              UnityEngine_Rendering_CommandBuffer__DrawMesh(
                v66,
                v67,
                (UnityEngine_Matrix4x4_o *)&v71,
                v65,
                0,
                0,
                v60,
                nullptr);
            }
            --v31;
            v28 += 4;
            v29 += 16;
            v30 += 64;
            if ( !v31 )
              goto LABEL_34;
          }
        }
      }
    }
  }
  a0 = (void *)sub_63CF120(a0, a1);
LABEL_37:
  sub_63CF128(a0, a1, v19, v20);
  VLB_VLBDrawSystem__MarkRendered(v61, v62);
}

