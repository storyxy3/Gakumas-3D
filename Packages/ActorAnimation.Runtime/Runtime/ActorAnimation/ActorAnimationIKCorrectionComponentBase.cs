namespace ActorAnimation
{
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    public abstract class ActorAnimationIKCorrectionComponentBase : MonoBehaviour, IActorAnimationBone
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

        public void SetDirty()
        {
        }

        public void ResetDirty()
        {
        }

        protected ActorAnimationIKCorrectionComponentBase()
        {
        }
    }
}
