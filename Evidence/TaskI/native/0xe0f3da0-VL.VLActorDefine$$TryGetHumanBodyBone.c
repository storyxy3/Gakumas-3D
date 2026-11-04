// VL.VLActorDefine$$TryGetHumanBodyBone @ 0xe0f3da0
bool __fastcall VL_VLActorDefine__TryGetHumanBodyBone(void *a0, void *a1, void *a2)
{
  __int64 v5; // x0
  void *v6; // x0
  int v8; // w0
  void *v9; // x1

  if ( (unk_F43DB8C & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_string__HumanBodyBones__TryGetValue__);
    sub_63CEE78(&VL_VLActorDefine_TypeInfo);
    unk_F43DB8C = 1;
  }
  v5 = VL_VLActorDefine_TypeInfo;
  *(_DWORD *)a1 = 0;
  if ( !*(_DWORD *)(v5 + 228) )
  {
    sub_63CEFF4(v5);
    v5 = VL_VLActorDefine_TypeInfo;
  }
  v6 = *(void **)(*(_QWORD *)(v5 + 184) + 64LL);
  if ( v6 )
    return System_Collections_Generic_Dictionary_object__Int32Enum___TryGetValue(
             v6,
             a0,
             a1,
             Method_System_Collections_Generic_Dictionary_string__HumanBodyBones__TryGetValue__);
  v8 = sub_63CF120(0, a1);
  return (unsigned __int8)VL_VLActorDefine__HumanBodyToString(v8, v9);
}

