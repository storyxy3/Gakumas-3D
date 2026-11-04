// 0xd1d3ae8 @ 0xd1d3ae8
void __fastcall ProFlareBatchForSRPData__SetShader(void *a0, void *a1, int a2, void *a3, void *a4)
{
  void *v5; // x5
  int v10; // w2
  int v11; // w3
  int v12; // w4
  void *v13; // x5
  _QWORD *v14; // x19
  __int64 v15; // t1
  void *v16; // x20
  int v17; // w2
  int v18; // w3
  int v19; // w4
  void *v20; // x5

  if ( (unk_F42C948 & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_MaterialPropertyBlock_TypeInfo);
    unk_F42C948 = 1;
  }
  *((_QWORD *)a0 + 6) = a1;
  sub_63CEE24((char *)a0 + 48, (int)a1, a2, (int)a3, (int)a4, v5);
  *((_DWORD *)a0 + 14) = a2;
  *((_QWORD *)a0 + 8) = a3;
  sub_63CEE24((char *)a0 + 64, (int)a3, v10, v11, v12, v13);
  v15 = *((_QWORD *)a0 + 9);
  v14 = (char *)a0 + 72;
  if ( !v15 )
  {
    v16 = (void *)sub_63CF110(UnityEngine_MaterialPropertyBlock_TypeInfo);
    UnityEngine_MaterialPropertyBlock___ctor(v16, nullptr);
    *v14 = v16;
    sub_63CEE24(v14, (int)v16, v17, v18, v19, v20);
  }
}

