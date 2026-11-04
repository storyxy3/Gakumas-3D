// 0xd1d4ae0 @ 0xd1d4ae0
void __fastcall ProFlareBatchForSRP__LateUpdate(void *a0, void *a1)
{
  _DWORD *Item; // x0
  int v4; // w20
  void *v5; // x21

  if ( (unk_F42C944 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__RemoveAt__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Item__);
    unk_F42C944 = 1;
  }
  Item = *((_DWORD **)a0 + 10);
  if ( Item )
  {
    v4 = 0;
    while ( v4 < Item[6] )
    {
      Item = System_Collections_Generic_List_object___get_Item(
               Item,
               v4,
               Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Item__);
      if ( !Item )
        goto LABEL_9;
      v5 = Item;
      --Item[55];
      if ( !ProFlareBatchForSRPData__IsValid(Item, a1) )
      {
        ProFlareBatchForSRPData__Dispose(v5, a1);
        Item = *((_DWORD **)a0 + 10);
        if ( !Item )
          goto LABEL_9;
        System_Collections_Generic_List_object___RemoveAt(
          Item,
          v4,
          Method_System_Collections_Generic_List_ProFlareBatchForSRPData__RemoveAt__);
        return;
      }
      Item = *((_DWORD **)a0 + 10);
      ++v4;
      if ( !Item )
        goto LABEL_9;
    }
  }
  else
  {
LABEL_9:
    sub_63CF120(Item, a1);
  }
}

