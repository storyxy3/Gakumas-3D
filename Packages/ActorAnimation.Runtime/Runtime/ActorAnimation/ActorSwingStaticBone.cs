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
                return staticCollider;
            }
        }

        public ActorSwingJobCollisionMask seatDynamicCorrectionDisableCollisionMask
        {
            get
            {
                return staticCollider.seatDynamicCorrectionDisableCollisionMask;
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

        public void SetDirty()
        {
            isDirty = true;
        }

        public void ResetDirty()
        {
            isDirty = false;
        }

        public bool IsValid()
        {
            return true;
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
