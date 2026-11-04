// 0xdd6bac8 @ 0xdd6bac8
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___SetupAsync_b__39_4(void *a0, void *a1, void *a2)
{
  if ( (unk_F43BA39 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA39 = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  return UnityEngine_Object__op_Inequality(a1, nullptr, nullptr);
}

