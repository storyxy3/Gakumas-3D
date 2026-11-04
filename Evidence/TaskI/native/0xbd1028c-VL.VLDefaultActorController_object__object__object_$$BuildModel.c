// 0xbd1028c @ 0xbd1028c
void __fastcall VL_VLDefaultActorController_object__object__object___BuildModel(void *a0, void *a1, void *a2)
{
  void *v4; // x0
  void **v5; // x20
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5
  __int64 v10; // x21
  __int64 Values; // x0
  __int64 v12; // x1
  __int64 v13; // x8
  bool v14; // w19
  __int64 v15; // x8
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x1
  __int64 v21; // x8
  __int64 v22; // x9
  int *v23; // x10
  __int64 v24; // x0
  __int64 v25; // x0
  __int64 v26; // x1
  __int64 v27; // x8
  __int64 v28; // x9
  int *v29; // x10
  __int64 v30; // x0
  _QWORD *v31; // x0
  __int64 v32; // x1
  _QWORD *v33; // x22
  void *transform; // x0
  __int64 v35; // x1
  __int64 v36; // x1
  void *v37; // x0
  __int128 v38; // q0
  __int64 v39; // x1
  __int64 v40; // x0
  long double v41; // q0
  __int64 v42; // x21
  __int64 v43; // x8
  __int64 v44; // x9
  int *v45; // x10
  __int64 v46; // x0
  __int64 v47; // x0
  void *Enumerator; // x0
  __int64 v49; // x1
  __int64 v50; // x8
  __int64 v51; // x9
  int *v52; // x10
  __int64 v53; // x0
  __int64 v54; // x0
  __int64 v55; // x1
  __int64 v56; // x8
  __int64 v57; // x9
  _DWORD *v58; // x10
  __int64 v59; // x0
  void *v60; // x0
  __int64 v61; // x1
  __int64 v62; // x1
  __int64 v63; // x9
  void *gameObject; // x21
  __int64 v65; // x0
  __int64 v66; // x8
  __int64 v67; // x22
  __int64 v68; // x9
  int *v69; // x10
  __int64 v70; // x0
  _QWORD *v71; // x19
  __int64 v72; // x0
  int v73; // w2
  int v74; // w3
  __int64 v75; // x9
  int v76; // w8
  int v77; // w29
  char v78; // w19
  __int64 v79; // x8
  void *v80; // x23
  void *name; // x22
  void *RootName; // x24
  _BOOL8 v83; // x0
  __int64 v84; // x1
  __int64 v85; // x25
  void *v86; // x26
  void *v87; // x0
  bool v88; // w27
  void *v89; // x28
  __int64 v90; // x1
  __int64 v91; // x0
  void *v92; // x25
  void *v93; // x0
  void *v94; // x22
  int v95; // w2
  int v96; // w3
  int v97; // w4
  void *v98; // x5
  void *v99; // x26
  void *v100; // x26
  _QWORD *v101; // x0
  int v102; // w2
  int v103; // w3
  int v104; // w4
  void *v105; // x5
  _QWORD *v106; // x23
  void *PartsId; // x24
  int v108; // w8
  __int64 v109; // x8
  __int64 v110; // x0
  __int64 v111; // x8
  __int64 v112; // x9
  __int64 v113; // x10
  __int64 v114; // x0
  void *v115; // x2
  __int64 v116; // x26
  bool v117; // [xsp+14h] [xbp+14h]
  __int64 *v118; // [xsp+18h] [xbp+18h]
  __int64 v119; // [xsp+20h] [xbp+20h]
  __int128 v121; // [xsp+30h] [xbp+30h] BYREF
  __int128 v122; // [xsp+40h] [xbp+40h]
  __int64 v123; // [xsp+50h] [xbp+50h]
  __int64 v124; // [xsp+58h] [xbp+58h]
  __int64 *v125; // [xsp+60h] [xbp+60h]
  __int64 v126; // [xsp+68h] [xbp+68h] BYREF
  __int64 v127; // [xsp+70h] [xbp+70h]
  void *v128; // [xsp+78h] [xbp+78h]
  __int128 v129; // [xsp+80h] [xbp+80h] BYREF
  __int128 v130; // [xsp+90h] [xbp+90h]
  __int64 v131; // [xsp+A0h] [xbp+A0h]
  __int64 v132; // [xsp+B0h] [xbp+B0h] BYREF
  __int64 v133; // [xsp+B8h] [xbp+B8h] BYREF
  __int128 v134; // [xsp+C0h] [xbp+C0h] BYREF
  __int128 v135; // [xsp+D0h] [xbp+D0h]
  __int64 v136; // [xsp+E0h] [xbp+E0h] BYREF
  _QWORD *v137; // [xsp+E8h] [xbp+E8h] BYREF

  v137 = a2;
  if ( (unk_F41D64B & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_System_Linq_Enumerable_ToArray_GameObject___);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_BoneLinkData__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_BoneLinkData__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_BoneLinkData__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__get_Current__);
    sub_63CEE78(&System_IDisposable_TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo);
    sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_KeyValuePair_string__VLActorModelParts__get_Key__);
    sub_63CEE78(&Method_System_Collections_Generic_KeyValuePair_string__VLActorModelParts__get_Value__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData__GetEnumerator__);
    sub_63CEE78(&Method_System_Collections_Generic_List_SkinnedMeshRenderer__get_Count__);
    sub_63CEE78(&Method_UnityEngine_Object_Instantiate_GameObject____2);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__GetEnumerator__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__Remove__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__get_Values__);
    sub_63CEE78(&UnityEngine_Transform_TypeInfo);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    sub_63CEE78(&StringLiteral_face);
    sub_63CEE78(&StringLiteral_body);
    sub_63CEE78(&StringLiteral_ReRegister_);
    unk_F41D64B = 1;
  }
  v136 = 0;
  v132 = 0;
  v133 = 0;
  v131 = 0;
  v129 = 0u;
  v130 = 0u;
  v134 = 0u;
  v135 = 0u;
  v126 = 0;
  v127 = 0;
  v128 = nullptr;
  v4 = System_Linq_Enumerable__ToArray_object_(a1, Method_System_Linq_Enumerable_ToArray_GameObject___);
  *((_QWORD *)a0 + 12) = v4;
  v5 = (void **)((char *)a0 + 96);
  sub_63CEE24((char *)a0 + 96, (int)v4, v6, v7, v8, v9);
  v10 = *((_QWORD *)a0 + 46);
  v118 = (__int64 *)((char *)a0 + 96);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  Values = UnityEngine_Object__op_Inequality((void *)v10, nullptr, nullptr);
  if ( (Values & 1) != 0 )
  {
    v13 = *((_QWORD *)a0 + 46);
    if ( !v13 )
      goto LABEL_151;
    Values = *((_QWORD *)a0 + 9);
    v14 = *(_BYTE *)(v13 + 80) != 0;
    if ( !Values )
      goto LABEL_151;
    Values = (__int64)VL_Core_SerializedDictionary_object__object___get_Values(
                        (void *)Values,
                        Method_VL_Core_SerializedDictionary_string__VLActorModelParts__get_Values__);
    if ( !Values )
      goto LABEL_151;
    v15 = *(_QWORD *)Values;
    v10 = Values;
    v117 = v14;
    v16 = *(unsigned __int16 *)(*(_QWORD *)Values + 302LL);
    if ( *(_WORD *)(*(_QWORD *)Values + 302LL) )
    {
      v17 = (int *)(*(_QWORD *)(v15 + 176) + 8LL);
      while ( *((_QWORD *)v17 - 1) != System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo )
      {
        --v16;
        v17 += 4;
        if ( !v16 )
          goto LABEL_13;
      }
      v18 = v15 + 16LL * *v17 + 312;
    }
    else
    {
LABEL_13:
      v18 = sub_6408234(Values, System_Collections_Generic_IEnumerable_VLActorModelParts__TypeInfo, 0);
    }
    v19 = (*(__int64 (__fastcall **)(__int64, _QWORD))v18)(v10, *(_QWORD *)(v18 + 8));
    v136 = v19;
    v124 = 0;
    v125 = &v136;
    if ( !v19 )
      goto LABEL_157;
    v5 = &Method_System_Collections_Generic_List_BoneLinkData__GetEnumerator__;
    v10 = v19;
    while ( 1 )
    {
      v21 = *(_QWORD *)v10;
      v22 = *(unsigned __int16 *)(*(_QWORD *)v10 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v10 + 302LL) )
      {
        v23 = (int *)(*(_QWORD *)(v21 + 176) + 8LL);
        while ( *((_QWORD *)v23 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v22;
          v23 += 4;
          if ( !v22 )
            goto LABEL_22;
        }
        v24 = v21 + 16LL * *v23 + 312;
      }
      else
      {
LABEL_22:
        v24 = sub_6408234(v10, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v25 = (*(__int64 (__fastcall **)(__int64, _QWORD))v24)(v10, *(_QWORD *)(v24 + 8));
      if ( (v25 & 1) == 0 )
        break;
      v10 = v136;
      if ( !v136 )
        goto LABEL_159;
      v27 = *(_QWORD *)v136;
      v28 = *(unsigned __int16 *)(*(_QWORD *)v136 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v136 + 302LL) )
      {
        v29 = (int *)(*(_QWORD *)(v27 + 176) + 8LL);
        while ( *((_QWORD *)v29 - 1) != System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo )
        {
          --v28;
          v29 += 4;
          if ( !v28 )
            goto LABEL_30;
        }
        v30 = v27 + 16LL * *v29 + 312;
      }
      else
      {
LABEL_30:
        v30 = sub_6408234(v136, System_Collections_Generic_IEnumerator_VLActorModelParts__TypeInfo, 0);
      }
      v31 = (_QWORD *)(*(__int64 (__fastcall **)(__int64, _QWORD))v30)(v10, *(_QWORD *)(v30 + 8));
      v33 = v31;
      if ( !v31 )
        goto LABEL_160;
      transform = UnityEngine_Component__get_transform(v31, nullptr);
      v10 = (__int64)transform;
      if ( !transform )
        goto LABEL_161;
      UnityEngine_Transform__SetParent_1(transform, nullptr, 0, nullptr);
      v37 = (void *)v33[9];
      if ( !v37 )
        goto LABEL_158;
      System_Collections_Generic_List_BoneLinkData___GetEnumerator(
        v37,
        Method_System_Collections_Generic_List_BoneLinkData__GetEnumerator__);
      v38 = v121;
      *(_QWORD *)&v121 = 0;
      *((_QWORD *)&v121 + 1) = &v134;
      v134 = v38;
      v135 = v122;
      while ( System_Collections_Generic_List_Enumerator_BoneLinkData___MoveNext(
                (__int64)&v134,
                Method_System_Collections_Generic_List_Enumerator_BoneLinkData__MoveNext__) )
      {
        if ( !(_QWORD)v135 )
          goto LABEL_41;
        UnityEngine_Transform__SetParent_1((void *)v135, (void *)v10, 0, nullptr);
      }
      System_Collections_Generic_List_Enumerator_BoneLinkData___Dispose(
        (__int64)&v134,
        Method_System_Collections_Generic_List_Enumerator_BoneLinkData__Dispose__);
      v10 = v136;
      if ( !v136 )
        goto LABEL_157;
    }
    v42 = *v125;
    if ( *v125 )
    {
      v43 = *(_QWORD *)v42;
      v44 = *(unsigned __int16 *)(*(_QWORD *)v42 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v42 + 302LL) )
      {
        v45 = (int *)(*(_QWORD *)(v43 + 176) + 8LL);
        while ( *((_QWORD *)v45 - 1) != System_IDisposable_TypeInfo )
        {
          --v44;
          v45 += 4;
          if ( !v44 )
            goto LABEL_47;
        }
        v46 = v43 + 16LL * *v45 + 312;
      }
      else
      {
LABEL_47:
        v46 = sub_6408234(*v125, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64, _QWORD))v46)(v42, *(_QWORD *)(v46 + 8));
    }
    v47 = v124;
    if ( v124 )
      goto LABEL_162;
  }
  else
  {
    v117 = 0;
    Values = (__int64)UnityEngine_Component__get_transform(a0, nullptr);
    if ( !Values )
      goto LABEL_151;
    Enumerator = UnityEngine_Transform__GetEnumerator((void *)Values, nullptr);
    v133 = (__int64)Enumerator;
    *(_QWORD *)&v121 = 0;
    *((_QWORD *)&v121 + 1) = &v133;
    *(_QWORD *)&v122 = &v132;
    while ( 1 )
    {
      v10 = v133;
      if ( !v133 )
        goto LABEL_153;
      v50 = *(_QWORD *)v133;
      v51 = *(unsigned __int16 *)(*(_QWORD *)v133 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v133 + 302LL) )
      {
        v52 = (int *)(*(_QWORD *)(v50 + 176) + 8LL);
        while ( *((_QWORD *)v52 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v51;
          v52 += 4;
          if ( !v51 )
            goto LABEL_59;
        }
        v53 = v50 + 16LL * *v52 + 312;
      }
      else
      {
LABEL_59:
        v53 = sub_6408234(v133, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v54 = (*(__int64 (__fastcall **)(__int64, _QWORD))v53)(v10, *(_QWORD *)(v53 + 8));
      if ( (v54 & 1) == 0 )
        break;
      v10 = v133;
      if ( !v133 )
        goto LABEL_154;
      v56 = *(_QWORD *)v133;
      v57 = *(unsigned __int16 *)(*(_QWORD *)v133 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v133 + 302LL) )
      {
        v58 = (_DWORD *)(*(_QWORD *)(v56 + 176) + 8LL);
        while ( *((_QWORD *)v58 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v57;
          v58 += 4;
          if ( !v57 )
            goto LABEL_67;
        }
        v59 = v56 + 16LL * (*v58 + 1) + 312;
      }
      else
      {
LABEL_67:
        v59 = sub_6408234(v133, System_Collections_IEnumerator_TypeInfo, 1);
      }
      v60 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))v59)(v10, *(_QWORD *)(v59 + 8));
      if ( !v60 )
        goto LABEL_155;
      v62 = UnityEngine_Transform_TypeInfo;
      v63 = *(unsigned __int8 *)(UnityEngine_Transform_TypeInfo + 304LL);
      if ( *(unsigned __int8 *)(*(_QWORD *)v60 + 304LL) < (unsigned int)v63
        || *(_QWORD *)(*(_QWORD *)(*(_QWORD *)v60 + 200LL) + 8 * v63 - 8) != UnityEngine_Transform_TypeInfo )
      {
LABEL_152:
        Enumerator = (void *)sub_63CF4A0(v60, v62);
LABEL_153:
        v54 = sub_63CF120(Enumerator, v49);
LABEL_154:
        v60 = (void *)sub_63CF120(v54, v55);
LABEL_155:
        Values = sub_63CF120(v60, v61);
LABEL_156:
        sub_63CF128(Values, v12, v73, v74);
LABEL_157:
        v37 = (void *)sub_63CF120(v19, v20);
LABEL_158:
        v25 = sub_63CF120(v37, v36);
LABEL_159:
        v31 = (_QWORD *)sub_63CF120(v25, v26);
LABEL_160:
        transform = (void *)sub_63CF120(v31, v32);
LABEL_161:
        sub_63CF120(transform, v35);
        sub_63CF118(v10);
        sub_63CF118(v5);
        v47 = v10;
LABEL_162:
        v41 = sub_63CF118(v47);
LABEL_163:
        v116 = v40;
        sub_5FE8D6C(&v121, v41);
        sub_64BD8DC(v116);
      }
      gameObject = UnityEngine_Component__get_gameObject(v60, nullptr);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      UnityEngine_Object__DestroyImmediate_1(gameObject, nullptr);
    }
    v65 = sub_63CEFF8(v133, System_IDisposable_TypeInfo);
    v132 = v65;
    if ( v65 )
    {
      v66 = *(_QWORD *)v65;
      v67 = v65;
      v68 = *(unsigned __int16 *)(*(_QWORD *)v65 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v65 + 302LL) )
      {
        v69 = (int *)(*(_QWORD *)(v66 + 176) + 8LL);
        while ( *((_QWORD *)v69 - 1) != System_IDisposable_TypeInfo )
        {
          --v68;
          v69 += 4;
          if ( !v68 )
            goto LABEL_80;
        }
        v70 = v66 + 16LL * *v69 + 312;
      }
      else
      {
LABEL_80:
        v70 = sub_6408234(v65, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64, _QWORD))v70)(v67, *(_QWORD *)(v70 + 8));
    }
  }
  v71 = v137;
  v72 = *(_QWORD *)(*(_QWORD *)(v137[4] + 192LL) + 72LL);
  if ( (*(_WORD *)(v72 + 309) & 1) == 0 )
    sub_6407F00(v72);
  v10 = sub_63CF110(v72);
  System_Collections_Generic_List_object____ctor_1((void *)v10, 16, *(void **)(*(_QWORD *)(v71[4] + 192LL) + 80LL));
  v75 = *v118;
  if ( !*v118 )
    goto LABEL_151;
  v76 = *(_DWORD *)(v75 + 24);
  if ( v76 >= 1 )
  {
    v77 = 0;
    v78 = 1;
    v5 = &Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__MoveNext__;
    v119 = *v118;
    do
    {
      if ( v77 >= (unsigned int)v76 )
        goto LABEL_156;
      v79 = v75 + 8LL * v77;
      v80 = *(void **)(v79 + 32);
      if ( !v80 )
        goto LABEL_151;
      name = UnityEngine_Object__get_name(*(void **)(v79 + 32), nullptr);
      if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
        sub_63CEFF4(VL_VLActorDefine_TypeInfo);
      RootName = VL_VLActorDefine__GetRootName(name, nullptr);
      if ( !*((_QWORD *)a0 + 9) )
        goto LABEL_113;
      VL_Core_SerializedDictionary_object__object___GetEnumerator(
        *((void **)a0 + 9),
        Method_VL_Core_SerializedDictionary_string__VLActorModelParts__GetEnumerator__);
      v131 = v123;
      v129 = v121;
      v130 = v122;
      *(_QWORD *)&v121 = 0;
      *((_QWORD *)&v121 + 1) = &v129;
      do
      {
        v83 = System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(
                (__int64)&v129,
                Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__MoveNext__);
        if ( !v83 )
        {
          System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(
            (__int64)&v129,
            Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__Dispose__);
LABEL_113:
          v92 = nullptr;
          goto LABEL_114;
        }
        v85 = *((_QWORD *)&v130 + 1);
        if ( !*((_QWORD *)&v130 + 1) )
        {
          v40 = sub_63CF120(v83, v84);
          goto LABEL_163;
        }
        v86 = (void *)v130;
        v87 = UnityEngine_Object__get_name(*((void **)&v130 + 1), nullptr);
      }
      while ( !System_String__op_Equality(v87, RootName, nullptr) );
      v88 = System_String__op_Equality(name, v86, nullptr);
      if ( v88 )
      {
        v89 = System_String__Concat_2(StringLiteral_ReRegister_, name, nullptr);
        if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Debug_TypeInfo);
        UnityEngine_Debug__Log(v89, nullptr);
      }
      v90 = *(_QWORD *)(*(_QWORD *)(v137[4] + 192LL) + 64LL);
      if ( (*(_WORD *)(v90 + 309) & 1) == 0 )
      {
        sub_6407F00(*(_QWORD *)(*(_QWORD *)(v137[4] + 192LL) + 64LL));
        v90 = v91;
      }
      v92 = (void *)sub_63CEFF8(v85, v90);
      v93 = *((void **)a0 + 9);
      if ( !v93 )
      {
LABEL_41:
        v40 = sub_63CF120(0, v39);
        goto LABEL_163;
      }
      VL_Core_SerializedDictionary_object__object___Remove(
        v93,
        v86,
        Method_VL_Core_SerializedDictionary_string__VLActorModelParts__Remove__);
      System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(
        (__int64)&v129,
        Method_System_Collections_Generic_Dictionary_Enumerator_string__VLActorModelParts__Dispose__);
      if ( v88 )
      {
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        Values = UnityEngine_Object__op_Inequality(v92, nullptr, nullptr);
        if ( (Values & 1) != 0 )
        {
          if ( v92 )
          {
            v94 = UnityEngine_Component__get_transform(v92, nullptr);
            Values = (__int64)UnityEngine_Component__get_transform(a0, nullptr);
            if ( v94 )
            {
              UnityEngine_Transform__SetParent_1(v94, (void *)Values, 0, nullptr);
              if ( (v78 & 1) != 0 )
              {
                *((_QWORD *)a0 + 46) = v92;
                sub_63CEE24((char *)a0 + 368, (int)v92, v95, v96, v97, v98);
              }
              goto LABEL_135;
            }
          }
          goto LABEL_151;
        }
      }
LABEL_114:
      v99 = UnityEngine_Component__get_transform(a0, nullptr);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      Values = (__int64)UnityEngine_Object__Instantiate_object__6(
                          v80,
                          v99,
                          0,
                          Method_UnityEngine_Object_Instantiate_GameObject____2);
      if ( !Values )
        goto LABEL_151;
      v100 = (void *)Values;
      UnityEngine_Object__set_name((void *)Values, RootName, nullptr);
      v101 = UnityEngine_GameObject__AddComponent_object_(v100, *(void **)(*(_QWORD *)(v137[4] + 192LL) + 96LL));
      v106 = v101;
      if ( (v78 & 1) != 0 )
      {
        *((_QWORD *)a0 + 46) = v101;
        sub_63CEE24((char *)a0 + 368, (int)v101, v102, v103, v104, v105);
      }
      if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
        sub_63CEFF4(VL_VLActorDefine_TypeInfo);
      PartsId = VL_VLActorDefine__GetPartsId(name, 1, nullptr);
      Values = (*(__int64 (__fastcall **)(void *, void *, void *, _QWORD))(*(_QWORD *)a0 + 1208LL))(
                 a0,
                 PartsId,
                 v100,
                 *(_QWORD *)(*(_QWORD *)a0 + 1216LL));
      if ( !v106 )
        goto LABEL_151;
      (*(void (__fastcall **)(_QWORD *, void *, void *, _QWORD))(*v106 + 376LL))(
        v106,
        PartsId,
        name,
        *(_QWORD *)(*v106 + 384LL));
      if ( System_String__op_Equality(PartsId, (void *)StringLiteral_body, nullptr) )
      {
        v108 = 2;
      }
      else
      {
        Values = System_String__op_Equality(PartsId, (void *)StringLiteral_face, nullptr);
        if ( (Values & 1) != 0 )
        {
          v108 = 1;
        }
        else
        {
          v109 = v106[13];
          if ( !v109 )
            goto LABEL_151;
          v108 = *(int *)(v109 + 24) <= 0 ? 0 : 3;
        }
      }
      v110 = UnityEngine_Object_TypeInfo;
      *((_DWORD *)v106 + 32) = v108;
      if ( !*(_DWORD *)(v110 + 228) )
        sub_63CEFF4(v110);
      Values = UnityEngine_Object__op_Inequality(v92, nullptr, nullptr);
      if ( (Values & 1) != 0 )
        VL_Core_VLActorController_object__object__object___AddDestroyParts(
          a0,
          v92,
          *(void **)(*(_QWORD *)(v137[4] + 192LL) + 120LL));
      v92 = v106;
LABEL_135:
      if ( !v10
        || (v111 = *(_QWORD *)(v10 + 16),
            v112 = *(_QWORD *)(*(_QWORD *)(v137[4] + 192LL) + 128LL),
            ++*(_DWORD *)(v10 + 28),
            !v111) )
      {
LABEL_151:
        v60 = (void *)sub_63CF120(Values, v12);
        goto LABEL_152;
      }
      v113 = *(int *)(v10 + 24);
      if ( (unsigned int)v113 >= *(_DWORD *)(v111 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          (void *)v10,
          v92,
          *(void **)(*(_QWORD *)(*(_QWORD *)(v112 + 32) + 192LL) + 112LL));
      }
      else
      {
        v114 = v111 + 8 * v113;
        *(_DWORD *)(v10 + 24) = v113 + 1;
        *(_QWORD *)(v114 + 32) = v92;
        sub_63CEE24((void *)(v114 + 32), (int)v92, v95, v96, v97, v98);
      }
      v75 = v119;
      ++v77;
      v78 = 0;
      v76 = *(_DWORD *)(v119 + 24);
    }
    while ( v77 < v76 );
  }
  Values = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 872LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 880LL));
  if ( !v10 )
    goto LABEL_151;
  System_Collections_Generic_List_object___GetEnumerator((void *)v10, *(void **)(*(_QWORD *)(v137[4] + 192LL) + 136LL));
  *(_QWORD *)&v121 = 0;
  *((_QWORD *)&v121 + 1) = &v126;
  *(_QWORD *)&v122 = &v137;
  while ( System_Collections_Generic_List_Enumerator_object___MoveNext(
            (__int64)&v126,
            *(void **)(*(_QWORD *)(v137[4] + 192LL) + 176LL)) )
    VL_Core_VLActorController_object__object__object___AddParts(a0, v128, v115);
  System_Collections_Generic_List_Enumerator_object___Dispose(
    (__int64)&v126,
    *(void **)(*(_QWORD *)(v137[4] + 192LL) + 184LL));
  VL_Core_VLActorController__InitializeAABB(a0, nullptr);
  if ( (*(_DWORD *)&v117 & 1) == 0 )
    (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)a0 + 840LL))(a0, 0, *(_QWORD *)(*(_QWORD *)a0 + 848LL));
  (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 1304LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 1312LL));
}

