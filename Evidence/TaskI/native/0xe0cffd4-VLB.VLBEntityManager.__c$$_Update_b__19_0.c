// VLB.VLBEntityManager.<>c$$<Update>b__19_0 @ 0xe0cffd4
int __fastcall VLB_VLBEntityManager___c___Update_b__19_0(void *a0, __int64 a1, __int64 a2, void *a3)
{
  if ( (*(_BYTE *)(a1 + 36) & 1) != 0 )
  {
    if ( (*(_BYTE *)(a2 + 36) & 1) == 0 )
      return -1;
  }
  else if ( (*(_BYTE *)(a2 + 36) & 1) != 0 )
  {
    return 1;
  }
  if ( *(_QWORD *)a1 && *(_QWORD *)a2 )
    return System_Int32__CompareTo_1(*(_QWORD *)a1 + 72, *(_DWORD *)(*(_QWORD *)a2 + 72LL), nullptr);
  else
    return *(_DWORD *)(sub_63CF120(a0, a1) + 16);
}

