namespace VL
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine;
    using global::VL;

    public class VLActorRigFurisodeBone : VLActorRigBone
    {
        public enum VLActorRigReferenceBone
        {
            referenceBoneA,
            referenceBoneB
        }

        public enum VLActorRigReferenceAxis
        {
            X,
            Y,
            Z
        }

        [Serializable]
        public struct VLActorRigFurisodeConnection
        {
            public VLActorRigReferenceBone referenceBone;
            public Vector3 posOffset;
            public math.RotationOrder rotationOrder;
            public VLActorRigReferenceAxis maskAxis;
            public float coefficient;
            public float min;
            public float max;
            public VLActorRigReferenceAxis outputAxis;
        }

        [SerializeField]
        private Transform _referenceBoneA;
        [SerializeField]
        private Transform _referenceBoneB;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionRollArmRotX;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionRollArmRotZ;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionTiltArmRotZ;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionTiltRefArmRotZ;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionTiltArmRotX;
        [SerializeField]
        private VLActorRigFurisodeConnection _connectionTiltForeArmRotY;
        public Transform referenceBoneA
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public Transform referenceBoneB
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionRollArmRotX
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionRollArmRotZ
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionTiltArmRotZ
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionTiltRefArmRotZ
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionTiltArmRotX
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeConnection connectionTiltForeArmRotY
        {
            get
            {
                return default(VLActorRigFurisodeConnection);
            }

            set
            {
            }
        }

        public VLActorRigFurisodeBone()
        {
        }
    }
}
