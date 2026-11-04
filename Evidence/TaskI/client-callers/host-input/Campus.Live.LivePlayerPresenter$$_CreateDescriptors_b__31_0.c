// Campus.Live.LivePlayerPresenter$$<CreateDescriptors>b__31_0 @ 0x863aef4
__int64 __fastcall Campus_Live_LivePlayerPresenter___CreateDescriptors_b__31_0(void *a0, void *a1, int a2, void *a3)
{
  _QWORD *v4; // x8
  __int64 v5; // x20
  void *v7; // x22
  _QWORD *v8; // x21
  void *v9; // x23
  void *TimelineProps; // x0
  __int64 v11; // x8
  void *v12; // x24
  __int64 v13; // x9
  void *v14; // x25
  void *v15; // x26
  __int64 v16; // x0
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5
  bool IsCmmnHeightCorrectionNeededForActorSwing; // w0
  void *v22; // x3
  void *v23; // x5
  __int64 result; // x0
  __int64 v25; // x30
  void *v26; // x19
  int v27; // w2
  int v28; // w3
  int v29; // w4
  void *v30; // x5
  __int64 v31; // [xsp+0h] [xbp+0h]
  __int64 v32; // [xsp+10h] [xbp+10h]
  void *v33; // [xsp+18h] [xbp+18h]

  v5 = (unsigned int)a2;
  v7 = a0;
  v8 = v4;
  if ( (unk_F413985 & 1) == 0 )
  {
    sub_63CEE78(&Method_FasterLinq_Select_GameObject__string___);
    sub_63CEE78(&System_Func_GameObject__string__TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_string__AddRange__);
    sub_63CEE78(&Method_Campus_Live_LivePlayerPresenter___c__CreateDescriptors_b__31_1__);
    sub_63CEE78(&Campus_Live_LivePlayerPresenter___c_TypeInfo);
    a0 = (void *)sub_63CEE78(&Method_System_ValueTuple_int__int__string__CampusActorDescriptor___ctor__);
    unk_F413985 = 1;
  }
  if ( !a1 )
    goto LABEL_14;
  a0 = *((void **)v7 + 4);
  *((_BYTE *)a1 + 88) = 1;
  if ( !a0 )
    goto LABEL_14;
  v9 = *((void **)a1 + 2);
  TimelineProps = Campus_Live_Live3DPresenter__GetTimelineProps(a0, v5, nullptr);
  v11 = Campus_Live_LivePlayerPresenter___c_TypeInfo;
  v12 = TimelineProps;
  if ( !*(_DWORD *)(Campus_Live_LivePlayerPresenter___c_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Live_LivePlayerPresenter___c_TypeInfo);
    v11 = Campus_Live_LivePlayerPresenter___c_TypeInfo;
  }
  v13 = *(_QWORD *)(v11 + 184);
  v14 = *(void **)(v13 + 24);
  if ( !v14 )
  {
    if ( !*(_DWORD *)(v11 + 228) )
    {
      sub_63CEFF4(v11);
      v13 = *(_QWORD *)(Campus_Live_LivePlayerPresenter___c_TypeInfo + 184LL);
    }
    v15 = *(void **)v13;
    v14 = (void *)sub_63CF110(System_Func_GameObject__string__TypeInfo);
    System_Func_object__object____ctor(
      v14,
      v15,
      Method_Campus_Live_LivePlayerPresenter___c__CreateDescriptors_b__31_1__,
      nullptr);
    v16 = *(_QWORD *)(Campus_Live_LivePlayerPresenter___c_TypeInfo + 184LL);
    *(_QWORD *)(v16 + 24) = v14;
    sub_63CEE24((void *)(v16 + 24), (int)v14, v17, v18, v19, v20);
  }
  a0 = FasterLinq__Select_object__object_(v12, v14, Method_FasterLinq_Select_GameObject__string___);
  if ( v9
    && (System_Collections_Generic_List_object___AddRange(
          v9,
          a0,
          Method_System_Collections_Generic_List_string__AddRange__),
        (a0 = *((void **)v7 + 4)) != nullptr) )
  {
    IsCmmnHeightCorrectionNeededForActorSwing = Campus_Live_Live3DPresenter__IsCmmnHeightCorrectionNeededForActorSwing(
                                                  a0,
                                                  nullptr);
    v8[1] = 0;
    v8[2] = 0;
    v22 = *((void **)a1 + 3);
    *((_BYTE *)a1 + 90) = IsCmmnHeightCorrectionNeededForActorSwing;
    v23 = (void *)Method_System_ValueTuple_int__int__string__CampusActorDescriptor___ctor__;
    *v8 = 0;
    System_ValueTuple_int__int__object__object____ctor((__int64)v8, v5, v5, v22, a1, v23);
  }
  else
  {
LABEL_14:
    sub_63CF120(a0, a1);
    *(&v31 - 4) = v25;
    v32 = v5;
    v33 = a1;
    if ( (unk_F413986 & 1) == 0 )
    {
      sub_63CEE78(&Campus_Live_LivePlayerPresenter___c_TypeInfo);
      unk_F413986 = 1;
    }
    v26 = (void *)sub_63CF110(Campus_Live_LivePlayerPresenter___c_TypeInfo);
    System_Object___ctor(v26, nullptr);
    **(_QWORD **)(Campus_Live_LivePlayerPresenter___c_TypeInfo + 184LL) = v26;
    sub_63CEE24(*(void **)(Campus_Live_LivePlayerPresenter___c_TypeInfo + 184LL), (int)v26, v27, v28, v29, v30);
  }
  return result;
}

