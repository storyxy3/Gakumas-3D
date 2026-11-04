// VLB.SharedVLBEntityManager$$OnVLBMaterialChange @ 0xe0ce73c
void __fastcall VLB_SharedVLBEntityManager__OnVLBMaterialChange(void *a0, void *a1, void *a2)
{
  void *v5; // x2

  VLB_SharedVLBEntityManager__OnVLBRemove(a0, a1, a2);
  VLB_SharedVLBEntityManager__OnVLBAdd(a0, a1, v5);
}

