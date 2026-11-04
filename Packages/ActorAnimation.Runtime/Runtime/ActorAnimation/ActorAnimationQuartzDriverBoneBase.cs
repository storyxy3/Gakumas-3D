namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;

    public abstract class ActorAnimationQuartzDriverBoneBase : ActorAnimationQuartzDriverBoneComponentBase, IComparable<ActorAnimationQuartzDriverBoneBase>
    {
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
        [CompilerGenerated]
        private int _003ChierarchyDepth_003Ek__BackingField;
        public bool isDirty
        {
            [CompilerGenerated]
            get
            {
                return _003CisDirty_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CisDirty_003Ek__BackingField = value;
            }
        }

        public int hierarchyDepth
        {
            [CompilerGenerated]
            get
            {
                return _003ChierarchyDepth_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003ChierarchyDepth_003Ek__BackingField = value;
            }
        }

        public void SetDirty()
        {
            isDirty = true;
        }

        public void ResetDirty()
        {
            isDirty = false;
        }

        public int GetHierarchyDepth()
        {
            int depth = -1;
            for (var current = transform; current != null; current = current.parent) depth++;
            return depth;
        }

        public void UpdateHierarchyDepth()
        {
            hierarchyDepth = GetHierarchyDepth();
        }

        public int CompareTo(ActorAnimationQuartzDriverBoneBase other)
        {
            return hierarchyDepth - other.hierarchyDepth;
        }

        protected ActorAnimationQuartzDriverBoneBase()
        {
        }
    }
}
