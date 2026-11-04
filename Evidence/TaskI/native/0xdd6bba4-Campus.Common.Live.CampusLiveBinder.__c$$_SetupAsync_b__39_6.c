// 0xdd6bba4 @ 0xdd6bba4
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___SetupAsync_b__39_6(void *a0, void *a1, void *a2)
{
  void *name; // x0
  __int64 v5; // x8
  void *v6; // x19

  if ( (unk_F43BA3B & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
    unk_F43BA3B = 1;
  }
  if ( !a1 )
  {
    sub_63CF120(a0, a1);
    JUMPOUT(0xDD6BC24);
  }
  name = UnityEngine_Object__get_name(a1, nullptr);
  v5 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
  v6 = name;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
    v5 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
  }
  return System_String__op_Equality(v6, **(void ***)(v5 + 184), nullptr);
}

