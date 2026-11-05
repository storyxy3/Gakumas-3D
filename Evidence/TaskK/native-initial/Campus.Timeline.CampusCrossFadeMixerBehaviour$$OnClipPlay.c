// Campus.Timeline.CampusCrossFadeMixerBehaviour$$OnClipPlay @ 0xdd4a2f8
void __fastcall Campus_Timeline_CampusCrossFadeMixerBehaviour__OnClipPlay(void *a0, __int64 a1, double a2, void *a3)
{
  int v6; // w8
  __int64 v7; // x1
  int HashCode; // w20
  void *v9; // x1
  void *CapturedTexture; // x21
  _QWORD *Instance; // x0
  __int64 v12; // x1
  void *v13; // x22
  void *v14; // x23
  void *v15; // x22
  __int64 Handle; // [xsp+0h] [xbp+0h] BYREF
  __int64 v17; // [xsp+8h] [xbp+8h]
  __int64 v18; // [xsp+10h] [xbp+10h] BYREF
  void *v19; // [xsp+18h] [xbp+18h]

  v18 = a1;
  v19 = a3;
  if ( (unk_F43B8F4 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Graphics_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&UnityEngine_Playables_PlayableHandle_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__GetHandle__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__);
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    unk_F43B8F4 = 1;
  }
  v6 = *(_DWORD *)(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo + 228LL);
  Handle = 0;
  v17 = 0;
  if ( !v6 )
    sub_63CEFF4(UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__TypeInfo);
  Handle = UnityEngine_Playables_ScriptPlayable_object___GetHandle(
             (__int64)&v18,
             Method_UnityEngine_Playables_ScriptPlayable_CampusCrossFadeBehaviour__GetHandle__);
  v17 = v7;
  if ( !*(_DWORD *)(UnityEngine_Playables_PlayableHandle_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_PlayableHandle_TypeInfo);
  HashCode = UnityEngine_Playables_PlayableHandle__GetHashCode((__int64)&Handle, nullptr);
  if ( (*((_DWORD *)a0 + 7) != HashCode || *((double *)a0 + 4) >= a2)
    && VL_Core_VLMonoBehaviourSingleton_object___get_HasInstance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__) )
  {
    CapturedTexture = Campus_Timeline_CampusCrossFadeMixerBehaviour__GetCapturedTexture(a0, v9);
    Instance = VL_Core_VLMonoBehaviourSingleton_object___get_Instance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    if ( !Instance )
      goto LABEL_20;
    if ( CapturedTexture )
    {
      v13 = (void *)Instance[17];
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( !UnityEngine_Object__op_Equality(v13, nullptr, nullptr) )
      {
        v14 = UnityEngine_Rendering_RTHandle__op_Implicit_2(CapturedTexture, nullptr);
        if ( !*(_DWORD *)(UnityEngine_Graphics_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Graphics_TypeInfo);
        UnityEngine_Graphics__Blit(v13, v14, nullptr);
        v15 = *((void **)a0 + 2);
        Instance = UnityEngine_Rendering_RTHandle__op_Implicit_1(CapturedTexture, nullptr);
        if ( v15 )
        {
          UnityEngine_UI_RawImage__set_texture(v15, Instance, nullptr);
          *((_DWORD *)a0 + 7) = HashCode;
          *((double *)a0 + 4) = a2;
          return;
        }
LABEL_20:
        sub_63CF120(Instance, v12);
        JUMPOUT(0xDD4A4EC);
      }
    }
  }
}

