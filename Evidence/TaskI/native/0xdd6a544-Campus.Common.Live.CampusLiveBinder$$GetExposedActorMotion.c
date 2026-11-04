// 0xdd6a544 @ 0xdd6a544
// local variable allocation has failed, the output may be wrong!
void *__fastcall Campus_Common_Live_CampusLiveBinder__GetExposedActorMotion(void *a0, int a1, void *a2)
{
  _QWORD *v4; // x20
  __int64 v5; // x8
  int v6; // w2
  int v7; // w3
  __int64 v8; // x8
  __int64 v9; // x8
  int v10; // w9
  void *v12; // x0
  int v13; // w1
  void *v14; // x2

  v4 = a0;
  if ( (unk_F43BA2B & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_ActorMotionDefine___);
    unk_F43BA2B = 1;
  }
  v5 = v4[10];
  if ( v5 )
  {
    a0 = (void *)Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_object_(
                   *(void **)(v5 + 104),
                   Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_ActorMotionDefine___);
    if ( ((unsigned __int8)a0 & 1) != 0 )
      return nullptr;
    v8 = v4[10];
    if ( v8 )
    {
      v9 = *(_QWORD *)(v8 + 104);
      if ( v9 )
      {
        v10 = *(_DWORD *)(v9 + 24);
        if ( v10 > a1 )
        {
          if ( v10 > (unsigned int)a1 )
            return *(void **)(v9 + 8LL * a1 + 32);
          goto LABEL_12;
        }
        return nullptr;
      }
    }
  }
  a0 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
LABEL_12:
  sub_63CF128(a0, *(_QWORD *)&a1, v6, v7);
  return (void *)Campus_Common_Live_CampusLiveBinder__HasLiveOverrideActorMotion(v12, v13, v14);
}

