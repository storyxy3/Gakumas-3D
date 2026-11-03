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
        public float damping;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float stiffness;
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
        public LimitInfo limitInfo;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float rootWeight;
        [SyncSceneToStream]
        public bool useArmCorrection;
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
                return default(InitialTransform);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public InitialTransform initialRightTransform
        {
            [CompilerGenerated]
            get
            {
                return default(InitialTransform);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public InitialTransform initialLeftEndTransform
        {
            [CompilerGenerated]
            get
            {
                return default(InitialTransform);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public InitialTransform initialRightEndTransform
        {
            [CompilerGenerated]
            get
            {
                return default(InitialTransform);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool isDirty
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public ActorSwingCollider swingCollider
        {
            get
            {
                return null;
            }
        }

        public void SetDirty()
        {
        }

        public void ResetDirty()
        {
        }

        public void UpdateInitialTransform(InitialTransform initialLeftTransform, InitialTransform initialRightTransform, InitialTransform initialLeftEndTransform, InitialTransform initialRightEndTransform)
        {
        }

        public void SetArms(Transform lArm, Transform rArm)
        {
        }

        public void SetBreasts(Transform lBreast, Transform rBreast, Transform lBreastEnd, Transform rBreastEnd)
        {
        }

        public bool IsValid()
        {
            return default(bool);
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
                return default(bool);
            }
        }

        Transform ActorAnimation.IActorSwingComponent.transform
        {
            get
            {
                return null;
            }
        }
    }
}
