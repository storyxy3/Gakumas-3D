// Campus.Crowd.ClipData$$.ctor @ 0xddc2bb4
void __fastcall Campus_Crowd_ClipData___ctor(
        void *a0,
        void *a1,
        int a2,
        void *a3,
        double a4,
        float a5,
        int a6,
        bool a7,
        void *a8)
{
  __int64 v17; // x1
  __int64 v18; // x0
  __int64 *v19; // x24
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  void *AnimationClipPlayable; // x0
  __int64 v25; // x1
  int v26; // w25
  void *v27; // x2
  double v28; // d0
  __int64 v29; // x8
  __int64 v30; // x29
  unsigned __int64 v31; // x20
  int v32; // w3
  void *v33; // x26
  __int64 v34; // x27
  __int64 Graph_AnimationMixerPlayable; // x0
  void *v36; // x1
  __int64 v37; // x8
  __int64 v38; // x8
  __int64 v39; // x8
  __int64 v40; // x27
  void *v41; // x28
  float animationLength; // s0
  __int64 v43; // x8
  void *v44; // x0
  int v45; // w2
  int v46; // w3
  int v47; // w4
  void *v48; // x5
  void *v49; // x0
  int v50; // w1
  void *v51; // x2
  long double v52; // q0
  float v53; // s1
  _QWORD *v54; // [xsp+0h] [xbp+0h]
  int v55; // [xsp+Ch] [xbp+Ch]

  if ( (unk_F43BCD5 & 1) == 0 )
  {
    sub_63CEE78(&System_Math_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_ConnectInput_AnimationMixerPlayable__Playable____1);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetGraph_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetDuration_Playable___);
    sub_63CEE78(&UnityEngine_Playables_Playable___TypeInfo);
    unk_F43BCD5 = 1;
  }
  System_Object___ctor(a0, nullptr);
  if ( a7 )
    v17 = 4;
  else
    v17 = 8;
  v18 = sub_63CEF64(UnityEngine_Playables_Playable___TypeInfo, v17);
  *((_QWORD *)a0 + 2) = v18;
  v19 = (__int64 *)((char *)a0 + 16);
  sub_63CEE24((char *)a0 + 16, v18, v20, v21, v22, v23);
  if ( !a3 )
    goto LABEL_24;
  v54 = a0;
  v55 = a6;
  v26 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)a3 + 424LL))(a3, *(_QWORD *)(*(_QWORD *)a3 + 432LL));
  if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
    sub_63CEFF4(System_Math_TypeInfo);
  v28 = System_Math__Max_2(0.0, a4, nullptr);
  v29 = *v19;
  if ( *v19 )
  {
    a4 = v28;
    v30 = 0;
    v31 = 0;
    while ( (__int64)v31 < *(int *)(v29 + 24) )
    {
      AnimationClipPlayable = (void *)(*(__int64 (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)a3 + 408LL))(
                                        a3,
                                        (unsigned int)((int)v31 % v26),
                                        *(_QWORD *)(*(_QWORD *)a3 + 416LL));
      if ( AnimationClipPlayable )
      {
        if ( !a1 )
          goto LABEL_24;
        if ( v31 >= *((unsigned int *)a1 + 6) )
          goto LABEL_26;
        v33 = AnimationClipPlayable;
        v34 = *v19;
        Graph_AnimationMixerPlayable = UnityEngine_Playables_PlayableExtensions__GetGraph_AnimationMixerPlayable_(
                                         *(_QWORD *)((char *)a1 + v30 + 32),
                                         *(void **)((char *)a1 + v30 + 40));
        AnimationClipPlayable = (void *)VL_AnimationData__CreateAnimationClipPlayable(
                                          v33,
                                          Graph_AnimationMixerPlayable,
                                          v36);
        if ( !v34 )
          goto LABEL_24;
        if ( v31 >= *(unsigned int *)(v34 + 24) )
          goto LABEL_26;
        v37 = v34 + v30;
        *(_QWORD *)(v37 + 32) = AnimationClipPlayable;
        *(_QWORD *)(v37 + 40) = v25;
        v38 = *v19;
        if ( !*v19 )
          goto LABEL_24;
        if ( v31 >= *(unsigned int *)(v38 + 24) )
          goto LABEL_26;
        v39 = v38 + v30;
        v40 = *(_QWORD *)(v39 + 32);
        v41 = *(void **)(v39 + 40);
        animationLength = VL_AnimationData__get_animationLength(v33, nullptr);
        UnityEngine_Playables_PlayableExtensions__SetDuration_Playable_(v40, animationLength, v41);
        if ( v31 >= *((unsigned int *)a1 + 6) )
          goto LABEL_26;
        v43 = *v19;
        if ( !*v19 )
          goto LABEL_24;
        if ( v31 >= *(unsigned int *)(v43 + 24) )
        {
LABEL_26:
          v52 = sub_63CF128(AnimationClipPlayable, v25, (_DWORD)v27, v32);
          Campus_Crowd_ClipData__OffsetTimes(v49, *(double *)&v52, v53, v50, v51);
          return;
        }
        UnityEngine_Playables_PlayableExtensions__ConnectInput_AnimationMixerPlayable__Playable__1(
          *(_QWORD *)((char *)a1 + v30 + 32),
          *(_QWORD *)((char *)a1 + v30 + 40),
          (unsigned int)a2,
          *(_QWORD *)(v43 + v30 + 32),
          1.0,
          *(void **)(v43 + v30 + 40));
      }
      v29 = *v19;
      ++v31;
      v30 += 16;
      if ( !*v19 )
        goto LABEL_24;
    }
  }
  else
  {
LABEL_24:
    AnimationClipPlayable = (void *)sub_63CF120(AnimationClipPlayable, v25);
  }
  v44 = Campus_Crowd_ClipData__OffsetTimes(AnimationClipPlayable, a4, a5, v55, v27);
  v54[3] = v44;
  sub_63CEE24(v54 + 3, (int)v44, v45, v46, v47, v48);
}

