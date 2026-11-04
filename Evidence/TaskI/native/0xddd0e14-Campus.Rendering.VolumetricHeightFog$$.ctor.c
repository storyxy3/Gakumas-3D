// Campus.Rendering.VolumetricHeightFog$$.ctor @ 0xddd0e14
void __fastcall Campus_Rendering_VolumetricHeightFog___ctor(void *a0, void *a1)
{
  void *v3; // x20
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43BD63 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Rendering_BoolParameter_TypeInfo);
    unk_F43BD63 = 1;
  }
  v3 = (void *)sub_63CF110(UnityEngine_Rendering_BoolParameter_TypeInfo);
  UnityEngine_Rendering_BoolParameter___ctor(v3, 0, 0, nullptr);
  *((_QWORD *)a0 + 7) = v3;
  sub_63CEE24((char *)a0 + 56, (int)v3, v4, v5, v6, v7);
  UnityEngine_Rendering_VolumeComponent___ctor(a0, nullptr);
}

