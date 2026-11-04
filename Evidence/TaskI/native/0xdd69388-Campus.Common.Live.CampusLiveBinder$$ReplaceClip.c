// 0xdd69388 @ 0xdd69388
void __fastcall Campus_Common_Live_CampusLiveBinder__ReplaceClip(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v4; // x30
  void *v5; // x0
  void *v6; // x1
  void *v7; // x2
  __int64 v8; // [xsp+0h] [xbp+0h]

  if ( a1 )
  {
    UnityEngine_Video_VideoPlayer__set_clip(a1, a2, nullptr);
  }
  else
  {
    *(&v8 - 2) = v4;
    v5 = (void *)sub_63CF120(a0, 0);
    Campus_Common_Live_CampusLiveTimelineController__ApplyMuteFromTrackDisableSettings(v5, v6, v7);
  }
}

