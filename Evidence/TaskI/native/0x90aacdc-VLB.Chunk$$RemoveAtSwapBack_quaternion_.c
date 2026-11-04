// VLB.Chunk$$RemoveAtSwapBack<quaternion> @ 0x90aacdc
void __fastcall VLB_Chunk__RemoveAtSwapBack_quaternion_(void *a0, void *a1, int a2, int a3, void *a4)
{
  *(_OWORD *)(*(_QWORD *)a1 + 16LL * a2) = *(_OWORD *)(*(_QWORD *)a1 + 16LL * (a3 - 1));
}

