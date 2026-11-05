// Campus.Live.LivePresenter$$CheckLiveEnd @ 0x863e52c
void __fastcall Campus_Live_LivePresenter__CheckLiveEnd(void *a0, float a1, void *a2)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x8
  __int64 v6; // x8
  __int64 v7; // x8
  __int64 v8; // x8
  __int64 v9; // x0
  void *v10; // x1
  __int64 v11; // x30
  _QWORD *v12; // x19
  __int64 v13; // x8
  __int64 v14; // x8
  void *v15; // x0
  __int64 v16; // [xsp+0h] [xbp+0h]
  __int64 v17; // [xsp+10h] [xbp+10h]
  __int64 v18; // [xsp+18h] [xbp+18h]

  v5 = *((_QWORD *)a0 + 4);
  if ( v5 )
  {
    v6 = *(_QWORD *)(v5 + 32);
    if ( v6 )
    {
      if ( *(_BYTE *)(v6 + 18) )
        return;
      v7 = *((_QWORD *)a0 + 6);
      if ( v7 )
      {
        v8 = *(_QWORD *)(v7 + 32);
        if ( v8 )
        {
          if ( (float)(*(float *)(v8 + 32) + -0.4) <= a1 )
            Campus_Live_LivePresenter__OnEndLiveSequence(a0, a2);
          return;
        }
      }
    }
  }
  v9 = sub_63CF120(a0, a2);
  *(&v16 - 4) = v11;
  v17 = v4;
  v18 = v3;
  v12 = (_QWORD *)v9;
  if ( (unk_F41399B & 1) == 0 )
  {
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    v9 = sub_63CEE78(&StringLiteral__model_ExecutionData_IsLiveStarted____false);
    unk_F41399B = 1;
  }
  v13 = v12[4];
  if ( !v13 || (v14 = *(_QWORD *)(v13 + 32)) == 0 )
  {
    v15 = (void *)sub_63CF120(v9, v10);
    if ( ((unsigned __int8)v10 & 1) == 0 )
      goto LABEL_16;
    goto LABEL_21;
  }
  if ( *(_BYTE *)(v14 + 16) )
  {
    if ( *(_BYTE *)(v14 + 18) )
    {
      v15 = v12;
LABEL_16:
      Campus_Live_LivePresenter__UnPause(v15, v10);
      return;
    }
    v15 = v12;
LABEL_21:
    Campus_Live_LivePresenter__Pause(v15, v10);
    return;
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__Log_1(StringLiteral__model_ExecutionData_IsLiveStarted____false, v12, nullptr);
}

