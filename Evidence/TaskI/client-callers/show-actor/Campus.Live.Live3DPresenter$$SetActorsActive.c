// 0x84f5398 @ 0x84f5398
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Live_Live3DPresenter__SetActorsActive(void *a0, bool a1, void *a2)
{
  void **v3; // x21
  void *Values; // x0
  __int64 *v7; // x20
  _BOOL8 IsValid; // x0
  __int64 v9; // x1
  __int64 v10; // x8
  __int64 v11; // x9
  _DWORD *v12; // x10
  __int64 v13; // x0
  void *v14; // x0
  long double v15; // q0
  void *v16; // x19
  int v17; // w1
  __int64 v18; // x19
  void *v19; // x0
  __int64 v20; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v21; // [xsp+10h] [xbp+10h]
  __int64 v22; // [xsp+18h] [xbp+18h] BYREF
  __int64 v23; // [xsp+20h] [xbp+20h]
  __int64 *v24; // [xsp+28h] [xbp+28h]

  v3 = (void **)&unk_F413000;
  if ( (unk_F413036 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__ICampusActorController__get_Values__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__get_Current__);
    sub_63CEE78(&VL_IVLActorController_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_int__ICampusActorController__GetEnumerator__);
    unk_F413036 = 1;
  }
  Values = *((void **)a0 + 10);
  v22 = 0;
  v23 = 0;
  v24 = nullptr;
  if ( !Values
    || (Values = System_Collections_Generic_Dictionary_int__object___get_Values(
                   Values,
                   Method_System_Collections_Generic_Dictionary_int__ICampusActorController__get_Values__)) == nullptr )
  {
LABEL_19:
    v14 = (void *)sub_63CF120(Values, a1);
    v16 = v14;
    if ( v17 == 1 )
    {
      v18 = *(_QWORD *)__cxa_begin_catch(v14);
      v20 = v18;
      __cxa_end_catch();
      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose((__int64)v21, *v3);
      if ( !v18 )
        return;
      v15 = sub_63CF118(v18);
      v16 = v19;
    }
    sub_5DD1934(&v20, v15);
    sub_64BD8DC(v16);
  }
  v3 = &Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__;
  System_Collections_Generic_Dictionary_ValueCollection_int__object___GetEnumerator(
    Values,
    Method_System_Collections_Generic_Dictionary_ValueCollection_int__ICampusActorController__GetEnumerator__);
  v20 = 0;
  v21 = &v22;
  while ( System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___MoveNext(
            (__int64)&v22,
            Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__MoveNext__) )
  {
    v7 = v24;
    IsValid = VL_VLExtension__IsValid(v24, nullptr);
    if ( IsValid )
    {
      if ( !v7 )
      {
        Values = (void *)sub_63CF120(IsValid, v9);
        goto LABEL_19;
      }
      v10 = *v7;
      v11 = *(unsigned __int16 *)(*v7 + 302);
      if ( *(_WORD *)(*v7 + 302) )
      {
        v12 = (_DWORD *)(*(_QWORD *)(v10 + 176) + 8LL);
        while ( *((_QWORD *)v12 - 1) != VL_IVLActorController_TypeInfo )
        {
          --v11;
          v12 += 4;
          if ( !v11 )
            goto LABEL_13;
        }
        v13 = v10 + 16LL * (*v12 + 8) + 312;
      }
      else
      {
LABEL_13:
        v13 = sub_6408234(v7, VL_IVLActorController_TypeInfo, 8);
      }
      (*(void (__fastcall **)(__int64 *, bool, _QWORD))v13)(v7, a1, *(_QWORD *)(v13 + 8));
    }
  }
  System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose(
    (__int64)&v22,
    Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__ICampusActorController__Dispose__);
}

