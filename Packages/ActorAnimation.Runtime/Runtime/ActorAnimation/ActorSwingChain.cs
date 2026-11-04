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
                return x == bone;
            }
        }

        public List<ActorSwingDynamicBone> rootBones = new List<ActorSwingDynamicBone>();
        public ChainInfo chains = new ChainInfo();
        private void OnEnable()
        {
            if (rootBones == null) rootBones = new List<ActorSwingDynamicBone>();
        }

        public void UpdateHierarchyDepth()
        {
            if (chains?.layers?.Count >= 1)
            {
                if (chains.layers[0].bones == null || chains.layers[0].bones.Count < 1) return;
                if (chains.layers[0].bones[0] != null)
                {
                    int depth = -1;
                    for (int i = 0; i < chains.layers.Count; i++)
                    {
                        if (i == 0)
                        {
                            for (var parent = chains.layers[0].bones[0].transform; parent != null; parent = parent.parent) depth++;
                        }
                        else depth++;
                        chains.layers[i].SetHierarchyDepth(depth);
                    }
                }
            }
        }

        public void UpdateChainInfo()
        {
            var updated = new ChainInfo();
            foreach (var bone in rootBones)
            {
                var closure = new _003C_003Ec__DisplayClass4_0 { bone = bone };
                if (chains.layers.Count > 0)
                {
                    int index = chains.layers[0].bones.FindIndex(closure._003CUpdateChainInfo_003Eb__1);
                    if (index >= 0)
                    {
                        for (int layer = 0; layer < chains.layers.Count; layer++)
                        {
                            if (updated.layers.Count < chains.layers.Count)
                                updated.layers.Add(new ChainLayerInfo(chains.layers[layer]));
                            if (index < chains.layers[layer].bones.Count)
                                updated.layers[layer].bones.Add(chains.layers[layer].bones[index]);
                        }
                        continue;
                    }
                }
                var current = closure.bone;
                int depth = 0;
                while (current != null)
                {
                    if (updated.layers.Count < depth + 1) updated.layers.Add(new ChainLayerInfo());
                    updated.layers[depth].bones.Add(current);
                    if (current.transform.childCount > 0)
                        current.transform.GetChild(0).TryGetComponent(out current);
                    else current = null;
                    depth++;
                }
            }
            updated.layers.RemoveAll(_003CUpdateChainInfo_003Eb__4_0);
            chains = updated;
        }

        public ActorSwingChain()
        {
        }

        bool ActorAnimation.IActorSwingComponent.isActiveAndEnabled
        {
            get
            {
                return isActiveAndEnabled;
            }
        }

        Transform ActorAnimation.IActorSwingComponent.transform
        {
            get
            {
                return transform;
            }
        }

        [CompilerGenerated]
        private bool _003CUpdateChainInfo_003Eb__4_0(ChainLayerInfo x)
        {
            return x.bones.Contains(null) || x.bones.Count != rootBones.Count;
        }
    }
}
