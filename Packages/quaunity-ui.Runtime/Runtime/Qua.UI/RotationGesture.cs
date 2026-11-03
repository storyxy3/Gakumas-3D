namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class RotationGesture : QuaUIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
    {
        [CompilerGenerated]
        private Vector2 _003CCenter_003Ek__BackingField;
        [CompilerGenerated]
        private float _003CDeltaAngle_003Ek__BackingField;
        [CompilerGenerated]
        private bool _003CIsRotating_003Ek__BackingField;
        public Action onBeginRotateCallback;
        public Action onRotateCallback;
        public Action onEndRotateCallback;
        private Dictionary<int, Vector2> _positions;
        public Vector2 Center
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

        public float DeltaAngle
        {
            [CompilerGenerated]
            get
            {
                return default(float);
            }

            [CompilerGenerated]
            private set
            {
            }
        }

        public bool IsRotating
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

        private float GetAngle(Vector2 v1, Vector2 v2)
        {
            return default(float);
        }

        public RotationGesture()
        {
        }
    }
}
