// Campus.Crowd.CrowdSystem$$SetBillboardResolution @ 0xddc4898
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Crowd_CrowdSystem__SetBillboardResolution(void *a0, int a1, void *a2)
{
  __int64 v3; // x8
  __int64 v4; // d0
  void *v5; // x0
  UnityEngine_Matrix4x4_o *v6; // x1
  void *v7; // x2
  UnityEngine_Vector3_o v8; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Vector4_o v9; // 0:s3.4,4:s4.4,8:s5.4,12:s6.4

  if ( a1 > 1 )
  {
    if ( a1 == 2 )
    {
      v3 = *((_QWORD *)a0 + 8);
      if ( v3 )
      {
        v4 = 0x4000000020LL;
        goto LABEL_14;
      }
    }
    else
    {
      if ( a1 != 3 )
        return;
      v3 = *((_QWORD *)a0 + 8);
      if ( v3 )
      {
        v4 = 0x8000000040LL;
        goto LABEL_14;
      }
    }
LABEL_16:
    v5 = (void *)sub_63CF120(a0, *(_QWORD *)&a1);
    Campus_Crowd_CrowdSystem__ScheduleJobs(v5, v6, v8, v9, v7);
    return;
  }
  if ( !a1 )
  {
    v3 = *((_QWORD *)a0 + 8);
    if ( v3 )
    {
      v4 = 0;
      goto LABEL_14;
    }
    goto LABEL_16;
  }
  if ( a1 != 1 )
    return;
  v3 = *((_QWORD *)a0 + 8);
  if ( !v3 )
    goto LABEL_16;
  v4 = 0x2000000010LL;
LABEL_14:
  *(_QWORD *)(v3 + 104) = v4;
}

