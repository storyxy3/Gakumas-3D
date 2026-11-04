// 0x8641bcc @ 0x8641bcc
__int64 __fastcall Campus_Live_LiveResourceManager__LoadAudioAsync(void *a0, void *a1, __int64 a2, void *a3)
{
  int v4; // w4
  void *v5; // x5
  __int64 v6; // x8
  __int64 v10; // x19
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  int v19; // w2
  int v20; // w3
  int v21; // w4
  void *v22; // x5
  void *v23; // x1
  __int64 result; // x0
  __int64 v25; // x8
  __int128 v26; // [xsp+8h] [xbp+8h] BYREF
  __int64 v27; // [xsp+18h] [xbp+18h]
  __int64 v28; // [xsp+20h] [xbp+20h] BYREF
  __int64 v29; // [xsp+28h] [xbp+28h] BYREF
  __int64 v30; // [xsp+30h] [xbp+30h]
  __int64 v31; // [xsp+38h] [xbp+38h]
  __int128 v32; // [xsp+40h] [xbp+40h] BYREF
  __int128 v33; // [xsp+50h] [xbp+50h] BYREF
  __int128 v34; // [xsp+60h] [xbp+60h]

  v10 = v6;
  if ( (unk_F4139A9 & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__Create__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__Start_LiveResourceManager__LoadAudioAsync_d__11___);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__get_Task__);
    unk_F4139A9 = 1;
  }
  v28 = 0;
  v33 = 0u;
  v34 = 0u;
  v32 = 0u;
  v31 = 0;
  v29 = 0;
  v30 = 0;
  sub_63CEE24(&v29, 0, a2, (int)a3, v4, v5);
  *(_QWORD *)&v32 = a0;
  sub_63CEE24(&v32, (int)a0, v11, v12, v13, v14);
  *((_QWORD *)&v32 + 1) = a1;
  sub_63CEE24((char *)&v32 + 8, (int)a1, v15, v16, v17, v18);
  *(_QWORD *)&v33 = a2;
  sub_63CEE24(&v33, 0, v19, v20, v21, v22);
  LODWORD(v28) = -1;
  if ( !*(_QWORD *)(Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__Start_LiveResourceManager__LoadAudioAsync_d__11___
                  + 56LL) )
    sub_6407F5C();
  Campus_Live_LiveResourceManager__LoadAudioAsync_d__11__MoveNext((__int64)&v28, v23);
  result = (__int64)sub_6510EEC(
                      &v26,
                      &v29,
                      Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__get_Task__);
  v25 = v27;
  *(_OWORD *)v10 = v26;
  *(_QWORD *)(v10 + 16) = v25;
  return result;
}

