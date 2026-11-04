// Campus.Crowd.ClipData$$SetTime @ 0xddc3058
void __fastcall Campus_Crowd_ClipData__SetTime(void *a0, double a1, void *a2)
{
  int v3; // w2
  int v4; // w3
  _QWORD *v6; // x19
  __int64 v7; // x8
  __int64 v8; // x22
  unsigned __int64 v9; // x26
  unsigned __int64 v10; // x9
  __int64 v11; // x8
  __int64 v12; // x20
  void *v13; // x21
  double Duration_Playable; // d0
  __int64 v15; // x8
  double v16; // d0
  void *v17; // x0
  void *v18; // x1

  v6 = a0;
  if ( (unk_F43BCD7 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetDuration_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_Playable___);
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetTime_Playable___);
    unk_F43BCD7 = 1;
  }
  v7 = v6[2];
  if ( v7 )
  {
    v8 = 0;
    v9 = 0;
    while ( 1 )
    {
      v10 = *(unsigned int *)(v7 + 24);
      if ( (__int64)v9 >= (int)v10 )
        break;
      if ( v9 >= v10 )
        goto LABEL_14;
      v11 = v7 + v8;
      v12 = *(_QWORD *)(v11 + 32);
      v13 = *(void **)(v11 + 40);
      a0 = (void *)UnityEngine_Playables_PlayableExtensions__IsValid_Playable_(v12, v13);
      if ( ((unsigned __int8)a0 & 1) != 0 )
      {
        Duration_Playable = UnityEngine_Playables_PlayableExtensions__GetDuration_Playable_(v12, v13);
        v15 = v6[3];
        if ( !v15 )
          goto LABEL_12;
        if ( v9 >= *(unsigned int *)(v15 + 24) )
        {
LABEL_14:
          sub_63CF128(a0, a2, v3, v4);
          Campus_Crowd_ClipData___c__DisplayClass5_0___ctor(v17, v18);
          return;
        }
        v16 = fmod(Duration_Playable + *(double *)(v15 + 8 * v9 + 32) + a1, Duration_Playable);
        UnityEngine_Playables_PlayableExtensions__SetTime_Playable_(v12, v16, v13);
      }
      v7 = v6[2];
      ++v9;
      v8 += 16;
      if ( !v7 )
        goto LABEL_12;
    }
  }
  else
  {
LABEL_12:
    sub_63CF120(a0, a2);
  }
}

