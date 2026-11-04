// 0xdd6b9d4 @ 0xdd6b9d4
void __fastcall Campus_Common_Live_CampusLiveBinder___c___cctor(void *a0)
{
  void *v1; // x19
  int v2; // w2
  int v3; // w3
  int v4; // w4
  void *v5; // x5

  if ( (unk_F43BA37 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
    unk_F43BA37 = 1;
  }
  v1 = (void *)sub_63CF110(Campus_Common_Live_CampusLiveBinder___c_TypeInfo);
  System_Object___ctor(v1, nullptr);
  **(_QWORD **)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL) = v1;
  sub_63CEE24(*(void **)(Campus_Common_Live_CampusLiveBinder___c_TypeInfo + 184LL), (int)v1, v2, v3, v4, v5);
}

