// 0xd1ccd00 @ 0xd1ccd00
bool __fastcall ProFlareRenderingSystem__TryGetFlareData(void *a0, void *a1, void *a2, void *a3)
{
  int v4; // w4
  void *v5; // x5
  char *v9; // x22
  void *v10; // x23
  void *main; // x23
  __int64 v12; // x0
  __int64 v13; // x1
  void *v14; // x23
  void *v15; // x23
  __int64 v16; // x8
  void *v17; // x23
  void *v18; // x6
  void *v20; // x2
  void *v21; // x4
  void *v22; // x1
  int v23; // w3
  void *v24; // x5

  if ( (unk_F42C91E & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_ProFlareBatchForSRP___);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F42C91E = 1;
  }
  *(_QWORD *)a2 = 0;
  sub_63CEE24(a2, 0, (int)a2, (int)a3, v4, v5);
  v9 = (char *)a0 + 32;
  v10 = *((void **)a0 + 4);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v10, nullptr, nullptr) )
  {
    main = UnityEngine_Camera__get_main(nullptr);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    if ( UnityEngine_Object__op_Inequality(main, nullptr, nullptr) )
    {
      v12 = (__int64)UnityEngine_Camera__get_main(nullptr);
      if ( !v12 )
      {
LABEL_27:
        v12 = sub_63CF120(v12, v13);
        return ProFlareBatchForSRP__TryGetScheduledFlareData((void *)v12, v22, v20, v23, v21, v24, v18);
      }
      UnityEngine_Component__TryGetComponent_object_(
        (void *)v12,
        (char *)a0 + 32,
        Method_UnityEngine_Component_TryGetComponent_ProFlareBatchForSRP___);
    }
  }
  v14 = *(void **)v9;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v12 = UnityEngine_Object__op_Equality(v14, nullptr, nullptr);
  if ( (v12 & 1) != 0 )
    return 0;
  if ( !*(_QWORD *)v9 )
    goto LABEL_27;
  v15 = *(void **)(*(_QWORD *)v9 + 40LL);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v12 = UnityEngine_Object__op_Equality(v15, nullptr, nullptr);
  if ( (v12 & 1) != 0 )
    return 0;
  if ( !*(_QWORD *)v9 )
    goto LABEL_27;
  v16 = *(_QWORD *)(*(_QWORD *)v9 + 40LL);
  if ( !v16 )
    goto LABEL_27;
  v17 = *(void **)(v16 + 32);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v17, nullptr, nullptr) )
    return 0;
  v12 = *(_QWORD *)v9;
  if ( !*(_QWORD *)v9 )
    goto LABEL_27;
  v20 = *((void **)a0 + 2);
  v21 = *((void **)a0 + 3);
  v22 = a1;
  v23 = *((_DWORD *)a0 + 10);
  v24 = a2;
  return ProFlareBatchForSRP__TryGetScheduledFlareData((void *)v12, v22, v20, v23, v21, v24, v18);
}

