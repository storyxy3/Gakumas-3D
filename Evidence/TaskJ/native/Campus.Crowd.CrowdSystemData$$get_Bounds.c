// Campus.Crowd.CrowdSystemData$$get_Bounds @ 0xddcb700
UnityEngine_Bounds_o *__fastcall Campus_Crowd_CrowdSystemData__get_Bounds(
        UnityEngine_Bounds_o *__return_ptr retstr,
        void *a0,
        void *a1)
{
  __int64 v3; // x9

  v3 = *((_QWORD *)a0 + 21);
  *(_OWORD *)&retstr->c.x = *(_OWORD *)((char *)a0 + 152);
  *(_QWORD *)&retstr->e.y = v3;
  return (UnityEngine_Bounds_o *)a0;
}

