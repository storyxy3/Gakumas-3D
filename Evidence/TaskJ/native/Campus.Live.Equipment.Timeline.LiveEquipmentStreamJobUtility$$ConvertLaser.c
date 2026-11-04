// 0xddb2bc0 @ 0xddb2bc0
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall Campus_Live_Equipment_Timeline_LiveEquipmentStreamJobUtility__ConvertLaser(
        void *a0,
        void *a1,
        void *a2)
{
  void *v3; // x8
  void *v6; // x19
  int v7; // w9
  void *v8; // x2
  void *v9; // x2
  void *v10; // x3
  float v11; // s8
  float v12; // s8
  float v13; // s8
  unsigned int v14; // s0
  unsigned int v15; // s2
  __int128 v16; // q1
  __int128 v17; // q2
  double v19; // [xsp+8h] [xbp+8h] BYREF
  double v20; // [xsp+10h] [xbp+10h] BYREF
  int v21; // [xsp+1Ch] [xbp+1Ch] BYREF
  __int128 v22; // [xsp+30h] [xbp+30h] OVERLAPPED
  __int128 v23; // [xsp+40h] [xbp+40h] OVERLAPPED
  __int128 v24; // [xsp+50h] [xbp+50h]
  __int64 v25; // [xsp+90h] [xbp+90h]
  unsigned __int64 v26; // [xsp+98h] [xbp+98h]

  v6 = v3;
  if ( (unk_F43BC5C & 1) == 0 )
  {
    sub_63CEE78(&Method_Campus_Live_Equipment_EquipmentExtensions_IsFlag_LiveEquipmentAnimationData___);
    unk_F43BC5C = 1;
  }
  memset(&v21, 0, 0x84u);
  v7 = *((_DWORD *)a0 + 15);
  *(_QWORD *)((char *)&v24 + 4) = *(_QWORD *)((char *)a0 + 52);
  HIDWORD(v24) = v7;
  Campus_Live_Equipment_Timeline_LiveEquipmentStreamJobUtility__UpdateColor(a0, &v21, v8);
  Campus_Live_Equipment_Timeline_LiveEquipmentStreamJobUtility__UpdateIntensity(a0, &v21, v9);
  Campus_Live_Equipment_Timeline_LiveEquipmentStreamJobUtility__UpdateHVRotation(a0, &v21, a1, v10);
  if ( Campus_Live_Equipment_EquipmentExtensions__IsFlag_LiveEquipmentAnimationData_(
         a0,
         512,
         Method_Campus_Live_Equipment_EquipmentExtensions_IsFlag_LiveEquipmentAnimationData___) )
  {
    v11 = *((float *)a0 + 11);
    if ( !byte_F4004BE[1] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004BE[1] = 1;
    }
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    v12 = v11 * 3.1416;
    if ( !byte_F4004F4[0] )
    {
      sub_63CEE78(&System_Math_TypeInfo);
      byte_F4004F4[0] = 1;
    }
    v13 = v12 + v12;
    if ( !*(_DWORD *)(System_Math_TypeInfo + 228LL) )
      sub_63CEFF4(System_Math_TypeInfo);
    sincos((float)(v13 * 0.5), &v20, &v19);
    *(float *)&v14 = v20;
    *(float *)&v15 = v19;
    v26 = __PAIR64__(v15, v14);
    *(float *)&v25 = *(float *)&v14 * 0.0;
    *((float *)&v25 + 1) = *(float *)&v14 * 0.0;
  }
  v17 = *((_OWORD *)a0 + 6);
  v16 = *((_OWORD *)a0 + 7);
  LODWORD(v22) = *((_DWORD *)a0 + 8);
  *(__int128 *)((char *)&v23 + 4) = v16;
  *(__int128 *)((char *)&v22 + 4) = v17;
  return (__int64)memcpy(v6, &v21, 0x84u);
}

