namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class CrossFlickGesture : FlickGestureBase
    {
        private class CrossDirectionData : IFlickDirectionData
        {
            [CompilerGenerated]
            private readonly CrossFlickDirection _003CFlickDirection_003Ek__BackingField;
            [CompilerGenerated]
            private readonly float _003CStartAngle_003Ek__BackingField;
            [CompilerGenerated]
            private readonly float _003CEndAngle_003Ek__BackingField;
            [CompilerGenerated]
            private readonly float _003CThreshold_003Ek__BackingField;
            public CrossFlickDirection FlickDirection
            {
                [CompilerGenerated]
                get
                {
                    return _003CFlickDirection_003Ek__BackingField;
                }
            }

            public float StartAngle
            {
                [CompilerGenerated]
                get
                {
                    return _003CStartAngle_003Ek__BackingField;
                }
            }

            public float EndAngle
            {
                [CompilerGenerated]
                get
                {
                    return _003CEndAngle_003Ek__BackingField;
                }
            }

            public float Threshold
            {
                [CompilerGenerated]
                get
                {
                    return _003CThreshold_003Ek__BackingField;
                }
            }

            public CrossDirectionData(float threshold, CrossFlickDirection flickDirection)
            {
            }

            public override string ToString()
            {
                return null;
            }
        }

        [CompilerGenerated]
        private Action m_onBeginDragCallback;
        [CompilerGenerated]
        private Action m_onDragCallback;
        [CompilerGenerated]
        private Action m_onEndDragCallback;
        [CompilerGenerated]
        private Action<CrossFlickDirection> m_onFlickCallback;
        [SerializeField]
        private float _threshold;
        private IList<IFlickDirectionData> _directions;
        public float Threshold
        {
            get
            {
                return default(float);
            }

            set
            {
            }
        }

        public event Action onBeginDragCallback
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public event Action onDragCallback
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public event Action onEndDragCallback
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public event Action<CrossFlickDirection> onFlickCallback
        {
            [CompilerGenerated]
            add
            {
            }

            [CompilerGenerated]
            remove
            {
            }
        }

        public override IList<IFlickDirectionData> GetFlickDirections()
        {
            return null;
        }

        protected override void OnFlick(PointerEventData eventData, IFlickDirectionData[] flicks)
        {
        }

        protected override void BeginDragEvent(PointerEventData eventData)
        {
        }

        protected override void DragEvent(PointerEventData eventData)
        {
        }

        protected override void EndDragEvent(PointerEventData eventData)
        {
        }

        public CrossFlickGesture()
        {
        }
    }
}
