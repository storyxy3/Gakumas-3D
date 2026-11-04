// VLB.SharedVLBEntityManager$$Dispose @ 0xe0cd6d8
void __fastcall VLB_SharedVLBEntityManager__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  __int64 v8; // x0
  void *v9; // x20
  void *v10; // x20
  void *v11; // x20
  void *v12; // x20
  void *v13; // x0
  void *v14; // x1

  if ( (unk_F43D9E8 & 1) == 0 )
  {
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBAdd__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBMaterialChange__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBPropertyChange__);
    sub_63CEE78(&Method_VLB_SharedVLBEntityManager_OnVLBRemove__);
    sub_63CEE78(&VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    unk_F43D9E8 = 1;
  }
  v3 = *((void **)a0 + 2);
  if ( v3 )
  {
    VLB_VLBEntityManager__Dispose(v3, a1);
    *((_QWORD *)a0 + 2) = 0;
    sub_63CEE24((char *)a0 + 16, 0, v4, v5, v6, v7);
    v8 = VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo;
    *((_DWORD *)a0 + 6) = 0;
    v9 = (void *)sub_63CF110(v8);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v9,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBAdd__,
      nullptr);
    VLB_VolumetricLightBeamSD__remove_onVLBAdd(v9, nullptr);
    v10 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v10,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBRemove__,
      nullptr);
    VLB_VolumetricLightBeamSD__remove_onVLBRemove(v10, nullptr);
    v11 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v11,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBPropertyChange__,
      nullptr);
    VLB_VolumetricLightBeamSD__remove_onVLBPropertyChange(v11, nullptr);
    v12 = (void *)sub_63CF110(VLB_VolumetricLightBeamSD_VolumetricLightBeamAction_TypeInfo);
    VLB_VolumetricLightBeamSD_VolumetricLightBeamAction___ctor(
      v12,
      a0,
      Method_VLB_SharedVLBEntityManager_OnVLBMaterialChange__,
      nullptr);
    VLB_VolumetricLightBeamSD__remove_onVLBMaterialChange(v12, nullptr);
  }
  else
  {
    v13 = (void *)sub_63CF120(0, a1);
    VLB_VLBEntityManager__Dispose(v13, v14);
  }
}

