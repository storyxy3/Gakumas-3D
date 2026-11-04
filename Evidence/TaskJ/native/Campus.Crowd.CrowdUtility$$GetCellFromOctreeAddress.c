// Campus.Crowd.CrowdUtility$$GetCellFromOctreeAddress @ 0xddcd52c
void __fastcall Campus_Crowd_CrowdUtility__GetCellFromOctreeAddress(int a0, void *a1, void *a2, void *a3, void *a4)
{
  if ( (unk_F43BD41 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Crowd_CrowdUtility_TypeInfo);
    unk_F43BD41 = 1;
  }
  if ( !*(_DWORD *)(Campus_Crowd_CrowdUtility_TypeInfo + 228LL) )
    sub_63CEFF4(Campus_Crowd_CrowdUtility_TypeInfo);
  *(_DWORD *)a1 = a0 & 1
                | (2 * (((unsigned int)a0 >> 3) & 1))
                | ((unsigned int)a0 >> 4) & 4
                | ((unsigned int)a0 >> 6) & 8;
  *(_DWORD *)a2 = (a0 >> 1) & 1
                | (2 * (((unsigned int)(a0 >> 1) >> 3) & 1))
                | ((unsigned int)(a0 >> 1) >> 4) & 4
                | ((unsigned int)(a0 >> 1) >> 6) & 8;
  *(_DWORD *)a3 = (a0 >> 2) & 1
                | (2 * (((unsigned int)(a0 >> 2) >> 3) & 1))
                | ((unsigned int)(a0 >> 2) >> 4) & 4
                | ((unsigned int)(a0 >> 2) >> 6) & 8;
}

