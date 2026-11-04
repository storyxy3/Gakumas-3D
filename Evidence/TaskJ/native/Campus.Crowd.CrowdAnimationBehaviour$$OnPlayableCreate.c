// Campus.Crowd.CrowdAnimationBehaviour$$OnPlayableCreate @ 0xddbf058
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__OnPlayableCreate(void *a0, __int64 a1, void *a2)
{
  __int64 Graph_Playable; // x22
  __int64 v7; // x1
  __int64 v8; // x23
  __int64 CrowdAnimationJob; // x0
  __int64 v10; // x1
  __int64 v11; // x0
  __int64 *v12; // x22
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  __int64 v17; // x0
  __int64 *v18; // x23
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  __int64 v23; // x0
  __int64 v24; // x1
  __int64 v25; // x28
  __int64 v26; // x27
  unsigned __int64 v27; // x24
  __int64 v28; // x25
  int v29; // w1
  int v30; // w26
  int v31; // w2
  int v32; // w3
  __int64 v33; // x8
  __int64 v34; // x8
  __int64 v35; // x29
  __int64 v36; // x27
  unsigned __int64 v37; // x28
  __int64 v38; // x26
  __int64 v39; // x24
  int v40; // w1
  int v41; // w25
  __int64 v42; // x8
  __int64 v43; // x8
  __int64 v44; // x8
  __int64 v45; // x9
  __int64 v46; // x8
  __int64 v47; // x9
  void *v48; // x0
  __int64 v49; // x1
  void *v50; // x2
  __int64 v51; // [xsp+10h] [xbp+10h] BYREF
  __int64 v52; // [xsp+A0h] [xbp+A0h] BYREF

  if ( (unk_F43BCC1 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Animations_AnimationMixerPlayable___TypeInfo);
    sub_63CEE78(&UnityEngine_Animations_AnimationMixerPlayable_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Animations_AnimationScriptPlayable_Create_CrowdAnimationJob___);
    sub_63CEE78(&UnityEngine_Animations_AnimationScriptPlayable_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_ConnectInput_AnimationMixerPlayable__AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_ConnectInput_AnimationScriptPlayable__AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_ConnectInput_Playable__AnimationScriptPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetGraph_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetInputCount_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetInputCount_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetPropagateSetTime_AnimationScriptPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetPropagateSetTime_Playable___);
    unk_F43BCC1 = 1;
  }
  Graph_Playable = UnityEngine_Playables_PlayableExtensions__GetGraph_Playable_(a1, a2);
  v8 = v7;
  memcpy(&v51, (char *)a0 + 16, 0x90u);
  if ( !*(_DWORD *)(UnityEngine_Animations_AnimationScriptPlayable_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Animations_AnimationScriptPlayable_TypeInfo);
  memcpy(&v52, &v51, 0x90u);
  CrowdAnimationJob = UnityEngine_Animations_AnimationScriptPlayable__Create_CrowdAnimationJob_(
                        Graph_Playable,
                        v8,
                        (int)&v52,
                        &byte_8);
  *((_QWORD *)a0 + 23) = v10;
  *((_QWORD *)a0 + 22) = CrowdAnimationJob;
  UnityEngine_Animations_AnimationScriptPlayable__SetProcessInputs((__int64)a0 + 176, 0, nullptr);
  UnityEngine_Playables_PlayableExtensions__SetPropagateSetTime_AnimationScriptPlayable_(
    *((_QWORD *)a0 + 22),
    *((_QWORD *)a0 + 23),
    (char *)&dword_0 + 1);
  v11 = sub_63CEF64(UnityEngine_Animations_AnimationMixerPlayable___TypeInfo, 8);
  *((_QWORD *)a0 + 24) = v11;
  v12 = (__int64 *)((char *)a0 + 192);
  sub_63CEE24((char *)a0 + 192, v11, v13, v14, v15, v16);
  v17 = sub_63CEF64(UnityEngine_Animations_AnimationMixerPlayable___TypeInfo, 4);
  *((_QWORD *)a0 + 25) = v17;
  v18 = (__int64 *)((char *)a0 + 200);
  sub_63CEE24((char *)a0 + 200, v17, v19, v20, v21, v22);
  v25 = *((_QWORD *)a0 + 24);
  if ( v25 )
  {
    v26 = 0;
    v27 = 0;
    while ( (__int64)v27 < *(int *)(v25 + 24) )
    {
      v28 = UnityEngine_Playables_PlayableExtensions__GetGraph_Playable_(a1, a2);
      v30 = v29;
      if ( !*(_DWORD *)(UnityEngine_Animations_AnimationMixerPlayable_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Animations_AnimationMixerPlayable_TypeInfo);
      v23 = UnityEngine_Animations_AnimationMixerPlayable__Create(v28, v30, nullptr);
      if ( v27 >= *(unsigned int *)(v25 + 24) )
        goto LABEL_30;
      v33 = v25 + v26;
      *(_QWORD *)(v33 + 32) = v23;
      *(_QWORD *)(v33 + 40) = v24;
      v34 = *((_QWORD *)a0 + 24);
      if ( !v34 )
        goto LABEL_28;
      if ( v27 >= *(unsigned int *)(v34 + 24) )
      {
LABEL_30:
        sub_63CF128(v23, v24, v31, v32);
        Campus_Crowd_CrowdAnimationBehaviour__OnPlayableDestroy(v48, v49, v50);
        return;
      }
      UnityEngine_Playables_PlayableExtensions__ConnectInput_AnimationScriptPlayable__AnimationMixerPlayable_(
        *((_QWORD *)a0 + 22),
        *((_QWORD *)a0 + 23),
        (unsigned int)v27,
        *(_QWORD *)(v34 + v26 + 32),
        1.0,
        *(void **)(v34 + v26 + 40));
      v25 = *v12;
      ++v27;
      v26 += 16;
      if ( !*v12 )
        goto LABEL_28;
    }
    v35 = *v18;
    if ( !*v18 )
      goto LABEL_28;
    v36 = 0;
    v37 = 0;
    v38 = 0x400000000LL;
    while ( (__int64)v37 < *(int *)(v35 + 24) )
    {
      v39 = UnityEngine_Playables_PlayableExtensions__GetGraph_Playable_(a1, a2);
      v41 = v40;
      if ( !*(_DWORD *)(UnityEngine_Animations_AnimationMixerPlayable_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Animations_AnimationMixerPlayable_TypeInfo);
      v23 = UnityEngine_Animations_AnimationMixerPlayable__Create(v39, v41, nullptr);
      if ( v37 >= *(unsigned int *)(v35 + 24) )
        goto LABEL_30;
      v42 = v35 + v36;
      *(_QWORD *)(v42 + 32) = v23;
      *(_QWORD *)(v42 + 40) = v24;
      v43 = *v12;
      if ( !*v12 )
        goto LABEL_28;
      if ( v37 + 4 >= *(unsigned int *)(v43 + 24) )
        goto LABEL_30;
      UnityEngine_Playables_PlayableExtensions__SetInputCount_AnimationMixerPlayable_(
        *(_QWORD *)(v43 + 16 * (v38 >> 32) + 32),
        *(_QWORD *)(v43 + 16 * (v38 >> 32) + 40),
        (char *)&dword_0 + 1);
      v44 = *v12;
      if ( !*v12 )
        goto LABEL_28;
      if ( v37 + 4 >= *(unsigned int *)(v44 + 24) )
        goto LABEL_30;
      v45 = *v18;
      if ( !*v18 )
        goto LABEL_28;
      if ( v37 >= *(unsigned int *)(v45 + 24) )
        goto LABEL_30;
      v46 = v44 + 16 * (v38 >> 32);
      v47 = v45 + v36;
      v36 += 16;
      v38 += 0x100000000LL;
      UnityEngine_Playables_PlayableExtensions__ConnectInput_AnimationMixerPlayable__AnimationMixerPlayable_(
        *(_QWORD *)(v46 + 32),
        *(_QWORD *)(v46 + 40),
        0,
        *(_QWORD *)(v47 + 32),
        1.0,
        *(void **)(v47 + 40));
      v35 = *v18;
      ++v37;
      if ( !*v18 )
        goto LABEL_28;
    }
  }
  else
  {
LABEL_28:
    sub_63CF120(v23, v24);
  }
  UnityEngine_Playables_PlayableExtensions__SetInputCount_Playable_(a1, (int)a2, (char *)&dword_0 + 1);
  UnityEngine_Playables_PlayableExtensions__ConnectInput_Playable__AnimationScriptPlayable_(
    a1,
    (int)a2,
    0,
    *((_QWORD *)a0 + 22),
    1.0,
    *((void **)a0 + 23));
  UnityEngine_Playables_PlayableExtensions__SetPropagateSetTime_Playable_(a1, (bool)a2, (char *)&dword_0 + 1);
}

