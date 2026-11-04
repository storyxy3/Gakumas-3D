// VLB.VLBEntityManager$$Update @ 0xe0cf720
void __fastcall VLB_VLBEntityManager__Update(void *a0, void *a1)
{
  int v3; // w8
  int v4; // w20
  __int64 Item; // x0
  void *v6; // x21
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x20
  __int64 v24; // x8
  void *v25; // x21
  void *v26; // x22
  __int64 v27; // x0
  int v28; // w2
  int v29; // w3
  int v30; // w4
  void *v31; // x5
  int v32; // w20
  unsigned __int64 v33; // x2
  int v34; // w20
  int v35; // w21
  __int128 v36; // kr00_16
  __int128 v37; // kr10_16
  int v38; // w23
  void *v39; // x22
  void *v40; // x22
  int v41; // w8
  void *v42; // x0
  void *v43; // x1
  void *v44; // x2
  __int128 v45; // [xsp+0h] [xbp+0h] BYREF
  __int128 v46; // [xsp+10h] [xbp+10h] BYREF
  __int128 v47; // [xsp+20h] [xbp+20h] BYREF
  __int64 v48; // [xsp+30h] [xbp+30h]
  __int128 v49; // [xsp+40h] [xbp+40h] BYREF
  __int128 v50; // [xsp+50h] [xbp+50h]
  __int64 v51; // [xsp+60h] [xbp+60h]

  if ( (unk_F43D9EF & 1) == 0 )
  {
    sub_63CEE78(&System_Comparison_VLBEntityManager_CombinedChunks__TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__ContainsKey__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__RemoveRange__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__RemoveRange__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__RemoveRange__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__RemoveRange__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__RemoveRange__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__Sort__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__set_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__set_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__set_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_int__set_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__set_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__set_Item__);
    sub_63CEE78(&Method_VLB_VLBEntityManager___c__Update_b__19_0__);
    sub_63CEE78(&VLB_VLBEntityManager___c_TypeInfo);
    unk_F43D9EF = 1;
  }
  v48 = 0;
  v3 = *((_DWORD *)a0 + 14);
  v47 = 0u;
  v46 = 0u;
  v45 = 0u;
  if ( v3 >= 1 )
  {
    v4 = 0;
    do
    {
      Item = *((_QWORD *)a0 + 3);
      v6 = *((void **)a0 + 9);
      v48 = 0;
      v46 = 0u;
      v47 = 0u;
      if ( !Item )
        goto LABEL_63;
      *(_QWORD *)&v46 = System_Collections_Generic_List_object___get_Item(
                          (void *)Item,
                          v4,
                          Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
      sub_63CEE24(&v46, v46, v7, v8, v9, v10);
      Item = *((_QWORD *)a0 + 4);
      if ( !Item )
        goto LABEL_63;
      *((_QWORD *)&v46 + 1) = System_Collections_Generic_List_object___get_Item(
                                (void *)Item,
                                v4,
                                Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
      sub_63CEE24((char *)&v46 + 8, SDWORD2(v46), v11, v12, v13, v14);
      Item = *((_QWORD *)a0 + 5);
      if ( !Item )
        goto LABEL_63;
      *(_QWORD *)&v47 = System_Collections_Generic_List_object___get_Item(
                          (void *)Item,
                          v4,
                          Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
      sub_63CEE24(&v47, v47, v15, v16, v17, v18);
      Item = *((_QWORD *)a0 + 6);
      if ( !Item )
        goto LABEL_63;
      *((_QWORD *)&v47 + 1) = System_Collections_Generic_List_object___get_Item(
                                (void *)Item,
                                v4,
                                Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
      sub_63CEE24((char *)&v47 + 8, SDWORD2(v47), v19, v20, v21, v22);
      Item = *((_QWORD *)a0 + 3);
      LODWORD(v48) = v4;
      if ( !Item )
        goto LABEL_63;
      Item = (__int64)System_Collections_Generic_List_object___get_Item(
                        (void *)Item,
                        v4,
                        Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
      if ( !Item )
        goto LABEL_63;
      BYTE4(v48) = *(_DWORD *)(Item + 16) != 0;
      if ( !v6 )
        goto LABEL_63;
      v49 = v46;
      v50 = v47;
      v51 = v48;
      System_Collections_Generic_List_VLBEntityManager_CombinedChunks___set_Item(
        v6,
        v4++,
        (__int64)&v49,
        Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__set_Item__);
    }
    while ( v4 < *((_DWORD *)a0 + 14) );
  }
  v23 = *((void **)a0 + 9);
  Item = VLB_VLBEntityManager___c_TypeInfo;
  if ( !*(_DWORD *)(VLB_VLBEntityManager___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VLB_VLBEntityManager___c_TypeInfo);
    Item = VLB_VLBEntityManager___c_TypeInfo;
  }
  v24 = *(_QWORD *)(Item + 184);
  v25 = *(void **)(v24 + 8);
  if ( !v25 )
  {
    if ( !*(_DWORD *)(Item + 228) )
    {
      sub_63CEFF4(Item);
      v24 = *(_QWORD *)(VLB_VLBEntityManager___c_TypeInfo + 184LL);
    }
    v26 = *(void **)v24;
    v25 = (void *)sub_63CF110(System_Comparison_VLBEntityManager_CombinedChunks__TypeInfo);
    System_Comparison_VLBEntityManager_CombinedChunks____ctor(
      v25,
      v26,
      Method_VLB_VLBEntityManager___c__Update_b__19_0__,
      nullptr);
    v27 = *(_QWORD *)(VLB_VLBEntityManager___c_TypeInfo + 184LL);
    *(_QWORD *)(v27 + 8) = v25;
    sub_63CEE24((void *)(v27 + 8), (int)v25, v28, v29, v30, v31);
  }
  if ( !v23 )
  {
LABEL_63:
    v42 = (void *)sub_63CF120(Item, a1);
    VLB_EntityIndexer__RemapChunkIndices(v42, v43, v44);
    return;
  }
  System_Collections_Generic_List_VLBEntityManager_CombinedChunks___Sort_3(
    v23,
    v25,
    Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__Sort__);
  if ( *((int *)a0 + 14) >= 1 )
  {
    v32 = 0;
    while ( 1 )
    {
      Item = *((_QWORD *)a0 + 9);
      if ( !Item )
        goto LABEL_63;
      System_Collections_Generic_List_VLBEntityManager_CombinedChunks___get_Item(
        (void *)Item,
        v32,
        Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
      if ( v32 != (_DWORD)v51 )
        goto LABEL_28;
      Item = *((_QWORD *)a0 + 9);
      if ( !Item )
        goto LABEL_63;
      System_Collections_Generic_List_VLBEntityManager_CombinedChunks___get_Item(
        (void *)Item,
        v32,
        Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
      if ( (v51 & 0x100000000LL) == 0 )
      {
LABEL_28:
        Item = *((_QWORD *)a0 + 2);
        if ( !Item )
          goto LABEL_63;
        System_Collections_Generic_Dictionary_int__int___Clear(
          (void *)Item,
          Method_System_Collections_Generic_Dictionary_int__int__Clear__);
        if ( *((int *)a0 + 14) >= 1 )
        {
          v34 = 0;
          v35 = 0;
          while ( 1 )
          {
            Item = *((_QWORD *)a0 + 9);
            if ( !Item )
              goto LABEL_63;
            Item = System_Collections_Generic_List_VLBEntityManager_CombinedChunks___get_Item(
                     (void *)Item,
                     v35,
                     Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__get_Item__);
            v36 = v49;
            v37 = v50;
            if ( (v51 & 0x100000000LL) != 0 )
            {
              Item = *((_QWORD *)a0 + 3);
              if ( !Item )
                goto LABEL_63;
              v38 = v51;
              System_Collections_Generic_List_object___set_Item(
                (void *)Item,
                v35,
                (void *)v49,
                Method_System_Collections_Generic_List_VLBEntityChunk__set_Item__);
              Item = *((_QWORD *)a0 + 4);
              if ( !Item )
                goto LABEL_63;
              System_Collections_Generic_List_object___set_Item(
                (void *)Item,
                v35,
                *((void **)&v36 + 1),
                Method_System_Collections_Generic_List_VLBCachedChunk__set_Item__);
              Item = *((_QWORD *)a0 + 5);
              if ( !Item )
                goto LABEL_63;
              System_Collections_Generic_List_object___set_Item(
                (void *)Item,
                v35,
                (void *)v37,
                Method_System_Collections_Generic_List_VLBCulledChunk__set_Item__);
              Item = *((_QWORD *)a0 + 6);
              if ( !Item )
                goto LABEL_63;
              System_Collections_Generic_List_object___set_Item(
                (void *)Item,
                v35,
                *((void **)&v37 + 1),
                Method_System_Collections_Generic_List_VLBDrawCallChunk__set_Item__);
              Item = *((_QWORD *)a0 + 3);
              if ( !Item )
                goto LABEL_63;
              v39 = *((void **)a0 + 2);
              Item = (__int64)System_Collections_Generic_List_object___get_Item(
                                (void *)Item,
                                v35,
                                Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
              if ( !Item || !v39 )
                goto LABEL_63;
              if ( !System_Collections_Generic_Dictionary_int__int___ContainsKey(
                      v39,
                      *(_DWORD *)(Item + 72),
                      Method_System_Collections_Generic_Dictionary_int__int__ContainsKey__) )
              {
                Item = *((_QWORD *)a0 + 3);
                if ( !Item )
                  goto LABEL_63;
                v40 = *((void **)a0 + 2);
                Item = (__int64)System_Collections_Generic_List_object___get_Item(
                                  (void *)Item,
                                  v35,
                                  Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
                if ( !Item || !v40 )
                  goto LABEL_63;
                System_Collections_Generic_Dictionary_int__int___Add(
                  v40,
                  *(_DWORD *)(Item + 72),
                  v35,
                  Method_System_Collections_Generic_Dictionary_int__int__Add__);
              }
              Item = *((_QWORD *)a0 + 10);
              if ( !Item )
                goto LABEL_63;
              System_Collections_Generic_List_int___set_Item(
                (void *)Item,
                v38,
                v35,
                Method_System_Collections_Generic_List_int__set_Item__);
              ++v34;
            }
            else
            {
              if ( !(_QWORD)v49 )
                goto LABEL_63;
              v45 = *(_OWORD *)(v49 + 24);
              Unity_Jobs_JobHandle__Complete((__int64)&v45, nullptr);
              if ( !*((_QWORD *)&v36 + 1) )
                goto LABEL_63;
              v45 = *(_OWORD *)(*((_QWORD *)&v36 + 1) + 24LL);
              Unity_Jobs_JobHandle__Complete((__int64)&v45, nullptr);
              if ( !(_QWORD)v37 )
                goto LABEL_63;
              v45 = *(_OWORD *)(v37 + 24);
              Unity_Jobs_JobHandle__Complete((__int64)&v45, nullptr);
              if ( !*((_QWORD *)&v37 + 1) )
                goto LABEL_63;
              v45 = *(_OWORD *)(*((_QWORD *)&v37 + 1) + 24LL);
              Unity_Jobs_JobHandle__Complete((__int64)&v45, nullptr);
              (*(void (__fastcall **)(_QWORD, _QWORD))(*(_QWORD *)v36 + 440LL))(
                v36,
                *(_QWORD *)(*(_QWORD *)v36 + 448LL));
              (*(void (__fastcall **)(_QWORD, _QWORD))(**((_QWORD **)&v36 + 1) + 440LL))(
                *((_QWORD *)&v36 + 1),
                *(_QWORD *)(**((_QWORD **)&v36 + 1) + 448LL));
              (*(void (__fastcall **)(_QWORD, _QWORD))(*(_QWORD *)v37 + 440LL))(
                v37,
                *(_QWORD *)(*(_QWORD *)v37 + 448LL));
              (*(void (__fastcall **)(_QWORD, _QWORD))(**((_QWORD **)&v37 + 1) + 440LL))(
                *((_QWORD *)&v37 + 1),
                *(_QWORD *)(**((_QWORD **)&v37 + 1) + 448LL));
            }
            v41 = *((_DWORD *)a0 + 14);
            if ( ++v35 >= v41 )
            {
              v33 = (unsigned int)(v41 - v34);
              if ( v41 <= v34 )
                break;
              Item = *((_QWORD *)a0 + 3);
              if ( Item )
              {
                System_Collections_Generic_List_object___RemoveRange(
                  (void *)Item,
                  v34,
                  v33,
                  Method_System_Collections_Generic_List_VLBEntityChunk__RemoveRange__);
                Item = *((_QWORD *)a0 + 4);
                if ( Item )
                {
                  System_Collections_Generic_List_object___RemoveRange(
                    (void *)Item,
                    v34,
                    *((_DWORD *)a0 + 14) - v34,
                    Method_System_Collections_Generic_List_VLBCachedChunk__RemoveRange__);
                  Item = *((_QWORD *)a0 + 5);
                  if ( Item )
                  {
                    System_Collections_Generic_List_object___RemoveRange(
                      (void *)Item,
                      v34,
                      *((_DWORD *)a0 + 14) - v34,
                      Method_System_Collections_Generic_List_VLBCulledChunk__RemoveRange__);
                    Item = *((_QWORD *)a0 + 6);
                    if ( Item )
                    {
                      System_Collections_Generic_List_object___RemoveRange(
                        (void *)Item,
                        v34,
                        *((_DWORD *)a0 + 14) - v34,
                        Method_System_Collections_Generic_List_VLBDrawCallChunk__RemoveRange__);
                      Item = *((_QWORD *)a0 + 9);
                      if ( Item )
                      {
                        System_Collections_Generic_List_VLBEntityManager_CombinedChunks___RemoveRange(
                          (void *)Item,
                          v34,
                          *((_DWORD *)a0 + 14) - v34,
                          Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__RemoveRange__);
                        *((_DWORD *)a0 + 14) = v34;
                        break;
                      }
                    }
                  }
                }
              }
              goto LABEL_63;
            }
          }
        }
        Item = *((_QWORD *)a0 + 8);
        if ( !Item )
          goto LABEL_63;
        VLB_EntityIndexer__RemapChunkIndices((void *)Item, *((void **)a0 + 10), (void *)v33);
        return;
      }
      if ( ++v32 >= *((_DWORD *)a0 + 14) )
        return;
    }
  }
}

