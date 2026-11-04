// VLB.EntityIndexer$$IsValid @ 0xe0ce76c
bool __fastcall VLB_EntityIndexer__IsValid(void *a0, __int64 a1, void *a2)
{
  _DWORD *v5; // x0
  int v6; // w1
  void *v8; // x0
  void *v9; // x1
  void *v10; // x2

  if ( (unk_F43D9F4 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Count___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    unk_F43D9F4 = 1;
  }
  v5 = *((_DWORD **)a0 + 2);
  if ( v5 )
  {
    if ( v5[6] <= (int)a1 )
    {
      return 0;
    }
    else
    {
      System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
        v5,
        a1,
        Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
      return v6 == HIDWORD(a1);
    }
  }
  else
  {
    v8 = (void *)sub_63CF120(0, a1);
    return VLB_VLBEntityManager__CreateChunkIndex(v8, v9, v10);
  }
}

