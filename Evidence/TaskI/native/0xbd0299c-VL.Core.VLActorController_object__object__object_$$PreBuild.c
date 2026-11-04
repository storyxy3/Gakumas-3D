// 0xbd0299c @ 0xbd0299c
bool __fastcall VL_Core_VLActorController_object__object__object___PreBuild(void *a0, void *a1)
{
  __int64 *descriptor; // x0
  __int64 v5; // x1
  __int64 v6; // x8
  __int64 *v7; // x21
  __int64 v8; // x9
  _DWORD *v9; // x10
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 *v12; // x20
  __int64 v13; // x9
  _DWORD *v14; // x10
  __int64 v15; // x0
  void *v16; // x0
  void *v17; // x2
  bool result; // w0
  void *v19; // x20
  void *v20; // x0
  void *v21; // x1

  if ( (unk_F41D5F9 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&VL_IVLActorDescriptor_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    sub_63CEE78(&StringLiteral_descripter_gameObject_not_found);
    unk_F41D5F9 = 1;
  }
  descriptor = (__int64 *)VL_Core_VLActorController_object__object__object___get_descriptor(
                            a0,
                            *(void **)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 56LL));
  if ( descriptor )
  {
    v6 = *descriptor;
    v7 = descriptor;
    v8 = *(unsigned __int16 *)(*descriptor + 302);
    if ( *(_WORD *)(*descriptor + 302) )
    {
      v9 = (_DWORD *)(*(_QWORD *)(v6 + 176) + 8LL);
      while ( *((_QWORD *)v9 - 1) != VL_IVLActorDescriptor_TypeInfo )
      {
        --v8;
        v9 += 4;
        if ( !v8 )
          goto LABEL_8;
      }
      v10 = v6 + 16LL * (*v9 + 2) + 312;
    }
    else
    {
LABEL_8:
      v10 = sub_6408234(descriptor, VL_IVLActorDescriptor_TypeInfo, 2);
    }
    if ( !(*(__int64 (__fastcall **)(__int64 *, _QWORD))v10)(v7, *(_QWORD *)(v10 + 8)) )
    {
      if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Debug_TypeInfo);
      UnityEngine_Debug__LogError(StringLiteral_descripter_gameObject_not_found, nullptr);
      return 0;
    }
    descriptor = (__int64 *)VL_Core_VLActorController_object__object__object___get_descriptor(
                              a0,
                              *(void **)(*(_QWORD *)(*((_QWORD *)a1 + 4) + 192LL) + 56LL));
    if ( descriptor )
    {
      v11 = *descriptor;
      v12 = descriptor;
      v13 = *(unsigned __int16 *)(*descriptor + 302);
      if ( *(_WORD *)(*descriptor + 302) )
      {
        v14 = (_DWORD *)(*(_QWORD *)(v11 + 176) + 8LL);
        while ( *((_QWORD *)v14 - 1) != VL_IVLActorDescriptor_TypeInfo )
        {
          --v13;
          v14 += 4;
          if ( !v13 )
            goto LABEL_16;
        }
        v15 = v11 + 16LL * (*v14 + 2) + 312;
      }
      else
      {
LABEL_16:
        v15 = sub_6408234(descriptor, VL_IVLActorDescriptor_TypeInfo, 2);
      }
      v16 = (void *)(*(__int64 (__fastcall **)(__int64 *, _QWORD))v15)(v12, *(_QWORD *)(v15 + 8));
      if ( VL_Core_VLActorController_object__object__object___CheckResourceObjects(v16, v16, v17) )
        return 1;
      (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 1160LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 1168LL));
      v19 = *((void **)a0 + 44);
      if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
        sub_63CEFF4(UnityEngine_Object_TypeInfo);
      if ( !UnityEngine_Object__op_Inequality(v19, nullptr, nullptr) )
        return 0;
      descriptor = *((__int64 **)a0 + 44);
      if ( descriptor )
      {
        (*(void (__fastcall **)(__int64 *, _QWORD, void *, _QWORD))(*descriptor + 376))(
          descriptor,
          0,
          a0,
          *(_QWORD *)(*descriptor + 384));
        return 0;
      }
    }
  }
  v20 = (void *)sub_63CF120(descriptor, v5);
  VL_Core_VLActorController_object__object__object___PostBuild(v20, v21);
  return result;
}

