// Campus.Crowd.CrowdAnimator.<>c$$<.ctor>b__21_1 @ 0xddc3634
UnityEngine_Vector3_o __fastcall Campus_Crowd_CrowdAnimator___c____ctor_b__21_1(void *a0, void *a1, void *a2)
{
  __int64 v3; // x30
  __int64 v7; // [xsp+0h] [xbp+0h]
  UnityEngine_Vector3_o result; // 0:s0.4,4:s1.4,8:s2.4

  if ( !a1 )
  {
    *(&v7 - 2) = v3;
    sub_63CF120(a0, 0);
    JUMPOUT(0xDDC364C);
  }
  result.x = *((float *)a1 + 5);
  result.y = *((float *)a1 + 6);
  result.z = *((float *)a1 + 7);
  return result;
}

