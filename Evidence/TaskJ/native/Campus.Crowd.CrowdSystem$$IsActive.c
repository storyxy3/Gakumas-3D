// Campus.Crowd.CrowdSystem$$IsActive @ 0xddc4510
bool __fastcall Campus_Crowd_CrowdSystem__IsActive(void *a0, void *a1)
{
  void *v3; // x20
  _BOOL8 v4; // x0
  __int64 v5; // x1
  __int64 v6; // x8
  void *v7; // x20
  __int64 v8; // x8
  __int128 v9; // q0
  __int64 v10; // x8
  void *v11; // x0
  bool result; // w0
  void *v14; // x0
  void *v15; // x1
  bool v16; // w2
  void *v17; // x3
  void *v18; // x4
  __int128 v19; // [xsp+0h] [xbp+0h] BYREF
  __int64 v20; // [xsp+10h] [xbp+10h]

  if ( (unk_F43BD15 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD15 = 1;
  }
  v3 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v4 = UnityEngine_Object__op_Equality(v3, nullptr, nullptr);
  if ( v4 )
    return 0;
  v6 = *((_QWORD *)a0 + 5);
  if ( !v6 )
    goto LABEL_15;
  v7 = *(void **)(v6 + 80);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v7, nullptr, nullptr) || !*((_QWORD *)a0 + 10) )
    return 0;
  UnityEngine_GeometryUtility__CalculateFrustumPlanes_1(*((void **)a0 + 2), *((void **)a0 + 3), nullptr);
  v8 = *((_QWORD *)a0 + 10);
  if ( v8 )
  {
    v9 = *(_OWORD *)(v8 + 152);
    v10 = *(_QWORD *)(v8 + 168);
    v11 = *((void **)a0 + 3);
    v19 = v9;
    v20 = v10;
    return UnityEngine_GeometryUtility__TestPlanesAABB(v11, (UnityEngine_Bounds_o *)&v19, nullptr);
  }
LABEL_15:
  v14 = (void *)sub_63CF120(v4, v5);
  Campus_Crowd_CrowdRenderingSetupData__Update(v14, v15, v16, v17, v18);
  return result;
}

