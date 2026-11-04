// VLB.VLBCulledChunk$$.ctor @ 0xe0ca7d4
void __fastcall VLB_VLBCulledChunk___ctor(void *a0, void *a1)
{
  unsigned int v3; // w0
  __int128 v4; // [xsp+0h] [xbp+0h] BYREF
  __int64 v5; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F43D9CE & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Plane___ctor__);
    sub_63CEE78(&Method_Unity_Collections_NativeList_int___ctor__);
    unk_F43D9CE = 1;
  }
  System_Object___ctor(a0, nullptr);
  v4 = 0u;
  Unity_Collections_NativeArray_Plane____ctor(
    (__int64)&v4,
    6,
    4,
    1,
    Method_Unity_Collections_NativeArray_Plane___ctor__);
  *((_OWORD *)a0 + 4) = v4;
  v3 = Unity_Collections_AllocatorManager_AllocatorHandle__op_Implicit(4, nullptr);
  v5 = 0;
  Unity_Collections_NativeList_int____ctor((__int64)&v5, v3, Method_Unity_Collections_NativeList_int___ctor__);
  *((_QWORD *)a0 + 10) = v5;
}

