// Campus.Crowd.CrowdUtility$$<GetCellFromOctreeAddress>g__BitOffset|17_0 @ 0xddcd618
int __fastcall Campus_Crowd_CrowdUtility___GetCellFromOctreeAddress_g__BitOffset_17_0(int a0, void *a1)
{
  return a0 & 1 | (2 * (((unsigned int)a0 >> 3) & 1)) | ((unsigned int)a0 >> 4) & 4 | ((unsigned int)a0 >> 6) & 8;
}

