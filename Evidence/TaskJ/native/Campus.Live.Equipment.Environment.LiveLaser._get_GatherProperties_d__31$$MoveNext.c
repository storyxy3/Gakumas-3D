// Campus.Live.Equipment.Environment.LiveLaser.<get_GatherProperties>d__31$$MoveNext @ 0xddb7fa8
bool __fastcall Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31__MoveNext(void *a0, void *a1)
{
  _QWORD *v2; // x19
  __int64 v3; // x20
  void *v4; // x1
  __int64 v5; // x0
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5
  bool result; // w0
  void *v11; // x1
  __int64 v12; // x0
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  int v17; // w8
  void *transform; // x0
  __int64 v19; // x0
  void *v20; // x19
  int v21; // w2
  int v22; // w3
  int v23; // w4
  void *v24; // x5
  int v25; // w8
  void *v26; // x21
  void *v27; // x1
  __int64 v28; // x0
  int v29; // w2
  int v30; // w3
  int v31; // w4
  void *v32; // x5
  void *v33; // x1
  __int64 v34; // x0
  int v35; // w2
  int v36; // w3
  int v37; // w4
  void *v38; // x5
  void *v39; // x1
  __int64 v40; // x0
  int v41; // w2
  int v42; // w3
  int v43; // w4
  void *v44; // x5
  void *v45; // x1
  __int64 v46; // x0
  int v47; // w2
  int v48; // w3
  int v49; // w4
  void *v50; // x5
  void *v51; // x1
  __int64 v52; // x0
  int v53; // w2
  int v54; // w3
  int v55; // w4
  void *v56; // x5
  void *v57; // x1
  __int64 v58; // x0
  int v59; // w2
  int v60; // w3
  int v61; // w4
  void *v62; // x5
  void *v63; // x1
  __int64 v64; // x0
  int v65; // w2
  int v66; // w3
  int v67; // w4
  void *v68; // x5
  void *v69; // x21
  void *v70; // x1
  __int64 v71; // x0
  int v72; // w2
  int v73; // w3
  int v74; // w4
  void *v75; // x5
  void *v76; // x21
  void *v77; // x1
  __int64 v78; // x0
  int v79; // w2
  int v80; // w3
  int v81; // w4
  void *v82; // x5
  void *v83; // x1
  __int64 v84; // x0
  int v85; // w2
  int v86; // w3
  int v87; // w4
  void *v88; // x5
  void *v89; // x0
  void *v90; // x1
  __int128 v91; // [xsp+0h] [xbp+0h] BYREF
  __int128 v92; // [xsp+10h] [xbp+10h] BYREF

  v2 = a0;
  if ( (unk_F43BC7B & 1) == 0 )
  {
    sub_63CEE78(&Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&StringLiteral_lightType);
    sub_63CEE78(&StringLiteral_laserCount);
    sub_63CEE78(&StringLiteral_laserAngle);
    sub_63CEE78(&StringLiteral_radius);
    sub_63CEE78(&StringLiteral_m_LocalRotation);
    sub_63CEE78(&StringLiteral_animationTime);
    sub_63CEE78(&StringLiteral_color);
    sub_63CEE78(&StringLiteral_length);
    sub_63CEE78(&StringLiteral_m_Enabled);
    sub_63CEE78(&StringLiteral_laserType);
    a0 = (void *)sub_63CEE78(&StringLiteral_randomSpeed);
    unk_F43BC7B = 1;
  }
  v3 = v2[5];
  switch ( *((_DWORD *)v2 + 4) )
  {
    case 0:
      v4 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
        (__int64)&v92,
        v4,
        StringLiteral_animationTime,
        nullptr);
      v91 = v92;
      v5 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v5;
      sub_63CEE24(v2 + 3, v5, v6, v7, v8, v9);
      result = 1;
      *((_DWORD *)v2 + 4) = 1;
      return result;
    case 1:
      v51 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v51, StringLiteral_color, nullptr);
      v91 = v92;
      v52 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v52;
      sub_63CEE24(v2 + 3, v52, v53, v54, v55, v56);
      v17 = 2;
      goto LABEL_35;
    case 2:
      v33 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v33, StringLiteral_laserType, nullptr);
      v91 = v92;
      v34 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v34;
      sub_63CEE24(v2 + 3, v34, v35, v36, v37, v38);
      v17 = 3;
      goto LABEL_35;
    case 3:
      v39 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v39, StringLiteral_lightType, nullptr);
      v91 = v92;
      v40 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v40;
      sub_63CEE24(v2 + 3, v40, v41, v42, v43, v44);
      v17 = 4;
      goto LABEL_35;
    case 4:
      v11 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v11, StringLiteral_laserCount, nullptr);
      v91 = v92;
      v12 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v12;
      sub_63CEE24(v2 + 3, v12, v13, v14, v15, v16);
      v17 = 5;
      goto LABEL_35;
    case 5:
      v57 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v57, StringLiteral_laserAngle, nullptr);
      v91 = v92;
      v58 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v58;
      sub_63CEE24(v2 + 3, v58, v59, v60, v61, v62);
      v17 = 6;
      goto LABEL_35;
    case 6:
      v63 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v63, StringLiteral_radius, nullptr);
      v91 = v92;
      v64 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v64;
      sub_63CEE24(v2 + 3, v64, v65, v66, v67, v68);
      v17 = 7;
      goto LABEL_35;
    case 7:
      v45 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor((__int64)&v92, v45, StringLiteral_length, nullptr);
      v91 = v92;
      v46 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v46;
      sub_63CEE24(v2 + 3, v46, v47, v48, v49, v50);
      v17 = 8;
      goto LABEL_35;
    case 8:
      v83 = (void *)v2[5];
      *((_DWORD *)v2 + 4) = -1;
      v92 = 0u;
      Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
        (__int64)&v92,
        v83,
        StringLiteral_randomSpeed,
        nullptr);
      v91 = v92;
      v84 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
      v2[3] = v84;
      sub_63CEE24(v2 + 3, v84, v85, v86, v87, v88);
      v17 = 9;
