namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class ScaleGesture : QuaUIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
    {
        [CompilerGenerated]
        private float _003CDeltaScale_003Ek__BackingField;
        [CompilerGenerated]
        private Vector3 _003CCenter_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsScaling_003Ek__BackingField;
        public Action onBeginScaleCallback;
        public Action onScaleCallback;
        public Action onEndScaleCallback;
        private Dictionary<int, Vector2> _positions;
        public float DeltaScale
        {
            [CompilerGenerated]
            get
            {
                return _003CDeltaScale_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDeltaScale_003Ek__BackingField = value;
            }
        }

        public Vector3 Center
        {
            [CompilerGenerated]
            get
            {
                return _003CCenter_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CCenter_003Ek__BackingField = value;
            }
        }

        public bool IsScaling
        {
            [CompilerGenerated]
            get
            {
                return _003CIsScaling_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CIsScaling_003Ek__BackingField = value;
            }
        }

        protected override void Awake()
        {
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
        }

        public void OnEndDrag(PointerEventData eventData)
        {
        }

        private void UpdateScale(PointerEventData eventData)
        {
        }

        public ScaleGesture()
        {
        }
    }
}
