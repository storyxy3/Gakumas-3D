// 0xdd6bf1c @ 0xdd6bf1c
bool __fastcall Campus_Common_Live_CampusLiveBinder___c__DisplayClass46_0___HasLiveOverrideActorMotion_b__0(
        void *a0,
        void *a1,
        void *a2)
{
  void *v5; // x19
  __int64 v6; // x0
  __int64 v7; // x8
  void *v8; // x20
  void *v9; // x21
  __int64 v10; // x0
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5

  if ( (unk_F43BA41 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_Any_OverrideActorMotionClip___);
    sub_63CEE78(&System_Func_OverrideActorMotionClip__bool__TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Live_CampusLiveBinder___c__HasLiveOverrideActorMotion_b__46_1__);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    unk_F43BA41 = 1;
  }
  if ( !a1 )
    return 0;
  if ( !System_String__op_Equality(*((void **)a1 + 2), *((void **)a0 + 2), nullptr) )
    return 0;
  v5 = *((void **)a1 + 3);
  if ( !v5 )
    return 0;
  v6 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    v6 = Campus_Common_Live_CampusLiveBinder___c_TypeInfo;
  }
  v7 = *(_QWORD *)(v6 + 184);
  v8 = *(void **)(v7 + 56);
  if ( !v8 )
  {
    if ( !*(_DWORD *)(v6 + 228) )
    {
      sub_63CEFF4(v6);
      v7 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    }
    v9 = *(void **)v7;
    v8 = (void *)sub_63CF110(System_Func_OverrideActorMotionClip__bool__TypeInfo);
    System_Func_object__bool____ctor(
      v8,
      v9,
      Method_Campus_Common_Live_CampusLiveBinder___c__HasLiveOverrideActorMotion_b__46_1__,
      nullptr);
    v10 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL);
    *(_QWORD *)(v10 + 56) = v8;
    sub_63CEE24((void *)(v10 + 56), (int)v8, v11, v12, v13, v14);
  }
  return System_Linq_Enumerable__Any_object__1(v5, v8, Method_System_Linq_Enumerable_Any_OverrideActorMotionClip___);
}

