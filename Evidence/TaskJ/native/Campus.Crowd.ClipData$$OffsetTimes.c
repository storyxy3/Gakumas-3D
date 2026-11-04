// Campus.Crowd.ClipData$$OffsetTimes @ 0xddc2e54
void *__fastcall Campus_Crowd_ClipData__OffsetTimes(void *a0, double a1, float a2, int a3, void *a4)
{
  __int64 v8; // x20
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 state; // x21
  void *v12; // x1
  void *v13; // x22
  float v14; // s0
  float v15; // s1
  void *v16; // x19
  void *v17; // x23
  void *v18; // x0
  void *v19; // x19
  void *result; // x0
  void *v21; // x0
  void *v22; // x1

  if ( (unk_F43BCD8 & 1) == 0 )
  {
    sub_63CEE78(&Method_System_Linq_Enumerable_Select_int__double___);
    sub_63CEE78(&Method_System_Linq_Enumerable_ToArray_double___);
    sub_63CEE78(&System_Func_int__double__TypeInfo);
    sub_63CEE78(&Method_Campus_Crowd_ClipData___c__DisplayClass5_0__OffsetTimes_b__0__);
    sub_63CEE78(&Campus_Crowd_ClipData___c__DisplayClass5_0_TypeInfo);
    unk_F43BCD8 = 1;
  }
  v8 = sub_63CF110(Campus_Crowd_ClipData___c__DisplayClass5_0_TypeInfo);
  System_Object___ctor((void *)v8, nullptr);
  if ( v8 )
  {
    *(double *)(v8 + 16) = a1;
    state = UnityEngine_Random__get_state(nullptr);
    v13 = v12;
    UnityEngine_Random__InitState(a3, nullptr);
    v14 = 0.0;
    if ( a2 <= 0.0 )
      v15 = a2;
    else
      v15 = 0.0;
    if ( a2 >= 0.0 )
      v14 = a2;
    *(float *)(v8 + 24) = v15;
    *(float *)(v8 + 28) = v14;
    v16 = System_Linq_Enumerable__Range(0, 8, nullptr);
    v17 = (void *)sub_63CF110(System_Func_int__double__TypeInfo);
    System_Func_int__double____ctor(
      v17,
      (void *)v8,
      Method_Campus_Crowd_ClipData___c__DisplayClass5_0__OffsetTimes_b__0__,
      nullptr);
    v18 = System_Linq_Enumerable__Select_int__double_(v16, v17, Method_System_Linq_Enumerable_Select_int__double___);
    v19 = System_Linq_Enumerable__ToArray_double_(v18, Method_System_Linq_Enumerable_ToArray_double___);
    UnityEngine_Random__set_state(state, v13);
    return v19;
  }
  else
  {
    v21 = (void *)sub_63CF120(v9, v10);
    Campus_Crowd_ClipData__Dispose(v21, v22);
  }
  return result;
}

