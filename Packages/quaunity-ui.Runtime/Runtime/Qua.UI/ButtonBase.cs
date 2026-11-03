namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Threading;
    using global::Cysharp.Threading.Tasks;
    using global::Qua.UI;
    using global::UnityEngine;

    public abstract class ButtonBase : QuaUIBehaviour
    {
        [SerializeField]
        protected bool _isDisabled;
        [CompilerGenerated]
        private float _003CClickCancelDragThreshold_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CLongTapCancelDragThreshold_003Ek__BackingField;
        public Action onClickedCallback;
        public Action onLongTappedCallback;
        public Action<bool> onPressedCallback;
        public Action onClickedCallbackForDisableState;
        public Action onLongTappedCallbackForDisableState;
        public Action<bool> onPressedCallbackForDisableState;
        private CancellationTokenSource _cts;
        public bool IsEnabled
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsDisabled
        {
            get
            {
                return default(bool);
            }
        }

        public virtual float ClickCancelDragThreshold
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public virtual float LongTapCancelDragThreshold
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        protected sealed override void Awake()
        {
        }

        protected virtual void Initialize()
        {
        }

        protected virtual LongTapGesture GetLongTapGesture()
        {
            return null;
        }

        protected virtual void AddCallbacks(LongTapGesture longTapGesture)
        {
        }

        public void SetDisabled(bool isDisabled)
        {
        }

        protected virtual void OnClickedHandler()
        {
        }

        protected virtual void OnLongTappedHandler()
        {
        }

        protected virtual void OnPressedHandler(bool isPressed)
        {
        }

        protected virtual void OnClicked()
        {
        }

        protected virtual void OnClickedForDisableState()
        {
        }

        protected virtual void OnLongTapped()
        {
        }

        protected virtual void OnPressed(bool isPressed)
        {
        }

        protected virtual void OnDisabled(bool isDisabled)
        {
        }

        protected virtual UniTask ClickedTransitionAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask PressedTransitionAsync(bool isPressed, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual UniTask LongTappedTransitionAsync(CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual void OnLongTapCanceled()
        {
        }

        protected virtual UniTask DisabledTransitionAsync(bool isDisabled, CancellationToken ct)
        {
            return default(UniTask);
        }

        protected virtual void ImmediateDisabledTransition(bool isDisabled)
        {
        }

        private CancellationToken GetCt()
        {
            return default(CancellationToken);
        }

        protected override void OnDestroy()
        {
        }

        protected ButtonBase()
        {
        }
    }
}
