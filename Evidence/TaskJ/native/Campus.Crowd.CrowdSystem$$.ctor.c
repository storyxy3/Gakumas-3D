// Campus.Crowd.CrowdSystem$$.ctor @ 0xddc4264
void __fastcall Campus_Crowd_CrowdSystem___ctor(void *a0, void *a1, void *a2)
{
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  __int64 v9; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void *v14; // x20
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  __int64 v19; // x20
  __int64 v20; // x8
  __int64 v21; // x0
  __int64 v22; // x0
  void *v23; // x20
  void *v24; // x21
  void *v25; // x2
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5

  if ( (unk_F43BD12 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Array_Empty_Color___);
    sub_63CEE78(&Campus_AudiencePenlight_DefaultAudiencePenlight_TypeInfo);
    sub_63CEE78(&UnityEngine_MaterialPropertyBlock_TypeInfo);
    sub_63CEE78(&UnityEngine_Plane___TypeInfo);
    unk_F43BD12 = 1;
  }
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 2) = a1;
  sub_63CEE24((char *)a0 + 16, (int)a1, v5, v6, v7, v8);
  v9 = sub_63CEF64(UnityEngine_Plane___TypeInfo, 6);
  *((_QWORD *)a0 + 3) = v9;
  sub_63CEE24((char *)a0 + 24, v9, v10, v11, v12, v13);
  v14 = (void *)sub_63CF110(UnityEngine_MaterialPropertyBlock_TypeInfo);
  UnityEngine_MaterialPropertyBlock___ctor(v14, nullptr);
  *((_QWORD *)a0 + 4) = v14;
  sub_63CEE24((char *)a0 + 32, (int)v14, v15, v16, v17, v18);
  v19 = Method_System_Array_Empty_Color___;
  v20 = *(_QWORD *)(Method_System_Array_Empty_Color___ + 56LL);
  if ( !v20 )
  {
    sub_6407F5C();
    v20 = *(_QWORD *)(v19 + 56);
  }
  v21 = *(_QWORD *)(v20 + 16);
  if ( (*(_WORD *)(v21 + 309) & 1) == 0 )
    sub_6407F00(v21);
  if ( !*(_DWORD *)(v21 + 228) )
    sub_63CEFF4(v21);
  v22 = *(_QWORD *)(*(_QWORD *)(v19 + 56) + 16LL);
  if ( (*(_WORD *)(v22 + 309) & 1) == 0 )
    sub_6407F00(v22);
  v23 = **(void ***)(v22 + 184);
  v24 = (void *)sub_63CF110(Campus_AudiencePenlight_DefaultAudiencePenlight_TypeInfo);
  Campus_AudiencePenlight_DefaultAudiencePenlight___ctor(v24, v23, v25);
  *((_QWORD *)a0 + 14) = v24;
  sub_63CEE24((char *)a0 + 112, (int)v24, v26, v27, v28, v29);
}

