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
    using global::DG.Tweening;
    using global::Qua.UI;
    using global::UnityEngine;

    [RequireComponent(typeof(LongTapGesture))]
    public abstract class CampusButtonBase : ButtonBase
    {
        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CDisabledTransitionAsync_003Ed__38 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusButtonBase _003C_003E4__this;
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
        private struct _003CPressedTransitionAsync_003Ed__31 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusButtonBase _003C_003E4__this;
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

        [StructLayout((LayoutKind)3)]
        [CompilerGenerated]
        private struct _003CWaitClickAsync_003Ed__42 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusButtonBase _003C_003E4__this;
            public CancellationToken ct;
            private CancellationTokenSource _003Ccts_003E5__2;
            private CancellationTokenRegistration _003C_003E7__wrap2;
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
        private struct _003CWaitPressAsync_003Ed__43 : IAsyncStateMachine
        {
            public int _003C_003E1__state;
            public AsyncUniTaskMethodBuilder _003C_003Et__builder;
            public CampusButtonBase _003C_003E4__this;
            public CancellationToken ct;
            private CancellationTokenSource _003Ccts_003E5__2;
            private CancellationTokenRegistration _003C_003E7__wrap2;
            private UniTask.Awaiter _003C_003Eu__1;
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
            {
            }

            [DebuggerHidden]
            void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        protected const float MinTouchAreaSize = 80f;
        [SerializeField]
        protected LongTapGesture _longTapGesture;
        [SerializeField]
        protected RectTransform _scaleRoot;
        [SerializeField]
        protected CanvasGroup _fadeRoot;
        [SerializeField]
        protected GameObject _enabledRoot;
        [SerializeField]
        protected GameObject _disabledRoot;
        [SerializeField]
        protected GameObject _selectedRoot;
        [SerializeField]
        protected RectTransform _touchArea;
        [SerializeField]
        protected bool _isSelected;
        [SerializeField]
        protected bool _isScalable;
        [SerializeField]
        protected bool _isFadable;
        protected Tween _pressTween;
        public Action<bool> onSelectedCallback;
        [SerializeField]
        protected SoundEnum.SoundEffectType _clickSoundEffectType;
        [SerializeField]
        protected SoundEnum.SoundEffectType _clickSoundEffectTypeForDisableState;
        public bool IsSelected
        {
            get
            {
                return default(bool);
            }
        }

        public SoundEnum.SoundEffectType ClickSoundEffectType
        {
            get
            {
                return default(SoundEnum.SoundEffectType);
            }

            set
            {
            }
        }

        public SoundEnum.SoundEffectType ClickSoundEffectTypeForDisableState
        {
            get
            {
                return default(SoundEnum.SoundEffectType);
            }

            set
            {
            }
        }

        protected override void Initialize()
        {
        }

        protected override LongTapGesture GetLongTapGesture()
        {
            return null;
        }

        protected override void OnClicked()
        {
        }

        protected override void OnClickedForDisableState()
        {
        }

        public void SetSelected(bool isSelected)
        {
        }

        public void SetScalable(bool isScalable)
        {
        }

        public void SetFadable(bool isFadable)
        {
        }

        protected virtual void SwitchRoot()
        {
        }

        [AsyncStateMachine(typeof(_003CPressedTransitionAsync_003Ed__31))]
        protected override UniTask PressedTransitionAsync(bool isPressed, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual Tween CreatePressTween(bool isPressed)
        {
            return null;
        }

        protected virtual Tween CreateScaleTween(bool isPressed)
        {
            return null;
        }

        protected virtual Tween CreateFadeTween(bool isPressed)
        {
            return null;
        }

        protected Transform GetScaleRoot()
        {
            return null;
        }

        protected float GetPressedScale()
        {
            return default(float);
        }

        protected virtual void ClearPressAnimation()
        {
        }

        [AsyncStateMachine(typeof(_003CDisabledTransitionAsync_003Ed__38))]
        protected override UniTask DisabledTransitionAsync(bool isDisabled, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void ImmediateDisabledTransition(bool isDisabled)
        {
        }

        protected override void OnDisable()
        {
        }

        public void StopPressAnimation()
        {
        }

        [AsyncStateMachine(typeof(_003CWaitClickAsync_003Ed__42))]
        public UniTask WaitClickAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        [AsyncStateMachine(typeof(_003CWaitPressAsync_003Ed__43))]
        public UniTask WaitPressAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected override void OnRectTransformDimensionsChange()
        {
        }

        protected CampusButtonBase()
        {
        }
    }
}
