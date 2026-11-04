// Campus.Live.Equipment.Environment.LiveLaser$$get_GatherProperties @ 0xddb6f1c
void *__fastcall Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties(void *a0, void *a1)
{
  __int64 v3; // x20
  int v4; // w2
  int v5; // w3
  int v6; // w4
  void *v7; // x5

  if ( (unk_F43BC76 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31_TypeInfo);
    unk_F43BC76 = 1;
  }
  v3 = sub_63CF110(Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31_TypeInfo);
  System_Object___ctor((void *)v3, nullptr);
  *(_DWORD *)(v3 + 16) = -2;
  *(_DWORD *)(v3 + 32) = System_Environment__get_CurrentManagedThreadId(nullptr);
  *(_QWORD *)(v3 + 40) = a0;
  sub_63CEE24((void *)(v3 + 40), (int)a0, v4, v5, v6, v7);
  return (void *)v3;
}

