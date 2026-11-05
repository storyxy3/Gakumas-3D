// Campus.Live.LivePresenter$$OnEndLiveSequence @ 0x8634254
void __fastcall Campus_Live_LivePresenter__OnEndLiveSequence(void *a0, void *a1)
{
  __int64 v2; // x8
  __int64 v3; // x8
  void **v4; // x19
  void *v5; // x0
  __int64 v6; // x1
  void *v7; // x2

  v2 = *((_QWORD *)a0 + 4);
  if ( !v2 )
    goto LABEL_6;
  v3 = *(_QWORD *)(v2 + 32);
  if ( !v3 )
    goto LABEL_6;
  if ( *(_BYTE *)(v3 + 17) )
    return;
  v4 = (void **)a0;
  a0 = *((void **)a0 + 6);
  *(_BYTE *)(v3 + 17) = 1;
  if ( a0 )
  {
    Campus_Live_LivePlayerPresenter__Pause(a0, a1);
    DG_Tweening_TweenExtensions__Kill(v4[7], 0, nullptr);
  }
  else
  {
LABEL_6:
    v5 = (void *)sub_63CF120(a0, a1);
    Campus_Live_LivePresenter__FinalizeLiveAsync(v5, v6, v7);
  }
}

