// 0xdd6bc24 @ 0xdd6bc24
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___HasLiveOverrideActorMotion_b__46_1(
        void *a0,
        void *a1,
        void *a2)
{
  void *v4; // x19

  if ( (unk_F43BA3C & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA3C = 1;
  }
  if ( !a1 )
    return 0;
  v4 = *((void **)a1 + 3);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  return UnityEngine_Object__op_Inequality(v4, nullptr, nullptr);
}

