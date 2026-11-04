// 0xdd6b93c @ 0xdd6b93c
void __fastcall Campus_Common_Live_CampusLiveBinder_ReferencePropertyName___cctor(void *a0)
{
  int v1; // w2
  int v2; // w3
  int v3; // w4
  void *v4; // x5
  int v5; // w1
  int v6; // w1
  __int64 v7; // x0
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5

  if ( (unk_F43BA36 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo);
    sub_63CEE78(&StringLiteral_ActorLayout);
    sub_63CEE78(&StringLiteral_Actor_);
    unk_F43BA36 = 1;
  }
  v5 = StringLiteral_ActorLayout;
  **(_QWORD **)(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo + 184LL) = StringLiteral_ActorLayout;
  sub_63CEE24(
    *(void **)(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo + 184LL),
    v5,
    v1,
    v2,
    v3,
    v4);
  v6 = StringLiteral_Actor_;
  v7 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo + 184LL);
  *(_QWORD *)(v7 + 8) = StringLiteral_Actor_;
  sub_63CEE24((void *)(v7 + 8), v6, v8, v9, v10, v11);
}

