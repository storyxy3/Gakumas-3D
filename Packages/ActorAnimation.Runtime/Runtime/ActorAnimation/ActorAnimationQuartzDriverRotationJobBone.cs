namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverRotationJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHandle;
        public math.RotationOrder rotationOrder;
        public float3 limitMin;
        public float3 limitMax;
        public float3 coefficient;
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
            drivenHandle.SetLocalRotation(stream, ActorAnimationQuartzDriverRotationBone.Calc(referenceHandle.GetLocalRotation(stream), rotationOrder, coefficient, limitMin, limitMax, connectionAxis, decomposeType, composeType));
        }

        public ActorAnimationQuartzDriverRotationJobBone(ActorAnimationQuartzDriverRotationSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceBone.transform);
            rotationOrder = setting.rotationOrder;
            limitMin = setting.limitMin;
            limitMax = setting.limitMax;
            coefficient = setting.coefficient;
            connectionAxis = setting.connectionAxis;
            decomposeType = setting.decomposeType;
            composeType = setting.composeType;
        }

        public void Update(ActorAnimationQuartzDriverRotationSetting setting)
        {
            rotationOrder = setting.rotationOrder;
            limitMin = setting.limitMin;
            limitMax = setting.limitMax;
            coefficient = setting.coefficient;
            connectionAxis = setting.connectionAxis;
            decomposeType = setting.decomposeType;
            composeType = setting.composeType;
        }
    }
}
