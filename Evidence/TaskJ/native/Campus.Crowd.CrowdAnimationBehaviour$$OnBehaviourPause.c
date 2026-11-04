// Campus.Crowd.CrowdAnimationBehaviour$$OnBehaviourPause @ 0xddbf690
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__OnBehaviourPause(void *a0, __int64 a1, __int64 a2, void *a3)
{
  _BOOL8 IsValid_AnimationMixerPlayable; // x0
  __int64 v6; // x1
  int v7; // w2
  int v8; // w3
  __int64 v9; // x8
  __int64 v10; // x9
  unsigned __int64 v11; // x22
  unsigned __int64 v12; // x10
  __int64 v13; // x23
  __int64 v14; // x8
  __int64 v15; // x22
  unsigned __int64 v16; // x23
  unsigned __int64 v17; // x9
  __int64 v18; // x8
  void *v19; // x0
  int v20; // w1
  void *v21; // x2

  if ( (unk_F43BCC4 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_Pause_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_Pause_AnimationScriptPlayable___);
    unk_F43BCC4 = 1;
  }
  UnityEngine_Playables_PlayableExtensions__Pause_AnimationScriptPlayable_(*((_QWORD *)a0 + 22), *((void **)a0 + 23));
  v9 = *((_QWORD *)a0 + 24);
  if ( v9 )
  {
    v10 = 0;
    v11 = 0;
    while ( 1 )
    {
      v12 = *(unsigned int *)(v9 + 24);
      if ( (__int64)v11 >= (int)v12 )
        break;
      if ( v11 >= v12 )
      {
LABEL_20:
        sub_63CF128(IsValid_AnimationMixerPlayable, v6, v7, v8);
        Campus_Crowd_CrowdAnimationBehaviour__SetAnimationCount(v19, v20, v21);
        return;
      }
      v13 = v10 + 16;
      ++v11;
      UnityEngine_Playables_PlayableExtensions__Pause_AnimationMixerPlayable_(
        *(_QWORD *)(v9 + v10 + 32),
        *(void **)(v9 + v10 + 40));
      v9 = *((_QWORD *)a0 + 24);
      v10 = v13;
      if ( !v9 )
        goto LABEL_18;
    }
    v14 = *((_QWORD *)a0 + 25);
    if ( !v14 )
      goto LABEL_18;
    v15 = 0;
    v16 = 0;
    while ( 1 )
    {
      v17 = *(unsigned int *)(v14 + 24);
      if ( (__int64)v16 >= (int)v17 )
        break;
      if ( v16 >= v17 )
        goto LABEL_20;
      IsValid_AnimationMixerPlayable = UnityEngine_Playables_PlayableExtensions__IsValid_AnimationMixerPlayable_(
                                         *(_QWORD *)(v14 + v15 + 32),
                                         *(void **)(v14 + v15 + 40));
      if ( IsValid_AnimationMixerPlayable )
      {
        v18 = *((_QWORD *)a0 + 25);
        if ( !v18 )
          goto LABEL_18;
        if ( v16 >= *(unsigned int *)(v18 + 24) )
          goto LABEL_20;
        UnityEngine_Playables_PlayableExtensions__Pause_AnimationMixerPlayable_(
          *(_QWORD *)(v18 + v15 + 32),
          *(void **)(v18 + v15 + 40));
      }
      v14 = *((_QWORD *)a0 + 25);
      ++v16;
      v15 += 16;
      if ( !v14 )
        goto LABEL_18;
    }
  }
  else
  {
LABEL_18:
    sub_63CF120(IsValid_AnimationMixerPlayable, v6);
  }
}

