// VLB.VLBEntityManager$$IsValid @ 0xe0cd3fc
bool __fastcall VLB_VLBEntityManager__IsValid(void *a0, __int64 a1, void *a2)
{
  __int64 v3; // x30
  void *v4; // x0
  void *v6; // x0
  void *v7; // x1
  void *v8; // x2
  __int64 v9; // [xsp+0h] [xbp+0h]

  v4 = *((void **)a0 + 8);
  if ( v4 )
    return VLB_EntityIndexer__IsValid(v4, a1, a2);
  *(&v9 - 2) = v3;
  v6 = (void *)sub_63CF120(0, a1);
  return VLB_VLBEntityManager__CreateEntity(v6, v7, v8);
}

