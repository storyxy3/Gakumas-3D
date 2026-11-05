// Campus.Timeline.CampusVolumeTimelineBehaviour$$ResetVolumePriority @ 0xdd7e738
void __fastcall Campus_Timeline_CampusVolumeTimelineBehaviour__ResetVolumePriority(void *a0, void *a1)
{
  void *v3; // x20
  _BOOL8 v4; // x0
  __int64 v5; // x1
  __int64 v6; // x8
  void *v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  void *v10; // x3
  void *v11; // x4

  if ( (unk_F43BAD7 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BAD7 = 1;
  }
  v3 = *((void **)a0 + 4);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  v4 = UnityEngine_Object__op_Inequality(v3, nullptr, nullptr);
  if ( v4 )
  {
    v6 = *((_QWORD *)a0 + 4);
    if ( v6 )
    {
      *(_DWORD *)(v6 + 36) = *((_DWORD *)a0 + 10);
    }
    else
    {
      v7 = (void *)sub_63CF120(v4, v5);
      Campus_Timeline_CampusVolumeTimelineMixerBehaviour__ProcessFrame(v7, v8, v9, v10, v11);
    }
  }
}

