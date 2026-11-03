namespace Qua.UI
{
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Cysharp.Threading.Tasks.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.UI;

    public class SimpleButton : ButtonBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CColorTintTransitionAsync_003Ed__12 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SimpleButton _003C_003E4__this;
            public bool isPressedOrIsDisabled;
            public Color color;
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
        private struct _003CDisabledTransitionAsync_003Ed__10 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SimpleButton _003C_003E4__this;
            public bool isDisabled;
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
        private struct _003CPressedTransitionAsync_003Ed__9 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public SimpleButton _003C_003E4__this;
            public bool isPressed;
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
        private Graphic _hitAreaGraphic;
        [SerializeField]
        private Graphic _targetGraphic;
        [SerializeField]
        protected Color _pressedColor;
        [SerializeField]
        protected Color _disabledColor;
        [SerializeField]
        private float _fadeDuration;
        private Color? _originalColor;
        protected Color TargetGraphicOriginalColor
        {
            get
            {
                return default(Color);
            }
        }

        protected override LongTapGesture GetLongTapGesture()
        {
            return null;
        }

        [AsyncStateMachine(typeof(_003CPressedTransitionAsync_003Ed__9))]
        protected override UniTask PressedTransitionAsync(bool isPressed, CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CDisabledTransitionAsync_003Ed__10))]
        protected override UniTask DisabledTransitionAsync(bool isDisabled, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void ImmediateDisabledTransition(bool isDisabled)
        {
        }

        [AsyncStateMachine(typeof(_003CColorTintTransitionAsync_003Ed__12))]
        private UniTask ColorTintTransitionAsync(Color color, bool isPressedOrIsDisabled, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask ColorTintTransitionAsync(Color endColor, CancellationToken ct)
        {
            return default(UniTask);
        }

        public SimpleButton()
        {
        }
    }
}
