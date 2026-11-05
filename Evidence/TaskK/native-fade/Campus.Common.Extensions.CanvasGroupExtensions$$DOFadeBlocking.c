// Campus.Common.Extensions.CanvasGroupExtensions$$DOFadeBlocking @ 0x7470db0
void *__fastcall Campus_Common_Extensions_CanvasGroupExtensions__DOFadeBlocking(void *a0, float a1, float a2, void *a3)
{
  void **v7; // x21
  void *v8; // x0
  __int64 v9; // x1
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void **v14; // x20
  void *v15; // x19
  void *v16; // x22
  void *v17; // x21
  void *v18; // x19
  void *gameObject; // x1
  void *result; // x0
  void *v21; // x0
  void *v22; // x1

  if ( (unk_F407DB8 & 1) == 0 )
  {
    sub_63CEE78(&Method_Campus_Common_Extensions_CanvasGroupExtensions_SetBlockingAlpha__);
    sub_63CEE78(&DG_Tweening_Core_DOGetter_float__TypeInfo);
    sub_63CEE78(&DG_Tweening_Core_DOSetter_float__TypeInfo);
    sub_63CEE78(&DG_Tweening_DOTween_TypeInfo);
    sub_63CEE78(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____);
    sub_63CEE78(&Method_Campus_Common_Extensions_CanvasGroupExtensions___c__DisplayClass1_0__DOFadeBlocking_b__0__);
    sub_63CEE78(&Campus_Common_Extensions_CanvasGroupExtensions___c__DisplayClass1_0_TypeInfo);
    unk_F407DB8 = 1;
  }
  v7 = (void **)sub_63CF110(Campus_Common_Extensions_CanvasGroupExtensions___c__DisplayClass1_0_TypeInfo);
  System_Object___ctor(v7, nullptr);
  if ( !v7 )
    goto LABEL_8;
  v7[2] = a0;
  v14 = v7 + 2;
  sub_63CEE24(v7 + 2, (int)a0, v10, v11, v12, v13);
  v15 = (void *)sub_63CF110(DG_Tweening_Core_DOGetter_float__TypeInfo);
  DG_Tweening_Core_DOGetter_float____ctor(
    v15,
    v7,
    Method_Campus_Common_Extensions_CanvasGroupExtensions___c__DisplayClass1_0__DOFadeBlocking_b__0__,
    nullptr);
  v16 = v7[2];
  v17 = (void *)sub_63CF110(DG_Tweening_Core_DOSetter_float__TypeInfo);
  DG_Tweening_Core_DOSetter_float____ctor(
    v17,
    v16,
    Method_Campus_Common_Extensions_CanvasGroupExtensions_SetBlockingAlpha__,
    nullptr);
  if ( !*(_DWORD *)(DG_Tweening_DOTween_TypeInfo + 228LL) )
    sub_63CEFF4(DG_Tweening_DOTween_TypeInfo);
  v8 = DG_Tweening_DOTween__To(v15, v17, a1, a2, nullptr);
  if ( *v14 )
  {
    v18 = v8;
    gameObject = UnityEngine_Component__get_gameObject(*v14, nullptr);
    return DG_Tweening_TweenSettingsExtensions__SetLink_object_(
             v18,
             gameObject,
             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____);
  }
  else
  {
LABEL_8:
    v21 = (void *)sub_63CF120(v8, v9);
    Campus_Common_Extensions_CanvasGroupExtensions___c__DisplayClass1_0___ctor(v21, v22);
  }
  return result;
}

