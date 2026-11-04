// Campus.Crowd.PenlightMeshRenderSystem$$ComputeUpdatePenlight @ 0xddcaabc
void __fastcall Campus_Crowd_PenlightMeshRenderSystem__ComputeUpdatePenlight(void *a0, void *a1, int a2, void *a3)
{
  void *v7; // x22
  int v8; // w0
  void *v9; // x2
  int v10; // w21
  int v11; // w26
  unsigned int v12; // w22
  int v13; // w23
  void *PenlightInfoBytesBuffer; // x0
  void *v15; // x24
  __int64 v16; // x1
  __int64 v17; // x0
  void *v18; // x25
  void *v19; // x0
  void *v20; // x1

  if ( (unk_F43BD32 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
    sub_63CEE78(&System_Runtime_InteropServices_Marshal_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
    unk_F43BD32 = 1;
  }
  v7 = *((void **)a0 + 7);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v7, nullptr, nullptr) && a2 >= 1 && (*((_DWORD *)a0 + 16) & 0x80000000) == 0 )
  {
    if ( !*(_DWORD *)(System_Runtime_InteropServices_Marshal_TypeInfo + 228LL) )
      sub_63CEFF4(System_Runtime_InteropServices_Marshal_TypeInfo);
    v8 = System_Runtime_InteropServices_Marshal__SizeOf_uint_(Method_System_Runtime_InteropServices_Marshal_SizeOf_uint___);
    v10 = (_BYTE)a2 ? ((unsigned int)a2 >> 8) + 1 : (unsigned int)a2 >> 8;
    if ( *((int *)a0 + 8) >= 1 )
    {
      v11 = 5 * v8;
      v12 = v8;
      v13 = 0;
      do
      {
        PenlightInfoBytesBuffer = Campus_Crowd_PenlightMeshRenderSystem__GetPenlightInfoBytesBuffer(a0, v13++, v9);
        if ( PenlightInfoBytesBuffer )
        {
          v15 = PenlightInfoBytesBuffer;
          UnityEngine_GraphicsBuffer__SetCounterValue(PenlightInfoBytesBuffer, 0, nullptr);
          v17 = Campus_Crowd_PenlightMeshRenderSystem_TypeInfo;
          v18 = *((void **)a0 + 7);
          if ( !*(_DWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 228LL) )
            sub_63CEFF4(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
          if ( !a1 )
          {
            v19 = (void *)sub_63CF120(v17, v16);
            Campus_AudiencePenlight_AudiencePenlightVolume__get_AudiencePenlight(v19, v20);
            return;
          }
          UnityEngine_Rendering_CommandBuffer__SetComputeIntParam(
            a1,
            v18,
            *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 8LL),
            v13,
            nullptr);
          UnityEngine_Rendering_CommandBuffer__SetComputeBufferParam_1(
            a1,
            *((void **)a0 + 7),
            *((_DWORD *)a0 + 16),
            *(_DWORD *)(*(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 184LL) + 12LL),
            v15,
            nullptr);
          UnityEngine_Rendering_CommandBuffer__DispatchCompute(
            a1,
            *((void **)a0 + 7),
            *((_DWORD *)a0 + 16),
            v10,
            1,
            1,
            nullptr);
          UnityEngine_Rendering_CommandBuffer__CopyCounterValue(a1, v15, *((void **)a0 + 5), v12, nullptr);
        }
        v12 += v11;
      }
      while ( v13 < *((_DWORD *)a0 + 8) );
    }
  }
}

