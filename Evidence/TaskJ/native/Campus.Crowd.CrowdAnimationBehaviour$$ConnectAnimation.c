// Campus.Crowd.CrowdAnimationBehaviour$$ConnectAnimation @ 0xddbf8f8
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__ConnectAnimation(
        void *a0,
        int a1,
        void *a2,
        double a3,
        float a4,
        int a5,
        void *a6)
{
  _DWORD *v13; // x24
  void *v14; // x23
  void *v15; // x22
  __int64 v16; // x0
  __int64 v17; // x1
  int v18; // w2
  int v19; // w3
  int v20; // w4
  void *v21; // x5
  _DWORD *v22; // x0
  __int64 v23; // x0
  void *v24; // x0
  int v25; // w1
  void *v26; // x2
  float v27; // s0

  if ( (unk_F43BCC6 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_ClipData_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BCC6 = 1;
  }
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( !UnityEngine_Object__op_Equality(a2, nullptr, nullptr) && (a1 & 0x80000000) == 0 )
  {
    v13 = *((_DWORD **)a0 + 20);
    if ( v13 )
    {
      if ( v13[6] > a1 )
      {
        v14 = *((void **)a0 + 24);
        v15 = (void *)sub_63CF110(Campus_Crowd_ClipData_TypeInfo);
        Campus_Crowd_ClipData___ctor(v15, v14, a1 + 1, a2, a3, a4, a5, 0, nullptr);
        if ( !v15 || (v16 = sub_63CEFF8(v15, *(_QWORD *)(*(_QWORD *)v13 + 64LL))) != 0 )
        {
          if ( v13[6] > (unsigned int)a1 )
          {
            v22 = &v13[2 * a1];
            *((_QWORD *)v22 + 4) = v15;
            sub_63CEE24(v22 + 8, (int)v15, v18, v19, v20, v21);
            return;
          }
          sub_63CF128(v16, v17, v18, v19);
        }
        v23 = sub_63CF144(v16);
        v24 = (void *)sub_63CEFE4(v23, 0);
        Campus_Crowd_CrowdAnimationBehaviour__SetAnimationWeight(v24, v25, v27, v26);
      }
    }
  }
}

