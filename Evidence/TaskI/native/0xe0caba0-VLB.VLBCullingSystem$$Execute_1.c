// 0xe0caba0 @ 0xe0caba0
void __fastcall VLB_VLBCullingSystem__Execute_1(void *a0, void *a1, void *a2, int a3, void *a4)
{
  __int64 v7; // x21
  __int64 v8; // x22
  __int64 v9; // x1
  void *v10; // x2
  __int64 v11; // x0
  void *v12; // x1
  void *v13; // x4
  __int64 v14; // x0
  __int64 v15; // x1
  __int128 v16; // [xsp+0h] [xbp+0h]
  __int128 v17; // [xsp+10h] [xbp+10h]
  __int128 v18; // [xsp+20h] [xbp+20h]
  __int128 v19; // [xsp+30h] [xbp+30h] BYREF
  __int128 v20; // [xsp+40h] [xbp+40h]
  __int128 v21; // [xsp+50h] [xbp+50h]
  __int64 v22; // [xsp+60h] [xbp+60h]

  if ( (unk_F43D9D3 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Jobs_IJobExtensions_Schedule_InitializeCullJob___);
    sub_63CEE78(&Method_Unity_Jobs_IJobParallelForExtensions_Schedule_CullingJob___);
    a0 = (void *)sub_63CEE78(&Method_Unity_Collections_NativeList_int__AsParallelWriter__);
    unk_F43D9D3 = 1;
  }
  if ( !a2 || (a0 = (char *)a2 + 80, v7 = *((_QWORD *)a2 + 10), v16 = *((_OWORD *)a2 + 4), !a1) )
  {
    sub_63CF120(a0, a1);
    JUMPOUT(0xE0CACB0);
  }
  v17 = *(_OWORD *)((char *)a1 + 120);
  v18 = *(_OWORD *)((char *)a1 + 104);
  v8 = Unity_Collections_NativeList_int___AsParallelWriter(
         (__int64)a0,
         Method_Unity_Collections_NativeList_int__AsParallelWriter__);
  v9 = *((_QWORD *)a1 + 3);
  v10 = *((void **)a1 + 4);
  v19 = v16;
  v20 = v17;
  v21 = v18;
  v11 = Unity_Jobs_IJobExtensions__Schedule_InitializeCullJob_(v7, v9, v10);
  v13 = v12;
  LODWORD(v12) = *((_DWORD *)a1 + 4);
  v22 = v8;
  v14 = Unity_Jobs_IJobParallelForExtensions__Schedule_CullingJob_((__int64)&v19, (int)v12, 16, v11, v13);
  *((_QWORD *)a2 + 3) = v14;
  *((_QWORD *)a2 + 4) = v15;
  *((_QWORD *)a1 + 3) = v14;
  *((_QWORD *)a1 + 4) = v15;
}

