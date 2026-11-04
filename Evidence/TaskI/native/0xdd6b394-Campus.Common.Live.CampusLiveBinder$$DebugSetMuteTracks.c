// 0xdd6b394 @ 0xdd6b394
void __fastcall Campus_Common_Live_CampusLiveBinder__DebugSetMuteTracks(void *a0, void *a1)
{
  _QWORD *v2; // x19
  __int64 v3; // x8
  __int64 v4; // x8
  __int64 v5; // x0
  __int64 v6; // x8
  void *v7; // x19
  __int64 v8; // x9
  void *v9; // x20
  void *v10; // x21
  __int64 v11; // x0
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  void *v16; // x0
  __int64 v17; // x8
  void *v18; // x19
  __int64 v19; // x9
  void *v20; // x20
  void *v21; // x21
  __int64 v22; // x0
  int v23; // w2
  int v24; // w3
  int v25; // w4
  void *v26; // x5
  void *v27; // x0
  void *v28; // x0
  __int64 v29; // x8
  void *v30; // x19
  __int64 v31; // x9
  void *v32; // x20
  void *v33; // x21
  __int64 v34; // x0
  int v35; // w2
  int v36; // w3
  int v37; // w4
  void *v38; // x5
  void *v39; // x0
  void *v40; // x1

  v2 = a0;
  if ( (unk_F43BA32 & 1) == 0 )
  {
    sub_63CEE78(&System_Action_TrackAsset__TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Extensions_EnumerableExtensions_ForEach_TrackAsset___);
    sub_63CEE78(&Campus_Common_Extensions_EnumerableExtensions_TypeInfo);
    sub_63CEE78(&Method_System_Linq_Enumerable_OfType_TrackAsset___);
    sub_63CEE78(&Method_System_Linq_Enumerable_Select_PlayableBinding__Object___);
    sub_63CEE78(&Method_System_Linq_Enumerable_Where_PlayableBinding___);
    sub_63CEE78(&System_Func_PlayableBinding__bool__TypeInfo);
    sub_63CEE78(&System_Func_PlayableBinding__Object__TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_0__);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_1__);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_2__);
    a0 = (void *)sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    unk_F43BA32 = 1;
  }
  v3 = v2[10];
  if ( v3
    && (v4 = *(_QWORD *)(v3 + 16)) != 0
    && (a0 = *(void **)(v4 + 32)) != nullptr
    && (a0 = UnityEngine_Playables_PlayableDirector__get_playableAsset(a0, nullptr)) != nullptr )
  {
    v5 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 440LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 448LL));
    v6 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    v7 = (void *)v5;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
      v6 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    }
    v8 = *(_QWORD *)(v6 + 184);
    v9 = *(void **)(v8 + 72);
    if ( !v9 )
    {
      if ( !*(_DWORD *)(v6 + 228) )
      {
        sub_63CEFF4(v6);
        v8 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      }
      v10 = *(void **)v8;
      v9 = (void *)sub_63CF110(System_Func_PlayableBinding__bool__TypeInfo);
      System_Func_PlayableBinding__bool____ctor(
        v9,
        v10,
        Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_0__,
        nullptr);
      v11 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      *(_QWORD *)(v11 + 72) = v9;
      sub_63CEE24((void *)(v11 + 72), (int)v9, v12, v13, v14, v15);
    }
    v16 = System_Linq_Enumerable__Where_PlayableBinding_(v7, v9, Method_System_Linq_Enumerable_Where_PlayableBinding___);
    v17 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    v18 = v16;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
      v17 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    }
    v19 = *(_QWORD *)(v17 + 184);
    v20 = *(void **)(v19 + 80);
    if ( !v20 )
    {
      if ( !*(_DWORD *)(v17 + 228) )
      {
        sub_63CEFF4(v17);
        v19 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      }
      v21 = *(void **)v19;
      v20 = (void *)sub_63CF110(System_Func_PlayableBinding__Object__TypeInfo);
      System_Func_PlayableBinding__object____ctor(
        v20,
        v21,
        Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_1__,
        nullptr);
      v22 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      *(_QWORD *)(v22 + 80) = v20;
      sub_63CEE24((void *)(v22 + 80), (int)v20, v23, v24, v25, v26);
    }
    v27 = System_Linq_Enumerable__Select_PlayableBinding__object_(
            v18,
            v20,
            Method_System_Linq_Enumerable_Select_PlayableBinding__Object___);
    v28 = System_Linq_Enumerable__OfType_object_(v27, Method_System_Linq_Enumerable_OfType_TrackAsset___);
    v29 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    v30 = v28;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
      v29 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
    }
    v31 = *(_QWORD *)(v29 + 184);
    v32 = *(void **)(v31 + 88);
    if ( !v32 )
    {
      if ( !*(_DWORD *)(v29 + 228) )
      {
        sub_63CEFF4(v29);
        v31 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      }
      v33 = *(void **)v31;
      v32 = (void *)sub_63CF110(System_Action_TrackAsset__TypeInfo);
      System_Action_object____ctor(
        v32,
        v33,
        Method_Campus_Common_Live_CampusLiveBinder___c__DebugSetMuteTracks_b__53_2__,
        nullptr);
      v34 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
      *(_QWORD *)(v34 + 88) = v32;
      sub_63CEE24((void *)(v34 + 88), (int)v32, v35, v36, v37, v38);
    }
    if ( !*(_DWORD *)(Campus_Common_Extensions_EnumerableExtensions_TypeInfo + 228LL) )
      sub_63CEFF4(Campus_Common_Extensions_EnumerableExtensions_TypeInfo);
    Campus_Common_Extensions_EnumerableExtensions__ForEach_object__1(
      v30,
      v32,
      Method_Campus_Common_Extensions_EnumerableExtensions_ForEach_TrackAsset___);
  }
  else
  {
    v39 = (void *)sub_63CF120(a0, a1);
    Campus_Common_Live_CampusLiveBinder_BindParams___ctor(v39, v40);
  }
}

