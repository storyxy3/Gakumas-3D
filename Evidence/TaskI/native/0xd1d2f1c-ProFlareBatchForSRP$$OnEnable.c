// 0xd1d2f1c @ 0xd1d2f1c
void __fastcall ProFlareBatchForSRP__OnEnable(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x2
  __int64 v5; // [xsp+18h] [xbp+18h] BYREF
  __int64 v6; // [xsp+20h] [xbp+20h]
  void *v7; // [xsp+28h] [xbp+28h]

  if ( (unk_F42C93F & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__GetEnumerator__);
    unk_F42C93F = 1;
  }
  v3 = *((void **)a0 + 10);
  v5 = 0;
  v6 = 0;
  v7 = nullptr;
  if ( v3 )
  {
    System_Collections_Generic_List_object___GetEnumerator(
      v3,
      Method_System_Collections_Generic_List_ProFlareBatchForSRPData__GetEnumerator__);
    while ( System_Collections_Generic_List_Enumerator_object___MoveNext(
              (__int64)&v5,
              Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__MoveNext__) )
    {
      if ( v7 )
        ProFlareBatchForSRPData__Initialize(v7, *((_DWORD *)a0 + 18), v4);
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(
      (__int64)&v5,
      Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__Dispose__);
  }
}

