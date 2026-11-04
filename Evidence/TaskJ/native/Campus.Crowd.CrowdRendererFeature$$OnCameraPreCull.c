// Campus.Crowd.CrowdRendererFeature$$OnCameraPreCull @ 0xddc3e6c
void __fastcall Campus_Crowd_CrowdRendererFeature__OnCameraPreCull(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v6; // x8
  __int64 instance; // x0
  void *v8; // x1
  void *v9; // x23
  _QWORD *v10; // x21
  _QWORD *v11; // x22
  void *v12; // x24
  void *v13; // x24
  void *v14; // x24
  void *v15; // x23
  void *v16; // x25
  void *v17; // x6
  void *v18; // x26
  void *v19; // x2
  void *v20; // x25
  void *v21; // x26
  void *v22; // x2
  void *v23; // x25
  void *v24; // x4
  void *v25; // x20
  void *v26; // x2
  void *v27; // x20
  void *v28; // x2
  void *v29; // x2
  __int64 v30; // x8
  __int128 v31; // q1
  __int128 v32; // q7
  __int128 v33; // q16
  float v34; // s2
  float v35; // s0
  void *v36; // x20
  void *v37; // x0
  void *v38; // x1
  void *v39; // x2
  __int128 v40; // [xsp+0h] [xbp+0h] BYREF
  __int128 v41; // [xsp+10h] [xbp+10h]
  __int128 v42; // [xsp+20h] [xbp+20h]
  __int128 v43; // [xsp+30h] [xbp+30h]
  void *v44; // [xsp+48h] [xbp+48h] BYREF
  UnityEngine_Vector3_o v45; // 0:kr00_12.12
  UnityEngine_Vector4_o v46; // 0:s3.4,4:s4.4,8:s5.4,12:s6.4

  if ( (unk_F43BCF4 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdSystem_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__);
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__set_Item__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&VL_Rendering_RenderingBridge_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_VolumeManager_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeStack_GetComponent_AudiencePenlightVolumeComponent___);
    sub_63CEE78(&Method_UnityEngine_Rendering_VolumeStack_GetComponent_Crowd___);
    unk_F43BCF4 = 1;
  }
  v6 = *((_QWORD *)a0 + 11);
  v44 = nullptr;
  if ( v6 && *((_DWORD *)a2 + 90) != 4 )
  {
    if ( !*(_DWORD *)(UnityEngine_Rendering_VolumeManager_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_VolumeManager_TypeInfo);
    instance = (__int64)UnityEngine_Rendering_VolumeManager__get_instance(nullptr);
    if ( !instance )
      goto LABEL_47;
    v9 = *(void **)(instance + 16);
    if ( !v9 )
      goto LABEL_47;
    instance = (__int64)UnityEngine_Rendering_VolumeStack__GetComponent_object_(
                          *(void **)(instance + 16),
                          Method_UnityEngine_Rendering_VolumeStack_GetComponent_Crowd___);
    if ( !instance )
      goto LABEL_47;
    v10 = (_QWORD *)instance;
    instance = *(_QWORD *)(instance + 56);
    if ( !instance )
      goto LABEL_47;
    v11 = (_QWORD *)(*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)instance + 536LL))(
                      instance,
                      *(_QWORD *)(*(_QWORD *)instance + 544LL));
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    instance = UnityEngine_Object__op_Equality(v11, nullptr, nullptr);
    if ( (instance & 1) == 0 )
    {
      if ( !v11 )
        goto LABEL_47;
      v12 = (void *)v11[10];
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( !UnityEngine_Object__op_Equality(v12, nullptr, nullptr) )
      {
        v13 = (void *)v11[11];
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        if ( !UnityEngine_Object__op_Equality(v13, nullptr, nullptr) )
        {
          instance = (__int64)UnityEngine_Rendering_VolumeStack__GetComponent_object_(
                                v9,
                                Method_UnityEngine_Rendering_VolumeStack_GetComponent_AudiencePenlightVolumeComponent___);
          if ( !instance )
            goto LABEL_47;
          instance = *(_QWORD *)(instance + 56);
          if ( !instance )
            goto LABEL_47;
          instance = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)instance + 536LL))(
                       instance,
                       *(_QWORD *)(*(_QWORD *)instance + 544LL));
          v14 = *((void **)a2 + 24);
          if ( !v14 )
            goto LABEL_47;
          v15 = (void *)instance;
          v16 = *((void **)a0 + 11);
          instance = UnityEngine_Object__GetInstanceID(*((void **)a2 + 24), nullptr);
          if ( !v16 )
            goto LABEL_47;
          if ( System_Collections_Generic_Dictionary_int__object___TryGetValue(
                 v16,
                 instance,
                 &v44,
                 Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__) )
          {
            instance = (__int64)v44;
            if ( v44 )
            {
LABEL_32:
              Campus_Crowd_CrowdSystem__Setup(
                (void *)instance,
                v11,
                v15,
                *((void **)a0 + 6),
                *((void **)a0 + 7),
                *((void **)a0 + 8),
                v17);
              instance = (__int64)v44;
              if ( v44 )
              {
                instance = Campus_Crowd_CrowdSystem__IsActive(v44, v8);
                if ( (instance & 1) == 0 )
                  return;
                if ( *((_QWORD *)a0 + 5) )
                {
                  instance = *((_QWORD *)a0 + 13);
                  if ( instance )
                  {
                    Campus_Crowd_CrowdRenderingSetupData__Update((void *)instance, a2, 0, v10, v24);
                    instance = v10[10];
                    if ( instance )
                    {
                      v25 = v44;
                      instance = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)instance + 536LL))(
                                   instance,
                                   *(_QWORD *)(*(_QWORD *)instance + 544LL));
                      if ( v25 )
                      {
                        Campus_Crowd_CrowdSystem__SetDrawCounts(v25, instance, v26);
                        instance = v10[13];
                        if ( instance )
                        {
                          v27 = v44;
                          instance = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)instance + 536LL))(
                                       instance,
                                       *(_QWORD *)(*(_QWORD *)instance + 544LL));
                          if ( v27 )
                          {
                            Campus_Crowd_CrowdSystem__SetBillboardResolution(v27, instance, v28);
                            v30 = *((_QWORD *)a0 + 13);
                            if ( v30 )
                            {
                              instance = (__int64)v44;
                              if ( v44 )
                              {
                                v31 = *(_OWORD *)(v30 + 64);
                                v46.z = *(float *)(v30 + 148);
                                v46.w = *(float *)(v30 + 152);
                                v32 = *(_OWORD *)(v30 + 16);
                                v33 = *(_OWORD *)(v30 + 32);
                                v42 = *(_OWORD *)(v30 + 48);
                                v43 = v31;
                                v46.x = *(float *)(v30 + 140);
                                v46.y = *(float *)(v30 + 144);
                                LODWORD(v31) = *(_DWORD *)(v30 + 84);
                                v34 = *(float *)(v30 + 88);
                                v35 = *(float *)(v30 + 80);
                                v40 = v32;
                                v41 = v33;
                                v45.x = v35;
                                LODWORD(v45.y) = v31;
                                v45.z = v34;
                                if ( Campus_Crowd_CrowdSystem__ScheduleJobs(
                                       v44,
                                       (UnityEngine_Matrix4x4_o *)&v40,
                                       v45,
                                       v46,
                                       v29) )
                                {
                                  v36 = *((void **)a0 + 14);
                                  if ( !*(_DWORD *)(VL_Rendering_RenderingBridge_TypeInfo + 228LL) )
                                    sub_63CEFF4(VL_Rendering_RenderingBridge_TypeInfo);
                                  VL_Rendering_RenderingBridge__AddRenderEvent(0, v36, nullptr);
                                  VL_Rendering_RenderingBridge__AddRenderEvent(1, *((void **)a0 + 15), nullptr);
                                }
                                return;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
LABEL_47:
              v37 = (void *)sub_63CF120(instance, v8);
              Campus_Crowd_CrowdSystem___ctor(v37, v38, v39);
              return;
            }
            v18 = (void *)sub_63CF110(Campus_Crowd_CrowdSystem_TypeInfo);
            Campus_Crowd_CrowdSystem___ctor(v18, v14, v19);
            v20 = *((void **)a0 + 11);
            v44 = v18;
            instance = UnityEngine_Object__GetInstanceID(v14, nullptr);
            if ( !v20 )
              goto LABEL_47;
            System_Collections_Generic_Dictionary_int__object___set_Item(
              v20,
              instance,
              v44,
              Method_System_Collections_Generic_Dictionary_int__CrowdSystem__set_Item__);
          }
          else
          {
            v21 = (void *)sub_63CF110(Campus_Crowd_CrowdSystem_TypeInfo);
            Campus_Crowd_CrowdSystem___ctor(v21, v14, v22);
            v23 = *((void **)a0 + 11);
            v44 = v21;
            instance = UnityEngine_Object__GetInstanceID(v14, nullptr);
            if ( !v23 )
              goto LABEL_47;
            System_Collections_Generic_Dictionary_int__object___Add(
              v23,
              instance,
              v44,
              Method_System_Collections_Generic_Dictionary_int__CrowdSystem__Add__);
          }
          instance = (__int64)v44;
          if ( !v44 )
            goto LABEL_47;
          goto LABEL_32;
        }
      }
    }
  }
}

