// 0xbd02d68 @ 0xbd02d68
bool __fastcall VL_Core_VLActorController_object__object__object___Build(void *a0, void *a1, void *a2, void *a3)
{
  int v4; // w4
  void *v5; // x5
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  _BOOL8 v13; // x0
  __int64 v14; // x1
  bool v15; // w21
  bool result; // w0
  void *v17; // x0
  void *v18; // x1
  void *v19; // x2

  *((_QWORD *)a0 + 44) = a1;
  sub_63CEE24((char *)a0 + 352, (int)a1, (int)a2, (int)a3, v4, v5);
  *((_QWORD *)a0 + 45) = a2;
  sub_63CEE24((char *)a0 + 360, (int)a2, v9, v10, v11, v12);
  v13 = VL_Core_VLActorController_object__object__object___PreBuild(
          a0,
          *(void **)(*(_QWORD *)(*((_QWORD *)a3 + 4) + 192LL) + 160LL));
  v15 = v13;
  if ( !v13 )
    return v15;
  if ( a2 )
  {
    (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)a0 + 856LL))(
      a0,
      *((_QWORD *)a2 + 4),
      *(_QWORD *)(*(_QWORD *)a0 + 864LL));
    (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 888LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 896LL));
    (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 1176LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 1184LL));
    VL_Core_VLActorController_object__object__object___PostBuild(
      a0,
      *(void **)(*(_QWORD *)(*((_QWORD *)a3 + 4) + 192LL) + 176LL));
    return v15;
  }
  v17 = (void *)sub_63CF120(v13, v14);
  VL_Core_VLActorController_object__object__object___SetRootParts(v17, v18, v19);
  return result;
}

