// Campus.Crowd.CrowdSortJob$$Execute @ 0xddc8cb0
void __fastcall Campus_Crowd_CrowdSortJob__Execute(__int64 a0, void *a1)
{
  __int64 v3; // x0
  __int64 v4; // x22
  __int64 i; // x23
  int v6; // w20
  unsigned int v7; // w0
  __int128 v8; // q0
  __int64 v9; // x8
  int v10; // w20
  unsigned int v11; // w0
  void *UnsafePtr_UnsafeList_uint; // x0
  __int64 v13; // x1
  void *v14; // x2
  int v15; // w8
  __int64 v16; // x20
  __int64 j; // x22
  __int64 v18; // x10
  int v19; // w27
  unsigned int v20; // w25
  unsigned __int16 v21; // w26
  unsigned __int64 v22; // x21
  __int64 v23; // x21
  __int64 v24; // x28
  __int64 v25; // x21
  __int64 v26; // x0
  __int64 v27; // x0
  char *UnsafePtr_uint; // x21
  __int64 v29; // x23
  __int64 v30; // x24
  void *v31; // x1
  void *v32; // x20
  int Value; // w0
  __int128 v34; // [xsp+0h] [xbp+0h] BYREF
  __int64 v35; // [xsp+10h] [xbp+10h]
  _DWORD *v36; // [xsp+18h] [xbp+18h] BYREF
  __int64 v37; // [xsp+20h] [xbp+20h]
  __int64 v38; // [xsp+28h] [xbp+28h]
  __int64 v39; // [xsp+30h] [xbp+30h] BYREF
  void *v40; // [xsp+38h] [xbp+38h]

  if ( (unk_F43BD11 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_uint___);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility_GetUnsafePtr_UnsafeList_uint____);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_UnsafeList_uint___Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_UnsafeList_uint____ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_CellSortData__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_Value__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__set_Value__);
    sub_63CEE78(&Method_Unity_Collections_NativeSortExtension_Sort_CellSortData__CellSortDataComparer___);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Add__);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___ctor__);
    sub_63CEE78(&Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__get_Length__);
    unk_F43BD11 = 1;
  }
  v3 = *(_QWORD *)a0;
  v39 = 0;
  v40 = nullptr;
  v36 = nullptr;
  v37 = 0;
  v38 = 0;
  if ( v3 && *(int *)(a0 + 8) >= 1 )
  {
    Unity_Collections_NativeSortExtension__Sort_CellSortData__CellSortDataComparer_(v3, *(_QWORD *)(a0 + 8), nullptr);
    Unity_Collections_NativeArray_UnsafeList_uint_____ctor(
      (__int64)&v39,
      8,
      2,
      1,
      Method_Unity_Collections_NativeArray_UnsafeList_uint____ctor__);
    v4 = 0;
    for ( i = 0; i != 32; i += 4 )
    {
      v6 = *(_DWORD *)(a0 + 208);
      v7 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(2, nullptr);
      v34 = 0u;
      v35 = 0;
      Unity_Collections_LowLevel_Unsafe_UnsafeList_uint____ctor(
        (__int64)&v34,
        v6,
        v7,
        0,
        Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___ctor__);
      v8 = v34;
      v9 = v39 + v4;
      v4 += 24;
      *(_QWORD *)(v9 + 16) = v35;
      *(_OWORD *)v9 = v8;
      *(_DWORD *)(*(_QWORD *)(a0 + 48) + i) = 0;
    }
    v10 = *(_DWORD *)(a0 + 24) - 8 * *(_DWORD *)(a0 + 208);
    v11 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(2, nullptr);
    Unity_Collections_LowLevel_Unsafe_UnsafeList_uint____ctor(
      (__int64)&v36,
      v10,
      v11,
      0,
      Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___ctor__);
    UnsafePtr_UnsafeList_uint = Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_UnsafeList_uint__(
                                  v39,
                                  v40);
    v15 = *(_DWORD *)(a0 + 8);
    v16 = (__int64)UnsafePtr_UnsafeList_uint;
    if ( v15 >= 1 )
    {
      for ( j = 0; j < v15; ++j )
      {
        v18 = *(_QWORD *)a0 + 8 * j;
        if ( *(_WORD *)(v18 + 4) )
        {
          v19 = *(unsigned __int16 *)(v18 + 2);
          v20 = *(unsigned __int16 *)(v18 + 4) + v19;
          v21 = *(_WORD *)(v18 + 2);
          do
          {
            v22 = *(unsigned int *)(*(_QWORD *)(a0 + 16) + 32LL * v21);
            if ( (v22 & 1) != 0
              && !Campus_Crowd_CrowdSortJob__IsCulledBoundingSphere(a0, v13, v14)
              && !Campus_Crowd_CrowdSortJob__IsCulledOcclusionSphere(a0, v13, v14) )
            {
              v23 = v16 + 24 * ((v22 >> 20) & 7);
              v24 = *(int *)(v23 + 8);
              if ( (int)v24 >= *(_DWORD *)(a0 + 208) )
              {
                v25 = (int)v37;
                if ( (int)v37 >= SHIDWORD(v37) )
                {
                  v27 = *(_QWORD *)(Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Add__ + 32LL);
                  if ( (*(_WORD *)(v27 + 309) & 1) == 0 )
                    sub_6407F00(v27);
                  Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___Resize(
                    (__int64)&v36,
                    v25 + 1,
                    0,
                    *(void **)(*(_QWORD *)(v27 + 192) + 128LL));
                  v36[v25] = v19;
                }
                else
                {
                  v36[(int)v37] = v19;
                  LODWORD(v37) = v37 + 1;
                }
              }
              else if ( (int)v24 >= *(_DWORD *)(v23 + 12) )
              {
                v26 = *(_QWORD *)(Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Add__ + 32LL);
                if ( (*(_WORD *)(v26 + 309) & 1) == 0 )
                  sub_6407F00(v26);
                Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___Resize(
                  v23,
                  v24 + 1,
                  0,
                  *(void **)(*(_QWORD *)(v26 + 192) + 128LL));
                *(_DWORD *)(*(_QWORD *)v23 + 4 * v24) = v19;
              }
              else
              {
                *(_DWORD *)(*(_QWORD *)v23 + 4 * v24) = v19;
                ++*(_DWORD *)(v23 + 8);
              }
            }
            v19 = ++v21;
          }
          while ( v20 > v21 );
          v15 = *(_DWORD *)(a0 + 8);
        }
      }
    }
    UnsafePtr_uint = (char *)Unity_Collections_LowLevel_Unsafe_NativeArrayUnsafeUtility__GetUnsafePtr_uint_(
                               *(_QWORD *)(a0 + 32),
                               *(void **)(a0 + 40));
    if ( (int)v40 >= 1 )
    {
      v29 = 0;
      do
      {
        v30 = *(int *)(v16 + 8);
        v31 = *(void **)v16;
        *(_DWORD *)(*(_QWORD *)(a0 + 48) + 4 * v29) = v30;
        Unity_Collections_LowLevel_Unsafe_UnsafeUtility__MemCpy(UnsafePtr_uint, v31, 4 * (int)v30, nullptr);
        Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___Dispose(
          v16,
          Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Dispose__);
        ++v29;
        UnsafePtr_uint += 4 * v30;
        v16 += 24;
      }
      while ( v29 < (int)v40 );
    }
    Unity_Collections_NativeArray_UnsafeList_uint____Dispose(
      (__int64)&v39,
      Method_Unity_Collections_NativeArray_UnsafeList_uint___Dispose__);
    Unity_Collections_NativeReference_int___set_Value(
      a0 + 64,
      v37,
      Method_Unity_Collections_NativeReference_int__set_Value__);
    v32 = v36;
    Value = Unity_Collections_NativeReference_int___get_Value(
              a0 + 64,
              Method_Unity_Collections_NativeReference_int__get_Value__);
    Unity_Collections_LowLevel_Unsafe_UnsafeUtility__MemCpy(UnsafePtr_uint, v32, 4 * Value, nullptr);
    Unity_Collections_LowLevel_Unsafe_UnsafeList_uint___Dispose(
      (__int64)&v36,
      Method_Unity_Collections_LowLevel_Unsafe_UnsafeList_uint__Dispose__);
  }
}

