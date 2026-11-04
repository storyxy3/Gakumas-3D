// VLB.VLBEntityManager$$DestroyEntity @ 0xe0ce1dc
void __fastcall VLB_VLBEntityManager__DestroyEntity(void *a0, __int64 a1, void *a2)
{
  char *Item; // x0
  void *v6; // x2
  void *v7; // x2
  unsigned __int64 v8; // x24
  _DWORD *v9; // x20
  void *v10; // x21
  void *v11; // x22
  void *v12; // x3
  unsigned __int64 v13; // x24
  char *v14; // x23
  int v15; // w8
  void *v16; // x0
  void *v17; // x1
  void *v18; // x2
  __int128 v19; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43D9EE & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    unk_F43D9EE = 1;
  }
  Item = *((char **)a0 + 8);
  v19 = 0u;
  if ( !Item )
    goto LABEL_20;
  if ( !VLB_EntityIndexer__IsValid(Item, a1, a2) )
    return;
  Item = *((char **)a0 + 8);
  if ( !Item )
    goto LABEL_20;
  Item = (char *)VLB_EntityIndexer__GetItem(Item, a1, v6);
  if ( !*((_QWORD *)a0 + 8) )
    goto LABEL_20;
  v8 = (unsigned __int64)Item;
  VLB_EntityIndexer__DestroyEntity(*((void **)a0 + 8), a1, v7);
  Item = *((char **)a0 + 3);
  if ( !Item )
    goto LABEL_20;
  Item = (char *)System_Collections_Generic_List_object___get_Item(
                   Item,
                   v8,
                   Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 4) )
    goto LABEL_20;
  v9 = Item;
  Item = (char *)System_Collections_Generic_List_object___get_Item(
                   *((void **)a0 + 4),
                   v8,
                   Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 5) )
    goto LABEL_20;
  v10 = Item;
  Item = (char *)System_Collections_Generic_List_object___get_Item(
                   *((void **)a0 + 5),
                   v8,
                   Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 6) )
    goto LABEL_20;
  v11 = Item;
  Item = (char *)System_Collections_Generic_List_object___get_Item(
                   *((void **)a0 + 6),
                   v8,
                   Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
  if ( !v9 )
    goto LABEL_20;
  v13 = HIDWORD(v8);
  v14 = Item;
  v15 = v9[4] - 1;
  if ( v15 != (_DWORD)v13 )
  {
    Item = *((char **)a0 + 8);
    if ( Item )
    {
      VLB_EntityIndexer__UpdateIndex(Item, *(_QWORD *)(*((_QWORD *)v9 + 5) + 8LL * v15), v13, v12);
      goto LABEL_15;
    }
LABEL_20:
    v16 = (void *)sub_63CF120(Item, a1);
    VLB_SharedVLBEntityManager__OnVLBPropertyChange(v16, v17, v18);
    return;
  }
LABEL_15:
  if ( !v14 )
    goto LABEL_20;
  v19 = *(_OWORD *)(v14 + 24);
  Unity_Jobs_JobHandle__Complete((__int64)&v19, nullptr);
  Item = (char *)(*(__int64 (__fastcall **)(_DWORD *, _QWORD, _QWORD))(*(_QWORD *)v9 + 408LL))(
                   v9,
                   (unsigned int)v13,
                   *(_QWORD *)(*(_QWORD *)v9 + 416LL));
  if ( !v10 )
    goto LABEL_20;
  Item = (char *)(*(__int64 (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)v10 + 408LL))(
                   v10,
                   (unsigned int)v13,
                   *(_QWORD *)(*(_QWORD *)v10 + 416LL));
  if ( !v11 )
    goto LABEL_20;
  (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)v11 + 408LL))(
    v11,
    (unsigned int)v13,
    *(_QWORD *)(*(_QWORD *)v11 + 416LL));
  (*(void (__fastcall **)(char *, _QWORD, _QWORD))(*(_QWORD *)v14 + 408LL))(
    v14,
    (unsigned int)v13,
    *(_QWORD *)(*(_QWORD *)v14 + 416LL));
}

