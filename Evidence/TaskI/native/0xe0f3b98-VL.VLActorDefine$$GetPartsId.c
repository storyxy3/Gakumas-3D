// VL.VLActorDefine$$GetPartsId @ 0xe0f3b98
// local variable allocation has failed, the output may be wrong!
void *__fastcall VL_VLActorDefine__GetPartsId(void *a0, bool a1, void *a2)
{
  void *v4; // x19
  int IndexOf; // w0
  int v6; // w1
  int v8; // w20
  unsigned __int16 Chars; // w21
  void *v10; // x21
  void *v11; // x0
  void *v12; // x0
  void *v13; // x1
  __int64 v14; // [xsp+8h] [xbp+8h] BYREF

  WORD2(v14) = 0;
  if ( a0 )
  {
    v4 = a0;
    IndexOf = System_String__LastIndexOf(a0, 0x5Fu, nullptr);
    v6 = IndexOf + 1;
    if ( IndexOf + 1 >= 2 )
    {
      if ( a1 )
        return System_String__Substring(v4, v6, nullptr);
      v8 = IndexOf;
      Chars = System_String__get_Chars(v4, v6, nullptr);
      if ( !*(_DWORD *)(unk_F43F4F8 + 228LL) )
        sub_63CEFF4(unk_F43F4F8);
      WORD2(v14) = System_Char__ToUpper_1(Chars, nullptr);
      v10 = System_Char__ToString((unsigned __int16)&v14 + 4, nullptr);
      v11 = System_String__Substring(v4, v8 + 2, nullptr);
      return System_String__Concat_2(v10, v11, nullptr);
    }
    return v4;
  }
  else
  {
    v12 = (void *)sub_63CF120(0, a1);
    return VL_VLActorDefine__GetRootName(v12, v13);
  }
}

