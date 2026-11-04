// Campus.Crowd.CrowdMotionDefine$$SetAnimationData @ 0xddc36e4
void __fastcall Campus_Crowd_CrowdMotionDefine__SetAnimationData(void *a0, void *a1, int a2, void *a3)
{
  __int64 *v7; // x22
  __int64 v8; // x0
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v13; // x0
  __int64 v14; // x1
  int v15; // w2
  int v16; // w3
  int v17; // w4
  void *v18; // x5
  _DWORD *v19; // x21
  _DWORD *v20; // x0
  __int64 v21; // x0
  void *v22; // x0
  void *v23; // x1

  if ( (unk_F43BCEF & 1) == 0 )
  {
    sub_63CEE78(&VL_AnimationData___TypeInfo);
    sub_63CEE78(&Method_System_Array_Resize_AnimationData___);
    sub_63CEE78(&Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_AnimationData___);
    unk_F43BCEF = 1;
  }
  v7 = (__int64 *)((char *)a0 + 72);
  if ( Qua_Extensions_IEnumerableExtensions__IsNullOrEmpty_object_(
         *((void **)a0 + 9),
         Method_Qua_Extensions_IEnumerableExtensions_IsNullOrEmpty_AnimationData___) )
  {
    v8 = sub_63CEF64(VL_AnimationData___TypeInfo, 1);
    *v7 = v8;
    sub_63CEE24((char *)a0 + 72, v8, v9, v10, v11, v12);
  }
  v13 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)a0 + 424LL))(a0, *(_QWORD *)(*(_QWORD *)a0 + 432LL));
  if ( (int)v13 <= a2 )
    System_Array__Resize_object_((char *)a0 + 72, a2 + 1, Method_System_Array_Resize_AnimationData___);
  v19 = (_DWORD *)*v7;
  if ( *v7 )
  {
    if ( a1 )
    {
      v13 = sub_63CEFF8(a1, *(_QWORD *)(*(_QWORD *)v19 + 64LL));
      if ( !v13 )
        goto LABEL_14;
    }
    if ( v19[6] > (unsigned int)a2 )
    {
      v20 = &v19[2 * a2];
      *((_QWORD *)v20 + 4) = a1;
      sub_63CEE24(v20 + 8, (int)a1, v15, v16, v17, v18);
      return;
    }
  }
  else
  {
    v13 = sub_63CF120(v13, v14);
  }
  sub_63CF128(v13, v14, v15, v16);
LABEL_14:
  v21 = sub_63CF144(v13);
  v22 = (void *)sub_63CEFE4(v21, 0);
  Campus_Crowd_CrowdMotionDefine___ctor(v22, v23);
}

