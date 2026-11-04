// VLB.VLBEntityManager$$UpdateAllEntityData @ 0xe0cf35c
void __fastcall VLB_VLBEntityManager__UpdateAllEntityData(void *a0, void *a1)
{
  int v3; // w8
  int v4; // w20
  void *Item; // x0
  int v6; // w2
  int v7; // w3
  void *v8; // x4
  unsigned __int64 v9; // x23
  __int64 v10; // x8
  void *v11; // x0
  __int64 v12; // x1
  void *v13; // x2
  __int64 v14; // [xsp+8h] [xbp+8h]
  __int64 v15; // [xsp+10h] [xbp+10h]
  __int128 v16; // [xsp+30h] [xbp+30h] BYREF

  if ( (unk_F43D9EC & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
    unk_F43D9EC = 1;
  }
  v3 = *((_DWORD *)a0 + 14);
  v16 = 0u;
  if ( v3 >= 1 )
  {
    v4 = 0;
    while ( 1 )
    {
      Item = *((void **)a0 + 9);
      if ( !Item )
        break;
      Item = (void *)System_Collections_Generic_List_VLBEntityManager_CombinedChunks___get_Item(
                       Item,
                       v4,
                       Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
      if ( !v15 )
        break;
      v16 = *(_OWORD *)(v15 + 24);
      Unity_Jobs_JobHandle__Complete((__int64)&v16, nullptr);
      if ( !v14 )
        break;
      if ( *(int *)(v14 + 16) >= 1 )
      {
        v9 = 0;
        do
        {
          v10 = *(_QWORD *)(v14 + 56);
          if ( !v10 )
            goto LABEL_15;
          if ( v9 >= *(unsigned int *)(v10 + 24) )
            goto LABEL_16;
          VLB_VLBEntityManager__UpdateEntityData(
            a0,
            *(_QWORD *)(*(_QWORD *)(v14 + 40) + 8 * v9),
            *(void **)(v10 + 8 * v9 + 32),
            0,
            v8);
        }
        while ( (__int64)++v9 < *(int *)(v14 + 16) );
      }
      if ( ++v4 >= *((_DWORD *)a0 + 14) )
        return;
    }
LABEL_15:
    Item = (void *)sub_63CF120(Item, a1);
LABEL_16:
    sub_63CF128(Item, a1, v6, v7);
    VLB_EntityIndexer__GetItem(v11, v12, v13);
  }
}

