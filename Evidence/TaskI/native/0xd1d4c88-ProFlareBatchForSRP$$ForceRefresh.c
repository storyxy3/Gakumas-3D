// 0xd1d4c88 @ 0xd1d4c88
void __fastcall ProFlareBatchForSRP__ForceRefresh(void *a0, void *a1)
{
  char *v2; // x19
  __int64 v3; // x8
  int v4; // w2
  int v5; // w9
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5
  __int64 v10; // x21
  void *TypeFromHandle; // x21
  void *ObjectsOfType; // x0
  void *v13; // x2
  int v14; // w3
  int v15; // w8
  _DWORD *v16; // x21
  unsigned int v17; // w25
  char *v18; // x26
  __int64 v19; // x8
  void **v20; // x26
  __int64 v21; // t1
  void *v22; // x22
  void *v23; // x23
  void *v24; // x0
  void *v25; // x1

  v2 = (char *)a0;
  if ( (unk_F42C945 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlare__Clear__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&ProFlare___TypeInfo);
    sub_63CEE78(&ProFlare_var);
    a0 = (void *)sub_63CEE78(&Method_System_Collections_Generic_Queue_int__Clear__);
    unk_F42C945 = 1;
  }
  v3 = *((_QWORD *)v2 + 6);
  if ( !v3 )
    goto LABEL_25;
  v4 = *(_DWORD *)(v3 + 24);
  v5 = *(_DWORD *)(v3 + 28) + 1;
  *(_DWORD *)(v3 + 24) = 0;
  *(_DWORD *)(v3 + 28) = v5;
  if ( v4 >= 1 )
    System_Array__Clear(*(void **)(v3 + 16), 0, v4, nullptr);
  a0 = *((void **)v2 + 7);
  if ( !a0 )
    goto LABEL_25;
  System_Collections_Generic_Queue_int___Clear(a0, Method_System_Collections_Generic_Queue_int__Clear__);
  a0 = *((void **)v2 + 8);
  if ( !a0 )
    goto LABEL_25;
  System_Collections_Generic_Dictionary_int__int___Clear(
    a0,
    Method_System_Collections_Generic_Dictionary_int__int__Clear__);
  *((_QWORD *)v2 + 5) = 0;
  sub_63CEE24(v2 + 40, 0, v6, v7, v8, v9);
  v10 = ProFlare_var;
  if ( !*(_DWORD *)(unk_F43F550 + 228LL) )
    sub_63CEFF4(unk_F43F550);
  TypeFromHandle = System_Type__GetTypeFromHandle(v10, nullptr);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  ObjectsOfType = UnityEngine_Object__FindObjectsOfType(TypeFromHandle, nullptr);
  a0 = (void *)sub_63CEFF8(ObjectsOfType, ProFlare___TypeInfo);
  if ( !a0 )
  {
LABEL_25:
    v24 = (void *)sub_63CF120(a0, a1);
    ProFlareBatchForSRP___ctor(v24, v25);
    return;
  }
  v15 = *((_DWORD *)a0 + 6);
  v16 = a0;
  if ( v15 >= 1 )
  {
    v17 = 0;
    while ( v17 < v15 )
    {
      v18 = (char *)&v16[2 * v17];
      v21 = *((_QWORD *)v18 + 4);
      v20 = (void **)(v18 + 32);
      v19 = v21;
      if ( !v21 )
        goto LABEL_25;
      v22 = *(void **)(v19 + 32);
      v23 = *((void **)v2 + 5);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      a0 = (void *)UnityEngine_Object__op_Equality(v22, v23, nullptr);
      if ( ((unsigned __int8)a0 & 1) != 0 )
      {
        if ( v17 >= v16[6] )
          break;
        ProFlareBatchForSRP__AddFlare(v2, *v20, v13);
      }
      v15 = v16[6];
      if ( (int)++v17 >= v15 )
        return;
    }
    sub_63CF128(a0, a1, (_DWORD)v13, v14);
    goto LABEL_25;
  }
}

