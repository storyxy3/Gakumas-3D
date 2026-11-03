namespace Campus.Common
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::UnityEngine;
    using global::VL;

    public class CampusGyroController : IDisposable
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInitializeAsync_003Ed__19 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusGyroController _003C_003E4__this;
            public CancellationToken ct;
            private CancellationTokenSource _003Ccts_003E5__2;
            private UniTask<int>.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        public const float DefaultLimitAngle = 89f;
        public const float LerpFactor = 0.6f;
        private VLGyro _gyro;
        private bool _initialized;
        private Quaternion _baseRotation;
        private int _lastAccessFrame;
        private Quaternion _rotation;
        [CompilerGenerated]
        private float _003CLimitAngle_003Ek__BackingField;
        private bool _isGyro;
        public Action<bool> onChangeGyro;
        public bool IsInitialized
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsGyro
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public Quaternion Rotation
        {
            get
            {
                return default(Quaternion);
            }
        }

        [AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__19))]
        public UniTask InitializeAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void UpdateRotation()
        {
        }

        public void ResetRotation()
        {
        }

        public void Dispose()
        {
        }

        public CampusGyroController()
        {
        }
    }
}
