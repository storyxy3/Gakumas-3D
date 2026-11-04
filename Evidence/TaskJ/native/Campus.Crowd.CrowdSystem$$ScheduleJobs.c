// Campus.Crowd.CrowdSystem$$ScheduleJobs @ 0xddc4918
bool __fastcall Campus_Crowd_CrowdSystem__ScheduleJobs(
        void *a0,
        UnityEngine_Matrix4x4_o *a1,
        UnityEngine_Vector3_o a2,
        UnityEngine_Vector4_o a3,
        void *a4)
{
  float w; // s8
  float z; // s9
  float y; // s10
  float x; // s11
  float v9; // s12
  float v10; // s13
  float v12; // s14
  void *v14; // x21
  _BOOL8 v15; // x0
  __int64 v16; // x1
  __int64 v17; // x8
  void *v18; // x21
  _QWORD *v19; // x8
  __int64 v20; // x8
  __int64 v21; // x8
  void *v22; // x0
  bool v23; // w21
  __int64 v25; // x0
  __int64 v26; // x0
  __int64 v27; // x1
  __int64 v28; // x8
  _DWORD *v29; // x8
  unsigned int v30; // s3
  unsigned int v31; // s1
  unsigned int v32; // s15
  __int64 v33; // x0
  __int64 v34; // x1
  __int64 v35; // x8
  int v36; // w21
  _QWORD *v37; // x20
  __int64 v38; // x22
  __int64 v39; // x0
  __int64 v40; // x2
  __int64 v41; // x0
  __int64 v42; // x1
  __int64 v43; // x8
  __int64 v44; // x23
  __int64 v45; // x24
  __int64 v46; // x0
  __int64 v47; // x1
  __int64 v48; // x25
  __int64 v49; // x22
  __int128 v50; // q0
  __int64 v51; // x8
  __int64 v52; // x0
  void *v53; // x1
  void *v54; // x22
  __int64 v55; // x21
  __int64 v56; // x0
  __int64 v57; // x1
  _OWORD *v58; // x8
  __int64 v59; // x9
  __int64 v60; // x20
  __int64 v61; // x23
  unsigned int v62; // w24
  void *v63; // x1
  void *v64; // x21
  void *v65; // x20
  void *v66; // x0
  void *AnimationComponent; // x0
  void *v68; // x2
  __int64 v69; // x0
  __int64 v70; // x1
  void *v71; // x1
  void *v72; // x0
  void *v73; // x19
  int v74; // w1
  __int128 v75; // [xsp+0h] [xbp+0h]
  __int128 v76; // [xsp+10h] [xbp+10h]
  __int128 v77; // [xsp+20h] [xbp+20h]
  __int128 v78; // [xsp+30h] [xbp+30h]
  unsigned int v79; // [xsp+48h] [xbp+48h]
  unsigned int v80; // [xsp+4Ch] [xbp+4Ch]
  __int64 v81; // [xsp+50h] [xbp+50h] BYREF
  char *v82; // [xsp+58h] [xbp+58h]
  __int128 v83; // [xsp+60h] [xbp+60h] BYREF
  __int128 v84; // [xsp+70h] [xbp+70h]
  __int128 v85; // [xsp+80h] [xbp+80h]
  __int128 v86; // [xsp+90h] [xbp+90h]
  __int128 v87; // [xsp+A0h] [xbp+A0h]
  __int128 v88; // [xsp+B0h] [xbp+B0h]
  __int128 v89; // [xsp+C0h] [xbp+C0h] BYREF
  __int128 v90; // [xsp+D0h] [xbp+D0h] BYREF
  __int128 v91; // [xsp+E0h] [xbp+E0h]
  __int128 v92; // [xsp+F0h] [xbp+F0h]
  __int128 v93; // [xsp+100h] [xbp+100h]
  __int128 v94; // [xsp+110h] [xbp+110h] BYREF
  __int128 v95; // [xsp+138h] [xbp+138h]
  __int64 v96; // [xsp+148h] [xbp+148h]
  unsigned __int64 v97; // [xsp+150h] [xbp+150h]
  unsigned __int64 v98; // [xsp+158h] [xbp+158h]
  unsigned __int64 v99; // [xsp+160h] [xbp+160h]
  __int64 v100; // [xsp+168h] [xbp+168h]
  unsigned __int64 v101; // [xsp+170h] [xbp+170h]
  unsigned __int64 v102; // [xsp+178h] [xbp+178h]
  unsigned __int64 v103; // [xsp+180h] [xbp+180h]
  unsigned __int64 v104; // [xsp+188h] [xbp+188h]
  __int64 v105; // [xsp+190h] [xbp+190h]
  __int64 v106; // [xsp+1E8h] [xbp+1E8h] BYREF

  w = a3.w;
  z = a3.z;
  y = a3.y;
  x = a3.x;
  v9 = a2.z;
  v10 = a2.y;
  v12 = a2.x;
  if ( (unk_F43BD16 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystem_TypeInfo);
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_CrowdModelData_SubMeshData___);
    sub_63CEE78(&Method_Unity_Jobs_IJobExtensions_Schedule_CrowdSortJob___);
    sub_63CEE78(&Method_Unity_Jobs_IJobParallelForExtensions_Schedule_CrowdCullJob___);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_OctreeInfo__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_PersonInfo__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__AsDeferredJobArray__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__AsParallelWriter__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__Clear__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__get_Capacity__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_CellSortData__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD16 = 1;
  }
  BYTE4(v106) = 0;
  v85 = 0u;
  v86 = 0u;
  v87 = 0u;
  v88 = 0u;
  v83 = 0u;
  v84 = 0u;
  if ( !Unity_Jobs_JobHandle__get_IsCompleted((__int64)a0 + 88, nullptr) )
    Unity_Jobs_JobHandle__Complete((__int64)a0 + 88, nullptr);
  v14 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v15 = UnityEngine_Object__op_Equality(v14, nullptr, nullptr);
  if ( v15 )
    return 0;
  v17 = *((_QWORD *)a0 + 5);
  if ( !v17 )
  {
    v26 = sub_63CF120(v15, v16);
    goto LABEL_45;
  }
  v18 = *(void **)(v17 + 80);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v18, nullptr, nullptr) )
  {
    v19 = *((_QWORD **)a0 + 10);
    if ( v19 )
    {
      if ( v19[10] )
      {
        if ( v19[8] )
        {
          if ( v19[12] )
          {
            v20 = *((_QWORD *)a0 + 7);
            if ( v20 )
            {
              v21 = *(_QWORD *)(v20 + 16);
              v22 = v21 ? *(void **)(v21 + 24) : nullptr;
              if ( !Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_object_(
                      v22,
                      Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_CrowdModelData_SubMeshData___) )
              {
                v25 = Campus_Crowd_CrowdSystem_TypeInfo;
                if ( !*(_DWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 228LL) )
                {
                  sub_63CEFF4(Campus_Crowd_CrowdSystem_TypeInfo);
                  v25 = Campus_Crowd_CrowdSystem_TypeInfo;
                }
                UnityEngine_Rendering_ProfilingScope___ctor(
                  (__int64)&v106 + 4,
                  nullptr,
                  *(void **)(*(_QWORD *)(v25 + 184) + 24LL),
                  nullptr);
                v28 = *((_QWORD *)a0 + 5);
                v81 = 0;
                v82 = (char *)&v106 + 4;
                if ( v28 )
                {
                  v29 = *(_DWORD **)(v28 + 80);
                  if ( v29 )
                  {
                    v30 = v29[27];
                    v32 = v29[28];
                    v31 = v29[29];
                    LODWORD(v106) = v29[26];
                    v91 = 0u;
                    v92 = 0u;
                    v93 = 0u;
                    v94 = 0u;
                    v79 = v31;
                    v80 = v30;
                    v89 = 0u;
                    v90 = 0u;
                    sub_D7D08AC(&v89, a1, 0);
                    v33 = (__int64)memcpy(&v83, &v89, 0x60u);
                    v35 = *((_QWORD *)a0 + 10);
                    if ( v35 )
                    {
                      v36 = *(_DWORD *)(v35 + 88);
                      v37 = (char *)a0 + 104;
                      v38 = *((_QWORD *)a0 + 13);
                      if ( !v38 )
                        goto LABEL_34;
                      v39 = *(_QWORD *)(Method_Unity_Collections_NativeList_CellSortData__get_Capacity__ + 32LL);
                      if ( (*(_WORD *)(v39 + 309) & 1) == 0 )
                        sub_6407F00(v39);
                      if ( *(_DWORD *)(v38 + 12) < v36 )
                        Unity_Collections_NativeList_CellSortData___Dispose(
                          (__int64)a0 + 104,
                          Method_Unity_Collections_NativeList_CellSortData__Dispose__);
                      if ( !*v37 )
                      {
LABEL_34:
                        v40 = (unsigned int)Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, nullptr);
                        *(_QWORD *)&v89 = 0;
                        Unity_Collections_NativeList_CellSortData____ctor_1(
                          (__int64)&v89,
                          v36,
                          v40,
                          Method_Unity_Collections_NativeList_CellSortData___ctor__);
                        *v37 = v89;
                      }
                      Unity_Collections_NativeList_CellSortData___Clear(
                        (__int64)a0 + 104,
                        Method_Unity_Collections_NativeList_CellSortData__Clear__);
                      v43 = *((_QWORD *)a0 + 10);
                      if ( v43 )
                      {
                        v44 = *(_QWORD *)(v43 + 80);
                        v45 = *(_QWORD *)(v43 + 88);
                        v46 = Unity_Collections_NativeList_CellSortData___AsParallelWriter(
                                (__int64)a0 + 104,
                                Method_Unity_Collections_NativeList_CellSortData__AsParallelWriter__);
                        v48 = *((_QWORD *)a0 + 10);
                        if ( v48 )
                        {
                          v49 = v46;
                          memcpy((char *)&v90 + 8, &v83, 0x60u);
                          v50 = *(_OWORD *)(v48 + 176);
                          v51 = *(_QWORD *)(v48 + 192);
                          *(_QWORD *)&v89 = v44;
                          *((_QWORD *)&v89 + 1) = v45;
                          v95 = v50;
                          v96 = v51;
                          v97 = __PAIR64__(v80, v106);
                          *(_QWORD *)&v90 = v49;
                          v98 = __PAIR64__(v79, v32);
                          v99 = __PAIR64__(LODWORD(v10), LODWORD(v12));
                          v100 = LODWORD(v9);
                          v52 = Unity_Jobs_IJobParallelForExtensions__Schedule_CrowdCullJob_(
                                  (__int64)&v89,
                                  v36,
                                  32,
                                  0,
                                  nullptr);
                          v54 = v53;
                          v55 = v52;
                          v56 = Unity_Collections_NativeList_CellSortData___AsDeferredJobArray(
                                  (__int64)a0 + 104,
                                  Method_Unity_Collections_NativeList_CellSortData__AsDeferredJobArray__);
                          v58 = *((_OWORD **)a0 + 10);
                          if ( v58 )
                          {
                            v59 = *((_QWORD *)a0 + 7);
                            if ( v59 )
                            {
                              v60 = v56;
                              v61 = v57;
                              v62 = *(_DWORD *)(v59 + 148);
                              v75 = v58[8];
                              v76 = v58[7];
                              v77 = v58[6];
                              v78 = v58[4];
                              memcpy(&v94, &v83, 0x60u);
                              *(_QWORD *)&v89 = v60;
                              *((_QWORD *)&v89 + 1) = v61;
                              v102 = __PAIR64__(v79, v32);
                              v90 = v78;
                              v91 = v77;
                              v103 = __PAIR64__(LODWORD(y), LODWORD(x));
                              v92 = v76;
                              v93 = v75;
                              v101 = __PAIR64__(v80, v106);
                              v104 = __PAIR64__(LODWORD(w), LODWORD(z));
                              v105 = v62;
                              v64 = (void *)Unity_Jobs_IJobExtensions__Schedule_CrowdSortJob_((__int64)&v89, v55, v54);
                              v65 = v63;
                              if ( !*((_QWORD *)a0 + 8) )
                              {
LABEL_42:
                                *((_QWORD *)a0 + 11) = v64;
                                *((_QWORD *)a0 + 12) = v65;
                                v23 = 1;
LABEL_43:
                                sub_E1B6FFC(&v81);
                                return v23;
                              }
                              v66 = *((void **)a0 + 5);
                              if ( v66 )
                              {
                                AnimationComponent = Campus_Crowd_CrowdVolume__get_AnimationComponent(v66, v63);
                                v69 = Campus_Crowd_BillboardMatricesJobHandler__Schedule(
                                        AnimationComponent,
                                        *((void **)a0 + 8),
                                        v68);
                                v64 = (void *)Unity_Jobs_JobHandle__CombineDependencies(v69, v70, v64);
                                v65 = v71;
                                goto LABEL_42;
                              }
LABEL_52:
                              v72 = (void *)sub_63CF120(v66, v63);
                              v73 = v72;
                              if ( v74 != 1 )
                              {
                                sub_E1B6FFC(&v81);
                                sub_64BD8DC(v73);
                              }
                              v81 = *(_QWORD *)__cxa_begin_catch(v72);
                              __cxa_end_catch();
                              v23 = 0;
                              goto LABEL_43;
                            }
LABEL_51:
                            v66 = (void *)sub_63CF120(v56, v57);
                            goto LABEL_52;
                          }
LABEL_50:
                          v56 = sub_63CF120(v56, v57);
                          goto LABEL_51;
                        }
LABEL_49:
                        v56 = sub_63CF120(v46, v47);
                        goto LABEL_50;
                      }
LABEL_48:
                      v46 = sub_63CF120(v41, v42);
                      goto LABEL_49;
                    }
LABEL_47:
                    v41 = sub_63CF120(v33, v34);
                    goto LABEL_48;
                  }
LABEL_46:
                  v33 = sub_63CF120(v26, v27);
                  goto LABEL_47;
                }
LABEL_45:
                v26 = sub_63CF120(v26, v27);
                goto LABEL_46;
              }
            }
          }
        }
      }
    }
  }
  return 0;
}

