// Campus.Crowd.CrowdRendererFeature$$Dispose @ 0xddc4fe8
void __fastcall Campus_Crowd_CrowdRendererFeature__Dispose(void *a0, bool a1, void *a2)
{
  void **v3; // x22
  void *v5; // x0
  void *Values; // x0
  __int64 v7; // x1
  void *v8; // x1
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  void *v13; // x19
  void *v14; // x0
  long double v15; // q0
  void *v16; // x21
  int v17; // w1
  __int64 v18; // x21
  void *v19; // x0
  __int64 v20; // [xsp+8h] [xbp+8h] BYREF
  __int64 *v21; // [xsp+10h] [xbp+10h]
  __int64 v22; // [xsp+18h] [xbp+18h] BYREF
  __int64 v23; // [xsp+20h] [xbp+20h]
  void *v24; // [xsp+28h] [xbp+28h]

  if ( (unk_F43BCF6 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__get_Values__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__CrowdSystem__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__CrowdSystem__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__CrowdSystem__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_ValueCollection_int__CrowdSystem__GetEnumerator__);
    unk_F43BCF6 = 1;
  }
  v22 = 0;
  v23 = 0;
  v5 = *((void **)a0 + 11);
  v24 = nullptr;
  if ( v5 )
  {
    Values = System_Collections_Generic_Dictionary_int__object___get_Values(
               v5,
               Method_System_Collections_Generic_Dictionary_int__CrowdSystem__get_Values__);
    if ( Values )
    {
      System_Collections_Generic_Dictionary_ValueCollection_int__object___GetEnumerator(
        Values,
        Method_System_Collections_Generic_Dictionary_ValueCollection_int__CrowdSystem__GetEnumerator__);
      v20 = 0;
      v21 = &v22;
      while ( System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___MoveNext(
                (__int64)&v22,
                Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__CrowdSystem__MoveNext__) )
      {
        if ( v24 )
          Campus_Crowd_CrowdSystem__Dispose(v24, v8);
      }
      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose(
        (__int64)&v22,
        Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__CrowdSystem__Dispose__);
      goto LABEL_10;
    }
    v14 = (void *)sub_63CF120(0, v7);
    v16 = v14;
    if ( v17 == 1 )
    {
      v18 = *(_QWORD *)__cxa_begin_catch(v14);
      v20 = v18;
      __cxa_end_catch();
      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__object___Dispose((__int64)v21, *v3);
      if ( !v18 )
      {
LABEL_10:
        *((_QWORD *)a0 + 11) = 0;
        sub_63CEE24((char *)a0 + 88, 0, v9, v10, v11, v12);
        goto LABEL_11;
      }
      v15 = sub_63CF118(v18);
      v16 = v19;
    }
    sub_63BAC94(&v20, v15);
    sub_64BD8DC(v16);
  }
LABEL_11:
  v13 = *((void **)a0 + 10);
  if ( !*(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
  UnityEngine_Rendering_CoreUtils__Destroy(v13, nullptr);
}

