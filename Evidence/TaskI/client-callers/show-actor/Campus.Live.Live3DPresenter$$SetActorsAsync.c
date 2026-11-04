// 0x84f43c4 @ 0x84f43c4
__int64 __fastcall Campus_Live_Live3DPresenter__SetActorsAsync(void *a0, void *a1, __int64 a2, void *a3)
{
  int v4; // w4
  void *v5; // x5
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5
  void *v21; // x1
  __int128 v23; // [xsp+0h] [xbp+0h] BYREF
  __int128 v24; // [xsp+10h] [xbp+10h] BYREF
  __int128 v25; // [xsp+20h] [xbp+20h] BYREF
  __int128 v26; // [xsp+30h] [xbp+30h]
  __int128 v27; // [xsp+40h] [xbp+40h]
  __int64 v28; // [xsp+50h] [xbp+50h]

  if ( (unk_F41302D & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Live3DPresenter__SetActorsAsync_d__48___);
    unk_F41302D = 1;
  }
  v28 = 0;
  v24 = 0u;
  v25 = 0u;
  v26 = 0u;
  v27 = 0u;
  v23 = 0u;
  sub_63CEE24((char *)&v23 + 8, 0, a2, (int)a3, v4, v5);
  *((_QWORD *)&v24 + 1) = a0;
  sub_63CEE24((char *)&v24 + 8, (int)a0, v9, v10, v11, v12);
  *(_QWORD *)&v25 = a1;
  sub_63CEE24(&v25, (int)a1, v13, v14, v15, v16);
  *((_QWORD *)&v25 + 1) = a2;
  sub_63CEE24((char *)&v25 + 8, 0, v17, v18, v19, v20);
  LODWORD(v23) = -1;
  if ( !*(_QWORD *)(Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Live3DPresenter__SetActorsAsync_d__48___
                  + 56LL) )
    sub_6407F5C();
  Campus_Live_Live3DPresenter__SetActorsAsync_d__48__MoveNext((__int64)&v23, v21);
  return sub_64DD1D4((char *)&v23 + 8, 0);
}

