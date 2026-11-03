namespace VL.Unsafe.Jobs
{
    using global::System;
    using global::Unity.Mathematics;
    using global::UnityEngine.Animations;
    using global::VL;

    [Serializable]
    public struct RigFurisodeData
    {
        public TransformStreamHandle targetHandle;
        public TransformStreamHandle referenceAHandle;
        public TransformStreamHandle referenceBHandle;
        public quaternion initTargetRotation;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionRollArmRotX;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionRollArmRotZ;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionTiltArmRotZ;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionTiltRefArmRotZ;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionTiltArmRotX;
        public VLActorRigFurisodeBone.VLActorRigFurisodeConnection connectionTiltForeArmRotY;
    }
}
