// Campus.Live.Equipment.Environment.LiveLaser$$UpdateInitialData @ 0xddb71e4
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__UpdateInitialData(void *a0, void *a1, void *a2)
{
  void *transform; // x0
  __int64 v6; // x1
  int v7; // s0
  int v8; // s8
  int v9; // s1
  int v10; // s9
  int v11; // s2
  int v12; // s10
  int v13; // s3
  int v14; // s11
  void *v15; // x21
  int v16; // s0
  int v17; // s1
  int v18; // s2
  void *v19; // x0
  void *v20; // x1
  void *v21; // x2
  UnityEngine_Vector3_o position; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Quaternion_o rotation; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4
  UnityEngine_Quaternion_o v24; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  if ( (unk_F43BC78 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BC78 = 1;
  }
  transform = UnityEngine_Component__get_transform(a0, nullptr);
  if ( !transform )
    goto LABEL_12;
  rotation = UnityEngine_Transform__get_rotation(transform, nullptr);
  v24 = UnityEngine_Quaternion__Inverse(rotation, nullptr);
  Unity_Mathematics_quaternion__op_Implicit_1(v24, nullptr);
  v8 = v7;
  v10 = v9;
  v12 = v11;
  v14 = v13;
  v15 = *((void **)a0 + 8);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v15, nullptr, nullptr) )
  {
    transform = *((void **)a0 + 8);
    if ( !transform )
      goto LABEL_12;
  }
  else
  {
    transform = UnityEngine_Component__get_transform(a0, nullptr);
    if ( !transform )
      goto LABEL_12;
  }
  position = UnityEngine_Transform__get_position(transform, nullptr);
  transform = (void *)Unity_Mathematics_float3__op_Implicit_3(position, nullptr);
  if ( a1 )
  {
    *((_DWORD *)a1 + 1) = v16;
    *((_DWORD *)a1 + 2) = v17;
    *((_DWORD *)a1 + 3) = v18;
    *((_DWORD *)a1 + 4) = v8;
    *((_DWORD *)a1 + 5) = v10;
    *((_DWORD *)a1 + 6) = v12;
    *((_DWORD *)a1 + 7) = v14;
    return;
  }
LABEL_12:
  v19 = (void *)sub_63CF120(transform, v6);
  Campus_Live_Equipment_Environment_LiveLaser__OnApply(v19, v20, v21);
}

