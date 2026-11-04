// Campus.Crowd.CrowdAnimationTimeline$$SetPenlightProjectionUvRect @ 0xddc295c
void __fastcall Campus_Crowd_CrowdAnimationTimeline__SetPenlightProjectionUvRect(
        void *a0,
        UnityEngine_Vector2_o a1,
        UnityEngine_Vector2_o a2,
        void *a3)
{
  float x; // s4
  float y; // s2

  if ( a1.x >= a2.x )
    x = a2.x;
  else
    x = a1.x;
  if ( a1.x <= a2.x )
    a1.x = a2.x;
  if ( a1.y >= a2.y )
    y = a2.y;
  else
    y = a1.y;
  if ( a1.y <= a2.y )
    a1.y = a2.y;
  *((float *)a0 + 12) = x;
  *((float *)a0 + 13) = y;
  *((UnityEngine_Vector2_o *)a0 + 7) = a1;
}

