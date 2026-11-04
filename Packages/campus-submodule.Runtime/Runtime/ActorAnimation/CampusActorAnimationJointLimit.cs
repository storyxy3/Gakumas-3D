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
                return _003CjointLimitNowLimitedHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle jointLimitEyeEnable
        {
            [CompilerGenerated]
            get
            {
                return _003CjointLimitEyeEnable_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle jointLimitEyeUpLimitHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CjointLimitEyeUpLimitHandle_003Ek__BackingField;
            }
        }

        public readonly PropertySceneHandle jointLimitEyeDownLimitHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CjointLimitEyeDownLimitHandle_003Ek__BackingField;
            }
        }

        public readonly MuscleHandle leftEyeDownUpMuscleHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CleftEyeDownUpMuscleHandle_003Ek__BackingField;
            }
        }

        public readonly MuscleHandle rightEyeDownUpMuscleHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CrightEyeDownUpMuscleHandle_003Ek__BackingField;
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
            var humanStream = stream.AsHuman();
            if (!humanStream.isValid || !jointLimitEyeEnable.IsValid(stream)) return;
            bool limited = false;
            if (jointLimitEyeEnable.GetBool(stream))
            {
                var range = GetEyeLimitRange(stream);
                ExecuteEye(humanStream, ref limited, leftEyeDownUpMuscleHandle, range.Item1, range.Item2);
                ExecuteEye(humanStream, ref limited, rightEyeDownUpMuscleHandle, range.Item1, range.Item2);
            }
            if (jointLimitNowLimitedHandle.IsValid(stream)) jointLimitNowLimitedHandle.SetBool(stream, limited);
        }

        private (float, float) GetEyeLimitRange(AnimationStream stream)
        {
            return (GetLimit(stream, jointLimitEyeUpLimitHandle), GetLimit(stream, jointLimitEyeDownLimitHandle));
        }

        private void ExecuteEye(AnimationHumanStream humanStream, ref bool isJointLimitEnable, MuscleHandle eyeDownUpMuscleHandle, float eyeUpLimit, float eyeDownLimit)
        {
            ClampMuscle(humanStream, ref isJointLimitEnable, eyeDownUpMuscleHandle, eyeUpLimit, eyeDownLimit);
        }

        private float GetLimit(AnimationStream stream, PropertySceneHandle limitHandle)
        {
            return limitHandle.IsValid(stream) ? limitHandle.GetFloat(stream) : 10f;
        }

        private void ClampMuscle(AnimationHumanStream humanStream, ref bool isJointLimitEnable, MuscleHandle muscleHandle, float plusLimit, float minusLimit)
        {
            float muscle = humanStream.GetMuscle(muscleHandle);
            if (muscle < minusLimit || muscle > plusLimit)
            {
                isJointLimitEnable = true;
                humanStream.SetMuscle(muscleHandle, Unity.Mathematics.math.clamp(muscle, minusLimit, plusLimit));
            }
        }

        public bool IsValid(AnimationStream stream)
        {
            return jointLimitEyeUpLimitHandle.IsValid(stream) && jointLimitEyeDownLimitHandle.IsValid(stream);
        }
    }
}
