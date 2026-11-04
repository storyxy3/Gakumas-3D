// Campus.Crowd.CrowdAnimator$$.ctor @ 0xddc1880
void __fastcall Campus_Crowd_CrowdAnimator___ctor(void *a0, void *a1, void *a2, void *a3, void *a4)
{
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v13; // x0
  __int64 v14; // x1
  void **v15; // x25
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  void *v20; // x0
  __int64 v21; // x1
  __int64 v22; // x23
  __int64 v23; // x8
  __int64 v24; // x26
  _OWORD *v25; // x8
  __int128 v26; // q1
  __int128 v27; // q2
  unsigned int v28; // w0
  void *v29; // x4
  void *v30; // x3
  void *v31; // x4
  void *v32; // x4
  __int64 v33; // x8
  int v34; // w1
  void *v35; // x2
  __int64 v36; // x8
  int v37; // w1
  __int64 v38; // x0
  void *v39; // x27
  __int64 v40; // x8
  void *v41; // x28
  void *v42; // x29
  __int64 v43; // x0
  int v44; // w2
  int v45; // w3
  int v46; // w4
  void *v47; // x5
  void *v48; // x0
  __int64 v49; // x8
  int v50; // w1
  __int64 v51; // x0
  void *v52; // x27
  __int64 v53; // x8
  void *v54; // x28
  void *v55; // x29
  __int64 v56; // x0
  int v57; // w2
  int v58; // w3
  int v59; // w4
  void *v60; // x5
  void *v61; // x0
  int v62; // w2
  int v63; // w3
  unsigned __int64 v64; // x22
  __int64 v65; // x29
  __int64 v66; // x8
  void *v67; // x25
  _DWORD *v68; // x8
  __int64 v69; // x20
  void *v70; // x21
  __int64 v71; // x25
  __int128 v72; // q2
  __int128 v73; // q1
  __int128 v74; // q3
  __int128 v75; // q0
  __int128 v76; // q1
  __int128 v77; // q0
  __int128 v78; // q1
  void *v79; // x0
  __int64 v80; // x1
  void *v81; // x0
  void *v82; // x1
  __int64 v83; // [xsp+8h] [xbp+8h]
  __int64 v84; // [xsp+10h] [xbp+10h]
  __int128 v85; // [xsp+20h] [xbp+20h] BYREF
  __int128 v86; // [xsp+30h] [xbp+30h] BYREF
  __int128 v87; // [xsp+40h] [xbp+40h] BYREF
  __int128 v88; // [xsp+50h] [xbp+50h] BYREF
  __int128 v89; // [xsp+60h] [xbp+60h] BYREF
  __int128 v90; // [xsp+70h] [xbp+70h] BYREF
  __int128 v91; // [xsp+80h] [xbp+80h] BYREF
  __int128 v92; // [xsp+90h] [xbp+90h] BYREF
  __int128 v93; // [xsp+A0h] [xbp+A0h]
  __int128 v94; // [xsp+B0h] [xbp+B0h]
  __int128 v95; // [xsp+C0h] [xbp+C0h]
  __int128 v96; // [xsp+D0h] [xbp+D0h]
  __int128 v97; // [xsp+E0h] [xbp+E0h]
  __int128 v98; // [xsp+F0h] [xbp+F0h]
  __int128 v99; // [xsp+100h] [xbp+100h]
  __int128 v100; // [xsp+110h] [xbp+110h]
  __int128 v101; // [xsp+120h] [xbp+120h] BYREF
  __int128 v102; // [xsp+130h] [xbp+130h]
  __int128 v103; // [xsp+140h] [xbp+140h]
  __int128 v104; // [xsp+150h] [xbp+150h]

  if ( (unk_F43BCD9 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdAnimationBehaviour_TypeInfo);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_FasterLinq_Select_CrowdModelData_CrowdVolumeBoneData__int___);
    sub_63CEE78(&Method_FasterLinq_Select_CrowdModelData_CrowdVolumeBoneData__Vector3___);
    sub_63CEE78(&System_Func_CrowdModelData_CrowdVolumeBoneData__Vector3__TypeInfo);
    sub_63CEE78(&System_Func_CrowdModelData_CrowdVolumeBoneData__int__TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__CopyFrom__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Vector3__CopyFrom__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int___ctor___1);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Bounds___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Vector3___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_TransformStreamHandle___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_Matrix4x4___ctor__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableOutputExtensions_SetSourcePlayable_AnimationPlayableOutput__ScriptPlayable_CrowdAnimationBehaviour____);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__Create__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
    sub_63CEE78(&Method_FasterLinq_SelectArray_CrowdModelData_CrowdVolumeBoneData__Vector3__ToArray__);
    sub_63CEE78(&Method_FasterLinq_SelectArray_CrowdModelData_CrowdVolumeBoneData__int__ToArray__);
    sub_63CEE78(&Method_Campus_Crowd_CrowdAnimator___c___ctor_b__21_0__);
    sub_63CEE78(&Method_Campus_Crowd_CrowdAnimator___c___ctor_b__21_1__);
    sub_63CEE78(&Campus_Crowd_CrowdAnimator___c_TypeInfo);
    sub_63CEE78(&StringLiteral__________GameObject__________________________________);
    sub_63CEE78(&StringLiteral_Crowd_Animation_Output);
    sub_63CEE78(&StringLiteral_Crowd_Animator);
    unk_F43BCD9 = 1;
  }
  memset(&v92, 0, 0x90u);
  *((_DWORD *)a0 + 44) = 1036831949;
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 13) = a1;
  sub_63CEE24((char *)a0 + 104, (int)a1, v9, v10, v11, v12);
  v13 = UnityEngine_Playables_PlayableGraph__Create_1(StringLiteral_Crowd_Animator, nullptr);
  *((_QWORD *)a0 + 8) = v14;
  *((_QWORD *)a0 + 7) = v13;
  UnityEngine_Playables_PlayableGraph__SetTimeUpdateMode((__int64)a0 + 56, 1, nullptr);
  *((_QWORD *)a0 + 6) = a2;
  v15 = (void **)((char *)a0 + 48);
  sub_63CEE24((char *)a0 + 48, (int)a2, v16, v17, v18, v19);
  v20 = (void *)UnityEngine_Animations_AnimationPlayableOutput__Create(
                  *((_QWORD *)a0 + 7),
                  *((void **)a0 + 8),
                  StringLiteral_Crowd_Animation_Output,
                  a2);
  if ( a3 )
  {
    v22 = *((_QWORD *)a3 + 10);
    if ( v22 )
    {
      v23 = *(_QWORD *)(v22 + 64);
      v83 = v21;
      v84 = (__int64)v20;
      if ( v23 )
      {
        v24 = *(_QWORD *)(v23 + 24);
        if ( !unk_F4004F3 )
        {
          sub_63CEE78(&UnityEngine_Matrix4x4_TypeInfo);
          unk_F4004F3 = 1;
        }
        v25 = *(_OWORD **)(UnityEngine_Matrix4x4_TypeInfo + 184LL);
        v26 = v25[5];
        v101 = v25[4];
        v102 = v26;
        v27 = v25[7];
        v103 = v25[6];
        v104 = v27;
        v28 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, nullptr);
        v91 = 0u;
        Unity_Collections_NativeReference_Matrix4x4____ctor_1(
          (__int64)&v91,
          (UnityEngine_Matrix4x4_o *)&v101,
          v28,
          Method_Unity_Collections_NativeReference_Matrix4x4___ctor__);
        v29 = (void *)Method_Unity_Collections_NativeArray_TransformStreamHandle___ctor__;
        *((_OWORD *)a0 + 1) = v91;
        v101 = 0u;
        Unity_Collections_NativeArray_TransformStreamHandle____ctor((__int64)&v101, v24, 4, 1, v29);
        v30 = Method_Unity_Collections_NativeArray_Matrix4x4___ctor__;
        v90 = 0u;
        *((_OWORD *)a0 + 13) = v101;
        Unity_Collections_NativeArray_Matrix4x4____ctor_1((__int64)&v90, *(void **)(v22 + 96), 4, v30);
        v31 = Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1;
        *((_OWORD *)a0 + 2) = v90;
        v89 = 0u;
        Unity_Collections_NativeArray_Matrix4x4____ctor((__int64)&v89, 8 * v24, 4, 1, v31);
        *(_OWORD *)((char *)a0 + 72) = v89;
        v88 = 0u;
        Unity_Collections_NativeArray_Bounds____ctor(
          (__int64)&v88,
          8,
          4,
          1,
          (void *)Method_Unity_Collections_NativeArray_Bounds___ctor__);
        v32 = Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1;
        *((_OWORD *)a0 + 7) = v88;
        v87 = 0u;
        Unity_Collections_NativeArray_Matrix4x4____ctor((__int64)&v87, 8 * v24, 4, 1, v32);
        *(_OWORD *)((char *)a0 + 88) = v87;
        v33 = *(_QWORD *)(v22 + 80);
        if ( v33 )
        {
          v34 = *(_DWORD *)(v33 + 24);
          v86 = 0u;
          Unity_Collections_NativeArray_int____ctor(
            (__int64)&v86,
            v34,
            4,
            1,
            (void *)Method_Unity_Collections_NativeArray_int___ctor___1);
          v35 = Method_Unity_Collections_NativeArray_int__CopyFrom__;
          *((_OWORD *)a0 + 8) = v86;
          Unity_Collections_NativeArray_int___CopyFrom((__int64)a0 + 128, *(void **)(v22 + 80), v35);
          v36 = *(_QWORD *)(v22 + 88);
          if ( v36 )
          {
            v37 = *(_DWORD *)(v36 + 24);
            v85 = 0u;
            Unity_Collections_NativeArray_int____ctor(
              (__int64)&v85,
              v37,
              4,
              1,
              (void *)Method_Unity_Collections_NativeArray_int___ctor___1);
            v38 = Campus_Crowd_CrowdAnimator___c_TypeInfo;
            *((_OWORD *)a0 + 9) = v85;
            v39 = *(void **)(v22 + 88);
            if ( !*(_DWORD *)(v38 + 228) )
            {
              sub_63CEFF4(v38);
              v38 = Campus_Crowd_CrowdAnimator___c_TypeInfo;
            }
            v40 = *(_QWORD *)(v38 + 184);
            v41 = *(void **)(v40 + 8);
            if ( !v41 )
            {
              if ( !*(_DWORD *)(v38 + 228) )
              {
                sub_63CEFF4(v38);
                v40 = *(_QWORD *)(Campus_Crowd_CrowdAnimator___c_TypeInfo + 184LL);
              }
              v42 = *(void **)v40;
              v41 = (void *)sub_63CF110(System_Func_CrowdModelData_CrowdVolumeBoneData__int__TypeInfo);
              System_Func_object__int____ctor(v41, v42, Method_Campus_Crowd_CrowdAnimator___c___ctor_b__21_0__, nullptr);
              v43 = *(_QWORD *)(Campus_Crowd_CrowdAnimator___c_TypeInfo + 184LL);
              *(_QWORD *)(v43 + 8) = v41;
              sub_63CEE24((void *)(v43 + 8), (int)v41, v44, v45, v46, v47);
            }
            v20 = FasterLinq__Select_object__int_(
                    v39,
                    v41,
                    Method_FasterLinq_Select_CrowdModelData_CrowdVolumeBoneData__int___);
            if ( v20 )
            {
              v48 = FasterLinq_SelectArray_object__int___ToArray(
                      v20,
                      Method_FasterLinq_SelectArray_CrowdModelData_CrowdVolumeBoneData__int__ToArray__);
              Unity_Collections_NativeArray_int___CopyFrom(
                (__int64)a0 + 144,
                v48,
                Method_Unity_Collections_NativeArray_int__CopyFrom__);
              v49 = *(_QWORD *)(v22 + 88);
              if ( v49 )
              {
                v50 = *(_DWORD *)(v49 + 24);
                v101 = 0u;
                Unity_Collections_NativeArray_Vector3____ctor(
                  (__int64)&v101,
                  v50,
                  4,
                  1,
                  Method_Unity_Collections_NativeArray_Vector3___ctor__);
                v51 = Campus_Crowd_CrowdAnimator___c_TypeInfo;
                *((_OWORD *)a0 + 10) = v101;
                v52 = *(void **)(v22 + 88);
                if ( !*(_DWORD *)(v51 + 228) )
                {
                  sub_63CEFF4(v51);
                  v51 = Campus_Crowd_CrowdAnimator___c_TypeInfo;
                }
                v53 = *(_QWORD *)(v51 + 184);
                v54 = *(void **)(v53 + 16);
                if ( !v54 )
                {
                  if ( !*(_DWORD *)(v51 + 228) )
                  {
                    sub_63CEFF4(v51);
                    v53 = *(_QWORD *)(Campus_Crowd_CrowdAnimator___c_TypeInfo + 184LL);
                  }
                  v55 = *(void **)v53;
                  v54 = (void *)sub_63CF110(System_Func_CrowdModelData_CrowdVolumeBoneData__Vector3__TypeInfo);
                  System_Func_object__Vector3____ctor(
                    v54,
                    v55,
                    Method_Campus_Crowd_CrowdAnimator___c___ctor_b__21_1__,
                    nullptr);
                  v56 = *(_QWORD *)(Campus_Crowd_CrowdAnimator___c_TypeInfo + 184LL);
                  *(_QWORD *)(v56 + 16) = v54;
                  sub_63CEE24((void *)(v56 + 16), (int)v54, v57, v58, v59, v60);
                }
                v20 = FasterLinq__Select_object__Vector3_(
                        v52,
                        v54,
                        Method_FasterLinq_Select_CrowdModelData_CrowdVolumeBoneData__Vector3___);
                if ( v20 )
                {
                  v61 = FasterLinq_SelectArray_object__Vector3___ToArray(
                          v20,
                          Method_FasterLinq_SelectArray_CrowdModelData_CrowdVolumeBoneData__Vector3__ToArray__);
                  Unity_Collections_NativeArray_Vector3___CopyFrom(
                    (__int64)a0 + 160,
                    v61,
                    Method_Unity_Collections_NativeArray_Vector3__CopyFrom__);
                  v20 = *v15;
                  if ( *v15 )
                  {
                    UnityEngine_Animator__set_avatar(v20, *(void **)(v22 + 56), nullptr);
                    if ( (int)v24 < 1 )
                    {
LABEL_38:
                      v69 = *((_QWORD *)a0 + 7);
                      v70 = *((void **)a0 + 8);
                      v71 = sub_63CF110(Campus_Crowd_CrowdAnimationBehaviour_TypeInfo);
                      Campus_Crowd_CrowdAnimationBehaviour___ctor((void *)v71, nullptr);
                      v72 = *((_OWORD *)a0 + 2);
                      v73 = *((_OWORD *)a0 + 13);
                      v74 = *((_OWORD *)a0 + 7);
                      v92 = *((_OWORD *)a0 + 1);
                      v93 = v73;
                      v75 = *((_OWORD *)a0 + 8);
                      v76 = *((_OWORD *)a0 + 9);
                      v94 = v72;
                      v95 = v75;
                      v77 = *((_OWORD *)a0 + 10);
                      v96 = v76;
                      v97 = v77;
                      v78 = *(_OWORD *)((char *)a0 + 88);
                      v98 = *(_OWORD *)((char *)a0 + 72);
                      v99 = v78;
                      v100 = v74;
                      if ( v71 )
                      {
                        memcpy((void *)(v71 + 16), &v92, 0x90u);
                        if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo + 228LL) )
                          sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdAnimationBehaviour__TypeInfo);
                        v79 = (void *)UnityEngine_Playables_ScriptPlayable_object___Create_1(v69, v70, v71, nullptr);
                        *((_QWORD *)a0 + 23) = v79;
                        *((_QWORD *)a0 + 24) = v80;
                        UnityEngine_Playables_PlayableOutputExtensions__SetSourcePlayable_AnimationPlayableOutput__ScriptPlayable_object__(
                          v84,
                          v83,
                          v79);
                        UnityEngine_Playables_PlayableGraph__Play((__int64)a0 + 56, nullptr);
                        return;
                      }
                    }
                    else
                    {
                      v64 = 0;
                      v65 = 8;
                      while ( 1 )
                      {
                        v66 = *(_QWORD *)(v22 + 64);
                        if ( !v66 )
                          break;
                        if ( v64 >= *(unsigned int *)(v66 + 24) )
                          goto LABEL_43;
                        if ( !a1 )
                          break;
                        v67 = UnityEngine_Transform__Find(a1, *(void **)(v66 + 8 * v64 + 32), nullptr);
                        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                          sub_63CEFF4(UnityEngine_Object_TypeInfo);
                        if ( UnityEngine_Object__op_Equality(v67, nullptr, nullptr) )
                        {
                          if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
                            sub_63CEFF4(UnityEngine_Debug_TypeInfo);
                          UnityEngine_Debug__LogError(
                            StringLiteral__________GameObject__________________________________,
                            nullptr);
                        }
                        v20 = (void *)UnityEngine_Animations_AnimatorJobExtensions__BindStreamTransform(
                                        a2,
                                        v67,
                                        nullptr);
                        ++v64;
                        v68 = (_DWORD *)(*((_QWORD *)a0 + 26) + v65);
                        v65 += 12;
                        *((_QWORD *)v68 - 1) = v20;
                        *v68 = v21;
                        if ( (unsigned int)v24 == v64 )
                          goto LABEL_38;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  v20 = (void *)sub_63CF120(v20, v21);
LABEL_43:
  sub_63CF128(v20, v21, v62, v63);
  Campus_Crowd_CrowdAnimationTimeline__OnEnable(v81, v82);
}

