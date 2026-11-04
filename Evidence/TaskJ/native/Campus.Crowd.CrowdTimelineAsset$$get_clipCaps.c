// Campus.Crowd.CrowdTimelineAsset$$get_clipCaps @ 0xddcc34c
int __fastcall Campus_Crowd_CrowdTimelineAsset__get_clipCaps(void *a0, void *a1)
{
  __int64 v3; // x9
  void *v4; // x20
  void *v5; // x0
  __int64 v6; // x1
  __int64 v8; // x8
  void *v9; // x0
  __int64 v10; // x1
  void *v11; // x2
  void *v12; // x3

  if ( (unk_F43BD39 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD39 = 1;
  }
  v3 = *((_QWORD *)a0 + 3);
  if ( v3 )
    v4 = *(void **)(v3 + 16);
  else
    v4 = nullptr;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v5 = (void *)UnityEngine_Object__op_Equality(v4, nullptr, nullptr);
  if ( ((unsigned __int8)v5 & 1) != 0 )
    return 0;
  v8 = *((_QWORD *)a0 + 3);
  if ( v8 && (v5 = *(void **)(v8 + 16)) != nullptr )
  {
    if ( VL_MotionDefine__get_isLoop(v5, nullptr) )
      return 27;
    else
      return 26;
  }
  else
  {
    v9 = (void *)sub_63CF120(v5, v6);
    return Campus_Crowd_CrowdTimelineAsset__CreatePlayable(v9, v10, v11, v12);
  }
}

