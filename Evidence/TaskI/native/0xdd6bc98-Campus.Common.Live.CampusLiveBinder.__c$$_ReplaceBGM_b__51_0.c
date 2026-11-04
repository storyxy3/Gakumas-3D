// 0xdd6bc98 @ 0xdd6bc98
bool __fastcall Campus_Common_Live_CampusLiveBinder___c___ReplaceBGM_b__51_0(void *a0, void *a1, void *a2)
{
  __int64 v3; // x21
  void *name; // x0
  __int64 v6; // x8
  void *v7; // x19
  __int64 v9; // x30
  __int64 v10; // x1
  __int64 v11; // x19
  void *streamName; // x0
  __int64 v13; // x1
  __int64 v14; // x30
  __int64 v15; // x1
  __int64 v16; // x19
  __int64 v17; // [xsp+0h] [xbp+0h]
  __int64 v18; // [xsp+10h] [xbp+10h]
  __int64 v19; // [xsp+18h] [xbp+18h]

  if ( (unk_F43BA3D & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    unk_F43BA3D = 1;
  }
  if ( a1 )
  {
    name = UnityEngine_Object__get_name(a1, nullptr);
    v6 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
    v7 = name;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
      v6 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
    }
    return System_String__op_Equality(v7, *(void **)(*(_QWORD *)(v6 + 184) + 8LL), nullptr);
  }
  else
  {
    sub_63CF120(a0, a1);
    *(&v17 - 4) = v9;
    *(&v17 - 3) = v3;
    v18 = 256094208;
    v19 = 0;
    v11 = v10;
    if ( (unk_F43BA3E & 1) == 0 )
    {
      sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
      sub_63CEE78(&StringLiteral_Equip);
      unk_F43BA3E = 1;
    }
    if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
    streamName = UnityEngine_Playables_PlayableBinding__get_streamName(v11, nullptr);
    if ( streamName )
    {
      return System_String__StartsWith(streamName, StringLiteral_Equip, nullptr);
    }
    else
    {
      sub_63CF120(0, v13);
      *(&v17 - 4) = v14;
      *(&v17 - 3) = (__int64)&UnityEngine_Playables_PlayableBinding_TypeInfo;
      v18 = 256094208;
      v19 = v11;
      v16 = v15;
      if ( (unk_F43BA3F & 1) == 0 )
      {
        sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
        unk_F43BA3F = 1;
      }
      if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
      return (unsigned __int8)UnityEngine_Playables_PlayableBinding__get_sourceObject(v16, nullptr);
    }
  }
}

