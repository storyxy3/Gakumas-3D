namespace Campus.Common
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::Campus.Common;
    using global::UnityEngine;
    using global::UnityEngine.Rendering.Universal;
    using global::VL;
    using global::VL.Core;

    public class CampusActorModelParts : VLDefaultActorModelParts<CampusActorDescriptor>
    {
        public List<ActorSwingDynamicBone> dynamicBones = new List<ActorSwingDynamicBone>(64);
        public List<InitialTransform> initialTransforms = new List<InitialTransform>(64);
        public List<ActorSwingStaticBone> staticBones = new List<ActorSwingStaticBone>(24);
        public List<ActorSwingBreastBone> breastBones = new List<ActorSwingBreastBone>(1);
        public List<InitialTransform> initialLeftBreastTransforms = new List<InitialTransform>(1);
        public List<InitialTransform> initialRightBreastTransforms = new List<InitialTransform>(1);
        public List<InitialTransform> initialLeftBreastEndTransforms = new List<InitialTransform>(1);
        public List<InitialTransform> initialRightBreastEndTransforms = new List<InitialTransform>(1);
        public List<ActorSwingChain> chains = new List<ActorSwingChain>(64);
        public List<VLActorExpressionBone> expressionBones = new List<VLActorExpressionBone>(32);
        public List<ActorAnimationConstraintTransformBone> constraintTransformBones = new List<ActorAnimationConstraintTransformBone>(8);
        public List<ActorAnimationQuartzDriverRotationBone> quartzDriverRotationBones = new List<ActorAnimationQuartzDriverRotationBone>(16);
        public List<ActorAnimationQuartzDriverFrillBone> quartzDriverFrillBones = new List<ActorAnimationQuartzDriverFrillBone>(4);
        public List<ActorAnimationQuartzDriverSkirtBone> quartzDriverSkirtBones = new List<ActorAnimationQuartzDriverSkirtBone>(12);
        public List<ActorAnimationQuartzDriverHairBone> quartzDriverHairBones = new List<ActorAnimationQuartzDriverHairBone>(10);
        public List<ActorAnimationQuartzDriverHumanoidHandBone> quartzDriverHumanoidHandBones = new List<ActorAnimationQuartzDriverHumanoidHandBone>(4);
        public List<ActorAnimationQuartzDriverHumanoidSleeveBone> quartzDriverHumanoidSleeveBones = new List<ActorAnimationQuartzDriverHumanoidSleeveBone>(8);
        public List<ActorAnimationQuartzDriverHumanoidUpLegBone> quartzDriverHumanoidUpLegBones = new List<ActorAnimationQuartzDriverHumanoidUpLegBone>(4);
        public List<ActorAnimationQuartzDriverHumanoidArmBone> quartzDriverHumanoidArmBones = new List<ActorAnimationQuartzDriverHumanoidArmBone>(4);
        public List<ActorAnimationQuartzDriverWaistBone> quartzDriverWaistBones = new List<ActorAnimationQuartzDriverWaistBone>(2);
        public List<ActorAnimationQuartzDriverFurisodeBone> quartzDriverFurisodeBones = new List<ActorAnimationQuartzDriverFurisodeBone>(4);
        public List<ActorAnimationQuartzDriverPonchoBone> quartzDriverPonchoBones = new List<ActorAnimationQuartzDriverPonchoBone>(6);
        public List<ActorAnimationIKCorrectionCollider> iKCorrectionColliders = new List<ActorAnimationIKCorrectionCollider>(8);
        public List<DecalProjector> decalProjectors = new List<DecalProjector>(16);
        private List<MonoBehaviour> _behaviourCache = new List<MonoBehaviour>(16);
        public override void Initialize(string partsId, string assetName)
        {
            this.assetName = assetName;
            this.partsId = partsId;
            _rendererActive = true;
            renderers = new List<Renderer>(16);
            skinRenderers = new List<SkinnedMeshRenderer>(16);
            rendererGameObjects = new List<GameObject>(16);
            aabbTransform = new List<Transform>(256);
            _boneMap = new BoneNameToTransformDictionary(256);
            _boneInfos = new List<DefaultBoneInfo>(256);
            _instanceIDToDefaultBoneInfoIndexMap = new InstanceIDToDefaultBoneInfoIndexDictionary(256);
            ProcessBones();
            UpdateSkinnedMeshRenderers();
            InitializeCampusMaterials();
        }

        private void AddCombinedOpaqueSubMesh(Renderer r, ref List<Material> tempMaterials, Material batchMaterial)
        {
        }

        private void InitializeCampusMaterials()
        {
            if (materials != null) DisposeMaterials();
            else materials = new List<MaterialInfo>(16);
            if (renderers == null) return;
            bool isPlaying = Application.isPlaying;
            if (isPlaying) Resources.Load<Material>("CampusActorBatchMaterial");
            foreach (var renderer in renderers)
            {
                if (renderer == null) continue;
                var shared = global::UnityEngine.Rendering.ListPool<Material>.Get();
                renderer.GetSharedMaterials(shared);
                if (isPlaying)
                {
                    var instances = global::UnityEngine.Rendering.ListPool<Material>.Get();
                    renderer.GetMaterials(instances);
                    for (int i = 0; i < instances.Count; i++)
                        materials.Add(new MaterialInfo(i < shared.Count ? shared[i] : null, renderer, i, instances[i]));
                    global::UnityEngine.Rendering.ListPool<Material>.Release(instances);
                }
                else
                {
                    for (int i = 0; i < shared.Count; i++) materials.Add(new MaterialInfo(shared[i], renderer, i, null));
                }
                global::UnityEngine.Rendering.ListPool<Material>.Release(shared);
            }
        }

        protected override void OnRegisterBone(in string boneName, Transform bone)
        {
            bone.GetComponents(_behaviourCache);
            for (int i = 0; i < _behaviourCache.Count; i++)
            {
                switch (_behaviourCache[i])
                {
                    case VLActorExpressionBone expression:
                        expressionBones.Add(expression);
                        break;
                    case ActorAnimationIKCorrectionCollider collider:
                        iKCorrectionColliders.Add(collider);
                        break;
                    case ActorSwingDynamicBone dynamicBone:
                        dynamicBones.Add(dynamicBone);
                        var initial = _boneInfos[_boneInfos.Count - 1];
                        initialTransforms.Add(new InitialTransform
                        {
                            localPosition = initial.localPosition,
                            localRotation = initial.localRotation,
                            position = initial.position,
                            rotation = initial.rotation
                        });
                        break;
                    case ActorSwingStaticBone staticBone:
                        staticBones.Add(staticBone);
                        break;
                    case ActorSwingBreastBone breast:
                        breastBones.Add(breast);
                        initialLeftBreastTransforms.Add(new InitialTransform
                        {
                            localPosition = breast.leftBreast.localPosition,
                            localRotation = breast.leftBreast.localRotation,
                            position = breast.leftBreast.position,
                            rotation = breast.leftBreast.rotation
                        });
                        initialRightBreastTransforms.Add(new InitialTransform
                        {
                            localPosition = breast.rightBreast.localPosition,
                            localRotation = breast.rightBreast.localRotation,
                            position = breast.rightBreast.position,
                            rotation = breast.rightBreast.rotation
                        });
                        initialLeftBreastEndTransforms.Add(new InitialTransform
                        {
                            localPosition = breast.leftBreastEnd.localPosition,
                            localRotation = breast.leftBreastEnd.localRotation,
                            position = breast.leftBreastEnd.position,
                            rotation = breast.leftBreastEnd.rotation
                        });
                        initialRightBreastEndTransforms.Add(new InitialTransform
                        {
                            localPosition = breast.rightBreastEnd.localPosition,
                            localRotation = breast.rightBreastEnd.localRotation,
                            position = breast.rightBreastEnd.position,
                            rotation = breast.rightBreastEnd.rotation
                        });
                        break;
                    case ActorSwingChain item:
                        chains.Add(item);
                        break;
                    case ActorAnimationConstraintTransformBone item:
                        constraintTransformBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverRotationBone item:
                        quartzDriverRotationBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverFrillBone item:
                        quartzDriverFrillBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverSkirtBone item:
                        quartzDriverSkirtBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverHairBone item:
                        quartzDriverHairBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverHumanoidHandBone item:
                        quartzDriverHumanoidHandBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverHumanoidSleeveBone item:
                        quartzDriverHumanoidSleeveBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverHumanoidUpLegBone item:
                        quartzDriverHumanoidUpLegBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverHumanoidArmBone item:
                        quartzDriverHumanoidArmBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverWaistBone item:
                        quartzDriverWaistBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverFurisodeBone item:
                        quartzDriverFurisodeBones.Add(item);
                        break;
                    case ActorAnimationQuartzDriverPonchoBone item:
                        quartzDriverPonchoBones.Add(item);
                        break;
                    case DecalProjector item:
                        decalProjectors.Add(item);
                        break;
                }
            }
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
