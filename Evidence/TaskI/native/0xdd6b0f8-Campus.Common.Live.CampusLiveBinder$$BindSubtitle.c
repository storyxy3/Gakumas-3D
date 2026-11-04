// 0xdd6b0f8 @ 0xdd6b0f8
void *__fastcall Campus_Common_Live_CampusLiveBinder__BindSubtitle(void *a0, __int64 a1, void *a2)
{
  _QWORD *v3; // x19
  __int64 v4; // x8
  void *v5; // x20
  bool v6; // w8
  __int64 v7; // x8
  void *v8; // x0
  void *v9; // x1
  void *v10; // x2
  void *v11; // x3

  v3 = a0;
  if ( (unk_F43BA30 & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA30 = 1;
  }
  v4 = v3[10];
  if ( !v4 )
    goto LABEL_10;
  v5 = *(void **)(v4 + 128);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v6 = UnityEngine_Object__op_Inequality(v5, nullptr, nullptr);
  a0 = nullptr;
  if ( v6 )
  {
    v7 = v3[10];
    if ( v7 )
      return *(void **)(v7 + 128);
LABEL_10:
    v8 = (void *)sub_63CF120(a0, a1);
    Campus_Common_Live_CampusLiveBinder__ReplaceBGM(v8, v9, v10, v11);
  }
  return a0;
}

