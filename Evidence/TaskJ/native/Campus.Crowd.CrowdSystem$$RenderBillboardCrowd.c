// Campus.Crowd.CrowdSystem$$RenderBillboardCrowd @ 0xddc56b4
void __fastcall Campus_Crowd_CrowdSystem__RenderBillboardCrowd(void *a0, void *a1, void *a2, int a3, void *a4)
{
  __int64 v9; // x8
  void *v10; // x1
  void *Value; // x0
  int TotalSubMeshInstanceCount; // w0
  void *v13; // x24
  int v14; // w23
  void *v15; // x22
  void *v16; // x7
  void *v17; // x0
  __int64 v18; // x1
  void *v19; // x2
  void *v20; // x3
  __int128 v21; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43BD1C & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_IsCreated__);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_Value__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD1C = 1;
  }
  v21 = 0u;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) )
  {
    if ( *((_QWORD *)a0 + 4) )
    {
      v9 = *((_QWORD *)a0 + 10);
      if ( v9 )
      {
        if ( *((_QWORD *)a0 + 8) )
        {
          v21 = *(_OWORD *)(v9 + 128);
          if ( Unity_Collections_NativeReference_int___get_IsCreated(
                 (__int64)&v21,
                 Method_Unity_Collections_NativeReference_int__get_IsCreated__)
            && Unity_Collections_NativeReference_int___get_Value(
                 (__int64)&v21,
                 Method_Unity_Collections_NativeReference_int__get_Value__) >= 1 )
          {
            Value = *((void **)a0 + 10);
            if ( Value
              && (TotalSubMeshInstanceCount = Campus_Crowd_CrowdSystemData__get_TotalSubMeshInstanceCount(Value, v10),
                  v13 = *((void **)a0 + 8),
                  v14 = TotalSubMeshInstanceCount,
                  v15 = *((void **)a0 + 4),
                  Value = (void *)Unity_Collections_NativeReference_int___get_Value(
                                    (__int64)&v21,
                                    Method_Unity_Collections_NativeReference_int__get_Value__),
                  v13) )
            {
              Campus_Crowd_BillboardMeshRenderSystem__RenderBillboard(v13, a1, a2, v15, v14, (int)Value, a3, v16);
            }
            else
            {
              v17 = (void *)sub_63CF120(Value, v10);
              Campus_Crowd_CrowdRendererFeature__OnRenderGBuffer(v17, v18, v19, v20);
            }
          }
        }
      }
    }
  }
}

