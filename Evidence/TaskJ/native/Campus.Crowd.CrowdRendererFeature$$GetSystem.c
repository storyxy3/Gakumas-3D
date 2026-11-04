// Campus.Crowd.CrowdRendererFeature$$GetSystem @ 0xddc5218
void *__fastcall Campus_Crowd_CrowdRendererFeature__GetSystem(void *a0, void *a1, void *a2)
{
  __int64 v3; // x22
  __int64 v4; // x23
  __int64 v5; // x24
  int v8; // w8
  void *result; // x0
  void *InstanceID; // x0
  __int64 v11; // x0
  char *v12; // x2
  __int64 v13; // x1
  __int64 v14; // x30
  char *v15; // x19
  __int64 v16; // x21
  void *v17; // x20
  void *v18; // x19
  void *v19; // x3
  void **v20; // x22
  void *v21; // x23
  void *v22; // x4
  void *v23; // x21
  void *EngineMaterial; // x0
  int v25; // w2
  int v26; // w3
  int v27; // w4
  void *v28; // x5
  void *v29; // [xsp+8h] [xbp+8h] BYREF
  char *v30; // [xsp+10h] [xbp+10h]
  __int64 v31; // [xsp+18h] [xbp+18h] BYREF
  __int64 v32; // [xsp+20h] [xbp+20h]
  __int64 v33; // [xsp+28h] [xbp+28h] BYREF
  __int64 v34; // [xsp+30h] [xbp+30h]
  __int64 v35; // [xsp+38h] [xbp+38h]
  __int64 v36; // [xsp+40h] [xbp+40h]
  __int64 v37; // [xsp+48h] [xbp+48h]
  void *v38; // [xsp+50h] [xbp+50h]
  void *v39; // [xsp+58h] [xbp+58h]

  if ( (unk_F43BCF7 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__);
    unk_F43BCF7 = 1;
  }
  v8 = *((_DWORD *)a1 + 90);
  result = nullptr;
  v29 = nullptr;
  if ( v8 != 4 )
  {
    InstanceID = *((void **)a1 + 24);
    if ( !InstanceID )
      goto LABEL_13;
    a0 = *((void **)a0 + 11);
    InstanceID = (void *)UnityEngine_Object__GetInstanceID(InstanceID, nullptr);
    if ( !a0 )
      goto LABEL_13;
    if ( !System_Collections_Generic_Dictionary_int__object___TryGetValue(
            a0,
            (int)InstanceID,
            &v29,
            Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__) )
      return nullptr;
    InstanceID = v29;
    if ( v29 )
    {
      if ( Campus_Crowd_CrowdSystem__IsActive(v29, a1) )
        return v29;
      else
        return nullptr;
    }
    else
    {
LABEL_13:
      v11 = sub_63CF120(InstanceID, a1);
      v32 = v14;
      v33 = v13;
      v34 = v5;
      v35 = v4;
      v36 = v3;
      v37 = 256094208;
      v38 = a1;
      v39 = a0;
      v15 = v12;
      v16 = v11;
      if ( (unk_F43BCF8 & 1) == 0 )
      {
        sub_63CEE78(&UnityEngine_Rendering_CommandBufferPool_TypeInfo);
        sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
        sub_63CEE78(&UnityEngine_Object_TypeInfo);
        sub_63CEE78(&UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
        unk_F43BCF8 = 1;
      }
      BYTE4(v31) = 0;
      result = Campus_Crowd_CrowdRendererFeature__GetSystem((void *)v16, v15 + 24, v12);
      if ( result )
      {
        v17 = result;
        if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
        v18 = UnityEngine_Rendering_CommandBufferPool__Get(nullptr);
        UnityEngine_Rendering_ProfilingScope___ctor((__int64)&v31 + 4, v18, *(void **)(v16 + 32), nullptr);
        v29 = nullptr;
        v30 = (char *)&v31 + 4;
        Campus_Crowd_CrowdSystem__RenderCrowd(v17, v18, 0, v19);
        v20 = (void **)(v16 + 80);
        v21 = *(void **)(v16 + 80);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        if ( UnityEngine_Object__op_Equality(v21, nullptr, nullptr) )
        {
          v23 = *(void **)(v16 + 72);
          if ( !*(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
          EngineMaterial = UnityEngine_Rendering_CoreUtils__CreateEngineMaterial(v23, nullptr);
          *v20 = EngineMaterial;
          sub_63CEE24(v20, (int)EngineMaterial, v25, v26, v27, v28);
        }
        Campus_Crowd_CrowdSystem__RenderBillboardCrowd(v17, v18, *v20, 0, v22);
        UnityEngine_Rendering_ProfilingScope__Dispose((__int64)&v31 + 4, nullptr);
        if ( !*(_DWORD *)(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Rendering_ScriptableRenderContext_TypeInfo);
        UnityEngine_Rendering_ScriptableRenderContext__ExecuteCommandBuffer((__int64)&v33, v18, nullptr);
        if ( !*(_DWORD *)(UnityEngine_Rendering_CommandBufferPool_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Rendering_CommandBufferPool_TypeInfo);
        UnityEngine_Rendering_CommandBufferPool__Release(v18, nullptr);
      }
    }
  }
  return result;
}

