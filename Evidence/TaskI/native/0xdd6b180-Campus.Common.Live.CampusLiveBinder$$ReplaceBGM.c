// 0xdd6b180 @ 0xdd6b180
void __fastcall Campus_Common_Live_CampusLiveBinder__ReplaceBGM(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v6; // x10
  void *OutputTracks; // x0
  __int64 v8; // x8
  void *v9; // x20
  __int64 v10; // x9
  void *v11; // x21
  void *v12; // x22
  __int64 v13; // x0
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  void *Clips; // x0
  void **v19; // x20
  float length; // s0
  int v21; // w2
  int v22; // w3
  int v23; // w4
  void *v24; // x5
  __int64 v25; // x10
  void *v26; // x0
  void *v27; // x1

  if ( (unk_F43BA31 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Timeline_AudioPlayableAsset_TypeInfo);
    sub_63CEE78(&Method_System_Linq_Enumerable_FirstOrDefault_TimelineClip____1);
    sub_63CEE78(&Method_System_Linq_Enumerable_FirstOrDefault_TrackAsset____1);
    sub_63CEE78(&System_Func_TrackAsset__bool__TypeInfo);
    sub_63CEE78(&UnityEngine_Timeline_TimelineAsset_TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__ReplaceBGM_b__51_0__);
    a0 = (void *)sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    unk_F43BA31 = 1;
  }
  if ( !a1 )
    goto LABEL_20;
  a0 = UnityEngine_Playables_PlayableDirector__get_playableAsset(a1, nullptr);
  if ( !a0 )
    goto LABEL_20;
  v6 = *(unsigned __int8 *)(UnityEngine_Timeline_TimelineAsset_TypeInfo + 304LL);
  if ( *(unsigned __int8 *)(*(_QWORD *)a0 + 304LL) < (unsigned int)v6
    || *(_QWORD *)(*(_QWORD *)(*(_QWORD *)a0 + 200LL) + 8 * v6 - 8) != UnityEngine_Timeline_TimelineAsset_TypeInfo )
  {
    goto LABEL_20;
  }
  OutputTracks = UnityEngine_Timeline_TimelineAsset__GetOutputTracks(a0, nullptr);
  v8 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  v9 = OutputTracks;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    v8 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  }
  v10 = *(_QWORD *)(v8 + 184);
  v11 = *(void **)(v10 + 64);
  if ( !v11 )
  {
    if ( !*(_DWORD *)(v8 + 228) )
    {
      sub_63CEFF4(v8);
      v10 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    }
    v12 = *(void **)v10;
    v11 = (void *)sub_63CF110(System_Func_TrackAsset__bool__TypeInfo);
    System_Func_object__bool____ctor(
      v11,
      v12,
      Method_Campus_Common_Live_CampusLiveBinder___c__ReplaceBGM_b__51_0__,
      nullptr);
    v13 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    *(_QWORD *)(v13 + 64) = v11;
    sub_63CEE24((void *)(v13 + 64), (int)v11, v14, v15, v16, v17);
  }
  a0 = System_Linq_Enumerable__FirstOrDefault_object__1(
         v9,
         v11,
         Method_System_Linq_Enumerable_FirstOrDefault_TrackAsset____1);
  if ( !a0 )
    goto LABEL_20;
  Clips = UnityEngine_Timeline_TrackAsset__GetClips(a0, nullptr);
  a0 = System_Linq_Enumerable__FirstOrDefault_object_(
         Clips,
         Method_System_Linq_Enumerable_FirstOrDefault_TimelineClip____1);
  if ( a2
    && (v19 = (void **)a0, length = UnityEngine_AudioClip__get_length(a2, nullptr), v19)
    && (UnityEngine_Timeline_TimelineClip__set_duration(v19, length, nullptr), (a0 = v19[5]) != nullptr)
    && (v25 = *(unsigned __int8 *)(UnityEngine_Timeline_AudioPlayableAsset_TypeInfo + 304LL),
        *(unsigned __int8 *)(*(_QWORD *)a0 + 304LL) >= (unsigned int)v25)
    && *(_QWORD *)(*(_QWORD *)(*(_QWORD *)a0 + 200LL) + 8 * v25 - 8) == UnityEngine_Timeline_AudioPlayableAsset_TypeInfo )
  {
    *((_QWORD *)a0 + 3) = a2;
    sub_63CEE24((char *)a0 + 24, (int)a2, v21, v22, v23, v24);
  }
  else
  {
LABEL_20:
    v26 = (void *)sub_63CF120(a0, a1);
    Campus_Common_Live_CampusLiveBinder__DebugSetMuteTracks(v26, v27);
  }
}

