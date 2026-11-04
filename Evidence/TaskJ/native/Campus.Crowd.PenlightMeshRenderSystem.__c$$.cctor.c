// Campus.Crowd.PenlightMeshRenderSystem.<>c$$.cctor @ 0xddcc2c8
void __fastcall Campus_Crowd_PenlightMeshRenderSystem___c___cctor(void *a0)
{
  void *v1; // x19
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5

  if ( (unk_F43BD38 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo);
    unk_F43BD38 = 1;
  }
  v1 = (void *)sub_63CF110(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo);
  System_Object___ctor(v1, nullptr);
  **(_QWORD **)(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo + 184LL) = v1;
  sub_63CEE24(*(void **)(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo + 184LL), (int)v1, v2, v3, v4, v5);
}

