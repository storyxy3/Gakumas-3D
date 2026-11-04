// VLB.Chunk$$ResizeNativeArray<object> @ 0x90ab58c
void __fastcall VLB_Chunk__ResizeNativeArray_object_(void *a0, void *a1, void *a2, int a3, void *a4)
{
  __int64 length; // x0
  __int64 v8; // x1
  int v9; // w2
  int v10; // w3
  __int64 v11; // x21
  void *transform; // x0
  void *v13; // x0
  void *v14; // x1
  __int64 v15; // [xsp+8h] [xbp+8h] BYREF

  v15 = 0;
  UnityEngine_Jobs_TransformAccessArray___ctor_1((__int64)&v15, a3, -1, nullptr);
  if ( !UnityEngine_Jobs_TransformAccessArray__get_isCreated((__int64)a1, nullptr) )
    goto LABEL_9;
  length = UnityEngine_Jobs_TransformAccessArray__get_length((__int64)a1, nullptr);
  if ( (int)length < 1 )
  {
LABEL_8:
    UnityEngine_Jobs_TransformAccessArray__Dispose((__int64)a1, nullptr);
LABEL_9:
    *(_QWORD *)a1 = v15;
    return;
  }
  if ( a2 )
  {
    v11 = 0;
    while ( (unsigned int)v11 < *((_DWORD *)a2 + 6) )
    {
      length = *((_QWORD *)a2 + v11 + 4);
      if ( !length )
        goto LABEL_10;
      transform = UnityEngine_Component__get_transform((void *)length, nullptr);
      UnityEngine_Jobs_TransformAccessArray__Add((__int64)&v15, transform, nullptr);
      length = UnityEngine_Jobs_TransformAccessArray__get_length((__int64)a1, nullptr);
      if ( (int)++v11 >= (int)length )
        goto LABEL_8;
    }
  }
  else
  {
LABEL_10:
    length = sub_63CF120(length, v8);
  }
  sub_63CF128(length, v8, v9, v10);
  Cinemachine_CinemachineExtension__GetAllExtraStates_object_(v13, v14);
}

