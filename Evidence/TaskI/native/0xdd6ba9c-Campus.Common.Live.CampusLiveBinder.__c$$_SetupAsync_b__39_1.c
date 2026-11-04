// 0xdd6ba9c @ 0xdd6ba9c
void *__fastcall Campus_Common_Live_CampusLiveBinder___c___SetupAsync_b__39_1(void *a0, void *a1, void *a2)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x21
  __int64 v6; // x30
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x30
  __int64 v11; // x30
  void *v12; // x1
  void *v13; // x19
  __int64 v14; // [xsp+0h] [xbp+0h]
  __int64 v15; // [xsp+10h] [xbp+10h]
  __int64 v16; // [xsp+18h] [xbp+18h]

  if ( a1 )
    return UnityEngine_Timeline_TrackAsset__GetClips(a1, nullptr);
  *(&v14 - 2) = v6;
  v8 = sub_63CF120(a0, 0);
  if ( v9 )
    return *(void **)(v9 + 40);
  *(&v14 - 2) = v10;
  sub_63CF120(v8, 0);
  *(&v14 - 4) = v11;
  *(&v14 - 3) = v5;
  v15 = v4;
  v16 = v3;
  v13 = v12;
  if ( (unk_F43BA39 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA39 = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  return (void *)UnityEngine_Object__op_Inequality(v13, nullptr, nullptr);
}

