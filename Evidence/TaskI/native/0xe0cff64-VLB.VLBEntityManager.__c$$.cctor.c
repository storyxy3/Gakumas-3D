// VLB.VLBEntityManager.<>c$$.cctor @ 0xe0cff64
void __fastcall VLB_VLBEntityManager___c___cctor(void *a0)
{
  void *v1; // x19
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5

  if ( (unk_F43D9F3 & 1) == 0 )
  {
    sub_63CEE78(&VLB_VLBEntityManager___c_TypeInfo);
    unk_F43D9F3 = 1;
  }
  v1 = (void *)sub_63CF110(VLB_VLBEntityManager___c_TypeInfo);
  System_Object___ctor(v1, nullptr);
  **(_QWORD **)(VLB_VLBEntityManager___c_TypeInfo + 184LL) = v1;
  sub_63CEE24(*(void **)(VLB_VLBEntityManager___c_TypeInfo + 184LL), (int)v1, v2, v3, v4, v5);
}

