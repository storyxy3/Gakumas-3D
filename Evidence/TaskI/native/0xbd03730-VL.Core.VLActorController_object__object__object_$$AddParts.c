// 0xbd03730 @ 0xbd03730
void __fastcall VL_Core_VLActorController_object__object__object___AddParts(void *a0, void *a1, void *a2)
{
  void **v4; // x25
  _DWORD *v5; // x21
  void *v6; // x23
  void *v7; // x24
  int v8; // w24
  void *v9; // x1
  void *v10; // x26
  void *v11; // x25
  void *name; // x0
  __int64 v13; // x8
  void *v14; // x27
  void *v15; // x21
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  int *v20; // x8
  __int64 v21; // x9
  __int64 v22; // x10
  __int64 v23; // x11
  __int64 v24; // x0
  void *v25; // x0
  void *v26; // x1
  void **v27; // [xsp+8h] [xbp+8h]

  v4 = (void **)a0;
  if ( (unk_F41D601 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLActorModelParts__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData__get_Item__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__Add__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__VLActorModelParts__ContainsKey__);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    a0 = (void *)sub_63CEE78(&StringLiteral_PartsID_________);
    unk_F41D601 = 1;
  }
  if ( !a1 )
    goto LABEL_43;
  VL_Core_VLActorModelParts__InitializeBones(a1, v4[11], nullptr);
  a0 = v4[9];
  if ( !a0 )
    goto LABEL_43;
  v5 = *((_DWORD **)a1 + 9);
  if ( !VL_Core_SerializedDictionary_object__object___ContainsKey(
          a0,
          *((void **)a1 + 4),
          Method_VL_Core_SerializedDictionary_string__VLActorModelParts__ContainsKey__) )
  {
    a0 = v4[9];
    if ( !a0 )
      goto LABEL_43;
    VL_Core_SerializedDictionary_object__object___Add(
      a0,
      *((void **)a1 + 4),
      a1,
      Method_VL_Core_SerializedDictionary_string__VLActorModelParts__Add__);
  }
  a0 = UnityEngine_Component__get_transform(a1, nullptr);
  v6 = a0;
  if ( !byte_F40009D[0] )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    byte_F40009D[0] = 1;
  }
  if ( !v6 )
    goto LABEL_43;
  UnityEngine_Transform__set_localPosition(
    v6,
    *(UnityEngine_Vector3_o *)*(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL),
    nullptr);
  a0 = UnityEngine_Component__get_transform(a1, nullptr);
  v7 = a0;
  if ( !byte_F40034E[366] )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Quaternion_TypeInfo);
    byte_F40034E[366] = 1;
  }
  v27 = v4;
  if ( !v7 )
    goto LABEL_43;
  UnityEngine_Transform__set_localRotation(
    v7,
    *(UnityEngine_Quaternion_o *)*(_QWORD *)(UnityEngine_Quaternion_TypeInfo + 184LL),
    nullptr);
  if ( !v5 )
    goto LABEL_43;
  if ( (int)v5[6] >= 1 )
  {
    v8 = 0;
    do
    {
      System_Collections_Generic_List_BoneLinkData___get_Item(
        v5,
        v8,
        Method_System_Collections_Generic_List_BoneLinkData__get_Item__);
      v10 = v9;
      a0 = (void *)System_Collections_Generic_List_BoneLinkData___get_Item(
                     v5,
                     v8,
                     Method_System_Collections_Generic_List_BoneLinkData__get_Item__);
      if ( !v10 )
        goto LABEL_43;
      v11 = a0;
      name = UnityEngine_Object__get_name(v10, nullptr);
      v13 = VL_VLActorDefine_TypeInfo;
      v14 = name;
      if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
      {
        sub_63CEFF4(VL_VLActorDefine_TypeInfo);
        v13 = VL_VLActorDefine_TypeInfo;
      }
      a0 = (void *)VL_VLUtility__FastStartsWith(v14, **(void ***)(v13 + 184), nullptr);
      if ( ((unsigned __int8)a0 & 1) == 0 )
      {
        if ( !v11 )
          goto LABEL_43;
        UnityEngine_Transform__SetParent_1(v11, v10, 0, nullptr);
      }
      if ( !byte_F40009D[0] )
      {
        a0 = (void *)sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
        byte_F40009D[0] = 1;
      }
      if ( !v11 )
        goto LABEL_43;
      UnityEngine_Transform__set_localPosition(
        v11,
        *(UnityEngine_Vector3_o *)*(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL),
        nullptr);
      if ( !byte_F40034E[366] )
      {
        sub_63CEE78(&UnityEngine_Quaternion_TypeInfo);
        byte_F40034E[366] = 1;
      }
      UnityEngine_Transform__set_localRotation(
        v11,
        *(UnityEngine_Quaternion_o *)*(_QWORD *)(UnityEngine_Quaternion_TypeInfo + 184LL),
        nullptr);
      if ( !byte_F40009D[436] )
      {
        sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
        byte_F40009D[436] = 1;
      }
      UnityEngine_Transform__set_localScale(
        v11,
        *(UnityEngine_Vector3_o *)(*(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL) + 12LL),
        nullptr);
    }
    while ( ++v8 < v5[6] );
  }
  a0 = v27[10];
  if ( !a0 )
  {
LABEL_43:
    v25 = (void *)sub_63CF120(a0, a1);
    VL_Core_VLActorController_object__object__object____ctor(v25, v26);
    return;
  }
  if ( !VL_Core_SerializedDictionary_object__object___ContainsKey(
          a0,
          *((void **)a1 + 5),
          Method_VL_Core_SerializedDictionary_string__VLActorModelParts__ContainsKey__) )
  {
    a0 = v27[10];
    if ( a0 )
    {
      VL_Core_SerializedDictionary_object__object___Add(
        a0,
        *((void **)a1 + 5),
        a1,
        Method_VL_Core_SerializedDictionary_string__VLActorModelParts__Add__);
      goto LABEL_38;
    }
    goto LABEL_43;
  }
  v15 = System_String__Concat_2(StringLiteral_PartsID_________, *((void **)a1 + 5), nullptr);
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(v15, nullptr);
LABEL_38:
  v20 = (int *)v27[8];
  if ( !v20 )
    goto LABEL_43;
  v21 = *((_QWORD *)v20 + 2);
  v22 = Method_System_Collections_Generic_List_VLActorModelParts__Add__;
  ++v20[7];
  if ( !v21 )
    goto LABEL_43;
  v23 = v20[6];
  if ( (unsigned int)v23 >= *(_DWORD *)(v21 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(
      v20,
      a1,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v22 + 32) + 192LL) + 112LL));
  }
  else
  {
    v24 = v21 + 8 * v23;
    v20[6] = v23 + 1;
    *(_QWORD *)(v24 + 32) = a1;
    sub_63CEE24((void *)(v24 + 32), (int)a1, v16, v17, v18, v19);
  }
}

