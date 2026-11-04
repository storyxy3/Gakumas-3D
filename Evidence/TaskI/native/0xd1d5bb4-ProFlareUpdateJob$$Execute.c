// 0xd1d5bb4 @ 0xd1d5bb4
void __fastcall ProFlareUpdateJob__Execute(__int64 a0, int a1, __int64 a2, void *a3)
{
  __int64 v4; // x20
  __int64 v5; // x8
  float *v7; // x8
  float v8; // w21
  float v9; // s14
  unsigned int v10; // w21
  float v11; // s0
  float v12; // s12
  float v13; // s1
  float v14; // s13
  float v15; // s2
  float v16; // s11
  __int64 v17; // x1
  void *v18; // x2
  float v19; // s0
  float v20; // s1
  float v21; // s2
  float v22; // s8
  _BOOL4 v23; // w8
  float v24; // s10
  float v25; // s9
  bool v26; // nf
  _BOOL4 v27; // w9
  int v28; // w22
  __int64 v29; // x0
  __int64 v30; // x1
  __int64 v31; // x2
  void *v32; // x3
  float updated; // s0
  float v34; // s3
  float v35; // s11
  float v36; // s12
  __int64 v37; // x8
  unsigned int v38; // s0
  __int64 v39; // [xsp+0h] [xbp+0h] BYREF
  void *v40; // [xsp+8h] [xbp+8h]
  UnityEngine_Vector3_o position; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Quaternion_o rotation; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v4 = a1;
  v5 = *(_QWORD *)(a0 + 96);
  v39 = a2;
  v40 = a3;
  v7 = (float *)(v5 + 32LL * a1);
  v8 = *v7;
  v9 = v7[1];
  if ( UnityEngine_Jobs_TransformAccess__get_isValid((__int64)&v39, nullptr) && (LOBYTE(v8) & 1) != 0 )
  {
    v10 = LODWORD(v8) & 0xFFFFFF00;
    position = UnityEngine_Jobs_TransformAccess__get_position((__int64)&v39, nullptr);
    Unity_Mathematics_float3__op_Implicit_3(position, nullptr);
    v12 = v11;
    v14 = v13;
    v16 = v15;
    ProFlareUpdateJob__WorldToViewportPoint(a0, v17, v18);
    v22 = v19;
    v23 = 0;
    v24 = v20;
    v25 = v21;
    v26 = (float)(v9 + v19) > 0.0 && (float)(v19 - v9) < 1.0;
    if ( v26 && (float)(v9 + v20) > 0.0 )
      v23 = (float)(v20 - v9) < 1.0;
    v27 = v21 > 0.0;
    if ( *(_BYTE *)a0 )
      v27 = v21 < 1.0;
    v28 = v23 && v27;
    rotation = UnityEngine_Jobs_TransformAccess__get_rotation((__int64)&v39, nullptr);
    v29 = Unity_Mathematics_quaternion__op_Implicit_1(rotation, nullptr);
    updated = ProFlareUpdateJob__Angle(v29, v30, v31, v32);
    v34 = v16 - *(float *)(a0 + 12);
    v35 = updated;
    v36 = (float)(v34 * *(float *)(a0 + 24))
        + (float)((float)((float)(v12 - *(float *)(a0 + 4)) * *(float *)(a0 + 16))
                + (float)((float)(v14 - *(float *)(a0 + 8)) * *(float *)(a0 + 20)));
    v38 = COERCE_UNSIGNED_INT(UnityEngine_Jobs_TransformAccess__get_localScale((__int64)&v39, nullptr).x);
    v37 = *(_QWORD *)(a0 + 96) + 32 * v4;
    *(_DWORD *)v37 = v10 | v28;
    *(float *)(v37 + 4) = v9;
    *(float *)(v37 + 8) = v22;
    *(float *)(v37 + 12) = v24;
    *(float *)(v37 + 16) = v25;
    *(float *)(v37 + 20) = v35;
    *(float *)(v37 + 24) = v36;
    *(_DWORD *)(v37 + 28) = v38;
  }
}

