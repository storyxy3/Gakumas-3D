// VLB.EntityIndexer$$GetItem @ 0xe0cf464
__int64 __fastcall VLB_EntityIndexer__GetItem(void *a0, __int64 a1, void *a2)
{
  int v3; // w19
  void *v5; // x0
  __int64 result; // x0
  void *v7; // x0

  v3 = a1;
  if ( (unk_F43D9F7 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    unk_F43D9F7 = 1;
  }
  v5 = *((void **)a0 + 2);
  if ( v5 )
    return System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
             v5,
             v3,
             Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
  v7 = (void *)sub_63CF120(0, a1);
  VLB_Noise3D__LoadIfNeeded(v7);
  return result;
}

