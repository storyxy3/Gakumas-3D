// 0xd1d6138 @ 0xd1d6138
__int64 __fastcall ProFlareUpdateElementJob__GetOffsetPosition(__int64 a0, void *a1, void *a2, void *a3)
{
  float v4; // s2
  float v7; // s0
  float v8; // s8
  float v9; // s1
  float v10; // s9
  float v11; // s0
  float v12; // s10
  float v13; // s11
  float v14; // s0
  float v15; // s1
  float v16; // s8
  float v17; // s9
  __int64 result; // x0
  float v19; // s0
  float v20; // s8
  float v21; // s1
  float v22; // s9
  float v23; // s11
  float v24; // s13
  float v25; // s11
  float v26; // s13
  float v27; // s0
  UnityEngine_Vector3_o v28; // 0:s0.4,4:s1.4,8:s2.4

  v4 = *((float *)a1 + 16);
  v28.x = -(float)(v4 * *((float *)a1 + 20));
  v28.y = -(float)(v4 * *((float *)a1 + 21));
  v28.z = -(float)(v4 * *((float *)a1 + 22));
  Unity_Mathematics_float3__op_Implicit_3(v28, nullptr);
  v8 = v7;
  v10 = v9;
  Unity_Mathematics_float3__op_Implicit_3(*(UnityEngine_Vector3_o *)((char *)a1 + 80), nullptr);
  v12 = v11;
  v13 = COERCE_FLOAT(*((_QWORD *)a1 + 12));
  Unity_Mathematics_float3__op_Implicit_3(*(UnityEngine_Vector3_o *)((char *)a1 + 92), nullptr);
  v16 = v8 + (float)((float)(v12 - v8) * v14);
  v17 = v10 + (float)((float)(v13 - v10) * v15);
  result = Unity_Mathematics_float3__op_Implicit_3(*(UnityEngine_Vector3_o *)((char *)a1 + 68), nullptr);
  v20 = v16 + v19;
  v22 = v17 + v21;
  if ( *((_BYTE *)a1 + 104) )
  {
    v24 = *((float *)a1 + 20);
    v23 = *((float *)a1 + 21);
    if ( !byte_F4004BE[3] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004BE[3] = 1;
    }
    v25 = v23 - v22;
    v26 = v24 - v20;
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    v27 = atan2(v25, v26);
    *(float *)a2 = v27 * 57.296;
  }
  return result;
}

