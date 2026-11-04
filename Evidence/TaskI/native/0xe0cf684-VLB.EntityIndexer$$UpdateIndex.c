// VLB.EntityIndexer$$UpdateIndex @ 0xe0cf684
void __fastcall VLB_EntityIndexer__UpdateIndex(void *a0, __int64 a1, int a2, void *a3)
{
  void *Item_1; // x0
  void *v8; // x0
  void *v9; // x1

  if ( (unk_F43D9F8 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__set_Item___1);
    unk_F43D9F8 = 1;
  }
  Item_1 = *((void **)a0 + 2);
  if ( Item_1
    && (Item_1 = (void *)System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
                           Item_1,
                           a1,
                           Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1),
        *((_QWORD *)a0 + 2)) )
  {
    System_Collections_Generic_List_EntityIndexer_EntityItem___set_Item_1(
      *((void **)a0 + 2),
      a1,
      (unsigned int)Item_1 | ((unsigned __int64)(unsigned int)a2 << 32),
      (void *)HIDWORD(a1));
  }
  else
  {
    v8 = (void *)sub_63CF120(Item_1, a1);
    VLB_VLBEntityManager__Update(v8, v9);
  }
}

