// Campus.Live.LiveSceneCameraHelper$$SetVLCameraAspectRatio @ 0x862fdac
void __fastcall Campus_Live_LiveSceneCameraHelper__SetVLCameraAspectRatio(void *a0, bool a1, void *a2)
{
  __int64 v3; // x22
  _BOOL8 v4; // x19
  _DWORD *Instance; // x0
  __int64 v6; // x1
  int v7; // w8
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x30
  __int64 v11; // x19
  void *v12; // x0
  void *gameObject; // x0
  __int64 v14; // x0
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  __int64 v19; // x30
  __int64 v20; // x1
  __int64 v21; // x19
  __int64 v22; // x20
  int v23; // w2
  int v24; // w3
  int v25; // w4
  void *v26; // x5
  int v27; // w2
  int v28; // w3
  int v29; // w4
  void *v30; // x5
  void *v31; // x1
  __int128 v32; // [xsp+0h] [xbp+0h] BYREF
  __int128 v33; // [xsp+10h] [xbp+10h] BYREF
  __int128 v34; // [xsp+20h] [xbp+20h] BYREF
  __int128 v35; // [xsp+30h] [xbp+30h]
  __int64 v36; // [xsp+40h] [xbp+40h]
  __int64 v37; // [xsp+50h] [xbp+50h]
  void **v38; // [xsp+58h] [xbp+58h]
  __int64 v39; // [xsp+60h] [xbp+60h]
  __int64 v40; // [xsp+68h] [xbp+68h]

  v4 = a1;
  if ( (unk_F4139BD & 1) == 0 )
  {
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__);
    sub_63CEE78(&Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    unk_F4139BD = 1;
  }
  if ( VL_Core_VLMonoBehaviourSingleton_object___get_HasInstance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__) )
  {
    Instance = VL_Core_VLMonoBehaviourSingleton_object___get_Instance(Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_Instance__);
    if ( Instance )
    {
      if ( v4 )
        v7 = 1071877691;
      else
        v7 = 1075209830;
      Instance[10] = v7;
      Instance[11] = 1065353216;
      VL_Rendering_VLSRPCameraController__UpdateRenderTarget(Instance, nullptr);
    }
    else
    {
      v8 = sub_63CF120(0, v6);
      *((_QWORD *)&v32 - 2) = v10;
      *((_QWORD *)&v32 - 1) = v4;
      v11 = v8;
      v12 = *(void **)(v8 + 80);
      if ( v12 )
      {
        gameObject = UnityEngine_Component__get_gameObject(v12, nullptr);
        Qua_Extensions_GameObjectExtensions__TrySetActive(gameObject, 0, nullptr);
        Qua_Extensions_GameObjectExtensions__TrySetActive(*(void **)(v11 + 112), 1, nullptr);
      }
      else
      {
        v14 = sub_63CF120(0, v9);
        v36 = v19;
        v37 = v3;
        v38 = &Method_VL_Core_VLMonoBehaviourSingleton_VLSRPCameraController__get_HasInstance__;
        v39 = 255930368;
        v40 = v11;
        v21 = v20;
        v22 = v14;
        if ( (unk_F413996 & 1) == 0 )
        {
          sub_63CEE78(&Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_LivePresenter__PlayLiveSequenceAsync_d__17___);
          unk_F413996 = 1;
        }
        v32 = 0u;
        v33 = 0u;
        v34 = 0u;
        v35 = 0u;
        sub_63CEE24((char *)&v32 + 8, 0, v15, v16, v17, v18);
        *((_QWORD *)&v33 + 1) = v22;
        sub_63CEE24((char *)&v33 + 8, v22, v23, v24, v25, v26);
        *(_QWORD *)&v34 = v21;
        sub_63CEE24(&v34, 0, v27, v28, v29, v30);
        LODWORD(v32) = -1;
        if ( !*(_QWORD *)(Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_LivePresenter__PlayLiveSequenceAsync_d__17___
                        + 56LL) )
          sub_6407F5C();
        Campus_Live_LivePresenter__PlayLiveSequenceAsync_d__17__MoveNext((__int64)&v32, v31);
        sub_64DD1D4((char *)&v32 + 8, 0);
      }
    }
  }
}

