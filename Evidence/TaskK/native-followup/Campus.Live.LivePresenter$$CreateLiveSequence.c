// Campus.Live.LivePresenter$$CreateLiveSequence @ 0x863e3dc
void *__fastcall Campus_Live_LivePresenter__CreateLiveSequence(void *a0, void *a1)
{
  void *gameObject; // x0
  void *v4; // x0
  _QWORD *v5; // x0
  __int64 v6; // x1
  void *v7; // x20
  _QWORD *v8; // x21
  void *v9; // x22
  void *v10; // x23
  _QWORD *v11; // x0
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  int v16; // w8
  __int64 v17; // x1
  void *result; // x0
  void *v19; // x0
  void *v20; // x1
  float v21; // s0

  if ( (unk_F41399A & 1) == 0 )
  {
    sub_63CEE78(&Method_Campus_Live_LivePresenter__CreateLiveSequence_b__24_0__);
    sub_63CEE78(&DG_Tweening_TweenCallback_TypeInfo);
    sub_63CEE78(&Method_DG_Tweening_TweenExtensions_Pause_Sequence___);
    sub_63CEE78(&Method_DG_Tweening_TweenSettingsExtensions_SetTarget_Sequence___);
    sub_63CEE78(&StringLiteral_LiveSequence);
    unk_F41399A = 1;
  }
  gameObject = UnityEngine_Component__get_gameObject(a0, nullptr);
  v4 = Campus_Common_CampusTween__Sequence(gameObject, nullptr);
  v5 = DG_Tweening_TweenSettingsExtensions__SetTarget_object_(
         v4,
         StringLiteral_LiveSequence,
         Method_DG_Tweening_TweenSettingsExtensions_SetTarget_Sequence___);
  if ( v5 )
  {
    v7 = v5;
    v8 = v5 + 14;
    v9 = (void *)v5[14];
    v10 = (void *)sub_63CF110(DG_Tweening_TweenCallback_TypeInfo);
    DG_Tweening_TweenCallback___ctor(v10, a0, Method_Campus_Live_LivePresenter__CreateLiveSequence_b__24_0__, nullptr);
    v11 = System_Delegate__Combine(v9, v10, nullptr);
    v16 = (int)v11;
    if ( v11 )
    {
      v17 = DG_Tweening_TweenCallback_TypeInfo;
      if ( *v11 == DG_Tweening_TweenCallback_TypeInfo )
      {
        *v8 = v11;
        if ( *v11 == v17 )
          goto LABEL_9;
      }
      sub_63CF4A0(v11, v17);
    }
    *v8 = 0;
LABEL_9:
    sub_63CEE24(v8, v16, v12, v13, v14, v15);
    DG_Tweening_TweenExtensions__Pause_object_(v7, Method_DG_Tweening_TweenExtensions_Pause_Sequence___);
    return v7;
  }
  v19 = (void *)sub_63CF120(0, v6);
  Campus_Live_LivePresenter__CheckLiveEnd(v19, v21, v20);
  return result;
}

