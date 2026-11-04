// VLB.SharedVLBEntityManager$$Release @ 0xe0cd6bc
void __fastcall VLB_SharedVLBEntityManager__Release(void *a0, void *a1, void *a2)
{
  int v3; // w8
  int v4; // w8

  v3 = *((_DWORD *)a0 + 6);
  if ( v3 )
  {
    v4 = v3 - 1;
    *((_DWORD *)a0 + 6) = v4;
    if ( !v4 )
      VLB_SharedVLBEntityManager__Dispose(a0, a1);
  }
}

