// VL.Core.VLActorModelParts$$UpdateRootBoneLinkList @ 0xe12908c
void __fastcall VL_Core_VLActorModelParts__UpdateRootBoneLinkList(void *a0, void *a1, void *a2)
{
  __int64 v5; // x8
  __int64 *v6; // x20
  int v7; // w2
  int v8; // w9
  void *v9; // x21
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  __int64 v14; // x8
  int **v15; // x21
  int v16; // w2
  int v17; // w9
  void *v18; // x23
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  int *transform; // x0
  __int64 v24; // x1
  int v25; // w23
  void *Child; // x24
  int v27; // w2
  int v28; // w3
  int v29; // w4
  void *v30; // x5
  __int64 v31; // x8
  __int64 v32; // x9
  __int64 v33; // x10
  __int64 v34; // x8
  int v35; // w22
  void *Item; // x23
  __int64 v37; // x23
  void *v38; // x0
  void *v39; // x24
  int v40; // w2
  int v41; // w3
  int v42; // w4
  void *v43; // x5
  int v44; // w2
  int v45; // w3
  int v46; // w4
  void *v47; // x5
  int v48; // w3
  int v49; // w4
  void *v50; // x5
  void *v51; // x2
  __int64 v52; // x8
  __int64 v53; // x10
  __int64 v54; // x0
  __int64 v55; // [xsp+8h] [xbp+8h] BYREF
  void *v56; // [xsp+10h] [xbp+10h] BYREF
  void *v57; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F43DD84 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_Transform__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Transform__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_BoneLinkData___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Transform___ctor___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_Transform__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Transform__get_Item__);
    sub_63CEE78(&System_Collections_Generic_List_Transform__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_BoneLinkData__TypeInfo);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__Transform__TryGetValue__);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    unk_F43DD84 = 1;
  }
  v57 = nullptr;
  v6 = (__int64 *)((char *)a0 + 72);
  v5 = *((_QWORD *)a0 + 9);
  if ( v5 )
  {
    v7 = *(_DWORD *)(v5 + 24);
    v8 = *(_DWORD *)(v5 + 28) + 1;
    *(_DWORD *)(v5 + 24) = 0;
    *(_DWORD *)(v5 + 28) = v8;
    if ( v7 >= 1 )
      System_Array__Clear(*(void **)(v5 + 16), 0, v7, nullptr);
  }
  else
  {
    v9 = (void *)sub_63CF110(System_Collections_Generic_List_BoneLinkData__TypeInfo);
    System_Collections_Generic_List_BoneLinkData____ctor(
      v9,
      Method_System_Collections_Generic_List_BoneLinkData___ctor__);
    *v6 = (__int64)v9;
    sub_63CEE24((char *)a0 + 72, (int)v9, v10, v11, v12, v13);
  }
  v15 = (int **)((char *)a0 + 144);
  v14 = *((_QWORD *)a0 + 18);
  if ( v14 )
  {
    v16 = *(_DWORD *)(v14 + 24);
    v17 = *(_DWORD *)(v14 + 28) + 1;
    *(_DWORD *)(v14 + 24) = 0;
    *(_DWORD *)(v14 + 28) = v17;
    if ( v16 >= 1 )
      System_Array__Clear(*(void **)(v14 + 16), 0, v16, nullptr);
  }
  else
  {
    v18 = (void *)sub_63CF110(System_Collections_Generic_List_Transform__TypeInfo);
    System_Collections_Generic_List_object____ctor_1(
      v18,
      8,
      Method_System_Collections_Generic_List_Transform___ctor___1);
    *v15 = (int *)v18;
    sub_63CEE24((char *)a0 + 144, (int)v18, v19, v20, v21, v22);
  }
  transform = (int *)UnityEngine_Component__get_transform(a0, nullptr);
  if ( !transform )
    goto LABEL_39;
  v25 = 0;
  while ( v25 < UnityEngine_Transform__get_childCount(transform, nullptr) )
  {
    transform = (int *)UnityEngine_Component__get_transform(a0, nullptr);
    if ( !transform )
      goto LABEL_39;
    Child = UnityEngine_Transform__GetChild(transform, v25, nullptr);
    if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
      sub_63CEFF4(VL_VLActorDefine_TypeInfo);
    if ( VL_VLActorDefine__IsBone(Child, nullptr) )
    {
      transform = *v15;
      if ( !*v15 )
        goto LABEL_39;
      v31 = *((_QWORD *)transform + 2);
      v32 = Method_System_Collections_Generic_List_Transform__Add__;
      ++transform[7];
      if ( !v31 )
        goto LABEL_39;
      v33 = transform[6];
      if ( (unsigned int)v33 >= *(_DWORD *)(v31 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          transform,
          Child,
          *(void **)(*(_QWORD *)(*(_QWORD *)(v32 + 32) + 192LL) + 112LL));
      }
      else
      {
        v34 = v31 + 8 * v33;
        transform[6] = v33 + 1;
        *(_QWORD *)(v34 + 32) = Child;
        sub_63CEE24((void *)(v34 + 32), (int)Child, v27, v28, v29, v30);
      }
    }
    ++v25;
    transform = (int *)UnityEngine_Component__get_transform(a0, nullptr);
    if ( !transform )
      goto LABEL_39;
  }
  transform = *v15;
  if ( *v15 )
  {
    v35 = 0;
    while ( v35 < transform[6] )
    {
      Item = System_Collections_Generic_List_object___get_Item(
               transform,
               v35,
               Method_System_Collections_Generic_List_Transform__get_Item__);
      if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
        sub_63CEFF4(VL_VLActorDefine_TypeInfo);
      transform = (int *)VL_VLActorDefine__GetConnectionName(Item, nullptr);
      if ( !a1 )
        goto LABEL_39;
      if ( VL_Core_SerializedDictionary_object__object___TryGetValue(
             a1,
             transform,
             &v57,
             Method_VL_Core_SerializedDictionary_string__Transform__TryGetValue__) )
      {
        transform = *v15;
        if ( !*v15 )
          goto LABEL_39;
        v37 = *v6;
        v38 = System_Collections_Generic_List_object___get_Item(
                transform,
                v35,
                Method_System_Collections_Generic_List_Transform__get_Item__);
        v39 = v57;
        v55 = (__int64)v38;
        v56 = nullptr;
        sub_63CEE24(&v55, (int)v38, v40, v41, v42, v43);
        v56 = v39;
        sub_63CEE24(&v56, (int)v39, v44, v45, v46, v47);
        if ( !v37 )
          goto LABEL_39;
        v24 = v55;
        v51 = v56;
        v52 = *(_QWORD *)(v37 + 16);
        ++*(_DWORD *)(v37 + 28);
        if ( !v52 )
          goto LABEL_39;
        v53 = *(int *)(v37 + 24);
        if ( (unsigned int)v53 >= *(_DWORD *)(v52 + 24) )
        {
          System_Collections_Generic_List_BoneLinkData___AddWithResize((void *)v37, v24, v51);
        }
        else
        {
          v54 = v52 + 16 * v53;
          *(_DWORD *)(v37 + 24) = v53 + 1;
          *(_QWORD *)(v54 + 32) = v24;
          *(_QWORD *)(v54 + 40) = v51;
          sub_63CEE24((void *)(v54 + 32), 0, (int)v51, v48, v49, v50);
        }
      }
      transform = *v15;
      ++v35;
      if ( !*v15 )
        goto LABEL_39;
    }
  }
  else
  {
LABEL_39:
    sub_63CF120(transform, v24);
  }
}

