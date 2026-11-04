// VLB.VLBDrawSystem$$.cctor @ 0xe0ccb30
void __fastcall VLB_VLBDrawSystem___cctor(void *a0)
{
  int v1; // w0
  void *v2; // x8
  int v3; // w0
  void *v4; // x8
  int v5; // w0
  void *v6; // x8
  int v7; // w0
  void *v8; // x8
  int v9; // w0
  void *v10; // x8
  int v11; // w0
  void *v12; // x8

  if ( (unk_F43D9E3 & 1) == 0 )
  {
    sub_63CEE78(&VLB_VLBDrawSystem_TypeInfo);
    sub_63CEE78(&StringLiteral__ShadowLightIndex);
    sub_63CEE78(&StringLiteral__ColorParam);
    sub_63CEE78(&StringLiteral__Params0);
    sub_63CEE78(&StringLiteral__ShadowParam);
    sub_63CEE78(&StringLiteral__CameraParam);
    sub_63CEE78(&StringLiteral__Params1);
    sub_63CEE78(&StringLiteral__ObjectToAdditionalLightShadow);
    unk_F43D9E3 = 1;
  }
  v1 = UnityEngine_Shader__PropertyToID(StringLiteral__ColorParam, nullptr);
  v2 = (void *)StringLiteral__CameraParam;
  **(_DWORD **)(VLB_VLBDrawSystem_TypeInfo + 184LL) = v1;
  v3 = UnityEngine_Shader__PropertyToID(v2, nullptr);
  v4 = (void *)StringLiteral__Params0;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 4LL) = v3;
  v5 = UnityEngine_Shader__PropertyToID(v4, nullptr);
  v6 = (void *)StringLiteral__Params1;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 8LL) = v5;
  v7 = UnityEngine_Shader__PropertyToID(v6, nullptr);
  v8 = (void *)StringLiteral__ShadowParam;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 12LL) = v7;
  v9 = UnityEngine_Shader__PropertyToID(v8, nullptr);
  v10 = (void *)StringLiteral__ObjectToAdditionalLightShadow;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 16LL) = v9;
  v11 = UnityEngine_Shader__PropertyToID(v10, nullptr);
  v12 = StringLiteral__ShadowLightIndex;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 20LL) = v11;
  *(_DWORD *)(*(_QWORD *)(VLB_VLBDrawSystem_TypeInfo + 184LL) + 24LL) = UnityEngine_Shader__PropertyToID(v12, nullptr);
}

