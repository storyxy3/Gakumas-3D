// 0xbd0243c @ 0xbd0243c
bool __fastcall VL_Core_VLActorController_object__object__object___CheckResourceObjects(void *a0, void *a1, void *a2)
{
  void *v4; // x19
  __int64 v5; // x8
  __int64 v6; // x9
  int *v7; // x10
  __int64 v8; // x0
  int v9; // w21
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x20
  __int64 v13; // x8
  __int64 v14; // x9
  int *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x0
  __int64 v18; // x1
  __int64 v19; // x20
  __int64 v20; // x8
  __int64 v21; // x9
  int *v22; // x10
  __int64 v23; // x0
  void *v24; // x20
  __int64 v25; // x0
  __int64 v26; // x1
  void *name; // x0
  void *v28; // x1
  int v29; // w22
  void *v30; // x1
  void *v31; // x19
  __int64 v32; // x20
  __int64 v33; // x8
  __int64 v34; // x9
  int *v35; // x10
  __int64 v36; // x0
  __int64 v38; // [xsp+8h] [xbp+8h]
  __int64 *v39; // [xsp+10h] [xbp+10h]
  __int64 v40; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F41D5F8 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_HashSet_string__Add__);
    sub_63CEE78(&Method_System_Collections_Generic_HashSet_string___ctor__);
    sub_63CEE78(&System_Collections_Generic_HashSet_string__TypeInfo);
    sub_63CEE78(&System_IDisposable_TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerable_GameObject__TypeInfo);
    sub_63CEE78(&System_Collections_Generic_IEnumerator_GameObject__TypeInfo);
    sub_63CEE78(&System_Collections_IEnumerator_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&StringLiteral________________);
    sub_63CEE78(&StringLiteral__________________________);
    unk_F41D5F8 = 1;
  }
  v40 = 0;
  v4 = (void *)sub_63CF110(System_Collections_Generic_HashSet_string__TypeInfo);
  System_Collections_Generic_HashSet_object____ctor(v4, Method_System_Collections_Generic_HashSet_string___ctor__);
  if ( !a1 )
  {
    v9 = 0;
    return v9 > 0;
  }
  v5 = *(_QWORD *)a1;
  v6 = *(unsigned __int16 *)(*(_QWORD *)a1 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)a1 + 302LL) )
  {
    v7 = (int *)(*(_QWORD *)(v5 + 176) + 8LL);
    while ( *((_QWORD *)v7 - 1) != System_Collections_Generic_IEnumerable_GameObject__TypeInfo )
    {
      --v6;
      v7 += 4;
      if ( !v6 )
        goto LABEL_8;
    }
    v8 = v5 + 16LL * *v7 + 312;
  }
  else
  {
LABEL_8:
    v8 = sub_6408234(a1, System_Collections_Generic_IEnumerable_GameObject__TypeInfo, 0);
  }
  v10 = (*(__int64 (__fastcall **)(void *, _QWORD))v8)(a1, *(_QWORD *)(v8 + 8));
  v40 = v10;
  v38 = 0;
  v39 = &v40;
  if ( v10 )
  {
    v12 = v10;
    v9 = 0;
    while ( 1 )
    {
      v13 = *(_QWORD *)v12;
      v14 = *(unsigned __int16 *)(*(_QWORD *)v12 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v12 + 302LL) )
      {
        v15 = (int *)(*(_QWORD *)(v13 + 176) + 8LL);
        while ( *((_QWORD *)v15 - 1) != System_Collections_IEnumerator_TypeInfo )
        {
          --v14;
          v15 += 4;
          if ( !v14 )
            goto LABEL_17;
        }
        v16 = v13 + 16LL * *v15 + 312;
      }
      else
      {
LABEL_17:
        v16 = sub_6408234(v12, System_Collections_IEnumerator_TypeInfo, 0);
      }
      v17 = (*(__int64 (__fastcall **)(__int64, _QWORD))v16)(v12, *(_QWORD *)(v16 + 8));
      if ( (v17 & 1) == 0 )
        goto LABEL_35;
      v19 = v40;
      if ( !v40 )
        break;
      v20 = *(_QWORD *)v40;
      v21 = *(unsigned __int16 *)(*(_QWORD *)v40 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v40 + 302LL) )
      {
        v22 = (int *)(*(_QWORD *)(v20 + 176) + 8LL);
        while ( *((_QWORD *)v22 - 1) != System_Collections_Generic_IEnumerator_GameObject__TypeInfo )
        {
          --v21;
          v22 += 4;
          if ( !v21 )
            goto LABEL_25;
        }
        v23 = v20 + 16LL * *v22 + 312;
      }
      else
      {
LABEL_25:
        v23 = sub_6408234(v40, System_Collections_Generic_IEnumerator_GameObject__TypeInfo, 0);
      }
      v24 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))v23)(v19, *(_QWORD *)(v23 + 8));
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      v25 = UnityEngine_Object__op_Equality(v24, nullptr, nullptr);
      if ( (v25 & 1) != 0 )
      {
        if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Debug_TypeInfo);
        UnityEngine_Debug__LogError(StringLiteral________________, nullptr);
        goto LABEL_42;
      }
      if ( !v24 )
        goto LABEL_55;
      name = UnityEngine_Object__get_name(v24, nullptr);
      v28 = name;
      if ( !v4 )
        goto LABEL_56;
      v10 = System_Collections_Generic_HashSet_object___Add(
              v4,
              name,
              Method_System_Collections_Generic_HashSet_string__Add__);
      if ( (v10 & 1) == 0 )
      {
        v30 = UnityEngine_Object__get_name(v24, nullptr);
        v31 = System_String__Concat_2(StringLiteral__________________________, v30, nullptr);
        if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
          sub_63CEFF4(UnityEngine_Debug_TypeInfo);
        UnityEngine_Debug__LogError(v31, nullptr);
LABEL_42:
        v29 = 6;
        goto LABEL_43;
      }
      v12 = v40;
      ++v9;
      if ( !v40 )
        goto LABEL_34;
    }
    v25 = sub_63CF120(v17, v18);
LABEL_55:
    name = (void *)sub_63CF120(v25, v26);
LABEL_56:
    v10 = sub_63CF120(name, v28);
  }
  v9 = 0;
LABEL_34:
  sub_63CF120(v10, v11);
LABEL_35:
  v29 = 2;
LABEL_43:
  v32 = v40;
  if ( v40 )
  {
    v33 = *(_QWORD *)v40;
    v34 = *(unsigned __int16 *)(*(_QWORD *)v40 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v40 + 302LL) )
    {
      v35 = (int *)(*(_QWORD *)(v33 + 176) + 8LL);
      while ( *((_QWORD *)v35 - 1) != System_IDisposable_TypeInfo )
      {
        --v34;
        v35 += 4;
        if ( !v34 )
          goto LABEL_48;
      }
      v36 = v33 + 16LL * *v35 + 312;
    }
    else
    {
LABEL_48:
      v36 = sub_6408234(v40, System_IDisposable_TypeInfo, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v36)(v32, *(_QWORD *)(v36 + 8));
  }
  if ( (v29 | 2) == 2 )
    return v9 > 0;
  return 0;
}

