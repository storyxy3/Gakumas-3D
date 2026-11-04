// 0xdd6a4c8 @ 0xdd6a4c8
bool __fastcall Campus_Common_Live_CampusLiveBinder__IsAllLiveScene(void *a0, void *a1)
{
  void *TimelineSceneName; // x19

  if ( (unk_F43BA29 & 1) == 0 )
  {
    sub_63CEE78(&StringLiteral_tln_live_all);
    unk_F43BA29 = 1;
  }
  TimelineSceneName = Campus_Common_Live_CampusLiveBinder__GetTimelineSceneName(a0, a1);
  return !System_String__IsNullOrEmpty(TimelineSceneName, nullptr)
      && TimelineSceneName
      && System_String__StartsWith_1(TimelineSceneName, StringLiteral_tln_live_all, 4, nullptr);
}

