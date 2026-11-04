// Campus.Live.Data.LiveFixedData$$GetAdditionalActorDescriptors @ 0x671e1d4
void *__fastcall Campus_Live_Data_LiveFixedData__GetAdditionalActorDescriptors(void *a0, void *a1)
{
  _DWORD *v3; // x0
  int v4; // w1
  __int64 v5; // x19
  __int64 v6; // x8
  __int64 v7; // x0
  __int64 v8; // x0
  void *v9; // x20
  _QWORD *v10; // x19
  void *v11; // t1
  void *v12; // x0
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5

  if ( (unk_F401209 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Array_Empty_CampusActorDescriptor___);
    sub_63CEE78(&Method_System_Linq_Enumerable_Skip_CampusActorDescriptor___);
    sub_63CEE78(&Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
    sub_63CEE78(&Method_System_Collections_Generic_List_CampusActorDescriptor__get_Count__);
    unk_F401209 = 1;
  }
  v3 = *((_DWORD **)a0 + 8);
  if ( !v3 )
  {
    sub_63CF120(0, a1);
    JUMPOUT(0x671E2F0);
  }
  v4 = *((_DWORD *)a0 + 22);
  if ( v3[6] == v4 )
  {
    v5 = Method_System_Array_Empty_CampusActorDescriptor___;
    v6 = *(_QWORD *)(Method_System_Array_Empty_CampusActorDescriptor___ + 56LL);
    if ( !v6 )
    {
      sub_6407F5C();
      v6 = *(_QWORD *)(v5 + 56);
    }
    v7 = *(_QWORD *)(v6 + 16);
    if ( (*(_WORD *)(v7 + 309) & 1) == 0 )
      sub_6407F00(v7);
    if ( !*(_DWORD *)(v7 + 228) )
      sub_63CEFF4(v7);
    v8 = *(_QWORD *)(*(_QWORD *)(v5 + 56) + 16LL);
    if ( (*(_WORD *)(v8 + 309) & 1) == 0 )
      sub_6407F00(v8);
    return **(void ***)(v8 + 184);
  }
  else
  {
    v11 = *((void **)a0 + 10);
    v10 = (char *)a0 + 80;
    v9 = v11;
    if ( !v11 )
    {
      v12 = System_Linq_Enumerable__Skip_object_(v3, v4, Method_System_Linq_Enumerable_Skip_CampusActorDescriptor___);
      v9 = System_Linq_Enumerable__ToList_object_(v12, Method_System_Linq_Enumerable_ToList_CampusActorDescriptor___);
      *v10 = v9;
      sub_63CEE24(v10, (int)v9, v13, v14, v15, v16);
    }
  }
  return v9;
}

