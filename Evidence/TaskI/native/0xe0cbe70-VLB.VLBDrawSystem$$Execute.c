// VLB.VLBDrawSystem$$Execute @ 0xe0cbe70
void __fastcall VLB_VLBDrawSystem__Execute(void *a0, void *a1, void *a2, void *a3)
{
  _QWORD *v5; // x20
  __int64 v6; // x8
  int v7; // w21
  void *v8; // x22
  __int64 v9; // x8
  __int64 v10; // x8
  void *v11; // x23
  __int64 v12; // x8
  void *v13; // x24
  void *v14; // x6
  void *v15; // x7

  v5 = a0;
  if ( (unk_F43D9DE & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    unk_F43D9DE = 1;
  }
  if ( *((_BYTE *)v5 + 16) )
  {
    v6 = v5[3];
    if ( v6 )
    {
      v7 = 0;
      while ( v7 < *(_DWORD *)(v6 + 56) )
      {
        a0 = *(void **)(v6 + 24);
        if ( !a0 )
          goto LABEL_19;
        a0 = System_Collections_Generic_List_object___get_Item(
               a0,
               v7,
               Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
        if ( !a0 )
          goto LABEL_19;
        v8 = a0;
        if ( (*((_BYTE *)a0 + 73) & 4) == 0 )
        {
          v9 = v5[3];
          if ( !v9 )
            goto LABEL_19;
          a0 = *(void **)(v9 + 32);
          if ( !a0 )
            goto LABEL_19;
          a0 = System_Collections_Generic_List_object___get_Item(
                 a0,
                 v7,
                 Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
          v10 = v5[3];
          if ( !v10 )
            goto LABEL_19;
          v11 = a0;
          a0 = *(void **)(v10 + 48);
          if ( !a0 )
            goto LABEL_19;
          a0 = System_Collections_Generic_List_object___get_Item(
                 a0,
                 v7,
                 Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
          v12 = v5[3];
          if ( !v12 )
            goto LABEL_19;
          v13 = a0;
          a0 = *(void **)(v12 + 24);
          if ( !a0 )
            goto LABEL_19;
          a0 = System_Collections_Generic_List_object___get_Item(
                 a0,
                 v7,
                 Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
          if ( !a0 )
            goto LABEL_19;
          VLB_VLBDrawSystem__Execute_1(v5, a1, v8, v11, v13, *((_DWORD *)a0 + 4), v14, v15);
        }
        v6 = v5[3];
        ++v7;
        if ( !v6 )
          goto LABEL_19;
      }
    }
    else
    {
LABEL_19:
      sub_63CF120(a0, a1);
    }
  }
}

