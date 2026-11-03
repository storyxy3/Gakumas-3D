namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;

    public class ActorAnimationIKCorrectionCollider : ActorAnimationIKCorrectionComponentBase, IComparable<ActorAnimationIKCorrectionCollider>
    {
        public ActorAnimationIKCorrectionColliderType type;
        [Range(0f, 1f)]
        public float weight;
        [Range(0f, 1f)]
        public float radius;
        [Range(0f, 1f)]
        public float radiusSub;
        [Range(0f, 1f)]
        public float dampArea;
        [Range(0f, 1f)]
        public float length;
        public Vector3 offset;
        public Vector3 rotation;
        [CompilerGenerated]
        private int _003ChierarchyDepth_003Ek__BackingField;
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

        public int GetHierarchyDepth()
        {
            return default(int);
        }

        public void UpdateHierarchyDepth()
        {
        }

        public int CompareTo(ActorAnimationIKCorrectionCollider other)
        {
            return default(int);
        }

        public ActorAnimationIKCorrectionCollider()
        {
        }
    }
}
