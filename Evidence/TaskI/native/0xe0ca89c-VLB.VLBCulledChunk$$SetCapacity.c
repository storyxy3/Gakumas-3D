// VLB.VLBCulledChunk$$SetCapacity @ 0xe0ca89c
void __fastcall VLB_VLBCulledChunk__SetCapacity(void *a0, int a1, void *a2)
{
  if ( (unk_F43D9CF & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeList_int__SetCapacity__);
    unk_F43D9CF = 1;
  }
  Unity_Collections_NativeList_int___SetCapacity(
    (__int64)a0 + 80,
    a1,
    Method_Unity_Collections_NativeList_int__SetCapacity__);
  *((_DWORD *)a0 + 5) = a1;
}

