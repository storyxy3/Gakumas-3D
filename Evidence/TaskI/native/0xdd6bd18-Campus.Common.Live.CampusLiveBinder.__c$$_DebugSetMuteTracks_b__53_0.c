// 0xdd6bd18 @ 0xdd6bd18
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___DebugSetMuteTracks_b__53_0(void *a0, __int64 a1, void *a2)
{
  void *streamName; // x0
  __int64 v5; // x1

  if ( (unk_F43BA3E & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
    sub_63CEE78(&StringLiteral_Equip);
    unk_F43BA3E = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  streamName = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
  if ( !streamName )
  {
    sub_63CF120(0, v5);
    JUMPOUT(0xDD6BD98);
  }
  return System_String__StartsWith(streamName, StringLiteral_Equip, nullptr);
}