LABEL_35:
      *((_DWORD *)v2 + 4) = v17;
      goto LABEL_36;
    case 9:
      *((_DWORD *)v2 + 4) = -1;
      if ( !v3 )
        goto LABEL_38;
      v26 = *(void **)(v3 + 56);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( UnityEngine_Object__op_Inequality(v26, nullptr, nullptr) )
      {
        v27 = *(void **)(v3 + 56);
        v92 = 0u;
        Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
          (__int64)&v92,
          v27,
          StringLiteral_m_LocalRotation,
          nullptr);
        v91 = v92;
        v28 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
        v2[3] = v28;
        v20 = v2 + 3;
        sub_63CEE24(v20, v28, v29, v30, v31, v32);
        v25 = 10;
        goto LABEL_32;
      }
LABEL_24:
      v69 = *(void **)(v3 + 64);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( UnityEngine_Object__op_Inequality(v69, nullptr, nullptr) )
      {
        v70 = *(void **)(v3 + 64);
        v92 = 0u;
        Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
          (__int64)&v92,
          v70,
          StringLiteral_m_LocalRotation,
          nullptr);
        v91 = v92;
        v71 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
        v2[3] = v71;
        v20 = v2 + 3;
        sub_63CEE24(v20, v71, v72, v73, v74, v75);
        v25 = 11;
        goto LABEL_32;
      }
LABEL_28:
      v76 = *(void **)(v3 + 48);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( UnityEngine_Object__op_Inequality(v76, nullptr, nullptr) )
      {
        v77 = *(void **)(v3 + 48);
        v92 = 0u;
        Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
          (__int64)&v92,
          v77,
          StringLiteral_m_Enabled,
          nullptr);
        v91 = v92;
        v78 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
        v2[3] = v78;
        v20 = v2 + 3;
        sub_63CEE24(v20, v78, v79, v80, v81, v82);
        v25 = 12;
        goto LABEL_32;
      }
LABEL_33:
      result = 0;
      break;
    case 0xA:
      *((_DWORD *)v2 + 4) = -1;
      if ( v3 )
        goto LABEL_24;
      goto LABEL_38;
    case 0xB:
      *((_DWORD *)v2 + 4) = -1;
      if ( !v3 )
        goto LABEL_38;
      goto LABEL_28;
    case 0xC:
      *((_DWORD *)v2 + 4) = -1;
      if ( v3 && (a0 = *(void **)(v3 + 48)) != nullptr )
      {
        transform = UnityEngine_Component__get_transform(a0, nullptr);
        v92 = 0u;
        Campus_Live_Equipment_LiveEquipmentComponentProperty___ctor(
          (__int64)&v92,
          transform,
          StringLiteral_m_LocalRotation,
          nullptr);
        v91 = v92;
        v19 = sub_63CEFFC(Campus_Live_Equipment_LiveEquipmentComponentProperty_TypeInfo, &v91);
        v2[3] = v19;
        v20 = v2 + 3;
        sub_63CEE24(v20, v19, v21, v22, v23, v24);
        v25 = 13;
LABEL_32:
        *((_DWORD *)v20 - 2) = v25;
LABEL_36:
        result = 1;
      }
      else
      {
LABEL_38:
        v89 = (void *)sub_63CF120(a0, a1);
        result = (unsigned __int8)Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31__System_Collections_Generic_IEnumerator_Campus_Live_Equipment_ILiveEquipmentProperty__get_Current(
                                    v89,
                                    v90);
      }
      break;
    case 0xD:
      result = 0;
      *((_DWORD *)v2 + 4) = -1;
      return result;
    default:
      goto LABEL_33;
  }
  return result;
}

