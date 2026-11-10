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
        private bool _colliderTrigger = true;
        public bool humanoid
        {
            get
            {
                return _humanoid;
            }

            set
            {
                _humanoid = value;
            }
        }

        public VLActorColliderType colliderType
        {
            get
            {
                return _colliderType;
            }

            set
            {
                _colliderType = value;
            }
        }

        public bool colliderTrigger
        {
            get
            {
                return _colliderTrigger;
            }

            set
            {
                _colliderTrigger = value;
            }
        }

        public VLDefaultActorDescriptor()
        {
        }
    }
}
