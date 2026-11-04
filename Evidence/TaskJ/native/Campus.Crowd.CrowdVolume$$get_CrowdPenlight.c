// Campus.Crowd.CrowdVolume$$get_CrowdPenlight @ 0xddca648
void *__fastcall Campus_Crowd_CrowdVolume__get_CrowdPenlight(void *a0, void *a1)
{
  void *Component_object; // x21
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43BD46 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_GetComponent_ICrowdPenlight___);
    unk_F43BD46 = 1;
  }
  Component_object = *((void **)a0 + 17);
  if ( !Component_object )
  {
    Component_object = UnityEngine_Component__GetComponent_object_(
                         a0,
                         Method_UnityEngine_Component_GetComponent_ICrowdPenlight___);
    *((_QWORD *)a0 + 17) = Component_object;
    sub_63CEE24((char *)a0 + 136, (int)Component_object, v4, v5, v6, v7);
  }
  return Component_object;
}

