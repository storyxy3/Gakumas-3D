// VLB.VLBEntityManager$$UpdateEntityData @ 0xe0ce424
void __fastcall VLB_VLBEntityManager__UpdateEntityData(void *a0, __int64 a1, void *a2, bool a3, void *a4)
{
  __int64 Item; // x0
  __int64 v10; // x21
  _QWORD *v11; // x20
  __int128 v12; // q0
  __int64 v13; // x21
  int v14; // w22
  float coneRadiusEnd; // s0
  __int64 v16; // x8
  __int64 v17; // d9
  float maxGeometryDistance; // s8
  float attenuationLerpLinearQuad; // s0
  __int64 v20; // x8
  void *v21; // x0
  int *v22; // x8
  int *v23; // x9
  int *v24; // x10
  int v25; // s8
  int v26; // s9
  int v27; // s10
  int *v28; // x8
  int v29; // s0
  _DWORD *v30; // x9
  _DWORD *v31; // x8
  int v32; // w9
  int v33; // w10
  _DWORD *v34; // x8
  float v35; // s8
  float v36; // s0
  _DWORD *v37; // x8
  int v38; // s0
  int v39; // s1
  int v40; // s2
  int v41; // s3
  float v42; // s0
  float v43; // s2
  bool v44; // w8
  float *v45; // x9
  float v46; // s1
  float v47; // s0
  void *v48; // x0
  void *v49; // x1
  void *v50; // x2
  float v51[4]; // [xsp+0h] [xbp+0h]
  float v52; // [xsp+10h] [xbp+10h]
  __int128 v53; // [xsp+20h] [xbp+20h] BYREF
  __int64 v54; // [xsp+38h] [xbp+38h] BYREF
  UnityEngine_Quaternion_o beamInternalLocalRotation; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43D9ED & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
    unk_F43D9ED = 1;
  }
  Item = *((_QWORD *)a0 + 8);
  v54 = 0;
  v53 = 0u;
  if ( !Item )
    goto LABEL_32;
  Item = VLB_EntityIndexer__GetItem((void *)Item, a1, a2);
  if ( !*((_QWORD *)a0 + 4) )
    goto LABEL_32;
  v10 = Item;
  Item = (__int64)System_Collections_Generic_List_object___get_Item(
                    *((void **)a0 + 4),
                    Item,
                    Method_System_Collections_Generic_List_VLBCachedChunk__get_Item__);
  v11 = (_QWORD *)Item;
  if ( a3 )
  {
    if ( !Item )
      goto LABEL_32;
    v53 = *(_OWORD *)(Item + 24);
    Unity_Jobs_JobHandle__Complete((__int64)&v53, nullptr);
  }
  if ( !a2 )
    goto LABEL_32;
  Item = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)a2 + 440LL))(a2, *(_QWORD *)(*(_QWORD *)a2 + 448LL));
  if ( !v11 )
    goto LABEL_32;
  v12 = *(_OWORD *)((char *)a2 + 56);
  v13 = v10 >> 32;
  *(_QWORD *)v51 = v12;
  v52 = *((float *)a2 + 16);
  *(_OWORD *)(v11[17] + 16 * v13) = v12;
  v14 = *((_DWORD *)a2 + 29);
  coneRadiusEnd = VLB_VolumetricLightBeamSD__get_coneRadiusEnd(a2, nullptr);
  v16 = v11[19] + 8 * v13;
  *(_DWORD *)v16 = v14;
  *(float *)(v16 + 4) = coneRadiusEnd;
  *(_QWORD *)(v11[21] + 8 * v13) = *(_QWORD *)((char *)a2 + 196);
  v17 = *(_QWORD *)((char *)a2 + 172);
  maxGeometryDistance = VLB_VolumetricLightBeamSD__get_maxGeometryDistance(a2, nullptr);
  attenuationLerpLinearQuad = VLB_VolumetricLightBeamSD__get_attenuationLerpLinearQuad(a2, nullptr);
  v20 = v11[23] + 16 * v13;
  *(_QWORD *)v20 = v17;
  *(float *)(v20 + 8) = maxGeometryDistance;
  *(float *)(v20 + 12) = attenuationLerpLinearQuad;
  VLB_Noise3D__LoadIfNeeded(v21);
  if ( *((_BYTE *)a2 + 224) )
  {
    Item = (__int64)VLB_Config__GetInstance(0, (void *)a1);
    if ( !Item )
      goto LABEL_32;
    v22 = (int *)(Item + 80);
    v23 = (int *)(Item + 84);
    v24 = (int *)(Item + 88);
  }
  else
  {
    v22 = (int *)((char *)a2 + 228);
    v23 = (int *)((char *)a2 + 232);
    v24 = (int *)((char *)a2 + 236);
  }
  v25 = *v22;
  v26 = *v23;
  v27 = *v24;
  if ( !*((_BYTE *)a2 + 216) )
  {
    v28 = (int *)((char *)a2 + 220);
    goto LABEL_18;
  }
  Item = (__int64)VLB_Config__GetInstance(0, (void *)a1);
  if ( !Item )
  {
LABEL_32:
    v48 = (void *)sub_63CF120(Item, a1);
    VLB_SharedVLBEntityManager__OnVLBMaterialChange(v48, v49, v50);
    return;
  }
  v28 = (int *)(Item + 76);
