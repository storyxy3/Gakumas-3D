// Campus.Crowd.CrowdSystemData$$.ctor @ 0xddc99f4
void __fastcall Campus_Crowd_CrowdSystemData___ctor(
        void *a0,
        void *a1,
        int a2,
        int a3,
        void *a4,
        void *a5,
        UnityEngine_Vector4_o a6,
        void *a7)
{
  float w; // s8
  __int64 *v15; // x25
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  void *v20; // x24
  void *v21; // x0
  __int64 v22; // x1
  __int64 v23; // x8
  __int128 v24; // q1
  __int64 v25; // x8
  __int64 v26; // x8
  __int128 v27; // q0
  __int64 v28; // x8
  __int128 v29; // q1
  __int64 v30; // x9
  unsigned int v31; // w0
  __int64 v32; // x8
  void *v33; // x1
  __int64 v34; // x8
  void *v35; // x1
  __int64 v36; // x0
  int v37; // w23
  int v38; // w24
  void *v39; // x25
  int v40; // w2
  int v41; // w3
  int v42; // w4
  void *v43; // x5
  int v44; // w24
  void *v45; // x0
  int v46; // w2
  void *v47; // x22
  int v48; // w2
  int v49; // w3
  int v50; // w4
  void *v51; // x5
  void *v52; // x3
  _DWORD **v53; // x0
  void *v54; // x0
  void *v55; // x3
  void *v56; // x0
  void *v57; // x3
  void *v58; // x5
  void *v59; // x0
  void *v60; // x1
  __int128 v61; // [xsp+0h] [xbp+0h] BYREF
  __int128 v62; // [xsp+10h] [xbp+10h] BYREF
  __int128 v63; // [xsp+20h] [xbp+20h] BYREF
  __int128 v64; // [xsp+30h] [xbp+30h] BYREF
  __int128 v65; // [xsp+40h] [xbp+40h]
  __int64 v66; // [xsp+50h] [xbp+50h]
  __int128 v67; // [xsp+60h] [xbp+60h] BYREF
  __int64 v68; // [xsp+70h] [xbp+70h]

  w = a6.w;
  if ( (unk_F43BD20 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystemData_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GraphicsBuffer_SetData_PersonInfo___);
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_PersonInfo___);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_float4x4___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_OctreeInfo___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_PersonInfo___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int___ctor___1);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int___ctor__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD20 = 1;
  }
  v67 = 0u;
  v68 = 0;
  v66 = 0;
  v65 = 0u;
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 2) = a1;
  v15 = (__int64 *)((char *)a0 + 16);
  sub_63CEE24((char *)a0 + 16, (int)a1, v16, v17, v18, v19);
  v20 = *((void **)a0 + 2);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v21 = (void *)UnityEngine_Object__op_Inequality(v20, nullptr, nullptr);
  if ( ((unsigned __int8)v21 & 1) != 0 )
  {
    v23 = *v15;
    if ( !*v15
      || (v24 = *(_OWORD *)(v23 + 40),
          v25 = *(_QWORD *)(v23 + 56),
          v67 = v24,
          v68 = v25,
          UnityEngine_Bounds__Expand((UnityEngine_Bounds_o *)&v67, w * 4.0, nullptr),
          (v26 = *v15) == 0) )
    {
LABEL_21:
      v59 = (void *)sub_63CF120(v21, v22);
      Campus_Crowd_CrowdVolume__get_AnimationComponent(v59, v60);
      return;
    }
    if ( *(_DWORD *)(v26 + 24) )
    {
      v27 = *(_OWORD *)(v26 + 40);
      v28 = *(_QWORD *)(v26 + 56);
    }
    else
    {
      v27 = v67;
      v28 = v68;
    }
    v65 = v27;
    v29 = v67;
    v30 = v68;
    v66 = v28;
    *((_QWORD *)a0 + 24) = v28;
    *((_OWORD *)a0 + 11) = v27;
    *(_OWORD *)((char *)a0 + 152) = v29;
    *((_QWORD *)a0 + 21) = v30;
  }
  else
  {
    *((_QWORD *)a0 + 21) = 0;
    *((_QWORD *)a0 + 22) = 0;
    *((_QWORD *)a0 + 19) = 0;
    *((_QWORD *)a0 + 20) = 0;
    *((_QWORD *)a0 + 23) = 0;
    *((_QWORD *)a0 + 24) = 0;
  }
  v64 = 0u;
  Unity_Collections_NativeArray_int____ctor(
    (__int64)&v64,
    a2,
    4,
    1,
    (void *)Method_Unity_Collections_NativeArray_int___ctor___1);
  *((_OWORD *)a0 + 7) = v64;
  v31 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, nullptr);
  v63 = 0u;
  Unity_Collections_NativeReference_int____ctor(
    (__int64)&v63,
    v31,
    1,
    Method_Unity_Collections_NativeReference_int___ctor__);
  v32 = *((_QWORD *)a0 + 2);
  *((_OWORD *)a0 + 8) = v63;
  if ( !v32 )
    goto LABEL_21;
  v33 = *(void **)(v32 + 64);
  v62 = 0u;
  Unity_Collections_NativeArray_OctreeInfo____ctor_1(
    (__int64)&v62,
    v33,
    4,
    Method_Unity_Collections_NativeArray_OctreeInfo___ctor__);
  v34 = *((_QWORD *)a0 + 2);
  *((_OWORD *)a0 + 5) = v62;
  if ( !v34 )
    goto LABEL_21;
  v35 = *(void **)(v34 + 32);
  v61 = 0u;
  Unity_Collections_NativeArray_PersonInfo____ctor_1(
    (__int64)&v61,
    v35,
    4,
    Method_Unity_Collections_NativeArray_PersonInfo___ctor__);
  v36 = System_Runtime_InteropServices_Marshal_TypeInfo;
  *((_OWORD *)a0 + 4) = v61;
  v37 = *((_DWORD *)a0 + 18);
  if ( !*(_DWORD *)(v36 + 228) )
    sub_63CEFF4(v36);
  v38 = System_Runtime_InteropServices_Marshal__SizeOf_PersonInfo_(Method_System_Runtime_InteropServices_Marshal_SizeOf_PersonInfo___);
  v39 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v39, 16, v37, v38, nullptr);
  *((_QWORD *)a0 + 3) = v39;
  sub_63CEE24((char *)a0 + 24, (int)v39, v40, v41, v42, v43);
  v21 = *((void **)a0 + 3);
  if ( !v21 )
    goto LABEL_21;
  UnityEngine_GraphicsBuffer__SetData_PersonInfo_(v21, *((_QWORD *)a0 + 8), *((void **)a0 + 9));
  v44 = System_Runtime_InteropServices_Marshal__SizeOf_float4x4_(Method_System_Runtime_InteropServices_Marshal_SizeOf_float4x4___);
  v45 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  v46 = 8 * a3;
  v47 = v45;
  UnityEngine_GraphicsBuffer___ctor_1(v45, 16, v46, v44, nullptr);
  *((_QWORD *)a0 + 4) = v47;
  sub_63CEE24((char *)a0 + 32, (int)v47, v48, v49, v50, v51);
  v53 = (_DWORD **)Campus_Crowd_CrowdSystemData_TypeInfo;
  if ( !*(_DWORD *)(Campus_Crowd_CrowdSystemData_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Crowd_CrowdSystemData_TypeInfo);
    v53 = (_DWORD **)Campus_Crowd_CrowdSystemData_TypeInfo;
  }
  Campus_Crowd_CrowdSystemData__InitializeBytesBuffer(v53, *v53[23] * v37, (char *)a0 + 40, v52);
  Campus_Crowd_CrowdSystemData__InitializePersonIndexArray(v54, v37, (char *)a0 + 96, v55);
  Campus_Crowd_CrowdSystemData__InitializeBytesBuffer(v56, *((_DWORD *)a0 + 26), (char *)a0 + 48, v57);
  Campus_Crowd_CrowdSystemData__InitializedPenlightInfoBuffer(a0, (char *)a0 + 64, a4, a5, (char *)a0 + 56, v58);
}

