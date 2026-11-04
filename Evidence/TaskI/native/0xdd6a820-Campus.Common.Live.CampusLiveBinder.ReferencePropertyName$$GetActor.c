// 0xdd6a820 @ 0xdd6a820
void *__fastcall Campus_Common_Live_CampusLiveBinder_ReferencePropertyName__GetActor(int a0, void *a1)
{
  __int64 v3; // x0
  __int64 v4; // x8
  void *v5; // x20
  void *v6; // x0
  void *v7; // x0
  __int64 v8; // x20
  void *v9; // x19
  __int64 v10; // x8
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v14; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43BA35 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Array_Empty_object___);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo);
    sub_63CEE78(&StringLiteral__0__1_00_);
    unk_F43BA35 = 1;
  }
  v3 = Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo);
    v3 = Campus_Common_Live_CampusLiveBinder_ReferencePropertyName_TypeInfo;
  }
  v4 = *(_QWORD *)(v3 + 184);
  HIDWORD(v14) = a0;
  v5 = *(void **)(v4 + 8);
  v6 = (void *)sub_63CEFFC(unk_F43F4B8, (char *)&v14 + 4);
  v7 = System_String__Format_1(StringLiteral__0__1_00_, v5, v6, nullptr);
  v8 = Method_System_Array_Empty_object___;
  v9 = v7;
  v10 = *(_QWORD *)(Method_System_Array_Empty_object___ + 56LL);
  if ( !v10 )
  {
    sub_6407F5C();
    v10 = *(_QWORD *)(v8 + 56);
  }
  v11 = *(_QWORD *)(v10 + 16);
  if ( (*(_WORD *)(v11 + 309) & 1) == 0 )
    sub_6407F00(v11);
  if ( !*(_DWORD *)(v11 + 228) )
    sub_63CEFF4(v11);
  v12 = *(_QWORD *)(*(_QWORD *)(v8 + 56) + 16LL);
  if ( (*(_WORD *)(v12 + 309) & 1) == 0 )
    sub_6407F00(v12);
  return System_String__Format_3(v9, **(void ***)(v12 + 184), nullptr);
}

