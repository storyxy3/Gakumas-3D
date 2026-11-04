namespace ActorAnimation
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::ActorAnimation;
    using global::UnityEngine;
    using global::UnityEngine.Animations.Rigging;
    using global::UnityEngine.Serialization;

    [AddComponentMenu("ActorAnimation/ActorAnimationSwingDynamicBone")]
    public class ActorSwingDynamicBone : MonoBehaviour, IActorSwingBone, IActorSwingComponent, IActorAnimationBone, IAnimationJobData, IComparable<ActorSwingDynamicBone>
    {
        public ActorSwingDynamicCollider dynamicCollider;
        public ResetType resetType;
        public DynamicType dynamicType;
        [FormerlySerializedAs("dampingPosition")]
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float damping = 0.5f;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float stiffness = 0.05f;
        [SyncSceneToStream]
        [Range(0f, 2f)]
        public float spring;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulum;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulumRange = 1f;
        [SyncSceneToStream]
        public float mass;
        [SyncSceneToStream]
        [Range(0f, 2f)]
        public float axisAddXToY;
        [SyncSceneToStream]
        [Range(0f, 2f)]
        public float axisAddXToZ;
        [SyncSceneToStream]
        [Range(0f, 10f)]
        public float wind = 1f;
        public bool useWindGlobalForce = true;
        public LimitInfo limitInfo = new LimitInfo();
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float rootWeight = 1f;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float seatDynamicCorrection;
        public ReferenceLimitInfo referenceLimitInfo;
        [CompilerGenerated]
        private int _003ChierarchyDepth_003Ek__BackingField;
        [CompilerGenerated]
        private InitialTransform _003CinitialTransform_003Ek__BackingField;
        public InitialTransform modelingTransform;
        [CompilerGenerated]
        private bool _003CisDirty_003Ek__BackingField;
        public ActorSwingCollider swingCollider
        {
            get
            {
                return dynamicCollider;
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

        public InitialTransform initialTransform
        {
            [CompilerGenerated]
            get
            {
                return _003CinitialTransform_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CinitialTransform_003Ek__BackingField = value;
            }
        }

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
            var current = transform;
            int depth = -1;
            while (current != null) { depth++; current = current.parent; }
            return depth;
        }

        public void UpdateHierarchyDepth()
        {
            hierarchyDepth = GetHierarchyDepth();
        }

        public void UpdateInitialTransform(InitialTransform initialTransform)
        {
            this.initialTransform = initialTransform;
        }

        public int CompareTo(ActorSwingDynamicBone other)
        {
            return hierarchyDepth - other.hierarchyDepth;
        }

        public bool IsValid()
        {
            return true;
        }

        public void SetDefaultValues()
        {
        }

        public ActorSwingDynamicBone()
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
    }
}
