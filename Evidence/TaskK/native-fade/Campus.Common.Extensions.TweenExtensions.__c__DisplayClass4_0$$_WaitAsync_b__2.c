// Campus.Common.Extensions.TweenExtensions.<>c__DisplayClass4_0$$<WaitAsync>b__2 @ 0xdd7acb8
void __fastcall Campus_Common_Extensions_TweenExtensions___c__DisplayClass4_0___WaitAsync_b__2(void *a0, void *a1)
{
  void *v3; // x0

  v3 = *((void **)a0 + 2);
  if ( !v3 )
  {
    sub_63CF120(0, a1);
    JUMPOUT(0xDD7ACEC);
  }
  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetCanceled(v3, 0, nullptr);
  DG_Tweening_TweenExtensions__Kill(*((void **)a0 + 3), *((_BYTE *)a0 + 32), nullptr);
}

