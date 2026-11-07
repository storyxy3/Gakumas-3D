namespace Qua.UI
{
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;
    using global::UnityEngine.UI;

    [RequireComponent(typeof(Graphic))]
    public abstract class FlickGestureBase : QuaUIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
    {
        [CompilerGenerated]
        private static float _003CThresholdCoefficient_003Ek__BackingField;
        private static List<IFlickDirectionData> _flickList;
        [SerializeField]
        private bool _isPenetrateParent;
        protected bool _isDragging;
        protected Graphic _targetGraphic;
        [CompilerGenerated]
        private MouseButtonType _003CInputMouseButton_003Ek__BackingField;
        public static float ThresholdCoefficient
        {
            [CompilerGenerated]
            get
            {
                return _003CThresholdCoefficient_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CThresholdCoefficient_003Ek__BackingField = value;
            }
        }

        public bool IsPenetrateParent
        {
            get
            {
                return default(bool);
            }

            set
            {
            }
        }

        public MouseButtonType InputMouseButton
        {
            [CompilerGenerated]
            get
            {
                return _003CInputMouseButton_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CInputMouseButton_003Ek__BackingField = value;
            }
        }

        public abstract IList<IFlickDirectionData> GetFlickDirections();
        protected abstract void OnFlick(PointerEventData eventData, IFlickDirectionData[] flicks);
        protected virtual void BeginDragEvent(PointerEventData eventData)
        {
        }

        protected virtual void DragEvent(PointerEventData eventData)
        {
        }

        protected virtual void EndDragEvent(PointerEventData eventData)
        {
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
        }

        public void OnEndDrag(PointerEventData eventData)
        {
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        protected void PenetrateParent<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> events)
            where T : IEventSystemHandler
        {
        }

        protected override void OnDestroy()
        {
        }

        [MethodImpl(256)]
        protected static bool InSideOf(IFlickDirectionData data, float distance, float degree)
        {
            return default(bool);
        }

        protected FlickGestureBase()
        {
        }
    }
}
