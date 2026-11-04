// VLB.VLBEntityManager$$.ctor @ 0xe0cd108
void __fastcall VLB_VLBEntityManager___ctor(void *a0, void *a1)
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
  void *v13; // x20
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  void *v18; // x20
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x20
  int v24; // w2
  int v25; // w3
  int v26; // w4
  void *v27; // x5
  void *v28; // x20
  void *v29; // x1
  int v30; // w2
  int v31; // w3
  int v32; // w4
  void *v33; // x5
  void *v34; // x20
  int v35; // w2
  int v36; // w3
  int v37; // w4
  void *v38; // x5
  void *v39; // x20
  int v40; // w2
  int v41; // w3
  int v42; // w4
  void *v43; // x5
  void *v44; // x0
  int v45; // w2
  int v46; // w3
  int v47; // w4
  void *v48; // x5

  if ( (unk_F43D9EA & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Profiling_CustomSampler_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int___ctor__);
    sub_63CEE78(&System_Collections_Generic_Dictionary_int__int__TypeInfo);
    sub_63CEE78(&VLB_EntityIndexer_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_int___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks___ctor__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk___ctor__);
    sub_63CEE78(&System_Collections_Generic_List_int__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_VLBCulledChunk__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_VLBEntityChunk__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_VLBEntityManager_CombinedChunks__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_VLBCachedChunk__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_List_VLBDrawCallChunk__TypeInfo);
    sub_63CEE78(&StringLiteral_VLBUpdateAllEntity_Execute);
    unk_F43D9EA = 1;
  }
  v3 = (void *)sub_63CF110(System_Collections_Generic_Dictionary_int__int__TypeInfo);
  System_Collections_Generic_Dictionary_int__int____ctor(
    v3,
    Method_System_Collections_Generic_Dictionary_int__int___ctor__);
  *((_QWORD *)a0 + 2) = v3;
  sub_63CEE24((char *)a0 + 16, (int)v3, v4, v5, v6, v7);
  v8 = (void *)sub_63CF110(System_Collections_Generic_List_VLBEntityChunk__TypeInfo);
  System_Collections_Generic_List_object____ctor(v8, Method_System_Collections_Generic_List_VLBEntityChunk___ctor__);
  *((_QWORD *)a0 + 3) = v8;
  sub_63CEE24((char *)a0 + 24, (int)v8, v9, v10, v11, v12);
  v13 = (void *)sub_63CF110(System_Collections_Generic_List_VLBCachedChunk__TypeInfo);
  System_Collections_Generic_List_object____ctor(v13, Method_System_Collections_Generic_List_VLBCachedChunk___ctor__);
  *((_QWORD *)a0 + 4) = v13;
  sub_63CEE24((char *)a0 + 32, (int)v13, v14, v15, v16, v17);
  v18 = (void *)sub_63CF110(System_Collections_Generic_List_VLBCulledChunk__TypeInfo);
  System_Collections_Generic_List_object____ctor(v18, Method_System_Collections_Generic_List_VLBCulledChunk___ctor__);
  *((_QWORD *)a0 + 5) = v18;
  sub_63CEE24((char *)a0 + 40, (int)v18, v19, v20, v21, v22);
  v23 = (void *)sub_63CF110(System_Collections_Generic_List_VLBDrawCallChunk__TypeInfo);
  System_Collections_Generic_List_object____ctor(v23, Method_System_Collections_Generic_List_VLBDrawCallChunk___ctor__);
  *((_QWORD *)a0 + 6) = v23;
  sub_63CEE24((char *)a0 + 48, (int)v23, v24, v25, v26, v27);
  v28 = (void *)sub_63CF110(VLB_EntityIndexer_TypeInfo);
  VLB_EntityIndexer___ctor(v28, v29);
  *((_QWORD *)a0 + 8) = v28;
  sub_63CEE24((char *)a0 + 64, (int)v28, v30, v31, v32, v33);
  v34 = (void *)sub_63CF110(System_Collections_Generic_List_VLBEntityManager_CombinedChunks__TypeInfo);
  System_Collections_Generic_List_VLBEntityManager_CombinedChunks____ctor(
    v34,
    Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks___ctor__);
  *((_QWORD *)a0 + 9) = v34;
  sub_63CEE24((char *)a0 + 72, (int)v34, v35, v36, v37, v38);
  v39 = (void *)sub_63CF110(System_Collections_Generic_List_int__TypeInfo);
  System_Collections_Generic_List_int____ctor(v39, Method_System_Collections_Generic_List_int___ctor__);
  *((_QWORD *)a0 + 10) = v39;
  sub_63CEE24((char *)a0 + 80, (int)v39, v40, v41, v42, v43);
  System_Object___ctor(a0, nullptr);
  if ( !*(_DWORD *)(UnityEngine_Profiling_CustomSampler_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Profiling_CustomSampler_TypeInfo);
  v44 = UnityEngine_Profiling_CustomSampler__Create(StringLiteral_VLBUpdateAllEntity_Execute, 0, nullptr);
  *((_QWORD *)a0 + 11) = v44;
  sub_63CEE24((char *)a0 + 88, (int)v44, v45, v46, v47, v48);
}

