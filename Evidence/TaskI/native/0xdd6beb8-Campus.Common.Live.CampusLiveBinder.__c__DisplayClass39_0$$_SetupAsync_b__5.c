// 0xdd6beb8 @ 0xdd6beb8
void __fastcall Campus_Common_Live_CampusLiveBinder___c__DisplayClass39_0___SetupAsync_b__5(
        void *a0,
        void *a1,
        void *a2)
{
  __int64 v3; // x8
  __int64 v4; // x8

  v3 = *((_QWORD *)a0 + 3);
  if ( !v3 || (v4 = *(_QWORD *)(v3 + 80)) == 0 || !a1 )
  {
    sub_63CF120(a0, a1);
    JUMPOUT(0xDD6BEFC);
  }
  UnityEngine_Playables_PlayableDirector__set_timeUpdateMode(a1, *(_DWORD *)(v4 + 72), nullptr);
  UnityEngine_Playables_PlayableDirector__set_extrapolationMode(a1, 0, nullptr);
}

