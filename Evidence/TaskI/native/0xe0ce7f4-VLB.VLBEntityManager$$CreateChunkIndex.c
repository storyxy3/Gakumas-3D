// VLB.VLBEntityManager$$CreateChunkIndex @ 0xe0ce7f4
int __fastcall VLB_VLBEntityManager__CreateChunkIndex(void *a0, void *a1, void *a2)
{
  void *v4; // x19
  void *v5; // x1
  int v6; // w20
  void *v7; // x1
  int result; // w0
  void *v9; // x3
  void *v10; // x22
  void *v11; // x2
  void *v12; // x21
  __int64 v13; // x23
  __int64 v14; // x24
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  __int64 v23; // x8
  __int64 v24; // x9
  __int64 v25; // x10
  __int64 v26; // x0
  __int64 v27; // x22
  _QWORD *v28; // x23
  int v29; // w2
  int v30; // w3
  int v31; // w4
  void *v32; // x5
  int v33; // w2
  int v34; // w3
  int v35; // w4
  void *v36; // x5
  __int64 v37; // x8
  __int64 v38; // x9
  __int64 v39; // x10
  __int64 v40; // x0
  __int64 v41; // x21
  void *v42; // x22
  void *v43; // x1
  int v44; // w2
  int v45; // w3
  int v46; // w4
  void *v47; // x5
  __int64 v48; // x8
  __int64 v49; // x9
  __int64 v50; // x10
  __int64 v51; // x0
  __int64 v52; // x21
  void *v53; // x22
  void *v54; // x1
  int v55; // w2
  int v56; // w3
  int v57; // w4
  void *v58; // x5
  __int64 v59; // x8
  __int64 v60; // x9
  __int64 v61; // x10
  __int64 v62; // x0
  int v63; // w2
  int v64; // w3
  int v65; // w4
  void *v66; // x5
  __int64 v67; // x8
  __int64 v68; // x10
  unsigned int v69; // w9
  __int64 v70; // x8
  void *v71; // x2
  __int64 v72; // x8
  __int64 v73; // x9
  __int64 v74; // x10
  void *v75; // x0
  int v76; // w1
  int v77; // w2
  void *v78; // x3
  __int128 v79; // [xsp+0h] [xbp+0h] BYREF
  __int128 v80; // [xsp+10h] [xbp+10h]
  __int128 v81; // [xsp+20h] [xbp+20h] BYREF
  __int128 v82; // [xsp+30h] [xbp+30h]
  __int64 v83; // [xsp+40h] [xbp+40h]
  __int64 v84; // [xsp+58h] [xbp+58h] BYREF

  v4 = a0;
  if ( (unk_F43D9EB & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__TryGetValue__);
    sub_63CEE78(&Method_System_Collections_Generic_List_int__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__Add__);
    sub_63CEE78(&UnityEngine_MaterialPropertyBlock_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&VLB_VLBCachedChunk_TypeInfo);
    sub_63CEE78(&VLB_VLBCulledChunk_TypeInfo);
    sub_63CEE78(&VLB_VLBDrawCallChunk_TypeInfo);
    a0 = (void *)sub_63CEE78(&VLB_VLBEntityChunk_TypeInfo);
    unk_F43D9EB = 1;
  }
  HIDWORD(v84) = 0;
  v79 = 0u;
  v80 = 0u;
  if ( !a1 )
    goto LABEL_47;
  VLB_VolumetricLightBeamSD__GetStaticProps(a1, nullptr);
  v79 = v81;
  v80 = v82;
  a0 = (void *)VLB_MaterialManager_StaticPropertiesSD__GetMaterialID((__int64)&v79, v5);
  if ( !*((_QWORD *)v4 + 2) )
    goto LABEL_47;
  v6 = (int)a0;
  if ( System_Collections_Generic_Dictionary_int__int___TryGetValue(
         *((void **)v4 + 2),
         (int)a0,
         (char *)&v84 + 4,
         Method_System_Collections_Generic_Dictionary_int__int__TryGetValue__) )
  {
    return HIDWORD(v84);
  }
  a0 = VLB_Config__GetInstance(0, v7);
  if ( !a0 )
    goto LABEL_47;
  v10 = VLB_Config__NewMaterialTransient(a0, 0, 1, v9);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Implicit(v10, nullptr) )
    VLB_MaterialManager_StaticPropertiesSD__ApplyToMaterial((__int64)&v79, v10, v11);
  v12 = (void *)sub_63CF110(UnityEngine_MaterialPropertyBlock_TypeInfo);
  UnityEngine_MaterialPropertyBlock___ctor(v12, nullptr);
  v13 = *((_QWORD *)v4 + 3);
  v14 = sub_63CF110(VLB_VLBEntityChunk_TypeInfo);
  System_Object___ctor((void *)v14, nullptr);
  if ( !v14 )
    goto LABEL_47;
  *(_QWORD *)(v14 + 80) = v10;
  *(_DWORD *)(v14 + 72) = v6;
  sub_63CEE24((void *)(v14 + 80), (int)v10, v15, v16, v17, v18);
  if ( !v13 )
    goto LABEL_47;
  v23 = *(_QWORD *)(v13 + 16);
  v24 = Method_System_Collections_Generic_List_VLBEntityChunk__Add__;
  ++*(_DWORD *)(v13 + 28);
  if ( !v23 )
    goto LABEL_47;
  v25 = *(int *)(v13 + 24);
  if ( (unsigned int)v25 >= *(_DWORD *)(v23 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(
      (void *)v13,
      (void *)v14,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v24 + 32) + 192LL) + 112LL));
  }
  else
  {
    v26 = v23 + 8 * v25;
    *(_DWORD *)(v13 + 24) = v25 + 1;
    *(_QWORD *)(v26 + 32) = v14;
    sub_63CEE24((void *)(v26 + 32), v14, v19, v20, v21, v22);
  }
  v27 = *((_QWORD *)v4 + 4);
  v28 = (_QWORD *)sub_63CF110(VLB_VLBCachedChunk_TypeInfo);
  System_Object___ctor(v28, nullptr);
  if ( !v28 )
    goto LABEL_47;
  v28[5] = v12;
  sub_63CEE24(v28 + 5, (int)v12, v29, v30, v31, v32);
  if ( !v27 )
    goto LABEL_47;
  v37 = *(_QWORD *)(v27 + 16);
  v38 = Method_System_Collections_Generic_List_VLBCachedChunk__Add__;
  ++*(_DWORD *)(v27 + 28);
  if ( !v37 )
    goto LABEL_47;
  v39 = *(int *)(v27 + 24);
  if ( (unsigned int)v39 >= *(_DWORD *)(v37 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(
      (void *)v27,
      v28,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v38 + 32) + 192LL) + 112LL));
  }
  else
  {
    v40 = v37 + 8 * v39;
    *(_DWORD *)(v27 + 24) = v39 + 1;
    *(_QWORD *)(v40 + 32) = v28;
    sub_63CEE24((void *)(v40 + 32), (int)v28, v33, v34, v35, v36);
  }
  v41 = *((_QWORD *)v4 + 5);
  v42 = (void *)sub_63CF110(VLB_VLBCulledChunk_TypeInfo);
  VLB_VLBCulledChunk___ctor(v42, v43);
  if ( !v41 )
    goto LABEL_47;
  v48 = *(_QWORD *)(v41 + 16);
  v49 = Method_System_Collections_Generic_List_VLBCulledChunk__Add__;
  ++*(_DWORD *)(v41 + 28);
  if ( !v48 )
    goto LABEL_47;
  v50 = *(int *)(v41 + 24);
  if ( (unsigned int)v50 >= *(_DWORD *)(v48 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(
      (void *)v41,
      v42,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v49 + 32) + 192LL) + 112LL));
  }
  else
  {
    v51 = v48 + 8 * v50;
    *(_DWORD *)(v41 + 24) = v50 + 1;
    *(_QWORD *)(v51 + 32) = v42;
    sub_63CEE24((void *)(v51 + 32), (int)v42, v44, v45, v46, v47);
  }
  v52 = *((_QWORD *)v4 + 6);
  v53 = (void *)sub_63CF110(VLB_VLBDrawCallChunk_TypeInfo);
  VLB_VLBDrawCallChunk___ctor(v53, v54);
  if ( !v52 )
    goto LABEL_47;
  v59 = *(_QWORD *)(v52 + 16);
  v60 = Method_System_Collections_Generic_List_VLBDrawCallChunk__Add__;
  ++*(_DWORD *)(v52 + 28);
  if ( !v59 )
    goto LABEL_47;
  v61 = *(int *)(v52 + 24);
  if ( (unsigned int)v61 >= *(_DWORD *)(v59 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(
      (void *)v52,
      v53,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v60 + 32) + 192LL) + 112LL));
  }
  else
  {
    v62 = v59 + 8 * v61;
    *(_DWORD *)(v52 + 24) = v61 + 1;
    *(_QWORD *)(v62 + 32) = v53;
    sub_63CEE24((void *)(v62 + 32), (int)v53, v55, v56, v57, v58);
  }
  a0 = *((void **)v4 + 9);
  if ( !a0 )
    goto LABEL_47;
  v67 = *((_QWORD *)a0 + 2);
  v68 = Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__Add__;
  ++*((_DWORD *)a0 + 7);
  if ( !v67 )
    goto LABEL_47;
  v69 = *((_DWORD *)a0 + 6);
  if ( v69 >= *(_DWORD *)(v67 + 24) )
  {
    v71 = *(void **)(*(_QWORD *)(*(_QWORD *)(v68 + 32) + 192LL) + 112LL);
    v83 = 0;
    v81 = 0u;
    v82 = 0u;
    System_Collections_Generic_List_VLBEntityManager_CombinedChunks___AddWithResize(a0, (__int64)&v81, v71);
  }
  else
  {
    v70 = v67 + 40LL * (int)v69;
    *((_DWORD *)a0 + 6) = v69 + 1;
    *(_OWORD *)(v70 + 32) = 0u;
    *(_QWORD *)(v70 + 64) = 0;
    *(_OWORD *)(v70 + 48) = 0u;
    sub_63CEE24((void *)(v70 + 32), 0, v63, v64, v65, v66);
  }
  a0 = *((void **)v4 + 10);
  if ( !a0 )
    goto LABEL_47;
  v72 = *((_QWORD *)a0 + 2);
  v73 = Method_System_Collections_Generic_List_int__Add__;
  ++*((_DWORD *)a0 + 7);
  if ( !v72 )
    goto LABEL_47;
  v74 = *((int *)a0 + 6);
  if ( (unsigned int)v74 >= *(_DWORD *)(v72 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(
      a0,
      0,
      *(void **)(*(_QWORD *)(*(_QWORD *)(v73 + 32) + 192LL) + 112LL));
  }
  else
  {
    *((_DWORD *)a0 + 6) = v74 + 1;
    *(_DWORD *)(v72 + 4 * v74 + 32) = 0;
  }
  a0 = *((void **)v4 + 2);
  if ( a0 )
  {
    System_Collections_Generic_Dictionary_int__int___Add(
      a0,
      v6,
      *((_DWORD *)v4 + 14),
      Method_System_Collections_Generic_Dictionary_int__int__Add__);
    result = *((_DWORD *)v4 + 14);
    *((_DWORD *)v4 + 14) = result + 1;
  }
  else
  {
LABEL_47:
    v75 = (void *)sub_63CF120(a0, a1);
    return VLB_EntityIndexer__CreateEntity(v75, v76, v77, v78);
  }
  return result;
}

