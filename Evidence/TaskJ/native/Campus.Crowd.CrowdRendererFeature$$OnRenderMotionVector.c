// Campus.Crowd.CrowdRendererFeature$$OnRenderMotionVector @ 0xddc5a14
void __fastcall Campus_Crowd_CrowdRendererFeature__OnRenderMotionVector(void *a0, __int64 a1, void *a2, void *a3)
{
  void *v6; // x0
  void *v7; // x2
  void *v8; // x19
  __int64 v9; // [xsp+0h] [xbp+0h] BYREF
  __int64 v10; // [xsp+8h] [xbp+8h] BYREF

  v10 = a1;
  if ( (unk_F43BCFA & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
    unk_F43BCFA = 1;
  }
  BYTE4(v9) = 0;
  if ( Campus_Crowd_CrowdRendererFeature__GetSystem(a0, (char *)a2 + 24, a2) && *((_DWORD *)a2 + 96) == 1 )
  {
    if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    v6 = UnityEngine_Rendering_CommandBufferPool__Get(nullptr);
    v7 = *((void **)a0 + 4);
    v8 = v6;
    UnityEngine_Rendering_ProfilingScope___ctor((__int64)&v9 + 4, v6, v7, nullptr);
    UnityEngine_Rendering_ProfilingScope__Dispose((__int64)&v9 + 4, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
    UnityEngine_Rendering_ScriptableRenderContext__ExecuteCommandBuffer((__int64)&v10, v8, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
    UnityEngine_Rendering_CommandBufferPool__Release(v8, nullptr);
  }
}

