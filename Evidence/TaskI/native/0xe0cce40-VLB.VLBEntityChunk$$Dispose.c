// VLB.VLBEntityChunk$$Dispose @ 0xe0cce40
void __fastcall VLB_VLBEntityChunk__Dispose(void *a0, void *a1)
{
  char *v3; // x19
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43D9E6 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_Entity__Dispose___1);
    unk_F43D9E6 = 1;
  }
  if ( *((_DWORD *)a0 + 5) )
  {
    Unity_Collections_NativeArray_Entity___Dispose_1(
      (__int64)a0 + 40,
      Method_Unity_Collections_NativeArray_Entity__Dispose___1);
    UnityEngine_Jobs_TransformAccessArray__Dispose((__int64)a0 + 64, nullptr);
    *((_QWORD *)a0 + 7) = 0;
    v3 = (char *)a0 + 56;
    sub_63CEE24(v3, 0, v4, v5, v6, v7);
    *((_QWORD *)v3 - 5) = 0;
  }
}

