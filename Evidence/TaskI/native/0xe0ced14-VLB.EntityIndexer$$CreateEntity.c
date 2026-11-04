// VLB.EntityIndexer$$CreateEntity @ 0xe0ced14
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall VLB_EntityIndexer__CreateEntity(void *a0, int a1, int a2, void *a3)
{
  __int64 v5; // x20
  __int64 v7; // x0
  unsigned int v8; // w22
  __int64 v9; // x9
  unsigned __int64 v10; // x19
  unsigned __int64 v11; // x19
  __int64 v12; // x8
  __int64 v13; // x8
  unsigned int v14; // w9
  __int64 v15; // x12
  __int64 v16; // x1
  __int64 v17; // x8
  __int64 result; // x0
  void *v19; // x0
  void *v20; // x1

  v5 = (unsigned int)a1;
  if ( (unk_F43D9F5 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__Add___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Count___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__set_Item___1);
    sub_63CEE78(&Method_System_Collections_Generic_Queue_int__Dequeue__);
    sub_63CEE78(&Method_System_Collections_Generic_Queue_int__get_Count__);
    unk_F43D9F5 = 1;
  }
  v7 = *((_QWORD *)a0 + 3);
  if ( v7 )
  {
    if ( *(_DWORD *)(v7 + 32) )
    {
      v7 = System_Collections_Generic_Queue_int___Dequeue(
             (void *)v7,
             Method_System_Collections_Generic_Queue_int__Dequeue__);
      if ( *((_QWORD *)a0 + 2) )
      {
        v8 = v7;
        System_Collections_Generic_List_EntityIndexer_EntityItem___get_Item_1(
          *((void **)a0 + 2),
          v7,
          Method_System_Collections_Generic_List_EntityIndexer_EntityItem__get_Item___1);
        v7 = *((_QWORD *)a0 + 2);
        if ( v7 )
        {
          v9 = (unsigned int)a2;
          v10 = (unsigned int)(a1 + 1);
          System_Collections_Generic_List_EntityIndexer_EntityItem___set_Item_1(
            (void *)v7,
            v8,
            v9 | (v5 << 32),
            (void *)v10);
          v11 = v10 << 32;
          v12 = v8;
          return v11 | v12;
        }
      }
    }
    else
    {
      v7 = *((_QWORD *)a0 + 2);
      if ( v7 )
      {
        v13 = *(_QWORD *)(v7 + 16);
        v14 = *(_DWORD *)(v7 + 24);
        ++*(_DWORD *)(v7 + 28);
        if ( v13 )
        {
          v15 = (unsigned int)a2;
          v11 = v14;
          v16 = v15 | (v5 << 32);
          if ( v14 >= *(_DWORD *)(v13 + 24) )
          {
            System_Collections_Generic_List_EntityIndexer_EntityItem___AddWithResize_1(
              (void *)v7,
              v16,
              (char *)&dword_0 + 1);
          }
          else
          {
            v17 = v13 + 12LL * (int)v14;
            *(_DWORD *)(v7 + 24) = v14 + 1;
            *(_QWORD *)(v17 + 32) = v16;
            *(_DWORD *)(v17 + 40) = 1;
          }
          v12 = 0x100000000LL;
          return v11 | v12;
        }
      }
    }
  }
  v19 = (void *)sub_63CF120(v7, *(_QWORD *)&a1);
  VLB_EntityIndexer___ctor(v19, v20);
  return result;
}

