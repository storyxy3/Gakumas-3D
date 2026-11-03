namespace ActorAnimation
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    [AddComponentMenu("ActorAnimation/ActorAnimationSwingChainBone")]
    public class ActorSwingChain : MonoBehaviour, IActorSwingComponent, IActorAnimationBone
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass4_0
        {
            public ActorSwingDynamicBone bone;
            public _003C_003Ec__DisplayClass4_0()
            {
            }

            internal bool _003CUpdateChainInfo_003Eb__1(ActorSwingDynamicBone x)
            {
                return default(bool);
            }
        }

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

        [CompilerGenerated]
        private bool _003CUpdateChainInfo_003Eb__4_0(ChainLayerInfo x)
        {
            return default(bool);
        }
    }
}
