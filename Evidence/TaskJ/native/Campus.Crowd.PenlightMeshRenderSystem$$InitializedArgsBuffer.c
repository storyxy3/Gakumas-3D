// Campus.Crowd.PenlightMeshRenderSystem$$InitializedArgsBuffer @ 0xddcbd58
void __fastcall Campus_Crowd_PenlightMeshRenderSystem__InitializedArgsBuffer(void *a0, void *a1, void *a2)
{
  unsigned int v5; // w21
  int v6; // w22
  void *v7; // x23
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  __int64 v12; // x1
  _DWORD *v13; // x21
  __int64 v14; // x22
  int v15; // w23
  __int64 IndexCount; // x0
  int v17; // w2
  int v18; // w3
  void *v19; // x8
  int v20; // w8
  _DWORD *v21; // x8
  void *v22; // x0
  int v23; // w1
  void *v24; // x2
  void *v25; // x3
  void *v26; // x4

  if ( (unk_F43BD35 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_int___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&uint___TypeInfo);
    unk_F43BD35 = 1;
  }
  v5 = 5 * *((_DWORD *)a0 + 8);
  if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
    sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
  v6 = System_Runtime_InteropServices_Marshal__SizeOf_int_(Method_System_Runtime_InteropServices_Marshal_SizeOf_int___);
  v7 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v7, 256, v5, v6, nullptr);
  *(_QWORD *)a1 = v7;
  sub_63CEE24(a1, (int)v7, v8, v9, v10, v11);
  v13 = (_DWORD *)sub_63CEF64(uint___TypeInfo, v5);
  if ( *((int *)a0 + 8) < 1 )
  {
LABEL_15:
    IndexCount = *(_QWORD *)a1;
    if ( *(_QWORD *)a1 )
    {
      UnityEngine_GraphicsBuffer__SetData((void *)IndexCount, v13, nullptr);
      return;
    }
  }
  else
  {
    v14 = 0;
    v15 = 3;
    while ( 1 )
    {
      IndexCount = *((_QWORD *)a0 + 3);
      if ( !IndexCount )
        break;
      IndexCount = UnityEngine_Mesh__GetIndexCount((void *)IndexCount, v14, nullptr);
      if ( !v13 )
        break;
      if ( (unsigned int)(v15 - 3) >= v13[6] )
        goto LABEL_18;
      v19 = *((void **)a0 + 3);
      v13[v15 + 5] = IndexCount;
      if ( !v19 )
        break;
      IndexCount = UnityEngine_Mesh__GetIndexStart(v19, v14, nullptr);
      if ( (unsigned int)(v15 - 1) >= v13[6] )
        goto LABEL_18;
      v20 = IndexCount;
      IndexCount = *((_QWORD *)a0 + 3);
      v13[v15 + 7] = v20;
      if ( !IndexCount )
        break;
      IndexCount = UnityEngine_Mesh__GetBaseVertex((void *)IndexCount, v14, nullptr);
      if ( (unsigned int)v15 >= v13[6] )
        goto LABEL_18;
      v21 = &v13[v15];
      ++v14;
      v15 += 5;
      v21[8] = IndexCount;
      if ( v14 >= *((int *)a0 + 8) )
        goto LABEL_15;
    }
  }
  IndexCount = sub_63CF120(IndexCount, v12);
LABEL_18:
  sub_63CF128(IndexCount, v12, v17, v18);
  Campus_Crowd_PenlightMeshRenderSystem__InitializeAppendBuffer(v22, v23, v24, v25, v26);
}

