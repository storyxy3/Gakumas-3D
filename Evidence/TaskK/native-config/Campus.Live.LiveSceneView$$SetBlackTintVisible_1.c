// 0x6711434 @ 0x6711434
// local variable allocation has failed, the output may be wrong!
void __fastcall Campus_Live_LiveSceneView__SetBlackTintVisible_1(void *a0, bool a1, UnityEngine_Color_o a2, void *a3)
{
  __int64 v5; // x0

  v5 = *((_QWORD *)a0 + 6);
  if ( !v5 )
  {
    sub_63CF120(0, a1);
    JUMPOUT(0x671147C);
  }
  (*(void (__fastcall **)(__int64, _QWORD, void *, long double, long double, long double, long double))(*(_QWORD *)v5 + 696LL))(
    v5,
    *(_QWORD *)(*(_QWORD *)v5 + 704LL),
    a3,
    *(long double *)&a2,
    *(long double *)&a2.g,
    *(long double *)&a2.b,
    *(long double *)&a2.a);
  Campus_Common_UIExtensions__SetVisible(*((void **)a0 + 5), a1, 1, nullptr);
}

