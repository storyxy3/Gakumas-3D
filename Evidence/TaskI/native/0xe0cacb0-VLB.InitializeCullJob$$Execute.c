// 0xe0cacb0 @ 0xe0cacb0
void __fastcall VLB_InitializeCullJob__Execute(__int64 a0, void *a1)
{
  if ( (unk_F43D9D4 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeList_int__Clear__);
    unk_F43D9D4 = 1;
  }
  Unity_Collections_NativeList_int___Clear(a0, Method_Unity_Collections_NativeList_int__Clear__);
}

