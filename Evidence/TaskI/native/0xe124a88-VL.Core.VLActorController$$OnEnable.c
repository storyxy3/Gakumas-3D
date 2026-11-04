// VL.Core.VLActorController$$OnEnable @ 0xe124a88
void __fastcall VL_Core_VLActorController__OnEnable(void *a0, void *a1)
{
  void *v3; // x20
  __int64 v4; // x1
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  __int64 v9; // x0
  void *v10; // x20
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  __int64 v15; // x0
  __int64 v16; // x0
  int *v17; // x0
  __int64 v18; // x8
  __int64 v19; // x9
  __int64 v20; // x10
  __int64 v21; // x8
  void *v22; // x1
  int v23; // w20
  void *Item; // x21

  if ( (unk_F43DD5C & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Application_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_IVLActorController__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_IVLActorController___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLActorExtension__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLActorExtension__get_Item__);
    sub_63CEE78(&System_Collections_Generic_List_IVLActorController__TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&VL_Core_VLActorController_TypeInfo);
    unk_F43DD5C = 1;
  }
  v3 = *((void **)a0 + 6);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
    (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 888LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 896LL));
  v9 = VL_Core_VLActorController_TypeInfo;
  if ( !*(_DWORD *)(VL_Core_VLActorController_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VL_Core_VLActorController_TypeInfo);
    v9 = VL_Core_VLActorController_TypeInfo;
  }
  if ( !*(_QWORD *)(*(_QWORD *)(v9 + 184) + 16LL) )
  {
    v10 = (void *)sub_63CF110(System_Collections_Generic_List_IVLActorController__TypeInfo);
    System_Collections_Generic_List_object____ctor(
      v10,
      Method_System_Collections_Generic_List_IVLActorController___ctor__);
    v15 = VL_Core_VLActorController_TypeInfo;
    if ( !*(_DWORD *)(VL_Core_VLActorController_TypeInfo + 228LL) )
    {
      sub_63CEFF4(VL_Core_VLActorController_TypeInfo);
      v15 = VL_Core_VLActorController_TypeInfo;
    }
    v16 = *(_QWORD *)(v15 + 184);
    *(_QWORD *)(v16 + 16) = v10;
    sub_63CEE24((void *)(v16 + 16), (int)v10, v11, v12, v13, v14);
    v9 = VL_Core_VLActorController_TypeInfo;
  }
  if ( !*(_DWORD *)(v9 + 228) )
  {
    sub_63CEFF4(v9);
    v9 = VL_Core_VLActorController_TypeInfo;
  }
  v17 = *(int **)(*(_QWORD *)(v9 + 184) + 16LL);
  if ( v17
    && (v18 = *((_QWORD *)v17 + 2), v19 = Method_System_Collections_Generic_List_IVLActorController__Add__,
                                    ++v17[7],
                                    v18) )
  {
    v20 = v17[6];
    if ( (unsigned int)v20 >= *(_DWORD *)(v18 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v17,
        a0,
        *(void **)(*(_QWORD *)(*(_QWORD *)(v19 + 32) + 192LL) + 112LL));
    }
    else
    {
      v21 = v18 + 8 * v20;
      v17[6] = v20 + 1;
      *(_QWORD *)(v21 + 32) = a0;
      sub_63CEE24((void *)(v21 + 32), (int)a0, v5, v6, v7, v8);
    }
    VL_Core_VLActorController__InitializeAABB(a0, v22);
    v17 = *((int **)a0 + 7);
    if ( v17 )
    {
      v23 = 0;
      while ( v23 < v17[6] )
      {
        Item = System_Collections_Generic_List_object___get_Item(
                 v17,
                 v23,
                 Method_System_Collections_Generic_List_VLActorExtension__get_Item__);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        if ( UnityEngine_Object__op_Inequality(Item, nullptr, nullptr) )
        {
          v17 = *((int **)a0 + 7);
          if ( !v17 )
            goto LABEL_36;
          v17 = (int *)System_Collections_Generic_List_object___get_Item(
                         v17,
                         v23,
                         Method_System_Collections_Generic_List_VLActorExtension__get_Item__);
          if ( !v17 )
            goto LABEL_36;
          if ( ((*(__int64 (__fastcall **)(int *, _QWORD))(*(_QWORD *)v17 + 424LL))(
                  v17,
                  *(_QWORD *)(*(_QWORD *)v17 + 432LL))
              & 1) == 0 )
            goto LABEL_32;
          if ( !*(_DWORD *)(UnityEngine_Application_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Application_TypeInfo);
          if ( UnityEngine_Application__get_isPlaying(nullptr) )
          {
LABEL_32:
            v17 = *((int **)a0 + 7);
            if ( !v17 )
              goto LABEL_36;
            v17 = (int *)System_Collections_Generic_List_object___get_Item(
                           v17,
                           v23,
                           Method_System_Collections_Generic_List_VLActorExtension__get_Item__);
            if ( !v17 )
              goto LABEL_36;
            (*(void (__fastcall **)(int *, _QWORD))(*(_QWORD *)v17 + 472LL))(v17, *(_QWORD *)(*(_QWORD *)v17 + 480LL));
          }
        }
        v17 = *((int **)a0 + 7);
        ++v23;
        if ( !v17 )
          goto LABEL_36;
      }
    }
  }
  else
  {
LABEL_36:
    sub_63CF120(v17, v4);
  }
}

