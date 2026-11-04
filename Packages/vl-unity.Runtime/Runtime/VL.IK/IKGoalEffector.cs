namespace VL.IK
{
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL.IK;

    public class IKGoalEffector : EffectorBase
    {
        private ActorAnimationIKHandleType handleType;
        public AvatarIKGoal goal;
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

        public IKGoalEffector()
        {
        }
    }
}
