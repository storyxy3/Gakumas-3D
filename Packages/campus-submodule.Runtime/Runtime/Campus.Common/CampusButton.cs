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
    using global::Qua.UI;
    using global::UnityEngine;

    [RequireComponent(typeof(LongTapGesture))]
    public class CampusButton : CampusButtonBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CLongTapLoopActionAsync_003Ed__11 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusButton _003C_003E4__this;
            public CancellationToken ct;
            private int _003ClongTapActionCount_003E5__2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        private const float MinimumLongTapTime = 0.05f;
        private const float LongTapIncreaseRatio = 0.05f;
        private const float MaximumLongTapTime = 0.15f;
        private const float LongTapUpSpeedCount = 5f;
        private bool _isLongTapPress;
        public Action onLoopTapCallback;
        private CancellationTokenSource _longTapActionCts;
        public LongTapGesture LongTapGesture
        {
            get
            {
                return null;
            }
        }

        protected override void OnPressed(bool isPressed)
        {
        }

        protected override void OnLongTapped()
        {
        }

        [AsyncStateMachine(typeof(_003CLongTapLoopActionAsync_003Ed__11))]
        private UniTask LongTapLoopActionAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        public void AddClickAndLoopCallback(Action action)
        {
        }

        public void SetFadeRoot(CanvasGroup canvasGroup)
        {
        }

        public void SetScaleRoot(RectTransform rect)
        {
        }

        protected override void OnDestroy()
        {
        }

        public CampusButton()
        {
        }
    }
}
