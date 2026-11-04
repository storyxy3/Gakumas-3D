// VLB.VLBDrawCallSystem$$Execute @ 0xe0cb228
void __fastcall VLB_VLBDrawCallSystem__Execute(void *a0, void *a1)
{
  _QWORD *v2; // x19
  __int64 v3; // x8
  int v4; // w20
  __int64 v5; // x8
  void *v6; // x21
  __int64 v7; // x8
  void *v8; // x22
  __int64 v9; // x8
  void *v10; // x23
  void *v11; // x5
  __int64 v12; // x8

  v2 = a0;
  if ( (unk_F43D9DB & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    unk_F43D9DB = 1;
  }
  v3 = v2[2];
  if ( v3 )
  {
    v4 = 0;
    do
    {
      if ( v4 >= *(_DWORD *)(v3 + 56) )
        goto LABEL_16;
      a0 = *(void **)(v3 + 32);
      if ( !a0 )
        break;
      a0 = System_Collections_Generic_List_object___get_Item(
             a0,
             v4,
             Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
      v5 = v2[2];
      if ( !v5 )
        break;
      v6 = a0;
      a0 = *(void **)(v5 + 40);
      if ( !a0 )
        break;
      a0 = System_Collections_Generic_List_object___get_Item(
             a0,
             v4,
             Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
      v7 = v2[2];
      if ( !v7 )
        break;
      v8 = a0;
      a0 = *(void **)(v7 + 48);
      if ( !a0 )
        break;
      a0 = System_Collections_Generic_List_object___get_Item(
             a0,
             v4,
             Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
      v9 = v2[2];
      if ( !v9 )
        break;
      v10 = a0;
      a0 = *(void **)(v9 + 32);
      if ( !a0 )
        break;
      a0 = System_Collections_Generic_List_object___get_Item(
             a0,
             v4,
             Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
      if ( !a0 )
        break;
      VLB_VLBDrawCallSystem__Execute_1(a0, v6, v8, v10, *((_DWORD *)a0 + 4), v11);
      v3 = v2[2];
      ++v4;
    }
    while ( v3 );
  }
  do
  {
    a0 = (void *)sub_63CF120(a0, a1);
LABEL_16:
    v12 = v2[3];
  }
  while ( !v12 );
  *(_BYTE *)(v12 + 16) = 1;
}

