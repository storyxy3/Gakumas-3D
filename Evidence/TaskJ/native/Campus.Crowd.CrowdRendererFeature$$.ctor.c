// Campus.Crowd.CrowdRendererFeature$$.ctor @ 0xddc5b10
void __fastcall Campus_Crowd_CrowdRendererFeature___ctor(void *a0, void *a1)
{
  void *v3; // x20
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  void *v8; // x20
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5

  if ( (unk_F43BCFB & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdRendererFeature_Settings_TypeInfo);
    sub_63CEE78(&StringLiteral_Render_Crowd);
    unk_F43BCFB = 1;
  }
  v3 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v3, StringLiteral_Render_Crowd, nullptr);
  *((_QWORD *)a0 + 4) = v3;
  sub_63CEE24((char *)a0 + 32, (int)v3, v4, v5, v6, v7);
  v8 = (void *)sub_63CF110(Campus_Crowd_CrowdRendererFeature_Settings_TypeInfo);
  System_Object___ctor(v8, nullptr);
  *((_QWORD *)a0 + 5) = v8;
  sub_63CEE24((char *)a0 + 40, (int)v8, v9, v10, v11, v12);
  UnityEngine_Rendering_Universal_ScriptableRendererFeature___ctor(a0, nullptr);
}

