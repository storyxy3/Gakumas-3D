// Campus.Crowd.CrowdAnimationBehaviour$$SetOverrideAnimationWeight @ 0xddbfe3c
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__SetOverrideAnimationWeight(void *a0, int a1, float a2, void *a3)
{
  int v4; // w3
  _QWORD *v7; // x20
  __int64 v8; // x8
  unsigned __int64 v9; // x24
  unsigned __int64 v10; // x9
  __int64 v11; // x8
  __int64 v12; // x8
  unsigned __int64 v13; // x25
  int v14; // w21
  __int64 v15; // x26
  __int64 v16; // x8
  void *v17; // x0
  int v18; // w1
  void *v19; // x2
  long double v20; // q0

  v7 = a0;
  if ( (unk_F43BCCA & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetInputCount_AnimationMixerPlayable___);
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetInputWeight_AnimationMixerPlayable___);
    unk_F43BCCA = 1;
  }
  v8 = v7[25];
  if ( v8 )
  {
    v9 = 0;
    while ( 1 )
    {
      v10 = *(unsigned int *)(v8 + 24);
      if ( (__int64)v9 >= (int)v10 )
        break;
      if ( v9 >= v10 )
        goto LABEL_22;
      a0 = (void *)UnityEngine_Playables_PlayableExtensions__GetInputCount_AnimationMixerPlayable_(
                     *(_QWORD *)(v8 + 16 * v9 + 32),
                     *(void **)(v8 + 16 * v9 + 40));
      if ( (int)a0 > a1 )
      {
        v11 = v7[25];
        if ( !v11 )
          goto LABEL_20;
        if ( v9 >= *(unsigned int *)(v11 + 24) )
          goto LABEL_22;
        UnityEngine_Playables_PlayableExtensions__SetInputWeight_AnimationMixerPlayable_(
          *(_QWORD *)(v11 + 16 * v9 + 32),
          *(_QWORD *)(v11 + 16 * v9 + 40),
          a2,
          (void *)(unsigned int)a1);
        if ( a2 > 0.0 )
        {
          v12 = v7[24];
          if ( !v12 )
            goto LABEL_20;
          v13 = v9 + 4;
          v14 = 1;
          v15 = (int)v9 + 4;
          while ( v13 < *(unsigned int *)(v12 + 24) )
          {
            a0 = (void *)UnityEngine_Playables_PlayableExtensions__GetInputCount_AnimationMixerPlayable_(
                           *(_QWORD *)(v12 + 16 * v15 + 32),
                           *(void **)(v12 + 16 * v15 + 40));
            if ( v14 >= (int)a0 )
              goto LABEL_19;
            v16 = v7[24];
            if ( v16 )
            {
              if ( v13 >= *(unsigned int *)(v16 + 24) )
                break;
              UnityEngine_Playables_PlayableExtensions__SetInputWeight_AnimationMixerPlayable_(
                *(_QWORD *)(v16 + 16 * v15 + 32),
                *(_QWORD *)(v16 + 16 * v15 + 40),
                0.0,
                (void *)(unsigned int)v14);
              v12 = v7[24];
              ++v14;
              if ( v12 )
                continue;
            }
            goto LABEL_20;
          }
LABEL_22:
          v20 = sub_63CF128(a0, *(_QWORD *)&a1, (_DWORD)a3, v4);
          Campus_Crowd_CrowdAnimationBehaviour__SetOverrideAnimationTime(v17, v18, *(double *)&v20, v19);
          return;
        }
      }
LABEL_19:
      v8 = v7[25];
      ++v9;
      if ( !v8 )
        goto LABEL_20;
    }
  }
  else
  {
LABEL_20:
    sub_63CF120(a0, *(_QWORD *)&a1);
  }
}

