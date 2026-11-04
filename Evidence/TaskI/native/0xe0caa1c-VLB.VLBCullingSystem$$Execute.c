// VLB.VLBCullingSystem$$Execute @ 0xe0caa1c
void __fastcall VLB_VLBCullingSystem__Execute(void *a0, __int64 a1, UnityEngine_Matrix4x4_o *a2, void *a3)
{
  int v4; // s0
  int v5; // s1
  int v6; // s2
  int v7; // s8
  int v8; // s9
  int v9; // s10
  _QWORD *v11; // x20
  __int64 v12; // x8
  int v13; // w21
  __int64 v14; // x8
  __int128 v15; // q1
  UnityEngine_Matrix4x4_o *v16; // x1
  __int64 v17; // x8
  __int128 v18; // q2
  __int64 v19; // x8
  __int64 v20; // x8
  void *v21; // x22
  __int64 v22; // x8
  void *v23; // x23
  int v24; // w3
  void *v25; // x4
  __int128 v26; // [xsp+0h] [xbp+0h] BYREF
  __int128 v27; // [xsp+10h] [xbp+10h]
  __int128 v28; // [xsp+20h] [xbp+20h]
  __int128 v29; // [xsp+30h] [xbp+30h]

  v7 = v6;
  v8 = v5;
  v9 = v4;
  v11 = a0;
  if ( (unk_F43D9D2 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    unk_F43D9D2 = 1;
  }
  v12 = v11[2];
  if ( v12 )
  {
    v13 = 0;
    while ( v13 < *(_DWORD *)(v12 + 56) )
    {
      a0 = *(void **)(v12 + 40);
      if ( a0 )
      {
        a0 = System_Collections_Generic_List_object___get_Item(
               a0,
               v13,
               Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
        if ( a0 )
        {
          *((_DWORD *)a0 + 10) = v9;
          *((_DWORD *)a0 + 11) = v8;
          *((_DWORD *)a0 + 12) = v7;
          v14 = v11[2];
          if ( v14 )
          {
            a0 = *(void **)(v14 + 40);
            if ( a0 )
            {
              a0 = System_Collections_Generic_List_object___get_Item(
                     a0,
                     v13,
                     Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
              if ( a0 )
              {
                v15 = *(_OWORD *)(a1 + 16);
                v17 = *((_QWORD *)a0 + 8);
                v16 = *((UnityEngine_Matrix4x4_o **)a0 + 9);
                v26 = *(_OWORD *)a1;
                v27 = v15;
                v18 = *(_OWORD *)(a1 + 48);
                v28 = *(_OWORD *)(a1 + 32);
                v29 = v18;
                VLB_Utils__CalcCullingPlane(v17, v16, &v26);
                v19 = v11[2];
                if ( v19 )
                {
                  a0 = *(void **)(v19 + 32);
                  if ( a0 )
                  {
                    a0 = System_Collections_Generic_List_object___get_Item(
                           a0,
                           v13,
                           Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
                    v20 = v11[2];
                    if ( v20 )
                    {
                      v21 = a0;
                      a0 = *(void **)(v20 + 40);
                      if ( a0 )
                      {
                        a0 = System_Collections_Generic_List_object___get_Item(
                               a0,
                               v13,
                               Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
                        v22 = v11[2];
                        if ( v22 )
                        {
                          v23 = a0;
                          a0 = *(void **)(v22 + 40);
                          if ( a0 )
                          {
                            a0 = System_Collections_Generic_List_object___get_Item(
                                   a0,
                                   v13,
                                   Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
                            if ( a0 )
                            {
                              VLB_VLBCullingSystem__Execute_1(a0, v21, v23, v24, v25);
                              v12 = v11[2];
                              ++v13;
                              if ( v12 )
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
      goto LABEL_19;
    }
  }
  else
  {
LABEL_19:
    sub_63CF120(a0, a1);
  }
}

