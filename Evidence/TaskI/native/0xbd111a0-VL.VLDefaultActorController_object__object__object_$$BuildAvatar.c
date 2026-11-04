// 0xbd111a0 @ 0xbd111a0
void __fastcall VL_VLDefaultActorController_object__object__object___BuildAvatar(void *a0, void *a1)
{
  void *v4; // x21
  int v5; // w8
  __int64 *descriptor; // x0
  __int64 v7; // x1
  __int64 v8; // x8
  void *v9; // x21
  __int64 v10; // x9
  int *v11; // x10
  __int64 v12; // x0
  __int64 v13; // x21
  void *Values; // x23
  __int64 v15; // x8
  __int64 v16; // x0
  __int64 v17; // x0
  void *v18; // x24
  __int64 v19; // x0
  __int64 v20; // x0
  void *v21; // x25
  int v22; // w2
  int v23; // w3
  int v24; // w4
  void *v25; // x5
  __int64 v26; // x8
  __int64 v27; // x0
  __int64 v28; // x0
  int v29; // w0
  __int64 v30; // x22
  void *transform; // x0
  void *v32; // x3
  int v33; // w2
  int v34; // w3
  int v35; // w4
  void *v36; // x5
  __int128 v37; // q0
  __int128 v38; // q1
  __int64 v39; // x8
  __int64 v40; // x8
  __int64 *v41; // x24
  __int64 v42; // x9
  int *v43; // x10
  __int64 v44; // x0
  void *gameObject; // x0
  void *v46; // x0
  int v47; // w2
  int v48; // w3
  int v49; // w4
  void *v50; // x5
  __int64 HumanBodyBone; // x0
  __int64 v52; // x1
  int v53; // w19
  __int64 v54; // x8
  __int64 v55; // x9
  int *v56; // x10
  __int64 v57; // x0
  __int64 v58; // x0
  __int64 v59; // x1
  __int64 v60; // x8
  __int64 v61; // x9
  int *v62; // x10
  __int64 v63; // x0
  __int64 v64; // x0
  __int64 v65; // x1
  __int64 v66; // x8
  __int64 v67; // x9
  int *v68; // x10
  __int64 v69; // x0
  __int64 v70; // x24
  __int64 v71; // x8
  int v72; // w27
  __int64 v73; // x9
  int *v74; // x10
  __int64 v75; // x0
  __int64 v76; // x24
  __int64 v77; // x8
  __int64 v78; // x9
  int *v79; // x10
  __int64 v80; // x0
  void **v81; // x24
  void *v82; // x2
  int v83; // w4
  void *v84; // x5
  unsigned int v85; // w8
  __int64 v86; // x8
  __int128 v87; // q1
  __int128 v88; // q2
  __int64 v89; // x9
  void *v90; // x25
  void *v91; // x0
  int v92; // w25
  int v93; // w8
  void *v94; // x0
  int v95; // w2
  int v96; // w3
  int v97; // w4
  void *v98; // x5
  __int64 v99; // x8
  int v100; // w10
  __int64 v101; // x10
  __int128 v102; // q0
  __int128 v103; // q1
  _OWORD *v104; // x8
  __int128 v105; // q0
  void *v106; // x2
  __int64 v107; // x0
  int v108; // w1
  __int64 v109; // x25
  __int64 v110; // x8
  __int64 v111; // x9
  int *v112; // x10
  __int64 v113; // x0
  int v114; // w24
  void *v115; // x25
  __int64 v116; // x23
  __int64 v117; // x8
  __int64 v118; // x9
  int *v119; // x10
  __int64 v120; // x0
  __int64 v121; // x0
  void *v122; // x23
  void *v123; // x0
  void *v124; // x0
  int v125; // w2
  int v126; // w3
  int v127; // w4
  void *v128; // x5
  void *v129; // x0
  char *v130; // [xsp+10h] [xbp+10h]
  _QWORD *v131; // [xsp+18h] [xbp+18h]
  __int128 v132; // [xsp+20h] [xbp+20h] BYREF
  __int128 v133; // [xsp+30h] [xbp+30h]
  __int128 v134; // [xsp+40h] [xbp+40h]
  __int128 v135; // [xsp+50h] [xbp+50h]
  __int128 v136; // [xsp+60h] [xbp+60h] BYREF
  __int128 v137; // [xsp+70h] [xbp+70h]
  __int128 v138; // [xsp+80h] [xbp+80h]
  __int128 v139; // [xsp+90h] [xbp+90h]
  __int128 v140; // [xsp+A0h] [xbp+A0h]
  __int128 v141; // [xsp+B0h] [xbp+B0h]
  __int128 v142; // [xsp+C0h] [xbp+C0h]
  __int64 v143; // [xsp+D0h] [xbp+D0h]
  __int64 v144; // [xsp+D8h] [xbp+D8h] BYREF
  __int64 *v145; // [xsp+E0h] [xbp+E0h]
  __int64 v146; // [xsp+E8h] [xbp+E8h] BYREF
  __int64 *v147; // [xsp+F0h] [xbp+F0h]
  __int128 v148; // [xsp+F8h] [xbp+F8h]
  __int128 v149; // [xsp+108h] [xbp+108h]
  __int128 v150; // [xsp+118h] [xbp+118h]
  __int64 v151; // [xsp+128h] [xbp+128h]
  __int128 v152; // [xsp+130h] [xbp+130h] BYREF
  __int128 v153; // [xsp+140h] [xbp+140h] BYREF
  __int128 v154; // [xsp+150h] [xbp+150h]
  __int128 v155; // [xsp+160h] [xbp+160h]
  __int64 v156; // [xsp+178h] [xbp+178h] BYREF
  __int64 v157; // [xsp+180h] [xbp+180h] BYREF
  __int64 v158; // [xsp+188h] [xbp+188h] BYREF
  __int128 v159; // [xsp+190h] [xbp+190h]
  __int128 v160; // [xsp+1A0h] [xbp+1A0h]
  __int128 v161; // [xsp+1B0h] [xbp+1B0h]
  __int128 v162; // [xsp+1C0h] [xbp+1C0h]
  __int128 v163; // [xsp+1D0h] [xbp+1D0h] BYREF
  __int128 v164; // [xsp+1E0h] [xbp+1E0h]
  __int128 v165; // [xsp+1F0h] [xbp+1F0h]

  if ( (unk_F41D64D & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
    sub_63CEE78(&Method_System_Linq_Enumerable_Sum_VLActorModelParts___);
    sub_63CEE78(&System_Func_VLActorModelParts__int__TypeInfo);
    sub_63CEE78(&System_IDisposable_TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerable_DefaultBoneInfo__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerator_DefaultBoneInfo__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo);
    sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    sub_63CEE78(&VL_IVLDefaultActorDescriptor_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_HumanBone__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_HumanBone__ToArray__);
    sub_63CEE78(&Method_System_Collections_Generic_List_HumanBone___ctor__);
    sub_63CEE78(&System_Collections_Generic_List_HumanBone__TypeInfo);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__get_Values__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_HumanBodyBones__Transform__set_Item__);
    sub_63CEE78(&UnityEngine_SkeletonBone___TypeInfo);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    sub_63CEE78(&StringLiteral_Generic_Avatar);
    sub_63CEE78(&StringLiteral_Humanoid_Avatar);
    sub_63CEE78(&StringLiteral_);
    unk_F41D64D = 1;
  }
  v4 = *((void **)a0 + 6);
  v157 = 0;
  v158 = 0;
  v5 = *(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL);
  HIDWORD(v156) = 0;
  v152 = 0u;
  v153 = 0u;
  v154 = 0u;
  v155 = 0u;
  if ( !v5 )
    sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
  UnityEngine_Rendering_CoreUtils__Destroy(v4, nullptr);
  descriptor = (__int64 *)VL_Core_VLActorController_object__object__object___get_descriptor(
                            a0,
                            *(void **)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 8LL));
  if ( !descriptor )
    goto LABEL_132;
  v8 = *descriptor;
  v9 = descriptor;
  v10 = *(unsigned __int16 *)(*descriptor + 302);
  if ( *(_WORD *)(*descriptor + 302) )
  {
    v11 = (int *)(*(_QWORD *)(v8 + 176) + 8LL);
    while ( *((_QWORD *)v11 - 1) != VL_IVLDefaultActorDescriptor_TypeInfo )
    {
      --v10;
      v11 += 4;
      if ( !v10 )
        goto LABEL_10;
    }
    v12 = v8 + 16LL * *v11 + 312;
  }
  else
  {
LABEL_10:
    v12 = sub_6408234(descriptor, VL_IVLDefaultActorDescriptor_TypeInfo, 0);
  }
  if ( ((*(__int64 (__fastcall **)(void *, _QWORD))v12)(v9, *(_QWORD *)(v12 + 8)) & 1) == 0 )
  {
    gameObject = UnityEngine_Component__get_gameObject(a0, nullptr);
    v46 = UnityEngine_AvatarBuilder__BuildGenericAvatar(gameObject, (void *)StringLiteral_, nullptr);
    *((_QWORD *)a0 + 6) = v46;
    sub_63CEE24((char *)a0 + 48, (int)v46, v47, v48, v49, v50);
    descriptor = *((__int64 **)a0 + 6);
    if ( descriptor )
    {
      UnityEngine_Object__set_name(descriptor, StringLiteral_Generic_Avatar, nullptr);
      return;
    }
    goto LABEL_132;
  }
  v13 = sub_63CF110(System_Collections_Generic_List_HumanBone__TypeInfo);
  System_Collections_Generic_List_HumanBone____ctor_1(
    (void *)v13,
    55,
    Method_System_Collections_Generic_List_HumanBone___ctor__);
  descriptor = *((__int64 **)a0 + 9);
  if ( !descriptor )
    goto LABEL_132;
  Values = VL_Core_SerializedDictionary_object__object___get_Values(
             descriptor,
             Method_VL_Core_SerializedDictionary_string__VLActorModelParts__get_Values__);
  v15 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 216LL);
  if ( (*(_WORD *)(v15 + 309) & 1) == 0 )
  {
    sub_6407F00(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 216LL));
    v15 = v16;
  }
  if ( !*(_DWORD *)(v15 + 228) )
    sub_63CEFF4(v15);
  v17 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 216LL);
  if ( (*(_WORD *)(v17 + 309) & 1) == 0 )
    sub_6407F00(v17);
  v18 = *(void **)(*(_QWORD *)(v17 + 184) + 8LL);
  if ( !v18 )
  {
    v19 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 216LL);
    if ( (*(_WORD *)(v19 + 309) & 1) == 0 )
      sub_6407F00(v19);
    if ( !*(_DWORD *)(v19 + 228) )
      sub_63CEFF4(v19);
    v20 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 216LL);
    if ( (*(_WORD *)(v20 + 309) & 1) == 0 )
      sub_6407F00(v20);
    v21 = **(void ***)(v20 + 184);
    v18 = (void *)sub_63CF110(System_Func_VLActorModelParts__int__TypeInfo);
    System_Func_object__int____ctor(v18, v21, *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 224LL), nullptr);
    v26 = *(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL);
    v27 = *(_QWORD *)(v26 + 216);
    if ( (*(_WORD *)(v27 + 309) & 1) == 0 )
    {
      sub_6407F00(v27);
      v26 = *(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL);
    }
    *(_QWORD *)(*(_QWORD *)(v27 + 184) + 8LL) = v18;
    v28 = *(_QWORD *)(v26 + 216);
    if ( (*(_WORD *)(v28 + 309) & 1) == 0 )
      sub_6407F00(v28);
    sub_63CEE24((void *)(*(_QWORD *)(v28 + 184) + 8LL), (int)v18, v22, v23, v24, v25);
  }
  v29 = System_Linq_Enumerable__Sum_object_(Values, v18, Method_System_Linq_Enumerable_Sum_VLActorModelParts___);
  v30 = sub_63CEF64(UnityEngine_SkeletonBone___TypeInfo, (unsigned int)(v29 + 1));
  transform = UnityEngine_Component__get_transform(a0, nullptr);
  descriptor = (__int64 *)VL_Core_VLActorController_object__object__object___GetSkeleton(transform, transform, 1, v32);
  if ( !v30 )
  {
LABEL_132:
    v121 = sub_63CF120(descriptor, v7);
LABEL_133:
    sub_63CF118(v121);
    v115 = v129;
    goto LABEL_134;
  }
  if ( *(_DWORD *)(v30 + 24) )
  {
    v37 = v148;
    v38 = v149;
    v39 = v151;
    *(_OWORD *)(v30 + 64) = v150;
    *(_OWORD *)(v30 + 32) = v37;
    *(_OWORD *)(v30 + 48) = v38;
    *(_QWORD *)(v30 + 80) = v39;
    sub_63CEE24((void *)(v30 + 32), 0, v33, v34, v35, v36);
    descriptor = *((__int64 **)a0 + 9);
    if ( !descriptor )
      goto LABEL_132;
    descriptor = (__int64 *)VL_Core_SerializedDictionary_object__object___get_Values(
                              descriptor,
                              Method_VL_Core_SerializedDictionary_string__VLActorModelParts__get_Values__);
    if ( !descriptor )
      goto LABEL_132;
    v40 = *descriptor;
    v41 = descriptor;
    v130 = (char *)a0 + 48;
    v131 = a0;
    v42 = *(unsigned __int16 *)(*descriptor + 302);
    if ( *(_WORD *)(*descriptor + 302) )
    {
      v43 = (int *)(*(_QWORD *)(v40 + 176) + 8LL);
      while ( *((_QWORD *)v43 - 1) != System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo )
      {
        --v42;
        v43 += 4;
        if ( !v42 )
          goto LABEL_40;
      }
      v44 = v40 + 16LL * *v43 + 312;
    }
    else
    {
LABEL_40:
      v44 = sub_6408234(descriptor, System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo, 0);
    }
    HumanBodyBone = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v44)(v41, *(_QWORD *)(v44 + 8));
    v158 = HumanBodyBone;
    v146 = 0;
    v147 = &v158;
    if ( HumanBodyBone )
    {
      v41 = (__int64 *)HumanBodyBone;
      v53 = 1;
      do
      {
        v54 = *v41;
        v55 = *(unsigned __int16 *)(*v41 + 302);
        if ( *(_WORD *)(*v41 + 302) )
        {
          v56 = (int *)(*(_QWORD *)(v54 + 176) + 8LL);
          while ( *((_QWORD *)v56 - 1) != System_Collections_IEnumerator_TypeInfo )
          {
            --v55;
            v56 += 4;
            if ( !v55 )
              goto LABEL_50;
          }
          v57 = v54 + 16LL * *v56 + 312;
        }
        else
        {
LABEL_50:
          v57 = sub_6408234(v41, System_Collections_IEnumerator_TypeInfo, 0);
        }
        v58 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v57)(v41, *(_QWORD *)(v57 + 8));
        if ( (v58 & 1) == 0 )
          goto LABEL_120;
        v41 = (__int64 *)v158;
        if ( !v158 )
          goto LABEL_115;
        v60 = *(_QWORD *)v158;
        v61 = *(unsigned __int16 *)(*(_QWORD *)v158 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v158 + 302LL) )
        {
          v62 = (int *)(*(_QWORD *)(v60 + 176) + 8LL);
          while ( *((_QWORD *)v62 - 1) != System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo )
          {
            --v61;
            v62 += 4;
            if ( !v61 )
              goto LABEL_58;
          }
          v63 = v60 + 16LL * *v62 + 312;
        }
        else
        {
LABEL_58:
          v63 = sub_6408234(v158, System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo, 0);
        }
        v64 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v63)(v41, *(_QWORD *)(v63 + 8));
        if ( !v64 )
          goto LABEL_116;
        v41 = *(__int64 **)(v64 + 64);
        if ( !v41 )
          goto LABEL_114;
        v66 = *v41;
        v67 = *(unsigned __int16 *)(*v41 + 302);
        if ( *(_WORD *)(*v41 + 302) )
        {
          v68 = (int *)(*(_QWORD *)(v66 + 176) + 8LL);
          while ( *((_QWORD *)v68 - 1) != System_Collections_Generic_IEnumerable_DefaultBoneInfo__TypeInfo )
          {
            --v67;
            v68 += 4;
            if ( !v67 )
              goto LABEL_66;
          }
          v69 = v66 + 16LL * *v68 + 312;
        }
        else
        {
LABEL_66:
          v69 = sub_6408234(*(_QWORD *)(v64 + 64), System_Collections_Generic_IEnumerable_DefaultBoneInfo__TypeInfo, 0);
        }
        HumanBodyBone = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v69)(v41, *(_QWORD *)(v69 + 8));
        v70 = HumanBodyBone;
        v157 = HumanBodyBone;
        v144 = 0;
        v145 = &v157;
        if ( !HumanBodyBone )
        {
LABEL_97:
          v107 = sub_63CF120(HumanBodyBone, v52);
          goto LABEL_118;
        }
        while ( 1 )
        {
          v71 = *(_QWORD *)v70;
          v72 = v53;
          v73 = *(unsigned __int16 *)(*(_QWORD *)v70 + 302LL);
          if ( *(_WORD *)(*(_QWORD *)v70 + 302LL) )
          {
            v74 = (int *)(*(_QWORD *)(v71 + 176) + 8LL);
            while ( *((_QWORD *)v74 - 1) != System_Collections_IEnumerator_TypeInfo )
            {
              --v73;
              v74 += 4;
              if ( !v73 )
                goto LABEL_73;
            }
            v75 = v71 + 16LL * *v74 + 312;
          }
          else
          {
LABEL_73:
            v75 = sub_6408234(v70, System_Collections_IEnumerator_TypeInfo, 0);
          }
          HumanBodyBone = (*(__int64 (__fastcall **)(__int64, _QWORD))v75)(v70, *(_QWORD *)(v75 + 8));
          if ( (HumanBodyBone & 1) == 0 )
            break;
          v76 = v157;
          if ( !v157 )
            goto LABEL_97;
          v77 = *(_QWORD *)v157;
          v78 = *(unsigned __int16 *)(*(_QWORD *)v157 + 302LL);
          if ( *(_WORD *)(*(_QWORD *)v157 + 302LL) )
          {
            v79 = (int *)(*(_QWORD *)(v77 + 176) + 8LL);
            while ( *((_QWORD *)v79 - 1) != System_Collections_Generic_IEnumerator_DefaultBoneInfo__TypeInfo )
            {
              --v78;
              v79 += 4;
              if ( !v78 )
                goto LABEL_81;
            }
            v80 = v77 + 16LL * *v79 + 312;
          }
          else
          {
LABEL_81:
            v80 = sub_6408234(v157, System_Collections_Generic_IEnumerator_DefaultBoneInfo__TypeInfo, 0);
          }
          v81 = (void **)(*(__int64 (__fastcall **)(__int64, _QWORD))v80)(v76, *(_QWORD *)(v80 + 8));
          ++v53;
          descriptor = (__int64 *)VL_Core_VLActorController_object__object__object___GetSkeleton_1(v81, v81, v82);
          v85 = *(_DWORD *)(v30 + 24);
          v140 = v136;
          v141 = v137;
          v142 = v138;
          v143 = v139;
          if ( v72 >= v85 )
            goto LABEL_117;
          v86 = v30 + 56LL * v72;
          v87 = v141;
          v88 = v142;
          v89 = v143;
          *(_OWORD *)(v86 + 32) = v140;
          *(_OWORD *)(v86 + 48) = v87;
          *(_OWORD *)(v86 + 64) = v88;
          *(_QWORD *)(v86 + 80) = v89;
          sub_63CEE24((void *)(v30 + 32 + 56LL * v72), 0, v33, v34, v83, v84);
          if ( !v81 )
            goto LABEL_97;
          v90 = v81[3];
          if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
            sub_63CEFF4(VL_VLActorDefine_TypeInfo);
          HumanBodyBone = VL_VLActorDefine__TryGetHumanBodyBone(v90, (char *)&v156 + 4, nullptr);
          if ( (HumanBodyBone & 1) != 0 )
          {
            v91 = *((void **)a0 + 53);
            if ( !v91 )
            {
              v107 = sub_63CF120(0, v52);
              goto LABEL_118;
            }
            VL_Core_SerializedDictionary_Int32Enum__object___set_Item(
              v91,
              SHIDWORD(v156),
              v81[2],
              Method_VL_Core_SerializedDictionary_HumanBodyBones__Transform__set_Item__);
            v92 = HIDWORD(v156);
            v93 = *(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL);
            v152 = 0u;
            v153 = 0u;
            v154 = 0u;
            v155 = 0u;
            if ( !v93 )
              sub_63CEFF4(VL_VLActorDefine_TypeInfo);
            v94 = VL_VLActorDefine__HumanBodyToString(v92, nullptr);
            UnityEngine_HumanBone__set_humanName((__int64)&v152, v94, nullptr);
            UnityEngine_HumanBone__set_boneName((__int64)&v152, v81[3], nullptr);
            UnityEngine_HumanLimit__set_useDefaultValues((__int64)&v153, 1, nullptr);
            if ( !v13 )
              goto LABEL_97;
            v99 = *(_QWORD *)(v13 + 16);
            v100 = *(_DWORD *)(v13 + 28) + 1;
            v159 = v152;
            v160 = v153;
            v161 = v154;
            v162 = v155;
            *(_DWORD *)(v13 + 28) = v100;
            if ( !v99 )
              goto LABEL_97;
            v101 = *(int *)(v13 + 24);
            if ( (unsigned int)v101 >= *(_DWORD *)(v99 + 24) )
            {
              v106 = *(void **)(*(_QWORD *)(*(_QWORD *)(Method_System_Collections_Generic_List_HumanBone__Add__ + 32LL)
                                          + 192LL)
                              + 112LL);
              v163 = v159;
              v164 = v160;
              v165 = v161;
              *(_OWORD *)&STACK[0x200] = v162;
              System_Collections_Generic_List_HumanBone___AddWithResize((void *)v13, (__int64)&v163, v106);
            }
            else
            {
              v102 = v159;
              v103 = v160;
              v104 = (_OWORD *)(v99 + (v101 << 6));
              *(_DWORD *)(v13 + 24) = v101 + 1;
              v104[2] = v102;
              v104[3] = v103;
              v105 = v162;
              v104[4] = v161;
              v104[5] = v105;
              sub_63CEE24(v104 + 2, 0, v95, v96, v97, v98);
            }
          }
          v70 = v157;
          if ( !v157 )
            goto LABEL_97;
        }
        v109 = v157;
        if ( v157 )
        {
          v110 = *(_QWORD *)v157;
          v111 = *(unsigned __int16 *)(*(_QWORD *)v157 + 302LL);
          if ( *(_WORD *)(*(_QWORD *)v157 + 302LL) )
          {
            v112 = (int *)(*(_QWORD *)(v110 + 176) + 8LL);
            while ( *((_QWORD *)v112 - 1) != System_IDisposable_TypeInfo )
            {
              --v111;
              v112 += 4;
              if ( !v111 )
                goto LABEL_103;
            }
            v113 = v110 + 16LL * *v112 + 312;
          }
          else
          {
LABEL_103:
            v113 = sub_6408234(v157, System_IDisposable_TypeInfo, 0);
          }
          HumanBodyBone = (*(__int64 (__fastcall **)(__int64, _QWORD))v113)(v109, *(_QWORD *)(v113 + 8));
        }
        v41 = (__int64 *)v158;
      }
      while ( v158 );
    }
    v64 = sub_63CF120(HumanBodyBone, v52);
