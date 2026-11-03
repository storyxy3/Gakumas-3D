namespace Campus.Gasha
{
    using global::Campus.Common;
    using global::JetBrains.Annotations;
    using global::UnityEngine;
    using global::VL;

    public class GashaGlobalEffectBindParam
    {
        public Camera uiCamera;
        public int contentsSortingLayerId;
        public int contentFrontSortingLayerId;
        public int overlaySortingLayerId;
        public CampusButton skipButton;
        [CanBeNull]
        public CampusActorDescriptor actorDescriptor;
        [CanBeNull]
        public ActorMotionDefine actorMotionDefine;
        public GashaGlobalEffectBindParam()
        {
        }
    }
}
