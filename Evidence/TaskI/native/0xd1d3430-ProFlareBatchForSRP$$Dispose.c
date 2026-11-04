// 0xd1d3430 @ 0xd1d3430
void __fastcall ProFlareBatchForSRP__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x1
  __int64 v5; // [xsp+18h] [xbp+18h] BYREF
  __int64 v6; // [xsp+20h] [xbp+20h]
  void *v7; // [xsp+28h] [xbp+28h]

  if ( (unk_F42C940 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ProFlareBatchForSRPData__GetEnumerator__);
    unk_F42C940 = 1;
  }
  v5 = 0;
  v6 = 0;
  v7 = nullptr;
  if ( UnityEngine_Jobs_TransformAccessArray__get_isCreated((__int64)a0 + 96, nullptr) )
    UnityEngine_Jobs_TransformAccessArray__Dispose((__int64)a0 + 96, nullptr);
  v3 = *((void **)a0 + 10);
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
        ProFlareBatchForSRPData__Dispose(v7, v4);
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(
      (__int64)&v5,
      Method_System_Collections_Generic_List_Enumerator_ProFlareBatchForSRPData__Dispose__);
  }
}

