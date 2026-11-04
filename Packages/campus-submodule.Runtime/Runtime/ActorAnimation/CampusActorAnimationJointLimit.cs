namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Animations;

    [Serializable]
    public struct CampusActorAnimationJointLimit
    {
        [CompilerGenerated]
        private readonly PropertyStreamHandle _003CjointLimitNowLimitedHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CjointLimitEyeEnable_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CjointLimitEyeUpLimitHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly PropertySceneHandle _003CjointLimitEyeDownLimitHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly MuscleHandle _003CleftEyeDownUpMuscleHandle_003Ek__BackingField;
        [CompilerGenerated]
        private readonly MuscleHandle _003CrightEyeDownUpMuscleHandle_003Ek__BackingField;
        public readonly PropertyStreamHandle jointLimitNowLimitedHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertyStreamHandle);
            }
        }

        public readonly PropertySceneHandle jointLimitEyeEnable
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly PropertySceneHandle jointLimitEyeUpLimitHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly PropertySceneHandle jointLimitEyeDownLimitHandle
        {
            [CompilerGenerated]
            get
            {
                return default(PropertySceneHandle);
            }
        }

        public readonly MuscleHandle leftEyeDownUpMuscleHandle
        {
            [CompilerGenerated]
            get
            {
                return default(MuscleHandle);
            }
        }

        public readonly MuscleHandle rightEyeDownUpMuscleHandle
        {
            [CompilerGenerated]
            get
            {
                return default(MuscleHandle);
            }
        }

        public CampusActorAnimationJointLimit(PropertyStreamHandle jointLimitNowLimitedHandle, PropertySceneHandle jointLimitEyeEnable, PropertySceneHandle jointLimitEyeUpLimitHandle, PropertySceneHandle jointLimitEyeDownLimitHandle, MuscleHandle leftEyeDownUpMuscleHandle, MuscleHandle rightEyeDownUpMuscleHandle)
        {
            _003CjointLimitNowLimitedHandle_003Ek__BackingField = jointLimitNowLimitedHandle;
            _003CjointLimitEyeEnable_003Ek__BackingField = jointLimitEyeEnable;
            _003CjointLimitEyeUpLimitHandle_003Ek__BackingField = jointLimitEyeUpLimitHandle;
            _003CjointLimitEyeDownLimitHandle_003Ek__BackingField = jointLimitEyeDownLimitHandle;
            _003CleftEyeDownUpMuscleHandle_003Ek__BackingField = leftEyeDownUpMuscleHandle;
            _003CrightEyeDownUpMuscleHandle_003Ek__BackingField = rightEyeDownUpMuscleHandle;
        }

        public void Execute(AnimationStream stream)
        {
        }

        private (float, float) GetEyeLimitRange(AnimationStream stream)
        {
            return default((float, float));
        }

        private void ExecuteEye(AnimationHumanStream humanStream, ref bool isJointLimitEnable, MuscleHandle eyeDownUpMuscleHandle, float eyeUpLimit, float eyeDownLimit)
        {
        }

        private float GetLimit(AnimationStream stream, PropertySceneHandle limitHandle)
        {
            return default(float);
        }

        private void ClampMuscle(AnimationHumanStream humanStream, ref bool isJointLimitEnable, MuscleHandle muscleHandle, float plusLimit, float minusLimit)
        {
        }

        public bool IsValid(AnimationStream stream)
        {
            return default(bool);
        }
    }
}
