// 0xdd6a5d8 @ 0xdd6a5d8
bool __fastcall Campus_Common_Live_CampusLiveBinder__HasLiveOverrideActorMotion(void *a0, int a1, void *a2)
{
  _QWORD *v5; // x20
  void *Actor; // x0
  void *v7; // x1
  __int64 v8; // x8
  __int64 v9; // x8
  void *v10; // x21
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  void *v15; // x19
  void *v17; // x0
  void *v18; // x1

  if ( (unk_F43BA2C & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_Any_OverrideActorMotionTrack___);
    sub_63CEE78(&System_Func_OverrideActorMotionTrack__bool__TypeInfo);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__DisplayClass46_0__HasLiveOverrideActorMotion_b__0__);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c__DisplayClass46_0_TypeInfo);
    unk_F43BA2C = 1;
  }
  v5 = (_QWORD *)sub_63CF110(Campus_Common_Live_CampusLiveBinder___c__DisplayClass46_0_TypeInfo);
  System_Object___ctor(v5, nullptr);
  v8 = *((_QWORD *)a0 + 10);
  if ( v8 )
  {
    v9 = *(_QWORD *)(v8 + 144);
    if ( !v9 )
      return 0;
    v10 = *(void **)(v9 + 64);
    if ( !v10 )
      return 0;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo + 228LL) )
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo);
    Actor = Campus_Common_Live_CampusLiveBinder_ReferencePropertyName__GetActor(a1, v7);
    if ( v5 )
    {
      v5[2] = Actor;
      sub_63CEE24(v5 + 2, (int)Actor, v11, v12, v13, v14);
      v15 = (void *)sub_63CF110(System_Func_OverrideActorMotionTrack__bool__TypeInfo);
      System_Func_object__bool____ctor(
        v15,
        v5,
        Method_Campus_Common_Live_CampusLiveBinder___c__DisplayClass46_0__HasLiveOverrideActorMotion_b__0__,
        nullptr);
      return System_Linq_Enumerable__Any_object__1(
               v10,
               v15,
               Method_System_Linq_Enumerable_Any_OverrideActorMotionTrack___);
    }
  }
  v17 = (void *)sub_63CF120(Actor, v7);
  return (unsigned __int8)Campus_Common_Live_CampusLiveBinder__GetTimelineSceneName(v17, v18);
}

