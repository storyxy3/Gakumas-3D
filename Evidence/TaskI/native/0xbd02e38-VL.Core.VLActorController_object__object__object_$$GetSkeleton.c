// 0xbd02e38 @ 0xbd02e38
__int64 __fastcall VL_Core_VLActorController_object__object__object___GetSkeleton(
        void *a0,
        void *a1,
        bool a2,
        void *a3)
{
  __int64 v4; // x8
  __int64 v7; // x19
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  __int64 result; // x0
  __int64 v13; // x8
  int v14; // s1
  float *v15; // x8
  float x; // s0
  float y; // s1
  float z; // s2
  float w; // s3
  __int64 v20; // x8
  int v21; // s1
  __int128 v22; // q2
  __int128 v23; // q1
  __int64 v24; // x8
  void *v25; // x0
  void *v26; // x1
  void *v27; // x2
  __int128 v28; // [xsp+0h] [xbp+0h] BYREF
  __int128 v29; // [xsp+10h] [xbp+10h]
  _BYTE v30[24]; // [xsp+20h] [xbp+20h]
  UnityEngine_Quaternion_o localRotation; // 0:kr10_16.16

  *(_QWORD *)&v30[16] = 0;
  v29 = 0u;
  *(_OWORD *)v30 = 0u;
  v28 = 0u;
  if ( a1 )
  {
    v7 = v4;
    *(_QWORD *)&v28 = UnityEngine_Object__get_name(a1, nullptr);
    sub_63CEE24(&v28, v28, v8, v9, v10, v11);
    if ( a2 )
    {
      if ( !byte_F40009D[0] )
      {
        result = sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
        byte_F40009D[0] = 1;
      }
      v13 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
      v14 = *(_DWORD *)(v13 + 8);
      *(_QWORD *)&v29 = *(_QWORD *)v13;
      DWORD2(v29) = v14;
      if ( !byte_F40034E[366] )
      {
        result = sub_63CEE78(&UnityEngine_Quaternion_TypeInfo);
        byte_F40034E[366] = 1;
      }
      v15 = *(float **)(UnityEngine_Quaternion_TypeInfo + 184LL);
      x = *v15;
      y = v15[1];
      z = v15[2];
      w = v15[3];
    }
    else
    {
      *(UnityEngine_Vector3_o *)&v29 = UnityEngine_Transform__get_localPosition(a1, nullptr);
      localRotation = UnityEngine_Transform__get_localRotation(a1, nullptr);
      x = localRotation.x;
      y = localRotation.y;
      z = localRotation.z;
      w = localRotation.w;
    }
    *((float *)&v29 + 3) = x;
    *(float *)v30 = y;
    *(float *)&v30[4] = z;
    *(float *)&v30[8] = w;
    if ( !byte_F40009D[436] )
    {
      result = sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
      byte_F40009D[436] = 1;
    }
    v20 = *(_QWORD *)(UnityEngine_Vector3_TypeInfo + 184LL);
    v21 = *(_DWORD *)(v20 + 20);
    *(_QWORD *)&v30[12] = *(_QWORD *)(v20 + 12);
    v22 = v29;
    *(_DWORD *)&v30[20] = v21;
    v23 = *(_OWORD *)v30;
    v24 = *(_QWORD *)&v30[16];
    *(_OWORD *)v7 = v28;
    *(_OWORD *)(v7 + 16) = v22;
    *(_OWORD *)(v7 + 32) = v23;
    *(_QWORD *)(v7 + 48) = v24;
  }
  else
  {
    v25 = (void *)sub_63CF120(a0, 0);
    return VL_Core_VLActorController_object__object__object___GetSkeleton_1(v25, v26, v27);
  }
  return result;
}

