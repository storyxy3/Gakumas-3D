// Campus.Crowd.CrowdSystem$$ComputeCrowdSkinning @ 0xddc5fb0
void __fastcall Campus_Crowd_CrowdSystem__ComputeCrowdSkinning(void *a0, void *a1, void *a2)
{
  void *v5; // x21
  void *v6; // x1
  void *v7; // x0
  __int64 *AnimationComponent; // x0
  __int64 v9; // x8
  __int64 *v10; // x21
  __int64 v11; // x9
  int *v12; // x10
  __int64 v13; // x0
  __int64 v14; // x8
  void *v15; // x22
  int count; // w0
  __int64 v17; // x8
  int v18; // w23
  __int64 v19; // x9
  int *v20; // x10
  __int64 v21; // x0
  int v22; // w1
  __int64 v23; // x0
  void *v24; // x1
  void *v25; // x3
  __int64 v26; // x8
  void *v27; // x0
  void *v28; // x1
  void *v29; // x2

  if ( (unk_F43BD17 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_GraphicsBuffer_SetData_Matrix4x4___);
    sub_63CEE78(&Campus_Crowd_ICrowdAnimation_TypeInfo);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD17 = 1;
  }
  v5 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v5, nullptr, nullptr) )
    return;
  v7 = *((void **)a0 + 5);
  if ( !v7 )
    goto LABEL_29;
  AnimationComponent = (__int64 *)Campus_Crowd_CrowdVolume__get_AnimationComponent(v7, v6);
  if ( !AnimationComponent )
    return;
  v9 = *AnimationComponent;
  v10 = AnimationComponent;
  v11 = *(unsigned __int16 *)(*AnimationComponent + 302);
  if ( *(_WORD *)(*AnimationComponent + 302) )
  {
    v12 = (int *)(*(_QWORD *)(v9 + 176) + 8LL);
    while ( *((_QWORD *)v12 - 1) != Campus_Crowd_ICrowdAnimation_TypeInfo )
    {
      --v11;
      v12 += 4;
      if ( !v11 )
        goto LABEL_12;
    }
    v13 = v9 + 16LL * *v12 + 312;
  }
  else
  {
LABEL_12:
    v13 = sub_6408234(AnimationComponent, Campus_Crowd_ICrowdAnimation_TypeInfo, 0);
  }
  v7 = (void *)(*(__int64 (__fastcall **)(__int64 *, _QWORD))v13)(v10, *(_QWORD *)(v13 + 8));
  if ( !v7 )
    return;
  v14 = *((_QWORD *)a0 + 10);
  if ( !v14 || (v15 = *(void **)(v14 + 32)) == nullptr )
  {
LABEL_29:
    v27 = (void *)sub_63CF120(v7, v6);
    Campus_Crowd_CrowdSystem__ComputeCrowd(v27, v28, v29);
    return;
  }
  if ( UnityEngine_GraphicsBuffer__IsValid(*(void **)(v14 + 32), nullptr) )
  {
    count = UnityEngine_GraphicsBuffer__get_count(v15, nullptr);
    v17 = *v10;
    v18 = count;
    v19 = *(unsigned __int16 *)(*v10 + 302);
    if ( *(_WORD *)(*v10 + 302) )
    {
      v20 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v20 - 1) != Campus_Crowd_ICrowdAnimation_TypeInfo )
      {
        --v19;
        v20 += 4;
        if ( !v19 )
          goto LABEL_22;
      }
      v21 = v17 + 16LL * *v20 + 312;
    }
    else
    {
LABEL_22:
      v21 = sub_6408234(v10, Campus_Crowd_ICrowdAnimation_TypeInfo, 0);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v21)(v10, *(_QWORD *)(v21 + 8));
    if ( v18 == v22 )
    {
      v23 = sub_E1B7008(0, Campus_Crowd_ICrowdAnimation_TypeInfo, v10);
      UnityEngine_GraphicsBuffer__SetData_Matrix4x4_(v15, v23, v24);
      v26 = *((_QWORD *)a0 + 10);
      if ( v26 )
      {
        v7 = *((void **)a0 + 7);
        if ( v7 )
        {
          Campus_Crowd_CrowdMeshRenderSystem__ComputeSkinning(v7, a1, *(void **)(v26 + 32), v25);
          return;
        }
      }
      goto LABEL_29;
    }
  }
}

