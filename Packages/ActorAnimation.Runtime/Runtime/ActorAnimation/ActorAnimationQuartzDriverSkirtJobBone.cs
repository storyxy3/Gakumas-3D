namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverSkirtJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandle;
        public quaternion initialReferenceRotation;
        public math.RotationOrder rotationOrder;
        public float3 innerCoefficient;
        public float3 outerCoefficient;
        public float3 limitMin;
        public float3 limitMax;
        public math.RotationOrder connectionAxis;
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
            drivenHandle.SetLocalRotation(stream, ActorAnimationQuartzDriverSkirtBone.Calc(initialReferenceRotation, referenceHandle.GetLocalRotation(stream), rotationOrder, innerCoefficient, outerCoefficient, limitMin, limitMax, connectionAxis));
        }

        public ActorAnimationQuartzDriverSkirtJobBone(ActorAnimationQuartzDriverSkirtSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceBone.transform);
            initialReferenceRotation = setting.referenceBone.transform.localRotation;
            rotationOrder = setting.rotationOrder;
            innerCoefficient = setting.innerCoefficient;
            outerCoefficient = setting.outerCoefficient;
            limitMin = setting.limitMin;
            limitMax = setting.limitMax;
            connectionAxis = setting.connectionAxis;
        }

        public void Update(ActorAnimationQuartzDriverSkirtSetting setting)
        {
            rotationOrder = setting.rotationOrder;
            innerCoefficient = setting.innerCoefficient;
            outerCoefficient = setting.outerCoefficient;
            limitMin = setting.limitMin;
            limitMax = setting.limitMax;
            connectionAxis = setting.connectionAxis;
        }
    }
}
