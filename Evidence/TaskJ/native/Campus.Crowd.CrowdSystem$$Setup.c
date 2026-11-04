// 0xddc43c8 @ 0xddc43c8
void __fastcall Campus_Crowd_CrowdSystem__Setup(void *a0, void *a1, void *a2, void *a3, void *a4, void *a5, void *a6)
{
  char *v13; // x24
  void *v14; // x26
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  void *v19; // x26
  bool v20; // w25
  void *v21; // x27
  _BOOL8 v22; // x0
  __int64 v23; // x1
  int v24; // w2
  int v25; // w3
  void *v26; // x4
  void *v27; // x5
  void *v28; // x4
  void *v29; // x0
  void *v30; // x1

  if ( (unk_F43BD13 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD13 = 1;
  }
  v13 = (char *)a0 + 40;
  v14 = *((void **)a0 + 5);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v14, a1, nullptr) )
    goto LABEL_9;
  v19 = *(void **)v13;
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Equality(v19, nullptr, nullptr) )
  {
LABEL_9:
    *(_QWORD *)v13 = a1;
    sub_63CEE24((char *)a0 + 40, (int)a1, v15, v16, v17, v18);
    v20 = 1;
  }
  else
  {
    v20 = 0;
  }
  v21 = *((void **)a0 + 6);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v22 = UnityEngine_Object__op_Inequality(v21, a2, nullptr);
  if ( v22 )
  {
    *((_QWORD *)a0 + 6) = a2;
    sub_63CEE24((char *)a0 + 48, (int)a2, v24, v25, (int)v26, v27);
    v20 = 1;
  }
  if ( *(_QWORD *)v13 )
  {
    Campus_Crowd_CrowdSystem__Setup_1(
      a0,
      *(void **)(*(_QWORD *)v13 + 80LL),
      *(void **)(*(_QWORD *)v13 + 88LL),
      v20,
      v26);
    Campus_Crowd_CrowdSystem__SetupCompute(a0, a3, a4, a5, v28);
  }
  else
  {
    v29 = (void *)sub_63CF120(v22, v23);
    Campus_Crowd_CrowdSystem__IsActive(v29, v30);
  }
}

