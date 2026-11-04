// VLB.EntityIndexer$$DestroyEntity @ 0xe0cf5d4
void __fastcall VLB_EntityIndexer__DestroyEntity(void *a0, __int64 a1, void *a2)
{
  int v3; // w19
  void *v5; // x0
  __int64 Item_1; // x2
  void *v7; // x0
  __int64 v8; // x1
  int v9; // w2
  void *v10; // x3

  v3 = a1;
  if ( (unk_F43D9F6 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__set_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_Queue_int__Enqueue__);
    unk_F43D9F6 = 1;
  }
  v5 = *((void **)a0 + 3);
  if ( v5
    && (System_Collections_Generic_Queue_int___Enqueue(v5, v3, Method_System_Collections_Generic_Queue_int__Enqueue__),
        (v5 = *((void **)a0 + 2)) != nullptr)
    && (Item_1 = System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
                   v5,
                   v3,
                   Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1),
        (v5 = *((void **)a0 + 2)) != nullptr) )
  {
    System_Collections_Generic_List_EntityIndexer_EntityItem___set_Item_1(
      v5,
      v3,
      Item_1,
      (void *)(unsigned int)(a1 + 1));
  }
  else
  {
    v7 = (void *)sub_63CF120(v5, a1);
    VLB_EntityIndexer__UpdateIndex(v7, v8, v9, v10);
  }
}

