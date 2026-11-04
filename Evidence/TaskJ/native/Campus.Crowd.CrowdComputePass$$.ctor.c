// Campus.Crowd.CrowdComputePass$$.ctor @ 0xddc3db4
void __fastcall Campus_Crowd_CrowdComputePass___ctor(void *a0, void *a1)
{
  void *v3; // x20
  char *v4; // x19
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5

  if ( (unk_F43BCFC & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_Universal_ScriptableRenderPass_TypeInfo);
    sub_63CEE78(&StringLiteral_Compute_Crowd);
    unk_F43BCFC = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Rendering_Universal_ScriptableRenderPass_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Rendering_Universal_ScriptableRenderPass_TypeInfo);
  UnityEngine_Rendering_Universal_ScriptableRenderPass___ctor(a0, nullptr);
  v3 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v3, StringLiteral_Compute_Crowd, nullptr);
  *((_QWORD *)a0 + 7) = v3;
  v4 = (char *)a0 + 56;
  sub_63CEE24(v4, (int)v3, v5, v6, v7, v8);
  *((_DWORD *)v4 - 10) = 0;
}

