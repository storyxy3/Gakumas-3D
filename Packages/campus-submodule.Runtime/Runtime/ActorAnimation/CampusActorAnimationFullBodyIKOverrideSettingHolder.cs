namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::VL.IK;

    public class CampusActorAnimationFullBodyIKOverrideSettingHolder : MonoBehaviour
    {
        public ActorAnimationIKHandleType iKHandleType;
        public EffectorBase[] overrideEffectorBases;
        public List<EffectorBase> OverrideEffectorBases(List<EffectorBase> originalEffectorBases)
        {
            return null;
        }

        public CampusActorAnimationFullBodyIKOverrideSettingHolder()
        {
        }
    }
}
