// ProFlareBatch$$UpdateFlares @ 0xd1d112c
void __fastcall ProFlareBatch__UpdateFlares(void *a0, void *a1)
{
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5
  char *v6; // x19
  __int64 v7; // x8
  __int64 v8; // x1
  void **v9; // x20
  void *v10; // x1
  void *v11; // x21
  void *v12; // x0
  void *v13; // x1

  v6 = (char *)a0;
  if ( (unk_F42C938 & 1) == 0 )
  {
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F42C938 = 1;
  }
  if ( !v6 )
  {
LABEL_14:
    v12 = (void *)sub_63CF120(a0, a1);
    ProFlareBatch__UpdateGeometry(v12, v13);
    return;
  }
  v7 = 160;
  if ( !v6[176] )
    v7 = 168;
  v8 = *(_QWORD *)&v6[v7];
  *((_QWORD *)v6 + 19) = v8;
  v9 = (void **)(v6 + 152);
  sub_63CEE24(v6 + 152, v8, v2, v3, v4, v5);
  v6[176] ^= 1u;
  ProFlareBatch__UpdateGeometry(v6, v10);
  v11 = *((void **)v6 + 19);
  if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Object_TypeInfo);
  if ( UnityEngine_Object__op_Inequality(v11, nullptr, nullptr) )
  {
    a0 = *v9;
    if ( *v9 )
    {
      UnityEngine_Mesh__set_vertices(a0, *((void **)v6 + 24), nullptr);
      a0 = *((void **)v6 + 19);
      if ( a0 )
      {
        UnityEngine_Mesh__set_colors32(a0, *((void **)v6 + 26), nullptr);
        a0 = *((void **)v6 + 15);
        if ( a0 )
        {
          UnityEngine_MeshFilter__set_sharedMesh(a0, *v9, nullptr);
          return;
        }
      }
    }
    goto LABEL_14;
  }
}