LABEL_18:
  v29 = *v28;
  v30 = (_DWORD *)(v11[25] + 16 * v13);
  *v30 = v25;
  v30[1] = v26;
  v30[2] = v27;
  v30[3] = v29;
  v31 = (_DWORD *)(v11[27] + 8 * v13);
  if ( *((_DWORD *)a2 + 52) == 1 )
    v32 = 0;
  else
    v32 = 1065353216;
  *v31 = *((_DWORD *)a2 + 53);
  v31[1] = v32;
  *(_DWORD *)(v11[29] + 4 * v13) = *((_QWORD *)a2 + 40);
  *(float *)(v11[31] + 4 * v13) = VLB_VolumetricLightBeamSD__get_coneApexOffsetZ(a2, nullptr);
  *(float *)(v11[33] + 4 * v13) = VLB_VolumetricLightBeamSD__get_coneAngle(a2, nullptr);
  *(_DWORD *)(v11[37] + 4 * v13) = *((_DWORD *)a2 + 48);
  *(_DWORD *)(v11[39] + 4 * v13) = *((_DWORD *)a2 + 51);
  *(_DWORD *)(v11[41] + 4 * v13) = *((_DWORD *)a2 + 47);
  *(_DWORD *)(v11[43] + 4 * v13) = *((_DWORD *)a2 + 83);
  VLB_VolumetricLightBeamSD__GetInsideAndOutsideIntensity(a2, (char *)&v54 + 4, &v54, nullptr);
  v33 = v54;
  v34 = (_DWORD *)(v11[35] + 8 * v13);
  *v34 = HIDWORD(v54);
  v34[1] = v33;
  v35 = *((float *)a2 + 29);
  v36 = VLB_VolumetricLightBeamSD__get_coneRadiusEnd(a2, nullptr);
  if ( v35 <= v36 )
    v35 = v36;
  beamInternalLocalRotation = VLB_VolumetricLightBeamSD__get_beamInternalLocalRotation(a2, nullptr);
  Unity_Mathematics_quaternion__op_Implicit_1(beamInternalLocalRotation, nullptr);
  v37 = (_DWORD *)(v11[45] + 16 * v13);
  *v37 = v38;
  v37[1] = v39;
  v37[2] = v40;
  v37[3] = v41;
  v42 = VLB_VolumetricLightBeamSD__get_maxGeometryDistance(a2, nullptr);
  v43 = v52;
  v44 = 0;
  v45 = (float *)(v11[47] + 12LL * (int)v13);
  v46 = v51[1];
  *v45 = v35;
  v45[1] = v35;
  v45[2] = v42;
  if ( v51[0] > v51[1] )
    v46 = v51[0];
  if ( v46 > v52 )
    v43 = v46;
  if ( v43 >= 0.001 )
  {
    v47 = *((float *)&v54 + 1);
    if ( *((float *)&v54 + 1) >= *(float *)&v54 )
      v47 = *(float *)&v54;
    v44 = v47 >= 0.001;
  }
  *(_BYTE *)(v11[15] + v13) = v44;
}

