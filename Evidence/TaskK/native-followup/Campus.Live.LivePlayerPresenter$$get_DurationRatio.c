// Campus.Live.LivePlayerPresenter$$get_DurationRatio @ 0x863a4a8
float __fastcall Campus_Live_LivePlayerPresenter__get_DurationRatio(void *a0, void *a1)
{
  void *v3; // x0
  float TimelineTime; // s0
  __int64 v5; // x8
  float result; // s0
  void *v7; // x0
  void *v8; // x1
  void *v9; // x2

  v3 = *((void **)a0 + 4);
  if ( v3 )
  {
    TimelineTime = Campus_Live_Live3DPresenter__get_TimelineTime(v3, nullptr);
    v5 = *((_QWORD *)a0 + 4);
    if ( v5 )
      return TimelineTime / *(float *)(v5 + 32);
  }
  v7 = (void *)sub_63CF120(v3, a1);
  Campus_Live_LivePlayerPresenter__SetModel(v7, v8, v9);
  return result;
}

