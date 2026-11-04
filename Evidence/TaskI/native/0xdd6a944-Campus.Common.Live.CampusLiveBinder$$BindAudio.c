// 0xdd6a944 @ 0xdd6a944
void *__fastcall Campus_Common_Live_CampusLiveBinder__BindAudio(void *a0, __int64 a1, void *a2)
{
  _QWORD *v3; // x24
  _QWORD *v6; // x22
  void *streamName; // x0
  __int64 v8; // x8
  void *v9; // x21
  void *result; // x0
  __int64 v11; // x1
  __int64 v12; // x8
  bool v13; // w8
  __int64 v14; // x8
  void **v15; // x8
  void *v16; // x0
  __int64 v17; // x8
  bool v18; // w8
  __int64 v19; // x8
  bool v20; // w8
  __int64 v21; // x8
  __int64 v22; // x0
  __int64 v23; // x30
  void *v24; // x21
  void *v25; // x1
  void *v26; // x19
  __int64 v27; // x20
  __int64 v28; // x1
  __int64 v29; // x8
  __int64 v30; // x0
  __int64 v31; // x8
  void *player; // x0
  __int64 v33; // x8
  __int64 v34; // x10
  __int64 v35; // x8
  bool v36; // w8
  __int64 v37; // x8
  void *v38; // x0
  bool v39; // w8
  __int64 v40; // x8
  void *Item; // x0
  __int64 v42; // x10
  bool v43; // w8
  void *v44; // x19
  void *name; // x0
  void *v46; // x19
  __int64 v47; // x0
  __int64 v48; // x30
  __int64 v49; // x1
  __int64 v50; // x20
  _QWORD *v51; // x19
  void *outputTargetType; // x0
  __int64 v53; // x22
  void *v54; // x21
  void *TypeFromHandle; // x0
  void *sourceObject; // x0
  int v57; // w2
  int v58; // w3
  int v59; // w4
  void *v60; // x5
  void *v61; // x1
  __int64 v62; // x10
  int *Instance; // x0
  __int64 v64; // x8
  __int64 v65; // x9
  __int64 v66; // x10
  __int64 v67; // x8
  __int64 v68; // x1
  __int64 v69; // x30
  _QWORD *v70; // x19
  __int64 v71; // x8
  void *v72; // x20
  bool v73; // w8
  __int64 v74; // x8
  void *v75; // x0
  void *v76; // x1
  void *v77; // x2
  void *v78; // x3
  __int64 v79; // [xsp+0h] [xbp+0h]
  __int64 v80; // [xsp+8h] [xbp+8h] BYREF
  _QWORD *v81; // [xsp+10h] [xbp+10h]
  _QWORD *v82; // [xsp+18h] [xbp+18h]
  _QWORD *v83; // [xsp+20h] [xbp+20h]
  void *v84; // [xsp+28h] [xbp+28h]
  __int64 v85; // [xsp+30h] [xbp+30h]
  void *v86; // [xsp+38h] [xbp+38h]

  if ( (unk_F43BA2D & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    unk_F43BA2D = 1;
  }
  v6 = &Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  streamName = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
  v8 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  v9 = streamName;
  if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    v8 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  }
  result = (void *)System_String__op_Equality(v9, *(void **)(*(_QWORD *)(v8 + 184) + 8LL), nullptr);
  if ( ((unsigned __int8)result & 1) != 0 )
  {
    v12 = *((_QWORD *)a0 + 10);
    if ( v12 )
    {
      a1 = *(_QWORD *)(v12 + 80);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      v13 = UnityEngine_Object__op_Inequality((void *)a1, nullptr, nullptr);
      result = nullptr;
      if ( !v13 )
        return result;
      v14 = *((_QWORD *)a0 + 10);
      if ( v14 )
      {
        v15 = (void **)(v14 + 80);
        return *v15;
      }
    }
  }
  else
  {
    if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
    v16 = UnityEngine_Playables_PlayableBinding__get_streamName(a1, nullptr);
    v17 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
    a1 = (__int64)v16;
    if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
      v17 = Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
    }
    v18 = System_String__op_Equality((void *)a1, *(void **)(*(_QWORD *)(v17 + 184) + 16LL), nullptr);
    result = nullptr;
    if ( !v18 )
      return result;
    v19 = *((_QWORD *)a0 + 10);
    if ( v19 )
    {
      a1 = *(_QWORD *)(v19 + 88);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      v20 = UnityEngine_Object__op_Inequality((void *)a1, nullptr, nullptr);
      result = nullptr;
      if ( !v20 )
        return result;
      v21 = *((_QWORD *)a0 + 10);
      if ( v21 )
      {
        v15 = (void **)(v21 + 88);
        return *v15;
      }
    }
  }
  v22 = sub_63CF120(result, v11);
  *(&v79 - 8) = v23;
  v81 = v3;
  v82 = &UnityEngine_Playables_PlayableBinding_TypeInfo;
  v83 = &Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
  v84 = v9;
  v85 = a1;
  v86 = a0;
  v24 = &unk_F43B000;
  v26 = v25;
  v27 = v22;
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
  HIDWORD(v80) = 0;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  result = UnityEngine_Playables_PlayableBinding__get_streamName((__int64)v26, nullptr);
  v29 = *(_QWORD *)(v27 + 80);
  if ( v29 )
  {
    v24 = result;
    v6 = *(_QWORD **)(v29 + 40);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    result = (void *)UnityEngine_Object__op_Inequality(v6, nullptr, nullptr);
    if ( ((unsigned __int8)result & 1) == 0 )
      goto LABEL_51;
    v6 = &Campus_Common_CampusActorLayout_TypeInfo;
    v30 = Campus_Common_CampusActorLayout_TypeInfo;
    if ( !*(_DWORD *)(Campus_Common_CampusActorLayout_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Common_CampusActorLayout_TypeInfo);
      v30 = Campus_Common_CampusActorLayout_TypeInfo;
    }
    result = (void *)System_String__op_Equality(v24, **(void ***)(v30 + 184), nullptr);
    if ( ((unsigned __int8)result & 1) != 0 )
    {
      if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
      result = UnityEngine_Playables_PlayableBinding__get_streamName((__int64)v26, nullptr);
      v31 = *(_QWORD *)(v27 + 80);
      if ( v31 )
      {
        v26 = result;
        result = *(void **)(v31 + 40);
        if ( result )
        {
          player = Campus_Common_CampusActorLayout__get_player(result, nullptr);
          v26 = System_String__Format_1(StringLiteral_Bind__0______1_, v26, player, nullptr);
          if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Debug_TypeInfo);
          UnityEngine_Debug__Log(v26, nullptr);
          v33 = *(_QWORD *)(v27 + 80);
          if ( v33 )
          {
            result = *(void **)(v33 + 40);
            if ( result )
            {
              result = Campus_Common_CampusActorLayout__get_player(result, nullptr);
              if ( !result )
                return result;
              v34 = *(unsigned __int8 *)(VL_Animation_MotionDefinePlayer_TypeInfo + 304LL);
              if ( *(unsigned __int8 *)(*(_QWORD *)result + 304LL) >= (unsigned int)v34 )
              {
                if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)result + 200LL) + 8 * v34 - 8) != VL_Animation_MotionDefinePlayer_TypeInfo )
                  return nullptr;
                return result;
              }
              return nullptr;
            }
          }
        }
      }
    }
    else
    {
LABEL_51:
      v35 = *(_QWORD *)(v27 + 80);
      if ( v35 )
      {
        if ( !*(_QWORD *)(v35 + 56) )
          return nullptr;
        v6 = &Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
        if ( *(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
        {
          if ( !v24 )
            return nullptr;
        }
        else
        {
          sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
          if ( !v24 )
            return nullptr;
        }
        v36 = System_String__StartsWith_1(
                v24,
                *(void **)(*(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL) + 64LL),
                4,
                nullptr);
        result = nullptr;
        if ( !v36 )
          return result;
        result = (void *)Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
        if ( !*(_DWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 228LL) )
        {
          sub_63CEFF4(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
          result = (void *)Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo;
        }
        v37 = *(_QWORD *)(*((_QWORD *)result + 23) + 64LL);
        if ( v37 )
        {
          v38 = System_String__Substring(v24, *(_DWORD *)(v37 + 16), nullptr);
          v39 = System_Int32__TryParse(v38, (char *)&v80 + 4, nullptr);
          result = nullptr;
          if ( !v39 )
            return result;
          v40 = *(_QWORD *)(v27 + 80);
          if ( v40 )
          {
            result = *(void **)(v40 + 56);
            if ( result )
            {
              if ( SHIDWORD(v80) >= *((_DWORD *)result + 6) )
                return nullptr;
              Item = System_Collections_Generic_List_object___get_Item(
                       result,
                       SHIDWORD(v80),
                       Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
              if ( Item
                && (v42 = *(unsigned __int8 *)(Campus_Common_CampusActorController_TypeInfo + 304LL),
                    *(unsigned __int8 *)(*(_QWORD *)Item + 304LL) >= (unsigned int)v42) )
              {
                if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)Item + 200LL) + 8 * v42 - 8) == Campus_Common_CampusActorController_TypeInfo )
                  v27 = (__int64)Item;
                else
                  v27 = 0;
              }
              else
              {
                v27 = 0;
              }
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              v43 = UnityEngine_Object__op_Inequality((void *)v27, nullptr, nullptr);
              result = nullptr;
              if ( !v43 )
                return result;
              if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
              result = UnityEngine_Playables_PlayableBinding__get_streamName((__int64)v26, nullptr);
              if ( v27 )
              {
                v44 = result;
                name = UnityEngine_Object__get_name((void *)v27, nullptr);
                v46 = System_String__Concat_4(StringLiteral_Bind_, v44, StringLiteral______5, name, nullptr);
                if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
                  sub_63CEFF4(UnityEngine_Debug_TypeInfo);
                UnityEngine_Debug__Log(v46, nullptr);
                return *(void **)(v27 + 456);
              }
            }
          }
        }
      }
    }
  }
  v47 = sub_63CF120(result, v28);
  *(&v79 - 6) = v48;
  *(&v79 - 5) = (__int64)&UnityEngine_Playables_PlayableBinding_TypeInfo;
  v81 = v6;
  v82 = v24;
  v83 = (_QWORD *)v27;
  v84 = v26;
  v50 = v49;
  v51 = (_QWORD *)v47;
  if ( (unk_F43BA2F & 1) == 0 )
  {
    sub_63CEE78(&Cinemachine_CinemachineBrain_var);
    sub_63CEE78(&Cinemachine_CinemachineCore_TypeInfo);
    sub_63CEE78(&CinemachineTrack_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_CinemachineTrack__Add__);
    sub_63CEE78(&UnityEngine_Playables_PlayableBinding_TypeInfo);
    unk_F43BA2F = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  outputTargetType = UnityEngine_Playables_PlayableBinding__get_outputTargetType(v50, nullptr);
  v53 = Cinemachine_CinemachineBrain_var;
  v54 = outputTargetType;
  if ( !*(_DWORD *)(unk_F43F550 + 228LL) )
    sub_63CEFF4(unk_F43F550);
  TypeFromHandle = System_Type__GetTypeFromHandle(v53, nullptr);
  if ( !System_Type__op_Equality(v54, TypeFromHandle, nullptr) )
    return nullptr;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  sourceObject = UnityEngine_Playables_PlayableBinding__get_sourceObject(v50, nullptr);
  if ( !sourceObject )
    goto LABEL_100;
  v61 = sourceObject;
  v62 = *(unsigned __int8 *)(CinemachineTrack_TypeInfo + 304LL);
  if ( *(unsigned __int8 *)(*(_QWORD *)sourceObject + 304LL) < (unsigned int)v62
    || *(_QWORD *)(*(_QWORD *)(*(_QWORD *)sourceObject + 200LL) + 8 * v62 - 8) != CinemachineTrack_TypeInfo )
  {
    goto LABEL_100;
  }
  Instance = (int *)v51[2];
  if ( Instance )
  {
    v64 = *((_QWORD *)Instance + 2);
    v65 = Method_System_Collections_Generic_List_CinemachineTrack__Add__;
    ++Instance[7];
    if ( v64 )
    {
      v66 = Instance[6];
      if ( (unsigned int)v66 >= *(_DWORD *)(v64 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          Instance,
          v61,
          *(void **)(*(_QWORD *)(*(_QWORD *)(v65 + 32) + 192LL) + 112LL));
      }
      else
      {
        v67 = v64 + 8 * v66;
        Instance[6] = v66 + 1;
        *(_QWORD *)(v67 + 32) = v61;
        sub_63CEE24((void *)(v67 + 32), (int)v61, v57, v58, v59, v60);
      }
LABEL_100:
      if ( !*(_DWORD *)(Cinemachine_CinemachineCore_TypeInfo + 228LL) )
        sub_63CEFF4(Cinemachine_CinemachineCore_TypeInfo);
      Instance = (int *)Cinemachine_CinemachineCore__get_Instance(nullptr);
      if ( Instance )
        return Cinemachine_CinemachineCore__GetActiveBrain(Instance, 0, nullptr);
    }
  }
  result = (void *)sub_63CF120(Instance, v61);
  *(&v79 - 4) = v69;
  v81 = (_QWORD *)v50;
  v82 = v51;
  v70 = result;
  if ( (unk_F43BA30 & 1) == 0 )
  {
    result = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA30 = 1;
  }
  v71 = v70[10];
  if ( !v71 )
    goto LABEL_113;
  v72 = *(void **)(v71 + 128);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v73 = UnityEngine_Object__op_Inequality(v72, nullptr, nullptr);
  result = nullptr;
  if ( v73 )
  {
    v74 = v70[10];
    if ( v74 )
      return *(void **)(v74 + 128);
LABEL_113:
    v75 = (void *)sub_63CF120(result, v68);
    Campus_Common_Live_CampusLiveBinder__ReplaceBGM(v75, v76, v77, v78);
  }
  return result;
}

