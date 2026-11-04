// 0xbd028a0 @ 0xbd028a0
void __fastcall VL_Core_VLActorController_object__object__object___AddDestroyParts(void *a0, void *a1, void *a2)
{
  __int64 v6; // x0
  void *v7; // x22
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  int v12; // w2
  int v13; // w3
  int v14; // w4
  void *v15; // x5
  __int64 v16; // x8
  __int64 v17; // x9
  __int64 v18; // x10
  __int64 v19; // x11
  __int64 v20; // x0
  void *v21; // x0
  void *v22; // x1

  if ( !*((_QWORD *)a0 + 47) )
  {
    v6 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 32LL);
    if ( (*(_WORD *)(v6 + 309) & 1) == 0 )
      sub_6407F00(v6);
    v7 = (void *)sub_63CF110(v6);
    System_Collections_Generic_List_object____ctor(v7, *(void **)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 40LL));
    *((_QWORD *)a0 + 47) = v7;
    sub_63CEE24((char *)a0 + 376, (int)v7, v8, v9, v10, v11);
  }
  if ( a1
    && (VL_Core_VLActorModelParts__SetRendererActive(a1, 0, nullptr), (v16 = *((_QWORD *)a0 + 47)) != 0)
    && (v17 = *(_QWORD *)(v16 + 16),
        v18 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 48LL),
        ++*(_DWORD *)(v16 + 28),
        v17) )
  {
    v19 = *(int *)(v16 + 24);
    if ( (unsigned int)v19 >= *(_DWORD *)(v17 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        (void *)v16,
        a1,
        *(void **)(*(_QWORD *)(*(_QWORD *)(v18 + 32) + 192LL) + 112LL));
    }
    else
    {
      v20 = v17 + 8 * v19;
      *(_DWORD *)(v16 + 24) = v19 + 1;
      *(_QWORD *)(v20 + 32) = a1;
      sub_63CEE24((void *)(v20 + 32), (int)a1, v12, v13, v14, v15);
    }
  }
  else
  {
    v21 = (void *)sub_63CF120(a0, a1);
    VL_Core_VLActorController_object__object__object___PreBuild(v21, v22);
  }
}

