namespace Qua.UI
{
    using global::System;
    using global::System.Collections;
    using global::System.Collections.Generic;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class LongTapGesture : QuaUIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        public enum ClickDetectType
        {
            OnClick,
            OnPointerUp
        }

        [CompilerGenerated]
        private sealed class _003CLongTapEnumerator_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
        {
            private int _003C_003E1__state;
            private object _003C_003E2__current;
            public LongTapGesture _003C_003E4__this;
            object System.Collections.Generic.IEnumerator<System.Object>.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            object System.Collections.IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return null;
                }
            }

            [DebuggerHidden]
            public _003CLongTapEnumerator_003Ed__71(int _003C_003E1__state)
            {
            }

            [DebuggerHidden]
            void System.IDisposable.Dispose()
            {
            }

            bool global::System.Collections.IEnumerator.MoveNext()
            {
                return default(bool);
            }

            [DebuggerHidden]
            void System.Collections.IEnumerator.Reset()
            {
            }
        }

        [CompilerGenerated]
        private float _003CLongTapTime_003Ek__BackingField;
        private float _lastPressTime;
        [CompilerGenerated]
        private bool _003CIsDragged_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsPressed_003Ek__BackingField;
        [CompilerGenerated]
        private int _003CPressedPointerId_003Ek__BackingField;
        public Action onClickedCallback;
        public Action onLongTappedCallback;
        public Action<bool> onPressedCallback;
        public Action onLongTapCanceledCallBack;
        [CompilerGenerated]
        private Vector2 _003CPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CClickedPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CDragDelta_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsMultiTouchDisabled_003Ek__BackingField;
        private Coroutine _longTapCoroutine;
        [CompilerGenerated]
        private float _003CLongTapCancelDragThreshold_003Ek__BackingField;
        private bool _isLongTapWaiting;
        [CompilerGenerated]
        private bool _003CShouldPenetrateDragEvent_003Ek__BackingField;
        [CompilerGenerated]
        private ClickDetectType _003CClickType_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CSuppressLongTapClick_003Ek__BackingField;
        [CompilerGenerated]
        private MouseButtonType _003CInputMouseButton_003Ek__BackingField;
        public virtual float LongTapTime
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

        public bool IsDragged
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

        public bool IsPressed
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

        public int PressedPointerId
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector2 Position
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector2 ClickedPosition
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public Vector2 DragDelta
        {
            [CompilerGenerated]
            get
            {
                return default(Vector2);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsMultiTouchDisabled
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

        public float LongTapCancelDragThreshold
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

        public bool ShouldPenetrateDragEvent
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public ClickDetectType ClickType
        {
            [CompilerGenerated]
            get
            {
                return default(ClickDetectType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public bool SuppressLongTapClick
        {
            [CompilerGenerated]
            get
            {
                return default(bool);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public MouseButtonType InputMouseButton
        {
            [CompilerGenerated]
            get
            {
                return default(MouseButtonType);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public void SetMultiTouchDisabled(bool isDisabled)
        {
        }

        public virtual void OnPointerClick(PointerEventData eventData)
        {
        }

        protected virtual void CheckClick(PointerEventData eventData)
        {
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
        }

        protected virtual void OnApplicationPause(bool isPause)
        {
        }

        public virtual void OnInitializePotentialDrag(PointerEventData eventData)
        {
        }

        public virtual void OnBeginDrag(PointerEventData eventData)
        {
        }

        public virtual void OnEndDrag(PointerEventData eventData)
        {
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
        }

        private void PenetrateDragEvent<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunc)
            where T : IEventSystemHandler
        {
        }

        [IteratorStateMachine(typeof(_003CLongTapEnumerator_003Ed__71))]
        private IEnumerator LongTapEnumerator()
        {
            return null;
        }

        private void CancelLongTapCoroutine()
        {
        }

        private bool IsInvalidPointEvent(PointerEventData eventData)
        {
            return default(bool);
        }

        public LongTapGesture()
        {
        }
    }
}
