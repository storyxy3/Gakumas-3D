// Campus.Crowd.CrowdSystem$$.cctor @ 0xddcb54c
void __fastcall Campus_Crowd_CrowdSystem___cctor(void *a0)
{
  int v1; // w0
  void *v2; // x8
  int v3; // w0
  void *v4; // x8
  int v5; // w0
  void *v6; // x8
  int v7; // w0
  __int64 v8; // x8
  void *v9; // x19
  __int64 v10; // x0
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  void *v15; // x19
  __int64 v16; // x0
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5

  if ( (unk_F43BD1E & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&StringLiteral__LookAt);
    sub_63CEE78(&StringLiteral__OcclusionSphere);
    sub_63CEE78(&StringLiteral_CrowdSystem_ExecuteCullingJob);
    sub_63CEE78(&StringLiteral__CameraForward);
    sub_63CEE78(&StringLiteral_CrowdSystem_Setup);
    sub_63CEE78(&StringLiteral__CameraPosition);
    unk_F43BD1E = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID(StringLiteral__LookAt, nullptr);
  v2 = (void *)StringLiteral__CameraPosition;
  **(_DWORD **)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) = v1;
  v3 = UnityEngine_Shader__PropertyToID(v2, nullptr);
  v4 = (void *)StringLiteral__CameraForward;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 4LL) = v3;
  v5 = UnityEngine_Shader__PropertyToID(v4, nullptr);
  v6 = (void *)StringLiteral__OcclusionSphere;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 8LL) = v5;
  v7 = UnityEngine_Shader__PropertyToID(v6, nullptr);
  v8 = UnityEngine_Rendering_ProfilingSampler_TypeInfo;
  *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL) + 12LL) = v7;
  v9 = (void *)sub_63CF110(v8);
  UnityEngine_Rendering_ProfilingSampler___ctor(v9, StringLiteral_CrowdSystem_Setup, nullptr);
  v10 = *(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL);
  *(_QWORD *)(v10 + 16) = v9;
  sub_63CEE24((void *)(v10 + 16), (int)v9, v11, v12, v13, v14);
  v15 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v15, StringLiteral_CrowdSystem_ExecuteCullingJob, nullptr);
  v16 = *(_QWORD *)(Campus_Crowd_CrowdSystem_TypeInfo + 184LL);
  *(_QWORD *)(v16 + 24) = v15;
  sub_63CEE24((void *)(v16 + 24), (int)v15, v17, v18, v19, v20);
}

