// Campus.Crowd.CrowdAnimationComponent$$CreateCrowdAnimator @ 0xddc00e0
void __fastcall Campus_Crowd_CrowdAnimationComponent__CreateCrowdAnimator(void *a0, void *a1)
{
  void *v3; // x1
  __int64 *v4; // x20
  void *transform; // x23
  void *v6; // x21
  void *v7; // x22
  void *v8; // x24
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  void *v13; // x21
  void *v14; // x21
  __int64 v15; // x1
  __int64 v16; // x0
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5
  __int64 v21; // x22
  __int64 v22; // x21
  int v23; // w4
  void *v24; // x5
  __int64 v25; // x22
  __int64 *v26; // x20
  int v27; // w4
  void *v28; // x5
  __int64 v34; // x0
  __int64 *v35; // x19
  int v36; // w2
  int v37; // w3
  int v38; // w4
  void *v39; // x5
  unsigned __int64 v40; // x8
  __int64 v41; // x9
  signed int v42; // w11
  unsigned int v43; // w10
  __int64 v44; // x11
  __int128 v45; // q0
  __int64 v46; // x9
  __int64 v47; // x0
  void *v48; // x0
  void *v49; // x1
  void *v50; // [xsp+8h] [xbp+8h] BYREF
  void *v51; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F43BCCB & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Color___TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_Animator___);
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_CrowdVolume___);
    sub_63CEE78(&Campus_Crowd_CrowdAnimator_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdMotionDefine___TypeInfo);
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_Color___);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Vector4___TypeInfo);
    unk_F43BCCB = 1;
  }
  v51 = nullptr;
  v50 = nullptr;
  if ( UnityEngine_Component__TryGetComponent_object_(
         a0,
         &v51,
         Method_UnityEngine_Component_TryGetComponent_Animator___)
    && UnityEngine_Component__TryGetComponent_object_(
         a0,
         &v50,
         Method_UnityEngine_Component_TryGetComponent_CrowdVolume___) )
  {
    v4 = (__int64 *)((char *)a0 + 72);
    if ( *((_QWORD *)a0 + 9) )
      Campus_Crowd_CrowdAnimationComponent__Dispose(a0, v3);
    transform = UnityEngine_Component__get_transform(a0, nullptr);
    v6 = v51;
    v7 = v50;
    v8 = (void *)sub_63CF110(Campus_Crowd_CrowdAnimator_TypeInfo);
    Campus_Crowd_CrowdAnimator___ctor(v8, transform, v6, v7, nullptr);
    *((_QWORD *)a0 + 9) = v8;
    sub_63CEE24((char *)a0 + 72, (int)v8, v9, v10, v11, v12);
    v13 = *((void **)a0 + 5);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( UnityEngine_Object__op_Inequality(v13, nullptr, nullptr) )
    {
      v14 = *((void **)a0 + 6);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( UnityEngine_Object__op_Inequality(v14, nullptr, nullptr) )
      {
        v16 = sub_63CEF64(Campus_Crowd_CrowdMotionDefine___TypeInfo, 2);
        if ( !v16 )
          goto LABEL_35;
        v21 = *((_QWORD *)a0 + 5);
        v22 = v16;
        if ( v21 )
        {
          v16 = sub_63CEFF8(*((_QWORD *)a0 + 5), *(_QWORD *)(*(_QWORD *)v16 + 64LL));
          if ( !v16 )
            goto LABEL_37;
        }
        if ( !*(_DWORD *)(v22 + 24) )
          goto LABEL_36;
        *(_QWORD *)(v22 + 32) = v21;
        sub_63CEE24((void *)(v22 + 32), v21, v17, v18, v19, v20);
        v25 = *((_QWORD *)a0 + 6);
        if ( v25 )
        {
          v16 = sub_63CEFF8(*((_QWORD *)a0 + 6), *(_QWORD *)(*(_QWORD *)v22 + 64LL));
          if ( !v16 )
            goto LABEL_37;
        }
        if ( (*(_DWORD *)(v22 + 24) & 0xFFFFFFFE) == 0 )
          goto LABEL_36;
        *(_QWORD *)(v22 + 40) = v25;
        sub_63CEE24((void *)(v22 + 40), v25, v17, v18, v23, v24);
        v16 = *v4;
        if ( !*v4 )
        {
LABEL_35:
          v16 = sub_63CF120(v16, v15);
          goto LABEL_36;
        }
        Campus_Crowd_CrowdAnimator__ConnectAnimation_1((void *)v16, (void *)v22, nullptr);
      }
      else
      {
        v16 = *v4;
        if ( !*v4 )
          goto LABEL_35;
        Campus_Crowd_CrowdAnimator__ConnectAnimation((void *)v16, *((void **)a0 + 5), nullptr);
      }
    }
    v26 = (__int64 *)((char *)a0 + 64);
    if ( !Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_Color_(
            *((void **)a0 + 8),
            Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_Color___) )
      goto LABEL_28;
    v16 = sub_63CEF64(UnityEngine_Color___TypeInfo, 1);
    if ( v16 )
    {
      v15 = v16;
      if ( *(_DWORD *)(v16 + 24) )
      {
        __asm { FMOV            V0.4S, #1.0 }
        *(_OWORD *)(v16 + 32) = _Q0;
        *v26 = v16;
        sub_63CEE24((char *)a0 + 64, v16, v17, v18, v27, v28);
LABEL_28:
        v34 = sub_63CEF64(UnityEngine_Vector4___TypeInfo, 8);
        *((_QWORD *)a0 + 4) = v34;
        v35 = (__int64 *)((char *)a0 + 32);
        sub_63CEE24(v35, v34, v36, v37, v38, v39);
        v40 = 0;
        while ( 1 )
        {
          v41 = *v26;
          if ( !*v26 )
            goto LABEL_35;
          v42 = *(_DWORD *)(v41 + 24);
          v43 = (int)v40 % v42;
          if ( (int)v40 % v42 >= (unsigned int)v42 )
            break;
          v44 = *v35;
          if ( !*v35 )
            goto LABEL_35;
          if ( v40 >= *(unsigned int *)(v44 + 24) )
            break;
          v45 = *(_OWORD *)(v41 + 16LL * v43 + 32);
          v46 = v44 + 16 * v40++;
          *(_OWORD *)(v46 + 32) = v45;
          if ( v40 == 8 )
            return;
        }
      }
LABEL_36:
      sub_63CF128(v16, v15, v17, v18);
LABEL_37:
      v47 = sub_63CF144(v16);
      v48 = (void *)sub_63CEFE4(v47, 0);
      Campus_Crowd_CrowdAnimationComponent__OnDisable(v48, v49);
      return;
    }
    goto LABEL_35;
  }
}

