// 0xdddecfc @ 0xdddecfc
void __fastcall Campus_Common_CampusActorController__ClearPropFieldConstraintTarget(void *a0, void *a1, void *a2)
{
  __int64 v5; // x1
  void *transform; // x0
  int v7; // w19
  void *v8; // [xsp+8h] [xbp+8h] BYREF
  void *v9; // [xsp+18h] [xbp+18h] BYREF

  if ( (unk_F43BDCC & 1) == 0 )
  {
    sub_63CEE78(&Method_UnityEngine_Component_TryGetComponent_ActorAnimationConstraintTransformBone___);
    sub_63CEE78(&UnityEngine_Debug_TypeInfo);
    sub_63CEE78(&Method_VL_Core_VLActorController_CampusActorModelParts__CampusActorDescriptor__ICampusActorDescriptor__TryGetPartsFromAssetName__);
    sub_63CEE78(&StringLiteral___________Prop___________);
    unk_F43BDCC = 1;
  }
  v9 = nullptr;
  v8 = nullptr;
  if ( VL_Core_VLActorController_object__object__object___TryGetPartsFromAssetName(
         a0,
         a1,
         &v9,
         Method_VL_Core_VLActorController_CampusActorModelParts__CampusActorDescriptor__ICampusActorDescriptor__TryGetPartsFromAssetName__) )
  {
    transform = v9;
    if ( v9 )
    {
      v7 = 0;
      do
      {
        transform = UnityEngine_Component__get_transform(transform, nullptr);
        if ( !transform )
          break;
        if ( v7 >= UnityEngine_Transform__get_childCount(transform, nullptr) )
          return;
        transform = v9;
        if ( !v9 )
          break;
        transform = UnityEngine_Component__get_transform(v9, nullptr);
        if ( !transform )
          break;
        transform = UnityEngine_Transform__GetChild(transform, v7, nullptr);
        if ( !transform )
          break;
        if ( UnityEngine_Component__TryGetComponent_object_(
               transform,
               &v8,
               Method_UnityEngine_Component_TryGetComponent_ActorAnimationConstraintTransformBone___) )
        {
          transform = v8;
          if ( !v8 )
            break;
          ActorAnimation_ActorAnimationConstraintTransformBone__ClearFieldSource(v8, nullptr);
          transform = v8;
          if ( !v8 )
            break;
          ActorAnimation_ActorAnimationConstraintBoneComponentBase__SetDirty(v8, nullptr);
        }
        transform = v9;
        ++v7;
      }
      while ( v9 );
    }
    sub_63CF120(transform, v5);
  }
  if ( !*(_DWORD *)(UnityEngine_Debug_TypeInfo + 228LL) )
    sub_63CEFF4(UnityEngine_Debug_TypeInfo);
  UnityEngine_Debug__LogError(StringLiteral___________Prop___________, nullptr);
}

