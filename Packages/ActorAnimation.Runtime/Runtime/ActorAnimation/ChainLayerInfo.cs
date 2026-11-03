namespace ActorAnimation
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    [Serializable]
    public class ChainLayerInfo : IComparable<ChainLayerInfo>
    {
        [HideInInspector]
        public bool active;
        public bool around;
        public float radius;
        public float smoothing;
        public List<ActorSwingDynamicBone> bones;
        [CompilerGenerated]
        private short _003ChierarchyDepth_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
        public short hierarchyDepth
        {
            [CompilerGenerated]
            get
            {
                return default(short);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

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

        public ChainLayerInfo()
        {
        }

        public ChainLayerInfo(ChainLayerInfo other)
        {
        }

        public void SetHierarchyDepth(int depth)
        {
        }

        public void ResetDirty()
        {
        }

        public int CompareTo(ChainLayerInfo other)
        {
            return default(int);
        }
    }
}
