// 0x84f3958 @ 0x84f3958
void __fastcall Campus_Live_Live3DPresenter__set_TimelineTime(void *a0, float a1, void *a2)
{
  __int64 v3; // x8
  float *v4; // x19
  float v5; // s1
  float v6; // s0
  __int64 v7; // x8
  void *v8; // x1
  void *v9; // x0

  v3 = *((_QWORD *)a0 + 8);
  if ( !v3 )
    goto LABEL_12;
  v4 = (float *)a0;
  a0 = *(void **)(v3 + 32);
  if ( !a0 )
    goto LABEL_12;
  v5 = v4[8];
  if ( v5 >= a1 )
    v5 = a1;
  v6 = a1 >= 0.0 ? v5 : 0.0;
  UnityEngine_Playables_PlayableDirector__set_time(a0, v6, nullptr);
  v7 = *((_QWORD *)v4 + 8);
  if ( v7 && (a0 = *(void **)(v7 + 32)) != nullptr )
  {
    UnityEngine_Playables_PlayableDirector__Evaluate(a0, nullptr);
    v9 = v4;
  }
  else
  {
LABEL_12:
    v9 = (void *)sub_63CF120(a0, a2);
  }
  Campus_Live_Live3DPresenter__ResetActorModel(v9, v8);
}

