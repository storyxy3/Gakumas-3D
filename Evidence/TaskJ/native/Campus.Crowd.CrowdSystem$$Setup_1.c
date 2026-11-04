// 0xddc92f8 @ 0xddc92f8
void __fastcall Campus_Crowd_CrowdSystem__Setup_1(void *a0, void *a1, void *a2, bool a3, void *a4)
{
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x8
  __int64 IsNullOrEmpty_object; // x0
  void *v14; // x1
  __int64 v15; // x8
  __int64 v16; // x9
  __int64 v17; // x10
  __int64 v18; // x11
  void *v19; // x25
  void *v20; // x26
  int v21; // w23
  int v22; // w24
  int v23; // w27
  __int64 v24; // x9
  void *v25; // x28
  void *v26; // x2
  int v27; // w2
  int v28; // w3
  int v29; // w4
  void *v30; // x5
  void *v31; // x28
  void *v32; // x1
  int v33; // w2
  int v34; // w3
  int v35; // w4
  void *v36; // x5
  __int64 v37; // x8
  void *v38; // x28
  bool v39; // w0
  void *v40; // x1
  void *v41; // x2
  void *v42; // x29
  void *v43; // x28
  void *v44; // x3
  int v45; // w2
  int v46; // w3
  int v47; // w4
  void *v48; // x5
  void *v49; // x0
  float v50; // s8
  float v51; // s9
  float v52; // s10
  float v53; // s11
  void *v54; // x0
  void *v55; // x21
  void *v56; // x6
  int v57; // w2
  int v58; // w3
  int v59; // w4
  void *v60; // x5
  void *v61; // x0
  void *v62; // x19
  int v63; // w1
  __int64 v64; // x19
  void *v65; // x0
  __int64 v66; // [xsp+8h] [xbp+8h] BYREF
  __int64 v67; // [xsp+10h] [xbp+10h]
  __int64 v68; // [xsp+18h] [xbp+18h] BYREF
  UnityEngine_Vector4_o v69; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BD14 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdSystem_TypeInfo);
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_CrowdModelData_SubMeshData___);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
    unk_F43BD14 = 1;
  }
  v9 = Campus_Crowd_CrowdSystem_TypeInfo;
  BYTE4(v68) = 0;
  if ( !*(_DWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Crowd_CrowdSystem_TypeInfo);
    v9 = Campus_Crowd_CrowdSystem_TypeInfo;
  }
  UnityEngine_Rendering_ProfilingScope___ctor(
    (__int64)&v68 + 4,
    nullptr,
    *(void **)(*(_QWORD *)(v9 + 184) + 16LL),
    nullptr);
  v66 = 0;
  v67 = (__int64)&v68 + 4;
  if ( !a1 )
  {
    IsNullOrEmpty_object = sub_63CF120(v10, v11);
LABEL_37:
    IsNullOrEmpty_object = sub_63CF120(IsNullOrEmpty_object, v14);
    goto LABEL_38;
  }
  v12 = *((_QWORD *)a1 + 3);
  if ( !v12
    || (IsNullOrEmpty_object = Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_object_(
                                 *(void **)(v12 + 24),
                                 Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_CrowdModelData_SubMeshData___),
        (IsNullOrEmpty_object & 1) != 0) )
  {
LABEL_34:
    UnityEngine_Rendering_ProfilingScope__Dispose((__int64)&v68 + 4, nullptr);
    return;
  }
  v15 = *((_QWORD *)a1 + 3);
  if ( !v15 )
    goto LABEL_37;
  v16 = *(_QWORD *)(v15 + 24);
  if ( !v16 )
  {
LABEL_38:
    IsNullOrEmpty_object = sub_63CF120(IsNullOrEmpty_object, v14);
    goto LABEL_39;
  }
  v17 = *((_QWORD *)a1 + 8);
  if ( !v17 )
  {
LABEL_39:
    IsNullOrEmpty_object = sub_63CF120(IsNullOrEmpty_object, v14);
    goto LABEL_40;
  }
  if ( !a2 )
  {
LABEL_40:
    IsNullOrEmpty_object = sub_63CF120(IsNullOrEmpty_object, v14);
    goto LABEL_41;
  }
  v18 = *((_QWORD *)a2 + 4);
  if ( v18 )
  {
    v19 = *((void **)a1 + 5);
    v20 = *((void **)a1 + 6);
    v21 = *(_DWORD *)(v16 + 24);
    v22 = *(_DWORD *)(v17 + 24);
    v23 = *(_DWORD *)(v18 + 24);
    if ( (a3 || (v24 = *((_QWORD *)a0 + 7)) == 0 || *(_QWORD *)(v24 + 16) != v15)
      && (Campus_Crowd_CrowdSystem__DisposeCrowdMeshRenderSystem(a0, v14),
          v25 = (void *)sub_63CF110(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo),
          Campus_Crowd_CrowdMeshRenderSystem___ctor(v25, a1, v26),
          *((_QWORD *)a0 + 7) = v25,
          sub_63CEE24((char *)a0 + 56, (int)v25, v27, v28, v29, v30),
          a3)
      || !*((_QWORD *)a0 + 8) )
    {
      Campus_Crowd_CrowdSystem__DisposeBillboardMeshRenderSystem(a0, v14);
      v31 = (void *)sub_63CF110(Campus_Crowd_BillboardMeshRenderSystem_TypeInfo);
      Campus_Crowd_BillboardMeshRenderSystem___ctor(v31, v32);
      *((_QWORD *)a0 + 8) = v31;
      sub_63CEE24((char *)a0 + 64, (int)v31, v33, v34, v35, v36);
    }
    v37 = *((_QWORD *)a1 + 4);
    if ( v37 )
      v38 = *(void **)(v37 + 16);
    else
      v38 = nullptr;
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    v39 = UnityEngine_Object__op_Inequality(v38, nullptr, nullptr);
    if ( !v39 || a3 )
    {
      if ( v39 )
      {
LABEL_29:
        Campus_Crowd_CrowdSystem__DisposePenlightMeshRenderSystem(a0, v40);
        v42 = *((void **)a1 + 4);
        v43 = (void *)sub_63CF110(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
        Campus_Crowd_PenlightMeshRenderSystem___ctor(v43, v42, v23, v44);
        *((_QWORD *)a0 + 9) = v43;
        sub_63CEE24((char *)a0 + 72, (int)v43, v45, v46, v47, v48);
      }
    }
    else if ( !*((_QWORD *)a0 + 9) )
    {
      goto LABEL_29;
    }
    if ( a3 || (v49 = *((void **)a0 + 10)) == nullptr || !Campus_Crowd_CrowdSystemData__EqualData(v49, a2, v41) )
    {
      Campus_Crowd_CrowdSystem__DisposeCrowdSystemData(a0, v40);
      v50 = *((float *)a1 + 26);
      v51 = *((float *)a1 + 27);
      v52 = *((float *)a1 + 28);
      v53 = *((float *)a1 + 29);
      v54 = (void *)sub_63CF110(Campus_Crowd_CrowdSystemData_TypeInfo);
      v69.x = v50;
      v69.y = v51;
      v69.z = v52;
      v69.w = v53;
      v55 = v54;
      Campus_Crowd_CrowdSystemData___ctor(v54, a2, v21, v22, v19, v20, v69, v56);
      *((_QWORD *)a0 + 10) = v55;
      sub_63CEE24((char *)a0 + 80, (int)v55, v57, v58, v59, v60);
    }
    goto LABEL_34;
  }
LABEL_41:
  v61 = (void *)sub_63CF120(IsNullOrEmpty_object, v14);
  v62 = v61;
  if ( v63 != 1 )
    goto LABEL_44;
  v64 = *(_QWORD *)__cxa_begin_catch(v61);
  v66 = v64;
  __cxa_end_catch();
  UnityEngine_Rendering_ProfilingScope__Dispose(v67, nullptr);
  if ( v64 )
  {
    sub_63CF118(v64);
    v62 = v65;
LABEL_44:
    sub_E1B6FFC(&v66);
    sub_64BD8DC(v62);
  }
}