LABEL_114:
    v58 = sub_63CF120(v64, v65);
LABEL_115:
    v64 = sub_63CF120(v58, v59);
LABEL_116:
    sub_63CF120(v64, v65);
    sub_63CF118(v41);
  }
LABEL_117:
  sub_63CF128(descriptor, v7, v33, v34);
LABEL_118:
  v114 = v108;
  v115 = (void *)v107;
  sub_5D96914(&v144);
  if ( v114 != 1 )
  {
LABEL_134:
    sub_5D96914(&v146);
    sub_64BD8DC(v115);
  }
  v146 = *(_QWORD *)__cxa_begin_catch(v115);
  __cxa_end_catch();
LABEL_120:
  v116 = *v147;
  if ( *v147 )
  {
    v117 = *(_QWORD *)v116;
    v118 = *(unsigned __int16 *)(*(_QWORD *)v116 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v116 + 302LL) )
    {
      v119 = (int *)(*(_QWORD *)(v117 + 176) + 8LL);
      while ( *((_QWORD *)v119 - 1) != System_IDisposable_TypeInfo )
      {
        --v118;
        v119 += 4;
        if ( !v118 )
          goto LABEL_125;
      }
      v120 = v117 + 16LL * *v119 + 312;
    }
    else
    {
LABEL_125:
      v120 = sub_6408234(*v147, System_IDisposable_TypeInfo, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v120)(v116, *(_QWORD *)(v120 + 8));
  }
  v121 = v146;
  if ( v146 )
    goto LABEL_133;
  descriptor = (__int64 *)UnityEngine_Component__get_gameObject(v131, nullptr);
  if ( !v13 )
    goto LABEL_132;
  v122 = descriptor;
  v123 = System_Collections_Generic_List_HumanBone___ToArray(
           (void *)v13,
           Method_System_Collections_Generic_List_HumanBone__ToArray__);
  (*(void (__fastcall **)(__int128 *__return_ptr, _QWORD *, void *, __int64, _QWORD))(*v131 + 904LL))(
    &v136,
    v131,
    v123,
    v30,
    *(_QWORD *)(*v131 + 912LL));
  v132 = v136;
  v133 = v137;
  v134 = v138;
  v135 = v139;
  v124 = UnityEngine_AvatarBuilder__BuildHumanAvatar(v122, (__int64)&v132, nullptr);
  v131[6] = v124;
  sub_63CEE24(v130, (int)v124, v125, v126, v127, v128);
  descriptor = (__int64 *)v131[6];
  if ( !descriptor )
    goto LABEL_132;
  UnityEngine_Object__set_name(descriptor, StringLiteral_Humanoid_Avatar, nullptr);
}

