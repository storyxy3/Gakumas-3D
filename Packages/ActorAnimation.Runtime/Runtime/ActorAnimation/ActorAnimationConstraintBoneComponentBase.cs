namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    public abstract class ActorAnimationConstraintBoneComponentBase : MonoBehaviour, IActorAnimationBone
    {
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
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

        public abstract ActorAnimationConstraintBoneType GetBoneType();
        public void SetDirty()
        {
            _003CisDirty_003Ek__BackingField = true;
        }

        public void ResetDirty()
        {
        }

        protected ActorAnimationConstraintBoneComponentBase()
        {
        }
    }
}
