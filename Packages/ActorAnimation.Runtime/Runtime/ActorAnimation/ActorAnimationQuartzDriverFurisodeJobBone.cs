namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverFurisodeJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandHandle;
        public ReadOnlyTransformHandle referenceForearmHandle;
        public ReadOnlyTransformHandle referenceFurisodeOffsetHandle;
        public ReadOnlyTransformHandle referenceSpineHandle;
        public float3 backWay;
        public float apexAngle;
        public float coefficient;
        public float min;
        public float max;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return referenceHandHandle.IsValid(stream) && referenceForearmHandle.IsValid(stream) && referenceFurisodeOffsetHandle.IsValid(stream) && referenceSpineHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!referenceHandHandle.IsResolved(stream))
            {
                referenceHandHandle.Resolve(stream);
                if (!referenceHandHandle.IsResolved(stream)) return false;
            }
            if (!referenceForearmHandle.IsResolved(stream))
            {
                referenceForearmHandle.Resolve(stream);
                if (!referenceForearmHandle.IsResolved(stream)) return false;
            }
            if (!referenceFurisodeOffsetHandle.IsResolved(stream))
            {
                referenceFurisodeOffsetHandle.Resolve(stream);
                if (!referenceFurisodeOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceSpineHandle.IsResolved(stream))
            {
                referenceSpineHandle.Resolve(stream);
                if (!referenceSpineHandle.IsResolved(stream)) return false;
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
            var handPosition = referenceHandHandle.GetPosition(stream);
            var forearmPosition = referenceForearmHandle.GetPosition(stream);
            var offsetRotation = referenceFurisodeOffsetHandle.GetRotation(stream);
            var spineRotation = referenceSpineHandle.GetRotation(stream);
            drivenHandle.SetLocalRotation(stream, ActorAnimationQuartzDriverFurisodeBone.Calc(handPosition, forearmPosition, offsetRotation, spineRotation, backWay, apexAngle, coefficient, min, max));
        }

        public ActorAnimationQuartzDriverFurisodeJobBone(ActorAnimationQuartzDriverFurisodeSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHandHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceHandBone.transform);
            referenceForearmHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceForearmBone.transform);
            referenceFurisodeOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceFurisodeOffsetBone.transform);
            referenceSpineHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceSpineBone.transform);
            backWay = setting.backWay;
            apexAngle = setting.apexAngle;
            coefficient = setting.coefficient;
            min = setting.min;
            max = setting.max;
        }

        public void Update(ActorAnimationQuartzDriverFurisodeSetting setting)
        {
            backWay = setting.backWay;
            apexAngle = setting.apexAngle;
            coefficient = setting.coefficient;
            min = setting.min;
            max = setting.max;
        }
    }
}
