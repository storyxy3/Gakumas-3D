// 0x84f467c @ 0x84f467c
void __fastcall Campus_Live_Live3DPresenter__InitializeCameraSwitcher(void *a0, void *a1)
{
  void *v3; // x20
  __int64 v4; // x1
  _QWORD *Camera; // x0
  int v6; // w20
  _QWORD *v7; // x21
  __int64 v8; // x8
  void *v9; // x0
  __int64 v10; // x1
  void *v11; // x2

  if ( (unk_F413030 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F413030 = 1;
  }
  v3 = *((void **)a0 + 17);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(v3, nullptr, nullptr) )
  {
    Camera = *((_QWORD **)a0 + 17);
    if ( Camera )
    {
      v6 = 0;
      while ( v6 < Campus_Common_CampusCameraSwitcher__get_CameraCount(Camera, nullptr) )
      {
        Camera = *((_QWORD **)a0 + 17);
        if ( Camera )
        {
          Camera = Campus_Common_CampusCameraSwitcher__GetCamera(Camera, v6, nullptr);
          if ( Camera )
          {
            v7 = Camera;
            Camera = (_QWORD *)Camera[5];
            if ( Camera )
            {
              UnityEngine_Playables_PlayableDirector__Stop(Camera, nullptr);
              v8 = v7[4];
              if ( v8 )
              {
                Camera = *((_QWORD **)a0 + 17);
                ++v6;
                *(_DWORD *)(v8 + 60) = -100;
                if ( Camera )
                  continue;
              }
            }
          }
        }
        goto LABEL_15;
      }
    }
    else
    {
LABEL_15:
      v9 = (void *)sub_63CF120(Camera, v4);
      Campus_Live_Live3DPresenter__InitializePanoramaCameraSwitcherAsync(v9, v10, v11);
    }
  }
}

