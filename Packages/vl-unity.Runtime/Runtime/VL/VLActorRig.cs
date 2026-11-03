namespace VL
{
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Unsafe.Jobs;

    [ExecuteAlways]
    public class VLActorRig : VLActorExtension
    {
        public const int RigCapacity = 20;
        [SerializeField]
        private VLActorRigFurisodeBone[] _rigFurisodeBones;
        private AnimationScriptPlayable _scriptPlayable;
        private IAnimationPlayer _animationPlayer;
        private NativeArray<RigFurisodeData> _rigFurisodes;
        private AnimationPlayableOutput _output;
        public override void Initialize()
        {
        }

        public bool Setup(VLActorRigBone[] rigBones)
        {
            return default(bool);
        }

        public override void OnUpdate()
        {
        }

        public override void Dispose()
        {
        }

        public VLActorRig()
        {
        }
    }
}
