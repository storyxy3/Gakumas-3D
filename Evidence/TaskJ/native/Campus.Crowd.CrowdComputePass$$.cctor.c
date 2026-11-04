// Campus.Crowd.CrowdComputePass$$.cctor @ 0xddc63bc
void __fastcall Campus_Crowd_CrowdComputePass___cctor(void *a0)
{
  if ( (unk_F43BCFE & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdComputePass_TypeInfo);
    sub_63CEE78(&StringLiteral__CrowdParams);
    unk_F43BCFE = 1;
  }
  **(_DWORD **)(Campus_Crowd_CrowdComputePass_TypeInfo + 184LL) = UnityEngine_Shader__PropertyToID(
                                                                    StringLiteral__CrowdParams,
                                                                    nullptr);
}

