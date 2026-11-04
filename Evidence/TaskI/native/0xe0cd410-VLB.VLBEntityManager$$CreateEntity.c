// VLB.VLBEntityManager$$CreateEntity @ 0xe0cd410
__int64 __fastcall VLB_VLBEntityManager__CreateEntity(void *a0, void *a1, void *a2)
{
  __int64 ChunkIndex; // x0
  __int64 v6; // x1
  int v7; // w26
  void *v8; // x3
  __int64 v9; // x8
  __int64 v10; // x22
  __int64 v11; // x21
  _QWORD *v12; // x23
  __int64 v13; // x24
  __int64 v14; // x25
  int v15; // w8
  __int64 v16; // x26
  int v17; // w8
  unsigned int v18; // w27
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  _DWORD *v23; // x24
  _DWORD *v24; // x0
  void *transform; // x0
  void *v26; // x4
  __int64 result; // x0
  __int64 v28; // x0
  void *v29; // x0
  void *v30; // x1
  void *v31; // x2

  if ( (unk_F43D9E9 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
    unk_F43D9E9 = 1;
  }
  ChunkIndex = VLB_VLBEntityManager__CreateChunkIndex(a0, a1, a2);
  if ( !*((_QWORD *)a0 + 3) )
    goto LABEL_28;
  v7 = ChunkIndex;
  ChunkIndex = (__int64)System_Collections_Generic_List_object___get_Item(
                          *((void **)a0 + 3),
                          ChunkIndex,
                          Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
  if ( !ChunkIndex )
    goto LABEL_28;
  v9 = ChunkIndex;
  ChunkIndex = *((_QWORD *)a0 + 8);
  if ( !ChunkIndex )
    goto LABEL_28;
  v10 = *(int *)(v9 + 16);
  ChunkIndex = VLB_EntityIndexer__CreateEntity((void *)ChunkIndex, *(_DWORD *)(v9 + 16), v7, v8);
  if ( !*((_QWORD *)a0 + 3) )
    goto LABEL_28;
  v11 = ChunkIndex;
  ChunkIndex = (__int64)System_Collections_Generic_List_object___get_Item(
                          *((void **)a0 + 3),
                          v7,
                          Method_System_Collections_Generic_List_VLBEntityChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 4) )
    goto LABEL_28;
  v12 = (_QWORD *)ChunkIndex;
  ChunkIndex = (__int64)System_Collections_Generic_List_object___get_Item(
                          *((void **)a0 + 4),
                          v7,
                          Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 5) )
    goto LABEL_28;
  v13 = ChunkIndex;
  ChunkIndex = (__int64)System_Collections_Generic_List_object___get_Item(
                          *((void **)a0 + 5),
                          v7,
                          Method_System_Collections_Generic_List_VLBCulledChunk__get_Item__);
  if ( !*((_QWORD *)a0 + 6) )
    goto LABEL_28;
  v14 = ChunkIndex;
  ChunkIndex = (__int64)System_Collections_Generic_List_object___get_Item(
                          *((void **)a0 + 6),
                          v7,
                          Method_System_Collections_Generic_List_VLBDrawCallChunk__get_Item__);
  if ( !v12 )
    goto LABEL_28;
  v15 = *((_DWORD *)v12 + 5);
  v16 = ChunkIndex;
  if ( v15 == *((_DWORD *)v12 + 4) )
  {
    v17 = 2 * v15;
    if ( v17 <= 8 )
      v18 = 8;
    else
      v18 = v17;
    ChunkIndex = (*(__int64 (__fastcall **)(_QWORD *, _QWORD, _QWORD))(*v12 + 424LL))(
                   v12,
                   v18,
                   *(_QWORD *)(*v12 + 432LL));
    if ( !v13 )
      goto LABEL_28;
    ChunkIndex = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v13 + 424LL))(
                   v13,
                   v18,
                   *(_QWORD *)(*(_QWORD *)v13 + 432LL));
    if ( !v14 )
      goto LABEL_28;
    ChunkIndex = (*(__int64 (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v14 + 424LL))(
                   v14,
                   v18,
                   *(_QWORD *)(*(_QWORD *)v14 + 432LL));
    if ( !v16 )
      goto LABEL_28;
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v16 + 424LL))(
      v16,
      v18,
      *(_QWORD *)(*(_QWORD *)v16 + 432LL));
  }
  ChunkIndex = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*v12 + 392LL))(v12, *(_QWORD *)(*v12 + 400LL));
  if ( !v13
    || (ChunkIndex = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v13 + 392LL))(
                       v13,
                       *(_QWORD *)(*(_QWORD *)v13 + 400LL)),
        !v14)
    || (ChunkIndex = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v14 + 392LL))(
                       v14,
                       *(_QWORD *)(*(_QWORD *)v14 + 400LL)),
        !v16)
    || (ChunkIndex = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v16 + 392LL))(
                       v16,
                       *(_QWORD *)(*(_QWORD *)v16 + 400LL)),
        (v23 = (_DWORD *)v12[7]) == nullptr) )
  {
LABEL_28:
    ChunkIndex = sub_63CF120(ChunkIndex, v6);
    goto LABEL_29;
  }
  if ( a1 )
  {
    ChunkIndex = sub_63CEFF8(a1, *(_QWORD *)(*(_QWORD *)v23 + 64LL));
    if ( !ChunkIndex )
      goto LABEL_30;
  }
  if ( (unsigned int)v10 < v23[6] )
  {
    v24 = &v23[2 * v10];
    *((_QWORD *)v24 + 4) = a1;
    sub_63CEE24(v24 + 8, (int)a1, v19, v20, v21, v22);
    *(_QWORD *)(v12[5] + 8 * v10) = v11;
    if ( a1 )
    {
      transform = UnityEngine_Component__get_transform(a1, nullptr);
      UnityEngine_Jobs_TransformAccessArray__Add((__int64)(v12 + 8), transform, nullptr);
      VLB_VLBEntityManager__UpdateEntityData(a0, v11, a1, 1, v26);
      return v11;
    }
    goto LABEL_28;
  }
LABEL_29:
  sub_63CF128(ChunkIndex, v6, v19, v20);
LABEL_30:
  v28 = sub_63CF144(ChunkIndex);
  v29 = (void *)sub_63CEFE4(v28, 0);
  VLB_SharedVLBEntityManager__Release(v29, v30, v31);
  return result;
}

