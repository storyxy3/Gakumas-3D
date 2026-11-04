// 0xe0d74c4 @ 0xe0d74c4
// local variable allocation has failed, the output may be wrong!
void __fastcall VLB_MeshGenerator___c__DisplayClass6_1___GenerateConeZ_Radii_DoubleCaps_b__2(
        void *a0,
        int a1,
        bool a2,
        void *a3)
{
  int *v4; // x19
  int v5; // w20
  unsigned int v6; // w21
  int v7; // w22
  int v8; // w23
  __int64 v9; // x25
  __int64 v10; // x26
  __int64 v11; // x8
  __int64 v12; // x8
  __int64 v13; // x8
  int v14; // w24
  int v15; // w9
  __int64 v16; // x8
  int v17; // w2
  int v18; // w3
  __int64 v19; // x8
  unsigned int v20; // w10
  int v21; // w11
  int v22; // w9
  int v23; // w11
  __int64 v24; // x8
  unsigned int v25; // w9
  int v26; // w10
  __int64 v27; // x11
  __int64 v28; // x10
  int v29; // w11

  v11 = *((_QWORD *)a0 + 4);
  if ( !v11 )
    goto LABEL_18;
  v12 = *(_QWORD *)(v11 + 24);
  if ( !v12 )
    goto LABEL_18;
  v7 = a2;
  v4 = (int *)a0;
  v6 = a1;
  a0 = (void *)(*(__int64 (__fastcall **)(_QWORD, int, _QWORD, void *))(v12 + 24))(
                 *(_QWORD *)(v12 + 64),
                 a1,
                 *(_QWORD *)(v12 + 40),
                 a3);
  v13 = *((_QWORD *)v4 + 4);
  if ( !v13 )
    goto LABEL_18;
  v5 = (int)a0;
  v14 = 0;
  if ( (v7 & 1) != 0 )
    v8 = 1;
  else
    v8 = 2;
  if ( (v7 & 1) != 0 )
    v7 = 2;
  else
    v7 = 1;
  while ( 1 )
  {
    v15 = *(_DWORD *)(v13 + 16);
    v9 = *((_QWORD *)v4 + 2);
    v10 = v4[6];
    v16 = *(_QWORD *)(v13 + 32);
    if ( v14 >= v15 - 1 )
      goto LABEL_19;
    if ( !v16 )
      break;
    a0 = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))(v16 + 24))(
                   *(_QWORD *)(v16 + 64),
                   v6,
                   *(_QWORD *)(v16 + 40));
    if ( !v9 )
      break;
    if ( (unsigned int)v10 >= *(_DWORD *)(v9 + 24) )
      goto LABEL_27;
    v19 = *((_QWORD *)v4 + 2);
    *(_DWORD *)(v9 + 4 * v10 + 32) = (_DWORD)a0;
    if ( !v19 )
      goto LABEL_18;
    v20 = *(_DWORD *)(v19 + 24);
    v21 = v4[6] + v8;
    if ( v21 >= v20 )
      goto LABEL_27;
    v22 = v5 + v14;
    *(_DWORD *)(v19 + 4LL * v21 + 32) = v5 + v14 + 1;
    v23 = v4[6] + v7;
    if ( v23 >= v20 )
      goto LABEL_27;
    ++v14;
    *(_DWORD *)(v19 + 4LL * v23 + 32) = v22;
    v13 = *((_QWORD *)v4 + 4);
    v4[6] += 3;
    if ( !v13 )
      goto LABEL_18;
  }
  while ( 1 )
  {
    while ( 1 )
    {
LABEL_18:
      a0 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
LABEL_19:
      if ( v16 )
      {
        a0 = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))(v16 + 24))(
                       *(_QWORD *)(v16 + 64),
                       v6,
                       *(_QWORD *)(v16 + 40));
        if ( v9 )
          break;
      }
    }
    if ( (unsigned int)v10 >= *(_DWORD *)(v9 + 24) )
      break;
    v24 = *((_QWORD *)v4 + 2);
    *(_DWORD *)(v9 + 4 * v10 + 32) = (_DWORD)a0;
    if ( v24 )
    {
      v25 = *(_DWORD *)(v24 + 24);
      v26 = v4[6] + v8;
      if ( v26 >= v25 )
        break;
      v27 = v24 + 4LL * v26;
      v28 = *((_QWORD *)v4 + 4);
      *(_DWORD *)(v27 + 32) = v5;
      if ( v28 )
      {
        v29 = v4[6] + v7;
        if ( v29 >= v25 )
          break;
        *(_DWORD *)(v24 + 4LL * v29 + 32) = v5 + *(_DWORD *)(v28 + 16) - 1;
        v4[6] += 3;
        return;
      }
    }
  }
LABEL_27:
  sub_63CF128(a0, *(_QWORD *)&a1, v17, v18);
}

