// Campus.Crowd.CrowdMotionDefine$$get_count @ 0xddc367c
int __fastcall Campus_Crowd_CrowdMotionDefine__get_count(void *a0, void *a1)
{
  _BOOL8 IsNullOrEmpty_object; // x0
  __int64 v4; // x1
  int result; // w0
  __int64 v6; // x8
  void *v7; // x0
  void *v8; // x1
  int v9; // w2
  void *v10; // x3

  if ( (unk_F43BCEE & 1) == 0 )
  {
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_AnimationData___);
    unk_F43BCEE = 1;
  }
  IsNullOrEmpty_object = Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_object_(
                           *((void **)a0 + 9),
                           Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_AnimationData___);
  if ( IsNullOrEmpty_object )
    return 0;
  v6 = *((_QWORD *)a0 + 9);
  if ( v6 )
    return *(_DWORD *)(v6 + 24);
  v7 = (void *)sub_63CF120(IsNullOrEmpty_object, v4);
  Campus_Crowd_CrowdMotionDefine__SetAnimationData(v7, v8, v9, v10);
  return result;
}

