// Campus.Crowd.PenlightMeshRenderSystem$$Dispose @ 0xddcb208
void __fastcall Campus_Crowd_PenlightMeshRenderSystem__Dispose(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x20
  __int64 v5; // x0
  __int64 v6; // x8
  void *v7; // x21
  void *v8; // x22
  __int64 v9; // x0
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  void *v14; // x20
  void *v15; // x19

  if ( (unk_F43BD34 & 1) == 0 )
  {
    sub_63CEE78(&System_Action_GraphicsBuffer__TypeInfo);
    sub_63CEE78(&Method_Campus_Common_Extensions_EnumerableExtensions_ForEach_GraphicsBuffer___);
    sub_63CEE78(&Campus_Common_Extensions_EnumerableExtensions_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&Method_Campus_Crowd_PenlightMeshRenderSystem___c__Dispose_b__26_0__);
    sub_63CEE78(&Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo);
    unk_F43BD34 = 1;
  }
  v3 = *((void **)a0 + 5);
  if ( v3 )
    UnityEngine_GraphicsBuffer__Dispose(v3, nullptr);
  v4 = *((void **)a0 + 6);
  if ( v4 )
  {
    v5 = Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo;
    if ( !*(_DWORD *)(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo + 228LL) )
    {
      sub_63CEFF4(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo);
      v5 = Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo;
    }
    v6 = *(_QWORD *)(v5 + 184);
    v7 = *(void **)(v6 + 8);
    if ( !v7 )
    {
      if ( !*(_DWORD *)(v5 + 228) )
      {
        sub_63CEFF4(v5);
        v6 = *(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo + 184LL);
      }
      v8 = *(void **)v6;
      v7 = (void *)sub_63CF110(System_Action_GraphicsBuffer__TypeInfo);
      System_Action_object____ctor(v7, v8, Method_Campus_Crowd_PenlightMeshRenderSystem___c__Dispose_b__26_0__, nullptr);
      v9 = *(_QWORD *)(Campus_Crowd_PenlightMeshRenderSystem___c_TypeInfo + 184LL);
      *(_QWORD *)(v9 + 8) = v7;
      sub_63CEE24((void *)(v9 + 8), (int)v7, v10, v11, v12, v13);
    }
    if ( !*(_DWORD *)(Campus_Common_Extensions_EnumerableExtensions_TypeInfo + 228LL) )
      sub_63CEFF4(Campus_Common_Extensions_EnumerableExtensions_TypeInfo);
    Campus_Common_Extensions_EnumerableExtensions__ForEach_object__1(
      v4,
      v7,
      Method_Campus_Common_Extensions_EnumerableExtensions_ForEach_GraphicsBuffer___);
  }
  v14 = *((void **)a0 + 3);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v14, nullptr, nullptr) )
  {
    v15 = *((void **)a0 + 3);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    UnityEngine_Object__DestroyImmediate_1(v15, nullptr);
  }
}

