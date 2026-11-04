// Campus.Crowd.CrowdAnimator$$Update @ 0xddc221c
void __fastcall Campus_Crowd_CrowdAnimator__Update(void *a0, void *a1)
{
  void *v3; // x0
  void *v4; // x0
  void *v5; // x1
  double v6; // d0
  __int128 v7; // [xsp+0h] [xbp+0h] BYREF
  __int128 v8; // [xsp+10h] [xbp+10h]
  __int128 v9; // [xsp+20h] [xbp+20h]
  __int128 v10; // [xsp+30h] [xbp+30h]
  __int128 v11; // [xsp+40h] [xbp+40h] BYREF
  __int128 v12; // [xsp+50h] [xbp+50h]
  __int128 v13; // [xsp+60h] [xbp+60h]
  __int128 v14; // [xsp+70h] [xbp+70h]

  if ( (unk_F43BCE2 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeReference_Matrix4x4__set_Value__);
    unk_F43BCE2 = 1;
  }
  v3 = *((void **)a0 + 13);
  if ( v3 )
  {
    UnityEngine_Transform__get_worldToLocalMatrix((UnityEngine_Matrix4x4_o *)&v7, v3, nullptr);
    v11 = v7;
    v12 = v8;
    v13 = v9;
    v14 = v10;
    Unity_Collections_NativeReference_Matrix4x4___set_Value(
      (__int64)a0 + 16,
      (UnityEngine_Matrix4x4_o *)&v11,
      Method_Unity_Collections_NativeReference_Matrix4x4__set_Value__);
  }
  else
  {
    v4 = (void *)sub_63CF120(0, a1);
    Campus_Crowd_CrowdAnimationTimeline__SetTime(v4, v6, v5);
  }
}

