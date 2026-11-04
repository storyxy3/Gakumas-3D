// VL.VLActorDefine$$IsBone @ 0xe0f3d3c
bool __fastcall VL_VLActorDefine__IsBone(void *a0, void *a1)
{
  void *v2; // x19
  void *v4; // x0
  void *v5; // x1
  void *v6; // x2
  __int64 v7; // [xsp+8h] [xbp+8h] BYREF

  v2 = a0;
  if ( (unk_F43DB8A & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_Renderer___);
    unk_F43DB8A = 1;
  }
  v7 = 0;
  if ( v2 )
    return !UnityEngine_Component__TryGetComponent_object_(
              v2,
              &v7,
              Method_UnityEngine_Component_TryGetComponent_Renderer___);
  v4 = (void *)sub_63CF120(a0, a1);
  return VL_VLActorDefine__TryGetHumanBodyBone(v4, v5, v6);
}

