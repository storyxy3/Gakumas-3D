// Campus.Crowd.CrowdSystemData$$InitializedPenlightInfoBuffer @ 0xddcb908
void __fastcall Campus_Crowd_CrowdSystemData__InitializedPenlightInfoBuffer(
        void *a0,
        void *a1,
        void *a2,
        void *a3,
        void *a4,
        void *a5)
{
  int v10; // w8
  __int64 v11; // x23
  int v12; // w24
  void *v13; // x25
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  __int64 v18; // x0
  __int64 v19; // x1
  void *v20; // x3
  unsigned int *v21; // x24
  unsigned __int64 v22; // x26
  int v23; // w27
  void *RandomIndex; // x0
  int v25; // w25
  void *v26; // x3
  int v27; // w2
  int v28; // w8
  unsigned int *v29; // x9
  void *v30; // x0
  void *v31; // x1
  void *v32; // x2
  void *v33; // x3
  __int64 v34; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43BD2E & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&int___TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    unk_F43BD2E = 1;
  }
  v10 = *(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL);
  v11 = *((unsigned int *)a1 + 2);
  HIDWORD(v34) = 0;
  if ( !v10 )
    sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
  v12 = System_Runtime_InteropServices_Marshal__SizeOf_uint_(Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
  v13 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v13, 48, v11, v12, nullptr);
  *(_QWORD *)a4 = v13;
  sub_63CEE24(a4, (int)v13, v14, v15, v16, v17);
  HIDWORD(v34) = -786231091;
  v18 = sub_63CEF64(int___TypeInfo, (unsigned int)v11);
  v21 = (unsigned int *)v18;
  if ( (int)v11 < 1 )
  {
LABEL_12:
    v18 = *(_QWORD *)a4;
    if ( *(_QWORD *)a4 )
    {
      UnityEngine_GraphicsBuffer__SetData((void *)v18, v21, nullptr);
      return;
    }
  }
  else
  {
    v22 = 0;
    while ( 1 )
    {
      v23 = *(_DWORD *)(*(_QWORD *)a1 + 32 * v22);
      RandomIndex = (void *)Campus_Crowd_CrowdSystemData__GetRandomIndex((void *)v18, a2, (char *)&v34 + 4, v20);
      v25 = (int)RandomIndex;
      v18 = Campus_Crowd_CrowdSystemData__GetRandomIndex(RandomIndex, a3, (char *)&v34 + 4, v26);
      v28 = 16 * (v18 & 0xF);
      if ( v25 )
        v28 = 0;
      if ( !v21 )
        break;
      if ( v22 >= v21[6] )
        goto LABEL_15;
      v29 = &v21[v22++];
      v29[8] = v28 & 0xFFFFFFF0 | (4 * (v25 + 1)) & (v23 << 10 >> 31) & 0xC | (v25 + 1) & 3;
      if ( v22 == v11 )
        goto LABEL_12;
    }
  }
  v18 = sub_63CF120(v18, v19);
LABEL_15:
  sub_63CF128(v18, v19, v27, (_DWORD)v20);
  Campus_Crowd_CrowdSystemData__GetRandomIndex(v30, v31, v32, v33);
}

