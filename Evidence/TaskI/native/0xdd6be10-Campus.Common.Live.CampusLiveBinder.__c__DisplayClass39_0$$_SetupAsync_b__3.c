// 0xdd6be10 @ 0xdd6be10
void *__fastcall Campus_Common_Live_CampusLiveBinder___c__DisplayClass39_0___SetupAsync_b__3(
        void *a0,
        void *a1,
        void *a2)
{
  void *v4; // x20
  void *result; // x0
  __int64 v6; // x10
  __int64 v7; // x0
  void *v8; // x1
  __int64 v9; // x30
  __int64 v10; // x8
  __int64 v11; // x8
  void *v12; // x19
  void *v13; // x0
  __int64 v14; // [xsp+0h] [xbp+0h]
  __int64 v15; // [xsp+8h] [xbp+8h] BYREF

  v4 = a0;
  if ( (unk_F43BA40 & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Playables_PlayableDirector_TypeInfo);
    unk_F43BA40 = 1;
  }
  BYTE4(v15) = 0;
  if ( a1 && (a0 = *((void **)v4 + 2)) != nullptr )
  {
    result = UnityEngine_Playables_PlayableDirector__GetReferenceValue(
               a0,
               *((unsigned int *)a1 + 6),
               (char *)&v15 + 4,
               nullptr);
    if ( result )
    {
      v6 = *(unsigned __int8 *)(UnityEngine_Playables_PlayableDirector_TypeInfo + 304LL);
      if ( *(unsigned __int8 *)(*(_QWORD *)result + 304LL) >= (unsigned int)v6 )
      {
        if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)result + 200LL) + 8 * v6 - 8) != UnityEngine_Playables_PlayableDirector_TypeInfo )
          return nullptr;
      }
      else
      {
        return nullptr;
      }
    }
  }
  else
  {
    v7 = sub_63CF120(a0, a1);
    *(&v14 - 2) = v9;
    *(&v14 - 1) = (__int64)a1;
    v10 = *(_QWORD *)(v7 + 24);
    if ( v10 && (v11 = *(_QWORD *)(v10 + 80)) != 0 && (v12 = v8) != nullptr )
    {
      UnityEngine_Playables_PlayableDirector__set_timeUpdateMode(v8, *(_DWORD *)(v11 + 72), nullptr);
      UnityEngine_Playables_PlayableDirector__set_extrapolationMode(v12, 0, nullptr);
    }
    else
    {
      v13 = (void *)sub_63CF120(v7, v8);
      System_Object___ctor(v13, nullptr);
    }
  }
  return result;
}

