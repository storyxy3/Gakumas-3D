// Campus.Common.Extensions.TweenExtensions.<>c__DisplayClass4_0$$<WaitAsync>b__0 @ 0xdd7ac88
void __fastcall Campus_Common_Extensions_TweenExtensions___c__DisplayClass4_0___WaitAsync_b__0(void *a0, void *a1)
{
  __int64 v2; // x19
  __int64 v3; // x30
  void *v4; // x0
  __int64 v5; // x1
  __int64 v6; // x30
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x30
  __int64 v10; // x19
  void *v11; // x0
  __int64 v12; // [xsp+0h] [xbp+0h]

  v4 = *((void **)a0 + 2);
  if ( v4 || (*(&v12 - 2) = v3, (v4 = *(void **)(sub_63CF120(0, a1) + 16)) != nullptr) )
  {
    Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult(v4, nullptr);
  }
  else
  {
    *(&v12 - 2) = v6;
    v7 = sub_63CF120(0, v5);
    *(&v12 - 2) = v9;
    *(&v12 - 1) = v2;
    v10 = v7;
    v11 = *(void **)(v7 + 16);
    if ( v11 )
    {
      Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetCanceled(v11, 0, nullptr);
      DG_Tweening_TweenExtensions__Kill(*(void **)(v10 + 24), *(_BYTE *)(v10 + 32), nullptr);
    }
    else
    {
      sub_63CF120(0, v8);
    }
  }
}

