// 0x84f4754 @ 0x84f4754
__int64 __fastcall Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync(void *a0, __int64 a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  void *v16; // x1
  __int128 v18; // [xsp+0h] [xbp+0h] BYREF
  __int128 v19; // [xsp+10h] [xbp+10h] BYREF
  __int128 v20; // [xsp+20h] [xbp+20h] BYREF
  __int64 v21; // [xsp+30h] [xbp+30h]

  if ( (unk_F413031 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54___);
    unk_F413031 = 1;
  }
  v21 = 0;
  v19 = 0u;
  v20 = 0u;
  v18 = 0u;
  sub_63CEE24((char *)&v18 + 8, 0, (int)a2, v3, v4, v5);
  *((_QWORD *)&v19 + 1) = a0;
  sub_63CEE24((char *)&v19 + 8, (int)a0, v8, v9, v10, v11);
  *(_QWORD *)&v20 = a1;
  sub_63CEE24(&v20, 0, v12, v13, v14, v15);
  LODWORD(v18) = -1;
  if ( !*(_QWORD *)(Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54___
                  + 56LL) )
    sub_6407F5C();
  Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync_d__54__MoveNext((__int64)&v18, v16);
  return sub_64DD1D4((char *)&v18 + 8, 0);
}

