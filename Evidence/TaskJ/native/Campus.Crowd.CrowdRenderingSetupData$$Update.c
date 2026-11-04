// Campus.Crowd.CrowdRenderingSetupData$$Update @ 0xddc45fc
void __fastcall Campus_Crowd_CrowdRenderingSetupData__Update(void *a0, void *a1, bool a2, void *a3, void *a4)
{
  void *v8; // x1
  __int128 v9; // q1
  unsigned __int64 v10; // x8
  int v11; // w9
  _DWORD *transform; // x0
  __int128 v13; // q0
  __int128 v14; // q2
  float v15; // s0
  float v16; // s14
  int v17; // s0
  int v18; // s11
  _QWORD *v19; // x8
  int v20; // s0
  int v21; // s1
  int v22; // s2
  int v23; // s13
  int v24; // s9
  int v25; // s10
  float v26; // s0
  __int128 v27; // q1
  __int128 v28; // q2
  unsigned __int64 v29; // x8
  __int128 v30; // q1
  __int128 v31; // q2
  void *v32; // x0
  int v33; // w1
  void *v34; // x2
  int v35; // [xsp+4h] [xbp+4h]
  __int128 v36; // [xsp+10h] [xbp+10h] BYREF
  __int128 v37; // [xsp+20h] [xbp+20h]
  __int128 v38; // [xsp+30h] [xbp+30h]
  __int128 v39; // [xsp+40h] [xbp+40h]
  __int128 v40; // [xsp+50h] [xbp+50h] BYREF
  __int128 v41; // [xsp+60h] [xbp+60h]
  __int128 v42; // [xsp+70h] [xbp+70h]
  __int128 v43; // [xsp+80h] [xbp+80h]
  __int128 v44; // [xsp+90h] [xbp+90h] BYREF
  __int128 v45; // [xsp+A0h] [xbp+A0h]
  __int128 v46; // [xsp+B0h] [xbp+B0h]
  __int128 v47; // [xsp+C0h] [xbp+C0h]
  __int128 v48; // [xsp+D0h] [xbp+D0h] BYREF
  __int128 v49; // [xsp+E0h] [xbp+E0h]
  __int128 v50; // [xsp+F0h] [xbp+F0h]
  __int128 v51; // [xsp+100h] [xbp+100h]
  __int128 v52; // [xsp+110h] [xbp+110h] BYREF
  __int128 v53; // [xsp+120h] [xbp+120h]
  __int128 v54; // [xsp+130h] [xbp+130h]
  __int128 v55; // [xsp+140h] [xbp+140h]
  __int64 v56; // [xsp+150h] [xbp+150h] BYREF
  UnityEngine_Vector3_o forward; // 0:kr00_12.12
  UnityEngine_Vector3_o Position; // 0:kr14_12.12

  memcpy(&v56, a1, 0x210u);
  UnityEngine_Rendering_Universal_CameraData__GetProjectionMatrix(
    (UnityEngine_Matrix4x4_o *)&v52,
    (__int64)&v56,
    0,
    nullptr);
  memcpy(&v56, a1, 0x210u);
  UnityEngine_Rendering_Universal_CameraData__GetViewMatrix((UnityEngine_Matrix4x4_o *)&v48, (__int64)&v56, 0, nullptr);
  v40 = v52;
  v41 = v53;
  v42 = v54;
  v43 = v55;
  v36 = v48;
  v37 = v49;
  v38 = v50;
  v39 = v51;
  UnityEngine_Matrix4x4__op_Multiply(
    (UnityEngine_Matrix4x4_o *)&v44,
    (UnityEngine_Matrix4x4_o *)&v40,
    (UnityEngine_Matrix4x4_o *)&v36,
    nullptr);
  v9 = v45;
  v10 = *(_QWORD *)((char *)a1 + 452);
  v11 = *((_DWORD *)a1 + 115);
  transform = *((_DWORD **)a1 + 24);
  *(_OWORD *)&STACK[0x370] = v44;
  *(_OWORD *)&STACK[0x380] = v9;
  v13 = v46;
  v14 = v47;
  STACK[0x360] = v10;
  LODWORD(STACK[0x368]) = v11;
  *(_OWORD *)&STACK[0x390] = v13;
  *(_OWORD *)&STACK[0x3A0] = v14;
  if ( !transform )
    goto LABEL_15;
  transform = UnityEngine_Component__get_transform(transform, nullptr);
  if ( !transform )
    goto LABEL_15;
  forward = UnityEngine_Transform__get_forward(transform, nullptr);
  if ( !a3 )
    goto LABEL_15;
  transform = *((_DWORD **)a3 + 11);
  if ( !transform )
    goto LABEL_15;
  (*(void (__fastcall **)(_DWORD *, _QWORD))(*(_QWORD *)transform + 536LL))(
    transform,
    *(_QWORD *)(*(_QWORD *)transform + 544LL));
  transform = *((_DWORD **)a3 + 12);
  if ( !transform )
    goto LABEL_15;
  v16 = v15;
  (*(void (__fastcall **)(_DWORD *, _QWORD))(*(_QWORD *)transform + 536LL))(
    transform,
    *(_QWORD *)(*(_QWORD *)transform + 544LL));
  transform = *((_DWORD **)a3 + 7);
  if ( !transform )
    goto LABEL_15;
  v18 = v17;
  transform = (_DWORD *)(*(__int64 (__fastcall **)(_DWORD *, _QWORD))(*(_QWORD *)transform + 536LL))(
                          transform,
                          *(_QWORD *)(*(_QWORD *)transform + 544LL));
  if ( !transform )
    goto LABEL_15;
  Position = Campus_Crowd_CrowdVolume__get_Position(transform, v8);
  transform = *((_DWORD **)a3 + 7);
  if ( !transform )
    goto LABEL_15;
  transform = (_DWORD *)(*(__int64 (__fastcall **)(_DWORD *, _QWORD))(*(_QWORD *)transform + 536LL))(
                          transform,
                          *(_QWORD *)(*(_QWORD *)transform + 544LL));
  if ( transform
    && (v19 = *((_QWORD **)a3 + 8), *(float *)&STACK[0x3F8] = Position.z, *(float *)&STACK[0x3FC] = Position.y, v19)
    && (v35 = transform[28],
        (*(void (__fastcall **)(_QWORD *__return_ptr, _QWORD *, _QWORD))(*v19 + 536LL))(
          v19,
          v19,
          *(_QWORD *)(*v19 + 544LL)),
        (transform = *((_DWORD **)a3 + 9)) != nullptr) )
  {
    v23 = v20;
    v24 = v21;
    v25 = v22;
    if ( v16 < 0.001 )
      v16 = 0.001;
    v26 = (*(float (__fastcall **)(_DWORD *, _QWORD))(*(_QWORD *)transform + 536LL))(
            transform,
            *(_QWORD *)(*(_QWORD *)transform + 544LL));
    v27 = *(_OWORD *)&STACK[0x370];
    v28 = *(_OWORD *)&STACK[0x380];
    v29 = STACK[0x360];
    *((_DWORD *)a0 + 23) = LODWORD(forward.x);
    *((_DWORD *)a0 + 24) = LODWORD(forward.y);
    *((_QWORD *)a0 + 10) = v29;
    LODWORD(v29) = STACK[0x368];
    *((_OWORD *)a0 + 1) = v27;
    *((_OWORD *)a0 + 2) = v28;
    v30 = *(_OWORD *)&STACK[0x390];
    v31 = *(_OWORD *)&STACK[0x3A0];
    *((_DWORD *)a0 + 22) = v29;
    *((_DWORD *)a0 + 25) = LODWORD(forward.z);
    *((float *)a0 + 26) = v16;
    *((_OWORD *)a0 + 3) = v30;
    *((_OWORD *)a0 + 4) = v31;
    LODWORD(v30) = STACK[0x3FC];
    *((_DWORD *)a0 + 29) = 0;
    *((_DWORD *)a0 + 30) = 0;
    *((_DWORD *)a0 + 35) = v23;
    *((_DWORD *)a0 + 36) = v24;
    *((float *)a0 + 27) = 1.0 / v16;
    *((_DWORD *)a0 + 28) = v18;
    LODWORD(v31) = STACK[0x3F8];
    *((_DWORD *)a0 + 31) = LODWORD(Position.x);
    *((_DWORD *)a0 + 32) = v30;
    *((_DWORD *)a0 + 37) = v25;
    *((float *)a0 + 38) = v26;
    *((_DWORD *)a0 + 33) = v31;
    *((_DWORD *)a0 + 34) = v35;
  }
  else
  {
LABEL_15:
    v32 = (void *)sub_63CF120(transform, v8);
    Campus_Crowd_CrowdSystem__SetDrawCounts(v32, v33, v34);
  }
}

