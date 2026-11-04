// Campus.Crowd.CrowdMeshRenderSystem$$Render @ 0xddc8700
void __fastcall Campus_Crowd_CrowdMeshRenderSystem__Render(void *a0, void *a1, void *a2, __int64 a3, int a4, void *a5)
{
  int v6; // w23
  void *v11; // x24
  __int64 v12; // x0
  __int64 v13; // x1
  int v14; // w2
  int v15; // w3
  __int64 v16; // x8
  int v17; // w8
  __int64 v18; // x8
  unsigned __int64 v19; // x24
  int v20; // w29
  __int64 v21; // x8
  unsigned __int64 v22; // x9
  __int64 v23; // x23
  void *v24; // x25
  int v25; // w26
  int v26; // s8
  int v27; // s9
  int v28; // [xsp+Ch] [xbp+Ch]
  UnityEngine_Vector4_o v29; // 0:s0.4,4:s1.4,8:s2.4,12:s3.4

  v6 = (int)a5;
  if ( (unk_F43BD0D & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
    sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BD0D = 1;
  }
  if ( *((_QWORD *)a0 + 2) )
  {
    v11 = *((void **)a0 + 5);
    if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
      sub_63CEFF4(UnityEngine_Object_TypeInfo);
    v12 = UnityEngine_Object__op_Equality(v11, nullptr, nullptr);
    if ( (v12 & 1) == 0 )
    {
      v16 = *((_QWORD *)a0 + 2);
      if ( v16 )
      {
        if ( *(_QWORD *)(v16 + 24) )
        {
          if ( v6 == 1 )
          {
            v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
            if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
            {
              sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
              v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
            }
            v17 = *(_DWORD *)(*(_QWORD *)(v12 + 184) + 48LL);
          }
          else if ( v6 )
          {
            v17 = -1;
          }
          else
          {
            v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
            if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
            {
              sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
              v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
            }
            v17 = *(_DWORD *)(*(_QWORD *)(v12 + 184) + 52LL);
          }
          v28 = v17;
          v18 = *((_QWORD *)a0 + 2);
          if ( v18 )
          {
            v19 = 0;
            v20 = 0;
            do
            {
              v21 = *(_QWORD *)(v18 + 24);
              if ( !v21 )
                break;
              v22 = *(unsigned int *)(v21 + 24);
              if ( (__int64)v19 >= (int)v22 )
                return;
              if ( v19 >= v22 )
              {
                sub_63CF128(v12, v13, v14, v15);
                return;
              }
              v23 = *(_QWORD *)(v21 + 8 * v19 + 32);
              if ( v23 )
                v24 = *(void **)(v23 + 32);
              else
                v24 = nullptr;
              if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
                sub_63CEFF4(UnityEngine_Object_TypeInfo);
              v12 = UnityEngine_Object__op_Equality(v24, nullptr, nullptr);
              if ( (v12 & 1) == 0 )
              {
                v25 = *(_DWORD *)(a3 + 4 * v19);
                if ( v25 >= 1 )
                {
                  if ( !v23 )
                    break;
                  v12 = Campus_Crowd_CrowdMeshRenderSystem_TypeInfo;
                  v26 = *(_DWORD *)(v23 + 24);
                  v27 = *(_DWORD *)(v23 + 28);
                  if ( !*(_DWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 228LL) )
                    sub_63CEFF4(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo);
                  if ( !a2 )
                    break;
                  v29.x = (float)v27;
                  v29.y = (float)v25;
                  v29.z = (float)v26;
                  v29.w = (float)v20;
                  UnityEngine_MaterialPropertyBlock__SetVector_1(
                    a2,
                    *(_DWORD *)(*(_QWORD *)(Campus_Crowd_CrowdMeshRenderSystem_TypeInfo + 184LL) + 32LL),
                    v29,
                    nullptr);
                  if ( !a1 )
                    break;
                  UnityEngine_Rendering_CommandBuffer__DrawMeshInstancedProcedural(
                    a1,
                    *((void **)a0 + 5),
                    v19,
                    v24,
                    v28,
                    v25,
                    a2,
                    nullptr);
                  v20 += v25;
                }
              }
              v18 = *((_QWORD *)a0 + 2);
              ++v19;
            }
            while ( v18 );
          }
          sub_63CF120(v12, v13);
        }
      }
    }
  }
}

