// Campus.Crowd.CrowdAnimationBehaviour$$OnPlayableDestroy @ 0xddbf498
void __fastcall Campus_Crowd_CrowdAnimationBehaviour__OnPlayableDestroy(void *a0, __int64 a1, void *a2)
{
  __int64 v6; // x0
  void *v7; // x1
  __int64 Graph_Playable; // x0
  void *v9; // x2
  __int64 v10; // x8
  __int64 v11; // x1
  __int64 v12; // [xsp+0h] [xbp+0h] BYREF
  __int64 v13; // [xsp+8h] [xbp+8h]

  if ( (unk_F43BCC2 & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_GetGraph_Playable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableExtensions_IsValid_AnimationScriptPlayable___);
    sub_63CEE78(&Method_UnityEngine_Playables_PlayableGraph_DestroySubgraph_AnimationScriptPlayable___);
    unk_F43BCC2 = 1;
  }
  v6 = *((_QWORD *)a0 + 22);
  v7 = *((void **)a0 + 23);
  v12 = 0;
  v13 = 0;
  if ( UnityEngine_Playables_PlayableExtensions__IsValid_AnimationScriptPlayable_(v6, v7) )
  {
    Graph_Playable = UnityEngine_Playables_PlayableExtensions__GetGraph_Playable_(a1, a2);
    v10 = *((_QWORD *)a0 + 22);
    v9 = *((void **)a0 + 23);
    v12 = Graph_Playable;
    v13 = v11;
    UnityEngine_Playables_PlayableGraph__DestroySubgraph_AnimationScriptPlayable_((__int64)&v12, v10, v9);
  }
}

