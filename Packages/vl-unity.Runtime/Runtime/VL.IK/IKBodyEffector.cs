namespace VL.IK
{
    using global::ActorAnimation;
    using global::VL.IK;

    public class IKBodyEffector : EffectorBase
    {
        private ActorAnimationIKHandleType handleType;
        public ActorAnimationIKHandleType HandleType
        {
            get
            {
                return handleType;
            }

            set
            {
                handleType = value;
            }
        }

        public IKBodyEffector()
        {
        }
    }
}
