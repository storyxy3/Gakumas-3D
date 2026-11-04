// 0xdd6bf04 @ 0xdd6bf04
bool __fastcall Campus_Common_Live_CampusLiveBinder___c__DisplayClass39_1___SetupAsync_b__8(void *a0, void *a1)
{
  __int64 v2; // x19
  __int64 v3; // x20
  __int64 v4; // x21
  __int64 v5; // x22
  __int64 v6; // x30
  void *v7; // x0
  __int64 v9; // x0
  __int64 v10; // x30
  __int64 v11; // x1
  __int64 v12; // x19
  __int64 v13; // x20
  void *v14; // x19
  __int64 v15; // x0
  __int64 v16; // x8
  void *v17; // x20
  void *v18; // x21
  __int64 v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  __int64 v24; // [xsp+0h] [xbp+0h]
  __int64 v25; // [xsp+10h] [xbp+10h]
  __int64 v26; // [xsp+18h] [xbp+18h]
  __int64 v27; // [xsp+20h] [xbp+20h]
  __int64 v28; // [xsp+28h] [xbp+28h]

  v7 = *((void **)a0 + 2);
  if ( v7 )
    return UnityEngine_Video_VideoPlayer__get_isPrepared(v7, nullptr);
  *(&v24 - 2) = v6;
  v9 = sub_63CF120(0, a1);
  *(&v24 - 6) = v10;
  v25 = v5;
  v26 = v4;
  v27 = v3;
  v28 = v2;
  v12 = v11;
  v13 = v9;
  if ( (unk_F43BA41 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_Any_OverrideActorMotionClip___);
    sub_63CEE78(&System_Func_OverrideActorMotionClip__bool__TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__HasLiveOverrideActorMotion_b__46_1__);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    unk_F43BA41 = 1;
  }
  if ( !v12 )
    return 0;
  if ( !System_String__op_Equality(*(void **)(v12 + 16), *(void **)(v13 + 16), nullptr) )
    return 0;
  v14 = *(void **)(v12 + 24);
  if ( !v14 )
    return 0;
  v15 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    v15 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  }
  v16 = *(_QWORD *)(v15 + 184);
  v17 = *(void **)(v16 + 56);
  if ( !v17 )
  {
    if ( !*(_DWORD *)(v15 + 228) )
    {
      sub_63CEFF4(v15);
      v16 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    }
    v18 = *(void **)v16;
    v17 = (void *)sub_63CF110(System_Func_OverrideActorMotionClip__bool__TypeInfo);
    System_Func_object__bool____ctor(
      v17,
      v18,
      Method_Campus_Common_Live_CampusLiveBinder___c__HasLiveOverrideActorMotion_b__46_1__,
      nullptr);
    v19 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    *(_QWORD *)(v19 + 56) = v17;
    sub_63CEE24((void *)(v19 + 56), (int)v17, v20, v21, v22, v23);
  }
  return System_Linq_Enumerable__Any_object__1(v14, v17, Method_System_Linq_Enumerable_Any_OverrideActorMotionClip___);
}

