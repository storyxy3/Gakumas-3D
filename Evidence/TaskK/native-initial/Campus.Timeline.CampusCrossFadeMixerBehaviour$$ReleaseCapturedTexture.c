// Campus.Timeline.CampusCrossFadeMixerBehaviour$$ReleaseCapturedTexture @ 0xdd49f08
void __fastcall Campus_Timeline_CampusCrossFadeMixerBehaviour__ReleaseCapturedTexture(void *a0, void *a1)
{
  void *v2; // x0

  v2 = *((void **)a0 + 5);
  if ( v2 )
    UnityEngine_Rendering_RTHandle__Release(v2, nullptr);
}

