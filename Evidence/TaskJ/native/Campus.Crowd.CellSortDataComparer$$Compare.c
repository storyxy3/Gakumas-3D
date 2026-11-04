// Campus.Crowd.CellSortDataComparer$$Compare @ 0xddc38a0
int __fastcall Campus_Crowd_CellSortDataComparer__Compare(__int64 a0, __int64 a1, __int64 a2, void *a3)
{
  int v4; // w8

  if ( HIWORD(a1) > HIWORD(a2) )
    v4 = 1;
  else
    v4 = -1;
  if ( HIWORD(a1) == HIWORD(a2) )
    return 0;
  else
    return v4;
}

