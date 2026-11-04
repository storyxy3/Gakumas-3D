// 0xe1276c0 @ 0xe1276c0
void __fastcall VL_Core_VLActorDescriptor__set_gameObjects(void *a0, void *a1, void *a2)
{
  void *v5; // x0
  int v6; // w2
  int v7; // w3
  int v8; // w4
  void *v9; // x5

  if ( (unk_F43DD7B & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_ToArray_GameObject___);
    unk_F43DD7B = 1;
  }
  v5 = System_Linq_Enumerable__ToArray_object_(a1, Method_System_Linq_Enumerable_ToArray_GameObject___);
  *((_QWORD *)a0 + 4) = v5;
  sub_63CEE24((char *)a0 + 32, (int)v5, v6, v7, v8, v9);
}

