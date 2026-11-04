// 0xdd6a088 @ 0xdd6a088
void __fastcall Campus_Common_Live_CampusLiveBinder__ApplyOverrideActorHierarchyTransforms(
        void *a0,
        void *a1,
        void *a2)
{
  int v3; // w3
  _QWORD *v4; // x19
  void *v5; // x20
  __int64 v6; // x8
  int32x2_t v7; // d8
  unsigned __int64 v8; // x23
  __int64 v9; // x22
  void *Item; // x0
  __int64 v11; // x10
  void *v12; // x21
  __int64 v13; // x27
  __int64 v14; // x8
  unsigned __int64 v15; // x28
  __int64 v16; // x25
  void *v17; // x22
  void *v18; // x0
  void *v19; // x1
  void *v20; // [xsp+8h] [xbp+8h] BYREF
  UnityEngine_Vector3_o v21; // 0:kr10_12.12
  UnityEngine_Quaternion_o v22; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v4 = a1;
  v5 = a0;
  if ( (unk_F43BA27 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_CampusActorController_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA27 = 1;
  }
  v20 = nullptr;
  if ( !v4 )
  {
LABEL_42:
    v18 = (void *)sub_63CF120(a0, a1);
    Campus_Common_Live_CampusLiveBinder__DisableJointLimitIfNeeded(v18, v19);
    return;
  }
  v6 = v4[3];
  if ( (int)v6 >= 1 )
  {
    v7.n64_u64[0] = vdup_n_s32(0x3C8EFA35u).n64_u64[0];
    v8 = 0;
    while ( v8 < (unsigned int)v6 )
    {
      v9 = v4[v8 + 4];
      if ( v9 )
      {
        if ( *(_QWORD *)(v9 + 24) )
        {
          a1 = (void *)*(unsigned int *)(v9 + 16);
          if ( ((unsigned int)a1 & 0x80000000) == 0 )
          {
            a0 = *((void **)v5 + 8);
            if ( !a0 )
              goto LABEL_42;
            if ( (int)a1 < *((_DWORD *)a0 + 6) )
            {
              Item = System_Collections_Generic_List_object___get_Item(
                       a0,
                       (int)a1,
                       Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
              if ( Item
                && (v11 = *(unsigned __int8 *)(Campus_Common_CampusActorController_TypeInfo + 304LL),
                    *(unsigned __int8 *)(*(_QWORD *)Item + 304LL) >= (unsigned int)v11) )
              {
                v12 = *(_QWORD *)(*(_QWORD *)(*(_QWORD *)Item + 200LL) + 8 * v11 - 8) == Campus_Common_CampusActorController_TypeInfo
                    ? Item
                    : nullptr;
              }
              else
              {
                v12 = nullptr;
              }
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              a0 = (void *)UnityEngine_Object__op_Equality(v12, nullptr, nullptr);
              if ( ((unsigned __int8)a0 & 1) == 0 )
              {
                v13 = *(_QWORD *)(v9 + 24);
                if ( !v13 )
                  goto LABEL_42;
                v14 = *(_QWORD *)(v13 + 24);
                if ( (int)v14 >= 1 )
                {
                  v15 = 0;
                  while ( v15 < (unsigned int)v14 )
                  {
                    v16 = *(_QWORD *)(v13 + 32 + 8 * v15);
                    if ( v16 )
                    {
                      a0 = (void *)System_String__IsNullOrEmpty(*(void **)(v16 + 16), nullptr);
                      if ( ((unsigned __int8)a0 & 1) == 0 )
                      {
                        if ( !v12 )
                          goto LABEL_42;
                        a0 = (void *)VL_Core_VLActorController__TryGetBoneTransformByName(
                                       v12,
                                       *(void **)(v16 + 16),
                                       &v20,
                                       nullptr);
                        if ( ((unsigned __int8)a0 & 1) != 0 )
                        {
                          if ( *(_BYTE *)(v16 + 24) )
                          {
                            a0 = v20;
                            if ( !v20 )
                              goto LABEL_42;
                            UnityEngine_Transform__set_localPosition(v20, *(UnityEngine_Vector3_o *)(v16 + 28), nullptr);
                          }
                          if ( *(_BYTE *)(v16 + 40) )
                          {
                            v17 = v20;
                            *(float32x2_t *)&v21.x = vmul_f32(*(float32x2_t *)(v16 + 44), v7);
                            v21.z = *(float *)(v16 + 52) * 0.017453;
                            v22 = UnityEngine_Quaternion__Internal_FromEulerRad(v21, nullptr);
                            if ( !v17 )
                              goto LABEL_42;
                            UnityEngine_Transform__set_localRotation(v17, v22, nullptr);
                          }
                          if ( *(_BYTE *)(v16 + 56) )
                          {
                            a0 = v20;
                            if ( !v20 )
                              goto LABEL_42;
                            UnityEngine_Transform__set_localScale(v20, *(UnityEngine_Vector3_o *)(v16 + 60), nullptr);
                          }
                        }
                      }
                    }
                    LODWORD(v14) = *(_DWORD *)(v13 + 24);
                    if ( (__int64)++v15 >= (int)v14 )
                      goto LABEL_39;
                  }
                  break;
                }
              }
            }
          }
        }
      }
LABEL_39:
      LODWORD(v6) = *((_DWORD *)v4 + 6);
      if ( (__int64)++v8 >= (int)v6 )
        return;
    }
    sub_63CF128(a0, a1, (_DWORD)a2, v3);
    goto LABEL_42;
  }
}

