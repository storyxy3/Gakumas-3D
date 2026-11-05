// Campus.Timeline.CampusVolumeTimelineTrack$$CreatePlayable @ 0xdd7eb20
__int64 __fastcall Campus_Timeline_CampusVolumeTimelineTrack__CreatePlayable(
        void *a0,
        __int64 a1,
        void *a2,
        void *a3,
        void *a4)
{
  void *v7; // x21
  __int64 v8; // x8
  __int64 v9; // x11
  __int64 v10; // x22
  __int64 result; // x0
  void *Resolver; // x0
  _DWORD *v13; // x23
  void *v14; // x0
  void *v15; // x1
  __int64 v16; // [xsp+0h] [xbp+0h] BYREF
  void *v17; // [xsp+8h] [xbp+8h]

  v7 = a0;
  v16 = a1;
  v17 = a2;
  if ( (unk_F43BADA & 1) == 0 )
  {
    sub_63CEE78(&Campus_Timeline_CampusVolumeTimelineAsset_TypeInfo);
    sub_63CEE78(&Method_UnityEngine_ExposedReference_Volume__Resolve__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    a0 = (void *)sub_63CEE78(&UnityEngine_Playables_Playable_TypeInfo);
    unk_F43BADA = 1;
  }
  if ( !a4 )
    goto LABEL_23;
  v8 = *((_QWORD *)a4 + 5);
  if ( v8
    && (v9 = *(unsigned __int8 *)(Campus_Timeline_CampusVolumeTimelineAsset_TypeInfo + 304LL),
        *(unsigned __int8 *)(*(_QWORD *)v8 + 304LL) >= (unsigned int)v9) )
  {
    if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)v8 + 200LL) + 8 * v9 - 8) == Campus_Timeline_CampusVolumeTimelineAsset_TypeInfo )
      v10 = *((_QWORD *)a4 + 5);
    else
      v10 = 0;
  }
  else
  {
    v10 = 0;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  a0 = (void *)UnityEngine_Object__op_Equality((void *)v10, nullptr, nullptr);
  if ( ((unsigned __int8)a0 & 1) == 0 )
  {
    if ( v10 )
    {
      *(_QWORD *)(v10 + 48) = *((_QWORD *)a4 + 3);
      Resolver = UnityEngine_Playables_PlayableGraph__GetResolver((__int64)&v16, nullptr);
      v13 = UnityEngine_ExposedReference_object___Resolve(
              v10 + 24,
              Resolver,
              Method_UnityEngine_ExposedReference_Volume__Resolve__);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      a0 = (void *)UnityEngine_Object__op_Inequality(v13, nullptr, nullptr);
      if ( ((unsigned __int8)a0 & 1) == 0 )
        return UnityEngine_Timeline_TrackAsset__CreatePlayable_1(v7, v16, v17, a3, a4);
      if ( v13 )
      {
        *(_DWORD *)(v10 + 40) = v13[9];
        return UnityEngine_Timeline_TrackAsset__CreatePlayable_1(v7, v16, v17, a3, a4);
      }
    }
LABEL_23:
    v14 = (void *)sub_63CF120(a0, a1);
    Campus_Timeline_CampusVolumeTimelineTrack___ctor(v14, v15);
    return result;
  }
  if ( !*(_DWORD *)(UnityEngine_Playables_Playable_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Playables_Playable_TypeInfo);
  return UnityEngine_Playables_Playable__get_Null(nullptr);
}

