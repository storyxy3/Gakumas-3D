// VLB.VLBDrawCallChunk$$.ctor @ 0xe0cada0
void __fastcall VLB_VLBDrawCallChunk___ctor(void *a0, void *a1)
{
  __int128 v3; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43D9D6 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int___ctor___1);
    unk_F43D9D6 = 1;
  }
  System_Object___ctor(a0, nullptr);
  v3 = 0u;
  Unity_Collections_NativeArray_int____ctor(
    (__int64)&v3,
    1,
    4,
    1,
    (void *)Method_Unity_Collections_NativeArray_int___ctor___1);
  *(_OWORD *)((char *)a0 + 136) = v3;
}

