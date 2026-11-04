// Campus.Crowd.CrowdAnimationBehaviour$$SetAnimationWeight @ 0xddbfa40
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__SetAnimationWeight(void *a0, int a1, float a2, void *a3)
{
  int v4; // w3
  _QWORD *v7; // x20
  __int64 v8; // x8
  __int64 v9; // x21
  unsigned __int64 v10; // x26
  unsigned __int64 v11; // x9
  __int64 v12; // x8
  __int64 Input_AnimationMixerPlayable; // x0
  void *v14; // x1
  __int64 v15; // x8
  void *v16; // x0
  int v17; // w1
  void *v18; // x2
  long double v19; // q0

  v7 = a0;
  if ( (unk_F43BCC7 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputCount_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInput_AnimationMixerPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_Playable___);
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetInputWeight_AnimationMixerPlayable___);
    unk_F43BCC7 = 1;
  }
  v8 = v7[24];
  if ( v8 )
  {
    v9 = 0;
    v10 = 0;
    while ( 1 )
    {
      v11 = *(unsigned int *)(v8 + 24);
      if ( (__int64)v10 >= (int)v11 )
        break;
      if ( v10 >= v11 )
        goto LABEL_17;
      a0 = (void *)UnityEngine_Playables_PlayableExtensions__GetInputCount_AnimationMixerPlayable_(
                     *(_QWORD *)(v8 + v9 + 32),
                     *(void **)(v8 + v9 + 40));
      if ( (int)a0 > a1 )
      {
        v12 = v7[24];
        if ( !v12 )
          goto LABEL_15;
        if ( v10 >= *(unsigned int *)(v12 + 24) )
          goto LABEL_17;
        Input_AnimationMixerPlayable = UnityEngine_Playables_PlayableExtensions__GetInput_AnimationMixerPlayable_(
                                         *(_QWORD *)(v12 + v9 + 32),
                                         *(_QWORD *)(v12 + v9 + 40),
                                         (void *)(unsigned int)(a1 + 1));
        a0 = (void *)UnityEngine_Playables_PlayableExtensions__IsValid_Playable_(Input_AnimationMixerPlayable, v14);
        if ( ((unsigned __int8)a0 & 1) != 0 )
        {
          v15 = v7[24];
          if ( !v15 )
            goto LABEL_15;
          if ( v10 >= *(unsigned int *)(v15 + 24) )
          {
LABEL_17:
            v19 = sub_63CF128(a0, *(_QWORD *)&a1, (_DWORD)a3, v4);
            Campus_Crowd_CrowdAnimationBehaviour__SetAnimationTime(v16, v17, *(double *)&v19, v18);
            return;
          }
          UnityEngine_Playables_PlayableExtensions__SetInputWeight_AnimationMixerPlayable_(
            *(_QWORD *)(v15 + v9 + 32),
            *(_QWORD *)(v15 + v9 + 40),
            a2,
            (void *)(unsigned int)(a1 + 1));
        }
      }
      v8 = v7[24];
      ++v10;
      v9 += 16;
      if ( !v8 )
        goto LABEL_15;
    }
  }
  else
  {
LABEL_15:
    sub_63CF120(a0, *(_QWORD *)&a1);
  }
}

