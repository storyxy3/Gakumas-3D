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

    public class StandaloneScreenOrientationController : ScreenOrientationControllerBase
    {
        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            public static Func<UniTask> _003C_003E9__7_0;
            public static Func<UniTask> _003C_003E9__8_0;
            public static Func<UniTask> _003C_003E9__9_0;
            public static Func<UniTask> _003C_003E9__10_0;
            public static Func<UniTask> _003C_003E9__11_0;
            public _003C_003Ec()
            {
            }

            internal UniTask _003CSetStartsWithPortraitAsync_003Eb__7_0()
            {
                return default(UniTask);
            }

            internal UniTask _003CSetStartsWithLandscapeAsync_003Eb__8_0()
            {
                return default(UniTask);
            }

            internal UniTask _003CSetFixedPortraitAsync_003Eb__9_0()
            {
                return default(UniTask);
            }

            internal UniTask _003CSetFixedLandscapeAsync_003Eb__10_0()
            {
                return default(UniTask);
            }

            internal UniTask _003CSetFixedLandscapeLeftAsync_003Eb__11_0()
            {
                return default(UniTask);
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CAdjustScreenResolutionForSetScreenResolutionFallbackAsync_003Ed__13 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public StandaloneScreenOrientationController _003C_003E4__this;
            public ScreenOrientation from;
            public ScreenOrientation to;
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
        private struct _003CSetFixedLandscapeAsync_003Ed__10 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
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
        private struct _003CSetFixedLandscapeLeftAsync_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
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
        private struct _003CSetFixedPortraitAsync_003Ed__9 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
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
        private struct _003CSetStartsWithLandscapeAsync_003Ed__8 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
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
        private struct _003CSetStartsWithPortraitAsync_003Ed__7 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Func<UniTask> completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
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
        private struct _003CToggleResolution_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public ScreenOrientation from;
            public ScreenOrientation to;
            public AsyncLazy completedOrientationTask;
            public StandaloneScreenOrientationController _003C_003E4__this;
            public CancellationToken ct;
            private int _003Cwidth_003E5__2;
            private int _003Cheight_003E5__3;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [CompilerGenerated]
        private Action<ScreenOrientation, ScreenOrientation> _003COnAdjustScreenResolutionErrorCallback_003Ek__BackingField;
        public Action<ScreenOrientation, ScreenOrientation> OnAdjustScreenResolutionErrorCallback
        {
            [CompilerGenerated]
            get
            {
                return _003COnAdjustScreenResolutionErrorCallback_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003COnAdjustScreenResolutionErrorCallback_003Ek__BackingField = value;
            }
        }

        [PreserveSig]
        private static extern bool GetClientRect(IntPtr hWnd, ref Rect lpRect);
        [PreserveSig]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [AsyncStateMachine(typeof(_003CSetStartsWithPortraitAsync_003Ed__7))]
        protected override UniTask SetStartsWithPortraitAsync(Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetStartsWithLandscapeAsync_003Ed__8))]
        protected override UniTask SetStartsWithLandscapeAsync(Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetFixedPortraitAsync_003Ed__9))]
        protected override UniTask SetFixedPortraitAsync(Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetFixedLandscapeAsync_003Ed__10))]
        protected override UniTask SetFixedLandscapeAsync(Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CSetFixedLandscapeLeftAsync_003Ed__11))]
        protected override UniTask SetFixedLandscapeLeftAsync(Func<UniTask> completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CToggleResolution_003Ed__12))]
        private UniTask ToggleResolution(ScreenOrientation from, ScreenOrientation to, AsyncLazy completedOrientationTask, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CAdjustScreenResolutionForSetScreenResolutionFallbackAsync_003Ed__13))]
        private UniTask AdjustScreenResolutionForSetScreenResolutionFallbackAsync(int originalWidth, int originalHeight, ScreenOrientation from, ScreenOrientation to, CancellationToken ct)
        {
            return default(UniTask);
        }

        private static bool IsSetScreenResolutionFailed()
        {
            return default(bool);
        }
    }
}
