// 0xe0ddde4 @ 0xe0ddde4
void __fastcall VLB_GlobalMeshSD__Destroy(void *a0)
{
  void *v1; // x19
  void *v2; // x19
  int v3; // w2
  int v4; // w3
  int v5; // w4
  void *v6; // x5

  if ( (unk_F43DA85 & 1) == 0 )
  {
    sub_63CEE78(&VLB_GlobalMeshSD_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43DA85 = 1;
  }
  v1 = **(void ***)(VLB_GlobalMeshSD_TypeInfo + 184LL);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v1, nullptr, nullptr) )
  {
    v2 = **(void ***)(VLB_GlobalMeshSD_TypeInfo + 184LL);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    UnityEngine_Object__DestroyImmediate_1(v2, nullptr);
    **(_QWORD **)(VLB_GlobalMeshSD_TypeInfo + 184LL) = 0;
    sub_63CEE24(*(void **)(VLB_GlobalMeshSD_TypeInfo + 184LL), 0, v3, v4, v5, v6);
  }
}

