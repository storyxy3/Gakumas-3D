// VLB.Config$$OnStartup @ 0xe0c7c64
void __fastcall VLB_Config__OnStartup(void *a0)
{
  void *v1; // x1
  _DWORD *Instance; // x0
  void *v3; // x1
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  void *v8; // x1
  void *v9; // x1
  void *v10; // x1
  void *v11; // x19
  void *v12; // x0
  void *v13; // x1

  if ( (unk_F43D9A8 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&StringLiteral_It_looks_like_the__Render_Pipeline__is_not_correctly_set_in_);
    unk_F43D9A8 = 1;
  }
  Instance = VLB_Config__GetInstance(0, v1);
  if ( Instance
    && (*((_QWORD *)Instance + 25) = 0,
        sub_63CEE24(Instance + 50, 0, v4, v5, v6, v7),
        (Instance = VLB_Config__GetInstance(0, v8)) != nullptr)
    && (VLB_Config__RefreshGlobalShaderProperties(Instance, v3), (Instance = VLB_Config__GetInstance(0, v9)) != nullptr) )
  {
    if ( (VLB_SRPHelper__get_projectRenderPipeline(nullptr) == 0) != (Instance[12] == 0) )
    {
      v11 = VLB_Config__GetInstance(0, v10);
      if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Debug_TypeInfo);
      UnityEngine_Debug__LogError_1(
        StringLiteral_It_looks_like_the__Render_Pipeline__is_not_correctly_set_in_,
        v11,
        nullptr);
    }
  }
  else
  {
    v12 = (void *)sub_63CF120(Instance, v3);
    VLB_Config__RefreshGlobalShaderProperties(v12, v13);
  }
}

