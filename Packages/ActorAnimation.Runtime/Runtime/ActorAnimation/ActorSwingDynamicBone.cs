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
        public float damping;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float stiffness;
        [SyncSceneToStream]
        [Range(0f, 2f)]
        public float spring;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulum;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float pendulumRange;
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
        public float wind;
        public bool useWindGlobalForce;
        public LimitInfo limitInfo;
        [SyncSceneToStream]
        [Range(0f, 1f)]
        public float rootWeight;
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
                return null;
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

        public InitialTransform initialTransform
        {
            [CompilerGenerated]
            get
            {
                return default(InitialTransform);
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

        public void SetDirty()
        {
        }

        public void ResetDirty()
        {
        }

        public int GetHierarchyDepth()
        {
            return default(int);
        }

        public void UpdateHierarchyDepth()
        {
        }

        public void UpdateInitialTransform(InitialTransform initialTransform)
        {
        }

        public int CompareTo(ActorSwingDynamicBone other)
        {
            return default(int);
        }

        public bool IsValid()
        {
            return default(bool);
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
