// Campus.Crowd.CrowdSystemData$$InitializeBytesBuffer @ 0xddcb7ac
void __fastcall Campus_Crowd_CrowdSystemData__InitializeBytesBuffer(void *a0, int a1, void *a2, void *a3)
{
  int v6; // w21
  void *v7; // x22
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5

  if ( (unk_F43BD2C & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_GraphicsBuffer_TypeInfo);
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    unk_F43BD2C = 1;
  }
  if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
    sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
  v6 = System_Runtime_InteropServices_Marshal__SizeOf_uint_(Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
  v7 = (void *)sub_63CF110(UnityEngine_GraphicsBuffer_TypeInfo);
  UnityEngine_GraphicsBuffer___ctor_1(v7, 32, a1, v6, nullptr);
  *(_QWORD *)a2 = v7;
  sub_63CEE24(a2, (int)v7, v8, v9, v10, v11);
}

