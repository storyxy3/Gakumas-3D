// Campus.Crowd.CrowdTimelineTrack$$CreateLayerMixer @ 0xddcc8b8
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall Campus_Crowd_CrowdTimelineTrack__CreateLayerMixer(void *a0, __int64 a1, void *a2, int a3, void *a4)
{
  void **v5; // x19
  __int64 v6; // x21
  void *v7; // x22
  void *v10; // x20
  __int64 v11; // x8
  void **GenericBinding; // x0
  __int64 v13; // x10
  void *Clips; // x0
  void *v16; // x2
  __int64 v17; // x8
  __int64 v18; // x9
  void *v19; // x22
  void *v20; // x23
  __int64 v21; // x0
  int v22; // w2
  int v23; // w3
  int v24; // w4
  void *v25; // x5
  __int64 v26; // x8
  void *v27; // x21
  __int64 v28; // x9
  int *v29; // x10
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x1
  __int64 v33; // x21
  __int64 v34; // x8
  __int64 v35; // x9
  int *v36; // x10
  __int64 v37; // x0
  __int64 v38; // x0
  __int64 v39; // x1
  __int64 v40; // x8
  __int64 v41; // x9
  int *v42; // x10
  __int64 v43; // x0
  void *v44; // x21
  void *v45; // x23
  int v46; // w22
  void *v47; // x3
  void *v48; // x22
  __int64 v49; // x8
  __int64 v50; // x9
  int *v51; // x10
  __int64 v52; // x0
  void *ChildTracks; // x0
  void *v54; // x0
  int v55; // w0
  void *v56; // x2
  void *v57; // x0
  __int64 v58; // x8
  __int64 v59; // x9
  void *v60; // x22
  __int64 v61; // x0
  int v62; // w2
  int v63; // w3
  int v64; // w4
  void *v65; // x5
  __int64 v66; // x8
  void *v67; // x20
  __int64 v68; // x9
  int *v69; // x10
  __int64 v70; // x0
  __int64 v71; // x0
  __int64 v72; // x1
  __int64 v73; // x20
  __int64 v74; // x8
  __int64 v75; // x9
  int *v76; // x10
  __int64 v77; // x0
  __int64 v78; // x0
  __int64 v79; // x1
  __int64 v80; // x8
  __int64 v81; // x9
  int *v82; // x10
  __int64 v83; // x0
  void *v84; // x20
  void *v85; // x22
  void *v86; // x3
  __int64 *i; // x8
  __int64 v88; // x8
  __int64 v89; // x9
  int *v90; // x10
  __int64 v91; // x0
  int v92; // w2
  int v93; // w3
  int v94; // w4
  void *v95; // x5
  void *v96; // x0
  long double v97; // q0
  void *v98; // x21
  int v99; // w1
  void *v100; // [xsp+0h] [xbp+0h] BYREF
  __int64 *v101; // [xsp+8h] [xbp+8h]
  __int64 *v102; // [xsp+10h] [xbp+10h] BYREF
  __int64 v103; // [xsp+18h] [xbp+18h] BYREF
  void *v104; // [xsp+20h] [xbp+20h]
  void *v105; // [xsp+28h] [xbp+28h] BYREF

  v5 = (void **)&unk_F43B000;
  v6 = (unsigned int)a4;
  v7 = *(void **)&a3;
  v10 = a0;
  if ( (unk_F43BD3D & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdAnimationTimeline_TypeInfo);
    sub_63CEE78(&Method_System_Linq_Enumerable_Count_TimelineClip___);
    sub_63CEE78(&Method_System_Linq_Enumerable_FirstOrDefault_TrackAsset___);
    sub_63CEE78(&Method_System_Linq_Enumerable_Select_TimelineClip__ValueTuple_CrowdTimelineBehaviour__int____);
    sub_63CEE78(&System_Func_TimelineClip__int__ValueTuple_CrowdTimelineBehaviour__int___TypeInfo);
    sub_63CEE78(&Method_UnityEngine_GameObject_TryGetComponent_PlayableDirector___);
    sub_63CEE78(&System_IDisposable_TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerable_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerator_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo);
    sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__GetBehaviour__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__op_Implicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__TypeInfo);
    sub_63CEE78(&Method_Campus_Crowd_CrowdTimelineTrack___c__CreateLayerMixer_b__0_0__);
    sub_63CEE78(&Method_Campus_Crowd_CrowdTimelineTrack___c__CreateLayerMixer_b__0_1__);
    a0 = (void *)sub_63CEE78(&Campus_Crowd_CrowdTimelineTrack___c_TypeInfo);
    unk_F43BD3D = 1;
  }
  v104 = nullptr;
  v105 = nullptr;
  v102 = nullptr;
  v103 = 0;
  if ( !v7 )
    goto LABEL_121;
  if ( !UnityEngine_GameObject__TryGetComponent_object_(
          v7,
          &v105,
          Method_UnityEngine_GameObject_TryGetComponent_PlayableDirector___) )
    return UnityEngine_Timeline_TrackAsset__CreateTrackMixer(v10, a1, a2, (int)v7, (void *)(unsigned int)v6);
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__TypeInfo);
  v11 = UnityEngine_Playables_ScriptPlayable_object___Create(a1, (int)a2, (void *)(unsigned int)v6);
  a0 = v105;
  v103 = v11;
  v104 = (void *)a1;
  if ( !v105 )
    goto LABEL_121;
  GenericBinding = (void **)UnityEngine_Playables_PlayableDirector__GetGenericBinding(v105, v10, nullptr);
  if ( GenericBinding
    && (v13 = *(unsigned __int8 *)(Campus_Crowd_CrowdAnimationTimeline_TypeInfo + 304LL),
        *((unsigned __int8 *)*GenericBinding + 304) >= (unsigned int)v13) )
  {
    if ( *(_QWORD *)(*((_QWORD *)*GenericBinding + 25) + 8 * v13 - 8) == Campus_Crowd_CrowdAnimationTimeline_TypeInfo )
      v5 = GenericBinding;
    else
      v5 = nullptr;
  }
  else
  {
    v5 = nullptr;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v5, nullptr, nullptr) )
    return UnityEngine_Timeline_TrackAsset__CreateTrackMixer(v10, a1, a2, (int)v7, (void *)(unsigned int)v6);
  Clips = UnityEngine_Timeline_TrackAsset__GetClips(v10, nullptr);
  a0 = (void *)System_Linq_Enumerable__Count_object_(Clips, Method_System_Linq_Enumerable_Count_TimelineClip___);
  if ( !v5 )
    goto LABEL_121;
  Campus_Crowd_CrowdAnimationTimeline__SetAnimationCount(v5, (int)a0, v16);
  v6 = (__int64)UnityEngine_Timeline_TrackAsset__GetClips(v10, nullptr);
  v17 = Campus_Crowd_CrowdTimelineTrack___c_TypeInfo;
  if ( !*(_DWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo);
    v17 = Campus_Crowd_CrowdTimelineTrack___c_TypeInfo;
  }
  v18 = *(_QWORD *)(v17 + 184);
  v19 = *(void **)(v18 + 8);
  if ( !v19 )
  {
    if ( !*(_DWORD *)(v17 + 228) )
    {
      sub_63CEFF4(v17);
      v18 = *(_QWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 184LL);
    }
    v20 = *(void **)v18;
    v19 = (void *)sub_63CF110(System_Func_TimelineClip__int__ValueTuple_CrowdTimelineBehaviour__int___TypeInfo);
    System_Func_object__int__ValueTuple_object__int_____ctor(
      v19,
      v20,
      Method_Campus_Crowd_CrowdTimelineTrack___c__CreateLayerMixer_b__0_0__,
      nullptr);
    v21 = *(_QWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 184LL);
    *(_QWORD *)(v21 + 8) = v19;
    sub_63CEE24((void *)(v21 + 8), (int)v19, v22, v23, v24, v25);
  }
  a0 = System_Linq_Enumerable__Select_object__ValueTuple_object__int___1(
         (void *)v6,
         v19,
         Method_System_Linq_Enumerable_Select_TimelineClip__ValueTuple_CrowdTimelineBehaviour__int____);
  if ( !a0 )
    goto LABEL_121;
  v26 = *(_QWORD *)a0;
  v27 = a0;
  v28 = *(unsigned __int16 *)(*(_QWORD *)a0 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)a0 + 302LL) )
  {
    v29 = (int *)(*(_QWORD *)(v26 + 176) + 8LL);
    while ( *((_QWORD *)v29 - 1) != System_Collections_Generic_IEnumerable_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo )
    {
      --v28;
      v29 += 4;
      if ( !v28 )
        goto LABEL_30;
    }
    v30 = v26 + 16LL * *v29 + 312;
  }
  else
  {
LABEL_30:
    v30 = sub_6408234(a0, System_Collections_Generic_IEnumerable_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo, 0);
  }
  v31 = (*(__int64 (__fastcall **)(void *, _QWORD))v30)(v27, *(_QWORD *)(v30 + 8));
  v102 = (__int64 *)v31;
  v100 = nullptr;
  v101 = (__int64 *)&v102;
  if ( v31 )
  {
    v33 = v31;
    while ( 1 )
    {
      v34 = *(_QWORD *)v33;
      v35 = *(unsigned __int16 *)(*(_QWORD *)v33 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v33 + 302LL) )
      {
        v36 = (int *)(*(_QWORD *)(v34 + 176) + 8LL);
        while ( *((_QWORD *)v36 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v35;
          v36 += 4;
          if ( !v35 )
            goto LABEL_38;
        }
        v37 = v34 + 16LL * *v36 + 312;
      }
      else
      {
LABEL_38:
        v37 = sub_6408234(v33, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v38 = (*(__int64 (__fastcall **)(__int64, _QWORD))v37)(v33, *(_QWORD *)(v37 + 8));
      if ( (v38 & 1) == 0 )
        break;
      v6 = (__int64)v102;
      if ( !v102 )
      {
        v78 = sub_63CF120(v38, v39);
LABEL_120:
        a0 = (void *)sub_63CF120(v78, v79);
        goto LABEL_121;
      }
      v40 = *v102;
      v41 = *(unsigned __int16 *)(*v102 + 302);
      if ( *(_WORD *)(*v102 + 302) )
      {
        v42 = (int *)(*(_QWORD *)(v40 + 176) + 8LL);
        while ( *((_QWORD *)v42 - 1) != System_Collections_Generic_IEnumerator_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo )
        {
          --v41;
          v42 += 4;
          if ( !v41 )
            goto LABEL_46;
        }
        v43 = v40 + 16LL * *v42 + 312;
      }
      else
      {
LABEL_46:
        v43 = sub_6408234(
                v102,
                System_Collections_Generic_IEnumerator_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo,
                0);
      }
      v31 = (*(__int64 (__fastcall **)(__int64, _QWORD))v43)(v6, *(_QWORD *)(v43 + 8));
      v44 = (void *)v31;
      if ( v31 )
      {
        v45 = *(void **)(v31 + 16);
        v46 = v32;
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        v31 = UnityEngine_Object__op_Equality(v45, nullptr, nullptr);
        if ( (v31 & 1) == 0 )
          Campus_Crowd_CrowdAnimationTimeline__SetAnimationData(v5, v46, v44, v47);
      }
      v33 = (__int64)v102;
      if ( !v102 )
        goto LABEL_54;
    }
  }
  else
  {
LABEL_54:
    sub_63CF120(v31, v32);
  }
  v6 = 0;
  v48 = v102;
  if ( v102 )
  {
    v49 = *v102;
    v50 = *(unsigned __int16 *)(*v102 + 302);
    if ( *(_WORD *)(*v102 + 302) )
    {
      v51 = (int *)(*(_QWORD *)(v49 + 176) + 8LL);
      while ( *((_QWORD *)v51 - 1) != System_IDisposable_TypeInfo )
      {
        --v50;
        v51 += 4;
        if ( !v50 )
          goto LABEL_60;
      }
      v52 = v49 + 16LL * *v51 + 312;
    }
    else
    {
LABEL_60:
      v52 = sub_6408234(v102, System_IDisposable_TypeInfo, 0);
    }
    (*(void (__fastcall **)(void *, _QWORD))v52)(v48, *(_QWORD *)(v52 + 8));
  }
  ChildTracks = UnityEngine_Timeline_TrackAsset__GetChildTracks(v10, nullptr);
  v10 = System_Linq_Enumerable__FirstOrDefault_object_(
          ChildTracks,
          Method_System_Linq_Enumerable_FirstOrDefault_TrackAsset___);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  a0 = (void *)UnityEngine_Object__op_Inequality(v10, nullptr, nullptr);
  if ( ((unsigned __int8)a0 & 1) == 0 )
    goto LABEL_115;
  if ( !v10 )
    goto LABEL_121;
  v54 = UnityEngine_Timeline_TrackAsset__GetClips(v10, nullptr);
  v55 = System_Linq_Enumerable__Count_object_(v54, Method_System_Linq_Enumerable_Count_TimelineClip___);
  if ( v5[8] )
    Campus_Crowd_CrowdAnimator__SetOverrideAnimationCount(v5[8], v55, v56);
  v57 = UnityEngine_Timeline_TrackAsset__GetClips(v10, nullptr);
  v58 = Campus_Crowd_CrowdTimelineTrack___c_TypeInfo;
  v10 = v57;
  if ( !*(_DWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo);
    v58 = Campus_Crowd_CrowdTimelineTrack___c_TypeInfo;
  }
  v59 = *(_QWORD *)(v58 + 184);
  v6 = *(_QWORD *)(v59 + 16);
  if ( !v6 )
  {
    if ( !*(_DWORD *)(v58 + 228) )
    {
      sub_63CEFF4(v58);
      v59 = *(_QWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 184LL);
    }
    v60 = *(void **)v59;
    v6 = sub_63CF110(System_Func_TimelineClip__int__ValueTuple_CrowdTimelineBehaviour__int___TypeInfo);
    System_Func_object__int__ValueTuple_object__int_____ctor(
      (void *)v6,
      v60,
      Method_Campus_Crowd_CrowdTimelineTrack___c__CreateLayerMixer_b__0_1__,
      nullptr);
    v61 = *(_QWORD *)(Campus_Crowd_CrowdTimelineTrack___c_TypeInfo + 184LL);
    *(_QWORD *)(v61 + 16) = v6;
    sub_63CEE24((void *)(v61 + 16), v6, v62, v63, v64, v65);
  }
  a0 = System_Linq_Enumerable__Select_object__ValueTuple_object__int___1(
         v10,
         (void *)v6,
         Method_System_Linq_Enumerable_Select_TimelineClip__ValueTuple_CrowdTimelineBehaviour__int____);
  if ( !a0 )
    goto LABEL_121;
  v66 = *(_QWORD *)a0;
  v67 = a0;
  v68 = *(unsigned __int16 *)(*(_QWORD *)a0 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)a0 + 302LL) )
  {
    v69 = (int *)(*(_QWORD *)(v66 + 176) + 8LL);
    while ( *((_QWORD *)v69 - 1) != System_Collections_Generic_IEnumerable_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo )
    {
      --v68;
      v69 += 4;
      if ( !v68 )
        goto LABEL_80;
    }
    v70 = v66 + 16LL * *v69 + 312;
  }
  else
  {
LABEL_80:
    v70 = sub_6408234(a0, System_Collections_Generic_IEnumerable_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo, 0);
  }
  v71 = (*(__int64 (__fastcall **)(void *, _QWORD))v70)(v67, *(_QWORD *)(v70 + 8));
  v102 = (__int64 *)v71;
  v100 = nullptr;
  v101 = (__int64 *)&v102;
  if ( v71 )
  {
    v73 = v71;
    while ( 1 )
    {
      v74 = *(_QWORD *)v73;
      v75 = *(unsigned __int16 *)(*(_QWORD *)v73 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v73 + 302LL) )
      {
        v76 = (int *)(*(_QWORD *)(v74 + 176) + 8LL);
        while ( *((_QWORD *)v76 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v75;
          v76 += 4;
          if ( !v75 )
            goto LABEL_88;
        }
        v77 = v74 + 16LL * *v76 + 312;
      }
      else
      {
LABEL_88:
        v77 = sub_6408234(v73, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v78 = (*(__int64 (__fastcall **)(__int64, _QWORD))v77)(v73, *(_QWORD *)(v77 + 8));
      if ( (v78 & 1) == 0 )
        break;
      v10 = v102;
      if ( !v102 )
        goto LABEL_120;
      v80 = *v102;
      v81 = *(unsigned __int16 *)(*v102 + 302);
      if ( *(_WORD *)(*v102 + 302) )
      {
        v82 = (int *)(*(_QWORD *)(v80 + 176) + 8LL);
        while ( *((_QWORD *)v82 - 1) != System_Collections_Generic_IEnumerator_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo )
        {
          --v81;
          v82 += 4;
          if ( !v81 )
            goto LABEL_96;
        }
        v83 = v80 + 16LL * *v82 + 312;
      }
      else
      {
LABEL_96:
        v83 = sub_6408234(
                v102,
                System_Collections_Generic_IEnumerator_ValueTuple_CrowdTimelineBehaviour__int___TypeInfo,
                0);
      }
      v71 = (*(__int64 (__fastcall **)(void *, _QWORD))v83)(v10, *(_QWORD *)(v83 + 8));
      v84 = (void *)v71;
      if ( v71 )
      {
        v85 = *(void **)(v71 + 16);
        v6 = v72;
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        v71 = UnityEngine_Object__op_Equality(v85, nullptr, nullptr);
        if ( (v71 & 1) == 0 )
          Campus_Crowd_CrowdAnimationTimeline__SetOverrideAnimationData(v5, v6, v84, v86);
      }
      v73 = (__int64)v102;
      if ( !v102 )
        goto LABEL_104;
    }
  }
  else
  {
LABEL_104:
    sub_63CF120(v71, v72);
  }
  v10 = nullptr;
  for ( i = (__int64 *)&v102; ; i = v101 )
  {
    v6 = *i;
    if ( *i )
    {
      v88 = *(_QWORD *)v6;
      v89 = *(unsigned __int16 *)(*(_QWORD *)v6 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v6 + 302LL) )
      {
        v90 = (int *)(*(_QWORD *)(v88 + 176) + 8LL);
        while ( *((_QWORD *)v90 - 1) != System_IDisposable_TypeInfo )
        {
          --v89;
          v90 += 4;
          if ( !v89 )
            goto LABEL_111;
        }
        v91 = v88 + 16LL * *v90 + 312;
      }
      else
      {
LABEL_111:
        v91 = sub_6408234(v6, System_IDisposable_TypeInfo, 0);
      }
      (*(void (__fastcall **)(__int64, _QWORD))v91)(v6, *(_QWORD *)(v91 + 8));
    }
    if ( !v10 )
      break;
LABEL_122:
    v97 = sub_63CF118(v10);
    v98 = v96;
    if ( v99 != 1 )
    {
      sub_E1B6FF0(&v100, v97);
      sub_64BD8DC(v98);
    }
    v10 = *(void **)__cxa_begin_catch(v96);
    v100 = v10;
    __cxa_end_catch();
  }
LABEL_115:
  if ( !*(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__TypeInfo);
  a0 = UnityEngine_Playables_ScriptPlayable_object___GetBehaviour(
         (__int64)&v103,
         Method_UnityEngine_Playables_ScriptPlayable_CrowdTimelineMixerBehaviour__GetBehaviour__);
  if ( !a0 )
  {
LABEL_121:
    sub_63CF120(a0, a1);
    sub_63CF118(v6);
    goto LABEL_122;
  }
  *((_QWORD *)a0 + 2) = v5;
  sub_63CEE24((char *)a0 + 16, (int)v5, v92, v93, v94, v95);
  return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v103, v104);
}

