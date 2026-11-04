// VLB.SharedVLBEntityManager$$OnVLBPropertyChange @ 0xe0ce3c4
void __fastcall VLB_SharedVLBEntityManager__OnVLBPropertyChange(void *a0, void *a1, void *a2)
{
  __int64 v3; // x8
  void *v4; // x20
  void *v6; // x4
  __int64 v7; // x1
  void *v8; // x2
  bool v9; // w3

  if ( !a1 )
    goto LABEL_9;
  v3 = *((_QWORD *)a0 + 2);
  v4 = a0;
  if ( !v3 )
    goto LABEL_9;
  a0 = *(void **)(v3 + 64);
  if ( !a0 )
    goto LABEL_9;
  if ( VLB_EntityIndexer__IsValid(a0, *((_QWORD *)a1 + 40), a2) )
  {
    a0 = *((void **)v4 + 2);
    if ( a0 )
    {
      v7 = *((_QWORD *)a1 + 40);
      v8 = a1;
      v9 = 1;
LABEL_7:
      VLB_VLBEntityManager__UpdateEntityData(a0, v7, v8, v9, v6);
      return;
    }
LABEL_9:
    a0 = (void *)sub_63CF120(a0, a1);
    goto LABEL_7;
  }
}

