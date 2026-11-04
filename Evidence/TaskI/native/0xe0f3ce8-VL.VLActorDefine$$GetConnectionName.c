// VL.VLActorDefine$$GetConnectionName @ 0xe0f3ce8
void *__fastcall VL_VLActorDefine__GetConnectionName(void *a0, void *a1)
{
  void *v2; // x19
  int IndexOf; // w0
  void *v5; // x0
  void *v6; // x1

  if ( a0 && (a0 = UnityEngine_Object__get_name(a0, nullptr)) != nullptr )
  {
    v2 = a0;
    IndexOf = System_String__LastIndexOf(a0, 0x5Fu, nullptr);
    if ( IndexOf < 1 )
      return v2;
    else
      return System_String__Substring_1(v2, 0, IndexOf, nullptr);
  }
  else
  {
    v5 = (void *)sub_63CF120(a0, a1);
    return (void *)VL_VLActorDefine__IsBone(v5, v6);
  }
}

