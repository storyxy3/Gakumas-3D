// 0xbd02f94 @ 0xbd02f94
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall VL_Core_VLActorController_object__object__object___GetSkeleton_1(void *a0, void *a1, void *a2)
{
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  __int64 v6; // x8
  __int64 v8; // x19
  __int64 result; // x0
  int v10; // w9
  __int128 v11; // q0
  __int64 v12; // x8
  int v13; // w9
  __int128 v14; // q1
  __int128 v15; // q2
  __int64 v16; // x8
  void *v17; // x0
  void *v18; // x1
  __int128 v19; // [xsp+0h] [xbp+0h] BYREF
  __int128 v20; // [xsp+10h] [xbp+10h] OVERLAPPED
  _BYTE v21[24]; // [xsp+20h] [xbp+20h]

  *(_QWORD *)&v21[16] = 0;
  v20 = 0u;
  *(_OWORD *)v21 = 0u;
  v19 = 0u;
  if ( a1 )
  {
    v8 = v6;
    *(_QWORD *)&v19 = *((_QWORD *)a1 + 3);
    sub_63CEE24(&v19, v19, (int)a2, v3, v4, v5);
    v10 = *((_DWORD *)a1 + 10);
    v11 = *(_OWORD *)((char *)a1 + 44);
    *(_QWORD *)&v20 = *((_QWORD *)a1 + 4);
    v12 = *((_QWORD *)a1 + 11);
    DWORD2(v20) = v10;
    v13 = *((_DWORD *)a1 + 24);
    *(__int128 *)((char *)&v20 + 12) = v11;
    *(_QWORD *)&v21[12] = v12;
    v14 = v20;
    *(_DWORD *)&v21[20] = v13;
    v15 = *(_OWORD *)v21;
    v16 = *(_QWORD *)&v21[16];
    *(_OWORD *)v8 = v19;
    *(_OWORD *)(v8 + 16) = v14;
    *(_OWORD *)(v8 + 32) = v15;
    *(_QWORD *)(v8 + 48) = v16;
  }
  else
  {
    v17 = (void *)sub_63CF120(a0, 0);
    VL_Core_VLActorController_object__object__object___OnBuildModelFail(v17, v18);
  }
  return result;
}

