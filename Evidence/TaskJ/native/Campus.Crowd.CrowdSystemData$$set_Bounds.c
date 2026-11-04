// Campus.Crowd.CrowdSystemData$$set_Bounds @ 0xddcb714
void __fastcall Campus_Crowd_CrowdSystemData__set_Bounds(void *a0, UnityEngine_Bounds_o *a1, void *a2)
{
  __int128 v3; // q0

  v3 = *(_OWORD *)&a1->c.x;
  *((_QWORD *)a0 + 21) = *(_QWORD *)&a1->e.y;
  *(_OWORD *)((char *)a0 + 152) = v3;
}

