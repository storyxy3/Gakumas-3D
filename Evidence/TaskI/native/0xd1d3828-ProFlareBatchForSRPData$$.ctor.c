// 0xd1d3828 @ 0xd1d3828
void __fastcall ProFlareBatchForSRPData___ctor(void *a0, void *a1, void *a2, void *a3)
{
  void *v7; // x22
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  void *v12; // x22
  int v13; // w2
  int v14; // w3
  int v15; // w4
  void *v16; // x5
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5
  int v21; // w2
  int v22; // w3
  int v23; // w4
  void *v24; // x5
  void *v25; // x20
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5

  if ( (unk_F42C947 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_MaterialPropertyBlock_TypeInfo);
    sub_63CEE78(&UnityEngine_Rendering_ProfilingSampler_TypeInfo);
    sub_63CEE78(&StringLiteral_ComputeProFlare);
    sub_63CEE78(&StringLiteral_Draw_ProFlare);
    unk_F42C947 = 1;
  }
  v7 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v7, StringLiteral_ComputeProFlare, nullptr);
  *((_QWORD *)a0 + 2) = v7;
  sub_63CEE24((char *)a0 + 16, (int)v7, v8, v9, v10, v11);
  v12 = (void *)sub_63CF110(UnityEngine_Rendering_ProfilingSampler_TypeInfo);
  UnityEngine_Rendering_ProfilingSampler___ctor(v12, StringLiteral_Draw_ProFlare, nullptr);
  *((_QWORD *)a0 + 3) = v12;
  sub_63CEE24((char *)a0 + 24, (int)v12, v13, v14, v15, v16);
  System_Object___ctor(a0, nullptr);
  *((_QWORD *)a0 + 4) = a1;
  sub_63CEE24((char *)a0 + 32, (int)a1, v17, v18, v19, v20);
  *((_QWORD *)a0 + 5) = a2;
  sub_63CEE24((char *)a0 + 40, (int)a2, v21, v22, v23, v24);
  v25 = (void *)sub_63CF110(UnityEngine_MaterialPropertyBlock_TypeInfo);
  UnityEngine_MaterialPropertyBlock___ctor(v25, nullptr);
  *((_QWORD *)a0 + 9) = v25;
  sub_63CEE24((char *)a0 + 72, (int)v25, v26, v27, v28, v29);
}

