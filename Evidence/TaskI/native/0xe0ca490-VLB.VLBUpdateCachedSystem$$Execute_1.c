// 0xe0ca490 @ 0xe0ca490
void __fastcall VLB_VLBUpdateCachedSystem__Execute_1(void *a0, void *a1, void *a2, int a3, void *a4)
{
  __int128 v8; // q2
  __int128 v9; // q1
  __int128 v10; // q0
  __int128 v11; // q1
  __int64 v12; // x20
  __int64 v13; // x1
  __int64 v14; // x0
  int v15; // w1
  __int64 v16; // x2
  void *v17; // x3
  __int128 v18; // [xsp+0h] [xbp+0h] BYREF
  __int128 v19; // [xsp+10h] [xbp+10h]
  __int128 v20; // [xsp+20h] [xbp+20h]
  __int128 v21; // [xsp+30h] [xbp+30h]
  __int128 v22; // [xsp+40h] [xbp+40h]
  __int128 v23; // [xsp+50h] [xbp+50h] BYREF
  __int64 v24; // [xsp+60h] [xbp+60h] BYREF

  if ( (unk_F43D9CC & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Jobs_IJobParallelForTransformExtensions_ScheduleReadOnly_VLBUpdateCachedSystem_UpdateTransformsJob___);
    unk_F43D9CC = 1;
  }
  v23 = 0u;
  v18 = 0u;
  v19 = 0u;
  v20 = 0u;
  v21 = 0u;
  v22 = 0u;
  if ( a3 )
  {
    if ( !a2 )
      goto LABEL_10;
    v23 = *(_OWORD *)((char *)a2 + 24);
    Unity_Jobs_JobHandle__Complete((__int64)&v23, nullptr);
    if ( !*((_BYTE *)a2 + 48) )
      *((_BYTE *)a2 + 48) = 1;
    v8 = *(_OWORD *)((char *)a2 + 72);
    v9 = *(_OWORD *)((char *)a2 + 376);
    v18 = *(_OWORD *)((char *)a2 + 360);
    v19 = v9;
    v10 = *(_OWORD *)((char *)a2 + 88);
    v11 = *(_OWORD *)((char *)a2 + 104);
    v20 = v8;
    v21 = v10;
    v22 = v11;
    if ( a1 )
    {
      v12 = *((_QWORD *)a1 + 8);
      v23 = 0u;
      memcpy(&v24, &v18, 0x50u);
      *((_QWORD *)a2 + 3) = UnityEngine_Jobs_IJobParallelForTransformExtensions__ScheduleReadOnly_VLBUpdateCachedSystem_UpdateTransformsJob_(
                              (__int64)&v24,
                              v12,
                              16,
                              0,
                              nullptr);
      *((_QWORD *)a2 + 4) = v13;
    }
    else
    {
LABEL_10:
      v14 = sub_63CF120(a0, a1);
      VLB_VLBUpdateCachedSystem_UpdateTransformsJob__Execute(v14, v15, v16, v17);
    }
  }
}

