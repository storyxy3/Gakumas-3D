// 0xd1cceb8 @ 0xd1cceb8
bool __fastcall ProFlareBatchForSRP__TryGetScheduledFlareData(
        void *a0,
        void *a1,
        void *a2,
        int a3,
        void *a4,
        void *a5,
        void *a6)
{
  void *v13; // x1
  void *Item; // x0
  int Count; // w0
  void *v16; // x4
  int v17; // w25
  void *v18; // x26
  void *v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  void *v24; // x25
  void *v25; // x3
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5
  void *v30; // x2
  void *v31; // x2
  int v32; // w2
  int v33; // w3
  int v34; // w4
  void *v35; // x5
  __int64 v36; // x8
  __int64 v37; // x9
  __int64 v38; // x10
  __int64 v39; // x8
  void *v40; // x2
  __int64 v41; // x8
  int v42; // w21
  int v43; // w23
  int v44; // w8
  _QWORD *v45; // x0
  void *v46; // x2
  _QWORD *v47; // x0
  void *v48; // x1
  __int64 v49; // x9
  int v50; // w21
  __int64 v52; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F42C941 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlare__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlare__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Item__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&ProFlareBatchForSRPData_TypeInfo);
    unk_F42C941 = 1;
  }
  *(_QWORD *)a5 = 0;
  sub_63CEE24(a5, 0, (int)a2, a3, (int)a4, a5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(a1, nullptr, nullptr) || !*((_QWORD *)a0 + 10) )
  {
    LOBYTE(Count) = 0;
    return Count;
  }
  Item = *((void **)a0 + 8);
  if ( Item )
  {
    Count = System_Collections_Generic_Dictionary_int__int___get_Count(
              Item,
              Method_System_Collections_Generic_Dictionary_int__int__get_Count__);
    if ( !Count )
      return Count;
    Item = *((void **)a0 + 10);
    if ( Item )
    {
      v17 = 0;
      while ( v17 < *((_DWORD *)Item + 6) )
      {
        Item = System_Collections_Generic_List_object___get_Item(
                 Item,
                 v17,
                 Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Item__);
        if ( !Item )
          goto LABEL_53;
        v18 = *((void **)Item + 5);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        if ( UnityEngine_Object__op_Equality(v18, a1, nullptr) )
        {
          Item = *((void **)a0 + 10);
          if ( !Item )
            goto LABEL_53;
          v19 = System_Collections_Generic_List_object___get_Item(
                  Item,
                  v17,
                  Method_System_Collections_Generic_List_ProFlareBatchForSRPData__get_Item__);
          *(_QWORD *)a5 = v19;
          sub_63CEE24(a5, (int)v19, v20, v21, v22, v23);
          break;
        }
        Item = *((void **)a0 + 10);
        ++v17;
        if ( !Item )
          goto LABEL_53;
      }
      Item = *(void **)a5;
      if ( *(_QWORD *)a5 )
        goto LABEL_59;
      v24 = (void *)sub_63CF110(ProFlareBatchForSRPData_TypeInfo);
      ProFlareBatchForSRPData___ctor(v24, a0, a1, v25);
      *(_QWORD *)a5 = v24;
      sub_63CEE24(a5, (int)v24, v26, v27, v28, v29);
      Item = *(void **)a5;
      if ( *(_QWORD *)a5 )
      {
        ProFlareBatchForSRPData__Initialize(Item, *((_DWORD *)a0 + 18), v30);
        Item = *(void **)a5;
        if ( *(_QWORD *)a5 )
        {
          ProFlareBatchForSRPData__UpdateUVData(Item, *((void **)a0 + 5), v31);
          Item = *((void **)a0 + 10);
          if ( Item )
          {
            v36 = *((_QWORD *)Item + 2);
            v13 = *(void **)a5;
            v37 = Method_System_Collections_Generic_List_ProFlareBatchForSRPData__Add__;
            ++*((_DWORD *)Item + 7);
            if ( v36 )
            {
              v38 = *((int *)Item + 6);
              if ( (unsigned int)v38 >= *(_DWORD *)(v36 + 24) )
              {
                System_Collections_Generic_List_object___AddWithResize(
                  Item,
                  v13,
                  *(void **)(*(_QWORD *)(*(_QWORD *)(v37 + 32) + 192LL) + 112LL));
              }
              else
              {
                v39 = v36 + 8 * v38;
                *((_DWORD *)Item + 6) = v38 + 1;
                *(_QWORD *)(v39 + 32) = v13;
                sub_63CEE24((void *)(v39 + 32), (int)v13, v32, v33, v34, v35);
              }
              Item = *(void **)a5;
              if ( *(_QWORD *)a5 )
              {
LABEL_59:
                ProFlareBatchForSRPData__SetShader(Item, a2, a3, a4, v16);
                if ( !*((_BYTE *)a0 + 88) )
                  goto LABEL_54;
                Item = (void *)UnityEngine_Jobs_TransformAccessArray__get_isCreated((__int64)a0 + 96, nullptr);
                if ( ((unsigned __int8)Item & 1) == 0 )
                {
                  v52 = 0;
                  UnityEngine_Jobs_TransformAccessArray___ctor_1((__int64)&v52, 1024, -1, nullptr);
                  *((_QWORD *)a0 + 12) = v52;
                }
                v41 = *((_QWORD *)a0 + 6);
                if ( v41 )
                {
                  v42 = 0;
                  while ( 1 )
                  {
                    v43 = *(_DWORD *)(v41 + 24);
                    Item = (void *)UnityEngine_Jobs_TransformAccessArray__get_length((__int64)a0 + 96, nullptr);
                    v44 = (int)Item;
                    if ( v42 >= v43 )
                      break;
                    Item = *((void **)a0 + 6);
                    if ( v42 >= v44 )
                    {
                      if ( !Item )
                        goto LABEL_53;
                      v47 = System_Collections_Generic_List_object___get_Item(
                              Item,
                              v42,
                              Method_System_Collections_Generic_List_ProFlare__get_Item__);
                      if ( v47 )
                        v48 = (void *)v47[7];
                      else
                        v48 = nullptr;
                      UnityEngine_Jobs_TransformAccessArray__Add((__int64)a0 + 96, v48, nullptr);
                    }
                    else
                    {
                      if ( !Item )
                        goto LABEL_53;
                      v45 = System_Collections_Generic_List_object___get_Item(
                              Item,
                              v42,
                              Method_System_Collections_Generic_List_ProFlare__get_Item__);
                      if ( v45 )
                        v46 = (void *)v45[7];
                      else
                        v46 = nullptr;
                      UnityEngine_Jobs_TransformAccessArray__set_Item((__int64)a0 + 96, v42, v46, nullptr);
                    }
                    v41 = *((_QWORD *)a0 + 6);
                    ++v42;
                    if ( !v41 )
                      goto LABEL_53;
                  }
                  v49 = *((_QWORD *)a0 + 6);
                  if ( v49 )
                  {
                    v50 = (_DWORD)Item - 1;
                    do
                    {
                      if ( v50 < *(_DWORD *)(v49 + 24) )
                        goto LABEL_54;
                      UnityEngine_Jobs_TransformAccessArray__RemoveAtSwapBack((__int64)a0 + 96, v50, nullptr);
                      v49 = *((_QWORD *)a0 + 6);
                      --v50;
                    }
                    while ( v49 );
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  do
  {
LABEL_53:
    sub_63CF120(Item, v13);
LABEL_54:
    Item = *(void **)a5;
  }
  while ( !*(_QWORD *)a5 );
  ProFlareBatchForSRPData__ScheduleFlares(Item, 0, v40);
  *((_BYTE *)a0 + 88) = 0;
  LOBYTE(Count) = 1;
  return Count;
}

