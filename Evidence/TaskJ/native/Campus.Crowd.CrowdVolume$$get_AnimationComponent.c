// Campus.Crowd.CrowdVolume$$get_AnimationComponent @ 0xddc9dc0
void *__fastcall Campus_Crowd_CrowdVolume__get_AnimationComponent(void *a0, void *a1)
{
  void *Component_object; // x21
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43BD45 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_GetComponent_ICrowdAnimation___);
    unk_F43BD45 = 1;
  }
  Component_object = *((void **)a0 + 16);
  if ( !Component_object )
  {
    Component_object = UnityEngine_Component__GetComponent_object_(
                         a0,
                         Method_UnityEngine_Component_GetComponent_ICrowdAnimation___);
    *((_QWORD *)a0 + 16) = Component_object;
    sub_63CEE24((char *)a0 + 128, (int)Component_object, v4, v5, v6, v7);
  }
  return Component_object;
}

