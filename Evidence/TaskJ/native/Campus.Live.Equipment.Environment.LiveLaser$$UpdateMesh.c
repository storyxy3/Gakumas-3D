// Campus.Live.Equipment.Environment.LiveLaser$$UpdateMesh @ 0xddb6d8c
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__UpdateMesh(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x20
  float v5; // s8
  float v6; // s10
  float v7; // s0
  float v8; // s1
  int v9; // w8
  void *v10; // x19
  void *v11; // x0
  void *v12; // x1
  __int128 v13; // [xsp+10h] [xbp+10h] BYREF
  __int128 v14; // [xsp+20h] [xbp+20h]
  __int128 v15; // [xsp+30h] [xbp+30h]
  __int128 v16; // [xsp+40h] [xbp+40h] BYREF
  __int128 v17; // [xsp+50h] [xbp+50h]
  __int128 v18; // [xsp+60h] [xbp+60h]
  double v19; // [xsp+78h] [xbp+78h] BYREF
  __int64 v20; // [xsp+80h] [xbp+80h]
  __int64 v21; // [xsp+88h] [xbp+88h]

  if ( (unk_F43BC75 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Mesh_SetVertexBufferData_LiveLaser_VertexLayout___);
    unk_F43BC75 = 1;
  }
  v3 = *((void **)a0 + 15);
  if ( !v3 )
    goto LABEL_8;
  UnityEngine_Mesh__SetVertexBufferData_LiveLaser_VertexLayout_(
    v3,
    *((_QWORD *)a0 + 17),
    *((_QWORD *)a0 + 18),
    0,
    0,
    *((_DWORD *)a0 + 36),
    0,
    nullptr);
  v4 = *((void **)a0 + 15);
  if ( !v4 )
    goto LABEL_8;
  v5 = *((float *)a0 + 27);
  v6 = *((float *)a0 + 28) * 0.5;
  v7 = sinf((float)((float)(*((float *)a0 + 26) * (float)(*((_DWORD *)a0 + 25) - 1)) * 0.5) * 0.017453);
  *(float *)&v21 = (float)(v5 + v5) * 0.5;
  *((float *)&v21 + 1) = v6;
  v8 = (float)-v7 - v5;
  *(float *)&v20 = v6 + 0.0;
  *((float *)&v20 + 1) = (float)((float)(v5 + v7) - v8) * 0.5;
  *(float *)&v19 = v8 + *((float *)&v20 + 1);
  *((float *)&v19 + 1) = *(float *)&v21 - v5;
  UnityEngine_Mesh__set_bounds(v4, (UnityEngine_Bounds_o *)&v19, nullptr);
  v3 = *((void **)a0 + 6);
  if ( !v3 )
    goto LABEL_8;
  UnityEngine_Renderer__set_enabled(v3, *((_DWORD *)a0 + 25) > 0, nullptr);
  v9 = *((_DWORD *)a0 + 25);
  v10 = *((void **)a0 + 15);
  v17 = 0u;
  v18 = 0u;
  v16 = 0u;
  UnityEngine_Rendering_SubMeshDescriptor___ctor((__int64)&v16, 0, 48 * v9, 0, nullptr);
  if ( v10 )
  {
    v13 = v16;
    v14 = v17;
    v15 = v18;
    UnityEngine_Mesh__SetSubMesh(v10, 0, (__int64)&v13, 8, nullptr);
  }
  else
  {
LABEL_8:
    v11 = (void *)sub_63CF120(v3, a1);
    Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties(v11, v12);
  }
}

