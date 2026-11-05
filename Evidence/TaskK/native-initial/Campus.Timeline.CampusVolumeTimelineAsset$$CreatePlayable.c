// Campus.Timeline.CampusVolumeTimelineAsset$$CreatePlayable @ 0xdd7e46c
__int64 __fastcall Campus_Timeline_CampusVolumeTimelineAsset__CreatePlayable(void *a0, __int64 a1, void *a2, void *a3)
{
  void *Resolver; // x0
  void *v6; // x21
  bool v7; // w8
  __int64 result; // x0
  __int64 v9; // x20
  void *gameObject; // x0
  __int64 v11; // x1
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  int v20; // s0
  __int64 v21; // d1
  __int64 v22; // x19
  void *v23; // x21
  __int64 v24; // x0
  __int64 v25; // x0
  void *v26; // x1
  void *v27; // x0
  void *v28; // x1
  __int64 v29; // [xsp+0h] [xbp+0h] BYREF
  void *v30; // [xsp+8h] [xbp+8h]

  v29 = a1;
  v30 = a2;
  if ( (unk_F43BAD4 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Timeline_CampusVolumeTimelineBehaviour_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_ExposedReference_Volume__Resolve__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__Create__);
    sub_63CEE78(&Method_UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__op_Implicit__);
    sub_63CEE78(&UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo);
    unk_F43BAD4 = 1;
  }
  Resolver = UnityEngine_Playables_PlayableGraph__GetResolver((__int64)&v29, nullptr);
  v6 = UnityEngine_ExposedReference_object___Resolve(
         (__int64)a0 + 24,
         Resolver,
         Method_UnityEngine_ExposedReference_Volume__Resolve__);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v7 = UnityEngine_Object__op_Equality(v6, nullptr, nullptr);
  result = 0;
  if ( !v7 )
  {
    v9 = sub_63CF110(Campus_Timeline_CampusVolumeTimelineBehaviour_TypeInfo);
    UnityEngine_Timeline_ActivationControlPlayable___ctor((void *)v9, nullptr);
    if ( v6 && (gameObject = UnityEngine_Component__get_gameObject(v6, nullptr), v9) )
    {
      *(_QWORD *)(v9 + 16) = gameObject;
      sub_63CEE24((void *)(v9 + 16), (int)gameObject, v12, v13, v14, v15);
      *(_QWORD *)(v9 + 32) = v6;
      *(_DWORD *)(v9 + 24) = 1;
      sub_63CEE24((void *)(v9 + 32), (int)v6, v16, v17, v18, v19);
      v20 = *((_DWORD *)a0 + 10);
      v21 = *((_QWORD *)a0 + 6);
      v22 = v29;
      v23 = v30;
      v24 = UnityEngine_Playables_ScriptPlayable_CampusVolumeTimelineBehaviour__TypeInfo;
      *(_DWORD *)(v9 + 40) = v20;
      *(_QWORD *)(v9 + 48) = v21;
      if ( !*(_DWORD *)(v24 + 228) )
        sub_63CEFF4(v24);
      v25 = UnityEngine_Playables_ScriptPlayable_object___Create_1(v22, v23, v9, nullptr);
      return UnityEngine_Playables_ScriptPlayable_object___op_Implicit(v25, v26);
    }
    else
    {
      v27 = (void *)sub_63CF120(gameObject, v11);
      Campus_Timeline_CampusVolumeTimelineBehaviour___ctor(v27, v28);
    }
  }
  return result;
}

