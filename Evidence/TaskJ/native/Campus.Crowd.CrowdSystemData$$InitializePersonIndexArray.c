// Campus.Crowd.CrowdSystemData$$InitializePersonIndexArray @ 0xddcb86c
void __fastcall Campus_Crowd_CrowdSystemData__InitializePersonIndexArray(void *a0, int a1, void *a2, void *a3)
{
  __int64 v6; // x9
  __int64 v7; // x8
  __int128 v8; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43BD2D & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_uint___ctor__);
    unk_F43BD2D = 1;
  }
  v8 = 0u;
  Unity_Collections_NativeArray_uint____ctor((__int64)&v8, a1, 4, 1, Method_Unity_Collections_NativeArray_uint___ctor__);
  *(_OWORD *)a2 = v8;
  if ( a1 >= 1 )
  {
    v6 = *(_QWORD *)a2;
    v7 = 0;
    do
    {
      *(_DWORD *)(v6 + 4 * v7) = v7;
      ++v7;
    }
    while ( a1 != v7 );
  }
}

