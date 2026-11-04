// VLB.VLBUpdateCachedSystem$$Execute @ 0xe0ca2ec
void __fastcall VLB_VLBUpdateCachedSystem__Execute(void *a0, void *a1, void *a2)
{
  _QWORD *v4; // x19
  __int64 v5; // x8
  int v6; // w20
  char v7; // w25
  _DWORD *Item; // x21
  int v9; // s0
  int v10; // s1
  int v11; // s2
  __int64 v12; // x8
  __int64 v13; // x8
  __int64 v14; // x8
  void *v15; // x21
  __int64 v16; // x8
  void *v17; // x22
  void *v18; // x4
  UnityEngine_Vector3_o forward; // 0:kr00_12.12

  v4 = a0;
  if ( (unk_F43D9CB & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    unk_F43D9CB = 1;
  }
  if ( a1
    && (a0 = UnityEngine_Component__get_transform(a1, nullptr)) != nullptr
    && (forward = UnityEngine_Transform__get_forward(a0, nullptr),
        a0 = (void *)UnityEngine_Camera__get_orthographic(a1, nullptr),
        (v5 = v4[2]) != 0) )
  {
    v6 = 0;
    v7 = (unsigned __int8)a0 & 1;
    while ( v6 < *(_DWORD *)(v5 + 56) )
    {
      a0 = *(void **)(v5 + 32);
      if ( a0 )
      {
        Item = System_Collections_Generic_List_object___get_Item(
                 a0,
                 v6,
                 Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
        a0 = (void *)Unity_Mathematics_float3__op_Implicit_3(forward, nullptr);
        if ( Item )
        {
          Item[13] = v9;
          Item[14] = v10;
          Item[15] = v11;
          v12 = v4[2];
          if ( v12 )
          {
            a0 = *(void **)(v12 + 32);
            if ( a0 )
            {
              a0 = System_Collections_Generic_List_object___get_Item(
                     a0,
                     v6,
                     Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
              if ( a0 )
              {
                v13 = v4[2];
                *((_BYTE *)a0 + 64) = v7;
                if ( v13 )
                {
                  a0 = *(void **)(v13 + 24);
                  if ( a0 )
                  {
                    a0 = System_Collections_Generic_List_object___get_Item(
                           a0,
                           v6,
                           Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
                    v14 = v4[2];
                    if ( v14 )
                    {
                      v15 = a0;
                      a0 = *(void **)(v14 + 32);
                      if ( a0 )
                      {
                        a0 = System_Collections_Generic_List_object___get_Item(
                               a0,
                               v6,
                               Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
                        v16 = v4[2];
                        if ( v16 )
                        {
                          v17 = a0;
                          a0 = *(void **)(v16 + 24);
                          if ( a0 )
                          {
                            a0 = System_Collections_Generic_List_object___get_Item(
                                   a0,
                                   v6,
                                   Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
                            if ( a0 )
                            {
                              VLB_VLBUpdateCachedSystem__Execute_1(a0, v15, v17, *((_DWORD *)a0 + 4), v18);
                              v5 = v4[2];
                              ++v6;
                              if ( v5 )
                                continue;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      goto LABEL_21;
    }
  }
  else
  {
LABEL_21:
    sub_63CF120(a0, a1);
  }
}

