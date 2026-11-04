// 0xdd6aafc @ 0xdd6aafc
void *__fastcall Campus_Common_Live_CampusLiveBinder__BindActor(void *a0, __int64 a1, void *a2)
{
  void *result; // x0
  __int64 v6; // x1
  __int64 v7; // x8
  void *v8; // x21
  void *v9; // x22
  __int64 v10; // x0
  __int64 v11; // x8
  void *v12; // x19
  void *player; // x0
  void *v14; // x19
  __int64 v15; // x8
  __int64 v16; // x10
  __int64 v17; // x8
  bool v18; // w8
  __int64 v19; // x8
  void *v20; // x0
  bool v21; // w8
  __int64 v22; // x8
  void **Item; // x0
  __int64 v24; // x10
  void **v25; // x20
  bool v26; // w8
  void *v27; // x19
  void *name; // x0
  void *v29; // x19
  __int64 v30; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43BA2E & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_CampusActorController_TypeInfo);
    sub_63CEE78(&Campus_Common_CampusActorLayout_TypeInfo);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
    sub_63CEE78(&VL_Animation_MotionDefinePlayer_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    sub_63CEE78(&StringLiteral______5);
    sub_63CEE78(&StringLiteral_Bind_);
    sub_63CEE78(&StringLiteral_Bind__0______1_);
    unk_F43BA2E = 1;
  }
  HIDWORD(v30) = 0;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  result = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
  v7 = *((_QWORD *)a0 + 10);
  if ( !v7 )
    goto LABEL_56;
  v8 = result;
  v9 = *(void **)(v7 + 40);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  result = (void *)UnityEngine_Object__op_Inequality(v9, nullptr, nullptr);
  if ( ((unsigned __int8)result & 1) != 0 )
  {
    v10 = Campus_Common_CampusActorLayout_TypeInfo;
    if ( !*(_DWORD *)(Campus_Common_CampusActorLayout_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_CampusActorLayout_TypeInfo);
      v10 = Campus_Common_CampusActorLayout_TypeInfo;
    }
    result = (void *)System_String__op_Equality(v8, **(void ***)(v10 + 184), nullptr);
    if ( ((unsigned __int8)result & 1) != 0 )
    {
      if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
      result = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
      v11 = *((_QWORD *)a0 + 10);
      if ( v11 )
      {
        v12 = result;
        result = *(void **)(v11 + 40);
        if ( result )
        {
          player = Campus_Common_CampusActorLayout__get_player(result, nullptr);
          v14 = System_String__Format_1(StringLiteral_Bind__0______1_, v12, player, nullptr);
          if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Debug_TypeInfo);
          UnityEngine_Debug__Log(v14, nullptr);
          v15 = *((_QWORD *)a0 + 10);
          if ( v15 )
          {
            result = *(void **)(v15 + 40);
            if ( result )
            {
              result = Campus_Common_CampusActorLayout__get_player(result, nullptr);
              if ( !result )
                return result;
              v16 = *(unsigned __int8 *)(VL_Animation_MotionDefinePlayer_TypeInfo + 304LL);
              if ( *(unsigned __int8 *)(*(_QWORD *)result + 304LL) >= (unsigned int)v16 )
              {
                if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)result + 200LL) + 8 * v16 - 8) != VL_Animation_MotionDefinePlayer_TypeInfo )
                  return nullptr;
                return result;
              }
              return nullptr;
            }
          }
        }
      }
      goto LABEL_56;
    }
  }
  v17 = *((_QWORD *)a0 + 10);
  if ( !v17 )
    goto LABEL_56;
  if ( !*(_QWORD *)(v17 + 56) )
    return nullptr;
  if ( *(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
  {
    if ( !v8 )
      return nullptr;
  }
  else
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    if ( !v8 )
      return nullptr;
  }
  v18 = System_String__StartsWith_1(
          v8,
          *(void **)(*(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL) + 64LL),
          4,
          nullptr);
  result = nullptr;
  if ( !v18 )
    return result;
  result = (void *)Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    result = (void *)Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  }
  v19 = *(_QWORD *)(*((_QWORD *)result + 23) + 64LL);
  if ( !v19 )
    goto LABEL_56;
  v20 = System_String__Substring(v8, *(_DWORD *)(v19 + 16), nullptr);
  v21 = System_Int32__TryParse(v20, (char *)&v30 + 4, nullptr);
  result = nullptr;
  if ( !v21 )
    return result;
  v22 = *((_QWORD *)a0 + 10);
  if ( !v22 || (result = *(void **)(v22 + 56)) == nullptr )
  {
LABEL_56:
    sub_63CF120(result, v6);
    JUMPOUT(0xDD6AF14);
  }
  if ( SHIDWORD(v30) >= *((_DWORD *)result + 6) )
    return nullptr;
  Item = (void **)System_Collections_Generic_List_object___get_Item(
                    result,
                    SHIDWORD(v30),
                    Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
  if ( Item
    && (v24 = *(unsigned __int8 *)(Campus_Common_CampusActorController_TypeInfo + 304LL),
        *((unsigned __int8 *)*Item + 304) >= (unsigned int)v24) )
  {
    if ( *(_QWORD *)(*((_QWORD *)*Item + 25) + 8 * v24 - 8) == Campus_Common_CampusActorController_TypeInfo )
      v25 = Item;
    else
      v25 = nullptr;
  }
  else
  {
    v25 = nullptr;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v26 = UnityEngine_Object__op_Inequality(v25, nullptr, nullptr);
  result = nullptr;
  if ( v26 )
  {
    if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
    result = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
    if ( !v25 )
      goto LABEL_56;
    v27 = result;
    name = UnityEngine_Object__get_name(v25, nullptr);
    v29 = System_String__Concat_4(StringLiteral_Bind_, v27, StringLiteral______5, name, nullptr);
    if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Debug_TypeInfo);
    UnityEngine_Debug__Log(v29, nullptr);
    return v25[57];
  }
  return result;
}

