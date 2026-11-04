// 0xdd6af14 @ 0xdd6af14
void *__fastcall Campus_Common_Live_CampusLiveBinder__BindCamera(void *a0, __int64 a1, void *a2)
{
  void *outputTargetType; // x0
  __int64 v6; // x22
  void *v7; // x21
  void *TypeFromHandle; // x0
  void *sourceObject; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void *v14; // x1
  __int64 v15; // x10
  int *Instance; // x0
  __int64 v17; // x8
  __int64 v18; // x9
  __int64 v19; // x10
  __int64 v20; // x8

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
  outputTargetType = UnityEngine_Playables_PlayableBinding__get_outputTargetType(a1, nullptr);
  v6 = Cinemachine_CinemachineBrain_var;
  v7 = outputTargetType;
  if ( !*(_DWORD *)(unk_F43F550 + 228LL) )
    sub_63CEFF4(unk_F43F550);
  TypeFromHandle = System_Type__GetTypeFromHandle(v6, nullptr);
  if ( !System_Type__op_Equality(v7, TypeFromHandle, nullptr) )
    return nullptr;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableBinding_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableBinding_TypeInfo);
  sourceObject = UnityEngine_Playables_PlayableBinding__get_sourceObject(a1, nullptr);
  if ( sourceObject )
  {
    v14 = sourceObject;
    v15 = *(unsigned __int8 *)(CinemachineTrack_TypeInfo + 304LL);
    if ( *(unsigned __int8 *)(*(_QWORD *)sourceObject + 304LL) >= (unsigned int)v15
      && *(_QWORD *)(*(_QWORD *)(*(_QWORD *)sourceObject + 200LL) + 8 * v15 - 8) == CinemachineTrack_TypeInfo )
    {
      Instance = *((int **)a0 + 2);
      if ( !Instance )
        goto LABEL_23;
      v17 = *((_QWORD *)Instance + 2);
      v18 = Method_System_Collections_Generic_List_CinemachineTrack__Add__;
      ++Instance[7];
      if ( !v17 )
        goto LABEL_23;
      v19 = Instance[6];
      if ( (unsigned int)v19 >= *(_DWORD *)(v17 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          Instance,
          v14,
          *(void **)(*(_QWORD *)(*(_QWORD *)(v18 + 32) + 192LL) + 112LL));
      }
      else
      {
        v20 = v17 + 8 * v19;
        Instance[6] = v19 + 1;
        *(_QWORD *)(v20 + 32) = v14;
        sub_63CEE24((void *)(v20 + 32), (int)v14, v10, v11, v12, v13);
      }
    }
  }
  if ( !*(_DWORD *)(Cinemachine_CinemachineCore_TypeInfo + 228LL) )
    sub_63CEFF4(Cinemachine_CinemachineCore_TypeInfo);
  Instance = (int *)Cinemachine_CinemachineCore__get_Instance(nullptr);
  if ( !Instance )
  {
LABEL_23:
    sub_63CF120(Instance, v14);
    JUMPOUT(0xDD6B0F8);
  }
  return Cinemachine_CinemachineCore__GetActiveBrain(Instance, 0, nullptr);
}

