// Campus.Timeline.CampusVolumeTimelineBehaviour$$OffsetVolumePriority @ 0xdd7e6ac
void __fastcall Campus_Timeline_CampusVolumeTimelineBehaviour__OffsetVolumePriority(void *a0, float a1, void *a2)
{
  void *v5; // x20
  _BOOL8 v6; // x0
  __int64 v7; // x1
  __int64 v8; // x8
  void *v9; // x0
  void *v10; // x1

  if ( (unk_F43BAD6 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BAD6 = 1;
  }
  v5 = *((void **)a0 + 4);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v6 = UnityEngine_Object__op_Inequality(v5, nullptr, nullptr);
  if ( v6 )
  {
    v8 = *((_QWORD *)a0 + 4);
    if ( v8 )
    {
      *(float *)(v8 + 36) = *((float *)a0 + 10) + a1;
    }
    else
    {
      v9 = (void *)sub_63CF120(v6, v7);
      Campus_Timeline_CampusVolumeTimelineBehaviour__ResetVolumePriority(v9, v10);
    }
  }
}

