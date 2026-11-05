// VLB.Config$$OnEnable @ 0xe0c83d8
void __fastcall VLB_Config__OnEnable(void *a0, void *a1)
{
  void *v2; // x2

  VLB_Config__CreateDefaultRaymarchingQualityPreset(a0, 1, v2);
  *((_DWORD *)a0 + 43) = 20000;
}

