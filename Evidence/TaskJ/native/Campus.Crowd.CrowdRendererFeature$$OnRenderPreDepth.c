// Campus.Crowd.CrowdRendererFeature$$OnRenderPreDepth @ 0xddc52cc
void __fastcall Campus_Crowd_CrowdRendererFeature__OnRenderPreDepth(void *a0, __int64 a1, void *a2, void *a3)
{
  void *System; // x0
  void *v7; // x20
  void *v8; // x19
  void *v9; // x3
  void **v10; // x22
  void *v11; // x23
  void *v12; // x4
  void *v13; // x21
  void *EngineMaterial; // x0
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  __int64 v19; // [xsp+18h] [xbp+18h] BYREF
  __int64 v20; // [xsp+28h] [xbp+28h] BYREF

  v20 = a1;
  if ( (unk_F43BCF8 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
    unk_F43BCF8 = 1;
  }
  BYTE4(v19) = 0;
  System = Campus_Crowd_CrowdRendererFeature__GetSystem(a0, (char *)a2 + 24, a2);
  if ( System )
  {
    v7 = System;
    if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    v8 = UnityEngine_Rendering_CommandBufferPool__Get(nullptr);
    UnityEngine_Rendering_ProfilingScope___ctor((__int64)&v19 + 4, v8, *((void **)a0 + 4), nullptr);
    Campus_Crowd_CrowdSystem__RenderCrowd(v7, v8, 0, v9);
    v10 = (void **)((char *)a0 + 80);
    v11 = *((void **)a0 + 10);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( UnityEngine_Object__op_Equality(v11, nullptr, nullptr) )
    {
      v13 = *((void **)a0 + 9);
      if ( !*(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
      EngineMaterial = UnityEngine_Rendering_CoreUtils__CreateEngineMaterial(v13, nullptr);
      *v10 = EngineMaterial;
      sub_63CEE24(v10, (int)EngineMaterial, v15, v16, v17, v18);
    }
    Campus_Crowd_CrowdSystem__RenderBillboardCrowd(v7, v8, *v10, 0, v12);
    UnityEngine_Rendering_ProfilingScope__Dispose((__int64)&v19 + 4, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
    UnityEngine_Rendering_ScriptableRenderContext__ExecuteCommandBuffer((__int64)&v20, v8, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    UnityEngine_Rendering_CommandBufferPool__Release(v8, nullptr);
  }
}

