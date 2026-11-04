// 0xdd6bb24 @ 0xdd6bb24
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___SetupAsync_b__39_7(void *a0, void *a1, void *a2)
{
  void *name; // x0
  __int64 v5; // x8
  void *v6; // x19
  __int64 v7; // x0
  void *v8; // x1
  __int64 v9; // x30
  void *v10; // x19
  void *v11; // x0
  __int64 v12; // x8
  void *v13; // x19
  __int64 v15; // x30
  __int64 v16; // x1
  __int64 v17; // x19
  void *v18; // x19
  __int64 v19; // [xsp+0h] [xbp+0h]
  __int64 v20; // [xsp+10h] [xbp+10h]
  __int64 v21; // [xsp+18h] [xbp+18h]

  if ( (unk_F43BA3A & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
    unk_F43BA3A = 1;
  }
  if ( a1 )
  {
    name = UnityEngine_Object__get_name(a1, nullptr);
    v5 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
    v6 = name;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
      v5 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
    }
    return System_String__op_Equality(v6, *(void **)(*(_QWORD *)(v5 + 184) + 8LL), nullptr);
  }
  else
  {
    v7 = sub_63CF120(a0, a1);
    *(&v19 - 4) = v9;
    v20 = 256094208;
    v21 = 0;
    v10 = v8;
    if ( (unk_F43BA3B & 1) == 0 )
    {
      v7 = sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
      unk_F43BA3B = 1;
    }
    if ( v10 )
    {
      v11 = UnityEngine_Object__get_name(v10, nullptr);
      v12 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
      v13 = v11;
      if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo + 228LL) )
      {
        sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo);
        v12 = Campus_Common_Live_CampusLiveBinder_DirectorName_TypeInfo;
      }
      return System_String__op_Equality(v13, **(void ***)(v12 + 184), nullptr);
    }
    else
    {
      sub_63CF120(v7, v8);
      *(&v19 - 4) = v15;
      v20 = 256094208;
      v21 = 0;
      v17 = v16;
      if ( (unk_F43BA3C & 1) == 0 )
      {
        sub_63CEE78(&UnityEngine_Object_TypeInfo);
        unk_F43BA3C = 1;
      }
      if ( v17 )
      {
        v18 = *(void **)(v17 + 24);
        if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Object_TypeInfo);
        return UnityEngine_Object__op_Inequality(v18, nullptr, nullptr);
      }
      else
      {
        return 0;
      }
    }
  }
}

