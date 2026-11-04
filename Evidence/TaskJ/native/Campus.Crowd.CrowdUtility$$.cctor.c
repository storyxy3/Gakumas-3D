// Campus.Crowd.CrowdUtility$$.cctor @ 0xddcd640
void __fastcall Campus_Crowd_CrowdUtility___cctor(void *a0)
{
  __int64 v1; // x19
  __int64 v2; // x0
  __int64 v3; // x1
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5
  __int64 v8; // x19
  int v9; // w4
  void *v10; // x5
  __int64 v11; // x0
  void *v12; // x0
  void *v13; // x1
  __int128 v14; // [xsp+0h] [xbp+0h] BYREF
  __int128 v15; // [xsp+10h] [xbp+10h] BYREF
  __int128 v16; // [xsp+20h] [xbp+20h] BYREF
  __int128 v17; // [xsp+30h] [xbp+30h] BYREF
  __int128 v18; // [xsp+40h] [xbp+40h] BYREF
  __int128 v19; // [xsp+50h] [xbp+50h] BYREF
  __int128 v20; // [xsp+60h] [xbp+60h] BYREF
  __int128 v21; // [xsp+70h] [xbp+70h] BYREF
  __int128 v22; // [xsp+80h] [xbp+80h] BYREF
  __int128 v23; // [xsp+90h] [xbp+90h] BYREF

  if ( (unk_F43BD43 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdUtility_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_VertexAttributeDescriptor___TypeInfo);
    unk_F43BD43 = 1;
  }
  v1 = sub_63CEF64(UnityEngine_Rendering_VertexAttributeDescriptor___TypeInfo, 6);
  v23 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v23, 0, 0, 3, 0, nullptr);
  if ( !v1 )
    goto LABEL_17;
  if ( !*(_DWORD *)(v1 + 24) )
    goto LABEL_16;
  *(_OWORD *)(v1 + 32) = v23;
  v22 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v22, 1, 0, 3, 0, nullptr);
  if ( (*(_DWORD *)(v1 + 24) & 0xFFFFFFFE) == 0 )
    goto LABEL_16;
  *(_OWORD *)(v1 + 48) = v22;
  v21 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v21, 3, 2, 4, 1, nullptr);
  if ( *(_DWORD *)(v1 + 24) <= 2u )
    goto LABEL_16;
  *(_OWORD *)(v1 + 64) = v21;
  v20 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v20, 4, 1, 2, 1, nullptr);
  if ( (*(_DWORD *)(v1 + 24) & 0xFFFFFFFC) == 0 )
    goto LABEL_16;
  *(_OWORD *)(v1 + 80) = v20;
  v19 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v19, 7, 10, 4, 3, nullptr);
  if ( *(_DWORD *)(v1 + 24) <= 4u )
    goto LABEL_16;
  *(_OWORD *)(v1 + 96) = v19;
  v18 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v18, 8, 0, 3, 2, nullptr);
  if ( *(_DWORD *)(v1 + 24) <= 5u )
    goto LABEL_16;
  *(_OWORD *)(v1 + 112) = v18;
  **(_QWORD **)(Campus_Crowd_CrowdUtility_TypeInfo + 184LL) = v1;
  sub_63CEE24(*(void **)(Campus_Crowd_CrowdUtility_TypeInfo + 184LL), v1, v4, v5, v6, v7);
  v8 = sub_63CEF64(UnityEngine_Rendering_VertexAttributeDescriptor___TypeInfo, 4);
  v17 = 0u;
  UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v17, 0, 0, 3, 0, nullptr);
  if ( v8 )
  {
    if ( *(_DWORD *)(v8 + 24) )
    {
      *(_OWORD *)(v8 + 32) = v17;
      v16 = 0u;
      UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v16, 1, 0, 3, 0, nullptr);
      if ( (*(_DWORD *)(v8 + 24) & 0xFFFFFFFE) != 0 )
      {
        *(_OWORD *)(v8 + 48) = v16;
        v15 = 0u;
        UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v15, 3, 2, 4, 1, nullptr);
        if ( *(_DWORD *)(v8 + 24) > 2u )
        {
          *(_OWORD *)(v8 + 64) = v15;
          v14 = 0u;
          UnityEngine_Rendering_VertexAttributeDescriptor___ctor((__int64)&v14, 4, 1, 2, 1, nullptr);
          if ( (*(_DWORD *)(v8 + 24) & 0xFFFFFFFC) != 0 )
          {
            *(_OWORD *)(v8 + 80) = v14;
            v11 = *(_QWORD *)(Campus_Crowd_CrowdUtility_TypeInfo + 184LL);
            *(_QWORD *)(v11 + 8) = v8;
            sub_63CEE24((void *)(v11 + 8), v8, v4, v5, v9, v10);
            return;
          }
        }
      }
    }
LABEL_16:
    sub_63CF128(v2, v3, v4, v5);
  }
LABEL_17:
  v12 = (void *)sub_63CF120(v2, v3);
  Campus_Crowd_CrowdVolume__get_Crowd(v12, v13);
}

