// 0xe0cb36c @ 0xe0cb36c
void __fastcall VLB_VLBDrawCallSystem__Execute_1(void *a0, void *a1, void *a2, void *a3, int a4, void *a5)
{
  __int64 v10; // x0
  unsigned __int64 v11; // x1
  __int128 v12; // q1
  __int128 v13; // q2
  __int128 v14; // q0
  __int128 v15; // q1
  __int128 v16; // q0
  __int128 v17; // q2
  __int128 v18; // q0
  __int128 v19; // q1
  __int128 v20; // q0
  __int128 v21; // q2
  __int128 v22; // q1
  __int128 v23; // q0
  __int128 v24; // q2
  __int128 v25; // q1
  __int128 v26; // q0
  __int64 v27; // x8
  __int128 v28; // q0
  int v29; // w10
  char v30; // w23
  unsigned __int64 v31; // x21
  unsigned __int64 v32; // x22
  __int128 v33; // q1
  __int128 v34; // q2
  __int64 v35; // x1
  void *v36; // x2
  __int128 v37; // q0
  __int128 v38; // q1
  __int128 v39; // q0
  __int128 v40; // q2
  __int128 v41; // q0
  __int64 v42; // x0
  __int64 v43; // x1
  __int64 v44; // x0
  void *v45; // x1
  __int128 v46; // [xsp+0h] [xbp+0h] BYREF
  __int128 v47; // [xsp+10h] [xbp+10h]
  __int128 v48; // [xsp+20h] [xbp+20h]
  __int128 v49; // [xsp+30h] [xbp+30h]
  __int128 v50; // [xsp+40h] [xbp+40h]
  __int128 v51; // [xsp+50h] [xbp+50h]
  __int128 v52; // [xsp+60h] [xbp+60h]
  __int128 v53; // [xsp+70h] [xbp+70h]
  __int128 v54; // [xsp+80h] [xbp+80h]
  __int128 v55; // [xsp+90h] [xbp+90h]
  __int128 v56; // [xsp+A0h] [xbp+A0h]
  __int128 v57; // [xsp+B0h] [xbp+B0h]
  __int128 v58; // [xsp+C0h] [xbp+C0h]
  __int128 v59; // [xsp+D0h] [xbp+D0h]
  __int128 v60; // [xsp+E0h] [xbp+E0h]
  __int128 v61; // [xsp+F0h] [xbp+F0h]
  __int128 v62; // [xsp+100h] [xbp+100h]
  __int64 v63; // [xsp+110h] [xbp+110h]
  __int128 v64; // [xsp+118h] [xbp+118h]
  __int64 v65; // [xsp+130h] [xbp+130h] BYREF

  if ( (unk_F43D9DC & 1) == 0 )
  {
    sub_63CEE78(&Method_Unity_Jobs_IJobExtensions_Schedule_VLBDrawCallSystem_DrawCallJob___);
    sub_63CEE78(&Method_Unity_Collections_NativeList_int__AsDeferredJobArray__);
    unk_F43D9DC = 1;
  }
  memset(&v46, 0, 0x128u);
  if ( a4 )
  {
    v10 = (__int64)memset(&v46, 0, 0x128u);
    if ( !a1 )
      goto LABEL_9;
    v12 = *(_OWORD *)((char *)a1 + 88);
    v13 = *(_OWORD *)((char *)a1 + 136);
    v46 = *(_OWORD *)((char *)a1 + 72);
    v47 = v12;
    v14 = *(_OWORD *)((char *)a1 + 152);
    v15 = *(_OWORD *)((char *)a1 + 168);
    v48 = v13;
    v49 = v14;
    v16 = *(_OWORD *)((char *)a1 + 184);
    v17 = *(_OWORD *)((char *)a1 + 200);
    v50 = v15;
    v51 = v16;
    v18 = *(_OWORD *)((char *)a1 + 216);
    v19 = *(_OWORD *)((char *)a1 + 232);
    v52 = v17;
    v53 = v18;
    v20 = *(_OWORD *)((char *)a1 + 248);
    v21 = *(_OWORD *)((char *)a1 + 264);
    v54 = v19;
    v55 = v20;
    v22 = *(_OWORD *)((char *)a1 + 280);
    v23 = *(_OWORD *)((char *)a1 + 296);
    v56 = v21;
    v57 = v22;
    v24 = *(_OWORD *)((char *)a1 + 312);
    v25 = *(_OWORD *)((char *)a1 + 328);
    v58 = v23;
    v59 = v24;
    v26 = *(_OWORD *)((char *)a1 + 344);
    v27 = *(_QWORD *)((char *)a1 + 52);
    v60 = v25;
    v61 = v26;
    v28 = *(_OWORD *)((char *)a1 + 104);
    *(_QWORD *)((char *)&v64 + 4) = v27;
    LODWORD(v27) = *((_DWORD *)a1 + 15);
    v62 = v28;
    HIDWORD(v64) = v27;
    if ( !a2 )
      goto LABEL_9;
    v29 = *((_DWORD *)a2 + 12);
    v30 = *((_BYTE *)a1 + 64);
    v63 = *((_QWORD *)a2 + 5);
    LODWORD(v64) = v29;
    v10 = Unity_Collections_NativeList_int___AsDeferredJobArray(
            (__int64)a2 + 80,
            Method_Unity_Collections_NativeList_int__AsDeferredJobArray__);
    if ( a3 )
    {
      v31 = v10;
      v32 = v11;
      memcpy(&v65, &v46, 0x128u);
      v33 = *(_OWORD *)((char *)a3 + 56);
      v34 = *(_OWORD *)((char *)a3 + 72);
      v35 = *((_QWORD *)a1 + 3);
      v36 = *((void **)a1 + 4);
      *(_OWORD *)&STACK[0x270] = *(_OWORD *)((char *)a3 + 40);
      *(_OWORD *)&STACK[0x280] = v33;
      v37 = *(_OWORD *)((char *)a3 + 88);
      v38 = *(_OWORD *)((char *)a3 + 104);
      LOBYTE(STACK[0x258]) = v30;
      *(_OWORD *)&STACK[0x290] = v34;
      *(_OWORD *)&STACK[0x2A0] = v37;
      v39 = *(_OWORD *)((char *)a3 + 120);
      v40 = *(_OWORD *)((char *)a3 + 136);
      LODWORD(STACK[0x259]) = 0;
      *(_OWORD *)&STACK[0x2B0] = v38;
      *(_OWORD *)&STACK[0x2C0] = v39;
      v41 = *(_OWORD *)((char *)a3 + 152);
      LODWORD(STACK[0x25C]) = 0;
      *(_OWORD *)&STACK[0x2D0] = v40;
      *(_OWORD *)&STACK[0x2E0] = v41;
      STACK[0x260] = v31;
      STACK[0x268] = v32;
      v42 = Unity_Jobs_IJobExtensions__Schedule_VLBDrawCallSystem_DrawCallJob_((__int64)&v65, v35, v36);
      *((_QWORD *)a3 + 3) = v42;
      *((_QWORD *)a3 + 4) = v43;
      *((_QWORD *)a1 + 3) = v42;
      *((_QWORD *)a1 + 4) = v43;
    }
    else
    {
LABEL_9:
      v44 = sub_63CF120(v10, v11);
      VLB_VLBDrawCallSystem_DrawCallJob__Execute(v44, v45);
    }
  }
}

