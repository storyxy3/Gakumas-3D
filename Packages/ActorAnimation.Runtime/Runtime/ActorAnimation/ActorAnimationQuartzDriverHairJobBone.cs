namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverHairJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceHeadHandle;
        public ReadOnlyTransformHandle referenceNeckHandle;
        public math.RotationOrder translateConnectionAxis;
        public float3 headTranslateCoefficient;
        public float3 headTranslateLimitMin;
        public float3 headTranslateLimitMax;
        public math.RotationOrder rotationOrder;
        public float3 headRotateCoefficient;
        public float3 headRotateLimitMin;
        public float3 headRotateLimitMax;
        public math.RotationOrder rotateConnectionAxis;
        public float3 neckRotateCoefficient;
        public float3 neckRotateLimitMin;
        public float3 neckRotateLimitMax;
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
            return referenceHeadHandle.IsValid(stream) && referenceNeckHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!referenceHeadHandle.IsResolved(stream))
            {
                referenceHeadHandle.Resolve(stream);
                if (!referenceHeadHandle.IsResolved(stream)) return false;
            }
            if (!referenceNeckHandle.IsResolved(stream))
            {
                referenceNeckHandle.Resolve(stream);
                if (!referenceNeckHandle.IsResolved(stream)) return false;
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
            var result = ActorAnimationQuartzDriverHairBone.Calc(referenceHeadHandle.GetLocalRotation(stream), referenceNeckHandle.GetLocalRotation(stream), translateConnectionAxis, headTranslateCoefficient, headTranslateLimitMin, headTranslateLimitMax, rotationOrder, headRotateCoefficient, headRotateLimitMin, headRotateLimitMax, rotateConnectionAxis, neckRotateCoefficient, neckRotateLimitMin, neckRotateLimitMax, composeType);
            drivenHandle.SetLocalRotation(stream, result.Item1);
            drivenHandle.SetLocalPosition(stream, result.Item2);
        }

        public ActorAnimationQuartzDriverHairJobBone(ActorAnimationQuartzDriverHairSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceHeadHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceHeadBone.transform);
            referenceNeckHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceNeckBone.transform);
            translateConnectionAxis = setting.translateConnectionAxis;
            headTranslateCoefficient = setting.headTranslateCoefficient;
            headTranslateLimitMin = setting.headTranslateLimitMin;
            headTranslateLimitMax = setting.headTranslateLimitMax;
            rotationOrder = setting.rotationOrder;
            headRotateCoefficient = setting.headRotateCoefficient;
            headRotateLimitMin = setting.headRotateLimitMin;
            headRotateLimitMax = setting.headRotateLimitMax;
            rotateConnectionAxis = setting.rotateConnectionAxis;
            neckRotateCoefficient = setting.neckRotateCoefficient;
            neckRotateLimitMin = setting.neckRotateLimitMin;
            neckRotateLimitMax = setting.neckRotateLimitMax;
            composeType = setting.composeType;
        }

        public void Update(ActorAnimationQuartzDriverHairSetting setting)
        {
            translateConnectionAxis = setting.translateConnectionAxis;
            headTranslateCoefficient = setting.headTranslateCoefficient;
            headTranslateLimitMin = setting.headTranslateLimitMin;
            headTranslateLimitMax = setting.headTranslateLimitMax;
            rotationOrder = setting.rotationOrder;
            headRotateCoefficient = setting.headRotateCoefficient;
            headRotateLimitMin = setting.headRotateLimitMin;
            headRotateLimitMax = setting.headRotateLimitMax;
            rotateConnectionAxis = setting.rotateConnectionAxis;
            neckRotateCoefficient = setting.neckRotateCoefficient;
            neckRotateLimitMin = setting.neckRotateLimitMin;
            neckRotateLimitMax = setting.neckRotateLimitMax;
            composeType = setting.composeType;
        }
    }
}
