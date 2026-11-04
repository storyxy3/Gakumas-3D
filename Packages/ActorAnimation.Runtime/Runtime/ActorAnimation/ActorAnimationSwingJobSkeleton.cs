namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::Unity.Collections;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationSwingJobSkeleton
    {
        [CompilerGenerated]
        private FloatProperty _003CjobWeight_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003CrootHandle_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003ChipsHandle_003Ek__BackingField;
        [CompilerGenerated]
        private ReadOnlyTransformHandle _003CheightCorrectionBoneHandle_003Ek__BackingField;
        public NativeList<ActorSwingJobDynamicBone> dynamicBones;
        public NativeList<ActorSwingJobStaticBone> staticBones;
        public NativeList<ActorSwingJobBreastBone> breastBones;
        public ActorSwingJobBreastBoneCurve breastBoneCurve;
        public NativeList<ActorSwingJobChainBone> chainBones;
        public NativeHashMap<int, int> instanceIDToDynamicBoneIndex;
        [CompilerGenerated]
        private ActorSwingJobSeatDynamicCorrection _003CseatedDynamicCorrection_003Ek__BackingField;
        [CompilerGenerated]
        private ActorAnimationManageProperty _003CmanageProperty_003Ek__BackingField;
        public bool isCmmnHeightCorrectionNeeded;
        private float _time;
        public ReadOnlyTransformHandle rootHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CrootHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CrootHandle_003Ek__BackingField = value;
            }
        }

        public ReadOnlyTransformHandle hipsHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003ChipsHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003ChipsHandle_003Ek__BackingField = value;
            }
        }

        public ReadOnlyTransformHandle heightCorrectionBoneHandle
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CheightCorrectionBoneHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CheightCorrectionBoneHandle_003Ek__BackingField = value;
            }
        }

        public ActorSwingJobSeatDynamicCorrection seatedDynamicCorrection
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CseatedDynamicCorrection_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CseatedDynamicCorrection_003Ek__BackingField = value;
            }
        }

        public ActorAnimationManageProperty manageProperty
        {
            [CompilerGenerated]
            readonly get
            {
                return _003CmanageProperty_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CmanageProperty_003Ek__BackingField = value;
            }
        }

        public void Execute(AnimationStream stream)
        {
            // TODO(qa-recon): APK swing execution, prewarm, collision and chain solver bodies remain unreconstructed.
        }

        public void ProcessAnimation(AnimationStream stream)
        {
        }

        private void ProcessStaticBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx, float3 heightCorrectionBonePosition, float heightCorrectionBoneScale)
        {
        }

        private void ProcessBreastBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx)
        {
        }

        private void ProcessBreastBoneLayer(float weight, ActorSwingJobLimitInfo limit, quaternion pDynamicDefaultRotation, ref ActorSwingAffineTransform targetBreastTx)
        {
        }

        private void ProcessDynamicBones(AnimationStream stream, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform rootTx, ActorSwingAffineTransform hipsTx, float3 heightCorrectionBonePosition, float heightCorrectionBoneScale)
        {
        }

        private unsafe void ProcessChainBone(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, ref int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
        }

        private unsafe int ProcessChainBoneCollider(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
            return default(int);
        }

        private unsafe bool ProcessChainBoneSmoothing(ActorSwingJobChainBone* pChainHead, ActorSwingJobDynamicBone* pDynamicHead, int depth, int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx)
        {
            return default(bool);
        }

        private float3 ProcessChainBoneSeatedDynamicCorrection(AnimationStream stream, ActorSwingAffineTransform selfTx, ActorSwingAffineTransform childDefaultTx, ActorSwingAffineTransform childTx, ActorSwingAffineTransform invRootTx, float3 cancelRootPosition)
        {
            return default(float3);
        }

        private unsafe void ProcessDynamicBoneLayer(ActorSwingJobDynamicBone* pDynamicHead, int startIndex, int length, float weight, ActorSwingJobChainBone* pChainHead, ref int chainStartIndex, ref ActorAnimationManagePropertyData managePropertyData, ActorSwingAffineTransform hipsTx, float heightCorrectionBoneScale, bool enableSeatedDynamicCorrection)
        {
        }

        private unsafe ActorSwingAffineTransform CalcDynamicSwing(ActorSwingJobDynamicBone* pDynamicHead, ActorSwingJobDynamicBone* pDynamic, float weight)
        {
            return default(ActorSwingAffineTransform);
        }

        private unsafe ActorSwingAffineTransform CalcDynamicSlide(ActorSwingJobDynamicBone* pDynamic, ActorSwingJobDynamicBone* pChildDynamic, float weight)
        {
            return default(ActorSwingAffineTransform);
        }

        private float3 CalcStiffnessPendulum(DynamicType dynamicType, float3 boneAxis, float boneLength, ActorSwingAffineTransform selfTx, ActorSwingAffineTransform childTx, ActorSwingAffineTransform childDefaultTx, float stiffness, float pendulum, float pendulumRange)
        {
            return default(float3);
        }

        private float ScaleScalar(float scalar, float scale)
        {
            return default(float);
        }

        private float3 ScaleDirectionVector(float3 direction, float scale)
        {
            return default(float3);
        }

        private float3 ScalePositionVector(float3 position, float3 origin, float scale)
        {
            return default(float3);
        }

        private void ScaleCollider(ref ActorSwingJobCollider jobCollider, float scale)
        {
        }

        public void ResetTime()
        {
            _time = 0f;
        }
    }
}
