// VLB.VLBEntityManager$$Dispose @ 0xe0cd83c
void __fastcall VLB_VLBEntityManager__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  __int64 v4; // x8
  int v5; // w2
  int v6; // w9
  _BOOL8 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 v11; // x0
  __int64 v12; // x1
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x1
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x0
  __int64 v19; // x1
  __int64 v20; // x0
  __int64 v21; // x1
  __int64 v22; // x0
  __int64 v23; // x8
  int v24; // w2
  int v25; // w9
  __int64 v26; // x8
  int v27; // w2
  int v28; // w9
  __int64 v29; // x8
  int v30; // w2
  int v31; // w9
  __int64 v32; // x8
  int v33; // w2
  int v34; // w9
  __int64 v35; // x8
  int v36; // w2
  int v37; // w9
  int v38; // w1
  __int64 v39; // x20
  long double v40; // q0
  void *v41; // x0
  void *v42; // [xsp+10h] [xbp+10h]
  __int128 v43; // [xsp+18h] [xbp+18h] BYREF
  __int64 v44; // [xsp+28h] [xbp+28h]
  __int128 v45; // [xsp+30h] [xbp+30h] BYREF
  __int64 v46; // [xsp+40h] [xbp+40h]
  __int128 v47; // [xsp+50h] [xbp+50h] BYREF
  __int64 v48; // [xsp+60h] [xbp+60h]
  __int128 v49; // [xsp+70h] [xbp+70h] BYREF
  __int64 v50; // [xsp+80h] [xbp+80h]
  __int128 v51; // [xsp+90h] [xbp+90h] BYREF
  __int128 v52; // [xsp+A0h] [xbp+A0h] BYREF
  __int64 v53; // [xsp+B0h] [xbp+B0h]

  if ( (unk_F43D9F0 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__int__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__Dispose__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__MoveNext__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__get_Current__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityManager_CombinedChunks__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__Clear__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__GetEnumerator__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__GetEnumerator__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__GetEnumerator__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__GetEnumerator__);
    unk_F43D9F0 = 1;
  }
  v3 = *((void **)a0 + 2);
  v52 = 0u;
  v53 = 0;
  v51 = 0u;
  v49 = 0u;
  v50 = 0;
  v47 = 0u;
  v48 = 0;
  v45 = 0u;
  v46 = 0;
  if ( v3 )
  {
    System_Collections_Generic_Dictionary_int__int___Clear(
      v3,
      Method_System_Collections_Generic_Dictionary_int__int__Clear__);
    v4 = *((_QWORD *)a0 + 9);
    if ( v4 )
    {
      v5 = *(_DWORD *)(v4 + 24);
      v6 = *(_DWORD *)(v4 + 28) + 1;
      *(_DWORD *)(v4 + 24) = 0;
      *(_DWORD *)(v4 + 28) = v6;
      if ( v5 >= 1 )
        System_Array__Clear(*(void **)(v4 + 16), 0, v5, nullptr);
      v3 = *((void **)a0 + 3);
      if ( v3 )
      {
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBEntityChunk__GetEnumerator__);
        v53 = v44;
        v52 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v52;
        while ( 1 )
        {
          v7 = System_Collections_Generic_List_Enumerator_object___MoveNext(
                 (__int64)&v52,
                 Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__MoveNext__);
          if ( !v7 )
            break;
          if ( !v53 )
          {
            v9 = sub_63CF120(v7, v8);
LABEL_67:
            v11 = sub_63CF120(v9, v10);
LABEL_68:
            v13 = sub_63CF120(v11, v12);
LABEL_69:
            v16 = sub_63CF120(v13, v14);
LABEL_70:
            v18 = sub_63CF120(v16, v15);
LABEL_71:
            v20 = sub_63CF120(v18, v17);
LABEL_72:
            v22 = sub_63CF120(v20, v19);
            goto LABEL_73;
          }
          v51 = *(_OWORD *)(v53 + 24);
          Unity_Jobs_JobHandle__Complete((__int64)&v51, nullptr);
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v52,
          Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__Dispose__);
        v3 = *((void **)a0 + 4);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBCachedChunk__GetEnumerator__);
        v50 = v44;
        v49 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v49;
        while ( 1 )
        {
          v9 = System_Collections_Generic_List_Enumerator_object___MoveNext(
                 (__int64)&v49,
                 Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__MoveNext__);
          if ( (v9 & 1) == 0 )
            break;
          if ( !v50 )
            goto LABEL_67;
          v51 = *(_OWORD *)(v50 + 24);
          Unity_Jobs_JobHandle__Complete((__int64)&v51, nullptr);
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v49,
          Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__Dispose__);
        v3 = *((void **)a0 + 5);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBCulledChunk__GetEnumerator__);
        v48 = v44;
        v47 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v47;
        while ( 1 )
        {
          v11 = System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v47,
                  Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__MoveNext__);
          if ( (v11 & 1) == 0 )
            break;
          if ( !v48 )
            goto LABEL_68;
          v51 = *(_OWORD *)(v48 + 24);
          Unity_Jobs_JobHandle__Complete((__int64)&v51, nullptr);
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v47,
          Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__Dispose__);
        v3 = *((void **)a0 + 6);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBDrawCallChunk__GetEnumerator__);
        v46 = v44;
        v45 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v45;
        while ( 1 )
        {
          v13 = System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v45,
                  Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__MoveNext__);
          if ( (v13 & 1) == 0 )
            break;
          if ( !v46 )
            goto LABEL_69;
          v51 = *(_OWORD *)(v46 + 24);
          Unity_Jobs_JobHandle__Complete((__int64)&v51, nullptr);
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v45,
          Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__Dispose__);
        v3 = *((void **)a0 + 3);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBEntityChunk__GetEnumerator__);
        v53 = v44;
        v52 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v52;
        while ( System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v52,
                  Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__MoveNext__) )
        {
          v16 = v53;
          if ( !v53 )
            goto LABEL_70;
          (*(void (**)(void))(*(_QWORD *)v53 + 440LL))();
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v52,
          Method_System_Collections_Generic_List_Enumerator_VLBEntityChunk__Dispose__);
        v3 = *((void **)a0 + 4);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBCachedChunk__GetEnumerator__);
        v50 = v44;
        v49 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v49;
        while ( System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v49,
                  Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__MoveNext__) )
        {
          v18 = v50;
          if ( !v50 )
            goto LABEL_71;
          (*(void (**)(void))(*(_QWORD *)v50 + 440LL))();
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v49,
          Method_System_Collections_Generic_List_Enumerator_VLBCachedChunk__Dispose__);
        v3 = *((void **)a0 + 5);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBCulledChunk__GetEnumerator__);
        v48 = v44;
        v47 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v47;
        while ( System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v47,
                  Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__MoveNext__) )
        {
          v20 = v48;
          if ( !v48 )
            goto LABEL_72;
          (*(void (**)(void))(*(_QWORD *)v48 + 440LL))();
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(
          (__int64)&v47,
          Method_System_Collections_Generic_List_Enumerator_VLBCulledChunk__Dispose__);
        v3 = *((void **)a0 + 6);
        if ( !v3 )
          goto LABEL_74;
        System_Collections_Generic_List_object___GetEnumerator(
          v3,
          Method_System_Collections_Generic_List_VLBDrawCallChunk__GetEnumerator__);
        v46 = v44;
        v45 = v43;
        *(_QWORD *)&v43 = 0;
        *((_QWORD *)&v43 + 1) = &v45;
        while ( 1 )
        {
          if ( !System_Collections_Generic_List_Enumerator_object___MoveNext(
                  (__int64)&v45,
                  Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__MoveNext__) )
          {
            System_Collections_Generic_List_Enumerator_object___Dispose(
              (__int64)&v45,
              Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__Dispose__);
            goto LABEL_48;
          }
          v22 = v46;
          if ( !v46 )
            break;
          (*(void (**)(void))(*(_QWORD *)v46 + 440LL))();
        }
LABEL_73:
        v3 = (void *)sub_63CF120(v22, v21);
        goto LABEL_74;
      }
    }
  }
  while ( 1 )
  {
LABEL_74:
    v42 = (void *)sub_63CF120(v3, a1);
    if ( v38 != 1 )
    {
      sub_63CBA4C(&v43);
LABEL_78:
      sub_64BD8DC(v42);
    }
    v39 = *(_QWORD *)__cxa_begin_catch(v42);
    *(_QWORD *)&v43 = v39;
    __cxa_end_catch();
    System_Collections_Generic_List_Enumerator_object___Dispose(
      *((__int64 *)&v43 + 1),
      Method_System_Collections_Generic_List_Enumerator_VLBDrawCallChunk__Dispose__);
    if ( v39 )
    {
      v40 = sub_63CF118(v39);
      v42 = v41;
      sub_63CB9EC(&v43, v40);
      goto LABEL_78;
    }
LABEL_48:
    v3 = *((void **)a0 + 8);
    if ( v3 )
    {
      VLB_EntityIndexer__Clear(v3, a1);
      v3 = *((void **)a0 + 2);
      if ( v3 )
      {
        System_Collections_Generic_Dictionary_int__int___Clear(
          v3,
          Method_System_Collections_Generic_Dictionary_int__int__Clear__);
        v23 = *((_QWORD *)a0 + 3);
        if ( v23 )
        {
          v24 = *(_DWORD *)(v23 + 24);
          v25 = *(_DWORD *)(v23 + 28) + 1;
          *(_DWORD *)(v23 + 24) = 0;
          *(_DWORD *)(v23 + 28) = v25;
          if ( v24 >= 1 )
            System_Array__Clear(*(void **)(v23 + 16), 0, v24, nullptr);
          v26 = *((_QWORD *)a0 + 4);
          if ( v26 )
          {
            v27 = *(_DWORD *)(v26 + 24);
            v28 = *(_DWORD *)(v26 + 28) + 1;
            *(_DWORD *)(v26 + 24) = 0;
            *(_DWORD *)(v26 + 28) = v28;
            if ( v27 >= 1 )
              System_Array__Clear(*(void **)(v26 + 16), 0, v27, nullptr);
            v29 = *((_QWORD *)a0 + 5);
            if ( v29 )
            {
              v30 = *(_DWORD *)(v29 + 24);
              v31 = *(_DWORD *)(v29 + 28) + 1;
              *(_DWORD *)(v29 + 24) = 0;
              *(_DWORD *)(v29 + 28) = v31;
              if ( v30 >= 1 )
                System_Array__Clear(*(void **)(v29 + 16), 0, v30, nullptr);
              v32 = *((_QWORD *)a0 + 6);
              if ( v32 )
              {
                v33 = *(_DWORD *)(v32 + 24);
                v34 = *(_DWORD *)(v32 + 28) + 1;
                *(_DWORD *)(v32 + 24) = 0;
                *(_DWORD *)(v32 + 28) = v34;
                if ( v33 >= 1 )
                  System_Array__Clear(*(void **)(v32 + 16), 0, v33, nullptr);
                v35 = *((_QWORD *)a0 + 9);
                if ( v35 )
                  break;
              }
            }
          }
        }
      }
    }
  }
  v36 = *(_DWORD *)(v35 + 24);
  v37 = *(_DWORD *)(v35 + 28) + 1;
  *(_DWORD *)(v35 + 24) = 0;
  *(_DWORD *)(v35 + 28) = v37;
  if ( v36 >= 1 )
    System_Array__Clear(*(void **)(v35 + 16), 0, v36, nullptr);
  *((_DWORD *)a0 + 14) = 0;
}

