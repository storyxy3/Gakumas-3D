// 0xbd02bac @ 0xbd02bac
void __fastcall VL_Core_VLActorController_object__object__object___PostBuild(void *a0, void *a1)
{
  void *v4; // x0
  __int64 v5; // x8
  __int64 *v6; // x20
  __int64 v7; // x1
  void *gameObject; // x0
  __int64 *v9; // x0
  void **v10; // x8
  __int64 v11; // x0
  __int64 v12; // x1
  __int64 v13; // x8
  int v14; // w2
  int v15; // w9
  void *v16; // x0
  long double v17; // q0
  void *v18; // x20
  int v19; // w1
  __int64 *v20; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v21; // [xsp+10h] [xbp+10h]
  void **v22; // [xsp+18h] [xbp+18h]
  __int64 v23; // [xsp+20h] [xbp+20h] BYREF
  __int64 v24; // [xsp+28h] [xbp+28h]
  void *v25; // [xsp+30h] [xbp+30h]
  _QWORD *v26; // [xsp+38h] [xbp+38h] BYREF

  v26 = a1;
  if ( (unk_F41D5FA & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F41D5FA = 1;
  }
  v4 = *((void **)a0 + 47);
  v23 = 0;
  v24 = 0;
  v25 = nullptr;
  if ( !v4 )
    goto LABEL_13;
  v5 = *((_QWORD *)a1 + 4);
  v6 = &v23;
  System_Collections_Generic_List_object___GetEnumerator(v4, *(void **)(*(_QWORD *)(v5 + 192) + 96LL));
  v20 = nullptr;
  v21 = &v23;
  v22 = (void **)&v26;
  while ( 1 )
  {
    if ( !System_Collections_Generic_List_Enumerator_object___MoveNext(
            (__int64)&v23,
            *(void **)(*(_QWORD *)(v26[4] + 192LL) + 128LL)) )
    {
      v6 = nullptr;
      v9 = &v23;
      v10 = (void **)&v26;
      goto LABEL_9;
    }
    if ( !v25 )
      break;
    gameObject = UnityEngine_Component__get_gameObject(v25, nullptr);
    VL_VLUtility__DestroyObject(gameObject, nullptr);
  }
  v11 = sub_63CF120(0, v7);
  while ( 1 )
  {
    do
    {
      sub_63CF120(v11, v12);
      do
      {
        v17 = sub_63CF118(v6);
        v18 = v16;
        if ( v19 != 1 )
        {
          sub_5FE8BC4(&v20, v17);
          sub_64BD8DC(v18);
        }
        v6 = *(__int64 **)__cxa_begin_catch(v16);
        v20 = v6;
        __cxa_end_catch();
        v9 = v21;
        v10 = v22;
LABEL_9:
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)v9,
          *(void **)(*(_QWORD *)(*((_QWORD *)*v10 + 4) + 192LL) + 136LL));
      }
      while ( v6 );
      v13 = *((_QWORD *)a0 + 47);
    }
    while ( !v13 );
    v14 = *(_DWORD *)(v13 + 24);
    v15 = *(_DWORD *)(v13 + 28) + 1;
    *(_DWORD *)(v13 + 24) = 0;
    *(_DWORD *)(v13 + 28) = v15;
    if ( v14 >= 1 )
      System_Array__Clear(*(void **)(v13 + 16), 0, v14, nullptr);
LABEL_13:
    v6 = *((__int64 **)a0 + 44);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Inequality(v6, nullptr, nullptr) )
      break;
    v11 = *((_QWORD *)a0 + 44);
    if ( v11 )
    {
      (*(void (__fastcall **)(__int64, __int64, void *, _QWORD))(*(_QWORD *)v11 + 376LL))(
        v11,
        1,
        a0,
        *(_QWORD *)(*(_QWORD *)v11 + 384LL));
      return;
    }
  }
}

