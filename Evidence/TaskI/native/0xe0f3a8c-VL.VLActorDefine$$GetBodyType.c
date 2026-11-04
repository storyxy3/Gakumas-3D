// VL.VLActorDefine$$GetBodyType @ 0xe0f3a8c
int __fastcall VL_VLActorDefine__GetBodyType(int a0, void *a1)
{
  __int64 v3; // x0
  void *v4; // x0
  int result; // w0
  void *v6; // x0
  void *v7; // x1
  __int64 v8; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43DB8B & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_HumanBodyBones__VLActorBodyType__TryGetValue__);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    unk_F43DB8B = 1;
  }
  v3 = VL_VLActorDefine_TypeInfo;
  HIDWORD(v8) = 0;
  if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VL_VLActorDefine_TypeInfo);
    v3 = VL_VLActorDefine_TypeInfo;
  }
  v4 = *(void **)(*(_QWORD *)(v3 + 184) + 56LL);
  if ( v4 )
  {
    System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___TryGetValue(
      v4,
      a0,
      (char *)&v8 + 4,
      Method_System_Collections_Generic_Dictionary_HumanBodyBones__VLActorBodyType__TryGetValue__);
    return HIDWORD(v8);
  }
  else
  {
    v6 = (void *)sub_63CF120(0, a1);
    VL_VLActorCollider___ctor(v6, v7);
  }
  return result;
}

