// 0xbd030d0 @ 0xbd030d0
bool __fastcall VL_Core_VLActorController_object__object__object___IsRendererActive(void *a0, void *a1)
{
  void *v3; // x0
  char v4; // w20
  _BOOL8 v5; // x0
  __int64 v6; // x1
  void *v8; // x0
  void *v9; // x19
  int v10; // w1
  __int64 v11; // x19
  void *v12; // x0
  __int64 v13; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v14; // [xsp+10h] [xbp+10h]
  __int64 v15; // [xsp+18h] [xbp+18h] BYREF
  __int64 v16; // [xsp+20h] [xbp+20h]
  __int64 v17; // [xsp+28h] [xbp+28h]

  if ( (unk_F41D5FC & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLActorModelParts__GetEnumerator__);
    unk_F41D5FC = 1;
  }
  v3 = *((void **)a0 + 8);
  v15 = 0;
  v16 = 0;
  v17 = 0;
  if ( v3 )
  {
    System_Collections_Generic_List_object___GetEnumerator(
      v3,
      Method_System_Collections_Generic_List_VLActorModelParts__GetEnumerator__);
    v4 = 0;
    v13 = 0;
    v14 = &v15;
    while ( 1 )
    {
      v5 = System_Collections_Generic_List_Enumerator_object___MoveNext(
             (__int64)&v15,
             Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__MoveNext__);
      if ( !v5 )
      {
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v15,
          Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__Dispose__);
        return v4 & 1;
      }
      if ( !v17 )
        break;
      v4 |= *(_BYTE *)(v17 + 80) != 0;
    }
    v8 = (void *)sub_63CF120(v5, v6);
    v9 = v8;
    if ( v10 != 1 )
      goto LABEL_14;
    v11 = *(_QWORD *)__cxa_begin_catch(v8);
    v13 = v11;
    __cxa_end_catch();
    System_Collections_Generic_List_Enumerator_object___Dispose(
      (__int64)v14,
      Method_System_Collections_Generic_List_Enumerator_VLActorModelParts__Dispose__);
    if ( v11 )
    {
      sub_63CF118(v11);
      v9 = v12;
LABEL_14:
      sub_5FE8BF8(&v13);
      sub_64BD8DC(v9);
    }
  }
  else
  {
    v4 = 0;
  }
  return v4 & 1;
}

