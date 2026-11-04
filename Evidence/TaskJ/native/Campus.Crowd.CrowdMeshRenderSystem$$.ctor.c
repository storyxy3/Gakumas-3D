// Campus.Crowd.CrowdMeshRenderSystem$$.ctor @ 0xddc7db8
void __fastcall Campus_Crowd_CrowdMeshRenderSystem___ctor(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 v7; // x1
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  __int64 v12; // x1
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x8
  __int64 v16; // x8
  void *v17; // x20
  void *v18; // x0
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  __int64 v23; // x0
  __int64 v24; // x1
  void *v25; // x21
  int vertexBufferTarget; // w0
  __int64 v27; // x1
  void *v28; // x0
  __int64 v29; // x0
  __int64 *v30; // x21
  int v31; // w2
  int v32; // w3
  int v33; // w4
  void *v34; // x5
  __int64 v35; // x0
  __int64 v36; // x1
  __int64 v37; // x24
  unsigned __int64 v38; // x22
  __int64 v39; // x23
  void *v40; // x0
  void *v41; // x0
  int v42; // w2
  int v43; // w3
  int v44; // w4
  void *v45; // x5
  __int64 v46; // x1
  int VertexBufferStride; // w21
  void *v48; // x0
  int vertexCount; // w22
  void *v50; // x20
  int v51; // w2
  int v52; // w3
  int v53; // w4
  void *v54; // x5
  void *v55; // x2
  void *VertexBuffer; // x20
  void *v57; // x21
  __int64 v58; // x0
  int v59; // w2
  int v60; // w3
  int v61; // w4
  void *v62; // x5
  __int128 v63; // q1
  __int128 v64; // q2
  __int128 v65; // q3
  void *v66; // x0
  void *v67; // x19
  int v68; // w1
  __int128 v69; // [xsp+0h] [xbp+0h] BYREF
  __int128 v70; // [xsp+10h] [xbp+10h]
  __int128 v71; // [xsp+20h] [xbp+20h]
  __int128 v72; // [xsp+30h] [xbp+30h]
  __int128 v73; // [xsp+40h] [xbp+40h]
  __int128 v74; // [xsp+50h] [xbp+50h]
  __int128 v75; // [xsp+60h] [xbp+60h]
  __int128 v76; // [xsp+70h] [xbp+70h]
  void *v77; // [xsp+80h] [xbp+80h] BYREF
  __int64 v78; // [xsp+88h] [xbp+88h]
  __int64 v79; // [xsp+98h] [xbp+98h] BYREF
  UnityEngine_Vector3_o v80; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Quaternion_o v81; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BD09 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&UnityEngine_GraphicsBuffer___TypeInfo);
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&UnityEngine_Graphics_TypeInfo);
    sub_63CEE78(&UnityEngine_Matrix4x4___TypeInfo);
    sub_63CEE78(&VL_VLMeshUtility_TypeInfo);
    sub_63CEE78(&StringLiteral___________________3);
    unk_F43BD09 = 1;
  }
  BYTE4(v79) = 0;
  System_Object___ctor(a0, nullptr);
  v5 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
  if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    v5 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
  }
  UnityEngine_Rendering_ProfilingScope___ctor(
    (__int64)&v79 + 4,
    nullptr,
    *(void **)(*(_QWORD *)(v5 + 184) + 40LL),
    nullptr);
  v77 = nullptr;
  v78 = (__int64)&v79 + 4;
  if ( !a1 )
  {
LABEL_32:
    v13 = sub_63CF120(v6, v7);
    goto LABEL_33;
  }
  v12 = *((_QWORD *)a1 + 3);
  *((_QWORD *)a0 + 2) = v12;
  sub_63CEE24((char *)a0 + 16, v12, v8, v9, v10, v11);
  v15 = *((_QWORD *)a1 + 8);
  if ( !v15 )
  {
LABEL_33:
    v13 = sub_63CF120(v13, v14);
    goto LABEL_34;
  }
  *((_DWORD *)a0 + 6) = *(_QWORD *)(v15 + 24);
  v16 = *((_QWORD *)a0 + 2);
  *(_QWORD *)((char *)a0 + 28) = *((_QWORD *)a1 + 9);
  if ( v16 )
  {
    v17 = *(void **)(v16 + 16);
    if ( !*(_DWORD *)(VL_VLMeshUtility_TypeInfo + 228LL) )
      sub_63CEFF4(VL_VLMeshUtility_TypeInfo);
    v18 = VL_VLMeshUtility__CopyMesh(v17, 0, nullptr);
    *((_QWORD *)a0 + 5) = v18;
    a1 = (char *)a0 + 40;
    sub_63CEE24((char *)a0 + 40, (int)v18, v19, v20, v21, v22);
    v25 = *((void **)a0 + 5);
    if ( !v25 )
      goto LABEL_35;
    vertexBufferTarget = UnityEngine_Mesh__get_vertexBufferTarget(*(void **)a1, nullptr);
    UnityEngine_Mesh__set_vertexBufferTarget(v25, vertexBufferTarget | 0x20, nullptr);
    v28 = *(void **)a1;
    if ( !*(_QWORD *)a1 )
      goto LABEL_36;
    if ( UnityEngine_Mesh__get_vertexBufferCount(v28, nullptr) == 4 )
    {
      v29 = sub_63CEF64(UnityEngine_GraphicsBuffer___TypeInfo, 4);
      *((_QWORD *)a0 + 7) = v29;
      v30 = (__int64 *)((char *)a0 + 56);
      sub_63CEE24((char *)a0 + 56, v29, v31, v32, v33, v34);
      v37 = *((_QWORD *)a0 + 7);
      if ( v37 )
      {
        v38 = 0;
        v39 = 32;
        while ( 1 )
        {
          v40 = *(void **)a1;
          if ( (__int64)v38 >= *(int *)(v37 + 24) )
          {
            if ( !v40 )
              goto LABEL_38;
            VertexBufferStride = UnityEngine_Mesh__GetVertexBufferStride(v40, 0, nullptr);
            v48 = *(void **)a1;
            if ( !*(_QWORD *)a1 )
              goto LABEL_39;
            vertexCount = UnityEngine_Mesh__get_vertexCount(v48, nullptr);
            v50 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
            UnityEngine_GraphicsBuffer___ctor_1(v50, 41, vertexCount, VertexBufferStride, nullptr);
            *((_QWORD *)a0 + 6) = v50;
            sub_63CEE24((char *)a0 + 48, (int)v50, v51, v52, v53, v54);
            VertexBuffer = Campus_Crowd_CrowdMeshRenderSystem__GetVertexBuffer(a0, 0, v55);
            v57 = *((void **)a0 + 6);
            if ( !*(_DWORD *)(UnityEngine_Graphics_TypeInfo + 228LL) )
              sub_63CEFF4(UnityEngine_Graphics_TypeInfo);
            UnityEngine_Graphics__CopyBuffer(VertexBuffer, v57, nullptr);
            v58 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 16);
            *((_QWORD *)a0 + 8) = v58;
            sub_63CEE24((char *)a0 + 64, v58, v59, v60, v61, v62);
            v80.x = 0.0;
            v80.z = 0.0;
            v80.y = 3.1416;
            v81 = UnityEngine_Quaternion__Internal_FromEulerRad(v80, nullptr);
            UnityEngine_Matrix4x4__Rotate((UnityEngine_Matrix4x4_o *)&v69, v81, nullptr);
            v63 = v70;
            a1 = v77;
            v64 = v71;
            v65 = v72;
            v73 = v69;
            v74 = v70;
            v75 = v71;
            v76 = v72;
            *(_OWORD *)((char *)a0 + 72) = v69;
            *(_OWORD *)((char *)a0 + 88) = v63;
            *(_OWORD *)((char *)a0 + 104) = v64;
            *(_OWORD *)((char *)a0 + 120) = v65;
            goto LABEL_28;
          }
          if ( !v40 )
            break;
          v41 = UnityEngine_Mesh__GetVertexBuffer(v40, v38, nullptr);
          if ( v38 >= *(unsigned int *)(v37 + 24) )
          {
            sub_63CF128(v41, v41, v42, v43);
            break;
          }
          *(_QWORD *)(v37 + 8 * v38 + 32) = v41;
          sub_63CEE24((void *)(v37 + v39), (int)v41, v42, v43, v44, v45);
          v37 = *v30;
          ++v38;
          v39 += 8;
          if ( !*v30 )
            goto LABEL_19;
        }
        v6 = sub_63CF120(v40, v36);
        goto LABEL_32;
      }
LABEL_19:
      sub_63CF120(v35, v36);
    }
    if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Debug_TypeInfo);
    UnityEngine_Debug__LogError(StringLiteral___________________3, nullptr);
    UnityEngine_Rendering_ProfilingScope__Dispose(v78, nullptr);
    return;
  }
LABEL_34:
  v23 = sub_63CF120(v13, v14);
LABEL_35:
  v28 = (void *)sub_63CF120(v23, v24);
LABEL_36:
  sub_63CF120(v28, v27);
  do
  {
    sub_63CF118(a1);
LABEL_38:
    v48 = (void *)sub_63CF120(v40, v36);
LABEL_39:
    v66 = (void *)sub_63CF120(v48, v46);
    v67 = v66;
    if ( v68 != 1 )
    {
      sub_E1B6FFC(&v77);
      sub_64BD8DC(v67);
    }
    a1 = *(void **)__cxa_begin_catch(v66);
    v77 = a1;
    __cxa_end_catch();
LABEL_28:
    UnityEngine_Rendering_ProfilingScope__Dispose(v78, nullptr);
  }
  while ( a1 );
}

