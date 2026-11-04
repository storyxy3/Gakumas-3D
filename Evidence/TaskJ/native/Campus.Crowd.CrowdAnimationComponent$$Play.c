// Campus.Crowd.CrowdAnimationComponent$$Play @ 0xddc0460
void __fastcall Campus_Crowd_CrowdAnimationComponent__Play(void *a0, void *a1)
{
  __int64 v2; // x19
  __int64 v3; // x30
  __int64 v4; // d8
  void *v5; // x0
  __int64 v6; // x0
  __int64 v7; // x1
  __int64 v8; // x30
  __int64 v9; // x19
  void *v10; // x0
  double v11; // d0
  __int64 v12; // x1
  __int64 v13; // x30
  void *v14; // x0
  __int64 v15; // x1
  __int64 v16; // x30
  void *v17; // x0
  __int64 v18; // x1
  __int64 v19; // x30
  void *v20; // x0
  __int64 v21; // x1
  __int64 v22; // x30
  __int64 v23; // x0
  __int64 v24; // x1
  __int64 v25; // x30
  void *v26; // x19
  double Time; // d8
  float fixedDeltaTime; // s0
  void *v29; // x0
  __int64 v30; // x1
  __int64 v31; // x30
  __int64 v32; // x1
  __int64 v33; // x30
  void *v34; // x0
  __int64 v35; // [xsp+0h] [xbp+0h]
  __int64 v36; // [xsp+10h] [xbp+10h]
  __int64 v37; // [xsp+18h] [xbp+18h]

  v5 = *((void **)a0 + 9);
  if ( v5 )
    goto LABEL_2;
  *(&v35 - 2) = v3;
  v6 = sub_63CF120(0, a1);
  *(&v35 - 2) = v8;
  *(&v35 - 1) = v2;
  v9 = v6;
  v10 = *(void **)(v6 + 72);
  if ( v10 )
  {
    Campus_Crowd_CrowdAnimator__Pause(v10, nullptr);
    v10 = *(void **)(v9 + 72);
    if ( v10 )
    {
      v11 = 0.0;
LABEL_6:
      Campus_Crowd_CrowdAnimator__SetTime(v10, v11, nullptr);
      return;
    }
  }
  v5 = *(void **)(sub_63CF120(v10, v7) + 72);
  if ( v5 )
  {
LABEL_2:
    Campus_Crowd_CrowdAnimator__Play(v5, nullptr);
    return;
  }
  *(&v35 - 2) = v13;
  v14 = *(void **)(sub_63CF120(0, v12) + 72);
  if ( v14 )
  {
    Campus_Crowd_CrowdAnimator__Pause(v14, nullptr);
  }
  else
  {
    *(&v35 - 2) = v16;
    v17 = *(void **)(sub_63CF120(0, v15) + 72);
    if ( v17 )
    {
      Campus_Crowd_CrowdAnimator__IsPlaying(v17, nullptr);
    }
    else
    {
      *(&v35 - 2) = v19;
      v20 = *(void **)(sub_63CF120(0, v18) + 72);
      if ( v20 )
      {
        Campus_Crowd_CrowdAnimator__IsPaused(v20, nullptr);
      }
      else
      {
        *(&v35 - 2) = v22;
        v23 = sub_63CF120(0, v21);
        *(&v35 - 4) = v4;
        v36 = v25;
        v37 = v9;
        v26 = *(void **)(v23 + 72);
        if ( v26 )
        {
          Time = Campus_Crowd_CrowdAnimator__GetTime(*(void **)(v23 + 72), nullptr);
          fixedDeltaTime = UnityEngine_Time__get_fixedDeltaTime(nullptr);
          Campus_Crowd_CrowdAnimator__SetTime(v26, Time + fixedDeltaTime, nullptr);
        }
        else
        {
          v29 = *(void **)(sub_63CF120(v23, v24) + 72);
          if ( v29 )
          {
            Campus_Crowd_CrowdAnimator__GetTime(v29, nullptr);
          }
          else
          {
            *(&v35 - 2) = v31;
            v10 = *(void **)(sub_63CF120(0, v30) + 72);
            if ( v10 )
              goto LABEL_6;
            *(&v35 - 2) = v33;
            v34 = (void *)sub_63CF120(0, v32);
            UnityEngine_MonoBehaviour___ctor(v34, nullptr);
          }
        }
      }
    }
  }
}

