// Campus.Crowd.BillboardMeshRenderSystem$$BakeBillboard @ 0xddc7174
void __fastcall Campus_Crowd_BillboardMeshRenderSystem__BakeBillboard(
        void *a0,
        __int64 a1,
        void *a2,
        void *a3,
        void *a4,
        void *a5)
{
  __int64 v6; // x26
  __int64 v7; // x29
  _QWORD *v8; // x25
  int v14; // w8
  bool v15; // w0
  int v16; // w8
  int v17; // w2
  __int64 v18; // x24
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  int v23; // w2
  int v24; // w3
  int v25; // w4
  void *v26; // x5
  __int64 v27; // x0
  __int64 v28; // x1
  int v29; // w2
  int v30; // w3
  __int64 v31; // x9
  int v32; // w10
  __int64 v33; // x8
  __int64 v34; // x9
  __int128 v35; // q0
  __int128 v36; // q1
  __int64 v37; // x9
  __int64 v38; // x30
  __int64 v39; // x0
  __int64 v40; // x19
  __int64 v41; // x1
  __int64 v42; // x1
  void *v43; // x20
  __int64 v44; // x0
  int v45; // w9
  _OWORD *v46; // x8
  __int128 v47; // q1
  __int128 v48; // q2
  __int64 v49; // x8
  __int128 v50; // q1
  __int128 v51; // q2
  __int128 v52; // q0
  __int64 v53; // x8
  __int128 v54; // q0
  __int128 v55; // q1
  __int64 v56; // x8
  int v57; // w1
  int v58; // w2
  int v59; // w3
  __int64 v60; // x8
  int v61; // w24
  unsigned __int64 v62; // x21
  unsigned __int64 v63; // x9
  __int64 v64; // x8
  void *v65; // x22
  unsigned int *v66; // x5
  unsigned __int64 v67; // x8
  __int64 v68; // x9
  unsigned __int64 v69; // x10
  int v70; // w10
  __int128 *v71; // x10
  unsigned int *v72; // x11
  __int128 v73; // q0
  __int128 v74; // q2
  __int128 v75; // q3
  __int128 v76; // [xsp+0h] [xbp+0h] BYREF
  __int128 v77; // [xsp+10h] [xbp+10h]
  __int64 v78; // [xsp+20h] [xbp+20h]
  __int128 v79; // [xsp+30h] [xbp+30h] BYREF
  __int128 v80; // [xsp+40h] [xbp+40h]
  __int128 v81; // [xsp+50h] [xbp+50h]
  __int128 v82; // [xsp+60h] [xbp+60h]
  __int128 v83; // [xsp+70h] [xbp+70h] BYREF
  __int128 v84; // [xsp+80h] [xbp+80h]
  __int128 v85; // [xsp+90h] [xbp+90h]
  __int128 v86; // [xsp+A0h] [xbp+A0h]
  __int128 v87; // [xsp+B0h] [xbp+B0h]
  __int128 v88; // [xsp+C0h] [xbp+C0h]
  __int128 v89; // [xsp+D0h] [xbp+D0h]
  __int128 v90; // [xsp+E0h] [xbp+E0h]
  __int128 v91; // [xsp+F0h] [xbp+F0h]
  __int128 v92; // [xsp+100h] [xbp+100h]
  __int128 v93; // [xsp+110h] [xbp+110h]
  __int128 v94; // [xsp+120h] [xbp+120h]
  __int64 v95; // [xsp+138h] [xbp+138h] BYREF
  __int64 v96; // [xsp+140h] [xbp+140h]
  __int64 v97; // [xsp+148h] [xbp+148h]
  __int64 v98; // [xsp+150h] [xbp+150h]
  __int64 v99; // [xsp+158h] [xbp+158h]
  __int64 v100; // [xsp+160h] [xbp+160h]
  char *v101; // [xsp+168h] [xbp+168h]
  void *v102; // [xsp+170h] [xbp+170h]
  void *v103; // [xsp+178h] [xbp+178h]
  __int64 v104; // [xsp+180h] [xbp+180h]
  void *v105; // [xsp+188h] [xbp+188h]

  v8 = (_QWORD *)&unk_F43B000;
  if ( (unk_F43BD02 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_Universal_RenderingUtils_TypeInfo);
    sub_63CEE78(&StringLiteral__BillboardColorBuffer);
    sub_63CEE78(&StringLiteral__BillboardDepthBuffer);
    unk_F43BD02 = 1;
  }
  LODWORD(v82) = 0;
  v14 = *(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL);
  v80 = 0u;
  v81 = 0u;
  v79 = 0u;
  if ( !v14 )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v15 = UnityEngine_Object__op_Equality(a3, nullptr, nullptr);
  if ( a4 )
  {
    if ( !v15 )
    {
      v16 = *((_DWORD *)a0 + 26);
      if ( v16 >= 1 )
      {
        v17 = *((_DWORD *)a0 + 27);
        if ( v17 >= 1 )
        {
          v18 = (unsigned int)(32 * v16);
          UnityEngine_RenderTextureDescriptor___ctor_7((__int64)&v79, 32 * v16, v17, 8, 0, nullptr);
          if ( !*(_DWORD *)(UnityEngine_Rendering_Universal_RenderingUtils_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Rendering_Universal_RenderingUtils_TypeInfo);
          UnityEngine_Rendering_Universal_RenderingUtils__ReAllocateIfNeeded(
            (char *)a0 + 88,
            &v79,
            0,
            1,
            0,
            1,
            0.0,
            StringLiteral__BillboardColorBuffer,
            nullptr);
          UnityEngine_RenderTextureDescriptor__set_graphicsFormat((__int64)&v79, 0, nullptr);
          HIDWORD(v80) = 90;
          UnityEngine_Rendering_Universal_RenderingUtils__ReAllocateIfNeeded(
            (char *)a0 + 96,
            &v79,
            0,
            1,
            0,
            1,
            0.0,
            StringLiteral__BillboardDepthBuffer,
            nullptr);
          *((_QWORD *)a0 + 16) = a3;
          sub_63CEE24((char *)a0 + 128, (int)a3, v19, v20, v21, v22);
          *((_QWORD *)a0 + 17) = a4;
          sub_63CEE24((char *)a0 + 136, (int)a4, v23, v24, v25, v26);
          v31 = *((_QWORD *)a0 + 14);
          if ( v31
            && (v32 = *((_DWORD *)a0 + 27),
                v33 = *(_QWORD *)(v31 + 32),
                *(_DWORD *)(v31 + 16) = v18,
                *(_DWORD *)(v31 + 20) = v32,
                v33)
            && (v34 = *((_QWORD *)a0 + 11)) != 0 )
          {
            if ( *(_DWORD *)(v33 + 24) )
            {
              v35 = *(_OWORD *)(v34 + 40);
              v36 = *(_OWORD *)(v34 + 56);
              v37 = *(_QWORD *)(v34 + 72);
              v76 = v35;
              v77 = v36;
              v78 = v37;
              UnityEngine_Rendering_AttachmentDescriptor__set_loadStoreTarget(v33 + 32, (__int64)&v76, nullptr);
              VL_CustomRenderPassUtility__Execute(a1, a2, *((void **)a0 + 14), *((void **)a0 + 15), nullptr);
              return;
            }
          }
          else
          {
            v27 = sub_63CF120(v27, v28);
          }
          sub_63CF128(v27, v28, v29, v30);
          v96 = v7;
          v97 = v38;
          v98 = v6;
          v99 = 256094208;
          v100 = v18;
          v101 = (char *)a0 + 136;
          v102 = a4;
          v103 = a0;
          v104 = a1;
          v105 = a2;
          v40 = v39;
          v95 = v41;
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
          v43 = UnityEngine_Rendering_CommandBufferPool__Get(nullptr);
          if ( !unk_F4004F3 )
          {
            sub_63CEE78(&UnityEngine_Matrix4x4_TypeInfo);
            unk_F4004F3 = 1;
          }
          v44 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
          v45 = *(_DWORD *)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 228LL);
          v46 = *(_OWORD **)(UnityEngine_Matrix4x4_TypeInfo + 184LL);
          v47 = v46[5];
          v91 = v46[4];
          v92 = v47;
          v48 = v46[7];
          v93 = v46[6];
          v94 = v48;
          if ( !v45 )
          {
            sub_63CEFF4(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
            v44 = Campus_Crowd_BillboardMeshRenderSystem_TypeInfo;
          }
          v49 = *(_QWORD *)(v44 + 184);
          v50 = *(_OWORD *)(v49 + 28);
          v51 = *(_OWORD *)(v49 + 44);
          v87 = *(_OWORD *)(v49 + 12);
          v88 = v50;
          v52 = *(_OWORD *)(v49 + 60);
          v89 = v51;
          v90 = v52;
          if ( !v43 )
            goto LABEL_46;
          v83 = v91;
          v84 = v92;
          v85 = v93;
          v86 = v94;
          v79 = v87;
          v80 = v88;
          v81 = v89;
          v82 = v90;
          UnityEngine_Rendering_CommandBuffer__SetViewProjectionMatrices(
            v43,
            (UnityEngine_Matrix4x4_o *)&v83,
            (UnityEngine_Matrix4x4_o *)&v79,
            nullptr);
          v53 = *(_QWORD *)(v40 + 88);
          if ( !v53 )
            goto LABEL_46;
          v54 = *(_OWORD *)(v53 + 40);
          v55 = *(_OWORD *)(v53 + 56);
          v56 = *(_QWORD *)(v53 + 72);
          v57 = **(_DWORD **)(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo + 184LL);
          v76 = v54;
          v77 = v55;
          v78 = v56;
          UnityEngine_Rendering_CommandBuffer__SetGlobalTexture_1(v43, v57, (__int64)&v76, nullptr);
          v60 = *(_QWORD *)(v40 + 136);
          if ( v60 )
          {
            v61 = 0;
            v8 = &UnityEngine_Rendering_ScriptableRenderContext_TypeInfo;
            v62 = 0;
            while ( 1 )
            {
              v63 = *(unsigned int *)(v60 + 24);
              if ( (__int64)v62 >= (int)v63 )
                break;
              if ( v62 >= v63 )
              {
LABEL_52:
                sub_63CF128(v44, v42, v58, v59);
                JUMPOUT(0xDDC7650);
              }
              v64 = *(_QWORD *)(v60 + 8 * v62 + 32);
              if ( v64 )
                v65 = *(void **)(v64 + 32);
              else
                v65 = nullptr;
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              v44 = UnityEngine_Object__op_Equality(v65, nullptr, nullptr);
              if ( (v44 & 1) == 0 )
              {
                v66 = *(unsigned int **)(v40 + 24);
                if ( !v66 )
                  goto LABEL_46;
                v67 = 0;
                v68 = 8;
                while ( 1 )
                {
                  v69 = v66[6];
                  if ( (__int64)v67 >= (int)v69 )
                    break;
                  if ( v67 >= v69 )
                    goto LABEL_52;
                  v70 = v61 + v67++;
                  v71 = (__int128 *)(*(_QWORD *)(v40 + 56) + ((__int64)v70 << 6));
                  v72 = &v66[v68];
                  v68 += 16;
                  v73 = v71[3];
                  v74 = *v71;
                  v75 = v71[1];
                  *((_OWORD *)v72 + 2) = v71[2];
                  *((_OWORD *)v72 + 3) = v73;
                  *(_OWORD *)v72 = v74;
                  *((_OWORD *)v72 + 1) = v75;
                  v66 = *(unsigned int **)(v40 + 24);
                  if ( !v66 )
                    goto LABEL_46;
                }
                UnityEngine_Rendering_CommandBuffer__DrawMeshInstanced_2(
                  v43,
                  *(void **)(v40 + 128),
                  v62,
                  v65,
                  0,
                  v66,
                  nullptr);
              }
              v60 = *(_QWORD *)(v40 + 136);
              ++v62;
              v61 += 4;
              if ( !v60 )
                goto LABEL_46;
            }
          }
          else
          {
LABEL_46:
            sub_63CF120(v44, v42);
          }
          if ( !*(_DWORD *)(*v8 + 228LL) )
            sub_63CEFF4(*v8);
          UnityEngine_Rendering_ScriptableRenderContext__ExecuteCommandBuffer((__int64)&v95, v43, nullptr);
          if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
          UnityEngine_Rendering_CommandBufferPool__Release(v43, nullptr);
        }
      }
    }
  }
}

