// Campus.Crowd.PenlightMeshRenderSystem$$GetPenlightInfoBytesBuffer @ 0xddcc0e0
// local variable allocation has failed, the output may be wrong!
void *__fastcall Campus_Crowd_PenlightMeshRenderSystem__GetPenlightInfoBytesBuffer(void *a0, int a1, void *a2)
{
  int v3; // w3
  __int64 v4; // x30
  __int64 v5; // x8
  __int64 v7; // [xsp+0h] [xbp+0h]

  if ( a1 < 0 )
    return nullptr;
  if ( *((_DWORD *)a0 + 8) <= a1 )
    return nullptr;
  v5 = *((_QWORD *)a0 + 6);
  if ( !v5 )
    return nullptr;
  if ( *(_DWORD *)(v5 + 24) <= (unsigned int)a1 )
  {
    *(&v7 - 2) = v4;
    sub_63CF128(a0, *(_QWORD *)&a1, (_DWORD)a2, v3);
    JUMPOUT(0xDDCC120);
  }
  return *(void **)(v5 + 8LL * (unsigned int)a1 + 32);
}

