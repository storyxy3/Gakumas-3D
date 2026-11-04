// 0xd1d5fb8 @ 0xd1d5fb8
// local variable allocation has failed, the output may be wrong!
void __fastcall ProFlareUpdateElementJob__Execute(__int64 a0, int a1, void *a2)
{
  void *v5; // x0
  void *v6; // x2
  void *v7; // x3
  float r; // kr00_4
  __int64 v9; // x2
  void *v10; // x3
  float v11; // s0
  float v12; // s3
  float v13; // s4
  float v14; // s4
  _OWORD *v15; // x8
  __int128 v16; // [xsp+0h] [xbp+0h] OVERLAPPED
  __int128 v17; // [xsp+10h] [xbp+10h] OVERLAPPED
  __int128 v18; // [xsp+20h] [xbp+20h] OVERLAPPED
  __int64 v19; // [xsp+30h] [xbp+30h] BYREF
  __int64 v20; // [xsp+70h] [xbp+70h]
  __int64 v21; // [xsp+80h] [xbp+80h]
  float v22[6]; // [xsp+88h] [xbp+88h]
  __int64 v23; // [xsp+A0h] [xbp+A0h]
  float v24; // [xsp+A8h] [xbp+A8h]
  __int64 v25; // [xsp+D8h] [xbp+D8h] BYREF
  UnityEngine_Vector3_o v26; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Color_o v27; // 0:s1.4,4:s2.4,8:s3.4,12:s4.4

  v5 = memcpy((char *)&v19 + 4, (const void *)(*(_QWORD *)(a0 + 24) + 124LL * a1), 0x7Cu);
  r = ProFlareUpdateElementJob__GetElementColor((__int64)v5, (char *)&v19 + 4, v6).r;
  v25 = 0;
  if ( (v19 & 0x100000000LL) != 0 )
  {
    if ( (v20 & 1) != 0 )
    {
      ProFlareUpdateElementJob__GetOffsetPosition(a0, (char *)&v19 + 4, &v25, v7);
      v12 = *(float *)&v25;
    }
    else
    {
      v26.x = -(float)(*((float *)&v20 + 1) * *((float *)&v21 + 1));
      v26.y = -(float)(*((float *)&v20 + 1) * v22[0]);
      v26.z = -(float)(*((float *)&v20 + 1) * v22[1]);
      Unity_Mathematics_float3__op_Implicit_3(v26, nullptr);
      v12 = 0.0;
    }
    v13 = 0.0;
  }
  else
  {
    ProFlareUpdateElementJob__GetOffsetPosition(a0, (char *)&v19 + 4, (char *)&v25 + 4, v7);
    v12 = 0.0;
    v13 = *((float *)&v25 + 1);
  }
  v14 = (float)((float)((float)(v13 + (float)(*((float *)&v21 + 1) * *(float *)&v23)) + (float)(*(float *)&v23 * v22[0]))
              + *((float *)&v23 + 1))
      + v24;
  v27.b = v14 + v12;
  *((float *)&v25 + 1) = v14;
  v27.a = r;
  ProFlareUpdateElementJob__GetElementJobData(a0, (char *)&v19 + 4, v9, v11, v27, v10);
  v15 = (_OWORD *)(*(_QWORD *)(a0 + 40) + 48LL * a1);
  *v15 = *(__int128 *)((char *)&v16 + 4);
  v15[1] = *(__int128 *)((char *)&v17 + 4);
  v15[2] = *(__int128 *)((char *)&v18 + 4);
}

