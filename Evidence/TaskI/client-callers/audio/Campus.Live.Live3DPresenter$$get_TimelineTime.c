// 0x84f3b90 @ 0x84f3b90
float __fastcall Campus_Live_Live3DPresenter__get_TimelineTime(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x0
  __int64 v5; // x1
  float v6; // s8
  __int64 v7; // x8
  void *v8; // x20
  __int64 v9; // x8

  if ( (unk_F413023 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F413023 = 1;
  }
  v3 = *((void **)a0 + 8);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v4 = (void *)UnityEngine_Object__op_Equality(v3, nullptr, nullptr);
  v6 = 0.0;
  if ( ((unsigned __int8)v4 & 1) == 0 )
  {
    v7 = *((_QWORD *)a0 + 8);
    if ( !v7 )
      goto LABEL_14;
    v8 = *(void **)(v7 + 32);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    v4 = (void *)UnityEngine_Object__op_Equality(v8, nullptr, nullptr);
    if ( ((unsigned __int8)v4 & 1) == 0 )
    {
      v9 = *((_QWORD *)a0 + 8);
      if ( v9 )
      {
        v4 = *(void **)(v9 + 32);
        if ( v4 )
          return UnityEngine_Playables_PlayableDirector__get_time(v4, nullptr);
      }
LABEL_14:
      sub_63CF120(v4, v5);
      JUMPOUT(0x84F3C58);
    }
  }
  return v6;
}

