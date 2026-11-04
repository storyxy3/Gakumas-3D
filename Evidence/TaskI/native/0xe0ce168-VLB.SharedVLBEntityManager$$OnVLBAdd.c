// VLB.SharedVLBEntityManager$$OnVLBAdd @ 0xe0ce168
void __fastcall VLB_SharedVLBEntityManager__OnVLBAdd(void *a0, void *a1, void *a2)
{
  _QWORD *v3; // x19
  void *v4; // x20
  __int64 v5; // x21
  __int64 v6; // x22
  __int64 v7; // x23
  __int64 v8; // x24
  __int64 v9; // x8
  void *v10; // x2
  __int64 v11; // x0
  __int64 v12; // x1
  void *v13; // x2
  __int64 v14; // x30
  __int64 v15; // x1
  __int64 v16; // x30
  __int64 v17; // x20
  __int64 v18; // x19
  char *Item; // x0
  void *v20; // x2
  void *v21; // x2
  unsigned __int64 v22; // x24
  void *v23; // x21
  void *v24; // x22
  void *v25; // x3
  unsigned __int64 v26; // x24
  char *v27; // x23
  int v28; // w8
  _QWORD *v29; // x0
  __int64 *v30; // x1
  void *v31; // x2
  __int64 v32; // x30
  __int64 v33; // x8
  _QWORD *v34; // x20
  __int64 *v35; // x19
  void *v36; // x4
  __int64 v37; // x1
  __int64 *v38; // x2
  bool v39; // w3
  __int128 v40; // [xsp+0h] [xbp+0h] BYREF
  __int64 v41; // [xsp+10h] [xbp+10h]
  __int64 v42; // [xsp+18h] [xbp+18h]
  __int64 v43; // [xsp+20h] [xbp+20h]
  __int64 v44; // [xsp+28h] [xbp+28h]
  __int64 v45; // [xsp+30h] [xbp+30h]
  __int64 v46; // [xsp+38h] [xbp+38h]
  void *v47; // [xsp+40h] [xbp+40h]
  _QWORD *v48; // [xsp+48h] [xbp+48h]

  if ( a1 )
  {
    v9 = *((_QWORD *)a0 + 2);
    v4 = a0;
    if ( v9 )
    {
      a0 = *(void **)(v9 + 64);
      if ( a0 )
      {
        v3 = a1;
        if ( VLB_EntityIndexer__IsValid(a0, *((_QWORD *)a1 + 40), a2) )
          return;
        a0 = *((void **)v4 + 2);
        if ( a0 )
        {
          v3[40] = VLB_VLBEntityManager__CreateEntity(a0, v3, v10);
          return;
        }
      }
    }
  }
  v11 = sub_63CF120(a0, a1);
  *((_QWORD *)&v40 - 2) = v14;
  if ( v12 && (v11 = *(_QWORD *)(v11 + 16)) != 0 )
  {
    v15 = *(_QWORD *)(v12 + 320);
    v16 = v40;
  }
  else
  {
    v11 = sub_63CF120(v11, v12);
  }
  v41 = v16;
  v43 = v8;
  v44 = v7;
  v45 = v6;
  v46 = v5;
  v47 = v4;
  v48 = v3;
  v17 = v15;
  v18 = v11;
  if ( (unk_F43D9EE & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    unk_F43D9EE = 1;
  }
  Item = *(char **)(v18 + 64);
  v40 = 0u;
  if ( Item )
  {
    if ( !VLB_EntityIndexer__IsValid(Item, v17, v13) )
      return;
    Item = *(char **)(v18 + 64);
    if ( Item )
    {
      Item = (char *)VLB_EntityIndexer__GetItem(Item, v17, v20);
      if ( *(_QWORD *)(v18 + 64) )
      {
        v22 = (unsigned __int64)Item;
        VLB_EntityIndexer__DestroyEntity(*(void **)(v18 + 64), v17, v21);
        Item = *(char **)(v18 + 24);
        if ( Item )
        {
          Item = (char *)System_Collections_Generic_List_object___get_Item(
                           Item,
                           v22,
                           Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
          if ( *(_QWORD *)(v18 + 32) )
          {
            v17 = (__int64)Item;
            Item = (char *)System_Collections_Generic_List_object___get_Item(
                             *(void **)(v18 + 32),
                             v22,
                             Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
            if ( *(_QWORD *)(v18 + 40) )
            {
              v23 = Item;
              Item = (char *)System_Collections_Generic_List_object___get_Item(
                               *(void **)(v18 + 40),
                               v22,
                               Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
              if ( *(_QWORD *)(v18 + 48) )
              {
                v24 = Item;
                Item = (char *)System_Collections_Generic_List_object___get_Item(
                                 *(void **)(v18 + 48),
                                 v22,
                                 Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
                if ( v17 )
                {
                  v26 = HIDWORD(v22);
                  v27 = Item;
                  v28 = *(_DWORD *)(v17 + 16) - 1;
                  if ( v28 != (_DWORD)v26 )
                  {
                    Item = *(char **)(v18 + 64);
                    if ( !Item )
                      goto LABEL_31;
                    VLB_EntityIndexer__UpdateIndex(Item, *(_QWORD *)(*(_QWORD *)(v17 + 40) + 8LL * v28), v26, v25);
                  }
                  if ( v27 )
                  {
                    v40 = *(_OWORD *)(v27 + 24);
                    Unity_Jobs_JobHandle__Complete((__int64)&v40, nullptr);
                    Item = (char *)(*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v17 + 408LL))(
                                     v17,
                                     (unsigned int)v26,
                                     *(_QWORD *)(*(_QWORD *)v17 + 416LL));
                    if ( v23 )
                    {
                      Item = (char *)(*(__int64 (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)v23 + 408LL))(
                                       v23,
                                       (unsigned int)v26,
                                       *(_QWORD *)(*(_QWORD *)v23 + 416LL));
                      if ( v24 )
                      {
                        (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)v24 + 408LL))(
                          v24,
                          (unsigned int)v26,
                          *(_QWORD *)(*(_QWORD *)v24 + 416LL));
                        (*(void (__fastcall **)(char *, _QWORD, _QWORD))(*(_QWORD *)v27 + 408LL))(
                          v27,
                          (unsigned int)v26,
                          *(_QWORD *)(*(_QWORD *)v27 + 416LL));
                        return;
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
LABEL_31:
  v29 = (_QWORD *)sub_63CF120(Item, v15);
  *((_QWORD *)&v40 - 4) = v32;
  v41 = v17;
  v42 = v18;
  if ( !v30 )
    goto LABEL_39;
  v33 = v29[2];
  v34 = v29;
  if ( !v33 )
    goto LABEL_39;
  v29 = *(_QWORD **)(v33 + 64);
  if ( !v29 )
    goto LABEL_39;
  v35 = v30;
  if ( VLB_EntityIndexer__IsValid(v29, v30[40], v31) )
  {
    v29 = (_QWORD *)v34[2];
    if ( v29 )
    {
      v37 = v35[40];
      v38 = v35;
      v39 = 1;
LABEL_37:
      VLB_VLBEntityManager__UpdateEntityData(v29, v37, v38, v39, v36);
      return;
    }
LABEL_39:
    v29 = (_QWORD *)sub_63CF120(v29, v30);
    goto LABEL_37;
  }
}

