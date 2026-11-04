// Campus.Crowd.BillboardMatricesJobHandler$$Schedule @ 0xddc6424
__int64 __fastcall Campus_Crowd_BillboardMatricesJobHandler__Schedule(void *a0, void *a1, void *a2)
{
  __int64 v5; // x8
  __int64 v6; // x9
  _DWORD *v7; // x10
  __int64 v8; // x0
  __int64 result; // x0
  __int64 v10; // x1
  __int64 v11; // x22
  __int64 v12; // x8
  __int64 v13; // x23
  __int64 v14; // x9
  _DWORD *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x0
  __int128 v18; // q0
  __int128 v19; // q1
  __int64 v20; // x1
  __int64 v21; // x0
  int v22; // w1
  void *v23; // x2
  __int64 v24; // [xsp+0h] [xbp+0h] BYREF
  __int64 v25; // [xsp+8h] [xbp+8h]
  __int64 v26; // [xsp+10h] [xbp+10h]
  __int64 v27; // [xsp+18h] [xbp+18h]
  __int128 v28; // [xsp+20h] [xbp+20h]
  __int128 v29; // [xsp+30h] [xbp+30h]

  if ( (unk_F43BCFF & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_ICrowdAnimation_TypeInfo);
    sub_63CEE78(&Method_Unity_Jobs_IJobParallelForExtensions_Schedule_BillboardMatricesJobHandler_BillboardMatricesJob___);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Bounds__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Matrix4x4__get_IsCreated__);
    unk_F43BCFF = 1;
  }
  if ( !a0 )
    return 0;
  v5 = *(_QWORD *)a0;
  v6 = *(unsigned __int16 *)(*(_QWORD *)a0 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)a0 + 302LL) )
  {
    v7 = (_DWORD *)(*(_QWORD *)(v5 + 176) + 8LL);
    while ( *((_QWORD *)v7 - 1) != Campus_Crowd_ICrowdAnimation_TypeInfo )
    {
      --v6;
      v7 += 4;
      if ( !v6 )
        goto LABEL_8;
    }
    v8 = v5 + 16LL * (*v7 + 2) + 312;
  }
  else
  {
LABEL_8:
    v8 = sub_6408234(a0, Campus_Crowd_ICrowdAnimation_TypeInfo, 2);
  }
  result = (*(__int64 (__fastcall **)(void *, _QWORD))v8)(a0, *(_QWORD *)(v8 + 8));
  if ( result )
  {
    if ( !a1 )
    {
      v21 = sub_63CF120(result, v10);
      Campus_Crowd_BillboardMatricesJobHandler_BillboardMatricesJob__Execute(v21, v22, v23);
      return result;
    }
    v11 = *((_QWORD *)a1 + 5);
    if ( v11 && *((_QWORD *)a1 + 7) && *((_QWORD *)a1 + 9) )
    {
      v12 = *(_QWORD *)a0;
      v13 = *((_QWORD *)a1 + 6);
      v14 = *(unsigned __int16 *)(*(_QWORD *)a0 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)a0 + 302LL) )
      {
        v15 = (_DWORD *)(*(_QWORD *)(v12 + 176) + 8LL);
        while ( *((_QWORD *)v15 - 1) != Campus_Crowd_ICrowdAnimation_TypeInfo )
        {
          --v14;
          v15 += 4;
          if ( !v14 )
            goto LABEL_19;
        }
        v16 = v12 + 16LL * (*v15 + 2) + 312;
      }
      else
      {
LABEL_19:
        v16 = sub_6408234(a0, Campus_Crowd_ICrowdAnimation_TypeInfo, 2);
      }
      v17 = (*(__int64 (__fastcall **)(void *, _QWORD))v16)(a0, *(_QWORD *)(v16 + 8));
      v24 = v11;
      v18 = *(_OWORD *)((char *)a1 + 56);
      v19 = *(_OWORD *)((char *)a1 + 72);
      v25 = v13;
      v26 = v17;
      v27 = v20;
      v28 = v18;
      v29 = v19;
      return Unity_Jobs_IJobParallelForExtensions__Schedule_BillboardMatricesJobHandler_BillboardMatricesJob_(
               (__int64)&v24,
               32,
               4,
               0,
               nullptr);
    }
    return 0;
  }
  return result;
}

