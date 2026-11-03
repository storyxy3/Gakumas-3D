namespace Campus.Common.Extensions
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Extensions;
    using global::Campus.Titan;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Titan;

    public static class TitanExtensions
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CPlayAsync_003Ed__0 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<ITimelineTween> _003C_003Et__builder;
            public TitanPlayer self;
            public CancellationToken ct;
            private UniTask<ITimelineTween>.Awaiter _003C_003Eu__1;
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
        private struct _003CPlayAsync_003Ed__1 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<ITimelineTween> _003C_003Et__builder;
            public TitanPlayer self;
            public string groupName;
            public CancellationToken ct;
            private UniTask<ITimelineTween>.Awaiter _003C_003Eu__1;
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
        private struct _003CPlayInternalAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder<ITimelineTween> _003C_003Et__builder;
            public string groupName;
            public TitanPlayer self;
            public float? delay;
            public CancellationToken ct;
            private ITimelineTween _003Ctimeline_003E5__2;
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
        private struct _003CPlayUntilWaitEndMarkerAsync_003Ed__5 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public TitanPlayer self;
            public string id;
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
        private struct _003CPlayUntilWaitEndMarkerAsync_003Ed__6 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public string id;
            public CancellationToken ct;
            public TitanPlayer self;
            public string groupName;
            private bool _003ChasId_003E5__2;
            private CancellationTokenRegistration _003ConCancel_003E5__3;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__0))]
        public static UniTask<ITimelineTween> PlayAsync(this TitanPlayer self, CancellationToken ct)
        {
            return default(UniTask<ITimelineTween>);
        }

        [AsyncStateMachine(typeof(_003CPlayAsync_003Ed__1))]
        public static UniTask<ITimelineTween> PlayAsync(this TitanPlayer self, string groupName, CancellationToken ct)
        {
            return default(UniTask<ITimelineTween>);
        }

        [AsyncStateMachine(typeof(_003CPlayInternalAsync_003Ed__4))]
        private static UniTask<ITimelineTween> PlayInternalAsync(TitanPlayer self, float? delay, string groupName, CancellationToken ct)
        {
            return default(UniTask<ITimelineTween>);
        }

        [AsyncStateMachine(typeof(_003CPlayUntilWaitEndMarkerAsync_003Ed__5))]
        public static UniTask PlayUntilWaitEndMarkerAsync(this TitanPlayer self, string id, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CPlayUntilWaitEndMarkerAsync_003Ed__6))]
        public static UniTask PlayUntilWaitEndMarkerAsync(this TitanPlayer self, string id, string groupName, CancellationToken ct)
        {
            return default(UniTask);
        }

        private static CampusSkipMarker GetSkipMarkerById(this TitanPlayer self, string markerId)
        {
            return null;
        }

        public static void SkipToMarkerById(this TitanPlayer self, string skipId)
        {
        }

        public static void SkipToMarkerByIdAndSetTapWait(this TitanPlayer self, string skipId, CampusButton targetButton)
        {
        }

        public static void SetTapWait(this TitanPlayer self, string id, CampusButton targetButton)
        {
        }

        public static bool IsExpiredSkipMarker(this TitanPlayer self, string markerId)
        {
            return default(bool);
        }
    }
}
