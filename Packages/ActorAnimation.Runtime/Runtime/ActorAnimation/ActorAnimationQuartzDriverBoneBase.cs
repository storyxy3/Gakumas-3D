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
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
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
            return default(int);
        }

        public void UpdateHierarchyDepth()
        {
        }

        public int CompareTo(ActorAnimationQuartzDriverBoneBase other)
        {
            return default(int);
        }

        protected ActorAnimationQuartzDriverBoneBase()
        {
        }
    }
}
