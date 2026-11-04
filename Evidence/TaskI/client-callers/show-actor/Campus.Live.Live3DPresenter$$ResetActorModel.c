// 0x84f39bc @ 0x84f39bc
void __fastcall Campus_Live_Live3DPresenter__ResetActorModel(void *a0, void *a1)
{
  void **v2; // x20
  void *Values; // x0
  __int64 *v5; // x19
  _BOOL8 IsValid; // x0
  __int64 v7; // x1
  __int64 v8; // x8
  __int64 v9; // x9
  _DWORD *v10; // x10
  __int64 v11; // x0
  void *v12; // x0
  long double v13; // q0
  void *v14; // x19
  int v15; // w1
  __int64 v16; // x19
  void *v17; // x0
  __int64 v18; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v19; // [xsp+10h] [xbp+10h]
  __int64 v20; // [xsp+18h] [xbp+18h] BYREF
  __int64 v21; // [xsp+20h] [xbp+20h]
  __int64 *v22; // [xsp+28h] [xbp+28h]

  v2 = (void **)&unk_F413000;
  if ( (unk_F413037 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__ICampusActorController__get_Values__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__get_Current__);
    sub_63CEE78(&VL_IVLActorController_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_int__ICampusActorController__GetEnumerator__);
    unk_F413037 = 1;
  }
  Values = *((void **)a0 + 10);
  v20 = 0;
  v21 = 0;
  v22 = nullptr;
  if ( !Values
    || (Values = System_Collections_Generic_Dictionary_int__object___get_Values(
                   Values,
                   Method_System_Collections_Generic_Dictionary_int__ICampusActorController__get_Values__)) == nullptr )
  {
LABEL_19:
    v12 = (void *)sub_63CF120(Values, a1);
    v14 = v12;
    if ( v15 == 1 )
    {
      v16 = *(_QWORD *)__cxa_begin_catch(v12);
      v18 = v16;
      __cxa_end_catch();
      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose((__int64)v19, *v2);
      if ( !v16 )
        return;
      v13 = sub_63CF118(v16);
      v14 = v17;
    }
    sub_5DD1934(&v18, v13);
    sub_64BD8DC(v14);
  }
  v2 = &Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__;
  System_Collections_Generic_Dictionary_ValueCollection_int__object___GetEnumerator(
    Values,
    Method_System_Collections_Generic_Dictionary_ValueCollection_int__ICampusActorController__GetEnumerator__);
  v18 = 0;
  v19 = &v20;
  while ( System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___MoveNext(
            (__int64)&v20,
            Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__MoveNext__) )
  {
    v5 = v22;
    IsValid = VL_VLExtension__IsValid(v22, nullptr);
    if ( IsValid )
    {
      if ( !v5 )
      {
        Values = (void *)sub_63CF120(IsValid, v7);
        goto LABEL_19;
      }
      v8 = *v5;
      v9 = *(unsigned __int16 *)(*v5 + 302);
      if ( *(_WORD *)(*v5 + 302) )
      {
        v10 = (_DWORD *)(*(_QWORD *)(v8 + 176) + 8LL);
        while ( *((_QWORD *)v10 - 1) != VL_IVLActorController_TypeInfo )
        {
          --v9;
          v10 += 4;
          if ( !v9 )
            goto LABEL_13;
        }
        v11 = v8 + 16LL * (*v10 + 2) + 312;
      }
      else
      {
LABEL_13:
        v11 = sub_6408234(v5, VL_IVLActorController_TypeInfo, 2);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v11)(v5, *(_QWORD *)(v11 + 8));
    }
  }
  System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose(
    (__int64)&v20,
    Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__);
}

