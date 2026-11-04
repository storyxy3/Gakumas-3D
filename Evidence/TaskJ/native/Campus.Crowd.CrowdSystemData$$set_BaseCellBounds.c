// Campus.Crowd.CrowdSystemData$$set_BaseCellBounds @ 0xddcb73c
void __fastcall Campus_Crowd_CrowdSystemData__set_BaseCellBounds(void *a0, UnityEngine_Bounds_o *a1, void *a2)
{
  __int128 v3; // q0

  v3 = *(_OWORD *)&a1->c.x;
  *((_QWORD *)a0 + 24) = *(_QWORD *)&a1->e.y;
  *((_OWORD *)a0 + 11) = v3;
}

