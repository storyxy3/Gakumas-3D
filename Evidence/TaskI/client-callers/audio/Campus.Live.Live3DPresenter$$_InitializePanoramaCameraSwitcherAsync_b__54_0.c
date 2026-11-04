// 0x84f5dbc @ 0x84f5dbc
void __fastcall Campus_Live_Live3DPresenter___InitializePanoramaCameraSwitcherAsync_b__54_0(
        void *a0,
        __int64 a1,
        void *a2)
{
  int v3; // w19
  void *ValueOrDefault_int__object; // x0

  v3 = (int)a2;
  if ( (unk_F413040 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_int__ICampusActorController___);
    unk_F413040 = 1;
  }
  ValueOrDefault_int__object = System_Collections_Generic_CollectionExtensions__GetValueOrDefault_int__object_(
                                 *((void **)a0 + 10),
                                 v3,
                                 Method_System_Collections_Generic_CollectionExtensions_GetValueOrDefault_int__ICampusActorController___);
  Campus_Live_LivePanoramaCameraManager__SetFocusTarget(ValueOrDefault_int__object, nullptr);
}

