namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;

    [AddComponentMenu("ActorAnimation/ActorAnimationSwingStaticBone")]
    public class ActorSwingStaticBone : MonoBehaviour, IActorSwingBone, IActorSwingComponent, IActorAnimationBone, IAnimationJobData
    {
        public ActorSwingStaticCollider staticCollider;
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
        public ActorSwingCollider swingCollider
        {
            get
            {
                return null;
            }
        }

        public ActorSwingJobCollisionMask seatDynamicCorrectionDisableCollisionMask
        {
            get
            {
                return default(ActorSwingJobCollisionMask);
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

        public void SetDirty()
        {
        }

        public void ResetDirty()
        {
        }

        public bool IsValid()
        {
            return default(bool);
        }

        public void SetDefaultValues()
        {
        }

        public ActorSwingStaticBone()
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
