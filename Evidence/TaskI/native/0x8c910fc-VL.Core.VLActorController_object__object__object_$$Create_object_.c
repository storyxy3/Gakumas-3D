// 0x8c910fc @ 0x8c910fc
void *__fastcall VL_Core_VLActorController_object__object__object___Create_object_(int a0, void *a1)
{
  __int64 *v2; // x8
  __int64 v5; // x21
  void *result; // x0
  __int64 v7; // x1
  void *v8; // x21
  void *v9; // x0
  void *v10; // x22
  void *v11; // x21
  void *v12; // x0
  void *v13; // x1
  void *v14; // x2
  __int64 v15; // [xsp+8h] [xbp+8h] BYREF

  v2 = *((__int64 **)a1 + 7);
  if ( !v2 )
  {
    sub_63CEE78(&UnityEngine_GameObject_TypeInfo);
    sub_63CEE78(&StringLiteral__0___1___3);
    v2 = *((__int64 **)a1 + 7);
    if ( !v2 )
    {
      sub_6407F5C();
      v2 = *((__int64 **)a1 + 7);
    }
  }
  v5 = *v2;
  if ( !*(_DWORD *)(unk_F43F550 + 228LL) )
    sub_63CEFF4(unk_F43F550);
  result = System_Type__GetTypeFromHandle(v5, nullptr);
  if ( result
    && (v8 = (void *)(*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)result + 520LL))(
                       result,
                       *(_QWORD *)(*(_QWORD *)result + 528LL)),
        HIDWORD(v15) = a0,
        v9 = (void *)sub_63CEFFC(unk_F43F4B8, (char *)&v15 + 4),
        v10 = System_String__Format_1(StringLiteral__0___1___3, v8, v9, nullptr),
        v11 = (void *)sub_63CF110(UnityEngine_GameObject_TypeInfo),
        UnityEngine_GameObject___ctor(v11, v10, nullptr),
        v11)
    && (result = UnityEngine_GameObject__AddComponent_object_(v11, *(void **)(*((_QWORD *)a1 + 7) + 8LL))) != nullptr )
  {
    *((_DWORD *)result + 8) = a0;
  }
  else
  {
    v12 = (void *)sub_63CF120(result, v7);
    return (void *)VL_Core_VLActorController_object__object__object___VL_IVLActorController_TryGetComponent_object_(
                     v12,
                     v13,
                     v14);
  }
  return result;
}

