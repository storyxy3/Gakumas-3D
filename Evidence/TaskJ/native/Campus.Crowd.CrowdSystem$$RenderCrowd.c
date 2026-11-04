// Campus.Crowd.CrowdSystem$$RenderCrowd @ 0xddc54e0
void __fastcall Campus_Crowd_CrowdSystem__RenderCrowd(void *a0, void *a1, int a2, void *a3)
{
  void *v7; // x2
  __int64 v8; // x8
  void *v9; // x0
  void *v10; // x1
  void *AnimationComponent; // x0
  __int64 *v12; // x23
  void *CrowdPenlight; // x0
  __int64 v14; // x8
  void *v15; // x22
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  bool v19; // zf
  void *v20; // x22
  void *v21; // x6
  void *v22; // x4
  __int64 v23; // x8
  __int128 v24; // q0
  __int64 v25; // x8
  void *v26; // x2
  void *v27; // x0
  void *v28; // x1
  void *v29; // x2
  int v30; // w3
  void *v31; // x4
  __int128 v32; // [xsp+0h] [xbp+0h] BYREF
  __int64 v33; // [xsp+10h] [xbp+10h]

  if ( (unk_F43BD1B & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_ICrowdAnimation_TypeInfo);
    sub_63CEE78(&Campus_Crowd_ICrowdPenlight_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD1B = 1;
  }
  v7 = *((void **)a0 + 4);
  if ( v7 )
  {
    v8 = *((_QWORD *)a0 + 10);
    if ( v8 )
    {
      v9 = *((void **)a0 + 7);
      if ( v9 )
      {
        Campus_Crowd_CrowdMeshRenderSystem__Render(
          v9,
          a1,
          v7,
          *(_QWORD *)(v8 + 112),
          *(_QWORD *)(v8 + 120),
          (void *)(unsigned int)a2);
        AnimationComponent = *((void **)a0 + 5);
        if ( !AnimationComponent )
          goto LABEL_31;
        AnimationComponent = Campus_Crowd_CrowdVolume__get_AnimationComponent(AnimationComponent, v10);
        if ( !*((_QWORD *)a0 + 5) )
          goto LABEL_31;
        v12 = (__int64 *)AnimationComponent;
        CrowdPenlight = Campus_Crowd_CrowdVolume__get_CrowdPenlight(*((void **)a0 + 5), v10);
        if ( v12 )
        {
          v14 = *v12;
          v15 = CrowdPenlight;
          v16 = *(unsigned __int16 *)(*v12 + 302);
          if ( *(_WORD *)(*v12 + 302) )
          {
            v17 = (int *)(*(_QWORD *)(v14 + 176) + 8LL);
            while ( *((_QWORD *)v17 - 1) != Campus_Crowd_ICrowdAnimation_TypeInfo )
            {
              --v16;
              v17 += 4;
              if ( !v16 )
                goto LABEL_13;
            }
            v18 = v14 + 16LL * *v17 + 312;
          }
          else
          {
LABEL_13:
            v18 = sub_6408234(v12, Campus_Crowd_ICrowdAnimation_TypeInfo, 0);
          }
          v19 = !(*(__int64 (__fastcall **)(__int64 *, _QWORD))v18)(v12, *(_QWORD *)(v18 + 8)) || v15 == nullptr;
          if ( !v19 && (sub_E1B7008(0, Campus_Crowd_ICrowdPenlight_TypeInfo, v15) & 1) == 0 && *((_QWORD *)a0 + 9) )
          {
            v20 = *((void **)a0 + 6);
            if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
              sub_63CEFF4(UnityEngine_Object_TypeInfo);
            AnimationComponent = (void *)UnityEngine_Object__op_Inequality(v20, nullptr, nullptr);
            if ( ((unsigned __int8)AnimationComponent & 1) == 0 )
              goto LABEL_26;
            AnimationComponent = *((void **)a0 + 6);
            if ( !AnimationComponent )
              goto LABEL_31;
            AnimationComponent = Campus_AudiencePenlight_AudiencePenlightVolume__get_AudiencePenlight(
                                   AnimationComponent,
                                   v10);
            v22 = AnimationComponent;
            if ( !AnimationComponent )
LABEL_26:
              v22 = *((void **)a0 + 14);
            v23 = *((_QWORD *)a0 + 10);
            if ( v23 )
            {
              AnimationComponent = *((void **)a0 + 9);
              if ( AnimationComponent )
              {
                v24 = *(_OWORD *)(v23 + 152);
                v25 = *(_QWORD *)(v23 + 168);
                v26 = *((void **)a0 + 4);
                v32 = v24;
                v33 = v25;
                Campus_Crowd_PenlightMeshRenderSystem__Render(
                  AnimationComponent,
                  a1,
                  v26,
                  (UnityEngine_Bounds_o *)&v32,
                  v22,
                  a2,
                  v21);
                return;
              }
            }
LABEL_31:
            v27 = (void *)sub_63CF120(AnimationComponent, v10);
            Campus_Crowd_CrowdSystem__RenderBillboardCrowd(v27, v28, v29, v30, v31);
          }
        }
      }
    }
  }
}

