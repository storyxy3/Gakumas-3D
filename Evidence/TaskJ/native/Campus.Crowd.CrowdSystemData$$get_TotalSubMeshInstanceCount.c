// Campus.Crowd.CrowdSystemData$$get_TotalSubMeshInstanceCount @ 0xddca6b8
int __fastcall Campus_Crowd_CrowdSystemData__get_TotalSubMeshInstanceCount(void *a0, void *a1)
{
  int *v3; // x8
  __int64 v4; // x9
  int result; // w0
  int v6; // t1

  if ( (unk_F43BD1F & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Collections_NativeArray_int__get_IsCreated__);
    unk_F43BD1F = 1;
  }
  v3 = *((int **)a0 + 14);
  if ( !v3 )
    return 0;
  v4 = *((unsigned int *)a0 + 30);
  if ( (int)v4 < 1 )
    return 0;
  result = 0;
  do
  {
    v6 = *v3++;
    --v4;
    result += v6;
  }
  while ( v4 );
  return result;
}

