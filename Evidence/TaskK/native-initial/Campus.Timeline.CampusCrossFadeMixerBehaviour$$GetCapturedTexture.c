// Campus.Timeline.CampusCrossFadeMixerBehaviour$$GetCapturedTexture @ 0xdd49f1c
void *__fastcall Campus_Timeline_CampusCrossFadeMixerBehaviour__GetCapturedTexture(void *a0, void *a1)
{
  char *Instance; // x0
  __int64 v4; // x1
  __int128 v5; // q1
  __int128 v6; // q2
  int v7; // w8
  void *result; // x0
  _QWORD *v9; // x19
  void *v10; // t1
  __int128 v11; // q0
  void *v12; // x0
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  __int128 v17; // [xsp+0h] [xbp+0h] BYREF
  __int128 v18; // [xsp+10h] [xbp+10h]
  __int128 v19; // [xsp+20h] [xbp+20h]
  int v20; // [xsp+30h] [xbp+30h]

  if ( (unk_F43B8F2 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_RTHandles_TypeInfo);
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__);
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    sub_63CEE78(&StringLiteral_CrossFadeCapturedTexture);
    unk_F43B8F2 = 1;
  }
  v20 = 0;
  v18 = 0u;
  v19 = 0u;
  v17 = 0u;
  if ( !VL_Core_VLMonoBehaviourSingleton_object___get_HasInstance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__) )
    return nullptr;
  Instance = (char *)VL_Core_VLMonoBehaviourSingleton_object___get_Instance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
  if ( Instance )
  {
    v11 = *(_OWORD *)(Instance + 152);
    v5 = *(_OWORD *)(Instance + 168);
    v6 = *(_OWORD *)(Instance + 184);
    v7 = *((_DWORD *)Instance + 50);
    v10 = *((void **)a0 + 5);
    v9 = (char *)a0 + 40;
    result = v10;
    v18 = v5;
    v19 = v6;
    v20 = v7;
    *(int32x2_t *)&v11 = vshr_n_s32(*(int32x2_t *)&v11, 1u);
    v17 = v11;
    if ( v10 )
    {
      if ( (_QWORD)v11 == *(_QWORD *)((char *)result + 172) )
        return result;
      UnityEngine_Rendering_RTHandle__Release(result, nullptr);
    }
    if ( !*(_DWORD *)(UnityEngine_Rendering_RTHandles_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Rendering_RTHandles_TypeInfo);
    v12 = UnityEngine_Rendering_RTHandles__Alloc_1(
            &v17,
            1,
            1,
            0,
            1,
            0.0,
            StringLiteral_CrossFadeCapturedTexture,
            nullptr);
    *v9 = v12;
    sub_63CEE24(v9, (int)v12, v13, v14, v15, v16);
    return (void *)*v9;
  }
  else
  {
    result = *(void **)(sub_63CF120(0, v4) + 40);
    if ( result )
      UnityEngine_Rendering_RTHandle__Release(result, nullptr);
  }
  return result;
}

