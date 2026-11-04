// 0xdddeb8c @ 0xdddeb8c
void __fastcall Campus_Common_CampusActorController__SetPropFieldConstraintTarget(
        void *a0,
        void *a1,
        void *a2,
        void *a3)
{
  __int64 v7; // x1
  void *transform; // x0
  int v9; // w20
  _QWORD *v10; // x21
  int v11; // w2
  int v12; // w3
  int v13; // w4
  void *v14; // x5
  _QWORD *v15; // [xsp+0h] [xbp+0h] BYREF
  void *v16; // [xsp+8h] [xbp+8h] BYREF

  if ( (unk_F43BDCB & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_ActorAnimationConstraintTransformBone___);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_VL_Core_VLActorController_CampusActorModelParts__CampusActorDescriptor__ICampusActorDescriptor__TryGetPartsFromAssetName__);
    sub_63CEE78(&StringLiteral___________Prop___________);
    unk_F43BDCB = 1;
  }
  v15 = nullptr;
  v16 = nullptr;
  if ( VL_Core_VLActorController_object__object__object___TryGetPartsFromAssetName(
         a0,
         a1,
         &v16,
         Method_VL_Core_VLActorController_CampusActorModelParts__CampusActorDescriptor__ICampusActorDescriptor__TryGetPartsFromAssetName__) )
  {
    transform = v16;
    if ( v16 )
    {
      v9 = 0;
      do
      {
        transform = UnityEngine_Component__get_transform(transform, nullptr);
        if ( !transform )
          break;
        if ( v9 >= UnityEngine_Transform__get_childCount(transform, nullptr) )
          return;
        transform = v16;
        if ( !v16 )
          break;
        transform = UnityEngine_Component__get_transform(v16, nullptr);
        if ( !transform )
          break;
        transform = UnityEngine_Transform__GetChild(transform, v9, nullptr);
        if ( !transform )
          break;
        transform = (void *)UnityEngine_Component__TryGetComponent_object_(
                              transform,
                              &v15,
                              Method_UnityEngine_Component_TryGetComponent_ActorAnimationConstraintTransformBone___);
        if ( ((unsigned __int8)transform & 1) != 0 )
        {
          if ( !a2 )
            break;
          v10 = v15;
          transform = UnityEngine_GameObject__get_transform(a2, nullptr);
          if ( !v10 )
            break;
          v10[9] = transform;
          sub_63CEE24(v10 + 9, (int)transform, v11, v12, v13, v14);
          transform = v15;
          if ( !v15 )
            break;
          ActorAnimation_ActorAnimationConstraintBoneComponentBase__SetDirty(v15, nullptr);
        }
        transform = v16;
        ++v9;
      }
      while ( v16 );
    }
    sub_63CF120(transform, v7);
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(StringLiteral___________Prop___________, nullptr);
}

