// Campus.Live.Equipment.Environment.LiveLaser.<get_GatherProperties>d__31$$System.Collections.Generic.IEnumerable<Campus.Live.Equipment.ILiveEquipmentProperty>.GetEnumerator @ 0xddb8670
void *__fastcall Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31__System_Collections_Generic_IEnumerable_Campus_Live_Equipment_ILiveEquipmentProperty__GetEnumerator(
        void *a0,
        void *a1)
{
  int v3; // w20
  __int64 v4; // x20
  int CurrentManagedThreadId; // w0
  __int64 v6; // x1
  int v7; // w2
  int v8; // w3
  int v9; // w4
  void *v10; // x5

  if ( (unk_F43BC7C & 1) == 0 )
  {
    sub_63CEE78(&Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31_TypeInfo);
    unk_F43BC7C = 1;
  }
  if ( *((_DWORD *)a0 + 4) == -2
    && (v3 = *((_DWORD *)a0 + 8), v3 == System_Environment__get_CurrentManagedThreadId(nullptr)) )
  {
    *((_DWORD *)a0 + 4) = 0;
  }
  else
  {
    v4 = sub_63CF110(Campus_Live_Equipment_Environment_LiveLaser__get_GatherProperties_d__31_TypeInfo);
    System_Object___ctor((void *)v4, nullptr);
    *(_DWORD *)(v4 + 16) = 0;
    CurrentManagedThreadId = System_Environment__get_CurrentManagedThreadId(nullptr);
    v6 = *((_QWORD *)a0 + 5);
    *(_DWORD *)(v4 + 32) = CurrentManagedThreadId;
    *(_QWORD *)(v4 + 40) = v6;
    sub_63CEE24((void *)(v4 + 40), v6, v7, v8, v9, v10);
    return (void *)v4;
  }
  return a0;
}

