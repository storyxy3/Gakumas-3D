namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/ActorAnimationSwingChainBone")]
    public class ActorSwingChain : MonoBehaviour, IActorSwingComponent, IActorAnimationBone
    {
        public List<ActorSwingDynamicBone> rootBones;
        public ChainInfo chains;
        private void OnEnable()
        {
        }

        public void UpdateHierarchyDepth()
        {
        }

        public void UpdateChainInfo()
        {
        }

        public ActorSwingChain()
        {
        }

        bool ActorAnimation.IActorSwingComponent.isActiveAndEnabled
        {
            get
            {
                return default(bool);
            }
        }

        Transform ActorAnimation.IActorSwingComponent.transform
        {
            get
            {
                return null;
            }
        }
    }
}
