// 0x8642644 @ 0x8642644
void __fastcall Campus_Live_LiveResourceManager__LoadAudioAsync_d__11__MoveNext(__int64 a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v6; // x19
  int v7; // w8
  __int64 v8; // x8
  void *v9; // x0
  void *v10; // x0
  __int64 v11; // x1
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  __int64 v16; // x9
  __int64 v17; // x0
  __int128 v18; // q0
  __int64 v19; // x8
  __int64 v20; // x8
  __int128 v21; // q0
  __int64 *v22; // x20
  unsigned int v23; // w21
  __int64 v24; // x0
  __int64 v25; // x1
  __int64 v26; // x0
  __int64 v27; // x8
  __int64 v28; // x9
  int *v29; // x10
  __int64 v30; // x0
  __int64 v31; // x20
  __int64 *v32; // x21
  __int64 v33; // x0
  __int64 v34; // x1
  __int64 v35; // x0
  __int64 v36; // x8
  __int64 v37; // x9
  _DWORD *v38; // x10
  __int64 v39; // x0
  void *v40; // x0
  int v41; // w1
  _QWORD **v42; // x20
  __int64 v43; // x0
  int v44; // w21
  _QWORD *v45; // x20
  __int64 v46; // x0
  _QWORD *exception; // x0
  __int128 v48; // [xsp+0h] [xbp+0h] BYREF
  __int64 v49; // [xsp+10h] [xbp+10h]
  __int64 v50; // [xsp+20h] [xbp+20h]
  int v51; // [xsp+28h] [xbp+28h]
  __int128 v52; // [xsp+30h] [xbp+30h]
  __int64 v53; // [xsp+40h] [xbp+40h]
  __int128 v54; // [xsp+50h] [xbp+50h] BYREF
  __int64 v55; // [xsp+60h] [xbp+60h]

  v6 = a0;
  if ( (unk_F4139AF & 1) == 0 )
  {
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__AwaitUnsafeOnCompleted_UniTask_Awaiter_AudioClip___LiveResourceManager__LoadAudioAsync_d__11___);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__SetResult__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AudioClip__GetResult__);
    sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AudioClip__get_IsCompleted__);
    sub_63CEE78(&Method_Campus_Live_LiveAssetCache_AudioClip__LoadAssetAsync__);
    sub_63CEE78(&Method_Campus_Live_LiveObjectStoreBase_LiveAssetCache_AudioClip___GetOrCreate__);
    a0 = sub_63CEE78(&Method_Cysharp_Threading_Tasks_UniTask_AudioClip__GetAwaiter__);
    unk_F4139AF = 1;
  }
  v7 = *(_DWORD *)v6;
  v54 = 0u;
  v55 = 0;
  v52 = 0u;
  v53 = 0;
  v51 = 0;
  if ( v7 )
  {
    v8 = *(_QWORD *)(v6 + 32);
    if ( v8 )
    {
      v9 = *(void **)(v8 + 48);
      if ( v9 )
      {
        v10 = Campus_Live_LiveObjectStoreBase_object___GetOrCreate(
                v9,
                *(void **)(v6 + 40),
                Method_Campus_Live_LiveObjectStoreBase_LiveAssetCache_AudioClip___GetOrCreate__);
        if ( v10 )
        {
          Campus_Live_LiveAssetCache_object___LoadAssetAsync(
            v10,
            *(void **)(v6 + 40),
            *(_QWORD *)(v6 + 48),
            Method_Campus_Live_LiveAssetCache_AudioClip__LoadAssetAsync__);
          v16 = v49;
          v49 = 0;
          v52 = v48;
          v53 = v16;
          v17 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_AudioClip__GetAwaiter__ + 32LL);
          v48 = 0u;
          if ( (*(_BYTE *)(v17 + 309) & 1) == 0 )
            sub_6407F00(v17);
          v48 = v52;
          v49 = v53;
          sub_63CEE24(&v48, 0, v12, v13, v14, v15);
          v54 = v48;
          v55 = v49;
          if ( (sub_65115C4(&v54, Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AudioClip__get_IsCompleted__) & 1) == 0 )
          {
            v18 = v54;
            v19 = v55;
            *(_DWORD *)v6 = 0;
            *(_OWORD *)(v6 + 56) = v18;
            *(_QWORD *)(v6 + 72) = v19;
            sub_63CEE24((void *)(v6 + 56), 0, v2, v3, v4, v5);
            ((void (__fastcall *)(__int64, __int128 *, __int64, _QWORD))loc_864A254)(
              v6 + 8,
              &v54,
              v6,
              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__AwaitUnsafeOnCompleted_UniTask_Awaiter_AudioClip___LiveResourceManager__LoadAudioAsync_d__11___);
            return;
          }
          goto LABEL_12;
        }
LABEL_40:
        v40 = (void *)sub_63CF120(v10, v11);
        if ( v41 != 1 )
          sub_64BD8DC(v40);
        v42 = (_QWORD **)__cxa_begin_catch(v40);
        v43 = sub_63CEE8C(&System_Exception_TypeInfo);
        if ( (sub_63CF528(v43, **v42) & 1) == 0 )
        {
          exception = __cxa_allocate_exception(8u);
          *exception = *v42;
          __cxa_throw(exception, (struct type_info *)&`typeinfo for'Il2CppExceptionWrapper, nullptr);
        }
        v44 = v51;
        v45 = *v42;
        *(&v50 + v51) = (__int64)v45;
        v51 = v44 + 1;
        __cxa_end_catch();
        *(_DWORD *)v6 = -2;
        v46 = sub_63CEE8C(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__SetException__);
        sub_5D971E0(v6 + 8, v45, v46);
        v51 = v44;
        return;
      }
    }
    else
    {
      v9 = (void *)sub_63CF120(a0, a1);
    }
    v10 = (void *)sub_63CF120(v9, a1);
    goto LABEL_40;
  }
  v20 = *(_QWORD *)(v6 + 72);
  v21 = *(_OWORD *)(v6 + 56);
  *(_QWORD *)(v6 + 64) = 0;
  *(_QWORD *)(v6 + 72) = 0;
  *(_QWORD *)(v6 + 56) = 0;
  v55 = v20;
  v54 = v21;
  *(_DWORD *)v6 = -1;
LABEL_12:
  v22 = (__int64 *)v54;
  if ( (_QWORD)v54 )
  {
    v23 = (unsigned __int16)v55;
    v24 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_AudioClip__GetResult__ + 32LL);
    if ( (*(_WORD *)(v24 + 309) & 1) == 0 )
      sub_6407F00(v24);
    v25 = *(_QWORD *)(*(_QWORD *)(v24 + 192) + 40LL);
    if ( (*(_WORD *)(v25 + 309) & 1) == 0 )
    {
      sub_6407F00(*(_QWORD *)(*(_QWORD *)(v24 + 192) + 40LL));
      v25 = v26;
    }
    v27 = *v22;
    v28 = *(unsigned __int16 *)(*v22 + 302);
    if ( *(_WORD *)(*v22 + 302) )
    {
      v29 = (int *)(*(_QWORD *)(v27 + 176) + 8LL);
      while ( *((_QWORD *)v29 - 1) != v25 )
      {
        --v28;
        v29 += 4;
        if ( !v28 )
          goto LABEL_21;
      }
      v30 = v27 + 16LL * *v29 + 312;
    }
    else
    {
LABEL_21:
      v30 = sub_6408234(v22, v25, 0);
    }
    v31 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v30)(v22, v23, *(_QWORD *)(v30 + 8));
  }
  else
  {
    v31 = *((_QWORD *)&v54 + 1);
  }
  v32 = *(__int64 **)(v6 + 8);
  *(_DWORD *)v6 = -2;
  if ( v32 )
  {
    v33 = *(_QWORD *)(Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AudioClip__SetResult__
                    + 32LL);
    if ( (*(_WORD *)(v33 + 309) & 1) == 0 )
      sub_6407F00(v33);
    v34 = *(_QWORD *)(*(_QWORD *)(v33 + 192) + 8LL);
    if ( (*(_WORD *)(v34 + 309) & 1) == 0 )
    {
      sub_6407F00(*(_QWORD *)(*(_QWORD *)(v33 + 192) + 8LL));
      v34 = v35;
    }
    v36 = *v32;
    v37 = *(unsigned __int16 *)(*v32 + 302);
    if ( *(_WORD *)(*v32 + 302) )
    {
      v38 = (_DWORD *)(*(_QWORD *)(v36 + 176) + 8LL);
      while ( *((_QWORD *)v38 - 1) != v34 )
      {
        --v37;
        v38 += 4;
        if ( !v37 )
          goto LABEL_34;
      }
      v39 = v36 + 16LL * (*v38 + 2) + 312;
    }
    else
    {
LABEL_34:
      v39 = sub_6408234(v32, v34, 2);
    }
    (*(void (__fastcall **)(__int64 *, __int64, _QWORD))v39)(v32, v31, *(_QWORD *)(v39 + 8));
  }
  else
  {
    *(_QWORD *)(v6 + 24) = v31;
    sub_63CEE24((void *)(v6 + 24), v31, v2, v3, v4, v5);
  }
}

