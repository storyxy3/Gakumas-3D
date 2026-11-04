// Campus.Crowd.Crowd$$.ctor @ 0xddbee34
void __fastcall Campus_Crowd_Crowd___ctor(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x2
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  void *v9; // x0
  void *v10; // x20
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  void *v15; // x20
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  void *v20; // x20
  int v21; // w2
  int v22; // w3
  int v23; // w4
  void *v24; // x5
  void *v25; // x20
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5
  void *v30; // x20
  int v31; // w2
  int v32; // w3
  int v33; // w4
  void *v34; // x5
  void *v35; // x20
  void *v36; // x3
  int v37; // w2
  int v38; // w3
  int v39; // w4
  void *v40; // x5
  UnityEngine_Vector3_o v41; // 0:s0.4,4:s1.4,8:s2.4

  if ( (unk_F43BCC0 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_BillboardQualityParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ClampedFloatParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ClampedIntParameter_TypeInfo);
    sub_63CEE78(&Campus_Crowd_CrowdVolumeParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_FloatParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_MinFloatParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_Vector3Parameter_TypeInfo);
    unk_F43BCC0 = 1;
  }
  v3 = (void *)sub_63CF110(Campus_Crowd_CrowdVolumeParameter_TypeInfo);
  Campus_Crowd_CrowdVolumeParameter___ctor(v3, nullptr, v4);
  *((_QWORD *)a0 + 7) = v3;
  sub_63CEE24((char *)a0 + 56, (int)v3, v5, v6, v7, v8);
  v9 = (void *)sub_63CF110(UnityEngine_Rendering_Vector3Parameter_TypeInfo);
  v41.x = 0.0;
  v41.y = 0.0;
  v41.z = 0.0;
  v10 = v9;
  UnityEngine_Rendering_Vector3Parameter___ctor(v9, v41, 0, nullptr);
  *((_QWORD *)a0 + 8) = v10;
  sub_63CEE24((char *)a0 + 64, (int)v10, v11, v12, v13, v14);
  v15 = (void *)sub_63CF110(UnityEngine_Rendering_FloatParameter_TypeInfo);
  UnityEngine_Rendering_FloatParameter___ctor(v15, -1000.0, 0, nullptr);
  *((_QWORD *)a0 + 9) = v15;
  sub_63CEE24((char *)a0 + 72, (int)v15, v16, v17, v18, v19);
  v20 = (void *)sub_63CF110(UnityEngine_Rendering_ClampedIntParameter_TypeInfo);
  UnityEngine_Rendering_ClampedIntParameter___ctor(v20, 1024, 0, 0x8000, 0, nullptr);
  *((_QWORD *)a0 + 10) = v20;
  sub_63CEE24((char *)a0 + 80, (int)v20, v21, v22, v23, v24);
  v25 = (void *)sub_63CF110(UnityEngine_Rendering_MinFloatParameter_TypeInfo);
  UnityEngine_Rendering_MinFloatParameter___ctor(v25, 0.6, 0.0, 0, nullptr);
  *((_QWORD *)a0 + 11) = v25;
  sub_63CEE24((char *)a0 + 88, (int)v25, v26, v27, v28, v29);
  v30 = (void *)sub_63CF110(UnityEngine_Rendering_ClampedFloatParameter_TypeInfo);
  UnityEngine_Rendering_ClampedFloatParameter___ctor(v30, 0.0, 0.0, 1.0, 0, nullptr);
  *((_QWORD *)a0 + 12) = v30;
  sub_63CEE24((char *)a0 + 96, (int)v30, v31, v32, v33, v34);
  v35 = (void *)sub_63CF110(Campus_Crowd_BillboardQualityParameter_TypeInfo);
  Campus_Crowd_BillboardQualityParameter___ctor(v35, 2, 0, v36);
  *((_QWORD *)a0 + 13) = v35;
  sub_63CEE24((char *)a0 + 104, (int)v35, v37, v38, v39, v40);
  UnityEngine_Rendering_VolumeComponent___ctor(a0, nullptr);
}

