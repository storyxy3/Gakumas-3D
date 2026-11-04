// Campus.Crowd.CrowdSystemData$$EqualData @ 0xddc9960
bool __fastcall Campus_Crowd_CrowdSystemData__EqualData(void *a0, void *a1, void *a2)
{
  void *v5; // x20

  if ( (unk_F43BD2A & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD2A = 1;
  }
  v5 = *((void **)a0 + 2);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  return UnityEngine_Object__op_Equality(a1, v5, nullptr);
}

