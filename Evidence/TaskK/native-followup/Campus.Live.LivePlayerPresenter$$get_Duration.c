// Campus.Live.LivePlayerPresenter$$get_Duration @ 0x863a460
float __fastcall Campus_Live_LivePlayerPresenter__get_Duration(void *a0, void *a1)
{
  __int64 v2; // x30
  __int64 v3; // x8
  void *v5; // x0
  void *v6; // x1
  __int64 v7; // [xsp+0h] [xbp+0h]

  v3 = *((_QWORD *)a0 + 4);
  if ( v3 )
    return *(float *)(v3 + 32);
  *(&v7 - 2) = v2;
  v5 = (void *)sub_63CF120(a0, a1);
  return Campus_Live_LivePlayerPresenter__get_TimelineTime(v5, v6);
}

