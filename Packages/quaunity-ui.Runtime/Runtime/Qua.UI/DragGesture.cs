namespace Qua.UI
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [RequireComponent(typeof(RectTransform))]
    public class DragGesture : QuaUIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
    {
        [CompilerGenerated]
        private Vector2 _003CDeltaPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CDeltaStartPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CDeltaEndPosition_003Ek__BackingField;
        [CompilerGenerated]
        private Vector2 _003CTotalDelta_003Ek__BackingField;
        private float _startTime;
        [CompilerGenerated]
        private int _003CFingerCount_003Ek__BackingField;
        public Action onBeginDragCallback;
        public Action onDragCallback;
        public Action onEndDragCallback;
        private Canvas _cachedRootCanvas;
        [CompilerGenerated]
        private int _003CFrameCountForRecentSpeed_003Ek__BackingField;
        private Vector2[] _recentDragDeltas;
        private float[] _recentTimeDeltas;
        private int _recentDataIndex;
        private bool _isDragFrame;
        [CompilerGenerated]
        private MouseButtonType _003CInputMouseButton_003Ek__BackingField;
        public Vector2 DeltaPosition
        {
            [CompilerGenerated]
            get
            {
                return _003CDeltaPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDeltaPosition_003Ek__BackingField = value;
            }
        }

        public Vector2 CanvasSpaceDeltaPosition
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 ScreenRatioDeltaPosition
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 RectRatioDeltaPosition
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 DeltaStartPosition
        {
            [CompilerGenerated]
            get
            {
                return _003CDeltaStartPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDeltaStartPosition_003Ek__BackingField = value;
            }
        }

        public Vector2 DeltaEndPosition
        {
            [CompilerGenerated]
            get
            {
                return _003CDeltaEndPosition_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CDeltaEndPosition_003Ek__BackingField = value;
            }
        }

        public Vector2 TotalDelta
        {
            [CompilerGenerated]
            get
            {
                return _003CTotalDelta_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CTotalDelta_003Ek__BackingField = value;
            }
        }

        public Vector2 ScreenRatioTotalDelta
        {
            get
            {
                return default(Vector2);
            }
        }

        public Vector2 RectRatioTotalDelta
        {
            get
            {
                return default(Vector2);
            }
        }

        public float DeltaTime
        {
            get
            {
                return default(float);
            }
        }

        public int FingerCount
        {
            [CompilerGenerated]
            get
            {
                return _003CFingerCount_003Ek__BackingField;
            }

            [CompilerGenerated]
            private set
            {
                _003CFingerCount_003Ek__BackingField = value;
            }
        }

        public bool IsDragging
        {
            get
            {
                return default(bool);
            }
        }

        private float ScreenSpaceRectWidth
        {
            get
            {
                return default(float);
            }
        }

        private float ScreenSpaceRectHeight
        {
            get
            {
                return default(float);
            }
        }

        public int FrameCountForRecentSpeed
        {
            [CompilerGenerated]
            get
            {
                return _003CFrameCountForRecentSpeed_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CFrameCountForRecentSpeed_003Ek__BackingField = value;
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

        private float CorrectZeroDivide(float denominator)
        {
            return default(float);
        }

        private Vector2 GetRectSpaceDelta(Vector2 delta)
        {
            return default(Vector2);
        }

        private Vector2 GetRootCanvasSize()
        {
            return default(Vector2);
        }

        private void LateUpdate()
        {
        }

        private void InsertDeltaValue(Vector2 delta)
        {
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
        }

        public virtual void OnBeginDrag(PointerEventData eventData)
        {
        }

        public virtual void OnEndDrag(PointerEventData eventData)
        {
        }

        public Vector2 GetRecentSpeed()
        {
            return default(Vector2);
        }

        protected override void OnCanvasHierarchyChanged()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        protected override void OnDestroy()
        {
        }

        public DragGesture()
        {
        }
    }
}
