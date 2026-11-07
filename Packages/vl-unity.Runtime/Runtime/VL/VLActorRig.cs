namespace VL
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Unity.Collections;
    using global::UnityEngine;
    using global::UnityEngine.Animations;
    using global::VL;
    using global::VL.Animation;
    using global::VL.Unsafe.Jobs;

    [ExecuteAlways]
    public class VLActorRig : VLActorExtension
    {
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<VLActorRigBone, bool> _003C_003E9__7_0;
            public static Func<VLActorRigBone, VLActorRigFurisodeBone> _003C_003E9__7_1;
            public _003C_003Ec()
            {
            }

            internal bool _003CSetup_003Eb__7_0(VLActorRigBone x)
            {
                return default(bool);
            }

            internal VLActorRigFurisodeBone _003CSetup_003Eb__7_1(VLActorRigBone x)
            {
                return null;
            }
        }

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
