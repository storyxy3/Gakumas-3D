// Campus.Common.Extensions.CanvasGroupExtensions$$SetBlockingAlpha @ 0x7470d0c
void __fastcall Campus_Common_Extensions_CanvasGroupExtensions__SetBlockingAlpha(void *a0, float a1, void *a2)
{
  _BOOL4 v5; // w8
  void *v6; // x0
  void *v7; // x1
  float v8; // s0
  float v9; // s1

  if ( a0 )
  {
    UnityEngine_CanvasGroup__set_alpha(a0, a1, nullptr);
    v5 = UnityEngine_CanvasGroup__get_interactable(a0, nullptr)
      && UnityEngine_CanvasGroup__get_blocksRaycasts(a0, nullptr);
    if ( v5 != a1 >= 1.0 )
    {
      UnityEngine_CanvasGroup__set_interactable(a0, a1 >= 1.0, nullptr);
      UnityEngine_CanvasGroup__set_blocksRaycasts(a0, a1 >= 1.0, nullptr);
    }
  }
  else
  {
    v6 = (void *)sub_63CF120(0, a2);
    Campus_Common_Extensions_CanvasGroupExtensions__DOFadeBlocking(v6, v8, v9, v7);
  }
}

