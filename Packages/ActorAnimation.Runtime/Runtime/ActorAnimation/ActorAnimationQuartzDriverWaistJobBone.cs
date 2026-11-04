namespace ActorAnimation
{
    using global::System;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::UnityEngine.Animations.Rigging;

    [Serializable]
    public struct ActorAnimationQuartzDriverWaistJobBone : IActorAnimationQuartzDriverJobBone
    {
        private bool _isActive;
        public ReadWriteTransformHandle drivenHandle;
        public ReadOnlyTransformHandle referenceWaistOffsetHandle;
        public ReadOnlyTransformHandle referenceThighOffsetHandle;
        public float weight;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return referenceWaistOffsetHandle.IsValid(stream) && referenceThighOffsetHandle.IsValid(stream) && drivenHandle.IsValid(stream);
        }

        public bool Resolve(AnimationStream stream)
        {
            if (!referenceWaistOffsetHandle.IsResolved(stream))
            {
                referenceWaistOffsetHandle.Resolve(stream);
                if (!referenceWaistOffsetHandle.IsResolved(stream)) return false;
            }
            if (!referenceThighOffsetHandle.IsResolved(stream))
            {
                referenceThighOffsetHandle.Resolve(stream);
                if (!referenceThighOffsetHandle.IsResolved(stream)) return false;
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
            referenceWaistOffsetHandle.GetGlobalTR(stream, out var waistPosition, out var waistRotation);
            var thighPosition = referenceThighOffsetHandle.GetPosition(stream);
            var result = ActorAnimationQuartzDriverWaistBone.Calc(waistPosition, waistRotation, thighPosition, weight);
            drivenHandle.SetLocalRotation(stream, result.Item1);
            drivenHandle.SetPosition(stream, result.Item2);
        }

        public ActorAnimationQuartzDriverWaistJobBone(ActorAnimationQuartzDriverWaistSetting setting, Transform transform, Animator animator)
        {
            _isActive = true;
            drivenHandle = ReadWriteTransformHandle.Bind(animator, transform);
            referenceWaistOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceWaistOffsetBone.transform);
            referenceThighOffsetHandle = ReadOnlyTransformHandle.Bind(animator, setting.referenceThighOffsetBone.transform);
            weight = setting.weight;
        }

        public void Update(ActorAnimationQuartzDriverWaistSetting setting)
        {
            weight = setting.weight;
        }
    }
}
