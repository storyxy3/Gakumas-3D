// Campus.Crowd.ClipData$$Dispose @ 0xddc2fc0
void __fastcall Campus_Crowd_ClipData__Dispose(void *a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  _QWORD *v4; // x19
  __int64 v5; // x8
  __int64 v6; // x9
  unsigned __int64 v7; // x21
  unsigned __int64 v8; // x10
  __int64 v9; // x22
  void *v10; // x0
  void *v11; // x1
  long double v12; // q0

  v4 = a0;
  if ( (unk_F43BCD6 & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_Destroy_Playable___);
    unk_F43BCD6 = 1;
  }
  v5 = v4[2];
  if ( v5 )
  {
    v6 = 0;
    v7 = 0;
    while ( 1 )
    {
      v8 = *(unsigned int *)(v5 + 24);
      if ( (__int64)v7 >= (int)v8 )
        break;
      if ( v7 >= v8 )
      {
        v12 = sub_63CF128(a0, a1, v2, v3);
        Campus_Crowd_ClipData__SetTime(v10, *(double *)&v12, v11);
        return;
      }
      v9 = v6 + 16;
      ++v7;
      UnityEngine_Playables_PlayableExtensions__Destroy_Playable_(*(_QWORD *)(v5 + v6 + 32), *(void **)(v5 + v6 + 40));
      v5 = v4[2];
      v6 = v9;
      if ( !v5 )
        goto LABEL_8;
    }
  }
  else
  {
LABEL_8:
    sub_63CF120(a0, a1);
  }
}

