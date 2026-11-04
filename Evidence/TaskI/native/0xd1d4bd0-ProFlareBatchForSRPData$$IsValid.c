// 0xd1d4bd0 @ 0xd1d4bd0
bool __fastcall ProFlareBatchForSRPData__IsValid(void *a0, void *a1)
{
  void *v3; // x20
  void *v4; // x20

  if ( (unk_F42C950 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_float4__get_IsCreated__);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F42C950 = 1;
  }
  v3 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Inequality(v3, nullptr, nullptr) )
    return 0;
  v4 = *((void **)a0 + 4);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  return UnityEngine_Object__op_Inequality(v4, nullptr, nullptr) && *((_QWORD *)a0 + 11) && *((_DWORD *)a0 + 55) >= 0;
}

