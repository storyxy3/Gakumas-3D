// 0x8642a50 @ 0x8642a50
void __fastcall Campus_Live_LiveResourceManager__LoadAudioAsync_d__11__SetStateMachine(__int64 a0, void *a1, void *a2)
{
  if ( (unk_F4139B0 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__SetStateMachine__);
    unk_F4139B0 = 1;
  }
  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_object___SetStateMachine(
    a0 + 8,
    a1,
    Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__SetStateMachine__);
}

