namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cinemachine;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;
    using global::UnityEngine.Rendering;
    using global::VL;
    using global::VL.Animation;

    public class CampusSceneLayout : MonoBehaviour
    {
        public enum SituationType
        {
            None = 0,
            HomeTop = 10,
            HomeIdol = 11,
            HomeStory = 12,
            HomeContest = 13,
            HomeLoginBonus = 14
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<(ICampusActorController actor, bool isCorrectionLayoutHeight), ICampusActorController> _003C_003E9__19_0;
            public static Func<Transform, float> _003C_003E9__34_0;
            public _003C_003Ec()
            {
            }

            internal ICampusActorController _003CSetupActor_003Eb__19_0((ICampusActorController actor, bool isCorrectionLayoutHeight) data)
            {
                return null;
            }

            internal float _003CTryCreateActorLayoutPositionCache_003Eb__34_0(Transform data)
            {
                return default(float);
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass27_0
        {
            public CinemachineBrain brain;
            public CampusSceneLayout _003C_003E4__this;
            public _003C_003Ec__DisplayClass27_0()
            {
            }

            internal bool _003CWaitUntilActiveCameraAsync_003Eb__0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitUntilActiveCameraAsync_003Ed__27 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusSceneLayout _003C_003E4__this;
            public CancellationToken ct;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [SerializeField]
        private string _id;
        [SerializeField]
        private CinemachineVirtualCamera _camera;
        private MotionDefinePlayer _cameraAnimationPlayer;
        [SerializeField]
        private CampusVirtualActorController[] _actors;
        [SerializeField]
        private CampusActorLayout _actorLayout;
        [SerializeField]
        private Volume _overrideVolume;
        private float[] _initialActorLayoutTargetPositionCaches;
        public const int DefaultActiveCameraPriority = 1000;
        public string Id
        {
            get
            {
                return null;
            }
        }

        public CinemachineVirtualCamera Camera
        {
            get
            {
                return null;
            }
        }

        public CampusActorLayout ActorLayout
        {
            get
            {
                return null;
            }
        }

        public Volume OverrideVolume
        {
            get
            {
                return null;
            }
        }

        public void SetupActor(ICampusActorController actor, bool isCorrectionLayoutHeight = false)
        {
        }

        public void SetupActor(IList<ICampusActorController> actors)
        {
        }

        public void SetupActor(IList<(ICampusActorController actor, bool isCorrectionLayoutHeight)> actors)
        {
        }

        public void Unset()
        {
        }

        public void SetCameraPriority(int priority)
        {
        }

        public void SetCameraActive(bool isActive)
        {
        }

        private void SetVolumeEnable(bool isActive)
        {
        }

        public MotionDefinePlayer GetCameraAnimationPlayer()
        {
            return null;
        }

        public IAnimationController PlayCameraMotion(MotionDefine motionDefine, float transition = 0f)
        {
            return null;
        }

        public bool IsActiveCamera()
        {
            return default(bool);
        }

        [AsyncStateMachine(typeof(_003CWaitUntilActiveCameraAsync_003Ed__27))]
        public UniTask WaitUntilActiveCameraAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void RegisterReset(CancellationToken ct)
        {
        }

        public void ResetActorLayoutPositions()
        {
        }

        public void ResetActorLayoutPosition(int index)
        {
        }

        public void SetActorLayoutPosition(int index, float value)
        {
        }

        public void AddActorLayoutPosition(int index, float value, bool isFromCurrent = false)
        {
        }

        public void AddActorLayoutPosition(int index, ICampusActorController actor, bool isFromCurrent = false)
        {
        }

        private void TryCreateActorLayoutPositionCache()
        {
        }

        public CampusSceneLayout()
        {
        }

        [CompilerGenerated]
        private void _003CRegisterReset_003Eb__28_0()
        {
        }

        [CompilerGenerated]
        private void _003CResetActorLayoutPositions_003Eb__29_0(Transform data, int index)
        {
        }
    }
}
