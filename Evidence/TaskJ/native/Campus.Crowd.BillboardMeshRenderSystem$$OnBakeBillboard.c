// Campus.Crowd.BillboardMeshRenderSystem$$OnBakeBillboard @ 0xddc7388
void __fastcall Campus_Crowd_BillboardMeshRenderSystem__OnBakeBillboard(void *a0, __int64 a1, void *a2, void *a3)
{
  _QWORD *v4; // x25
  __int64 v6; // x1
  void *v7; // x20
  __int64 v8; // x0
  int v9; // w9
  _OWORD *v10; // x8
  __int128 v11; // q1
  __int128 v12; // q2
  __int64 v13; // x8
  __int128 v14; // q1
  __int128 v15; // q2
  __int128 v16; // q0
  __int64 v17; // x8
  __int128 v18; // q0
  __int128 v19; // q1
  __int64 v20; // x8
  int v21; // w1
  int v22; // w2
  int v23; // w3
  __int64 v24; // x8
  int v25; // w24
  unsigned __int64 v26; // x21
  unsigned __int64 v27; // x9
  __int64 v28; // x8
  void *v29; // x22
  unsigned int *v30; // x5
  unsigned __int64 v31; // x8
  __int64 v32; // x9
  unsigned __int64 v33; // x10
  int v34; // w10
  __int128 *v35; // x10
  unsigned int *v36; // x11
  __int128 v37; // q0
  __int128 v38; // q2
  __int128 v39; // q3
  __int128 v40; // [xsp+0h] [xbp+0h] BYREF
  __int128 v41; // [xsp+10h] [xbp+10h]
  __int64 v42; // [xsp+20h] [xbp+20h]
  __int128 v43; // [xsp+30h] [xbp+30h] BYREF
  __int128 v44; // [xsp+40h] [xbp+40h]
  __int128 v45; // [xsp+50h] [xbp+50h]
  __int128 v46; // [xsp+60h] [xbp+60h]
  __int128 v47; // [xsp+70h] [xbp+70h] BYREF
  __int128 v48; // [xsp+80h] [xbp+80h]
  __int128 v49; // [xsp+90h] [xbp+90h]
  __int128 v50; // [xsp+A0h] [xbp+A0h]
  __int128 v51; // [xsp+B0h] [xbp+B0h]
  __int128 v52; // [xsp+C0h] [xbp+C0h]
  __int128 v53; // [xsp+D0h] [xbp+D0h]
  __int128 v54; // [xsp+E0h] [xbp+E0h]
  __int128 v55; // [xsp+F0h] [xbp+F0h]
  __int128 v56; // [xsp+100h] [xbp+100h]
  __int128 v57; // [xsp+110h] [xbp+110h]
  __int128 v58; // [xsp+120h] [xbp+120h]
  __int64 v59; // [xsp+138h] [xbp+138h] BYREF

  v59 = a1;
  if ( (unk_F43BD03 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
    unk_F43BD03 = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
  v7 = UnityEngine_Rendering_CommandBufferPool__Get(nullptr);
  if ( !unk_F4004F3 )
  {
    sub_63CEE78(&UnityEngine_Matrix4x4_TypeInfo);
    unk_F4004F3 = 1;
  }
  v8 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
  v9 = *(_DWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 228LL);
  v10 = *(_OWORD **)(UnityEngine_Matrix4x4_TypeInfo + 184LL);
  v11 = v10[5];
  v55 = v10[4];
  v56 = v11;
  v12 = v10[7];
  v57 = v10[6];
  v58 = v12;
  if ( !v9 )
  {
    sub_63CEFF4(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    v8 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
  }
  v13 = *(_QWORD *)(v8 + 184);
  v14 = *(_OWORD *)(v13 + 28);
  v15 = *(_OWORD *)(v13 + 44);
  v51 = *(_OWORD *)(v13 + 12);
  v52 = v14;
  v16 = *(_OWORD *)(v13 + 60);
  v53 = v15;
  v54 = v16;
  if ( !v7 )
    goto LABEL_29;
  v47 = v55;
  v48 = v56;
  v49 = v57;
  v50 = v58;
  v43 = v51;
  v44 = v52;
  v45 = v53;
  v46 = v54;
  UnityEngine_Rendering_CommandBuffer__SetViewProjectionMatrices(
    v7,
    (UnityEngine_Matrix4x4_o *)&v47,
    (UnityEngine_Matrix4x4_o *)&v43,
    nullptr);
  v17 = *((_QWORD *)a0 + 11);
  if ( !v17 )
    goto LABEL_29;
  v18 = *(_OWORD *)(v17 + 40);
  v19 = *(_OWORD *)(v17 + 56);
  v20 = *(_QWORD *)(v17 + 72);
  v21 = **(_DWORD **)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL);
  v40 = v18;
  v41 = v19;
  v42 = v20;
  UnityEngine_Rendering_CommandBuffer__SetGlobalTexture_1(v7, v21, (__int64)&v40, nullptr);
  v24 = *((_QWORD *)a0 + 17);
  if ( v24 )
  {
    v25 = 0;
    v4 = &UnityEngine_Rendering_ScriptableRenderContext_TypeInfo;
    v26 = 0;
    while ( 1 )
    {
      v27 = *(unsigned int *)(v24 + 24);
      if ( (__int64)v26 >= (int)v27 )
        break;
      if ( v26 >= v27 )
      {
LABEL_35:
        sub_63CF128(v8, v6, v22, v23);
        JUMPOUT(0xDDC7650);
      }
      v28 = *(_QWORD *)(v24 + 8 * v26 + 32);
      if ( v28 )
        v29 = *(void **)(v28 + 32);
      else
        v29 = nullptr;
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      v8 = UnityEngine_Object__op_Equality(v29, nullptr, nullptr);
      if ( (v8 & 1) == 0 )
      {
        v30 = *((unsigned int **)a0 + 3);
        if ( !v30 )
          goto LABEL_29;
        v31 = 0;
        v32 = 8;
        while ( 1 )
        {
          v33 = v30[6];
          if ( (__int64)v31 >= (int)v33 )
            break;
          if ( v31 >= v33 )
            goto LABEL_35;
          v34 = v25 + v31++;
          v35 = (__int128 *)(*((_QWORD *)a0 + 7) + ((__int64)v34 << 6));
          v36 = &v30[v32];
          v32 += 16;
          v37 = v35[3];
          v38 = *v35;
          v39 = v35[1];
          *((_OWORD *)v36 + 2) = v35[2];
          *((_OWORD *)v36 + 3) = v37;
          *(_OWORD *)v36 = v38;
          *((_OWORD *)v36 + 1) = v39;
          v30 = *((unsigned int **)a0 + 3);
          if ( !v30 )
            goto LABEL_29;
        }
        UnityEngine_Rendering_CommandBuffer__DrawMeshInstanced_2(v7, *((void **)a0 + 16), v26, v29, 0, v30, nullptr);
      }
      v24 = *((_QWORD *)a0 + 17);
      ++v26;
      v25 += 4;
      if ( !v24 )
        goto LABEL_29;
    }
  }
  else
  {
LABEL_29:
    sub_63CF120(v8, v6);
  }
  if ( !*(_DWORD *)(*v4 + 228LL) )
    sub_63CEFF4(*v4);
  UnityEngine_Rendering_ScriptableRenderContext__ExecuteCommandBuffer((__int64)&v59, v7, nullptr);
  if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
  UnityEngine_Rendering_CommandBufferPool__Release(v7, nullptr);
}

