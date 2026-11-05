// ProFlareBatchForSRPData$$ComputeFlares @ 0xd1d522c
void __fastcall ProFlareBatchForSRPData__ComputeFlares(void *a0, void *a1, void *a2)
{
  int v5; // w8
  int v6; // w21
  void *v7; // x2
  __int64 v8; // x1
  void *v9; // x22
  int v10; // w23
  __int64 v11; // x0
  __int64 v12; // x1
  void *v13; // x0
  __int64 v14; // x1
  float v15; // s0
  void *v16; // x0
  float v17; // s8
  __int64 v18; // x0
  __int64 v19; // x1
  float farClipPlane; // s0
  __int64 v21; // x8
  float v22; // s9
  void *v23; // x22
  int v24; // w24
  int v25; // w23
  void *v26; // x0
  void *v27; // x19
  int v28; // w1
  __int64 v29; // x19
  void *v30; // x0
  __int64 v31; // [xsp+0h] [xbp+0h] BYREF
  __int64 v32; // [xsp+8h] [xbp+8h]
  __int64 v33; // [xsp+28h] [xbp+28h] BYREF
  UnityEngine_Vector4_o v34; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F42C94A & 1) == 0 )
  {
    sub_63CEE78(&ProFlareBatchForSRPData_TypeInfo);
    unk_F42C94A = 1;
  }
  v5 = *((_DWORD *)a0 + 52);
  BYTE4(v33) = 0;
  if ( (v5 & 0xF) != 0 )
    v6 = v5 / 16 + 1;
  else
    v6 = v5 / 16;
  if ( !v6 )
    return;
  UnityEngine_Rendering_ProfilingScope___ctor((__int64)&v33 + 4, a1, *((void **)a0 + 2), nullptr);
  v31 = 0;
  v32 = (__int64)&v33 + 4;
  ProFlareBatchForSRPData__UpdateComputeBuffer(a0, a1, v7);
  v9 = *((void **)a0 + 6);
  v10 = *((_DWORD *)a0 + 14);
  v11 = ProFlareBatchForSRPData_TypeInfo;
  if ( !*(_DWORD *)(ProFlareBatchForSRPData_TypeInfo + 228LL) )
    sub_63CEFF4(ProFlareBatchForSRPData_TypeInfo);
  if ( !a1 )
  {
    v13 = (void *)sub_63CF120(v11, v8);
    goto LABEL_16;
  }
  UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam(
    a1,
    v9,
    v10,
    **(_DWORD **)(ProFlareBatchForSRPData_TypeInfo + 184LL),
    *((void **)a0 + 22),
    nullptr);
  UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam(
    a1,
    *((void **)a0 + 6),
    *((_DWORD *)a0 + 14),
    *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 4LL),
    *((void **)a0 + 25),
    nullptr);
  v13 = *((void **)a0 + 5);
  if ( !v13 )
  {
LABEL_16:
    v16 = (void *)sub_63CF120(v13, v12);
    goto LABEL_17;
  }
  v15 = UnityEngine_Camera__get_nearClipPlane(v13, nullptr);
  v16 = *((void **)a0 + 5);
  if ( v16 )
  {
    v17 = v15;
    farClipPlane = UnityEngine_Camera__get_farClipPlane(v16, nullptr);
    v21 = *((_QWORD *)a0 + 4);
    if ( v21 )
    {
      v22 = farClipPlane;
      v23 = *((void **)a0 + 6);
      v24 = *(_DWORD *)(v21 + 116);
      v25 = *(_DWORD *)(*(_QWORD *)(ProFlareBatchForSRPData_TypeInfo + 184LL) + 8LL);
      v34.y = UnityEngine_Time__get_deltaTime(nullptr);
      v34.z = (float)(v22 - v17) / (float)(v17 * v22);
      v34.w = 1.0 / v22;
      v34.x = (float)v24;
      UnityEngine_Rendering_CommandBuffer__SetComputeVectorParam(a1, v23, v25, v34, nullptr);
      UnityEngine_Rendering_CommandBuffer__DispatchCompute(
        a1,
        *((void **)a0 + 6),
        *((_DWORD *)a0 + 14),
        v6,
        1,
        1,
        nullptr);
      UnityEngine_Rendering_ProfilingScope__Dispose((__int64)&v33 + 4, nullptr);
      return;
    }
    goto LABEL_18;
  }
LABEL_17:
  v18 = sub_63CF120(v16, v14);
LABEL_18:
  v26 = (void *)sub_63CF120(v18, v19);
  v27 = v26;
  if ( v28 != 1 )
    goto LABEL_21;
  v29 = *(_QWORD *)__cxa_begin_catch(v26);
  v31 = v29;
  __cxa_end_catch();
  UnityEngine_Rendering_ProfilingScope__Dispose(v32, nullptr);
  if ( v29 )
  {
    sub_63CF118(v29);
    v27 = v30;
LABEL_21:
    sub_5D9C258(&v31);
    sub_64BD8DC(v27);
  }
}

