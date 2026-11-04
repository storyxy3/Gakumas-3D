// 0xdd6a2f8 @ 0xdd6a2f8
void __fastcall Campus_Common_Live_CampusLiveBinder__DisableJointLimitIfNeeded(void *a0, void *a1)
{
  _QWORD *v2; // x19
  __int64 v3; // x8
  __int64 v4; // x8
  char v5; // w20
  int v6; // w21
  void *v7; // x2
  __int64 *v8; // x22
  void *ExposedActorMotion; // x23
  void *v10; // x2
  __int64 v11; // x8
  __int64 v12; // x1
  __int64 v13; // x9
  _DWORD *v14; // x10
  __int64 v15; // x9
  __int64 v16; // x0

  v2 = a0;
  if ( (unk_F43BA28 & 1) == 0 )
  {
    sub_63CEE78(&Campus_Common_ICampusActorController_TypeInfo);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Count__);
    sub_63CEE78(&Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
    a0 = (void *)sub_63CEE78(&UnityEngine_Object_TypeInfo);
    unk_F43BA28 = 1;
  }
  v3 = v2[10];
  if ( v3 )
  {
    if ( !*(_QWORD *)(v3 + 56) )
      return;
    a0 = (void *)Campus_Common_Live_CampusLiveBinder__IsAllLiveScene(v2, a1);
    v4 = v2[10];
    if ( v4 )
    {
      v5 = (char)a0;
      v6 = 0;
      do
      {
        a0 = *(void **)(v4 + 56);
        if ( !a0 )
          break;
        if ( v6 >= *((_DWORD *)a0 + 6) )
          return;
        a0 = System_Collections_Generic_List_object___get_Item(
               a0,
               v6,
               Method_System_Collections_Generic_List_ICampusActorController__get_Item__);
        if ( a0 )
        {
          v8 = (__int64 *)a0;
          ExposedActorMotion = Campus_Common_Live_CampusLiveBinder__GetExposedActorMotion(v2, v6, v7);
          if ( !*(_DWORD *)(UnityEngine_Object_TypeInfo + 228LL) )
            sub_63CEFF4(UnityEngine_Object_TypeInfo);
          if ( UnityEngine_Object__op_Inequality(ExposedActorMotion, nullptr, nullptr) )
          {
            if ( (v5 & 1) != 0 )
            {
LABEL_17:
              v11 = *v8;
              v12 = Campus_Common_ICampusActorController_TypeInfo;
              v13 = *(unsigned __int16 *)(*v8 + 302);
              if ( !*(_WORD *)(*v8 + 302) )
                goto LABEL_26;
              v14 = (_DWORD *)(*(_QWORD *)(v11 + 176) + 8LL);
              while ( *((_QWORD *)v14 - 1) != Campus_Common_ICampusActorController_TypeInfo )
              {
                --v13;
                v14 += 4;
                if ( !v13 )
                  goto LABEL_26;
              }
LABEL_27:
              v16 = v11 + 16LL * (*v14 + 29) + 312;
            }
            else
            {
LABEL_22:
              v11 = *v8;
              v12 = Campus_Common_ICampusActorController_TypeInfo;
              v15 = *(unsigned __int16 *)(*v8 + 302);
              if ( *(_WORD *)(*v8 + 302) )
              {
                v14 = (_DWORD *)(*(_QWORD *)(v11 + 176) + 8LL);
                while ( *((_QWORD *)v14 - 1) != Campus_Common_ICampusActorController_TypeInfo )
                {
                  --v15;
                  v14 += 4;
                  if ( !v15 )
                    goto LABEL_26;
                }
                goto LABEL_27;
              }
LABEL_26:
              v16 = sub_6408234(v8, v12, 29);
            }
            a0 = (void *)(*(__int64 (__fastcall **)(__int64 *, _QWORD))v16)(v8, *(_QWORD *)(v16 + 8));
            goto LABEL_29;
          }
          a0 = (void *)Campus_Common_Live_CampusLiveBinder__HasLiveOverrideActorMotion(v2, v6, v10);
          if ( (v5 & 1) == 0 )
            goto LABEL_22;
          if ( ((unsigned __int8)a0 & 1) != 0 )
            goto LABEL_17;
        }
LABEL_29:
        v4 = v2[10];
        ++v6;
      }
      while ( v4 );
    }
  }
  sub_63CF120(a0, a1);
}

