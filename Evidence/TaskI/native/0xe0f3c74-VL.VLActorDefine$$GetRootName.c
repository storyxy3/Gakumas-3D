// VL.VLActorDefine$$GetRootName @ 0xe0f3c74
void *__fastcall VL_VLActorDefine__GetRootName(void *a0, void *a1)
{
  void *v2; // x2
  __int64 v4; // x0
  void *v5; // x20
  void *PartsId; // x1

  if ( (unk_F43DB89 & 1) == 0 )
  {
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    unk_F43DB89 = 1;
  }
  v4 = VL_VLActorDefine_TypeInfo;
  if ( !*(_DWORD *)(VL_VLActorDefine_TypeInfo + 228LL) )
  {
    sub_63CEFF4(VL_VLActorDefine_TypeInfo);
    v4 = VL_VLActorDefine_TypeInfo;
  }
  v5 = *(void **)(*(_QWORD *)(v4 + 184) + 16LL);
  PartsId = VL_VLActorDefine__GetPartsId(a0, 0, v2);
  return System_String__Concat_2(v5, PartsId, nullptr);
}

