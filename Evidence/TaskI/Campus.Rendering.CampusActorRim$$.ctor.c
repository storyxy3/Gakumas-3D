// Campus.Rendering.CampusActorRim$$.ctor @ 0xddd33b0
void __fastcall Campus_Rendering_CampusActorRim___ctor(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x20
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  void *v9; // x20
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void *v14; // x0
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
  UnityEngine_Vector2_o v30; // 0:s0.4,4:s1.4
  UnityEngine_Color_o v31; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BD7F & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_ClampedFloatParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ColorParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_MinFloatParameter_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_Vector2Parameter_TypeInfo);
    unk_F43BD7F = 1;
  }
  v3 = (void *)sub_63CF110(UnityEngine_Rendering_ColorParameter_TypeInfo);
  v31.r = 1.0;
  v31.g = 1.0;
  v31.b = 1.0;
  v31.a = 1.0;
  v4 = v3;
  UnityEngine_Rendering_ColorParameter___ctor_1(v3, v31, 0, 0, 0, 0, nullptr);
  *((_QWORD *)a0 + 7) = v4;
  sub_63CEE24((char *)a0 + 56, (int)v4, v5, v6, v7, v8);
  v9 = (void *)sub_63CF110(UnityEngine_Rendering_MinFloatParameter_TypeInfo);
  UnityEngine_Rendering_MinFloatParameter___ctor(v9, 0.0, 0.0, 0, nullptr);
  *((_QWORD *)a0 + 8) = v9;
  sub_63CEE24((char *)a0 + 64, (int)v9, v10, v11, v12, v13);
  v14 = (void *)sub_63CF110(UnityEngine_Rendering_Vector2Parameter_TypeInfo);
  v30.x = 0.0;
  v30.y = 0.0;
  v15 = v14;
  UnityEngine_Rendering_Vector2Parameter___ctor(v14, v30, 0, nullptr);
  *((_QWORD *)a0 + 9) = v15;
  sub_63CEE24((char *)a0 + 72, (int)v15, v16, v17, v18, v19);
  v20 = (void *)sub_63CF110(UnityEngine_Rendering_ClampedFloatParameter_TypeInfo);
  UnityEngine_Rendering_ClampedFloatParameter___ctor(v20, 1.0, 0.0, 1.0, 0, nullptr);
  *((_QWORD *)a0 + 10) = v20;
  sub_63CEE24((char *)a0 + 80, (int)v20, v21, v22, v23, v24);
  v25 = (void *)sub_63CF110(UnityEngine_Rendering_ClampedFloatParameter_TypeInfo);
  UnityEngine_Rendering_ClampedFloatParameter___ctor(v25, 8.0, 1.0, 32.0, 0, nullptr);
  *((_QWORD *)a0 + 11) = v25;
  sub_63CEE24((char *)a0 + 88, (int)v25, v26, v27, v28, v29);
  UnityEngine_Rendering_VolumeComponent___ctor(a0, nullptr);
}

