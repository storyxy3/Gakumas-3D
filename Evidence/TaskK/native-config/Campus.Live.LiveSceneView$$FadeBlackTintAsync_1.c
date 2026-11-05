// 0x6711904 @ 0x6711904
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall Campus_Live_LiveSceneView__FadeBlackTintAsync_1(
        void *a0,
        bool a1,
        UnityEngine_Color_o a2,
        float a3,
        __int64 a4,
        void *a5)
{
  float a; // s9
  float b; // s10
  float g; // s11
  float r; // s12
  void *v14; // x0
  float v15; // s0
  void *v16; // x0

  a = a2.a;
  b = a2.b;
  g = a2.g;
  r = a2.r;
  if ( !a1 )
  {
    v14 = *((void **)a0 + 5);
    if ( !v14 )
    {
LABEL_8:
      sub_63CF120(v14, a1);
      JUMPOUT(0x67119BC);
    }
    UnityEngine_CanvasGroup__set_blocksRaycasts(v14, 0, nullptr);
  }
  v14 = *((void **)a0 + 6);
  if ( !v14 )
    goto LABEL_8;
  (*(void (__fastcall **)(void *, _QWORD, __int64, void *, float, float, float, float))(*(_QWORD *)v14 + 696LL))(
    v14,
    *(_QWORD *)(*(_QWORD *)v14 + 704LL),
    a4,
    a5,
    r,
    g,
    b,
    a);
  v15 = 0.0;
  if ( a1 )
    v15 = 1.0;
  v16 = Campus_Common_Extensions_CanvasGroupExtensions__DOFadeBlocking(*((void **)a0 + 5), v15, a3, nullptr);
  return Campus_Common_Extensions_TweenExtensions__WaitAsync(v16, a4, nullptr);
}

