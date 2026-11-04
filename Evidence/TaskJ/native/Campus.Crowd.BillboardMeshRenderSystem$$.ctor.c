// Campus.Crowd.BillboardMeshRenderSystem$$.ctor @ 0xddc6a54
void __fastcall Campus_Crowd_BillboardMeshRenderSystem___ctor(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x1
  void *BillboardMesh; // x0
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5
  __int64 v10; // x0
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  __int64 v15; // x0
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  __int64 v20; // x20
  __int64 v21; // x24
  int v22; // w25
  __int128 v23; // q0
  __int128 v24; // q2
  __int128 v25; // q3
  _OWORD *v26; // x8
  void *v27; // x4
  __int64 v28; // x0
  __int64 v29; // x20
  _DWORD *v30; // x21
  __int64 v31; // x0
  __int64 v32; // x1
  int v33; // w2
  int v34; // w3
  int v35; // w2
  int v36; // w3
  int v37; // w4
  void *v38; // x5
  __int64 v39; // x0
  int v40; // w4
  void *v41; // x5
  int v42; // w2
  int v43; // w3
  int v44; // w4
  void *v45; // x5
  __int64 v46; // x20
  _QWORD *v47; // x21
  int v48; // w2
  int v49; // w3
  int v50; // w4
  void *v51; // x5
  void *v52; // x22
  int v53; // w2
  int v54; // w3
  int v55; // w4
  void *v56; // x5
  void *v57; // x22
  int v58; // w2
  int v59; // w3
  int v60; // w4
  void *v61; // x5
  int v62; // w4
  void *v63; // x5
  int v64; // w2
  int v65; // w3
  int v66; // w4
  void *v67; // x5
  __int64 v68; // x0
  void *v69; // x0
  void *v70; // x1
  __int128 v71; // [xsp+0h] [xbp+0h] BYREF
  __int128 v72; // [xsp+10h] [xbp+10h] BYREF
  __int128 v73; // [xsp+20h] [xbp+20h]
  __int128 v74; // [xsp+30h] [xbp+30h]
  __int128 v75; // [xsp+40h] [xbp+40h]
  __int128 v76; // [xsp+50h] [xbp+50h] BYREF
  __int128 v77; // [xsp+60h] [xbp+60h]
  __int128 v78; // [xsp+70h] [xbp+70h]
  __int128 v79; // [xsp+80h] [xbp+80h]
  __int128 v80; // [xsp+90h] [xbp+90h]
  __int128 v81; // [xsp+A0h] [xbp+A0h]
  __int128 v82; // [xsp+B0h] [xbp+B0h]
  __int64 v83; // [xsp+C0h] [xbp+C0h]
  UnityEngine_Vector3_o v84; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Color_o v85; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Quaternion_o v86; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BD01 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_AttachmentDescriptor___TypeInfo);
    sub_63CEE78(&Method_Campus_Crowd_BillboardMeshRenderSystem_OnBakeBillboard__);
    sub_63CEE78(&bool___TypeInfo);
    sub_63CEE78(&VL_CustomRenderAction_TypeInfo);
    sub_63CEE78(&VL_CustomRenderPassData_TypeInfo);
    sub_63CEE78(&VL_CustomSubPassData___TypeInfo);
    sub_63CEE78(&VL_CustomSubPassData_TypeInfo);
    sub_63CEE78(&int___TypeInfo);
    sub_63CEE78(&UnityEngine_Matrix4x4___TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1);
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&StringLiteral_Bake_Billboard);
    unk_F43BD01 = 1;
  }
  v83 = 0;
  v79 = 0u;
  v80 = 0u;
  v81 = 0u;
  v82 = 0u;
  v78 = 0u;
  v76 = 0u;
  v77 = 0u;
  System_Object___ctor(a0, nullptr);
  BillboardMesh = Campus_Crowd_BillboardMeshRenderSystem__CreateBillboardMesh(v3, v4);
  *((_QWORD *)a0 + 2) = BillboardMesh;
  sub_63CEE24((char *)a0 + 16, (int)BillboardMesh, v6, v7, v8, v9);
  v10 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 4);
  *((_QWORD *)a0 + 3) = v10;
  sub_63CEE24((char *)a0 + 24, v10, v11, v12, v13, v14);
  v15 = sub_63CEF64(UnityEngine_Matrix4x4___TypeInfo, 32);
  *((_QWORD *)a0 + 4) = v15;
  sub_63CEE24((char *)a0 + 32, v15, v16, v17, v18, v19);
  v72 = 0u;
  Unity_Collections_NativeArray_Matrix4x4____ctor(
    (__int64)&v72,
    4,
    4,
    1,
    Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1);
  *(_OWORD *)((char *)a0 + 40) = v72;
  if ( *((int *)a0 + 12) >= 1 )
  {
    v20 = 0;
    v21 = 0;
    v22 = 180;
    do
    {
      v84.z = 0.0;
      v84.y = (float)v22 * 0.017453;
      v84.x = 0.0;
      v86 = UnityEngine_Quaternion__Internal_FromEulerRad(v84, nullptr);
      UnityEngine_Matrix4x4__Rotate((UnityEngine_Matrix4x4_o *)&v72, v86, nullptr);
      v23 = v75;
      v24 = v72;
      v25 = v73;
      ++v21;
      v26 = (_OWORD *)(*((_QWORD *)a0 + 5) + v20);
      v22 -= 90;
      v20 += 64;
      v26[2] = v74;
      v26[3] = v23;
      *v26 = v24;
      v26[1] = v25;
    }
    while ( v21 < *((int *)a0 + 12) );
  }
  v72 = 0u;
  Unity_Collections_NativeArray_Matrix4x4____ctor(
    (__int64)&v72,
    32,
    4,
    1,
    Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1);
  v27 = Method_Unity_Collections_NativeArray_Matrix4x4___ctor___1;
  *(_OWORD *)((char *)a0 + 56) = v72;
  v71 = 0u;
  Unity_Collections_NativeArray_Matrix4x4____ctor((__int64)&v71, 32, 4, 1, v27);
  v28 = VL_CustomRenderPassData_TypeInfo;
  *(_OWORD *)((char *)a0 + 72) = v71;
  v29 = sub_63CF110(v28);
  VL_CustomRenderPassData___ctor((void *)v29, nullptr);
  v30 = (_DWORD *)sub_63CEF64(UnityEngine_Rendering_AttachmentDescriptor___TypeInfo, 2);
  UnityEngine_Rendering_AttachmentDescriptor___ctor((__int64)&v76, 8, nullptr);
  UnityEngine_Rendering_AttachmentDescriptor__set_loadAction((__int64)&v76, 1, nullptr);
  UnityEngine_Rendering_AttachmentDescriptor__set_storeAction((__int64)&v76, 0, nullptr);
  v85.r = 0.0;
  v85.g = 0.0;
  v85.b = 0.0;
  v85.a = 0.0;
  UnityEngine_Rendering_AttachmentDescriptor__set_clearColor((__int64)&v76, v85, nullptr);
  if ( !v30 )
    goto LABEL_17;
  if ( !v30[6] )
    goto LABEL_18;
  memmove(v30 + 8, &v76, 0x78u);
  UnityEngine_Rendering_AttachmentDescriptor___ctor((__int64)&v76, 90, nullptr);
  UnityEngine_Rendering_AttachmentDescriptor__set_loadAction((__int64)&v76, 1, nullptr);
  UnityEngine_Rendering_AttachmentDescriptor__set_storeAction((__int64)&v76, 3, nullptr);
  if ( (v30[6] & 0xFFFFFFFE) == 0 )
    goto LABEL_18;
  v31 = (__int64)memmove(v30 + 38, &v76, 0x78u);
  if ( !v29 )
    goto LABEL_17;
  *(_QWORD *)(v29 + 32) = v30;
  sub_63CEE24((void *)(v29 + 32), (int)v30, v35, v36, v37, v38);
  v39 = bool___TypeInfo;
  *(_DWORD *)(v29 + 40) = 1;
  v31 = sub_63CEF64(v39, 2);
  if ( !v31 )
    goto LABEL_17;
  v32 = v31;
  if ( (*(_DWORD *)(v31 + 24) & 0xFFFFFFFE) == 0 )
  {
LABEL_18:
    sub_63CF128(v31, v32, v33, v34);
    goto LABEL_19;
  }
  *(_BYTE *)(v31 + 33) = 1;
  *(_QWORD *)(v29 + 48) = v31;
  sub_63CEE24((void *)(v29 + 48), v31, v33, v34, v40, v41);
  *((_QWORD *)a0 + 14) = v29;
  sub_63CEE24((char *)a0 + 112, v29, v42, v43, v44, v45);
  v46 = sub_63CEF64(VL_CustomSubPassData___TypeInfo, 1);
  v47 = (_QWORD *)sub_63CF110(VL_CustomSubPassData_TypeInfo);
  VL_CustomSubPassData___ctor(v47, nullptr);
  v31 = sub_63CEF64(int___TypeInfo, 1);
  if ( !v47 )
    goto LABEL_17;
  v47[2] = v31;
  sub_63CEE24(v47 + 2, v31, v48, v49, v50, v51);
  v52 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v52, StringLiteral_Bake_Billboard, nullptr);
  v47[6] = v52;
  sub_63CEE24(v47 + 6, (int)v52, v53, v54, v55, v56);
  v57 = (void *)sub_63CF110(VL_CustomRenderAction_TypeInfo);
  VL_CustomRenderAction___ctor(v57, a0, Method_Campus_Crowd_BillboardMeshRenderSystem_OnBakeBillboard__, nullptr);
  v47[5] = v57;
  sub_63CEE24(v47 + 5, (int)v57, v58, v59, v60, v61);
  if ( !v46 )
  {
LABEL_17:
    v31 = sub_63CF120(v31, v32);
    goto LABEL_18;
  }
  v31 = sub_63CEFF8(v47, *(_QWORD *)(*(_QWORD *)v46 + 64LL));
  if ( v31 )
  {
    if ( *(_DWORD *)(v46 + 24) )
    {
      *(_QWORD *)(v46 + 32) = v47;
      sub_63CEE24((void *)(v46 + 32), (int)v47, v33, v34, v62, v63);
      *((_QWORD *)a0 + 15) = v46;
      sub_63CEE24((char *)a0 + 120, v46, v64, v65, v66, v67);
      return;
    }
    goto LABEL_18;
  }
LABEL_19:
  v68 = sub_63CF144(v31);
  v69 = (void *)sub_63CEFE4(v68, 0);
  Campus_Crowd_BillboardMeshRenderSystem__CreateBillboardMesh(v69, v70);
}

