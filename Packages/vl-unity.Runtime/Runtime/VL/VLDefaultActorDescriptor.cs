namespace VL
{
    using global::System;
    using global::UnityEngine;
    using global::VL;
    using global::VL.Core;

    [Serializable]
    public class VLDefaultActorDescriptor : VLActorDescriptor, IVLDefaultActorDescriptor, IVLActorDescriptor
    {
        [SerializeField]
        private bool _humanoid;
        [SerializeField]
        private VLActorColliderType _colliderType;
        [SerializeField]
        private bool _colliderTrigger;
        public bool humanoid
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public VLActorColliderType colliderType
        {
            get
            {
                return default(VLActorColliderType);
            }

            set
            {
            }
        }

        public bool colliderTrigger
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public VLDefaultActorDescriptor()
        {
        }
    }
}
