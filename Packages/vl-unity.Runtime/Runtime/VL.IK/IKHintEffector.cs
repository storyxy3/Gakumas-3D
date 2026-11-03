namespace VL.IK
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL.IK;

    public class IKHintEffector : EffectorBase
    {
        private ActorAnimationIKHandleType handleType;
        public AvatarIKHint hint;
        public ActorAnimationIKHandleType HandleType
        {
            get
            {
                return default(ActorAnimationIKHandleType);
            }

            set
            {
            }
        }

        public IKHintEffector()
        {
        }
    }
}
