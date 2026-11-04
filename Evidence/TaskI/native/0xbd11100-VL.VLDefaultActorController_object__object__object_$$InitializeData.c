// 0xbd11100 @ 0xbd11100
void __fastcall VL_VLDefaultActorController_object__object__object___InitializeData(void *a0, void *a1)
{
  _QWORD *v2; // x19
  void *v3; // x0
  void *v4; // x20
  int v5; // w2
  int v6; // w3
  int v7; // w4
  void *v8; // x5
  void *v9; // x0
  void *v10; // x1

  v2 = a0;
  if ( (unk_F41D64C & 1) == 0 )
  {
    sub_63CEE78(&VL_Core_HumanBodyBoneMapDictionary_TypeInfo);
    a0 = (void *)sub_63CEE78(&Method_VL_Core_SerializedDictionary_HumanBodyBones__Transform__Clear__);
    unk_F41D64C = 1;
  }
  if ( v2 )
  {
    VL_Core_VLActorController__InitializeData(v2, nullptr);
    v3 = (void *)v2[53];
    if ( v3 )
    {
      VL_Core_SerializedDictionary_Int32Enum__object___Clear(
        v3,
        Method_VL_Core_SerializedDictionary_HumanBodyBones__Transform__Clear__);
    }
    else
    {
      v4 = (void *)sub_63CF110(VL_Core_HumanBodyBoneMapDictionary_TypeInfo);
      VL_Core_HumanBodyBoneMapDictionary___ctor(v4, nullptr);
      v2[53] = v4;
      sub_63CEE24(v2 + 53, (int)v4, v5, v6, v7, v8);
    }
  }
  else
  {
    v9 = (void *)sub_63CF120(a0, a1);
    VL_VLDefaultActorController_object__object__object___BuildAvatar(v9, v10);
  }
}

