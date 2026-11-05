// Campus.Timeline.CampusCrossFadeMixerBehaviour$$OnPlayableDestroy @ 0xdd4a074
void __fastcall Campus_Timeline_CampusCrossFadeMixerBehaviour__OnPlayableDestroy(void *a0, __int64 a1, void *a2)
{
  void *v3; // x0

  v3 = *((void **)a0 + 5);
  if ( v3 )
    UnityEngine_Rendering_RTHandle__Release(v3, nullptr);
}

