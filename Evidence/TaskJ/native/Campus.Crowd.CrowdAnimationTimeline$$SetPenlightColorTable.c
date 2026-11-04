// Campus.Crowd.CrowdAnimationTimeline$$SetPenlightColorTable @ 0xddc1664
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetPenlightColorTable(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0
  __int64 v6; // x1
  int v7; // w2
  int v8; // w3
  __int64 v14; // x0
  __int64 *v15; // x19
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  unsigned __int64 v20; // x8
  signed int v21; // w10
  unsigned int v22; // w9
  __int64 v23; // x10
  __int128 v24; // q0
  __int64 v25; // x9
  void *v26; // x0
  void *v27; // x1

  if ( (unk_F43BCD4 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Color___TypeInfo);
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_Color___);
    sub_63CEE78(&UnityEngine_Vector4___TypeInfo);
    unk_F43BCD4 = 1;
  }
  if ( Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_Color_(
         a1,
         Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_Color___) )
  {
    v5 = sub_63CEF64(UnityEngine_Color___TypeInfo, 1);
    if ( !v5 )
      goto LABEL_15;
    a1 = (void *)v5;
    if ( !*(_DWORD *)(v5 + 24) )
    {
LABEL_14:
      sub_63CF128(v5, v6, v7, v8);
      goto LABEL_15;
    }
    __asm { FMOV            V0.4S, #1.0 }
    *(_OWORD *)(v5 + 32) = _Q0;
  }
  v14 = sub_63CEF64(UnityEngine_Vector4___TypeInfo, 8);
  *((_QWORD *)a0 + 5) = v14;
  v15 = (__int64 *)((char *)a0 + 40);
  sub_63CEE24(v15, v14, v16, v17, v18, v19);
  if ( a1 )
  {
    v20 = 0;
    while ( 1 )
    {
      v21 = *((_DWORD *)a1 + 6);
      v22 = (int)v20 % v21;
      if ( (int)v20 % v21 >= (unsigned int)v21 )
        goto LABEL_14;
      v23 = *v15;
      if ( !*v15 )
        break;
      if ( v20 >= *(unsigned int *)(v23 + 24) )
        goto LABEL_14;
      v24 = *((_OWORD *)a1 + v22 + 2);
      v25 = v23 + 16 * v20++;
      *(_OWORD *)(v25 + 32) = v24;
      if ( v20 == 8 )
        return;
    }
  }
LABEL_15:
  v26 = (void *)sub_63CF120(v5, v6);
  Campus_Crowd_CrowdAnimationTimeline__InitializeCrowdAnimator(v26, v27);
}

