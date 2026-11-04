// Campus.Crowd.CrowdVolume$$BuildHierarchy @ 0xddcd900
void __fastcall Campus_Crowd_CrowdVolume__BuildHierarchy(void *a0, void *a1)
{
  __int64 transform; // x0
  __int64 v4; // x1
  void *v5; // x20
  void *gameObject; // x20
  void *v7; // x20
  int v8; // w2
  int v9; // w3
  __int64 v10; // x8
  unsigned __int64 v11; // x21
  __int64 v12; // x22
  __int64 v13; // x8
  unsigned __int64 v14; // x9
  void *v15; // x20
  __int64 v16; // x8
  __int64 v17; // x8
  __int128 *v18; // x8
  __int128 v19; // q0
  __int128 v20; // q2
  __int128 v21; // q3
  void *v22; // x0
  void *v23; // x3
  void *v24; // x0
  void *v25; // x1
  void *v26; // x2
  void *v27; // x3
  __int128 v28; // [xsp+0h] [xbp+0h] BYREF
  __int128 v29; // [xsp+10h] [xbp+10h]
  __int128 v30; // [xsp+20h] [xbp+20h]
  __int128 v31; // [xsp+30h] [xbp+30h]

  if ( (unk_F43BD47 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&StringLiteral_Reference);
    unk_F43BD47 = 1;
  }
  v28 = 0u;
  v29 = 0u;
  v30 = 0u;
  v31 = 0u;
  transform = (__int64)UnityEngine_Component__get_transform(a0, nullptr);
  if ( transform )
  {
    v5 = UnityEngine_Transform__Find((void *)transform, (void *)StringLiteral_Reference, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    transform = UnityEngine_Object__op_Inequality(v5, nullptr, nullptr);
    if ( (transform & 1) != 0 )
    {
      if ( !v5 )
        goto LABEL_26;
      gameObject = UnityEngine_Component__get_gameObject(v5, nullptr);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      UnityEngine_Object__Destroy_1(gameObject, nullptr);
    }
    v7 = *((void **)a0 + 10);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    transform = UnityEngine_Object__op_Equality(v7, nullptr, nullptr);
    if ( (transform & 1) != 0 )
      return;
    v10 = *((_QWORD *)a0 + 10);
    if ( v10 )
    {
      v11 = 0;
      v12 = 32;
      do
      {
        v13 = *(_QWORD *)(v10 + 64);
        if ( !v13 )
          break;
        v14 = *(unsigned int *)(v13 + 24);
        if ( (__int64)v11 >= (int)v14 )
          return;
        if ( v11 >= v14 )
          goto LABEL_27;
        v15 = *(void **)(v13 + 8 * v11 + 32);
        transform = System_String__IsNullOrEmpty(v15, nullptr);
        if ( (transform & 1) == 0 )
        {
          v16 = *((_QWORD *)a0 + 10);
          if ( !v16 )
            break;
          v17 = *(_QWORD *)(v16 + 96);
          if ( !v17 )
            break;
          if ( v11 >= *(unsigned int *)(v17 + 24) )
            goto LABEL_27;
          v18 = (__int128 *)(v17 + v12);
          v19 = v18[3];
          v20 = *v18;
          v21 = v18[1];
          v30 = v18[2];
          v31 = v19;
          v28 = v20;
          v29 = v21;
          v22 = UnityEngine_Component__get_transform(a0, nullptr);
          Campus_Crowd_CrowdVolume___BuildHierarchy_g__Build_16_1(v22, v15, &v28, v23);
        }
        v10 = *((_QWORD *)a0 + 10);
        ++v11;
        v12 += 64;
      }
      while ( v10 );
    }
  }
LABEL_26:
  transform = sub_63CF120(transform, v4);
LABEL_27:
  sub_63CF128(transform, v4, v8, v9);
  Campus_Crowd_CrowdVolume___BuildHierarchy_g__Build_16_1(v24, v25, v26, v27);
}

