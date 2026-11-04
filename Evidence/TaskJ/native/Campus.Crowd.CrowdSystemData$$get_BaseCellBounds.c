// Campus.Crowd.CrowdSystemData$$get_BaseCellBounds @ 0xddcb728
UnityEngine_Bounds_o *__fastcall Campus_Crowd_CrowdSystemData__get_BaseCellBounds(
        UnityEngine_Bounds_o *__return_ptr retstr,
        void *a0,
        void *a1)
{
  __int64 v3; // x9

  v3 = *((_QWORD *)a0 + 24);
  *(_OWORD *)&retstr->c.x = *((_OWORD *)a0 + 11);
  *(_QWORD *)&retstr->e.y = v3;
  return (UnityEngine_Bounds_o *)a0;
}

