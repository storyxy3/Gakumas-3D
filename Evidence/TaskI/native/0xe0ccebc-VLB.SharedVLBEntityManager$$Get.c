// VLB.SharedVLBEntityManager$$Get @ 0xe0ccebc
void *__fastcall VLB_SharedVLBEntityManager__Get(void *a0, void *a1)
{
  void *result; // x0
  char *v4; // x20
  void *v5; // x21
  void *v6; // x1
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5
  __int64 ObjectsOfType_object; // x0
  __int64 v12; // x1
  void *v13; // x2
  int v14; // w3
  int v15; // w8
  __int64 v16; // x21
  unsigned int v17; // w23
  __int64 v18; // x8
  __int64 *v19; // x22
  void *v20; // x20
  void *v21; // x20
  void *v22; // x20
  void *v23; // x20
  void *v24; // x0
  void *v25; // x1

  if ( (unk_F43D9E7 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Object_FindObjectsOfType_VolumetricLightBeamSD___);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBAdd__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBMaterialChange__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBPropertyChange__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBRemove__);
    sub_63CEE78(&VLB_VLBEntityManager_TypeInfo);
    sub_63CEE78(&VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    unk_F43D9E7 = 1;
  }
  v4 = (char *)a0 + 16;
  result = *((void **)a0 + 2);
  if ( result )
    goto LABEL_19;
  v5 = (void *)sub_63CF110(VLB_VLBEntityManager_TypeInfo);
  VLB_VLBEntityManager___ctor(v5, v6);
  *(_QWORD *)v4 = v5;
  sub_63CEE24((char *)a0 + 16, (int)v5, v7, v8, v9, v10);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  ObjectsOfType_object = (__int64)UnityEngine_Object__FindObjectsOfType_object_(Method_UnityEngine_Object_FindObjectsOfType_VolumetricLightBeamSD___);
  if ( ObjectsOfType_object )
  {
    v15 = *(_DWORD *)(ObjectsOfType_object + 24);
    v16 = ObjectsOfType_object;
    if ( v15 >= 1 )
    {
      v17 = 0;
      while ( v17 < v15 )
      {
        v18 = v16 + 8LL * (int)v17;
        v19 = *(__int64 **)(v18 + 32);
        if ( !v19 )
          goto LABEL_20;
        ObjectsOfType_object = UnityEngine_Behaviour__get_isActiveAndEnabled(*(void **)(v18 + 32), nullptr);
        if ( (ObjectsOfType_object & 1) != 0 )
        {
          if ( !*(_QWORD *)v4 )
            goto LABEL_20;
          ObjectsOfType_object = *(_QWORD *)(*(_QWORD *)v4 + 64LL);
          if ( !ObjectsOfType_object )
            goto LABEL_20;
          ObjectsOfType_object = VLB_EntityIndexer__IsValid((void *)ObjectsOfType_object, v19[40], v13);
          if ( (ObjectsOfType_object & 1) == 0 )
          {
            ObjectsOfType_object = *(_QWORD *)v4;
            if ( !*(_QWORD *)v4 )
              goto LABEL_20;
            ObjectsOfType_object = VLB_VLBEntityManager__CreateEntity((void *)ObjectsOfType_object, v19, v13);
            v19[40] = ObjectsOfType_object;
          }
        }
        v15 = *(_DWORD *)(v16 + 24);
        if ( (int)++v17 >= v15 )
          goto LABEL_18;
      }
      goto LABEL_21;
    }
LABEL_18:
    v20 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v20,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBAdd__,
      nullptr);
    VLB_VolumetricLightBeamSD__add_onVLBAdd(v20, nullptr);
    v21 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v21,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBRemove__,
      nullptr);
    VLB_VolumetricLightBeamSD__add_onVLBRemove(v21, nullptr);
    v22 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v22,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBPropertyChange__,
      nullptr);
    VLB_VolumetricLightBeamSD__add_onVLBPropertyChange(v22, nullptr);
    v23 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v23,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBMaterialChange__,
      nullptr);
    VLB_VolumetricLightBeamSD__add_onVLBMaterialChange(v23, nullptr);
    result = *((void **)a0 + 2);
LABEL_19:
    ++*((_DWORD *)a0 + 6);
    return result;
  }
LABEL_20:
  ObjectsOfType_object = sub_63CF120(ObjectsOfType_object, v12);
LABEL_21:
  sub_63CF128(ObjectsOfType_object, v12, (_DWORD)v13, v14);
  VLB_VLBEntityManager___ctor(v24, v25);
  return result;
}

