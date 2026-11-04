// 0xdd6bd98 @ 0xdd6bd98
void *__fastcall Campus_Common_Live_CampusLiveBinder___c___DebugSetMuteTracks_b__53_1(void *a0, __int64 a1, void *a2)
{
  if ( (unk_F43BA3F & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
    unk_F43BA3F = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  return UnityEngine_Playables_PlayableBinding__get_sourceObject(a1, nullptr);
}

