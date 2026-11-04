// Campus.Crowd.CrowdVolume$$<BuildHierarchy>g__Build|16_1 @ 0xddcdab8
void __fastcall Campus_Crowd_CrowdVolume___BuildHierarchy_g__Build_16_1(void *a0, void *a1, void *a2, void *a3)
{
  void *v4; // x19
  void *v5; // x20
  void *_16_0; // x21
  int v7; // w0
  void *v8; // x3
  int v9; // w22
  void *v10; // x0
  void *v11; // x3

  if ( a1 )
  {
    v4 = a2;
    v5 = a1;
    _16_0 = a0;
    while ( 1 )
    {
      v7 = System_String__IndexOf(v5, 0x2Fu, nullptr);
      if ( v7 < 1 )
        break;
      v9 = v7;
      v10 = System_String__Substring_1(v5, 0, v7, nullptr);
      _16_0 = Campus_Crowd_CrowdVolume___BuildHierarchy_g__Create_16_0(_16_0, v10, v4, v11);
      a0 = System_String__Substring(v5, v9 + 1, nullptr);
      v5 = a0;
      if ( !a0 )
        goto LABEL_5;
    }
  }
  else
  {
LABEL_5:
    sub_63CF120(a0, a1);
  }
  Campus_Crowd_CrowdVolume___BuildHierarchy_g__Create_16_0(_16_0, v5, v4, v8);
}

