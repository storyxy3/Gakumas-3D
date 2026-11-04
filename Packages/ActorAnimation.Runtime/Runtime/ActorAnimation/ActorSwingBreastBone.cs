namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;
    using global::UnityEngine.Serialization;

    [AddComponentMenu("ActorAnimation/ActorAnimationSwingBreastBone")]
    public class ActorSwingBreastBone : MonoBehaviour, IActorSwingBone, IActorSwingComponent, IActorAnimationBone, IAnimationJobData
    {
        public ActorSwingStaticCollider breastCollider;
        [FormerlySerializedAs("dampingPosition")]
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float damping = 0.5f;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float stiffness = 0.05f;
        [SyncSceneToStream]
        [Range(0f, 2f)]
        public float spring;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulum;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulumRange;
        [SyncSceneToStream]
        [Range(0f, 0.5f)]
        public float average;
        public LimitInfo limitInfo = new LimitInfo();
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float rootWeight = 1f;
        [SyncSceneToStream]
        public bool useArmCorrection = true;
        public Transform leftLowerArm;
        public Transform rightLowerArm;
        public Transform leftBreast;
        public Transform rightBreast;
        public Transform leftBreastEnd;
        public Transform rightBreastEnd;
        public AnimationCurve upCurve;
        public AnimationCurve sideCurve;
        [CompilerGenerated]
        private InitialTransform _003CinitialLeftTransform_003Ek__BackingField;
        [CompilerGenerated]
        private InitialTransform _003CinitialRightTransform_003Ek__BackingField;
        [CompilerGenerated]
        private InitialTransform _003CinitialLeftEndTransform_003Ek__BackingField;
        [CompilerGenerated]
        private InitialTransform _003CinitialRightEndTransform_003Ek__BackingField;
        public InitialTransform modelingLeftTransform;
        public InitialTransform modelingRightTransform;
        public InitialTransform modelingLeftEndTransform;
        public InitialTransform modelingRightEndTransform;
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
        public InitialTransform initialLeftTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CinitialLeftTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CinitialLeftTransform_003Ek__BackingField = value;
            }
        }

        public InitialTransform initialRightTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CinitialRightTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CinitialRightTransform_003Ek__BackingField = value;
            }
        }

        public InitialTransform initialLeftEndTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CinitialLeftEndTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CinitialLeftEndTransform_003Ek__BackingField = value;
            }
        }

        public InitialTransform initialRightEndTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CinitialRightEndTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CinitialRightEndTransform_003Ek__BackingField = value;
            }
        }

        public bool isDirty
        {
            [CompilerGenerated]
            get
            {
                return _003CisDirty_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisDirty_003Ek__BackingField = value;
            }
        }

        public ActorSwingCollider swingCollider
        {
            get
            {
                return breastCollider;
            }
        }

        public void SetDirty()
        {
            isDirty = true;
        }

        public void ResetDirty()
        {
            isDirty = false;
        }

        public void UpdateInitialTransform(InitialTransform initialLeftTransform, InitialTransform initialRightTransform, InitialTransform initialLeftEndTransform, InitialTransform initialRightEndTransform)
        {
            this.initialLeftTransform = initialLeftTransform;
            this.initialRightTransform = initialRightTransform;
            this.initialLeftEndTransform = initialLeftEndTransform;
            this.initialRightEndTransform = initialRightEndTransform;
        }

        public void SetArms(Transform lArm, Transform rArm)
        {
            useArmCorrection = true;
            if (lArm != null) leftLowerArm = lArm;
            if (rArm != null) rightLowerArm = rArm;
        }

        public void SetBreasts(Transform lBreast, Transform rBreast, Transform lBreastEnd, Transform rBreastEnd)
        {
            useArmCorrection = true;
            if (lBreast != null) leftBreast = lBreast;
            if (rBreast != null) rightBreast = rBreast;
            if (lBreastEnd != null) leftBreastEnd = lBreastEnd;
            if (rBreastEnd != null) rightBreastEnd = rBreastEnd;
        }

        public bool IsValid()
        {
            return true;
        }

        public void SetDefaultValues()
        {
        }

        public ActorSwingBreastBone()
        {
        }

        bool ActorAnimation.IActorSwingComponent.isActiveAndEnabled
        {
            get
            {
                return isActiveAndEnabled;
            }
        }

        Transform ActorAnimation.IActorSwingComponent.transform
        {
            get
            {
                return transform;
            }
        }
    }
}
