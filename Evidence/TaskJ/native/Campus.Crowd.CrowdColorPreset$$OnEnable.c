// Campus.Crowd.CrowdColorPreset$$OnEnable @ 0xddc3808
void __fastcall Campus_Crowd_CrowdColorPreset__OnEnable(void *a0, void *a1)
{
  __int64 *v3; // x19
  __int64 v4; // t1
  __int64 v5; // x1
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5

  if ( (unk_F43BCF0 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdColorPreset_ColorType___TypeInfo);
    unk_F43BCF0 = 1;
  }
  v4 = *((_QWORD *)a0 + 3);
  v3 = (__int64 *)((char *)a0 + 24);
  if ( !v4 )
  {
    v5 = sub_63CEF64(Campus_Crowd_CrowdColorPreset_ColorType___TypeInfo, 1);
    *v3 = v5;
    sub_63CEE24(v3, v5, v6, v7, v8, v9);
  }
}

