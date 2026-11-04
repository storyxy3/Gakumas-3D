// 0xe0e3514 @ 0xe0e3514
bool __fastcall VLB_Utils__TestPlanesAABB(__int64 a0, UnityEngine_Bounds_o *a1, void *a2)
{
  float v3; // s4
  unsigned __int64 v4; // x9
  float v5; // s5
  float v6; // s6
  bool v7; // w8
  float v8; // s7
  float v9; // s16
  float *v10; // x10
  float v11; // s0
  float v12; // s3
  float v13; // s1
  float v14; // s2
  float v15; // s4
  float v16; // s5
  float v17; // s17
  float v18; // s18
  float v19; // s6
  float v20; // s19
  float v21; // s20
  float v22; // s16
  float v23; // s21
  float v24; // s17
  float v25; // s22
  float v26; // s18
  float v27; // s7
  bool v28; // cc

  v3 = *((float *)a2 + 1);
  v4 = 0;
  v5 = *((float *)a2 + 2);
  v6 = *((float *)a2 + 3);
  v7 = 0;
  v8 = *((float *)a2 + 4);
  v9 = *((float *)a2 + 5);
  v10 = (float *)(a0 + 8);
  v11 = *(float *)a2 - v6;
  v12 = *(float *)a2 + v6;
  v13 = v3 - v8;
  v14 = v5 - v9;
  v15 = v3 + v8;
  v16 = v5 + v9;
  do
  {
    v17 = *(v10 - 2);
    v18 = *(v10 - 1);
    v19 = v10[1];
    v20 = v11 * v17;
    v21 = v14 * *v10;
    v22 = (float)(v11 * v17) + (float)(v13 * v18);
    if ( (float)(v19 + (float)(v21 + v22)) <= 0.0 )
    {
      v23 = v12 * v17;
      v24 = (float)(v12 * v17) + (float)(v13 * v18);
      if ( (float)(v19 + (float)(v21 + v24)) <= 0.0 )
      {
        v25 = v15 * v18;
        v26 = v20 + (float)(v15 * v18);
        if ( (float)(v19 + (float)(v21 + v26)) <= 0.0 && (float)(v19 + (float)(v21 + (float)(v23 + v25))) <= 0.0 )
        {
          v27 = v16 * *v10;
          if ( (float)(v19 + (float)(v27 + v22)) <= 0.0
            && (float)(v19 + (float)(v27 + v24)) <= 0.0
            && (float)(v19 + (float)(v27 + v26)) <= 0.0
            && (float)(v19 + (float)(v27 + (float)(v23 + v25))) <= 0.0 )
          {
            break;
          }
        }
      }
    }
    v28 = v4++ > 4;
    v10 += 4;
    v7 = v28;
  }
  while ( v4 != 6 );
  return v7;
}

