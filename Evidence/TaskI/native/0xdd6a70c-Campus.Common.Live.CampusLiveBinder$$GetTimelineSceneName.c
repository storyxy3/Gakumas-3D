// 0xdd6a70c @ 0xdd6a70c
void *__fastcall Campus_Common_Live_CampusLiveBinder__GetTimelineSceneName(void *a0, void *a1)
{
  _QWORD *v2; // x19
  __int64 v3; // x8
  void *v4; // x20
  __int64 v5; // x8
  void *v6; // x20
  __int64 v7; // x8
  __int64 v9; // [xsp+8h] [xbp+8h] BYREF

  v2 = a0;
  if ( (unk_F43BA2A & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA2A = 1;
  }
  v3 = v2[10];
  HIDWORD(v9) = 0;
  if ( !v3 )
    goto LABEL_19;
  v4 = *(void **)(v3 + 24);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  a0 = (void *)UnityEngine_Object__op_Inequality(v4, nullptr, nullptr);
  v5 = v2[10];
  if ( ((unsigned __int8)a0 & 1) != 0 )
  {
    if ( !v5 )
      goto LABEL_19;
    a0 = *(void **)(v5 + 24);
    if ( !a0 )
      goto LABEL_19;
    goto LABEL_16;
  }
  if ( !v5 )
    goto LABEL_19;
  v6 = *(void **)(v5 + 16);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  a0 = (void *)UnityEngine_Object__op_Inequality(v6, nullptr, nullptr);
  if ( ((unsigned __int8)a0 & 1) == 0 )
    return **(void ***)(unk_F43F500 + 184LL);
  v7 = v2[10];
  if ( !v7 || (a0 = *(void **)(v7 + 16)) == nullptr )
  {
LABEL_19:
    sub_63CF120(a0, a1);
    JUMPOUT(0xDD6A818);
  }
LABEL_16:
  a0 = UnityEngine_Component__get_gameObject(a0, nullptr);
  if ( !a0 )
    goto LABEL_19;
  HIDWORD(v9) = UnityEngine_GameObject__get_scene(a0, nullptr);
  return UnityEngine_SceneManagement_Scene__get_name((__int64)&v9 + 4, nullptr);
}

