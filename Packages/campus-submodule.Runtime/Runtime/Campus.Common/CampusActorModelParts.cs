namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;

    public class CampusActorModelParts : VLDefaultActorModelParts<CampusActorDescriptor>
    {
        public List<ActorSwingDynamicBone> dynamicBones;
        public List<InitialTransform> initialTransforms;
        public List<ActorSwingStaticBone> staticBones;
        public List<ActorSwingBreastBone> breastBones;
        public List<InitialTransform> initialLeftBreastTransforms;
        public List<InitialTransform> initialRightBreastTransforms;
        public List<InitialTransform> initialLeftBreastEndTransforms;
        public List<InitialTransform> initialRightBreastEndTransforms;
        public List<ActorSwingChain> chains;
        public List<VLActorExpressionBone> expressionBones;
        public List<ActorAnimationConstraintTransformBone> constraintTransformBones;
        public List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones;
        public List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones;
        public List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones;
        public List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones;
        public List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones;
        public List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones;
        public List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones;
        public List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones;
        public List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones;
        public List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones;
        public List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones;
        public List<ActorAnimationIKCorrectionCollider> iKCorrectionColliders;
        public List<DecalProjector> decalProjectors;
        private List<MonoBehaviour> _behaviourCache;
        public override void Initialize(string partsId, string assetName)
        {
        }

        private void AddCombinedOpaqueSubMesh(Renderer r, ref List<Material> tempMaterials, Material batchMaterial)
        {
        }

        private void InitializeCampusMaterials()
        {
        }

        protected override void OnRegisterBone(in string boneName, Transform bone)
        {
        }

        internal void UpdateDecalProperty()
        {
            if (decalProjectors != null)
            {
                foreach (var projector in decalProjectors) projector.UpdateDecalProperty();
            }
        }

        public CampusActorModelParts()
        {
        }
    }
}
