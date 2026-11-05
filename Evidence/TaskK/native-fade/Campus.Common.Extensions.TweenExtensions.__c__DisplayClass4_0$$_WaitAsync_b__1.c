// Campus.Common.Extensions.TweenExtensions.<>c__DisplayClass4_0$$<WaitAsync>b__1 @ 0xdd7aca0
void __fastcall Campus_Common_Extensions_TweenExtensions___c__DisplayClass4_0___WaitAsync_b__1(void *a0, void *a1)
{
  __int64 v2; // x30
  void *v3; // x0
  __int64 v4; // [xsp+0h] [xbp+0h]

  v3 = *((void **)a0 + 2);
  if ( !v3 )
  {
    *(&v4 - 2) = v2;
    sub_63CF120(0, a1);
    JUMPOUT(0xDD7ACB8);
  }
  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult(v3, nullptr);
}

