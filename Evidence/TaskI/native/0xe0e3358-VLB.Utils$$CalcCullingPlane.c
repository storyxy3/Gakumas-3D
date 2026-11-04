// 0xe0e3358 @ 0xe0e3358
void __fastcall VLB_Utils__CalcCullingPlane(__int64 a0, UnityEngine_Matrix4x4_o *a1, void *a2)
{
  void *v5; // x0
  void *Plane; // x0
  int v7; // s0
  int v8; // s1
  int v9; // s2
  int v10; // s3
  void *v11; // x0
  int v12; // s0
  int v13; // s1
  int v14; // s2
  int v15; // s3
  void *v16; // x0
  int v17; // s0
  int v18; // s1
  int v19; // s2
  int v20; // s3
  void *v21; // x0
  int v22; // s0
  int v23; // s1
  int v24; // s2
  int v25; // s3
  void *v26; // x0
  int v27; // s0
  int v28; // s1
  int v29; // s2
  int v30; // s3
  int v31; // s0
  int v32; // s1
  int v33; // s2
  int v34; // s3
  UnityEngine_Vector4_o Row; // 0:kr00_16.16
  UnityEngine_Vector4_o v36; // 0:kr10_16.16
  UnityEngine_Vector4_o v37; // 0:kr20_16.16
  UnityEngine_Vector4_o v38; // 0:kr30_16.16
  UnityEngine_Vector4_o v39; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v40; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v41; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v42; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v43; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Vector4_o v44; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  Row = UnityEngine_Matrix4x4__GetRow((UnityEngine_Matrix4x4_o *)a2, 0, nullptr);
  v36 = UnityEngine_Matrix4x4__GetRow((UnityEngine_Matrix4x4_o *)a2, 1, nullptr);
  v37 = UnityEngine_Matrix4x4__GetRow((UnityEngine_Matrix4x4_o *)a2, 2, nullptr);
  v38 = UnityEngine_Matrix4x4__GetRow((UnityEngine_Matrix4x4_o *)a2, 3, nullptr);
  v39.x = v37.x + v38.x;
  v39.y = v37.y + v38.y;
  v39.z = v37.z + v38.z;
  v39.w = v37.w + v38.w;
  Plane = (void *)VLB_Utils__GetPlane(v39, v5);
  *(_DWORD *)a0 = v7;
  *(_DWORD *)(a0 + 4) = v8;
  *(_DWORD *)(a0 + 8) = v9;
  *(_DWORD *)(a0 + 12) = v10;
  v40.x = v38.x - v37.x;
  v40.y = v38.y - v37.y;
  v40.z = v38.z - v37.z;
  v40.w = v38.w - v37.w;
  v11 = (void *)VLB_Utils__GetPlane(v40, Plane);
  *(_DWORD *)(a0 + 16) = v12;
  *(_DWORD *)(a0 + 20) = v13;
  *(_DWORD *)(a0 + 24) = v14;
  *(_DWORD *)(a0 + 28) = v15;
  v41.x = v36.x + v38.x;
  v41.y = v36.y + v38.y;
  v41.z = v36.z + v38.z;
  v41.w = v36.w + v38.w;
  v16 = (void *)VLB_Utils__GetPlane(v41, v11);
  *(_DWORD *)(a0 + 32) = v17;
  *(_DWORD *)(a0 + 36) = v18;
  *(_DWORD *)(a0 + 40) = v19;
  *(_DWORD *)(a0 + 44) = v20;
  v42.x = v38.x - v36.x;
  v42.y = v38.y - v36.y;
  v42.z = v38.z - v36.z;
  v42.w = v38.w - v36.w;
  v21 = (void *)VLB_Utils__GetPlane(v42, v16);
  *(_DWORD *)(a0 + 48) = v22;
  *(_DWORD *)(a0 + 52) = v23;
  *(_DWORD *)(a0 + 56) = v24;
  *(_DWORD *)(a0 + 60) = v25;
  v43.x = Row.x + v38.x;
  v43.y = Row.y + v38.y;
  v43.z = Row.z + v38.z;
  v43.w = Row.w + v38.w;
  v26 = (void *)VLB_Utils__GetPlane(v43, v21);
  *(_DWORD *)(a0 + 64) = v27;
  *(_DWORD *)(a0 + 68) = v28;
  *(_DWORD *)(a0 + 72) = v29;
  *(_DWORD *)(a0 + 76) = v30;
  v44.x = v38.x - Row.x;
  v44.y = v38.y - Row.y;
  v44.z = v38.z - Row.z;
  v44.w = v38.w - Row.w;
  VLB_Utils__GetPlane(v44, v26);
  *(_DWORD *)(a0 + 80) = v31;
  *(_DWORD *)(a0 + 84) = v32;
  *(_DWORD *)(a0 + 88) = v33;
  *(_DWORD *)(a0 + 92) = v34;
}

