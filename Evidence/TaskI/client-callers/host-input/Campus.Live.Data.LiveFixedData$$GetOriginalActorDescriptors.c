// Campus.Live.Data.LiveFixedData$$GetOriginalActorDescriptors @ 0x671e120
void *__fastcall Campus_Live_Data_LiveFixedData__GetOriginalActorDescriptors(void *a0, void *a1)
{
  _DWORD *v3; // x0
  int v4; // w1
  void *v5; // x20
  _QWORD *v6; // x19
  void *v7; // t1
  void *v8; // x0
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v14; // x0
  __int64 v15; // x1
  __int64 v16; // x30
  __int64 v17; // x19
  _DWORD *v18; // x0
  int v19; // w1
  __int64 v20; // x19
  __int64 v21; // x8
  __int64 v22; // x0
  __int64 v23; // x0
  void *v24; // x20
  _QWORD *v25; // x19
  void *v26; // t1
  void *v27; // x0
  int v28; // w2
  int v29; // w3
  int v30; // w4
  void *v31; // x5
  __int64 v32; // [xsp+0h] [xbp+0h]
  __int64 v33; // [xsp+10h] [xbp+10h]
  void *v34; // [xsp+18h] [xbp+18h]

  if ( (unk_F401208 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_Take_CampusActorDescriptor___);
    sub_63CEE78(&Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
    sub_63CEE78(&Method_System_Collections_Generic_List_CampusActorDescriptor__get_Count__);
    unk_F401208 = 1;
  }
  v3 = *((_DWORD **)a0 + 8);
  if ( v3 )
  {
    v4 = *((_DWORD *)a0 + 22);
    if ( v3[6] == v4 )
      return *((void **)a0 + 8);
    v7 = *((void **)a0 + 9);
    v6 = (char *)a0 + 72;
    v5 = v7;
    if ( !v7 )
    {
      v8 = System_Linq_Enumerable__Take_object_(v3, v4, Method_System_Linq_Enumerable_Take_CampusActorDescriptor___);
      v5 = System_Linq_Enumerable__ToList_object_(v8, Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
      *v6 = v5;
      sub_63CEE24(v6, (int)v5, v9, v10, v11, v12);
    }
    return v5;
  }
  else
  {
    v14 = sub_63CF120(0, a1);
    *(&v32 - 4) = v16;
    v33 = 255856640;
    v34 = a0;
    v17 = v14;
    if ( (unk_F401209 & 1) == 0 )
    {
      sub_63CEE78(&Method_System_Array_Empty_CampusActorDescriptor___);
      sub_63CEE78(&Method_System_Linq_Enumerable_Skip_CampusActorDescriptor___);
      sub_63CEE78(&Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
      sub_63CEE78(&Method_System_Collections_Generic_List_CampusActorDescriptor__get_Count__);
      unk_F401209 = 1;
    }
    v18 = *(_DWORD **)(v17 + 64);
    if ( v18 )
    {
      v19 = *(_DWORD *)(v17 + 88);
      if ( v18[6] == v19 )
      {
        v20 = Method_System_Array_Empty_CampusActorDescriptor___;
        v21 = *(_QWORD *)(Method_System_Array_Empty_CampusActorDescriptor___ + 56LL);
        if ( !v21 )
        {
          sub_6407F5C();
          v21 = *(_QWORD *)(v20 + 56);
        }
        v22 = *(_QWORD *)(v21 + 16);
        if ( (*(_WORD *)(v22 + 309) & 1) == 0 )
          sub_6407F00(v22);
        if ( !*(_DWORD *)(v22 + 228) )
          sub_63CEFF4(v22);
        v23 = *(_QWORD *)(*(_QWORD *)(v20 + 56) + 16LL);
        if ( (*(_WORD *)(v23 + 309) & 1) == 0 )
          sub_6407F00(v23);
        return **(void ***)(v23 + 184);
      }
      else
      {
        v26 = *(void **)(v17 + 80);
        v25 = (_QWORD *)(v17 + 80);
        v24 = v26;
        if ( !v26 )
        {
          v27 = System_Linq_Enumerable__Skip_object_(
                  v18,
                  v19,
                  Method_System_Linq_Enumerable_Skip_CampusActorDescriptor___);
          v24 = System_Linq_Enumerable__ToList_object_(
                  v27,
                  Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
          *v25 = v24;
          sub_63CEE24(v25, (int)v24, v28, v29, v30, v31);
        }
      }
      return v24;
    }
    else
    {
      return (void *)*(unsigned int *)(sub_63CF120(0, v15) + 16);
    }
  }
}

