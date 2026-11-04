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
                return _003CisDirty_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisDirty_003Ek__BackingField = value;
            }
        }

        public abstract ActorAnimationConstraintBoneType GetBoneType();
        public void SetDirty()
        {
            isDirty = true;
        }

        public void ResetDirty()
        {
            isDirty = false;
        }

        protected ActorAnimationConstraintBoneComponentBase()
        {
        }
    }
}
