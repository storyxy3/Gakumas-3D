// Campus.Crowd.CrowdAnimationBehaviour$$SetAnimationCount @ 0xddbf7cc
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__SetAnimationCount(void *a0, int a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  _QWORD *v6; // x21
  _QWORD *v8; // x19
  __int64 v9; // x8
  __int64 v10; // x9
  unsigned __int64 v11; // x23
  unsigned __int64 v12; // x10
  __int64 v13; // x24
  __int64 *v14; // x19
  __int64 v15; // x22
  __int64 v16; // t1
  __int64 v17; // x8
  unsigned __int64 v18; // x23
  __int64 v19; // x1
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  void *v24; // x0
  int v25; // w1
  void *v26; // x2
  int v27; // w3
  void *v28; // x4
  long double v29; // q0
  float v30; // s1

  v6 = (_QWORD *)&unk_F43B000;
  v8 = a0;
  if ( (unk_F43BCC5 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_ClipData___TypeInfo);
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_SetInputCount_AnimationMixerPlayable___);
    unk_F43BCC5 = 1;
  }
  v9 = v8[24];
  if ( v9 )
  {
    v10 = 0;
    v6 = &Campus_Crowd_ClipData___TypeInfo;
    v11 = 0;
    while ( 1 )
    {
      v12 = *(unsigned int *)(v9 + 24);
      if ( (__int64)v11 >= (int)v12 )
        break;
      if ( v11 >= v12 )
        goto LABEL_18;
      v13 = v10 + 16;
      ++v11;
      UnityEngine_Playables_PlayableExtensions__SetInputCount_AnimationMixerPlayable_(
        *(_QWORD *)(v9 + v10 + 32),
        *(_QWORD *)(v9 + v10 + 40),
        (void *)(unsigned int)(a1 + 1));
      v9 = v8[24];
      v10 = v13;
      if ( !v9 )
        goto LABEL_8;
    }
  }
  else
  {
LABEL_8:
    a0 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
  }
  v16 = v8[20];
  v14 = v8 + 20;
  v15 = v16;
  if ( !v16 )
    goto LABEL_17;
  v17 = *(_QWORD *)(v15 + 24);
  if ( (int)v17 < 1 )
  {
LABEL_16:
    *v14 = 0;
    sub_63CEE24(v14, 0, (int)a2, v3, v4, v5);
LABEL_17:
    v19 = sub_63CEF64(*v6, (unsigned int)a1);
    *v14 = v19;
    sub_63CEE24(v14, v19, v20, v21, v22, v23);
    return;
  }
  v18 = 0;
  while ( v18 < (unsigned int)v17 )
  {
    a0 = *(void **)(v15 + 32 + 8 * v18);
    if ( a0 )
    {
      Campus_Crowd_ClipData__Dispose(a0, nullptr);
      LODWORD(v17) = *(_DWORD *)(v15 + 24);
    }
    if ( (__int64)++v18 >= (int)v17 )
      goto LABEL_16;
  }
LABEL_18:
  v29 = sub_63CF128(a0, *(_QWORD *)&a1, (_DWORD)a2, v3);
  Campus_Crowd_CrowdAnimationBehaviour__ConnectAnimation(v24, v25, v26, *(double *)&v29, v30, v27, v28);
}

