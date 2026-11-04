// Campus.Crowd.CrowdRendererFeature$$AddRenderPasses @ 0xddc4ee0
void __fastcall Campus_Crowd_CrowdRendererFeature__AddRenderPasses(void *a0, void *a1, void *a2, void *a3)
{
  void *InstanceID; // x0
  void *v8; // x21
  int v9; // w2
  int v10; // w3
  int v11; // w4
  void *v12; // x5
  __int64 v13; // x21
  int v14; // w1
  __int64 v15; // x22
  int v16; // w2
  int v17; // w3
  int v18; // w4
  void *v19; // x5
  __int64 v20; // x0
  __int64 v21; // x30
  __int64 v22; // x2
  __int64 v23; // x19
  __int64 v24; // x20
  __int64 v25; // x1
  int v26; // w3
  int v27; // w4
  void *v28; // x5
  int v29; // w2
  int v30; // w3
  int v31; // w4
  void *v32; // x5
  __int64 v33; // [xsp+0h] [xbp+0h]
  void *v34; // [xsp+8h] [xbp+8h] BYREF
  void *v35; // [xsp+10h] [xbp+10h]
  void *v36; // [xsp+18h] [xbp+18h]

  if ( (unk_F43BCF5 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__);
    unk_F43BCF5 = 1;
  }
  InstanceID = *((void **)a2 + 27);
  v34 = nullptr;
  if ( !InstanceID )
    goto LABEL_12;
  v8 = *((void **)a0 + 11);
  InstanceID = (void *)UnityEngine_Object__GetInstanceID(InstanceID, nullptr);
  if ( !v8 )
    goto LABEL_12;
  if ( !System_Collections_Generic_Dictionary_int__object___TryGetValue(
          v8,
          (int)InstanceID,
          &v34,
          Method_System_Collections_Generic_Dictionary_int__CrowdSystem__TryGetValue__) )
    return;
  InstanceID = v34;
  if ( !v34 )
    goto LABEL_12;
  InstanceID = (void *)Campus_Crowd_CrowdSystem__IsActive(v34, a1);
  if ( ((unsigned __int8)InstanceID & 1) == 0 )
    return;
  v13 = *((_QWORD *)a0 + 12);
  if ( !v13
    || (v14 = (int)v34,
        v15 = *((_QWORD *)a0 + 13),
        *(_QWORD *)(v13 + 224) = v34,
        sub_63CEE24((void *)(v13 + 224), v14, v9, v10, v11, v12),
        *(_QWORD *)(v13 + 240) = v15,
        sub_63CEE24((void *)(v13 + 240), v15, v16, v17, v18, v19),
        !a1) )
  {
LABEL_12:
    v20 = sub_63CF120(InstanceID, a1);
    *(&v33 - 4) = v21;
    v35 = a0;
    v36 = a1;
    v23 = v22;
    v24 = v20;
    *(_QWORD *)(v20 + 224) = v25;
    sub_63CEE24((void *)(v20 + 224), v25, v22, v26, v27, v28);
    *(_QWORD *)(v24 + 240) = v23;
    sub_63CEE24((void *)(v24 + 240), v23, v29, v30, v31, v32);
    return;
  }
  UnityEngine_Rendering_Universal_ScriptableRenderer__EnqueuePass(a1, *((void **)a0 + 12), nullptr);
}

