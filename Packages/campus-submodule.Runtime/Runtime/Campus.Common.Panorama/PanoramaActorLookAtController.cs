namespace Campus.Common.Panorama
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.LookAt;
    using global::Campus.Common.Panorama;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;

    public class PanoramaActorLookAtController : MonoBehaviour
    {
        private enum FocusUpdateReasonType
        {
            User,
            Live,
            Camera
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9;
            public static Func<bool> _003C_003E9__29_0;
            public _003C_003Ec()
            {
            }

            internal bool _003CSetEvent_003Eb__29_0()
            {
                return default(bool);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayEyeBlinkOnLookAtAsync_003Ed__37 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public PanoramaActorLookAtController _003C_003E4__this;
            public CancellationToken ct;
            private float _003Celapsed_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private const float EyeBlinkOnLookAtDuration = 7f / 30f;
        private ICampusActorController _actor;
        private CampusLookAtConstraint _lookAtConstraint;
        private CampusActorLookAtController _lookAtController;
        private LookTargetType _currentLookTargetType;
        private PanoramaCameraType _currentCameraType;
        private bool _shouldEnableLookAt;
        private bool _liveEnableLookAt;
        private bool _isProhibitLookEnable;
        private bool _isFocusTarget;
        private bool _isConstraintOutRange;
        private bool _isEyeBlinkOnLookAtPlaying;
        public ICampusActorController Actor
        {
            get
            {
                return null;
            }
        }

        public bool IsConstraintEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public CampusActorLookAtController LookAtController
        {
            get
            {
                return null;
            }
        }

        public bool IsLookAtEnable
        {
            get
            {
                return default(bool);
            }
        }

        public bool ShouldEnableLookAt
        {
            get
            {
                return default(bool);
            }
        }

        public bool LiveEnableLookAt
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsProhibitLookEnable
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsFocusTarget
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize(ICampusActorController actor, CampusCustomLookAtEffector customLookAtEffector)
        {
        }

        private void SetEvent()
        {
        }

        public void SetShouldLookAtEnable(bool isEnable)
        {
        }

        public void SetLiveLookAtEnable(bool isEnable)
        {
        }

        public void SetProhibitLookEnable(bool isProhibit)
        {
        }

        public void SetCurrentCamera(SwitchPanoramaCamera panoramaCamera)
        {
        }

        public void SetEyeLookAtAngleOverwrite(float eyeLookOutVirtualAngle, float eyeLookAgainVirtualAngle, float eyeLookOutHorizontalAngle, float eyeLookAgainHorizontalAngle)
        {
        }

        private void ChangeLookAtStatus(FocusUpdateReasonType focusUpdateReason, [Optional] Transform lookAtTarget)
        {
        }

        private void PlayEyeBlinkOnLookAt()
        {
        }

        [AsyncStateMachine(typeof(_003CPlayEyeBlinkOnLookAtAsync_003Ed__37))]
        private UniTask PlayEyeBlinkOnLookAtAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private LookTargetType GetLookTargetType(bool isLookAtEnable)
        {
            return default(LookTargetType);
        }

        public bool CanChangeActorLookStatus(bool shouldEnable)
        {
            return default(bool);
        }

        public void SetFocusActorTarget(bool isFocusTarget)
        {
        }

        private void OnConstrainStatusChange(bool isOutRange)
        {
        }

        public PanoramaActorLookAtController()
        {
        }

        [CompilerGenerated]
        private LookTargetType _003CSetEvent_003Eb__29_1()
        {
            return default(LookTargetType);
        }

        [CompilerGenerated]
        private Transform _003CSetEvent_003Eb__29_2()
        {
            return null;
        }
    }
}
