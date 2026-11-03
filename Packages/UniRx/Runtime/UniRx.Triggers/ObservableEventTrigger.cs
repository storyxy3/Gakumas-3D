namespace UniRx.Triggers
{
    using global::System;
    using global::UniRx;
    using global::UniRx.Triggers;
    using global::UnityEngine;
    using global::UnityEngine.EventSystems;

    [DisallowMultipleComponent]
    public class ObservableEventTrigger : ObservableTriggerBase, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IInitializePotentialDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
    {
        private Subject<BaseEventData> onDeselect;
        private Subject<AxisEventData> onMove;
        private Subject<PointerEventData> onPointerDown;
        private Subject<PointerEventData> onPointerEnter;
        private Subject<PointerEventData> onPointerExit;
        private Subject<PointerEventData> onPointerUp;
        private Subject<BaseEventData> onSelect;
        private Subject<PointerEventData> onPointerClick;
        private Subject<BaseEventData> onSubmit;
        private Subject<PointerEventData> onDrag;
        private Subject<PointerEventData> onBeginDrag;
        private Subject<PointerEventData> onEndDrag;
        private Subject<PointerEventData> onDrop;
        private Subject<BaseEventData> onUpdateSelected;
        private Subject<PointerEventData> onInitializePotentialDrag;
        private Subject<BaseEventData> onCancel;
        private Subject<PointerEventData> onScroll;
        void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnDeselectAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IMoveHandler.OnMove(AxisEventData eventData)
        {
        }

        public IObservable<AxisEventData> OnMoveAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerDownAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerEnterAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerExitAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerUpAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.ISelectHandler.OnSelect(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnSelectAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnPointerClickAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnSubmitAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnDragAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnBeginDragAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnEndDragAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnDropAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnUpdateSelectedAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnInitializePotentialDragAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.ICancelHandler.OnCancel(BaseEventData eventData)
        {
        }

        public IObservable<BaseEventData> OnCancelAsObservable()
        {
            return null;
        }

        void UnityEngine.EventSystems.IScrollHandler.OnScroll(PointerEventData eventData)
        {
        }

        public IObservable<PointerEventData> OnScrollAsObservable()
        {
            return null;
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
        }

        public ObservableEventTrigger()
        {
        }
    }
}
