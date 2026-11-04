// VLB.EntityIndexer$$RemapChunkIndices @ 0xe0cfde0
void __fastcall VLB_EntityIndexer__RemapChunkIndices(void *a0, void *a1, void *a2)
{
  __int64 Item_1; // x0
  int v6; // w21
  unsigned int v7; // w22
  __int64 v8; // x8

  if ( (unk_F43D9F9 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Count___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_int__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__set_Item___1);
    unk_F43D9F9 = 1;
  }
  Item_1 = *((_QWORD *)a0 + 2);
  if ( Item_1 )
  {
    v6 = 0;
    while ( v6 < *(_DWORD *)(Item_1 + 24) )
    {
      Item_1 = System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
                 (void *)Item_1,
                 v6,
                 Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
      if ( a1 )
      {
        Item_1 = System_Collections_Generic_List_int___get_Item(
                   a1,
                   Item_1,
                   Method_System_Collections_Generic_List_int__get_Item__);
        if ( *((_QWORD *)a0 + 2) )
        {
          v7 = Item_1;
          v8 = System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
                 *((void **)a0 + 2),
                 v6,
                 Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
          Item_1 = *((_QWORD *)a0 + 2);
          if ( Item_1 )
          {
            System_Collections_Generic_List_EntityIndexer_EntityItem___set_Item_1(
              (void *)Item_1,
              v6,
              v8 & 0xFFFFFFFF00000000LL | v7,
              (void *)(unsigned int)a1);
            Item_1 = *((_QWORD *)a0 + 2);
            ++v6;
            if ( Item_1 )
              continue;
          }
        }
      }
      goto LABEL_10;
    }
  }
  else
  {
LABEL_10:
    sub_63CF120(Item_1, a1);
  }
}

