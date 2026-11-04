// Campus.Crowd.CrowdTimelineTrack.<>c$$<CreateLayerMixer>b__0_1 @ 0xddcd3a0
__int64 __fastcall Campus_Crowd_CrowdTimelineTrack___c___CreateLayerMixer_b__0_1(void *a0, void *a1, int a2, void *a3)
{
  void *v5; // x20
  __int64 v6; // x9
  __int64 v7; // x12
  void **v8; // x20
  __int64 result; // x0
  void *v10; // x0
  void *v11; // x1
  __int64 v12; // [xsp+0h] [xbp+0h] BYREF
  __int64 v13; // [xsp+8h] [xbp+8h]

  v5 = a1;
  if ( (unk_F43BD40 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdTimelineAsset_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    a0 = (void *)sub_63CEE78(&Method_System_ValueTuple_CrowdTimelineBehaviour__int___ctor__);
    unk_F43BD40 = 1;
  }
  if ( v5 )
  {
    v6 = *((_QWORD *)v5 + 5);
    if ( v6
      && (v7 = *(unsigned __int8 *)(Campus_Crowd_CrowdTimelineAsset_TypeInfo + 304LL),
          *(unsigned __int8 *)(*(_QWORD *)v6 + 304LL) >= (unsigned int)v7) )
    {
      if ( *(_QWORD *)(*(_QWORD *)(*(_QWORD *)v6 + 200LL) + 8 * v7 - 8) == Campus_Crowd_CrowdTimelineAsset_TypeInfo )
        v8 = *((void ***)v5 + 5);
      else
        v8 = nullptr;
    }
    else
    {
      v8 = nullptr;
    }
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    a0 = (void *)UnityEngine_Object__op_Inequality(v8, nullptr, nullptr);
    a1 = nullptr;
    if ( ((unsigned __int8)a0 & 1) == 0 )
      goto LABEL_15;
    if ( v8 )
    {
      a1 = v8[3];
LABEL_15:
      v12 = 0;
      v13 = 0;
      System_ValueTuple_object__int____ctor(
        (__int64)&v12,
        a1,
        a2,
        Method_System_ValueTuple_CrowdTimelineBehaviour__int___ctor__);
      return v12;
    }
  }
  v10 = (void *)sub_63CF120(a0, a1);
  Campus_Crowd_CrowdVolume__get_Position(v10, v11);
  return result;
}

