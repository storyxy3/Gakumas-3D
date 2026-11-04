// Campus.Crowd.CrowdSystemData$$GetRandomIndex @ 0xddcbab8
int __fastcall Campus_Crowd_CrowdSystemData__GetRandomIndex(void *a0, void *a1, void *a2, void *a3)
{
  __int64 v6; // x0
  __int64 v7; // x1
  int v8; // w2
  int v9; // w3
  unsigned int v10; // w10
  unsigned int v11; // w9
  int v12; // w9
  unsigned int v13; // w8
  __int64 v14; // x0
  int v15; // w11
  unsigned __int64 v16; // x8
  bool v17; // cc

  v6 = System_Linq_Enumerable__Sum(a1, nullptr);
  if ( (int)v6 >= 1 )
  {
    v10 = *(_DWORD *)a2;
    v11 = v10 ^ (v10 << 13) ^ ((v10 ^ (v10 << 13)) >> 17);
    *(_DWORD *)a2 = v11 ^ (32 * v11);
    if ( !a1 )
      goto LABEL_13;
    v12 = *((_DWORD *)a1 + 6);
    if ( v12 >= 1 )
    {
      v13 = v6;
      v14 = 0;
      v15 = 0;
      v16 = (v10 * (unsigned __int64)v13) >> 32;
      while ( v12 != (_DWORD)v14 )
      {
        v17 = v15 <= (int)v16;
        v15 += *((_DWORD *)a1 + (int)v14 + 8);
        if ( v17 && v15 > (int)v16 )
          return v14;
        v14 = (unsigned int)(v14 + 1);
        if ( (v12 & ~(v12 >> 31)) == (_DWORD)v14 )
          goto LABEL_10;
      }
      sub_63CF128(v14, v7, v8, v9);
LABEL_13:
      sub_63CF120(v6, v7);
      JUMPOUT(0xDDCBB60);
    }
  }
LABEL_10:
  LODWORD(v14) = 0;
  return v14;
}

