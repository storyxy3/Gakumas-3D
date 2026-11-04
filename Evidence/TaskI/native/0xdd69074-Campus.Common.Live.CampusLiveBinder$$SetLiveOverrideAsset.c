// 0xdd69074 @ 0xdd69074
void __fastcall Campus_Common_Live_CampusLiveBinder__SetLiveOverrideAsset(void *a0, void *a1, void *a2)
{
  void *v3; // x20
  void *v4; // x19
  __int64 v5; // x8
  void *v6; // x21
  __int64 v7; // x8
  __int64 v8; // x8
  void *v9; // x21
  void *v10; // x2
  void *v11; // x3
  __int64 v12; // x8
  void *v13; // x21
  __int64 v14; // x8
  __int64 v15; // x9
  __int64 v16; // x9
  __int64 v17; // x8
  __int64 v18; // x9
  __int64 v19; // x9
  __int64 v20; // x24
  unsigned __int64 v21; // x25
  unsigned int v22; // w8
  __int64 v23; // x8
  __int64 v24; // x8
  __int64 v25; // x22
  int v26; // w8
  __int64 v27; // x26
  void *v28; // x21
  __int64 v29; // x28
  void *v30; // x22
  __int64 v31; // x8
  __int64 v32; // x8
  __int64 v33; // x9
  __int64 v34; // x9
  void *v35; // x2
  __int64 v36; // x8
  void *v37; // x1

  v3 = a1;
  v4 = a0;
  if ( (unk_F43BA26 & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA26 = 1;
  }
  v5 = *((_QWORD *)v4 + 10);
  if ( !v5 )
    goto LABEL_69;
  v6 = *(void **)(v5 + 144);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  a0 = (void *)UnityEngine_Object__op_Equality(v6, nullptr, nullptr);
  if ( ((unsigned __int8)a0 & 1) == 0 )
  {
    v7 = *((_QWORD *)v4 + 10);
    if ( !v7 )
      goto LABEL_69;
    v8 = *(_QWORD *)(v7 + 144);
    if ( !v8 )
      goto LABEL_69;
    v9 = *(void **)(v8 + 24);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    a0 = (void *)UnityEngine_Object__op_Inequality(v9, nullptr, nullptr);
    if ( ((unsigned __int8)a0 & 1) != 0 )
    {
      v12 = *((_QWORD *)v4 + 5);
      if ( !v12 )
        goto LABEL_69;
      v13 = *(void **)(v12 + 264);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      a0 = (void *)UnityEngine_Object__op_Inequality(v13, nullptr, nullptr);
      if ( ((unsigned __int8)a0 & 1) != 0 )
      {
        v14 = *((_QWORD *)v4 + 5);
        if ( !v14 )
          goto LABEL_69;
        v15 = *((_QWORD *)v4 + 10);
        if ( !v15 )
          goto LABEL_69;
        v16 = *(_QWORD *)(v15 + 144);
        if ( !v16 )
          goto LABEL_69;
        a0 = *(void **)(v14 + 264);
        if ( !a0 )
          goto LABEL_69;
        UnityEngine_Video_VideoPlayer__set_clip(a0, *(void **)(v16 + 24), nullptr);
      }
    }
    v17 = *((_QWORD *)v4 + 10);
    if ( v17 )
    {
      v18 = *(_QWORD *)(v17 + 144);
      if ( v18 )
      {
        if ( !*(_QWORD *)(v18 + 32) )
          goto LABEL_48;
        v19 = *((_QWORD *)v4 + 5);
        if ( v19 )
        {
          v20 = *(_QWORD *)(v19 + 272);
          if ( !v20 || (int)*(_QWORD *)(v20 + 24) < 1 )
            goto LABEL_48;
          v21 = 0;
          v22 = *(_QWORD *)(v20 + 24);
          do
          {
            if ( v21 >= v22 )
              goto LABEL_70;
            v23 = *((_QWORD *)v4 + 10);
            if ( !v23 )
              goto LABEL_69;
            v24 = *(_QWORD *)(v23 + 144);
            if ( !v24 )
              goto LABEL_69;
            v25 = *(_QWORD *)(v24 + 32);
            if ( !v25 )
              goto LABEL_69;
            v26 = *(_DWORD *)(v25 + 24);
            if ( v26 >= 1 )
            {
              v27 = 0;
              v28 = *(void **)(v20 + 8 * v21 + 32);
              while ( 1 )
              {
                if ( (unsigned int)v27 >= v26 )
                  goto LABEL_70;
                if ( !v28 )
                  goto LABEL_69;
                v29 = *(_QWORD *)(v25 + 32 + 8 * v27);
                a0 = UnityEngine_Component__get_gameObject(v28, nullptr);
                if ( !a0 )
                  goto LABEL_69;
                a0 = UnityEngine_Object__get_name(a0, nullptr);
                if ( !v29 || !a0 )
                  goto LABEL_69;
                a0 = (void *)System_String__Equals_1(a0, *(void **)(v29 + 16), nullptr);
                if ( ((unsigned __int8)a0 & 1) != 0 )
                  break;
                v26 = *(_DWORD *)(v25 + 24);
                if ( (int)++v27 >= v26 )
                  goto LABEL_46;
              }
              v30 = *(void **)(v29 + 24);
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              a0 = (void *)UnityEngine_Object__op_Inequality(v30, nullptr, nullptr);
              if ( ((unsigned __int8)a0 & 1) != 0 )
                UnityEngine_UI_Image__set_sprite(v28, *(void **)(v29 + 24), nullptr);
            }
LABEL_46:
            v22 = *(_DWORD *)(v20 + 24);
            ++v21;
          }
          while ( (__int64)v21 < (int)v22 );
          v17 = *((_QWORD *)v4 + 10);
          if ( v17 )
          {
LABEL_48:
            v31 = *(_QWORD *)(v17 + 144);
            if ( v31 )
            {
              a1 = *(void **)(v31 + 48);
              if ( a1 && *((_QWORD *)a1 + 3) )
              {
                a0 = *((void **)v4 + 5);
                if ( !a0 )
                  goto LABEL_69;
                Campus_Common_Live_CampusLiveTimelineController__ApplyMuteFromTrackDisableSettings(a0, a1, v10);
              }
              else
              {
                a1 = *(void **)(v31 + 40);
                if ( a1 )
                {
                  a0 = *((void **)v4 + 5);
                  if ( !a0 )
                    goto LABEL_69;
                  Campus_Common_Live_CampusLiveTimelineController__ApplyTrackMuteState(a0, a1, 1, v11);
                }
              }
              v32 = *((_QWORD *)v4 + 10);
              if ( v32 )
              {
                v33 = *(_QWORD *)(v32 + 144);
                if ( v33 )
                {
                  a1 = *(void **)(v33 + 56);
                  if ( !a1
                    || (a0 = *((void **)v4 + 5)) != nullptr
                    && (Campus_Common_Live_CampusLiveTimelineController__ApplyTrackMuteState(a0, a1, 0, v11),
                        (v32 = *((_QWORD *)v4 + 10)) != 0) )
                  {
                    v34 = *(_QWORD *)(v32 + 144);
                    if ( v34 )
                    {
                      v35 = *(void **)(v34 + 64);
                      if ( !v35
                        || *((_QWORD *)v4 + 5)
                        && (Campus_Common_Live_CampusLiveTimelineController__ApplyOverrideMotionTracks(a0, v3, v35, v11),
                            (v32 = *((_QWORD *)v4 + 10)) != 0) )
                      {
                        v36 = *(_QWORD *)(v32 + 144);
                        if ( v36 )
                        {
                          v37 = *(void **)(v36 + 72);
                          if ( v37 )
                            Campus_Common_Live_CampusLiveBinder__ApplyOverrideActorHierarchyTransforms(v4, v37, v35);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
LABEL_69:
    a0 = (void *)sub_63CF120(a0, a1);
LABEL_70:
    sub_63CF128(a0, a1, (_DWORD)v10, (_DWORD)v11);
    JUMPOUT(0xDD69388);
  }
}

