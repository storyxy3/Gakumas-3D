// 0x84f5e1c @ 0x84f5e1c
void __fastcall Campus_Live_Live3DPresenter___InitializePanoramaCameraSwitcherAsync_b__54_2(
        void *a0,
        __int64 a1,
        void *a2)
{
  __int64 v3; // x8
  char v4; // w19

  v3 = *((_QWORD *)a0 + 21);
  v4 = (char)a2;
  if ( v3 )
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))(v3 + 24))(
      *(_QWORD *)(v3 + 64),
      (unsigned __int8)a2 & 1,
      *(_QWORD *)(v3 + 40));
  Campus_Live_LivePanoramaCameraManager__OnChangeCameraByTimelineTack(a1, SHIDWORD(a1), v4 & 1, nullptr);
}

