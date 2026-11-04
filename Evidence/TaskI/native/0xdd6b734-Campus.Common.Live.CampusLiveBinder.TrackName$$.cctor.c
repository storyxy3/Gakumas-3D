// 0xdd6b734 @ 0xdd6b734
void __fastcall Campus_Common_Live_CampusLiveBinder_TrackName___cctor(void *a0)
{
  int v1; // w2
  int v2; // w3
  int v3; // w4
  void *v4; // x5
  int v5; // w1
  int v6; // w1
  __int64 v7; // x0
  int v8; // w2
  int v9; // w3
  int v10; // w4
  void *v11; // x5
  int v12; // w1
  __int64 v13; // x0
  int v14; // w2
  int v15; // w3
  int v16; // w4
  void *v17; // x5
  int v18; // w1
  __int64 v19; // x0
  int v20; // w2
  int v21; // w3
  int v22; // w4
  void *v23; // x5
  int v24; // w1
  __int64 v25; // x0
  int v26; // w2
  int v27; // w3
  int v28; // w4
  void *v29; // x5
  int v30; // w1
  __int64 v31; // x0
  int v32; // w2
  int v33; // w3
  int v34; // w4
  void *v35; // x5
  int v36; // w1
  __int64 v37; // x0
  int v38; // w2
  int v39; // w3
  int v40; // w4
  void *v41; // x5
  int v42; // w2
  int v43; // w3
  int v44; // w4
  void *v45; // x5
  __int64 v46; // x0
  __int64 *v47; // x8
  __int64 v48; // x1
  __int64 v49; // x0
  int v50; // w1
  __int64 v51; // x0
  int v52; // w2
  int v53; // w3
  int v54; // w4
  void *v55; // x5
  int v56; // w1
  __int64 v57; // x0
  int v58; // w2
  int v59; // w3
  int v60; // w4
  void *v61; // x5

  if ( (unk_F43BA34 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_CampusActorLayout_TypeInfo);
    sub_63CEE78(&Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo);
    sub_63CEE78(&StringLiteral_Cinemachine);
    sub_63CEE78(&StringLiteral_Actor);
    sub_63CEE78(&StringLiteral_Camera);
    sub_63CEE78(&StringLiteral_Light);
    sub_63CEE78(&StringLiteral_Audio);
    sub_63CEE78(&StringLiteral_Actor_);
    sub_63CEE78(&StringLiteral_BGM);
    sub_63CEE78(&StringLiteral_Subtitle);
    sub_63CEE78(&StringLiteral_Voice);
    unk_F43BA34 = 1;
  }
  v5 = StringLiteral_Cinemachine;
  **(_QWORD **)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL) = StringLiteral_Cinemachine;
  sub_63CEE24(*(void **)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL), v5, v1, v2, v3, v4);
  v6 = StringLiteral_BGM;
  v7 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v7 + 8) = StringLiteral_BGM;
  sub_63CEE24((void *)(v7 + 8), v6, v8, v9, v10, v11);
  v12 = StringLiteral_Voice;
  v13 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v13 + 16) = StringLiteral_Voice;
  sub_63CEE24((void *)(v13 + 16), v12, v14, v15, v16, v17);
  v18 = StringLiteral_Actor;
  v19 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v19 + 24) = StringLiteral_Actor;
  sub_63CEE24((void *)(v19 + 24), v18, v20, v21, v22, v23);
  v24 = StringLiteral_Camera;
  v25 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v25 + 32) = StringLiteral_Camera;
  sub_63CEE24((void *)(v25 + 32), v24, v26, v27, v28, v29);
  v30 = StringLiteral_Audio;
  v31 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v31 + 40) = StringLiteral_Audio;
  sub_63CEE24((void *)(v31 + 40), v30, v32, v33, v34, v35);
  v36 = StringLiteral_Light;
  v37 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v37 + 48) = StringLiteral_Light;
  sub_63CEE24((void *)(v37 + 48), v36, v38, v39, v40, v41);
  v46 = Campus_Common_CampusActorLayout_TypeInfo;
  if ( !*(_DWORD *)(Campus_Common_CampusActorLayout_TypeInfo + 228LL) )
  {
    sub_63CEFF4(Campus_Common_CampusActorLayout_TypeInfo);
    v46 = Campus_Common_CampusActorLayout_TypeInfo;
  }
  v47 = *(__int64 **)(v46 + 184);
  v48 = *v47;
  v49 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v49 + 56) = *v47;
  sub_63CEE24((void *)(v49 + 56), v48, v42, v43, v44, v45);
  v50 = StringLiteral_Actor_;
  v51 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v51 + 64) = StringLiteral_Actor_;
  sub_63CEE24((void *)(v51 + 64), v50, v52, v53, v54, v55);
  v56 = StringLiteral_Subtitle;
  v57 = *(_QWORD *)(Campus_Common_Live_CampusLiveBinder_TrackName_TypeInfo + 184LL);
  *(_QWORD *)(v57 + 72) = StringLiteral_Subtitle;
  sub_63CEE24((void *)(v57 + 72), v56, v58, v59, v60, v61);
}

