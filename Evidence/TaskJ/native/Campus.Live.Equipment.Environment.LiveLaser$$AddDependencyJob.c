// Campus.Live.Equipment.Environment.LiveLaser$$AddDependencyJob @ 0xddb6fd8
// local variable allocation has failed, the output may be wrong!
__int64 __fastcall Campus_Live_Equipment_Environment_LiveLaser__AddDependencyJob(
        void *a0,
        __int64 a1,
        __int64 a2,
        void *a3)
{
  __int64 v4; // x4
  __int64 v5; // x22
  float *v10; // x8
  float v11; // s8
  float v12; // s9
  float v13; // s10
  __int64 HasInstance; // x0
  __int64 v15; // x1
  __int64 *v16; // x24
  __int64 v17; // x8
  __int64 v18; // x9
  int *v19; // x10
  __int64 v20; // x0
  float v21; // s1
  float v22; // s2
  int v23; // w24
  unsigned int v24; // s0
  unsigned int v25; // s8
  unsigned int v26; // s1
  unsigned int v27; // s9
  unsigned int v28; // s2
  unsigned int v29; // s10
  unsigned int v30; // s0
  unsigned int v31; // s1
  unsigned int v32; // s2
  __int64 result; // x0
  __int64 v34; // x1
  void *v35; // x0
  void *v36; // x1
  void *v37; // x2
  __int128 v38; // [xsp+0h] [xbp+0h]
  void *v39; // [xsp+18h] [xbp+18h] BYREF
  __int64 v40; // [xsp+20h] [xbp+20h]
  __int128 v41; // [xsp+28h] [xbp+28h]
  __int64 v42; // [xsp+38h] [xbp+38h] OVERLAPPED
  __int64 v43; // [xsp+48h] [xbp+48h] OVERLAPPED
  __int64 v44; // [xsp+58h] [xbp+58h] OVERLAPPED
  __int128 v45; // [xsp+68h] [xbp+68h]
  unsigned __int64 v46; // [xsp+78h] [xbp+78h]
  unsigned __int64 v47; // [xsp+80h] [xbp+80h]
  unsigned __int64 v48; // [xsp+88h] [xbp+88h]
  __int64 v49; // [xsp+90h] [xbp+90h]
  __int64 v50; // [xsp+98h] [xbp+98h]
  UnityEngine_Vector3_o v51; // 0:s0.4,4:s1.4,8:s2.4
  UnityEngine_Vector3_o position; // 0:s0.4,4:s1.4,8:s2.4

  v5 = v4;
  if ( (unk_F43BC77 & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Jobs_IJobExtensions_Schedule_LiveLaser_LaserVertexJob___);
    sub_63CEE78(&VL_IVLTransform_TypeInfo);
    unk_F43BC77 = 1;
  }
  if ( !byte_F40009D[0] )
  {
    sub_63CEE78(&UnityEngine_Vector3_TypeInfo);
    byte_F40009D[0] = 1;
  }
  v10 = *(float **)(UnityEngine_Vector3_TypeInfo + 184LL);
  v11 = *v10;
  v12 = v10[1];
  v13 = v10[2];
  HasInstance = VL_VLCameraController__get_HasInstance(nullptr);
  if ( (HasInstance & 1) != 0 )
  {
    if ( !unk_F41D6D7 )
    {
      HasInstance = sub_63CEE78(&VL_VLCameraController_TypeInfo);
      unk_F41D6D7 = 1;
    }
    v16 = **(__int64 ***)(VL_VLCameraController_TypeInfo + 184LL);
    if ( !v16 )
      goto LABEL_18;
    v17 = *v16;
    v18 = *(unsigned __int16 *)(*v16 + 302);
    if ( *(_WORD *)(*v16 + 302) )
    {
      v19 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != VL_IVLTransform_TypeInfo )
      {
        --v18;
        v19 += 4;
        if ( !v18 )
          goto LABEL_13;
      }
      v20 = v17 + 16LL * *v19 + 312;
    }
    else
    {
LABEL_13:
      v20 = sub_6408234(v16, VL_IVLTransform_TypeInfo, 0);
    }
    v11 = (*(float (__fastcall **)(__int64 *, _QWORD))v20)(v16, *(_QWORD *)(v20 + 8));
    v12 = v21;
    v13 = v22;
  }
  v51.y = v12;
  v51.z = v13;
  v23 = *((_DWORD *)a0 + 8);
  v38 = *(_OWORD *)((char *)a0 + 136);
  v51.x = v11;
  Unity_Mathematics_float3__op_Implicit_3(v51, nullptr);
  v25 = v24;
  v27 = v26;
  v29 = v28;
  HasInstance = (__int64)UnityEngine_Component__get_transform(a0, nullptr);
  if ( HasInstance )
  {
    position = UnityEngine_Transform__get_position((void *)HasInstance, nullptr);
    Unity_Mathematics_float3__op_Implicit_3(position, nullptr);
    v49 = 0;
    v50 = 0;
    v41 = v38;
    v39 = a3;
    v40 = v5;
    LODWORD(v42) = v23;
    v46 = __PAIR64__(v27, v25);
    *(_OWORD *)((char *)&v42 + 4) = 0u;
    *(_OWORD *)((char *)&v43 + 4) = 0u;
    *(_OWORD *)((char *)&v44 + 4) = 0u;
    v45 = 0u;
    v47 = __PAIR64__(v30, v29);
    v48 = __PAIR64__(v32, v31);
    result = Unity_Jobs_IJobExtensions__Schedule_LiveLaser_LaserVertexJob_((__int64)&v39, a1, (void *)a2);
    *((_QWORD *)a0 + 21) = result;
    *((_QWORD *)a0 + 22) = v34;
    return result;
  }
LABEL_18:
  v35 = (void *)sub_63CF120(HasInstance, v15);
  Campus_Live_Equipment_Environment_LiveLaser__UpdateInitialData(v35, v36, v37);
  return result;
}

