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

    public abstract class ScreenOrientationControllerBase : IDisposable
    {
        protected readonly struct OrientationPair
        {
            public readonly DeviceOrientation device;
            public readonly ScreenOrientation screen;
            public OrientationPair(DeviceOrientation device, ScreenOrientation screen)
            {
                this = default;
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CInternalSetOrientationAsync_003Ed__29 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenOrientationControllerBase _003C_003E4__this;
            public OrientationType orientationType;
            public CancellationToken ct;
            public Func<UniTask> completedOrientationTask;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetAutoAfterRotateDeviceAsync_003Ed__35 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public OrientationPair orientationPair;
            public CancellationToken ct;
            public ScreenOrientationControllerBase _003C_003E4__this;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetAutoAsync_003Ed__30 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public ScreenOrientationControllerBase _003C_003E4__this;
            private DeviceOrientation _003CprevDeviceOrientation_003E5__2;
            private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetFixedAsync_003Ed__32 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CancellationToken ct;
            public OrientationPair otherPair;
            public OrientationPair defaultPair;
            public ScreenOrientationControllerBase _003C_003E4__this;
            public AsyncLazy completedOrientationTask;
            public UniTaskCompletionSource completionSource;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private DeviceOrientation? _003CprevDeviceOrientation_003E5__4;
            private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;
            private UniTask.Awaiter _003C_003Eu__2;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetFixedLazyAsync_003Ed__39 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public ScreenOrientationControllerBase _003C_003E4__this;
            public OrientationPair defaultPair;
            public OrientationPair otherPair;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetScreenOrientationAsync_003Ed__34 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenOrientation from;
            public ScreenOrientation to;
            public AsyncLazy completedOrientationTask;
            public UniTaskCompletionSource completionSource;
            public ScreenOrientationControllerBase _003C_003E4__this;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetStartsWithAsync_003Ed__33 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public OrientationPair defaultPair;
            public OrientationPair otherPair;
            public ScreenOrientationControllerBase _003C_003E4__this;
            public AsyncLazy completedOrientationTask;
            public UniTaskCompletionSource completionSource;
            public CancellationToken ct;
            private object _003C_003E7__wrap1;
            private int _003C_003E7__wrap2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CSetStartsWithLazyAsync_003Ed__38 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public ScreenOrientationControllerBase _003C_003E4__this;
            public OrientationPair defaultPair;
            public OrientationPair otherPair;
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

        protected readonly OrientationPair Portrait;
        protected readonly OrientationPair PortraitUpsideDown;
        protected readonly OrientationPair LandscapeLeft;
        protected readonly OrientationPair LandscapeRight;
        [CompilerGenerated]
        private Func<ScreenOrientation, ScreenOrientation, CancellationToken, UniTask> _003CBeforeChangeOrientationAsync_003Ek__BackingField;
        [CompilerGenerated]
        private Func<ScreenOrientation, ScreenOrientation, AsyncLazy, UniTaskCompletionSource, CancellationToken, UniTask> _003CAfterChangeOrientationAsync_003Ek__BackingField;
        private CancellationTokenSource _cts;
        [CompilerGenerated]
        private OrientationType _003CCurrentOrientationType_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsOrientating_003Ek__BackingField;
        public Func<ScreenOrientation, ScreenOrientation, CancellationToken, UniTask> BeforeChangeOrientationAsync
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public Func<ScreenOrientation, ScreenOrientation, AsyncLazy, UniTaskCompletionSource, CancellationToken, UniTask> AfterChangeOrientationAsync
        {
            [CompilerGenerated]
            get
            {
                return null;
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public OrientationType CurrentOrientationType
        {
            [CompilerGenerated]
            get
            {
                return default(OrientationType);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsOrientating
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

        protected abstract UniTask SetStartsWithPortraitAsync(Func<UniTask> completedOrientationTask, CancellationToken ct);
        protected abstract UniTask SetStartsWithLandscapeAsync(Func<UniTask> completedOrientationTask, CancellationToken ct);
        protected abstract UniTask SetFixedPortraitAsync(Func<UniTask> completedOrientationTask, CancellationToken ct);
        protected abstract UniTask SetFixedLandscapeAsync(Func<UniTask> completedOrientationTask, CancellationToken ct);
        protected abstract UniTask SetFixedLandscapeLeftAsync(Func<UniTask> completedOrientationTask, CancellationToken ct);
        public void SetOrientation(OrientationType orientationType)
        {
        }

        public UniTask SetOrientationAsync(OrientationType orientationType, Func<UniTask> completedOrientationTask)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CInternalSetOrientationAsync_003Ed__29))]
        private UniTask InternalSetOrientationAsync(OrientationType orientationType, Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetAutoAsync_003Ed__30))]
        private UniTask SetAutoAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        private UniTask WaitAutoOnceAsync(OrientationType prevOrientationType, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetFixedAsync_003Ed__32))]
        protected UniTask SetFixedAsync(OrientationPair defaultPair, OrientationPair otherPair, AsyncLazy completedOrientationTask, UniTaskCompletionSource completionSource, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetStartsWithAsync_003Ed__33))]
        protected UniTask SetStartsWithAsync(OrientationPair defaultPair, OrientationPair otherPair, AsyncLazy completedOrientationTask, UniTaskCompletionSource completionSource, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetScreenOrientationAsync_003Ed__34))]
        private UniTask SetScreenOrientationAsync(ScreenOrientation from, ScreenOrientation to, AsyncLazy completedOrientationTask, UniTaskCompletionSource completionSource, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetAutoAfterRotateDeviceAsync_003Ed__35))]
        private UniTask SetAutoAfterRotateDeviceAsync(OrientationPair orientationPair, CancellationToken ct)
        {
            return default(UniTask);
        }

        public void Dispose()
        {
        }

        private static void SetAutoRotate(bool autoRotate)
        {
        }

        [AsyncStateMachine(typeof(_003CSetStartsWithLazyAsync_003Ed__38))]
        protected UniTask SetStartsWithLazyAsync(OrientationPair defaultPair, OrientationPair otherPair, Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetFixedLazyAsync_003Ed__39))]
        protected UniTask SetFixedLazyAsync(OrientationPair defaultPair, OrientationPair otherPair, Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected ScreenOrientationControllerBase()
        {
        }
    }
}
