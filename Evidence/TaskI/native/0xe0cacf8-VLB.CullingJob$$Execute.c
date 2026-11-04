// 0xe0cacf8 @ 0xe0cacf8
void __fastcall VLB_CullingJob__Execute(__int64 a0, int a1, void *a2)
{
  __int64 v5; // x0
  UnityEngine_Bounds_o *v6; // x1
  __int64 v7; // x8
  __int128 v8; // q0
  __int64 v9; // x8
  __int128 v10; // [xsp+0h] [xbp+0h] BYREF
  __int64 v11; // [xsp+10h] [xbp+10h]

  if ( (unk_F43D9D5 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeList_ParallelWriter_int__AddNoResize__);
    unk_F43D9D5 = 1;
  }
  if ( *(_BYTE *)(*(_QWORD *)(a0 + 16) + a1) )
  {
    v5 = *(_QWORD *)a0;
    v6 = *(UnityEngine_Bounds_o **)(a0 + 8);
    v7 = *(_QWORD *)(a0 + 32) + 24LL * a1;
    v8 = *(_OWORD *)v7;
    v9 = *(_QWORD *)(v7 + 16);
    v10 = v8;
    v11 = v9;
    if ( VLB_Utils__TestPlanesAABB(v5, v6, &v10) )
      Unity_Collections_NativeList_ParallelWriter_int___AddNoResize(
        a0 + 48,
        a1,
        Method_Unity_Collections_NativeList_ParallelWriter_int__AddNoResize__);
  }
}

