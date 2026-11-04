namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverFrillJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandle;
        public math.RotationOrder rotationOrder;
        public float3 outerMinusCoefficient;
        public float3 innerCoefficient;
        public float3 outerPlusCoefficient;
        public float3 switchMinus;
        public float3 switchPlus;
        public math.RotationOrder connectionAxis;
        public ActorAnimationQuartzDriverRotationDecomposeType decomposeType;
        public ActorAnimationQuartzDriverRotationComposeType composeType;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return referenceHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!referenceHandle.IsResolved(stream))
            {
                referenceHandle.Resolve(stream);
                if (!referenceHandle.IsResolved(stream)) return false;
            }
            if (!drivenHandle.IsResolved(stream))
            {
                drivenHandle.Resolve(stream);
                if (!drivenHandle.IsResolved(stream)) return false;
            }
            return true;
        }

        public void Execute(AnimationStream stream)
        {
            drivenHandle.SetLocalRotation(stream, ActorAnimationQuartzDriverFrillBone.Calc(referenceHandle.GetLocalRotation(stream), rotationOrder, outerMinusCoefficient, innerCoefficient, outerPlusCoefficient, switchMinus, switchPlus, connectionAxis, decomposeType, composeType));
        }

        public ActorAnimationQuartzDriverFrillJobBone(ActorAnimationQuartzDriverFrillSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform.transform);
            referenceHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceBone.transform);
            rotationOrder = setting.rotationOrder;
            outerMinusCoefficient = setting.outerMinusCoefficient;
            innerCoefficient = setting.innerCoefficient;
            outerPlusCoefficient = setting.outerPlusCoefficient;
            switchMinus = setting.switchMinus;
            switchPlus = setting.switchPlus;
            connectionAxis = setting.connectionAxis;
            decomposeType = setting.decomposeType;
            composeType = setting.composeType;
        }

        public void Update(ActorAnimationQuartzDriverFrillSetting setting)
        {
            rotationOrder = setting.rotationOrder;
            outerMinusCoefficient = setting.outerMinusCoefficient;
            innerCoefficient = setting.innerCoefficient;
            outerPlusCoefficient = setting.outerPlusCoefficient;
            switchMinus = setting.switchMinus;
            switchPlus = setting.switchPlus;
            connectionAxis = setting.connectionAxis;
            decomposeType = setting.decomposeType;
            composeType = setting.composeType;
        }
    }
}
