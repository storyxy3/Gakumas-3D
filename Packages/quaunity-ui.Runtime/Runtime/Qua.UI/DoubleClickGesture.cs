namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class DoubleClickGesture : QuaUIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        public enum StateType
        {
            Idle,
            Down1,
            Up1,
            Down2,
            Holding
        }

        [SerializeField]
        private float _upDownSpan;
        [SerializeField]
        private float _clickSpan;
        [CompilerGenerated]
        private StateType _003CState_003Ek__BackingField;
        private float _previousEventTime;
        private Vector3 _previousEventPosition;
        [CompilerGenerated]
        private Vector2 _003CPosition_003Ek__BackingField;
        public Action onTappedCallback;
        public Action onSingleClickedCallback;
        public Action onDoubleClickedCallback;
        [CompilerGenerated]
        private MouseButtonType _003CInputMouseButton_003Ek__BackingField;
        public StateType State
        {
            [CompilerGenerated]
            get
            {
                return default(StateType);
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

        public void SetHolding()
        {
        }

        public void OnPointerDown(PointerEventData eventData)
        {
        }

        public void OnPointerUp(PointerEventData eventData)
        {
        }

        private bool IsWithinThresholdSpan(float threshold)
        {
            return default(bool);
        }

        private bool IsWithinThresholdPosition(Vector3 pos1, Vector3 pos2)
        {
            return default(bool);
        }

        public DoubleClickGesture()
        {
        }
    }
}
