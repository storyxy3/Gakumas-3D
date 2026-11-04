// VL.Core.VLActorModelParts$$InitializeBones @ 0xe128f1c
void __fastcall VL_Core_VLActorModelParts__InitializeBones(void *a0, void *a1, void *a2)
{
  __int64 v5; // x1
  void *v6; // x0
  __int64 v7; // x0
  __int64 v8; // x1
  void *v9; // x0
  long double v10; // q0
  void *v11; // x19
  int v12; // w1
  __int64 v13; // x19
  void *v14; // x0
  __int64 v15; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v16; // [xsp+10h] [xbp+10h]
  __int64 v17; // [xsp+18h] [xbp+18h] BYREF
  __int64 v18; // [xsp+20h] [xbp+20h]
  __int64 v19; // [xsp+28h] [xbp+28h]

  if ( (unk_F43DD83 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_DefaultBoneInfo__GetEnumerator__);
    sub_63CEE78(&Method_VL_Core_SerializedDictionary_string__Transform__Add__);
    unk_F43DD83 = 1;
  }
  v17 = 0;
  v18 = 0;
  v19 = 0;
  VL_Core_VLActorModelParts__UpdateRootBoneLinkList(a0, a1, a2);
  v6 = *((void **)a0 + 8);
  if ( !v6 )
    goto LABEL_13;
  a0 = &Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__Dispose__;
  System_Collections_Generic_List_object___GetEnumerator(
    v6,
    Method_System_Collections_Generic_List_DefaultBoneInfo__GetEnumerator__);
  v15 = 0;
  v16 = &v17;
  while ( 1 )
  {
    v7 = System_Collections_Generic_List_Enumerator_object___MoveNext(
           (__int64)&v17,
           Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__MoveNext__);
    if ( (v7 & 1) == 0 )
    {
      System_Collections_Generic_List_Enumerator_object___Dispose(
        (__int64)&v17,
        Method_System_Collections_Generic_List_Enumerator_DefaultBoneInfo__Dispose__);
      return;
    }
    if ( !v19 )
      break;
    if ( !a1 )
      goto LABEL_12;
    VL_Core_SerializedDictionary_object__object___Add(
      a1,
      *(void **)(v19 + 24),
      *(void **)(v19 + 16),
      Method_VL_Core_SerializedDictionary_string__Transform__Add__);
  }
  v7 = sub_63CF120(v7, v8);
LABEL_12:
  v6 = (void *)sub_63CF120(v7, v8);
LABEL_13:
  v9 = (void *)sub_63CF120(v6, v5);
  v11 = v9;
  if ( v12 != 1 )
  {
LABEL_16:
    sub_63CE1AC(&v15, v10);
    sub_64BD8DC(v11);
  }
  v13 = *(_QWORD *)__cxa_begin_catch(v9);
  v15 = v13;
  __cxa_end_catch();
  System_Collections_Generic_List_Enumerator_object___Dispose((__int64)v16, *(void **)a0);
  if ( v13 )
  {
    v10 = sub_63CF118(v13);
    v11 = v14;
    goto LABEL_16;
  }
}

