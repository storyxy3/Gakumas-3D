namespace Campus.Common.Extensions
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Campus.Common;
    using global::Campus.Common.Extensions;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::DG.Tweening;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public static class TweenExtensions
    {
        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass10_0
        {
            public CampusText target;
            public string text;
            public _003C_003Ec__DisplayClass10_0()
            {
            }

            internal string _003CDOTextTalk_003Eb__0()
            {
                return null;
            }

            internal void _003CDOTextTalk_003Eb__1(string x)
            {
            }

            internal void _003CDOTextTalk_003Eb__2()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass4_0
        {
            public UniTaskCompletionSource completionSource;
            public Tween self;
            public bool isKillTrue;
            public _003C_003Ec__DisplayClass4_0()
            {
            }

            internal void _003CWaitAsync_003Eb__0()
            {
            }

            internal void _003CWaitAsync_003Eb__1()
            {
            }

            internal void _003CWaitAsync_003Eb__2()
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass8_0
        {
            public int initialValue;
            public int finalValue;
            public Func<int, string> convertor;
            public CampusText text;
            public _003C_003Ec__DisplayClass8_0()
            {
            }

            internal int _003CDOTextInt_003Eb__0()
            {
                return default(int);
            }

            internal void _003CDOTextInt_003Eb__1(int it)
            {
            }

            internal void _003CDOTextInt_003Eb__2()
            {
            }

            internal void _003CDOTextInt_003Eg__SetText_007C3(int value)
            {
            }
        }

        [CompilerGenerated]
        private sealed class _003C_003Ec__DisplayClass9_0
        {
            public Graphic graphic;
            public _003C_003Ec__DisplayClass9_0()
            {
            }

            internal Color _003CDOAlpha_003Eb__0()
            {
                return default(Color);
            }

            internal void _003CDOAlpha_003Eb__1(Color color)
            {
            }
        }

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitAsync_003Ed__2 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Tween self;
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
        private struct _003CWaitAsync_003Ed__4 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Tween self;
            public bool isKillTrue;
            public CancellationToken ct;
            private CancellationTokenRegistration _003C_003E7__wrap1;
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
        private struct _003CWaitWithKillTrueAsync_003Ed__3 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public Tween self;
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

        [AsyncStateMachine(typeof(_003CWaitAsync_003Ed__2))]
        public static UniTask WaitAsync(this Tween self, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CWaitWithKillTrueAsync_003Ed__3))]
        public static UniTask WaitWithKillTrueAsync(this Tween self, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CWaitAsync_003Ed__4))]
        private static UniTask WaitAsync(this Tween self, bool isKillTrue, CancellationToken ct)
        {
            return default(UniTask);
        }

        public static void SetElapsedPercentage(this Tween self, float progress, bool andPlay = false)
        {
        }

        public static bool IsEndPosition(this Tween self)
        {
            return default(bool);
        }

        public static Tweener DOTextInt(this CampusText text, int initialValue, int finalValue, float duration, [Optional] Func<int, string> convertor)
        {
            return null;
        }

        public static Tweener DOAlpha(this Graphic graphic, float endValue, float duration)
        {
            return null;
        }

        public static Tweener DOTextTalk(this CampusText target, string text, bool isKeepText = false, bool isRichTextEnabled = true)
        {
            return null;
        }
    }
}
