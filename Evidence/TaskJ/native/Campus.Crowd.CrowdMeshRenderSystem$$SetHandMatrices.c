// Campus.Crowd.CrowdMeshRenderSystem$$SetHandMatrices @ 0xddc857c
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__SetHandMatrices(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v7; // x25
  __int64 v8; // x23
  unsigned __int64 v9; // x24
  __int128 v10; // q1
  __int128 v11; // q2
  __int64 v12; // x26
  __int128 *v13; // x8
  __int128 v14; // q3
  __int128 v15; // q4
  __int128 v16; // q5
  __int128 v17; // q6
  __int128 v18; // q0
  __int64 v19; // x0
  __int64 v20; // x1
  int v21; // w2
  int v22; // w3
  __int128 v23; // q0
  _OWORD *v24; // x8
  __int128 v25; // q2
  __int128 v26; // q3
  __int64 v27; // x8
  _OWORD *v28; // x8
  int v29; // w9
  __int128 *v30; // x9
  __int128 v31; // q0
  __int128 v32; // q2
  __int128 v33; // q3
  __int64 v34; // x0
  __int128 v35; // [xsp+0h] [xbp+0h] BYREF
  __int128 v36; // [xsp+10h] [xbp+10h]
  __int128 v37; // [xsp+20h] [xbp+20h]
  __int128 v38; // [xsp+30h] [xbp+30h]
  __int128 v39; // [xsp+40h] [xbp+40h] BYREF
  __int128 v40; // [xsp+50h] [xbp+50h]
  __int128 v41; // [xsp+60h] [xbp+60h]
  __int128 v42; // [xsp+70h] [xbp+70h]
  __int128 v43; // [xsp+80h] [xbp+80h] BYREF
  __int128 v44; // [xsp+90h] [xbp+90h]
  __int128 v45; // [xsp+A0h] [xbp+A0h]
  __int128 v46; // [xsp+B0h] [xbp+B0h]
  __int128 v47; // [xsp+C0h] [xbp+C0h]
  __int128 v48; // [xsp+D0h] [xbp+D0h]
  __int128 v49; // [xsp+E0h] [xbp+E0h]
  __int128 v50; // [xsp+F0h] [xbp+F0h]

  if ( (unk_F43BD0C & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    unk_F43BD0C = 1;
  }
  if ( a1 )
  {
    v7 = 0;
    v8 = 0;
    v9 = -1;
    do
    {
      v10 = *(_OWORD *)((char *)a0 + 88);
      v11 = *(_OWORD *)((char *)a0 + 104);
      v12 = *((_QWORD *)a0 + 8);
      v13 = (__int128 *)(*(_QWORD *)a2 + ((__int64)(*((_DWORD *)a0 + 7) + *((_DWORD *)a0 + 6) * (int)v8) << 6));
      v14 = *v13;
      v15 = v13[1];
      v16 = v13[2];
      v17 = v13[3];
      v35 = *(_OWORD *)((char *)a0 + 72);
      v36 = v10;
      v18 = *(_OWORD *)((char *)a0 + 120);
      v39 = v14;
      v40 = v15;
      v37 = v11;
      v38 = v18;
      v41 = v16;
      v42 = v17;
      v47 = v14;
      v48 = v15;
      v49 = v16;
      v50 = v17;
      v19 = (__int64)UnityEngine_Matrix4x4__op_Multiply(
                       (UnityEngine_Matrix4x4_o *)&v43,
                       (UnityEngine_Matrix4x4_o *)&v39,
                       (UnityEngine_Matrix4x4_o *)&v35,
                       nullptr);
      if ( !v12 )
        goto LABEL_14;
      if ( v9 + 1 >= *(unsigned int *)(v12 + 24) )
        goto LABEL_15;
      v23 = v46;
      v24 = (_OWORD *)(v12 + v7);
      v25 = v43;
      v26 = v44;
      v24[4] = v45;
      v24[5] = v23;
      v24[2] = v25;
      v24[3] = v26;
      v27 = *((_QWORD *)a0 + 8);
      if ( !v27 )
      {
LABEL_14:
        v19 = sub_63CF120(v19, v20);
LABEL_15:
        sub_63CF128(v19, v20, v21, v22);
        JUMPOUT(0xDDC8700);
      }
      v9 += 2LL;
      if ( v9 >= *(unsigned int *)(v27 + 24) )
        goto LABEL_15;
      v28 = (_OWORD *)(v27 + v7);
      v7 += 128;
      v29 = *((_DWORD *)a0 + 8) + *((_DWORD *)a0 + 6) * v8++;
      v30 = (__int128 *)(*(_QWORD *)a2 + ((__int64)v29 << 6));
      v31 = v30[3];
      v32 = *v30;
      v33 = v30[1];
      v28[8] = v30[2];
      v28[9] = v31;
      v28[6] = v32;
      v28[7] = v33;
    }
    while ( v8 != 8 );
    v34 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
    if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
      v34 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
    }
    UnityEngine_MaterialPropertyBlock__SetMatrixArray_2(
      a1,
      *(_DWORD *)(*(_QWORD *)(v34 + 184) + 36LL),
      *((void **)a0 + 8),
      nullptr);
  }
}

