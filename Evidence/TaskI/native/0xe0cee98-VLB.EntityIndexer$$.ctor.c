// VLB.EntityIndexer$$.ctor @ 0xe0cee98
void __fastcall VLB_EntityIndexer___ctor(void *a0, void *a1)
{
  void *v3; // x20
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  void *v8; // x20
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5

  if ( (unk_F43D9FB & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_EntityIndexer_EntityItem___ctor___1);
    sub_63CEE78(&System_Collections_Generic_List_EntityIndexer_EntityItem__TypeInfo_1);
    sub_63CEE78(&Method_System_Collections_Generic_Queue_int___ctor__);
    sub_63CEE78(&System_Collections_Generic_Queue_int__TypeInfo);
    unk_F43D9FB = 1;
  }
  v3 = (void *)sub_63CF110(System_Collections_Generic_List_EntityIndexer_EntityItem__TypeInfo_1);
  System_Collections_Generic_List_EntityIndexer_EntityItem____ctor_1(
    v3,
    Method_System_Collections_Generic_List_EntityIndexer_EntityItem___ctor___1);
  *((_QWORD *)a0 + 2) = v3;
  sub_63CEE24((char *)a0 + 16, (int)v3, v4, v5, v6, v7);
  v8 = (void *)sub_63CF110(System_Collections_Generic_Queue_int__TypeInfo);
  System_Collections_Generic_Queue_int____ctor(v8, Method_System_Collections_Generic_Queue_int___ctor__);
  *((_QWORD *)a0 + 3) = v8;
  sub_63CEE24((char *)a0 + 24, (int)v8, v9, v10, v11, v12);
  System_Object___ctor(a0, nullptr);
}

