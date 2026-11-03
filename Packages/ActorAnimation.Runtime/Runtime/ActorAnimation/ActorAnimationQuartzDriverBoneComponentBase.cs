namespace ActorAnimation
{
    using global::ActorAnimation;
    using global::UnityEngine;

    public abstract class ActorAnimationQuartzDriverBoneComponentBase : MonoBehaviour, IActorAnimationBone
    {
        public abstract ActorAnimationQuartzDriverBoneType GetBoneType();
        protected ActorAnimationQuartzDriverBoneComponentBase()
        {
        }
    }
}
