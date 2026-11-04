// Campus.Crowd.CrowdSystem$$ComputePenlight @ 0xddca238
void __fastcall Campus_Crowd_CrowdSystem__ComputePenlight(void *a0, void *a1, void *a2)
{
  __int64 v5; // x8
  void *TotalSubMeshInstanceCount; // x0
  __int64 *CrowdPenlight; // x0
  __int64 v8; // x8
  void *v9; // x21
  __int64 v10; // x9
  int *v11; // x10
  __int64 v12; // x0
  __int64 v13; // x8
  int v14; // w21
  void *v15; // x3
  __int64 v16; // x8
  int v17; // w22
  void *v18; // x23
  int v19; // w24
  void *v20; // x4
  void *v21; // x4
  void *v22; // x4
  void *v23; // x3
  void *v24; // x21
  __int64 *AudiencePenlight; // x21
  __int64 v26; // x8
  __int64 v27; // x9
  void *v28; // x20
  int *v29; // x10
  __int64 v30; // x0
  char v31; // w21
  void *v32; // x0
  void *v33; // x1
  void *v34; // x2
  __int128 v35; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43BD19 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_CoreUtils_TypeInfo);
    sub_63CEE78(&Campus_AudiencePenlight_IAudiencePenlight_TypeInfo);
    sub_63CEE78(&Campus_Crowd_ICrowdPenlight_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_Value__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
    unk_F43BD19 = 1;
  }
  v5 = *((_QWORD *)a0 + 10);
  v35 = 0u;
  if ( !v5 || !*((_QWORD *)a0 + 9) )
    return;
  TotalSubMeshInstanceCount = *((void **)a0 + 5);
  if ( !TotalSubMeshInstanceCount )
    goto LABEL_41;
  CrowdPenlight = (__int64 *)Campus_Crowd_CrowdVolume__get_CrowdPenlight(TotalSubMeshInstanceCount, a1);
  if ( CrowdPenlight )
  {
    v8 = *CrowdPenlight;
    v9 = CrowdPenlight;
    v10 = *(unsigned __int16 *)(*CrowdPenlight + 302);
    if ( *(_WORD *)(*CrowdPenlight + 302) )
    {
      v11 = (int *)(*(_QWORD *)(v8 + 176) + 8LL);
      while ( *((_QWORD *)v11 - 1) != Campus_Crowd_ICrowdPenlight_TypeInfo )
      {
        --v10;
        v11 += 4;
        if ( !v10 )
          goto LABEL_11;
      }
      v12 = v8 + 16LL * *v11 + 312;
    }
    else
    {
LABEL_11:
      v12 = sub_6408234(CrowdPenlight, Campus_Crowd_ICrowdPenlight_TypeInfo, 0);
    }
    if ( ((*(__int64 (__fastcall **)(void *, _QWORD))v12)(v9, *(_QWORD *)(v12 + 8)) & 1) == 0 )
    {
      TotalSubMeshInstanceCount = *((void **)a0 + 10);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      TotalSubMeshInstanceCount = (void *)Campus_Crowd_CrowdSystemData__get_TotalSubMeshInstanceCount(
                                            TotalSubMeshInstanceCount,
                                            a1);
      v13 = *((_QWORD *)a0 + 10);
      if ( !v13 )
        goto LABEL_41;
      v14 = (int)TotalSubMeshInstanceCount;
      v35 = *(_OWORD *)(v13 + 128);
      TotalSubMeshInstanceCount = (void *)Unity_Collections_NativeReference_int___get_Value(
                                            (__int64)&v35,
                                            Method_Unity_Collections_NativeReference_int__get_Value__);
      v16 = *((_QWORD *)a0 + 9);
      if ( !v16 )
        goto LABEL_41;
      v17 = (int)TotalSubMeshInstanceCount;
      TotalSubMeshInstanceCount = *((void **)a0 + 10);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      v18 = *(void **)(v16 + 56);
      v19 = *(_DWORD *)(v16 + 64);
      Campus_Crowd_CrowdSystemData__SetBoundsMin(TotalSubMeshInstanceCount, a1, v18, v15);
      if ( !*((_QWORD *)a0 + 10) )
        goto LABEL_41;
      Campus_Crowd_CrowdSystemData__SetVisiblePersonCount(TotalSubMeshInstanceCount, a1, v18, v17 + v14, v20);
      TotalSubMeshInstanceCount = *((void **)a0 + 10);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      Campus_Crowd_CrowdSystemData__SetPersonBuffers(TotalSubMeshInstanceCount, a1, v18, v19, v21);
      TotalSubMeshInstanceCount = *((void **)a0 + 10);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      Campus_Crowd_CrowdSystemData__SetPenlightBuffers(TotalSubMeshInstanceCount, a1, v18, v19, v22);
      TotalSubMeshInstanceCount = *((void **)a0 + 9);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      Campus_Crowd_PenlightMeshRenderSystem__ComputeUpdatePenlight(TotalSubMeshInstanceCount, a1, v17 + v14, v23);
      v24 = *((void **)a0 + 6);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( !UnityEngine_Object__op_Inequality(v24, nullptr, nullptr) )
        goto LABEL_27;
      TotalSubMeshInstanceCount = *((void **)a0 + 6);
      if ( !TotalSubMeshInstanceCount )
        goto LABEL_41;
      AudiencePenlight = (__int64 *)Campus_AudiencePenlight_AudiencePenlightVolume__get_AudiencePenlight(
                                      TotalSubMeshInstanceCount,
                                      a1);
      if ( !AudiencePenlight )
LABEL_27:
        AudiencePenlight = *((__int64 **)a0 + 14);
      TotalSubMeshInstanceCount = (void *)Campus_Crowd_PenlightMeshRenderSystem_TypeInfo;
      if ( !*(_DWORD *)(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Crowd_PenlightMeshRenderSystem_TypeInfo);
        TotalSubMeshInstanceCount = (void *)Campus_Crowd_PenlightMeshRenderSystem_TypeInfo;
      }
      if ( AudiencePenlight )
      {
        v26 = *AudiencePenlight;
        v27 = *(unsigned __int16 *)(*AudiencePenlight + 302);
        v28 = *(void **)(*((_QWORD *)TotalSubMeshInstanceCount + 23) + 32LL);
        if ( *(_WORD *)(*AudiencePenlight + 302) )
        {
          v29 = (int *)(*(_QWORD *)(v26 + 176) + 8LL);
          while ( *((_QWORD *)v29 - 1) != Campus_AudiencePenlight_IAudiencePenlight_TypeInfo )
          {
            --v27;
            v29 += 4;
            if ( !v27 )
              goto LABEL_35;
          }
          v30 = v26 + 16LL * *v29 + 312;
        }
        else
        {
LABEL_35:
          v30 = sub_6408234(AudiencePenlight, Campus_AudiencePenlight_IAudiencePenlight_TypeInfo, 0);
        }
        v31 = (*(__int64 (__fastcall **)(__int64 *, _QWORD))v30)(AudiencePenlight, *(_QWORD *)(v30 + 8));
        if ( !*(_DWORD *)(UnityEngine_Rendering_CoreUtils_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Rendering_CoreUtils_TypeInfo);
        UnityEngine_Rendering_CoreUtils__SetKeyword(a1, v28, (v31 & 1) == 0, nullptr);
        return;
      }
LABEL_41:
      v32 = (void *)sub_63CF120(TotalSubMeshInstanceCount, a1);
      Campus_Crowd_PenlightMeshRenderSystem__SetupCompute(v32, v33, v34);
    }
  }
}

