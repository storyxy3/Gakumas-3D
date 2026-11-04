// 0xd1d5474 @ 0xd1d5474
void __fastcall ProFlareBatchForSRPData__UpdateComputeBuffer(void *a0, void *a1, void *a2)
{
  void *v4; // x20
  void *v5; // x0
  void *v6; // x1
  void *v7; // x2

  v4 = a0;
  if ( (unk_F42C94C & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Rendering_CommandBuffer_SetBufferData_ProFlareElementData___);
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Rendering_CommandBuffer_SetBufferData_ProFlareInputData___);
    unk_F42C94C = 1;
  }
  if ( a1 )
  {
    UnityEngine_Rendering_CommandBuffer__SetBufferData_ProFlareInputData_(
      a1,
      *((void **)v4 + 22),
      *((_QWORD *)v4 + 23),
      *((void **)v4 + 24));
    UnityEngine_Rendering_CommandBuffer__SetBufferData_ProFlareElementData_(
      a1,
      *((void **)v4 + 13),
      *((_QWORD *)v4 + 14),
      *((void **)v4 + 15));
  }
  else
  {
    v5 = (void *)sub_63CF120(a0, a1);
    ProFlareBatchForSRPData__RenderFlares(v5, v6, v7);
  }
}

