// Campus.Crowd.CrowdSystemData$$UpdatePersonIndexBuffer @ 0xddc9fe4
void __fastcall Campus_Crowd_CrowdSystemData__UpdatePersonIndexBuffer(void *a0, void *a1, void *a2)
{
  int TotalSubMeshInstanceCount; // w20
  __int64 Value; // x0
  __int64 v6; // x1
  void *v7; // x0
  void *v8; // x1
  void *v9; // x2
  __int128 v10; // [xsp+0h] [xbp+0h] BYREF

  if ( (unk_F43BD22 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_GraphicsBuffer_SetData_uint____1);
    sub_63CEE78(&Method_Unity_Collections_NativeReference_int__get_Value__);
    unk_F43BD22 = 1;
  }
  v10 = 0u;
  TotalSubMeshInstanceCount = Campus_Crowd_CrowdSystemData__get_TotalSubMeshInstanceCount(a0, a1);
  v10 = *((_OWORD *)a0 + 8);
  Value = Unity_Collections_NativeReference_int___get_Value(
            (__int64)&v10,
            Method_Unity_Collections_NativeReference_int__get_Value__);
  if ( *((_QWORD *)a0 + 6) )
  {
    UnityEngine_GraphicsBuffer__SetData_uint__1(
      *((void **)a0 + 6),
      *((_QWORD *)a0 + 12),
      *((_QWORD *)a0 + 13),
      0,
      0,
      (void *)(unsigned int)(Value + TotalSubMeshInstanceCount));
  }
  else
  {
    v7 = (void *)sub_63CF120(Value, v6);
    Campus_Crowd_CrowdSystemData__ComputeUpdatePerson(v7, v8, v9);
  }
}

