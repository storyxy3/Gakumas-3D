// Campus.Live.Equipment.Environment.LiveLaser$$OnDisable @ 0xddb6c30
void __fastcall Campus_Live_Equipment_Environment_LiveLaser__OnDisable(void *a0, void *a1)
{
  void *v3; // x20
  __int64 v4; // x1
  void *v5; // x0
  void **v6; // x20
  void *v7; // x21
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  void *v12; // x0
  void *v13; // x1

  if ( (unk_F43BC74 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_LiveLaser_VertexLayout__Dispose__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ushort__Dispose___1);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_LiveLaser_VertexLayout__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeArray_ushort__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BC74 = 1;
  }
  Unity_Jobs_JobHandle__Complete((__int64)a0 + 168, nullptr);
  v3 = *((void **)a0 + 16);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
  {
    v5 = *((void **)a0 + 16);
    if ( !v5 )
      goto LABEL_18;
    UnityEngine_MeshFilter__set_sharedMesh(v5, nullptr, nullptr);
  }
  v6 = (void **)((char *)a0 + 120);
  v7 = *((void **)a0 + 15);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Inequality(v7, nullptr, nullptr) )
    goto LABEL_13;
  v5 = *v6;
  if ( !*v6 )
  {
LABEL_18:
    v12 = (void *)sub_63CF120(v5, v4);
    Campus_Live_Equipment_Environment_LiveLaser__UpdateMesh(v12, v13);
    return;
  }
  UnityEngine_Mesh__Clear_1(v5, nullptr);
  VL_VLUtility__DestroyObject(*v6, nullptr);
  *v6 = nullptr;
  sub_63CEE24((char *)a0 + 120, 0, v8, v9, v10, v11);
LABEL_13:
  if ( *((_QWORD *)a0 + 17) )
    Unity_Collections_NativeArray_LiveLaser_VertexLayout___Dispose_1(
      (__int64)a0 + 136,
      *((_QWORD *)a0 + 21),
      *((void **)a0 + 22));
  if ( *((_QWORD *)a0 + 19) )
    Unity_Collections_NativeArray_ushort___Dispose_1((__int64)a0 + 152, *((_QWORD *)a0 + 21), *((void **)a0 + 22));
}

