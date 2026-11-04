// Campus.Crowd.CrowdRendererFeature$$Create @ 0xddc3b28
void __fastcall Campus_Crowd_CrowdRendererFeature__Create(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x20
  void *v5; // x20
  void *v6; // x20
  void *v7; // x20
  void *v8; // x1
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  void *v13; // x20
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  void *v18; // x20
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x20
  int v24; // w2
  int v25; // w3
  int v26; // w4
  void *v27; // x5
  void *v28; // x20
  int v29; // w2
  int v30; // w3
  int v31; // w4
  void *v32; // x5
  void *v33; // x20
  int v34; // w2
  int v35; // w3
  int v36; // w4
  void *v37; // x5

  if ( (unk_F43BCF3 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdComputePass_TypeInfo);
    sub_63CEE78(&Method_Campus_Crowd_CrowdRendererFeature_OnRenderGBuffer__);
    sub_63CEE78(&Method_Campus_Crowd_CrowdRendererFeature_OnRenderMotionVector__);
    sub_63CEE78(&Method_Campus_Crowd_CrowdRendererFeature_OnRenderPreDepth__);
    sub_63CEE78(&Campus_Crowd_CrowdRenderingSetupData_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem___ctor__);
    sub_63CEE78(&System_Collections_Generic_Dictionary_int__CrowdSystem__TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&VL_Rendering_RenderingBridge_RenderEvent_TypeInfo);
    unk_F43BCF3 = 1;
  }
  v3 = *((void **)a0 + 7);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v3, nullptr, nullptr) )
  {
    v4 = *((void **)a0 + 6);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(v4, nullptr, nullptr) )
    {
      v5 = *((void **)a0 + 8);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( !UnityEngine_Object__op_Equality(v5, nullptr, nullptr) )
      {
        v6 = *((void **)a0 + 9);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        if ( !UnityEngine_Object__op_Equality(v6, nullptr, nullptr) )
        {
          v7 = (void *)sub_63CF110(Campus_Crowd_CrowdComputePass_TypeInfo);
          Campus_Crowd_CrowdComputePass___ctor(v7, v8);
          *((_QWORD *)a0 + 12) = v7;
          sub_63CEE24((char *)a0 + 96, (int)v7, v9, v10, v11, v12);
          (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)a0 + 488LL))(
            a0,
            0,
            *(_QWORD *)(*(_QWORD *)a0 + 496LL));
          v13 = (void *)sub_63CF110(System_Collections_Generic_Dictionary_int__CrowdSystem__TypeInfo);
          System_Collections_Generic_Dictionary_int__object____ctor_1(
            v13,
            8,
            Method_System_Collections_Generic_Dictionary_int__CrowdSystem___ctor__);
          *((_QWORD *)a0 + 11) = v13;
          sub_63CEE24((char *)a0 + 88, (int)v13, v14, v15, v16, v17);
          v18 = (void *)sub_63CF110(Campus_Crowd_CrowdRenderingSetupData_TypeInfo);
          System_Object___ctor(v18, nullptr);
          *((_QWORD *)a0 + 13) = v18;
          sub_63CEE24((char *)a0 + 104, (int)v18, v19, v20, v21, v22);
          v23 = (void *)sub_63CF110(VL_Rendering_RenderingBridge_RenderEvent_TypeInfo);
          VL_Rendering_RenderingBridge_RenderEvent___ctor(
            v23,
            a0,
            Method_Campus_Crowd_CrowdRendererFeature_OnRenderPreDepth__,
            nullptr);
          *((_QWORD *)a0 + 14) = v23;
          sub_63CEE24((char *)a0 + 112, (int)v23, v24, v25, v26, v27);
          v28 = (void *)sub_63CF110(VL_Rendering_RenderingBridge_RenderEvent_TypeInfo);
          VL_Rendering_RenderingBridge_RenderEvent___ctor(
            v28,
            a0,
            Method_Campus_Crowd_CrowdRendererFeature_OnRenderGBuffer__,
            nullptr);
          *((_QWORD *)a0 + 15) = v28;
          sub_63CEE24((char *)a0 + 120, (int)v28, v29, v30, v31, v32);
          v33 = (void *)sub_63CF110(VL_Rendering_RenderingBridge_RenderEvent_TypeInfo);
          VL_Rendering_RenderingBridge_RenderEvent___ctor(
            v33,
            a0,
            Method_Campus_Crowd_CrowdRendererFeature_OnRenderMotionVector__,
            nullptr);
          *((_QWORD *)a0 + 16) = v33;
          sub_63CEE24((char *)a0 + 128, (int)v33, v34, v35, v36, v37);
        }
      }
    }
  }
}

