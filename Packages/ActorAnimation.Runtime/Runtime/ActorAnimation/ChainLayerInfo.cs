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
        public float radius = 0.05f;
        public float smoothing;
        public List<ActorSwingDynamicBone> bones = new List<ActorSwingDynamicBone>();
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
            active = other.active;
            radius = other.radius;
            smoothing = other.smoothing;
        }

        public void SetHierarchyDepth(int depth)
        {
        }

        public void ResetDirty()
        {
        }

        public int CompareTo(ChainLayerInfo other)
        {
            return _003ChierarchyDepth_003Ek__BackingField - other._003ChierarchyDepth_003Ek__BackingField;
        }
    }
}
