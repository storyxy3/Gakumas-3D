// VLB.SharedVLBEntityManager$$OnVLBRemove @ 0xe0ce1bc
void __fastcall VLB_SharedVLBEntityManager__OnVLBRemove(void *a0, void *a1, void *a2)
{
  __int64 v3; // x1

  if ( a1 && (a0 = *((void **)a0 + 2)) != nullptr )
    v3 = *((_QWORD *)a1 + 40);
  else
    a0 = (void *)sub_63CF120(a0, a1);
  VLB_VLBEntityManager__DestroyEntity(a0, v3, a2);
}

