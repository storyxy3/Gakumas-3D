namespace Qua.UI
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::Qua.UI;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    public class CustomArcFlickGesture : FlickGestureBase
    {
        [CompilerGenerated]
        private Action m_onBeginDragCallback;
        [CompilerGenerated]
        private Action m_onDragCallback;
        [CompilerGenerated]
        private Action m_onEndDragCallback;
        [CompilerGenerated]
        private Action<CustomArcFlickDirectionData> m_onFlickCallback;
        [CompilerGenerated]
        private Action<CustomArcFlickDirectionData[]> m_onFlicksCallback;
        [SerializeField]
        private CustomArcFlickDirectionData[] _flickDataList;
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

        public event Action<CustomArcFlickDirectionData> onFlickCallback
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

        public event Action<CustomArcFlickDirectionData[]> onFlicksCallback
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

        public CustomArcFlickGesture()
        {
        }
    }
}
