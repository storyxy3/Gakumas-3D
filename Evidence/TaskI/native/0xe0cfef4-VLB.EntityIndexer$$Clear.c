// VLB.EntityIndexer$$Clear @ 0xe0cfef4
void __fastcall VLB_EntityIndexer__Clear(void *a0, void *a1)
{
  void *v2; // x19
  __int64 v3; // x8
  int v4; // w9

  v2 = a0;
  if ( (unk_F43D9FA & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem__Clear___1);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_Queue_int__Clear__);
    unk_F43D9FA = 1;
  }
  v3 = *((_QWORD *)v2 + 2);
  if ( !v3
    || (a0 = *((void **)v2 + 3), v4 = *(_DWORD *)(v3 + 28) + 1, *(_DWORD *)(v3 + 24) = 0, *(_DWORD *)(v3 + 28) = v4, !a0) )
  {
    sub_63CF120(a0, a1);
    JUMPOUT(0xE0CFF64);
  }
  System_Collections_Generic_Queue_int___Clear(a0, Method_System_Collections_Generic_Queue_int__Clear__);
}

