namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverPonchoJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceArmHandle;
        public ReadOnlyTransformHandle referencePonchoOffsetHandle;
        public ReadOnlyTransformHandle referenceArmOffsetHandle;
        public ReadOnlyTransformHandle referenceBodyOffsetHandle;
        public ReadOnlyTransformHandle referenceInnerOffsetHandle;
        public ReadOnlyTransformHandle referenceOuterOffsetHandle;
        public float lerpCoefficient;
        public float innerLimit;
        public float outerLimit;
        public float3 axisWay;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return referenceArmHandle.IsValid(stream) && referencePonchoOffsetHandle.IsValid(stream) && referenceArmOffsetHandle.IsValid(stream) && referenceBodyOffsetHandle.IsValid(stream) && referenceInnerOffsetHandle.IsValid(stream) && referenceOuterOffsetHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!referenceArmHandle.IsResolved(stream))
            {
                referenceArmHandle.Resolve(stream);
                if (!referenceArmHandle.IsResolved(stream)) return false;
            }
            if (!referencePonchoOffsetHandle.IsResolved(stream))
            {
                referencePonchoOffsetHandle.Resolve(stream);
                if (!referencePonchoOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceArmOffsetHandle.IsResolved(stream))
            {
                referenceArmOffsetHandle.Resolve(stream);
                if (!referenceArmOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceBodyOffsetHandle.IsResolved(stream))
            {
                referenceBodyOffsetHandle.Resolve(stream);
                if (!referenceBodyOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceInnerOffsetHandle.IsResolved(stream))
            {
                referenceInnerOffsetHandle.Resolve(stream);
                if (!referenceInnerOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceOuterOffsetHandle.IsResolved(stream))
            {
                referenceOuterOffsetHandle.Resolve(stream);
                if (!referenceOuterOffsetHandle.IsResolved(stream)) return false;
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
            var armRotation = referenceArmHandle.GetLocalRotation(stream);
            var offsetPosition = referencePonchoOffsetHandle.GetPosition(stream);
            var offsetRotation = referencePonchoOffsetHandle.GetRotation(stream);
            var armPosition = referenceArmOffsetHandle.GetPosition(stream);
            var bodyPosition = referenceBodyOffsetHandle.GetPosition(stream);
            var innerPosition = referenceInnerOffsetHandle.GetLocalPosition(stream);
            var outerPosition = referenceOuterOffsetHandle.GetLocalPosition(stream);
            var result = ActorAnimationQuartzDriverPonchoBone.Calc(armRotation, offsetPosition, offsetRotation, armPosition, bodyPosition, innerPosition, outerPosition, lerpCoefficient, innerLimit, outerLimit, axisWay);
            drivenHandle.SetLocalRotation(stream, result.Item1);
            drivenHandle.SetLocalPosition(stream, result.Item2);
        }

        public ActorAnimationQuartzDriverPonchoJobBone(ActorAnimationQuartzDriverPonchoSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceArmHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceArmBone.transform);
            referencePonchoOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referencePonchoOffsetBone.transform);
            referenceArmOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceArmOffsetBone.transform);
            referenceBodyOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceBodyOffsetBone.transform);
            referenceInnerOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceInnerOffsetBone.transform);
            referenceOuterOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceOuterOffsetBone.transform);
            lerpCoefficient = setting.lerpCoefficient;
            innerLimit = setting.innerLimit;
            outerLimit = setting.outerLimit;
            axisWay = setting.axisWay;
        }

        public void Update(ActorAnimationQuartzDriverPonchoSetting setting)
        {
            lerpCoefficient = setting.lerpCoefficient;
            innerLimit = setting.innerLimit;
            outerLimit = setting.outerLimit;
            axisWay = setting.axisWay;
        }
    }
}
