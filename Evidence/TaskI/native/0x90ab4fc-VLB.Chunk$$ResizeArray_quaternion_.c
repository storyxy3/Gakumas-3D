// VLB.Chunk$$ResizeArray<quaternion> @ 0x90ab4fc
void __fastcall VLB_Chunk__ResizeArray_quaternion_(void *a0, void *a1, int a2, void *a3)
{
  void **v4; // x8
  __int128 v8; // [xsp+0h] [xbp+0h] BYREF

  v4 = *((void ***)a3 + 7);
  if ( !v4 )
  {
    sub_6407F5C();
    v4 = *((void ***)a3 + 7);
  }
  v8 = 0u;
  Unity_Collections_NativeArray_quaternion____ctor((__int64)&v8, a2, 4, 0, *v4);
  if ( *(_QWORD *)a1 )
  {
    Unity_Collections_NativeArray_quaternion___Copy_3(*(_QWORD *)a1, *((_QWORD *)a1 + 1), v8, *((void **)&v8 + 1));
    Unity_Collections_NativeArray_quaternion___Dispose((__int64)a1, *(void **)(*((_QWORD *)a3 + 7) + 56LL));
  }
  *(_OWORD *)a1 = v8;
}

