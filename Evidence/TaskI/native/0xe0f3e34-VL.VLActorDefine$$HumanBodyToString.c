// VL.VLActorDefine$$HumanBodyToString @ 0xe0f3e34
void *__fastcall VL_VLActorDefine__HumanBodyToString(int a0, void *a1)
{
  __int64 v3; // x0
  int v4; // w9
  void *v5; // x0
  void *result; // x0
  void *v7; // x0
  void *v8; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43DB8D & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_HumanBodyBones__string__TryGetValue__);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    sub_63CEE78(&StringLiteral_);
    unk_F43DB8D = 1;
  }
  v3 = VL_VLActorDefine_TypeInfo;
  v4 = *(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL);
  v8 = (void *)StringLiteral_;
  if ( !v4 )
  {
    sub_63CEFF4(VL_VLActorDefine_TypeInfo);
    v3 = VL_VLActorDefine_TypeInfo;
  }
  v5 = *(void **)(*(_QWORD *)(v3 + 184) + 72LL);
  if ( v5 )
  {
    System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue(
      v5,
      a0,
      &v8,
      Method_System_Collections_Generic_Dictionary_HumanBodyBones__string__TryGetValue__);
    return v8;
  }
  else
  {
    v7 = (void *)sub_63CF120(0, a1);
    VL_VLActorDefine__ClearRequiredDescriptionFlags(v7);
  }
  return result;
}

