// Campus.Crowd.PenlightMeshRenderSystem$$.ctor @ 0xddc9754
void __fastcall Campus_Crowd_PenlightMeshRenderSystem___ctor(void *a0, void *a1, int a2, void *a3)
{
  char *v7; // x21
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  void *v12; // x0
  __int64 v13; // x1
  void *v14; // x22
  void *v15; // x0
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  void *v20; // x22
  int vertexBufferTarget; // w0
  __int64 v22; // x8
  void *v23; // x2
  __int64 v24; // x0
  __int64 *v25; // x21
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5
  void *v30; // x0
  void *v31; // x4
  unsigned __int64 v32; // x22
  __int64 i; // x23
  int v34; // w2
  int v35; // w3
  int v36; // w4
  void *v37; // x5
  __int64 v38; // x8
  int v39; // w1
  void *v40; // x0
  void *v41; // x1
  void *v42; // x2
  __int64 v43; // [xsp+0h] [xbp+0h] BYREF
  __int64 v44; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43BD30 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&UnityEngine_GraphicsBuffer___TypeInfo);
    sub_63CEE78(&VL_VLMeshUtility_TypeInfo);
    sub_63CEE78(&StringLiteral___________________3);
    unk_F43BD30 = 1;
  }
  v43 = 0;
  v44 = 0;
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 2) = a1;
  v7 = (char *)a0 + 16;
  sub_63CEE24((char *)a0 + 16, (int)a1, v8, v9, v10, v11);
  if ( *((_QWORD *)a0 + 2) )
  {
    v14 = *(void **)(*((_QWORD *)a0 + 2) + 16LL);
    if ( !*(_DWORD *)(VL_VLMeshUtility_TypeInfo + 228LL) )
      sub_63CEFF4(VL_VLMeshUtility_TypeInfo);
    v15 = VL_VLMeshUtility__CopyMesh(v14, 0, nullptr);
    *((_QWORD *)a0 + 3) = v15;
    sub_63CEE24((char *)a0 + 24, (int)v15, v16, v17, v18, v19);
    v20 = *((void **)a0 + 3);
    if ( v20 )
    {
      vertexBufferTarget = UnityEngine_Mesh__get_vertexBufferTarget(*((void **)a0 + 3), nullptr);
      UnityEngine_Mesh__set_vertexBufferTarget(v20, vertexBufferTarget | 0x20, nullptr);
      if ( *(_QWORD *)v7 )
      {
        v22 = *(_QWORD *)(*(_QWORD *)v7 + 24LL);
        if ( v22 )
        {
          v12 = *((void **)a0 + 3);
          *((_DWORD *)a0 + 8) = *(_QWORD *)(v22 + 24);
          if ( v12 )
          {
            if ( UnityEngine_Mesh__get_vertexBufferCount(v12, nullptr) != 2 )
            {
              if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Debug_TypeInfo);
              UnityEngine_Debug__LogError(StringLiteral___________________3, nullptr);
              return;
            }
            Campus_Crowd_PenlightMeshRenderSystem__InitializedArgsBuffer(a0, (char *)a0 + 40, v23);
            v24 = sub_63CEF64(UnityEngine_GraphicsBuffer___TypeInfo, *((unsigned int *)a0 + 8));
            *((_QWORD *)a0 + 6) = v24;
            v25 = (__int64 *)((char *)a0 + 48);
            sub_63CEE24((char *)a0 + 48, v24, v26, v27, v28, v29);
            if ( *((int *)a0 + 8) < 1 )
              return;
            v32 = 0;
            for ( i = 32; ; i += 8 )
            {
              Campus_Crowd_PenlightMeshRenderSystem__InitializeAppendBuffer(v30, a2, &v44, &v43, v31);
              v38 = *v25;
              if ( !*v25 )
                break;
              if ( v32 >= *(unsigned int *)(v38 + 24) )
                goto LABEL_21;
              v39 = v44;
              *(_QWORD *)(v38 + i) = v44;
              sub_63CEE24((void *)(v38 + i), v39, v34, v35, v36, v37);
              if ( (__int64)++v32 >= *((int *)a0 + 8) )
                return;
            }
          }
        }
      }
    }
  }
  v12 = (void *)sub_63CF120(v12, v13);
LABEL_21:
  sub_63CF128(v12, v13, v34, v35);
  Campus_Crowd_CrowdSystemData__EqualData(v40, v41, v42);
}

