// Campus.Crowd.CrowdSystem$$SetupRenderingParameter @ 0xddc6208
void __fastcall Campus_Crowd_CrowdSystem__SetupRenderingParameter(void *a0, void *a1)
{
  __int64 v3; // x8
  void *v4; // x20
  void *v5; // x1
  void *v6; // x2
  void *AnimationComponent; // x0
  void *v8; // x2
  void *v9; // x21
  void *CrowdPenlight; // x0
  void *v11; // x20
  void *v12; // x1
  void *v13; // x20
  void *v14; // x19
  void *v15; // x3
  void *v16; // x0
  __int64 v17; // x1
  void *v18; // x2
  void *v19; // x3
  __int64 v20; // [xsp+0h] [xbp+0h] BYREF
  void *v21; // [xsp+8h] [xbp+8h]

  if ( (unk_F43BD1A & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_ICrowdAnimation_TypeInfo);
    sub_63CEE78(&Campus_Crowd_ICrowdPenlight_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD1A = 1;
  }
  v3 = *((_QWORD *)a0 + 4);
  v20 = 0;
  v21 = nullptr;
  if ( v3 && *((_QWORD *)a0 + 10) && *((_QWORD *)a0 + 7) )
  {
    v4 = *((void **)a0 + 5);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( !UnityEngine_Object__op_Equality(v4, nullptr, nullptr) )
    {
      AnimationComponent = *((void **)a0 + 10);
      if ( !AnimationComponent )
        goto LABEL_22;
      Campus_Crowd_CrowdSystemData__SetPersonInfoBytes(AnimationComponent, *((void **)a0 + 4), v6);
      AnimationComponent = *((void **)a0 + 10);
      if ( !AnimationComponent )
        goto LABEL_22;
      Campus_Crowd_CrowdSystemData__SetBoundsMin_1(AnimationComponent, *((void **)a0 + 4), v8);
      AnimationComponent = *((void **)a0 + 5);
      if ( !AnimationComponent )
        goto LABEL_22;
      AnimationComponent = Campus_Crowd_CrowdVolume__get_AnimationComponent(AnimationComponent, v5);
      if ( !*((_QWORD *)a0 + 5) )
        goto LABEL_22;
      v9 = AnimationComponent;
      CrowdPenlight = Campus_Crowd_CrowdVolume__get_CrowdPenlight(*((void **)a0 + 5), v5);
      if ( v9 )
      {
        v11 = CrowdPenlight;
        v20 = sub_E1B7008(0, Campus_Crowd_ICrowdAnimation_TypeInfo, v9);
        v21 = v12;
        if ( v20 )
        {
          if ( v11 && (sub_E1B7008(0, Campus_Crowd_ICrowdPenlight_TypeInfo, v11) & 1) == 0 )
          {
            AnimationComponent = *((void **)a0 + 5);
            if ( AnimationComponent )
            {
              v13 = *((void **)a0 + 7);
              v14 = *((void **)a0 + 4);
              AnimationComponent = Campus_Crowd_CrowdVolume__get_AnimationComponent(AnimationComponent, v5);
              if ( AnimationComponent )
              {
                AnimationComponent = (void *)sub_E1B7008(1, Campus_Crowd_ICrowdAnimation_TypeInfo, AnimationComponent);
                v20 = (__int64)AnimationComponent;
                v21 = v5;
                if ( v13 )
                {
                  Campus_Crowd_CrowdMeshRenderSystem__SetHandMatrices(v13, v14, &v20, v15);
                  return;
                }
              }
            }
LABEL_22:
            v16 = (void *)sub_63CF120(AnimationComponent, v5);
            Campus_Crowd_CrowdSystem__BakeBillboardCrowd(v16, v17, v18, v19);
          }
        }
      }
    }
  }
}

